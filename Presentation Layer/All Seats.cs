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
    public partial class All_Seats : Form
    {
        public int total_seats;
        List<PictureBox> Icons = new List<PictureBox>();
        List<Label> Labels = new List<Label>();
        List<Panel> Panels = new List<Panel>();
        public All_Seats()
        {
            InitializeComponent();
            MainMenu.ExistingPassenger.total_seats(ref total_seats);
            boxes();
            ViewMode.Checked = false;
        }

        private void All_Seats_Load(object sender, EventArgs e)
        {
            int index = 0;
            int index2 = 0;
            for (int p_rows = 0; p_rows < 6; p_rows++)
            {
                for (int p_cols = 0; p_cols < 4; p_cols++, index++, index2 += 2)
                {

                    // Ignoring the unavailable seats 
                    if ((p_rows == 0 & p_cols > 1) || (p_rows == 5 & p_cols > 1))
                    {
                        index--;
                        index2 -= 2;
                        continue ;
                    }
                    else
                    {
                        Seat temp = new Seat();
                        temp = MainMenu.ExistingPassenger.CheckAll_Seats(p_rows,p_cols);
                        if (temp.onePair.Key != "0")
                        {
                            if (temp.onePair.Value == true)
                            {
                                if ( p_cols==3 && p_rows<= 4)
                                {
                                    string source = Environment.CurrentDirectory + @"\Window Seat Icon Filled.png";
                                    Icons[index].ImageLocation = source;
                                    if (temp.SeatSelector != null)
                                    {
                                        if (temp.SeatSelector.Cnic == MainMenu.ExistingPassenger.Cnic)
                                        {
                                             Panels[index].Visible = true;
                                             Labels[index2].Text = "CNIC: " + MainMenu.ExistingPassenger.Cnic;
                                             Labels[index2 + 1].Text = "Name: " + MainMenu.ExistingPassenger.Name;
                                            if (DeleteMode.Checked == true)
                                            {
                                                Icons[index].Enabled = true;

                                            }
                                            else
                                            {
                                                Icons[index].Enabled = false;

                                            }
                                        }

                                    }
                                    if (temp.to_be_seated.Cnic == MainMenu.ExistingPassenger.Cnic)
                                    {
                                        Panels[index].Visible = true;
                                        Labels[index2].Text = "CNIC: " + MainMenu.ExistingPassenger.Cnic;
                                        Labels[index2 + 1].Text = "Name: " + MainMenu.ExistingPassenger.Name;
                                        if (DeleteMode.Checked == true)
                                        {
                                            Icons[index].Enabled = true;

                                        }
                                        else
                                        {
                                            Icons[index].Enabled = false;

                                        }
                                    }


                                }
                                else if (p_cols == 0 && p_rows <= 4)
                                {
                                    string source = Environment.CurrentDirectory + @"\Window Seat Icon Filled.png";
                                    Icons[index].ImageLocation = source;
                                    if (temp.SeatSelector != null)
                                    {
                                        if (temp.SeatSelector.Cnic == MainMenu.ExistingPassenger.Cnic)
                                        {
                                            Panels[index].Visible = true;
                                            Labels[index2].Text = "CNIC: " + MainMenu.ExistingPassenger.Cnic;
                                            Labels[index2 + 1].Text = "Name: " + MainMenu.ExistingPassenger.Name;
                                            if (DeleteMode.Checked == true)
                                            {
                                                Icons[index].Enabled = true;

                                            }
                                            else
                                            {
                                                Icons[index].Enabled = false;

                                            }
                                        }

                                    }
                                    if (temp.to_be_seated.Cnic == MainMenu.ExistingPassenger.Cnic)
                                    {
                                        Panels[index].Visible = true;
                                        Labels[index2].Text = "CNIC: " + MainMenu.ExistingPassenger.Cnic;
                                        Labels[index2 + 1].Text = "Name: " + MainMenu.ExistingPassenger.Name;
                                        if (DeleteMode.Checked == true)
                                        {
                                            Icons[index].Enabled = true;

                                        }
                                        else
                                        {
                                            Icons[index].Enabled = false;

                                        }
                                    }


                                }
                                else
                                {
                                    string source = Environment.CurrentDirectory + @"\Aisle Seat Icon filled.png";
                                    Icons[index].ImageLocation = source;
                                    if (temp.SeatSelector != null)
                                    {
                                        if (temp.SeatSelector.Cnic == MainMenu.ExistingPassenger.Cnic)
                                        {
                                            Panels[index].Visible = true;
                                            Labels[index2].Text = "CNIC: " + MainMenu.ExistingPassenger.Cnic;
                                            Labels[index2 + 1].Text = "Name: " + MainMenu.ExistingPassenger.Name;
                                            if (DeleteMode.Checked == true)
                                            {
                                                Icons[index].Enabled = true;

                                            }
                                            else
                                            {
                                                Icons[index].Enabled = false;

                                            }
                                        }

                                    }
                                    if (temp.to_be_seated.Cnic == MainMenu.ExistingPassenger.Cnic)
                                    {
                                        Panels[index].Visible = true;
                                        Labels[index2].Text = "CNIC: " + MainMenu.ExistingPassenger.Cnic;
                                        Labels[index2 + 1].Text = "Name: " + MainMenu.ExistingPassenger.Name;
                                        if (DeleteMode.Checked == true)
                                        {
                                            Icons[index].Enabled = true;

                                        }
                                        else
                                        {
                                            Icons[index].Enabled = false;

                                        }
                                    }
                                }
                            }
                            else
                            {
                                if ((p_cols == 3) && p_rows <= 4)
                                {
                                    string source = Environment.CurrentDirectory + @"\Window Seat Icon.png";
                                    Icons[index].ImageLocation = source;

                                }
                                else if ((p_cols == 0) && p_rows <= 5)
                                {
                                    string source = Environment.CurrentDirectory + @"\Window Seat Icon.png";
                                    Icons[index].ImageLocation = source;

                                }
                                else
                                {
                                    string source = Environment.CurrentDirectory + @"\Aisle Seat Icon.png";
                                    Icons[index].ImageLocation = source;
                                }
                            }

                        }
                    }
                    
                }

            }


        }


        public void boxes()
        {
            Icons.Add(pictureBox1);
            Icons.Add(pictureBox7);
            Icons.Add(pictureBox2);
            Icons.Add(pictureBox8);
            Icons.Add(pictureBox13);
            Icons.Add(pictureBox17);
            Icons.Add(pictureBox3);
            Icons.Add(pictureBox9);
            Icons.Add(pictureBox14);
            Icons.Add(pictureBox18);
            Icons.Add(pictureBox4);
            Icons.Add(pictureBox10);
            Icons.Add(pictureBox15);
            Icons.Add(pictureBox19);
            Icons.Add(pictureBox5);
            Icons.Add(pictureBox11);
            Icons.Add(pictureBox16);
            Icons.Add(pictureBox20);
            Icons.Add(pictureBox6);
            Icons.Add(pictureBox12);

            Panels.Add(panel1);
            Panels.Add(panel7);
            Panels.Add(panel2);
            Panels.Add(panel8);
            Panels.Add(panel13);
            Panels.Add(panel17);
            Panels.Add(panel3);
            Panels.Add(panel9);
            Panels.Add(panel14);
            Panels.Add(panel18);
            Panels.Add(panel4);
            Panels.Add(panel10);
            Panels.Add(panel15);
            Panels.Add(panel19);
            Panels.Add(panel5);
            Panels.Add(panel11);
            Panels.Add(panel16);
            Panels.Add(panel20);
            Panels.Add(panel6);
            Panels.Add(panel12);


            
            Labels.Add(label1);
            Labels.Add(label2);
            Labels.Add(label13);
            Labels.Add(label14);
            Labels.Add(label3);
            Labels.Add(label4);
            Labels.Add(label15);
            Labels.Add(label16);
            Labels.Add(label25);
            Labels.Add(label26);
            Labels.Add(label33);
            Labels.Add(label34);
            Labels.Add(label5);
            Labels.Add(label6);
            Labels.Add(label17);
            Labels.Add(label18);
            Labels.Add(label27);
            Labels.Add(label28);
            Labels.Add(label35);
            Labels.Add(label36);
            Labels.Add(label7);
            Labels.Add(label8);
            Labels.Add(label19);
            Labels.Add(label20);
            Labels.Add(label29);
            Labels.Add(label30);
            Labels.Add(label37);
            Labels.Add(label38);
            Labels.Add(label9);
            Labels.Add(label10);
            Labels.Add(label21);
            Labels.Add(label22);
            Labels.Add(label31);
            Labels.Add(label32);
            Labels.Add(label39);
            Labels.Add(label40);
            Labels.Add(label11);
            Labels.Add(label12);
            Labels.Add(label23);
            Labels.Add(label24);

        }

        public void ModeCheck(bool del_status,bool view_status)
        {
            DeleteMode.Checked = del_status;
            ViewMode.Checked = view_status;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(0, 0);
            if(status==true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Window Seat Icon.png";
                pictureBox1.ImageLocation = source;
                panel1.Visible = false;
                label1.Text = null;
                label2.Text = null;
                if(DeleteMode.Checked==false)
                {
                    ModeCheck(false,true);
                }
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(1, 0);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Window Seat Icon.png";
                pictureBox2.ImageLocation = source;
                panel2.Visible = false;
                label3.Text = null;
                label4.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(2, 0);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Window Seat Icon.png";
                pictureBox3.ImageLocation = source;
                panel3.Visible = false;
                label5.Text = null;
                label6.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(3, 0);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Window Seat Icon.png";
                pictureBox4.ImageLocation = source;
                panel4.Visible = false;
                label7.Text = null;
                label8.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(4, 0);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Window Seat Icon.png";
                pictureBox5.ImageLocation = source;
                panel5.Visible = false;
                label9.Text = null;
                label10.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(5, 0);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Window Seat Icon.png";
                pictureBox6.ImageLocation = source;
                panel6.Visible = false;
                label11.Text = null;
                label12.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(0, 1);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Aisle Seat Icon.png";
                pictureBox7.ImageLocation = source;
                panel7.Visible = false;
                label13.Text = null;
                label14.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(1, 1);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Aisle Seat Icon.png";
                pictureBox8.ImageLocation = source;
                panel8.Visible = false;
                label15.Text = null;
                label16.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(2, 1);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Aisle Seat Icon.png";
                pictureBox9.ImageLocation = source;
                panel9.Visible = false;
                label17.Text = null;
                label18.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(3, 1);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Aisle Seat Icon.png";
                pictureBox10.ImageLocation = source;
                panel10.Visible = false;
                label19.Text = null;
                label20.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(4, 1);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Aisle Seat Icon.png";
                pictureBox11.ImageLocation = source;
                panel11.Visible = false;
                label21.Text = null;
                label22.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(5, 1);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Aisle Seat Icon.png";
                pictureBox12.ImageLocation = source;
                panel12.Visible = false;
                label23.Text = null;
                label24.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(1, 2);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Aisle Seat Icon.png";
                pictureBox13.ImageLocation = source;
                panel13.Visible = false;
                label25.Text = null;
                label26.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(2, 2);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Aisle Seat Icon.png";
                pictureBox14.ImageLocation = source;
                panel14.Visible = false;
                label27.Text = null;
                label28.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(3, 2);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Aisle Seat Icon.png";
                pictureBox15.ImageLocation = source;
                panel15.Visible = false;
                label29.Text = null;
                label30.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(4, 2);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Aisle Seat Icon.png";
                pictureBox16.ImageLocation = source;
                panel16.Visible = false;
                label31.Text = null;
                label32.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(1, 3);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Window Seat Icon.png";
                pictureBox17.ImageLocation = source;
                panel17.Visible = false;
                label33.Text = null;
                label34.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(2, 3);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Window Seat Icon.png";
                pictureBox18.ImageLocation = source;
                panel18.Visible = false;
                label35.Text = null;
                label36.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(3, 3);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Window Seat Icon.png";
                pictureBox19.ImageLocation = source;
                panel19.Visible = false;
                label37.Text = null;
                label38.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            bool status=MainMenu.ExistingPassenger.CancelReservation(4, 3);
            if (status == true)
            {
                MessageBox.Show("Reservation Canceled", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string source = Environment.CurrentDirectory + @"\Window Seat Icon.png";
                pictureBox20.ImageLocation = source;
                panel20.Visible = false;
                label39.Text = null;
                label40.Text = null;
                if (DeleteMode.Checked == false)
                {
                    ModeCheck(false, true);
                }
            }
        }

        private void ViewMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DeleteMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BookMode_CheckedChanged(object sender, EventArgs e)
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

        private void All_Seats_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu.ExistingPassenger.exit(ref MainMenu.counter, ref MainMenu.flight_counter);
            Application.Exit();
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {
        }

        private void options_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void options_panel_MouseEnter(object sender, EventArgs e)
        {

        }

        private void options_panel_MouseHover(object sender, EventArgs e)
        {

        }

        private void options_panel_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Left_Window_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Right_Aisle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Left_Window_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Left_Aisle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModeCheck(false, true);
            All_Seats_Load(this, null);
            ViewMode.Checked = true;
        }

        private void deleteSeatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModeCheck(true, false);
            All_Seats_Load(this, null);
            DeleteMode.Checked = true;
        }

        private void bookSeatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookMode.Checked = true;
            Book_Seat newbook = new Book_Seat();
            newbook.Show();
            this.Hide();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
