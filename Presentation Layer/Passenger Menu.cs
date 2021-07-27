using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Passenger_Menu : Form
    {
        public Passenger_Menu()
        {
            InitializeComponent();
        }

        private void Passenger_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Seat_Status_MouseHover(object sender, EventArgs e)
        {

                string source = Environment.CurrentDirectory + @"\Seats Icon hover.png";
                Seat_Status_icon.ImageLocation = source;
                
        }

        private void Seat_Status_icon_Click(object sender, EventArgs e)
        {
            All_Seats all = new All_Seats();
            all.ModeCheck(false, true);
            this.Hide();
            all.Show();
        }

        private void Seat_Status_icon_MouseLeave(object sender, EventArgs e)
        {
            string source = Environment.CurrentDirectory + @"\Seats Icon.png";
            Seat_Status_icon.ImageLocation = source;
        }

        private void Book_Seat_icon_Click(object sender, EventArgs e)
        {
            Book_Seat seat = new Book_Seat();
            this.Hide();
            seat.Show();
        }

        private void Book_Seat_icon_MouseHover(object sender, EventArgs e)
        {
            string source = Environment.CurrentDirectory + @"\Booking icon hover.png";
            Book_Seat_icon.ImageLocation = source;
        }

        private void Book_Seat_icon_MouseLeave(object sender, EventArgs e)
        {
            string source = Environment.CurrentDirectory + @"\Booking icon.png";
            Book_Seat_icon.ImageLocation = source;
        }

        private void Cancel_Seat_icon_Click(object sender, EventArgs e)
        {
            All_Seats seats = new All_Seats();
            seats.ModeCheck(true,false);
            this.Hide();
            seats.Show();
        }

        private void Cancel_Seat_icon_MouseHover(object sender, EventArgs e)
        {
            string source = Environment.CurrentDirectory + @"\Cancel hover.png";
            Cancel_Seat_icon.ImageLocation = source;
        }

        private void Cancel_Seat_icon_MouseLeave(object sender, EventArgs e)
        {
            string source = Environment.CurrentDirectory + @"\Cancel.png";
            Cancel_Seat_icon.ImageLocation = source;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MainMenu.ExistingPassenger.exit(ref MainMenu.counter, ref MainMenu.flight_counter);
            MainMenu NewMenu = new MainMenu();
            NewMenu.Show();
            this.Hide();
        }

        private void Logout_MouseHover(object sender, EventArgs e)
        {
            string source = Environment.CurrentDirectory + @"\Logout hover.png";
            Logout.ImageLocation = source;
        }

        private void Logout_MouseLeave(object sender, EventArgs e)
        {
            string source = Environment.CurrentDirectory + @"\Logout.png";
            Logout.ImageLocation = source;
        }

        private void Login_Label_Click(object sender, EventArgs e)
        {

        }

        private void Passenger_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu.ExistingPassenger.exit(ref MainMenu.counter, ref MainMenu.flight_counter);
            Application.Exit();
        }
    }
}
