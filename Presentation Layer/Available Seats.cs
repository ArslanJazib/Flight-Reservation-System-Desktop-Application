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
    public partial class Available_Seats : Form
    {
        public int total_seats;
        int staticrows = 0;
        string cnic;
        string name;
        bool reservation_status;
        bool rother_reservation;
        bool rleft_side;
        bool rright_side;
        bool rwindow_side;
        bool raisle_side;
        List<PictureBox> Icons = new List<PictureBox>();
        List<Label> Labels = new List<Label>();
        List<Panel> Panels = new List<Panel>();
        public Available_Seats()
        {
            InitializeComponent();
            MainMenu.ExistingPassenger.total_seats(ref total_seats);
            boxes();
        }
        public void GetInput(string input_cnic, string input_name, bool self_reservation, bool other_reservation, bool left_side,
        bool right_side, bool window_side, bool aisle_side)
        {
            cnic = input_cnic;
            name = input_name;
            reservation_status = self_reservation;
            rother_reservation = other_reservation;
            rleft_side = left_side;
            rright_side = right_side;
            rwindow_side = window_side;
            raisle_side = aisle_side;
        }
        public void GetInput(string input_cnic, string input_name, bool self_reservation, bool other_reservation)
        {
            cnic = input_cnic;
            name = input_name;
            reservation_status = self_reservation;
            rother_reservation = other_reservation;

        }
        public void Available_Seats_Load(object sender, EventArgs e)
        {
            SeatLoad();

        }

        private void Right_Aisle_Paint(object sender, PaintEventArgs e)
        {

        }
        public void boxes()
        {
            Icons.Add(pictureBox1);
            Icons.Add(pictureBox2);
            Icons.Add(pictureBox3);
            Icons.Add(pictureBox4);
            Icons.Add(pictureBox5);
            Icons.Add(pictureBox6);
            Icons.Add(pictureBox7);
            Icons.Add(pictureBox8);
            Icons.Add(pictureBox9);
            Icons.Add(pictureBox10);
            Icons.Add(pictureBox11);
            Icons.Add(pictureBox12);
            Icons.Add(pictureBox13);
            Icons.Add(pictureBox14);
            Icons.Add(pictureBox15);
            Icons.Add(pictureBox16);
            Icons.Add(pictureBox17);
            Icons.Add(pictureBox18);
            Icons.Add(pictureBox19);
            Icons.Add(pictureBox20);



            Panels.Add(panel1);
            Panels.Add(panel2);
            Panels.Add(panel3);
            Panels.Add(panel4);
            Panels.Add(panel5);
            Panels.Add(panel6);
            Panels.Add(panel7);
            Panels.Add(panel8);
            Panels.Add(panel9);
            Panels.Add(panel10);
            Panels.Add(panel11);
            Panels.Add(panel12);
            Panels.Add(panel13);
            Panels.Add(panel14);
            Panels.Add(panel15);
            Panels.Add(panel16);
            Panels.Add(panel17);
            Panels.Add(panel18);
            Panels.Add(panel19);
            Panels.Add(panel20);



            Labels.Add(label1);
            Labels.Add(label3);
            Labels.Add(label5);
            Labels.Add(label7);
            Labels.Add(label9);
            Labels.Add(label11);
            Labels.Add(label13);
            Labels.Add(label15);
            Labels.Add(label17);
            Labels.Add(label19);
            Labels.Add(label21);
            Labels.Add(label23);
            Labels.Add(label25);
            Labels.Add(label27);
            Labels.Add(label29);
            Labels.Add(label31);
            Labels.Add(label33);
            Labels.Add(label35);
            Labels.Add(label37);
            Labels.Add(label39);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RightWindow_SeatSelection(0, pictureBox1);
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RightWindow_SeatSelection(1, pictureBox2);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RightWindow_SeatSelection(2, pictureBox3);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            RightWindow_SeatSelection(3, pictureBox4);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            RightWindow_SeatSelection(4, pictureBox5);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            RightWindow_SeatSelection(5, pictureBox6);

        }

        private void LeftWindow_SeatSelection(byte selected_seat,PictureBox box)
        {
            if (rleft_side == true && rwindow_side == true)
            {
                bool status=SeatsMatrix.Left_Window_selection(selected_seat,MainMenu.ExistingPassenger, reservation_status, rother_reservation, cnic, name);
                if(status==true)
                {
                    MessageBox.Show("Seat selected", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string source = Environment.CurrentDirectory + @"\Window Seat Icon Filled.png";
                    box.ImageLocation = source;
                    if ( MessageBox.Show("Do you want to reserve another seat", "Choose", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        Passenger_Input new_passenger = new Passenger_Input();
                        new_passenger.Show();
                    }
                    else
                    {
                        this.Hide();
                        MainMenu.PMenu.Show();
                    }

                }
            }
        }
        private void LeftAisle_SeatSelection(byte selected_seat, PictureBox box)
        {
            if (rleft_side == true && raisle_side == true)
            {
                bool status = SeatsMatrix.Left_Aisle_selection(selected_seat, MainMenu.ExistingPassenger, reservation_status, rother_reservation, cnic, name);
                if (status == true)
                {
                    MessageBox.Show("Seat selected", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string source = Environment.CurrentDirectory + @"\Aisle Seat Icon Filled.png";
                    box.ImageLocation = source;
                    if (MessageBox.Show("Do you want to reserve another seat", "Choose", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Passenger_Input new_passenger = new Passenger_Input();
                        new_passenger.Show();
                    }
                    else
                    {
                        this.Hide();
                        MainMenu.PMenu.Show();
                    }

                }
            }
        }
        private void RightWindow_SeatSelection(byte selected_seat, PictureBox box)
        {
            if (rright_side == true && rwindow_side == true)
            {
                bool status = SeatsMatrix.Right_Window_selection(selected_seat, MainMenu.ExistingPassenger, reservation_status, rother_reservation, cnic, name);
                if (status == true)
                {
                    MessageBox.Show("Seat selected", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string source = Environment.CurrentDirectory + @"\Window Seat Icon Filled.png";
                    box.ImageLocation = source;
                    if (MessageBox.Show("Do you want to reserve another seat", "Choose", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Passenger_Input new_passenger = new Passenger_Input();
                        new_passenger.Show();
                    }
                    else
                    {
                        this.Hide();
                        MainMenu.PMenu.Show();
                    }

                }
            }
        }
        private void RightAisle_SeatSelection(byte selected_seat, PictureBox box)
        {
            if (rright_side == true && raisle_side == true)
            {
                bool status = SeatsMatrix.Right_Aisle_selection(selected_seat, MainMenu.ExistingPassenger, reservation_status, rother_reservation, cnic, name);
                if (status == true)
                {
                    MessageBox.Show("Seat selected", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string source = Environment.CurrentDirectory + @"\Aisle Seat Icon Filled.png";
                    box.ImageLocation = source;
                    if (MessageBox.Show("Do you want to reserve another seat", "Choose", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Passenger_Input new_passenger = new Passenger_Input();
                        new_passenger.Show();
                    }
                    else
                    {
                        this.Hide();
                        MainMenu.PMenu.Show();
                    }

                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            RightAisle_SeatSelection(6, pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            RightAisle_SeatSelection(7, pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            RightAisle_SeatSelection(8, pictureBox9);

        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            RightAisle_SeatSelection(9, pictureBox10);

        }
        private void Left_Window_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

                RightAisle_SeatSelection(10, pictureBox11);

            
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            RightAisle_SeatSelection(11, pictureBox12);

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            LeftAisle_SeatSelection(12, pictureBox13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            LeftAisle_SeatSelection(13, pictureBox14);

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            LeftAisle_SeatSelection(14, pictureBox15);

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            LeftAisle_SeatSelection(15, pictureBox16);

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            LeftWindow_SeatSelection(16, pictureBox17);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            LeftWindow_SeatSelection(17, pictureBox18);

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            LeftWindow_SeatSelection(18, pictureBox19);

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            LeftWindow_SeatSelection(19, pictureBox20);

        }
        private void SeatLoad()
        {
            KeyValuePair<List<Seat>, List<int>> temp = new KeyValuePair<List<Seat>, List<int>>();
            temp = MainMenu.ExistingPassenger.book_seat(cnic, name, reservation_status, rother_reservation, rleft_side,
            rright_side, rwindow_side, raisle_side, ref staticrows);
            if(temp.Key!=null)
            {
                if (rright_side == true && rwindow_side == true)
                {
                    int index2 = 0;
                    for (int index = 0; index <= 5; index++)
                    {
                        if (temp.Value.Count != 0 && index2 <= temp.Value.Count - 1)
                        {
                            for (int x = index2; x <= temp.Value.Count - 1; x++)
                            {
                                if (temp.Value[index2] == index)
                                {
                                    string source = Environment.CurrentDirectory + @"\Window Seat Icon Filled.png";
                                    Icons[index].ImageLocation = source;
                                    Panels[index].Visible = true;
                                    Labels[index].Text = "Seat Reserved";
                                    Icons[index].Enabled = false;
                                    break;
                                }
                            }
                            index2++;
                            continue;
                        }
                        else
                        {
                            string source = Environment.CurrentDirectory + @"\Window Seat Icon.png";
                            Icons[index].ImageLocation = source;
                        }
                    }
                }
                else if (rright_side == true && raisle_side == true)
                {
                    int index2 = 0;
                    for (int index = 6; index <= 11; index++)
                    {
                        if (temp.Value.Count != 0 && index2 <= temp.Value.Count - 1)
                        {
                            for (int x = index2; x <= temp.Value.Count - 1; x++)
                            {
                                if (temp.Value[index2] == index)
                                {
                                    string source = Environment.CurrentDirectory + @"\Aisle Seat Icon Filled.png";
                                    Icons[index].ImageLocation = source;
                                    Panels[index].Visible = true;
                                    Labels[index].Text = "Seat Reserved";
                                    Icons[index].Enabled = false;
                                    break;
                                }
                            }
                            index2++;
                            continue;
                        }
                        else
                        {
                            string source = Environment.CurrentDirectory + @"\Aisle Seat Icon.png";
                            Icons[index].ImageLocation = source;
                        }
                    }
                }
                else if (rleft_side == true && rwindow_side == true)
                {
                    int index2 = 0;
                    for (int index = 16; index <= 19; index++)
                    {
                        if (temp.Value.Count != 0 && index2 <= temp.Value.Count - 1)
                        {
                            for (int x = index2; x <= temp.Value.Count - 1; x++)
                            {
                                if (temp.Value[index2] == index)
                                {
                                    string source = Environment.CurrentDirectory + @"\Window Seat Icon Filled.png";
                                    Icons[index].ImageLocation = source;
                                    Panels[index].Visible = true;
                                    Labels[index].Text = "Seat Reserved";
                                    Icons[index].Enabled = false;
                                    break;
                                }
                            }
                            index2++;
                            continue;
                        }
                        else
                        {
                            string source = Environment.CurrentDirectory + @"\Window Seat Icon.png";
                            Icons[index].ImageLocation = source;
                        }
                    }
                }
                else if (rleft_side == true && raisle_side == true)
                {
                    int index2 = 0;
                    for (int index = 12; index <= 15; index++)
                    {
                        if (temp.Value.Count != 0 && index2 <= temp.Value.Count - 1)
                        {
                            for (int x = index2; x <= temp.Value.Count - 1; x++)
                            {
                                if (temp.Value[index2] == index)
                                {
                                    string source = Environment.CurrentDirectory + @"\Aisle Seat Icon Filled.png";
                                    Icons[index].ImageLocation = source;
                                    Panels[index].Visible = true;
                                    Labels[index].Text = "Seat Reserved";
                                    Icons[index].Enabled = false;
                                    break;
                                }
                            }
                            index2++;
                            continue;
                        }
                        else
                        {
                            string source = Environment.CurrentDirectory + @"\Aisle Seat Icon.png";
                            Icons[index].ImageLocation = source;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Passenger is already seated", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Book_Seat re_open = new Book_Seat();
                re_open.Show();
                this.Hide();
                
            }

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

        private void BookMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ViewMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DeleteMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Logout_Click_1(object sender, EventArgs e)
        {

        }

        private void Available_Seats_FormClosing(object sender, FormClosingEventArgs e)
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

        private void options_panel_MouseHover(object sender, EventArgs e)
        {

        }

        private void options_panel_MouseLeave(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void modes_Enter(object sender, EventArgs e)
        {

        }

        private void RRight_Window_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RRight_Aisle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel22_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel23_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
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
