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
    public partial class Passenger_Input : Form
    {
        static bool cnic_check = false;
        static bool name_check = false;
        public Passenger_Input()
        {
            InitializeComponent();
            RFor_Other.Checked = true;
        }

        private void Passenger_Input_Load(object sender, EventArgs e)
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

        private void RFor_Self_CheckedChanged(object sender, EventArgs e)
        {
            if(RFor_Self.Checked==true)
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

        private void MainCoice_btn_Click(object sender, EventArgs e)
        {
            bool self_reservation;
            bool other_reservation;

            if (RFor_Self.Checked == true)
            {
                self_reservation = true;
            }
            else
            {
                self_reservation = false;
            }
            if (RFor_Other.Checked == true)
            {
                other_reservation = true;
            }
            else
            {
                other_reservation = false;
            }

            Book_Seat.aseats.GetInput(CNIC_tbox.Text, Name_tbox.Text,
            self_reservation, other_reservation);
            this.Hide();
            Book_Seat.aseats.Available_Seats_Load(this, null);
        }

        private void RFor_Other_CheckedChanged(object sender, EventArgs e)
        {
            if(RFor_Other.Checked==true)
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
    }
}
