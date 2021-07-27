using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DataAccessLayer
{
    public class FileHandler
    {
       public List<Passengers> Passenger_List;
        public List<Passengers> PassengerList
        {
            get
            {
                return Passenger_List;
            }
            set
            {
                Passenger_List = value;
            }
        }
        public FileHandler() // Default Constructor
        {
            // Reading all passenger records and referncing them to passenger class when program starts
            Passenger_List = new List<Passengers>();
            GetPassengerInfo(Passenger_List);

        }

        // Writing Passenger's information into file function
        public static void StorePassengerInfo(Passengers passenger)
        {
            StreamWriter writer = new StreamWriter("Passengers.txt",true);
            writer.WriteLine(passenger.Cnic);
            writer.WriteLine(passenger.Name);   
            writer.Close();
        }

        // Getting Passenger's information from file function
        public void GetPassengerInfo(List<Passengers> Passenger_List)
        {
            StreamReader reader = new StreamReader("Passengers.txt");
            while (!reader.EndOfStream)
            {
                Passengers passenger = new Passengers();
                passenger.Cnic = reader.ReadLine();
                passenger.Name = reader.ReadLine();
                PassengerList.Add(passenger);
            }
            reader.Close();
        }

        // Getting Flight information from file function
        public static void GetFlightInfo(Seat[,] Matrix)
        {
            int temporary = 0; /* An unsed variable to used to call the parameterized
            contructor the seats matrix class*/
            StreamReader reader = new StreamReader("Flight.txt");
            while (!reader.EndOfStream)
            {
                SeatsMatrix flightMatrix = new SeatsMatrix(temporary);
                /*Storing all the information file into chracter arrays to filter out labels*/
                char[] temp_cnic = (reader.ReadLine()).ToCharArray();
                char[] temp_name = (reader.ReadLine()).ToCharArray();
                char[] temp_seat = (reader.ReadLine()).ToCharArray();
                char[] temp_rcnic = (reader.ReadLine()).ToCharArray();
                char[] temp_rname = (reader.ReadLine()).ToCharArray();

                flightMatrix.to_be_seated.Cnic = null;
                flightMatrix.to_be_seated.Name = null;
                flightMatrix.onePair = new KeyValuePair<string, bool>(null, true);
                string temp_key = null; // Used to pass key to filematrix key 
                flightMatrix.SeatSelector.Cnic = null;
                flightMatrix.SeatSelector.Name = null;
                string temp_sname = null; // Used to check if the sear selector is none

                // Reading the cnic to flight matrix
                for (int index = 6; index < temp_cnic.Count(); index++)
                {
                    flightMatrix.to_be_seated.Cnic += temp_cnic[index];
                }

                // Reading the name to flight matrix
                for (int index = 6; index < temp_name.Count(); index++)
                {
                    flightMatrix.to_be_seated.Name += temp_name[index];
                }

                // Reading the seat to flight matrix
                for (int index = 6; index < temp_seat.Count(); index++)
                {
                    temp_key += temp_seat[index];
                }

                // Reading the seat status to true
                flightMatrix.onePair = new KeyValuePair<string, bool>(temp_key, true);

                // Reasing the seat selector cnic to flight matrix
                for (int index = 18; index < temp_rcnic.Count(); index++)
                {
                    if (temp_rcnic[index] == 'N') // If CNIC starts with "N" then it's none
                    {
                        flightMatrix.SeatSelector.Cnic = null;
                        break;
                    }
                    else
                    {
                        flightMatrix.SeatSelector.Cnic += temp_rcnic[index];
                    }
                }
                for (int index = 18; index < temp_rname.Count(); index++)
                {
                    // If the selector name is none
                    if (temp_rname[index] == 'N')
                    {
                        temp_sname = "N";
                        for (int index2 = 19; index2 <= 21; index2++)
                        {
                            temp_sname += temp_rname[index2];
                        }
                        if (temp_sname == "None")
                        {
                            flightMatrix.to_be_seated.Name += null;
                            break;
                        }

                    }
                    else
                    {
                        flightMatrix.SeatSelector.Name += temp_rname[index];
                    }
                }

                FileHandler.ReadAllSeats(flightMatrix,Matrix);
                
            }
            reader.Close();
            
        }

        // Writing the information in the flight file to current matrix
        public static void ReadAllSeats(SeatsMatrix flightMatrix, Seat[,] Matrix)
        {
            bool flag = false;
            for (int rows = 0; rows < 6; rows++)
            {
                for (int cols = 0; cols < 4; cols++)
                {
                    if ((rows == 0 & cols > 1) || (rows == 5 & cols > 1))
                    {
                        continue;
                    }
                    else
                    {
                        if(Matrix[rows, cols].onePair.Key==flightMatrix.onePair.Key)/*If the 
                        seat was in the flight file then write it's data in the current matrix*/
                        {
                            Matrix[rows, cols] = flightMatrix;
                            flag = true;
                            break;

                        }

                    }
                    
                }
                if (flag == true)
                {
                    break;
                }

            }
        }

        // Update Passenger List Function
        public static void UpdateFile(Passengers passenger,ref int counter)
        {
            if (counter == 0) // If file is never updated before clear it's content
            {
                StreamWriter clear = new StreamWriter("Passengers.txt");
                clear.Flush();
                clear.Close();
            }
            StorePassengerInfo(passenger);
            counter++;
        }

        // Update Flight List Function
        public static void UpdateFileFlight(Seat FlyingPassenger,ref int flight_counter)
        {
            if (flight_counter == 0) // If file is never updated before clear it's content
            {
                StreamWriter clear = new StreamWriter("Flight.txt");
                clear.Flush();
                clear.Close();
            }
            StoreFlightInfo(FlyingPassenger);
            flight_counter++;
        }

        // Writing the seat information into flight file
        public static void StoreFlightInfo(Seat FlyingPassenger)
        {
            StreamWriter writer = new StreamWriter("Flight.txt",true);
            writer.WriteLine("CNIC: "+ FlyingPassenger.to_be_seated.Cnic);
            writer.WriteLine("Name: "+ FlyingPassenger.to_be_seated.Name);
            writer.WriteLine("Seat: "+FlyingPassenger.onePair.Key);
            if(FlyingPassenger.SeatSelector!=null)
            {
                writer.WriteLine("Reserved By CNIC: " + FlyingPassenger.SeatSelector.Cnic);
                writer.WriteLine("Reserved By Name: " + FlyingPassenger.SeatSelector.Name);
            }
            else
            {
                writer.WriteLine("Reserved By CNIC: None");
                writer.WriteLine("Reserved By Name: None");
            }
           
            writer.Close();
        }

        // Checks if the flight file is empty
        public static bool EmptyFileConformation()
        {
            var status=new FileInfo("flight.txt");
            if (status.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
