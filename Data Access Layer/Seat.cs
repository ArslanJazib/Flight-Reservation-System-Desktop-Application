using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace DataAccessLayer
{
    public  class Seat
    {
        public Passengers to_be_seated = new Passengers(); /*This attribute will hold name & cnic
        of the person who is on the flight*/

        public KeyValuePair<string, bool> onePair = new KeyValuePair<string, bool>("0", false);
        /*This attribute is a key value pair representing each seat name as key & value to represents if it's 
        filled or not True=Filled*/

        public Passengers SeatSelector = new Passengers();/*This attribute will hold the name & cnic
        of the person who reserving a seat for someone else*/

        public Seat() // Default Constructor
        {
            to_be_seated.Cnic = "Unknown";
            to_be_seated.Name = "Unknown";
        }


    }
}
