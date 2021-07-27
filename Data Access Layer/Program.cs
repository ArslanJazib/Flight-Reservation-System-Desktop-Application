//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccessLayer
//{
//    public class Program
//    {
//        static void Main()
//        {
//            bool just_sign_up = true; /*If user just wants to sign up only
//            the passenger list will be updated on exit*/

//            FileHandler fileHandler = new FileHandler();/*Calling the defualt constructor
//            of the file handler to get all records from passenger list*/

//            SeatsMatrix temp = new SeatsMatrix(); /* Calling the default constructor of the
//            seat matrix class get all records from flight list*/

//            int MainChoice =0;
//            string welcome= "Seat Reservation System";
//            Console.Write(new string(' ', (Console.WindowWidth - welcome.Length) / 2));
//            Console.WriteLine(welcome);
//            do
//            {
//                Console.WriteLine("Press 1 to Log In");
//                Console.WriteLine("Press 2 to Sign Up");
//                Console.Write("Your Choice: ");
//                MainChoice = int.Parse(Console.ReadLine());
//                if (MainChoice == 1)
//                {
//                    Console.Clear();
//                    MainChoice = 0;
//                    Passengers ExistingPassenger = new Passengers(fileHandler.PassengerList);/*Using the 
//                    filsehandler object to refer all the records in passenger list to object */

//                    if (ExistingPassenger.LogIN_Confirmation() == true)
//                    {
//                        do
//                        {                           
//                            int SecondChoice = 0;
//                            Console.Clear();
//                            Console.WriteLine("Press 1 to check seat status");
//                            Console.WriteLine("Press 2 to reserve a seat");
//                            Console.WriteLine("Press 3 to cancel reservation");
//                            Console.Write("Your Choice: ");
//                            SecondChoice = int.Parse(Console.ReadLine());
//                            if (SecondChoice == 1)
//                            {
//                                ExistingPassenger.CheckAll_Seats();
//                            }
//                            else if (SecondChoice == 2)
//                            {
//                                ExistingPassenger.book_seat();
//                                just_sign_up = false;

//                            }
//                            else if (SecondChoice == 3)
//                            {
//                                ExistingPassenger.CancelReservation();
//                                just_sign_up = false;
//                            }
//                            else
//                            {
//                                Console.WriteLine("Wrong Choice Try Again");
//                            }

//                            Console.WriteLine("\nPress 1 if you want to go to Main Menu ");
//                            Console.WriteLine("\nPress any other key to exit ");
//                            Console.Write("Your Choice: ");
//                            MainChoice = int.Parse(Console.ReadLine());
//                        } while (MainChoice == 1);
//                    }                    
//                }
//                else if (MainChoice == 2)
//                {
//                    Passengers newPassenger = new Passengers(fileHandler.PassengerList);
//                    newPassenger.SignUP();
                    
//                }
//                Console.WriteLine("\nPress 1 if you want to go to Login screen ");
//                Console.Write("\nPress any other key if you want to exit ");
//                Console.Write("Your Choice: ");
//                MainChoice = int.Parse(Console.ReadLine());
                
//            } while (MainChoice == 1);

//            Passengers.exit(just_sign_up, fileHandler.PassengerList);
//        }
//    }
//}
