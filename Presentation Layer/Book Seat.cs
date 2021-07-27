using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
namespace Assignment_2
{
    public partial class Book_Seat : Form
    {
        static bool cnic_check = false;
        static bool name_check = false;
        public static Available_Seats aseats = new Available_Seats();

        public Book_Seat()
        {
            InitializeComponent();
        }

        private void Book_Seat_Load(object sender, EventArgs e)
        {
            CNIC_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CNIC_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            CNIC_tbox.TextAlign = HorizontalAlignment.Center;
            CNIC_tbox.Text = "Enter CNIC";
            Name_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            Name_tbox.TextAlign = HorizontalAlignment.Center;
            Name_tbox.Text = "Enter Name";
        }


        private void CNIC_tbox_TextChanged(object sender, EventArgs e)
        {
            cnic_check = true;

        }

        private void Name_tbox_TextChanged(object sender, EventArgs e)
        {
            name_check = true;

        }
        private void CNIC_tbox_MouseClick(object sender, MouseEventArgs e)
        {

            CNIC_tbox.Clear();
            CNIC_tbox.TextAlign = HorizontalAlignment.Left;
            CNIC_tbox.ForeColor = Color.Black;
            CNIC_tbox.Font = new Font(CNIC_tbox.Font, FontStyle.Regular);

        }
        private void Name_tbox_MouseClick(object sender, MouseEventArgs e)
        {

            Name_tbox.Clear();
            Name_tbox.TextAlign = HorizontalAlignment.Left;
            Name_tbox.ForeColor = Color.Black;
            Name_tbox.Font = new Font(CNIC_tbox.Font, FontStyle.Regular);


        }
        private void check_input()
        {
            if (cnic_check == true && name_check == true)
            {
                if (CNIC_tbox.Text.Length > 0 && Name_tbox.Text.Length > 0)
                {
                    MainCoice_btn.Enabled = true;
                }
                else
                {
                    MainCoice_btn.Enabled = false;
                }
            }
        }

