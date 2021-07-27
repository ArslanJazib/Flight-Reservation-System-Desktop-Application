using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DataAccessLayer
{

    public class Passengers
    {
        List<Passengers> Passenger_List;
        string name;
        string cnic;
        bool check=false;
        bool check2 = false;
        public Passengers()
        {
            name = "Unknown";
            cnic = "Unknown";

        }
        public Passengers(List<Passengers> File_Passenger_List)
        {
            Passenger_List = File_Passenger_List;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Cnic
        {
            get { return cnic; }
            set { cnic = value; }
        }
        public string getData()
        {
            string data = " ";
            data += "CNIC: ";
            data += "Name: ";
            return data;

        }

        public byte LogIN_Confirmation(string input_cnic, string input_name, Passengers Existing)
        {
            byte status = 0; // returning status to allow log in
            if (Passenger_List.Count != 0) // If the passenger list is not empty
            {
                for (int index = 0; index < Passenger_List.Count; index++)
                {
                    if (Passenger_List[index].Cnic == input_cnic)
                    {
                        if (Passenger_List[index].Name == input_name)
                        {
                            status = 0;
                            /* if the entered information is correct assign the information
                            to current user's passenger object*/
                            Existing.Cnic = input_cnic;
                            Existing.Name = input_name;
                        }
                        else if (status == 0)
                        {
                            status = 1;// If name is not in the list
                        }
                        return status;
                    }
                    else
                    {
                        status = 2;// if cnic is not in the list
                    }
                }
                return status;
            }
            else
            {
                status = 3; // if both are not in the list
                return status;
            }
        }

        public bool SignUP(string cnic,string name)
        {
            Passengers newPassenger = new Passengers();
            newPassenger.cnic = cnic;
            newPassenger.name = name;
            bool status=getPassengerInfo(cnic, name);
            if(status==true)
            {
                Passenger_List.Add(newPassenger);
                return true;
            }
            else
            {
                return false;
            }

        }
        public  void exit(ref int counter,ref int flight_counter)
        {
                Updatefile(this.Passenger_List, ref counter);
                UpdatefileFlight(SeatsMatrix.ReturnMatrix(), ref flight_counter);
            
        }
        public byte GetPassenger(string input_cnic, string input_name)
        {
            bool status = true;
            byte result = 3;
            if (Passenger_List.Count != 0)
            {
                // If passenger exists return his data
                for (int index = 0; index < Passenger_List.Count; index++)
                {
                    if (Passenger_List[index].Cnic == input_cnic)
                    {
                        if (Passenger_List[index].Name == input_name)
                        {
                            status = true;
                            result = 0;
                            return result;
                        }
                        else if (status == false)
                        {
                            result = 1;
                            return result;
                        }
                    }
                    else if (status == false)
                    {
                        result = 2;
                        return result;
                    }
                }
                return result;
            }
            else //If the file is empty take to sign up screen
            {
                result = 2;
                return result;
            }
        }

        public KeyValuePair<List<Seat>, List<int>> book_seat(string cnic, string name, bool self_reservation, bool other_reservation, bool left_side,
        bool right_side, bool window_side, bool aisle_side, ref int staticrows)
        {
            KeyValuePair<List<Seat>, List<int>> temp = new KeyValuePair<List<Seat>, List<int>>();
            List<byte> choices = SeatsMatrix.SeatReservation(this.Passenger_List, this, self_reservation, other_reservation, left_side,
            right_side, window_side, aisle_side, cnic, name);
            if (choices[0] == 1)
            {
                if (choices[1] == 1)
                {
                    KeyValuePair<List<Seat>, List<int>> AvaiableSeats = SeatsMatrix.Left_Window_display();
                    return AvaiableSeats;

                }
                else if (choices[1] == 2)
                {
                    KeyValuePair<List<Seat>, List<int>> AvaiableSeats = SeatsMatrix.Left_Aisle_display();
                    return AvaiableSeats;
                }
            }
            else if (choices[0] == 2)
            {
                if (choices[1] == 1)
                {
                    KeyValuePair<List<Seat>, List<int>> AvaiableSeats = SeatsMatrix.Right_Window_display();
                    return AvaiableSeats;

                }
                else if (choices[1] == 2)
                {
                    KeyValuePair<List<Seat>, List<int>> AvaiableSeats = SeatsMatrix.Right_Aisle_display();
                    return AvaiableSeats;
                }
            }

            return temp;
        }
        public Seat CheckAll_Seats(int rows, int cols)
        {
            return SeatsMatrix.LoadAllSeats(this, rows, cols);

        }
        public bool CancelReservation(int rows, int cols)
        {
            bool status = SeatsMatrix.CancelReservation(this.Passenger_List, this, rows, cols);
            if (status == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void total_seats(ref int total_seats)
        {
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
                        total_seats++;

                    }
                }
            }
        }
        public bool Check_All_Filled()
        {
            bool check = SeatsMatrix.Check_All_Seats();
            return check;
        }

        // Get Passenger Information Function
        public bool getPassengerInfo(string cnic, string name)
        {
            bool validation = false; // For checking CNIC to avoid repetition
            Passengers passenger = new Passengers();
            passenger.Cnic = cnic;
            int count = this.Passenger_List.Count;
            validation = this.Check_CNIC(passenger, count, Passenger_List); //Function to compare input with the Present data
            if (validation == true) // If the CNIC entered is unique then take other inputs
            {
                passenger.Name = name;
                return true;

            }
            else
            {
                return false;
            }

        }
        // Check CNIC
        public bool Check_CNIC(Passengers passenger, int count, List<Passengers> Passenger_List)
        {
            // Function to Compare user's input with the CNIC present in file
            bool validation = true;
            for (int index = 0; index < count; index++)
            {
                if (Passenger_List[index].Cnic == passenger.Cnic)
                {
                    validation = false;
                }
            }
            return validation;
        }
        // Updating Passenger File Function
        public void Updatefile(List<Passengers> Passenger_List,ref int counter)
        {
            if(check==false)
            {
                check = true;
                for (int index = 0; index < Passenger_List.Count; index++)
                {
                    FileHandler.UpdateFile(Passenger_List[index], ref counter);

                }
            }
            else
            {
                counter = 0;
                check = false;
                Updatefile(Passenger_List, ref counter);
            }
        }
        // Updating Fligt File Function
        public void UpdatefileFlight(Seat[,] Matrix,ref int flight_counter)
        {
            if (check2 == false)
            {
                check2 = true;
                bool flag = false;
                /* The current matrix is traversed and the filled seats are
                 are passed to file handler to write their data in the file*/
                for (int rows = 0; rows < 6; rows++)
                {
                    for (int cols = 0; cols < 4; cols++)
                    {
                        if (Matrix[rows, cols].onePair.Value == true)
                        {
                            flag = true;
                            FileHandler.UpdateFileFlight(Matrix[rows, cols], ref flight_counter);


                        }
                    }

                }
                if (flag == false)
                {
                    StreamWriter clear = new StreamWriter("Flight.txt");
                    clear.Flush();
                    clear.Close();
                }
            }
            else
            {
            
                    flight_counter = 0;
                    check2 = false;
                    UpdatefileFlight(Matrix, ref flight_counter);
                
            }
        }




    }



    
}
