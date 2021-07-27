using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class InputOutputHandler
    {
        // Confirm Passenger Function
        public static bool ConfirmPassenger(List<Passengers> Passenger_List,Passengers Existing)
        {
            bool status = false; // returning status to allow log in

            if (Passenger_List.Count != 0) // If the passenger list is not empty
            {
                string cnic;
                string name;
                Console.Write("Enter CNIC: ");
                cnic = Console.ReadLine();

                Console.Write("Enter Name: ");
                name = Console.ReadLine();

                for (int index = 0; index < Passenger_List.Count; index++)
                {
                    if (Passenger_List[index].Cnic == cnic)
                    {
                        if (Passenger_List[index].Name == name)
                        {
                            status = true;
                            /* if the entered information is correct assign the information
                            to current user's passenger object*/
                            Existing.Cnic = cnic;
                            Existing.Name = name;
                        }
                        else if (status == false)
                        {
                            Console.WriteLine("Wrong Name Entered Please Try Again ");
                        }
                        return status;
                    }
                    else
                    {
                        Console.WriteLine("Wrong CNIC Entered Please Try Again ");
                    }
                }
                return status;
            }
            else
            {
                Console.WriteLine("No user exists in the system register to Log In");
                return status;
            }
        }

        // Get Passenger Function 
        public static Passengers GetPassenger(List<Passengers> Passenger_List,Passengers SeatSelector)
        {
            bool status = true;
            bool status2 = false; 
            int go_back_choice;
            Passengers customer = new Passengers();
            string cnic;
            string name;
            if (Passenger_List.Count != 0)
            {
                do
                {
                    Console.Clear();
                    Console.Write("Enter CNIC: ");
                    cnic = Console.ReadLine();
                    Console.Write("Enter Name: ");
                    name = Console.ReadLine();

                    if (SeatSelector.Cnic == cnic & SeatSelector.Name == name) /*If the user enteres
                        his own information when making a reservation*/
                    {
                        Console.WriteLine("You entered you own information");
                        do
                        {
                            //Console.Clear();
                            Console.WriteLine("Press 1 if you are reserving a seat for yourself");
                            Console.WriteLine("Press 2 if you are reserving a seat for someone else");
                            Console.Write("Your choice: ");
                            go_back_choice = int.Parse(Console.ReadLine());
                            if (go_back_choice == 1)
                            {
                                return SeatSelector;
                            }
                            else if (go_back_choice == 2)
                            {
                                status = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Wrong Choice");
                                status2 = true;
                            }
                        } while (status2 == true);
                    }
                } while (status == false);
                
                // If passenger exits return his data
                for (int index = 0; index < Passenger_List.Count; index++)
                {
                    if (Passenger_List[index].Cnic == cnic)
                    {
                        if (Passenger_List[index].Name == name)
                        {
                            status = true;
                            return customer= Passenger_List[index];
                        }
                        else if (status == false)
                        {
                            Console.WriteLine("Wrong Name Entered Please Try Again ");
                        }
                    }
                }
                return customer;
            }
            else //If the file is empty take to sign up screen
            {
                Console.WriteLine("No user exists in the system register to Log In");
                customer = InputOutputHandler.getPassengerInfo(Passenger_List);
                Passenger_List.Add(customer);

            }
            return customer;
        }

        // Get Passenger Information Function
        public static Passengers getPassengerInfo(List<Passengers> Passenger_List)
        {
            bool validation = false; // For checking CNIC to avoid repetition
            Passengers passenger = new Passengers();

            // Loop to keep asking for the CNIC in case if CNIC already exists
            do
            {
                Console.Clear();
                Console.Write("Enter CNIC: ");
                passenger.Cnic = Console.ReadLine();
                int count = Passenger_List.Count;
                validation = Check_CNIC(passenger, count, Passenger_List); //Function to compare input with the Present data

                if (validation == true) // If the CNIC entered is unique then take other inputs
                {
                    Console.Write("Enter Name: ");
                    passenger.Name = Console.ReadLine();
                    return passenger;

                }
                else
                {
                    Console.WriteLine("Passenger already has an account: ");
                }
                Console.WriteLine("------------------------\n");


            } while (validation == false);
            return passenger;
        }

        // Check CNIC
        public static bool Check_CNIC(Passengers passenger, int count, List<Passengers> Passenger_List)
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

        // Displaying All Passengers
        public static void DisplayAllUsers(List<Passengers> Passenger_List)
        {
            for (int index = 0; index < Passenger_List.Count; index++)
            {
                Console.WriteLine("CNIC : "+ Passenger_List[index].Cnic);
                Console.WriteLine("Name : " + Passenger_List[index].Name);
            }
        }

        //// Updating Passenger File Function
        //public static void Updatefile(List<Passengers> Passenger_List)
        //{
            
        //    for (int index = 0; index < Passenger_List.Count; index++)
        //    {
        //        FileHandler.UpdateFile(Passenger_List[index]);
                
        //    }
        //}
        //// Updating Fligt File Function
        //public static void UpdatefileFlight(Seat[,] Matrix)
        //{
        //    /* The current matrix is traversed and the filled seats are
        //     are passed to file handler to write their data in the file*/
        //        for (int rows = 0; rows < 6; rows++)
        //        {
        //        for (int cols = 0; cols < 4; cols++)
        //        {
        //            if (Matrix[rows, cols].onePair.Value == true)
        //            {

        //                        FileHandler.UpdateFileFlight(Matrix[rows, cols]);
                            
                        
        //            }
        //        }

        //        }
            
        //}
    }
}
