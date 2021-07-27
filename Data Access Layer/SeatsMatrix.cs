using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SeatsMatrix : Seat
    {
        protected internal Dictionary<string, bool> All_Seats = new Dictionary<string, bool>(20);/*Creating
        a dictionary to hold all the key:value pairs represting every seat the size is 20 because
        4 seats are unavailable for booking*/

        static public int DictonaryIndex = 0;/*Using this variable to iterate the dictionary for 
        initializing the seats in the matrix with key:value pairs*/

        public static Seat[,] Matrix = new Seat[6, 4];/*Creating a 2d array represting the seats on the plan
        there 24 seats on the plan 4 seats are unavailable for booking*/

        static int filledSeats_flag = 24; //To check if the plane is completely filled or not
        static bool flag = false; // To compare with the value of the seat representing it's status
        static bool passenger_flag = false; // To check if the passenger is in passenger list
        static List<int> free_rows = new List<int>(); /*This list will hold the number of free seats*/
        static List<int> filled_rows = new List<int>(); // To hold the total number of filled seats

        public SeatsMatrix() //Default Constructor
        {
            // initializing each key:value pair in the dictionary 
            All_Seats.Add("71A", false);
            All_Seats.Add("71B", false);
            All_Seats.Add("72A", false);
            All_Seats.Add("72B", false);
            All_Seats.Add("72C", false);
            All_Seats.Add("72D", false);
            All_Seats.Add("73A", false);
            All_Seats.Add("73B", false);
            All_Seats.Add("73C", false);
            All_Seats.Add("73D", false);
            All_Seats.Add("74A", false);
            All_Seats.Add("74B", false);
            All_Seats.Add("74C", false);
            All_Seats.Add("74D", false);
            All_Seats.Add("75A", false);
            All_Seats.Add("75B", false);
            All_Seats.Add("75C", false);
            All_Seats.Add("75D", false);
            All_Seats.Add("76A", false);
            All_Seats.Add("76B", false);

            // Filling each index in the 2d array with the seat objects by calling seat default constructor
            for (int rows = 0; rows < 6; rows++)
            {
                for (int cols = 0; cols < 4; cols++)
                {
                    Matrix[rows, cols] = new Seat();
                }
            }

            // Filling each seat in the 2d array with their respective key:value pairs
            for (int rows = 0; rows < 6; rows++)
            {
                for (int cols = 0; cols < 4; cols++)
                {
                    // Ignoring the unavailable seats 
                    if ((rows == 0 & cols > 1) || (rows == 5 & cols > 1))
                    {
                        continue;
                    }
                    else
                    {
                        if (DictonaryIndex < 20)
                        {
                            Matrix[rows, cols].onePair = All_Seats.ElementAt(DictonaryIndex);
                            DictonaryIndex++;
                        }
                    }

                }
            }
            // If the flight file is not empty then storing the previous records in the current matrix
            if (FileHandler.EmptyFileConformation() == false)
            {
                FileHandler.GetFlightInfo(Matrix);
            }
            bool check = Check_All_Seats();
            if (check == false)
            {
                Console.WriteLine("Ready to take off");

            }

        }

        public SeatsMatrix(int temporary) //Parameterized constructor
        {
            /*Parameterized constructor used create another marix to hold the data of each record
             in the file temporarily*/
        }

        // Seat Reservation
        public static List<byte> SeatReservation(List<Passengers> Passenger_List, Passengers SeatSelector, bool self_reservation, bool other_reservation, bool left_side,
        bool right_side, bool window_side, bool aisle_side, string cnic, string name)
        {
            List<byte> choices = new List<byte>();
            byte side_choice = 0;
            byte seat_choice = 0;
            int user_choice = 0;
            Passengers seat_reserver = new Passengers(); //Passenger to be seated
            bool same_reservation = false; // To check if the user reserving a seat for him/her self
            bool onlyone_flag = false; //To check if the user is already seated or not
            if (self_reservation == true)
            {
                user_choice = 1;
            }
            if (other_reservation == true)
            {
                user_choice = 2;
            }
            // If user is reserving a seat for him/her self
            if (user_choice == 1)
            {
                same_reservation = true;

                // To check if the user is already seated or not
                for (int rows = 0; rows < 6; rows++)
                {
                    for (int cols = 0; cols < 4; cols++)
                    {
                        if (Matrix[rows, cols] != null)
                        {
                            if (Matrix[rows, cols].onePair.Value == true)
                            {
                                if (Matrix[rows, cols].to_be_seated.Cnic == SeatSelector.Cnic)
                                {
                                    onlyone_flag = true;
                                }
                            }
                        }
                    }
                }
            }

            // If user is booking for someone else
            else if (user_choice == 2)
            {
                // Getting the passenger info
                seat_reserver.Cnic = cnic;
                seat_reserver.Name = name;


                // To check if the person is already seated or not
                for (int rows = 0; rows < 6; rows++)
                {
                    for (int cols = 0; cols < 4; cols++)
                    {
                        if (Matrix[rows, cols] != null)
                        {
                            if (Matrix[rows, cols].onePair.Value == true)
                            {
                                if (Matrix[rows, cols].to_be_seated.Cnic == seat_reserver.Cnic)
                                {
                                    onlyone_flag = true;
                                }
                            }
                        }

                    }



                }

            }
            // If the person is not seated and and is already registered set flag to true
            if (onlyone_flag == false)
            {
                for (int index = 0; index < Passenger_List.Count; index++)
                {
                    if (same_reservation == true)
                    {
                        passenger_flag = true;
                        break;
                    }
                    else
                    {
                        if (seat_reserver.Cnic == (Passenger_List[index].Cnic))
                        {
                            passenger_flag = true;
                            break;
                        }
                    }

                }

                // If the user is not in passenger list ask him/her to sign up
                if (passenger_flag == false)
                {
                    side_choice = 0;
                    seat_choice = 0;
                    choices.Add(side_choice);
                    choices.Add(seat_choice);
                }

                //Asking person to choose the side of the plane on which he/she wants to make a reservation
                if (left_side == true)
                {
                    side_choice = 1;
                    choices.Add(side_choice);
                }
                else if (right_side == true)
                {
                    side_choice = 2;
                    choices.Add(side_choice);
                }
                // Left Side of the plane
                if (side_choice == 1)
                {
                    if (window_side == true)
                    {
                        seat_choice = 1;
                        choices.Add(seat_choice);
                    }
                    else if (aisle_side == true)
                    {
                        seat_choice = 2;
                        choices.Add(seat_choice);

                    }

                }
                // Right Side of the plane
                else if (side_choice == 2)
                {
                    if (window_side == true)
                    {
                        seat_choice = 1;
                        choices.Add(seat_choice);
                    }
                    else if (aisle_side == true)
                    {
                        seat_choice = 2;
                        choices.Add(seat_choice);

                    }

                }
            }
            else
            {
                side_choice = 0;
                seat_choice = 0;
                choices.Add(side_choice);
                choices.Add(seat_choice);

            }
            return choices;
        }

        //Show Status Function
        public static void ShowSeatStatus(Passengers user)
        {
            Console.Clear();
            Console.WriteLine("True = Filled\n");
            for (int rows = 0; rows < 6; rows++)
            {
                for (int cols = 0; cols < 4; cols++)
                {
                    if ((rows == 0 & cols > 1) || (rows == 5 & cols > 1))
                    {
                        continue;  // Ignoring the unavailable seats 
                    }
                    else
                    {

                        Console.WriteLine("Row: " + rows + "\tCol:  " + cols + "\t" + Matrix[rows, cols].onePair);

                        // If someone is sitting on the plane showing their status
                        if (Matrix[rows, cols].onePair.Value == true)
                        {
                            if (Matrix[rows, cols].SeatSelector != null)
                            {
                                if (Matrix[rows, cols].SeatSelector.Cnic == user.Cnic)
                                {
                                    Console.WriteLine("Passenger CNIC: " + Matrix[rows, cols].to_be_seated.Cnic
                               + "\tPassenger Name: " + Matrix[rows, cols].to_be_seated.Name);
                                }

                            }
                            if (Matrix[rows, cols].to_be_seated.Cnic == user.Cnic)
                            {
                                Console.WriteLine("Passenger CNIC: " + user.Cnic
                                + "\tPassenger Name: " + user.Name);
                            }

                        }

                    }
                    Console.WriteLine();
                }
            }
        }

        // Cancel Reservation Function
        public static bool CancelReservation(List<Passengers> Passenger_List, Passengers Canceling,int rows,int cols)
        {
            //for (int rows = 0; rows < 6; rows++)
            //{
            //    for (int cols = 0; cols < 4; cols++)
            //    {
            //        if (Matrix[rows, cols].SeatSelector.Cnic != null) /* If there is seat selector 
            //        which means there was a reservation for someone else*/
            //        {
            //            if (Matrix[rows, cols].SeatSelector.Cnic == Canceling.Cnic) /* If the current
            //            user is the seat selector of any seat he/she can cancel the reservation*/
            //            {
            //                if (Matrix[rows, cols].onePair.Value == true)
            //                {
            //                    // Stroing the index of the reserved seat
            //                    filled_rows.Add(rows);
            //                    filled_rows.Add(cols);
            //                }
            //            }
            //        }
            //        else
            //        {
            //            if (Matrix[rows, cols].onePair.Value == true)
            //            {
            //                if (Matrix[rows, cols].to_be_seated.Cnic == Canceling.Cnic)/* If the current
            //                user is the passenger he/she can cancel the reservation*/
            //                {
            //                    // Stroing the index of the reserved seat
            //                    filled_rows.Add(rows);
            //                    filled_rows.Add(cols);
            //                }
            //            }
            //        }
            //    }
            //}


                    if (Matrix[rows,cols].SeatSelector.Cnic != null) /*If the
                        choosen seat has a selector then the reservation was for someone else*/
                    {
                        if (Matrix[rows, cols].SeatSelector.Cnic == Canceling.Cnic)/* If
                            the current user is the seat selector of any seat he/she can cancel the reservation*/
                        {
                            // Making a new KeyValuePair to turn change the value/status of the selected key to false represeting empty
                            Matrix[rows, cols].onePair = new KeyValuePair<string, bool>(Matrix[rows, cols].onePair.Key, false);
                            Matrix[rows, cols].to_be_seated.Cnic = null;
                            Matrix[rows, cols].to_be_seated.Name = null;
                            Matrix[rows, cols].SeatSelector = null;
                            return true;
                        }
                    }
                    else // If the current user wants to cancel his own seat reservation
                    {
                        if (Matrix[rows, cols].to_be_seated.Cnic == Canceling.Cnic)
                        {
                            Matrix[rows, cols].onePair = new KeyValuePair<string, bool>(Matrix[rows, cols].onePair.Key, false);
                            Matrix[rows, cols].to_be_seated.Cnic = null;
                            Matrix[rows, cols].to_be_seated.Name = null;
                            // SeatSelector is already null for someone who reserved his own seat
                            return true;
                        }
                    }
                    return false;
                
            


        }

        // Passing the current matrix to file for writing data in file when closing the application
        public static Seat[,] ReturnMatrix()
        {
            return Matrix;
        }

        // Check All Seats Function
        public static bool Check_All_Seats()
        {
            int filledSeats_flag = 20;
            bool status;
            for (int rows = 0; rows < 6; rows++)
            {
                for (int cols = 0; cols < 4; cols++)
                {
                    if (Matrix[rows, cols].onePair.Value == true)
                    {
                        --filledSeats_flag;
                    }
                }
            }
            if (filledSeats_flag == 0)
            {
                status = false;
            }
            else
            {
                status = true;
            }
            return status;
        }

        public static Seat LoadAllSeats(Passengers user,  int rows,  int cols)
        {
            bool flag = false;
            for (int r = rows; r < 6;)
            {
                for (int c = cols; c < 4;)
                {
                    // Ignoring the unavailable seats 
                    if ((rows == 0 & cols > 1) || (rows == 5 & cols > 1))
                    {
                        flag = true; ;
                    }
                    if(flag==true)
                    {
                        return Matrix[0, 1];
                    }
                    else
                    {
                        return Matrix[rows, cols];
                        
                    }

                }

            }
            return Matrix[0, 1];
        }

        public static KeyValuePair<List<Seat>, List<int>> Left_Window_display()
        {
            int cols = 3; // Accoring to our plane Left-Window seats are on 3rd column
            int index = 16; //Using to make a numbered list for the user
            List<Seat> Free_Seat = new List<Seat>();
            List<int> reserved_Seats = new List<int>();
            KeyValuePair<List<Seat>, List<int>> Seats = new KeyValuePair<List<Seat>, List<int>>();
            free_rows = new List<int>();
            for (int rows = 1; rows <= 4; rows++)
            {
                if (Matrix[rows, cols].onePair.Value == flag)
                {
                    free_rows.Add(index);
                    Free_Seat.Add(Matrix[rows, cols]);
                    index++;
                }
                else
                {
                    reserved_Seats.Add(index);
                    index++;
                    --filledSeats_flag; /* If the seat filled reduce the total aviabale
                                    seats by one*/
                }

            }
            Seats = new KeyValuePair<List<Seat>, List<int>>(Free_Seat,reserved_Seats);
            return Seats;
        }
        public static KeyValuePair<List<Seat>, List<int>> Left_Aisle_display()
        {
            int cols = 2; // Accoring to our plane Left-Aisle seats are on 2nd column
            int index = 12;
            List<Seat> Free_Seat = new List<Seat>();
            List<int> reserved_Seats = new List<int>();
            KeyValuePair<List<Seat>, List<int>> Seats = new KeyValuePair<List<Seat>, List<int>>();
            free_rows = new List<int>();
            for (int rows = 1; rows <= 4; rows++)
            {
                if (Matrix[rows, cols].onePair.Value == flag)
                {
                    free_rows.Add(index);
                    Free_Seat.Add(Matrix[rows, cols]);
                    index++;
                }
                else
                {
                    reserved_Seats.Add(index);
                    index++;
                    --filledSeats_flag; /* If the seat filled reduce the total aviabale
                                    seats by one*/
                }

            }
            Seats = new KeyValuePair<List<Seat>, List<int>>(Free_Seat, reserved_Seats);
            return Seats;
        }
        public static KeyValuePair<List<Seat>, List<int>> Right_Window_display()
        {
            int cols = 0;
            int index = 0;
            List<Seat> Free_Seat = new List<Seat>();
            List<int> reserved_Seats = new List<int>();
            KeyValuePair<List<Seat>, List<int>> Seats = new KeyValuePair<List<Seat>, List<int>>();
            free_rows = new List<int>();
            for (int rows = 0; rows <= 5; rows++)
            {
                if (Matrix[rows, cols].onePair.Value == flag)
                {
                    free_rows.Add(index);
                    Free_Seat.Add(Matrix[rows, cols]);
                    index++;
                }
                else
                {
                    reserved_Seats.Add(index);
                    index++;
                    --filledSeats_flag; /* If the seat filled reduce the total aviabale
                                    seats by one*/
                }

            }
            Seats = new KeyValuePair<List<Seat>, List<int>>(Free_Seat, reserved_Seats);
            return Seats;
        }
        public static KeyValuePair<List<Seat>, List<int>> Right_Aisle_display()
        {
            int cols = 1;
            int index = 6;
            List<Seat> Free_Seat = new List<Seat>();
            List<int> reserved_Seats = new List<int>();
            KeyValuePair<List<Seat>, List<int>> Seats = new KeyValuePair<List<Seat>, List<int>>();
            free_rows = new List<int>();
            for (int rows = 0; rows <= 5; rows++)
            {
                if (Matrix[rows, cols].onePair.Value == flag)
                {
                    free_rows.Add(index);
                    Free_Seat.Add(Matrix[rows, cols]);
                    index++;
                }
                else
                {
                    reserved_Seats.Add(index);
                    index++;
                    --filledSeats_flag; /* If the seat filled reduce the total aviabale
                                    seats by one*/
                }

            }
            Seats = new KeyValuePair<List<Seat>, List<int>>(Free_Seat, reserved_Seats);
            return Seats;
        }
        public static bool Left_Window_selection(byte selected_row, Passengers SeatSelector, bool self_reservation, bool other_reservation, string cnic, string name)
        {
            if (filledSeats_flag > 0) // If there are seats available for reservation
            {
                int cols = 3;
                byte choice = selected_row;
                int index = 0; // Index is 0 because rows are starting from zero
                for (int rows = 1; rows <= 4; rows++)
                {
                    if (choice == (byte)(free_rows[index]))
                    {
                        if (Matrix[rows, cols].onePair.Value == flag)
                        {
                            Matrix[rows, cols].onePair = new KeyValuePair<string, bool>(Matrix[rows, cols].onePair.Key, true);
                            /*Making a new KeyValuePair having the seat status as true and the seat number as key*/

                            if (passenger_flag == true)
                            {
                                // If someone is making a reservation for him/her self there is no seat selector                                                   
                                if (self_reservation == true)
                                {
                                    Matrix[rows, cols].to_be_seated = SeatSelector;
                                    Matrix[rows, cols].SeatSelector = null;
                                    return true;
                                }

                                /*If the user is making a reservation for someone else store their data in seat selactor
                                 and the passengers data in to be seated*/
                                else if (other_reservation == true)
                                {
                                    Matrix[rows, cols].to_be_seated.Cnic = cnic;
                                    Matrix[rows, cols].to_be_seated.Name = name;
                                    Matrix[rows, cols].SeatSelector = SeatSelector;
                                    return true;
                                }

                            }

                            break;
                        }


                    }
                    else
                    {
                        index++;
                    }
                }
            }
            return false;
        }
        public static bool Left_Aisle_selection(byte selected_row, Passengers SeatSelector, bool self_reservation, bool other_reservation, string cnic, string name)
        {
            if (filledSeats_flag > 0) // If there are seats available for reservation
            {
                int cols = 2;
                byte choice = selected_row;
                int index = 0; // Index is 0 because rows are starting from zero
                for (int rows = 1; rows <= 4; rows++)
                {
                    if (choice == (byte)(free_rows[index]))
                    {
                        if (Matrix[rows, cols].onePair.Value == flag)
                        {
                            Matrix[rows, cols].onePair = new KeyValuePair<string, bool>(Matrix[rows, cols].onePair.Key, true);
                            /*Making a new KeyValuePair having the seat status as true and the seat number as key*/

                            if (passenger_flag == true)
                            {
                                // If someone is making a reservation for him/her self there is no seat selector                                                   
                                if (self_reservation == true)
                                {
                                    Matrix[rows, cols].to_be_seated = SeatSelector;
                                    Matrix[rows, cols].SeatSelector = null;
                                    return true;
                                }

                                /*If the user is making a reservation for someone else store their data in seat selactor
                                 and the passengers data in to be seated*/
                                else if (other_reservation == true)
                                {
                                    Matrix[rows, cols].to_be_seated.Cnic = cnic;
                                    Matrix[rows, cols].to_be_seated.Name = name;
                                    Matrix[rows, cols].SeatSelector = SeatSelector;
                                    return true;
                                }

                            }

                            break;
                        }


                    }
                    else
                    {
                        index++;
                    }
                }
            }
            return false;
        }
        public static bool Right_Window_selection(byte selected_row, Passengers SeatSelector, bool self_reservation, bool other_reservation, string cnic, string name)
        {
            int cols = 0;
            byte choice = selected_row;
            int index = 0;
                for (int rows = 0; rows <= 5; rows++) /* According to our plane you
                                 choose for 5 rows on the right side of plan */
                {
                    if (choice == (byte)(free_rows[index]))
                    {
                        if (Matrix[rows, cols].onePair.Value == flag)
                        {
                            Matrix[rows, cols].onePair = new KeyValuePair<string, bool>(Matrix[rows, cols].onePair.Key, true);
                            if (passenger_flag == true)
                            {
                                if (self_reservation == true)
                                {
                                    Matrix[rows, cols].to_be_seated = SeatSelector;
                                    Matrix[rows, cols].SeatSelector = null;
                                    return true;
                                }
                                else
                                {
                                Matrix[rows, cols].to_be_seated.Cnic = cnic;
                                Matrix[rows, cols].to_be_seated.Name = name;
                                Matrix[rows, cols].SeatSelector = SeatSelector;
                                return true;
                                }
                            }
                        }
                        break;
                    }
                    else
                    {
                        index++;
                    }
                }
            return false;
        }
        public static bool Right_Aisle_selection(byte selected_row, Passengers SeatSelector, bool self_reservation, bool other_reservation, string cnic, string name)
        {
            int cols = 1;
            byte choice = selected_row;
            int index = 0;
            for (int rows = 0; rows <= 5; rows++) /* According to our plane you
                                 choose for 5 rows on the right side of plan */
            {
                if (choice == (byte)(free_rows[index]))
                {
                    if (Matrix[rows, cols].onePair.Value == flag)
                    {
                        Matrix[rows, cols].onePair = new KeyValuePair<string, bool>(Matrix[rows, cols].onePair.Key, true);
                        if (passenger_flag == true)
                        {
                            if (self_reservation == true)
                            {
                                Matrix[rows, cols].to_be_seated = SeatSelector;
                                Matrix[rows, cols].SeatSelector = null;
                                return true;
                            }
                            else
                            {
                                Matrix[rows, cols].to_be_seated.Cnic = cnic;
                                Matrix[rows, cols].to_be_seated.Name = name;
                                Matrix[rows, cols].SeatSelector = SeatSelector;
                                return true;
                            }
                        }
                    }
                    break;
                }
                else
                {
                    index++;
                }
            }
            return false;
        }
    }
}