        private void button_enable_MouseEnter(object sender, EventArgs e)
        {
            check_input();
        }
        private void MainCoice_btn_Click(object sender, EventArgs e)
        {
            byte status = MainMenu.ExistingPassenger.GetPassenger(CNIC_tbox.Text, Name_tbox.Text);
            if(status==0)
            {
                input_gbox.Enabled = false;
                Show_Seats.Visible = true;
            }
            else if (status == 1)
            {
                MessageBox.Show("Name is not registered", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (status == 2)
            {
                MessageBox.Show("CNIC is not registered", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (status == 3)
            {
                MessageBox.Show("No user exists Sign Up", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }


        private void Show_Seats_Click(object sender, EventArgs e)
        {
            bool self_reservation;
            bool other_reservation;
            bool left_side;
            bool right_side;
            bool window_side;
            bool aisle_side;
            if (RFor_Self.Checked==true)
            {
                self_reservation = true;
            }
            else
            {
                self_reservation = false;
            }
            if(RFor_Other.Checked==true)
            {
                other_reservation = true;
            }
            else
            {
                other_reservation = false;
            }
            if(Left_Side.Checked==true)
            {
                left_side = true;
            }
            else
            {
                left_side = false;
            }
            if(Right_Side.Checked==true)
            {
                right_side = true;
            }
            else
            {
                right_side = false;
            }
            if(Window_Side.Checked==true)
            {
                window_side = true;
            }
            else
            {
                window_side = false;
            }
            if(Aisle_Side.Checked==true)
            {
                aisle_side = true;
            }
            else
            {
                aisle_side = false;
            }
            aseats = new Available_Seats();
            aseats.GetInput(CNIC_tbox.Text, Name_tbox.Text,
                self_reservation, other_reservation, left_side,
                right_side, window_side, aisle_side);
            aseats.Show();
            this.Hide();

        }

        private void RFor_Self_CheckedChanged(object sender, EventArgs e)
        {
            if( (RFor_Self.Checked==true   ||
                RFor_Other.Checked==true )  &&
                (Left_Side.Checked==true   || 
                Right_Side.Checked==true ) &&
                (Window_Side.Checked==true ||
                Aisle_Side.Checked==true))
            {
                input_gbox.Visible = true;
            }
            if (RFor_Self.Checked == true)
            {
                CNIC_tbox.Clear();
                CNIC_tbox.TextAlign = HorizontalAlignment.Left;
                CNIC_tbox.ForeColor = Color.Black;
                CNIC_tbox.Font = new Font(CNIC_tbox.Font, FontStyle.Regular);
                CNIC_tbox.Text = MainMenu.ExistingPassenger.Cnic;
                CNIC_tbox.Enabled = false;
                cnic_check = true;
                Name_tbox.Clear();
                Name_tbox.TextAlign = HorizontalAlignment.Left;
                Name_tbox.ForeColor = Color.Black;
                Name_tbox.Font = new Font(CNIC_tbox.Font, FontStyle.Regular);
                Name_tbox.Text = MainMenu.ExistingPassenger.Name;
                Name_tbox.Enabled = false;
                name_check = true;
                check_input();
            }
        }

        private void RFor_Other_CheckedChanged(object sender, EventArgs e)
        {
            if ((RFor_Self.Checked == true ||
                RFor_Other.Checked == true) &&
                (Left_Side.Checked == true ||
                Right_Side.Checked == true) &&
                (Window_Side.Checked == true ||
                Aisle_Side.Checked == true))
            {
                input_gbox.Visible = true;
            }
            if (RFor_Other.Checked == true)
            {

                MainCoice_btn.Enabled = false;
                CNIC_tbox.Clear();
                CNIC_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                CNIC_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
                CNIC_tbox.TextAlign = HorizontalAlignment.Center;
                CNIC_tbox.Enabled = true;
                cnic_check = false;
                Name_tbox.Clear();
                CNIC_tbox.Text = "Enter CNIC";
                Name_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Name_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
                Name_tbox.TextAlign = HorizontalAlignment.Center;
                Name_tbox.Text = "Enter Name";
                Name_tbox.Enabled = true;
                name_check = false;
            }
        }

        private void Left_Side_CheckedChanged(object sender, EventArgs e)
        {
            if ((RFor_Self.Checked == true ||
                RFor_Other.Checked == true) &&
                (Left_Side.Checked == true ||
                Right_Side.Checked == true) &&
                (Window_Side.Checked == true ||
                Aisle_Side.Checked == true))
            {
                input_gbox.Visible = true;
            }
        }

        private void Right_Side_CheckedChanged(object sender, EventArgs e)
        {
            if ((RFor_Self.Checked == true ||
                RFor_Other.Checked == true) &&
                (Left_Side.Checked == true ||
                Right_Side.Checked == true) &&
                (Window_Side.Checked == true ||
                Aisle_Side.Checked == true))
            {
                input_gbox.Visible = true;
            }
        }

        private void Window_Side_CheckedChanged(object sender, EventArgs e)
        {
            if ((RFor_Self.Checked == true ||
                RFor_Other.Checked == true) &&
                (Left_Side.Checked == true ||
                Right_Side.Checked == true) &&
                (Window_Side.Checked == true ||
                Aisle_Side.Checked == true))
            {
                input_gbox.Visible = true;
            }
        }

        private void Aisle_Side_CheckedChanged(object sender, EventArgs e)
        {
            if ((RFor_Self.Checked == true ||
                RFor_Other.Checked == true) &&
                (Left_Side.Checked == true ||
                Right_Side.Checked == true) &&
                (Window_Side.Checked == true ||
                Aisle_Side.Checked == true))
            {
                input_gbox.Visible = true;
            }
        }

        private void button_enable_Paint(object sender, PaintEventArgs e)
        {

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
        private void ViewMode_CheckedChanged(object sender, EventArgs e)
        {


            
        }

        private void DeleteMode_CheckedChanged(object sender, EventArgs e)
        {


            
        }

        private void Book_Seat_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu.ExistingPassenger.exit(ref MainMenu.counter, ref MainMenu.flight_counter);
            Application.Exit();
        }

        private void options_MouseHover(object sender, EventArgs e)
        {

        }

        private void options_Leave(object sender, EventArgs e)
        {

        }

        private void options_Enter(object sender, EventArgs e)
        {


        }

        private void options_panel_MouseHover(object sender, EventArgs e)
        {
        }

        private void options_panel_MouseLeave(object sender, EventArgs e)
        {
        }

        private void modes_Leave(object sender, EventArgs e)
        {

        }

        private void ViewMode_btn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteMode_btn_Click(object sender, EventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewMode_panel_MouseHover(object sender, EventArgs e)
        {
        }

        private void DeleteMode_panel_MouseHover(object sender, EventArgs e)
        {
        }

        private void ViewMode_panel_MouseLeave(object sender, EventArgs e)
        {
        }

        private void DeleteMode_panel_MouseLeave(object sender, EventArgs e)
        {
        }

        private void panel23_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewMode_panel_MouseEnter(object sender, EventArgs e)
        {

        }

        private void input_gbox_Enter(object sender, EventArgs e)
        {

        }

        private void Avaibale_label_Click(object sender, EventArgs e)
        {

        }

        private void Main_RLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewSeatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            All_Seats newAll = new All_Seats();
            newAll.ModeCheck(false, true);
            newAll.Show();
            this.Hide();
        }

        private void deleteSeatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            All_Seats newAll = new All_Seats();
            newAll.ModeCheck(true, false);
            newAll.Show();
            this.Hide();
        }
    }
}
