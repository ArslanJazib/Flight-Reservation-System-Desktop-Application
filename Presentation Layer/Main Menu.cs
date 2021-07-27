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
    public partial class MainMenu : Form
    {
        static public int counter = 0; // To check if the file is ever updated before
        static public int flight_counter = 0; // To check if the file is ever updated before
        static bool login_check = false;
        static bool SignUp_check = false;
        static bool cnic_check=false;
        static bool name_check = false;
        static FileHandler fileHandler = new FileHandler();/*Calling the defualt constructor
        of the file handler to get all records from passenger list*/
        static SeatsMatrix temp = new SeatsMatrix(); /* Calling the default constructor of the
           seat matrix class get all records from flight list*/
       public static Passengers ExistingPassenger = new Passengers(fileHandler.PassengerList);/*Using the 
       filsehandler object to refer all the records in passenger list to object */
        public static Passenger_Menu PMenu = new Passenger_Menu();
        public MainMenu()
        {
            InitializeComponent();
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void Welcome_Label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Icon_Click(object sender, EventArgs e)
        {
            string source = Environment.CurrentDirectory + @"\Login.png";
            login_Icon.ImageLocation = source;
            Information_Panel.Visible = false;
            this.ActiveControl = null;
            login_Icon.Enabled = true;
            SignUp_check = false;
            cnic_check = false;
            name_check = false;
            if (login_check==false)
            {
                this.ActiveControl = null;
                source = Environment.CurrentDirectory + @"\Login.png";
                login_Icon.ImageLocation = source;
                source = Environment.CurrentDirectory + @"\DimmedSignUp.png";
                SignUp_icon.ImageLocation = source;
                Information_Panel.Visible = true;
                MainCoice_btn.Text = "Login";
                CNIC_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                CNIC_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
                CNIC_tbox.TextAlign = HorizontalAlignment.Center;
                CNIC_tbox.Text = "Enter CNIC";
                Name_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Name_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
                Name_tbox.TextAlign = HorizontalAlignment.Center;
                Name_tbox.Text = "Enter Name";

            }

        }

        private void SignUp_icon_Click(object sender, EventArgs e)
        {
            string source = Environment.CurrentDirectory + @"\SignUp.png";
            SignUp_icon.ImageLocation = source;
            Information_Panel.Visible = false;
            this.ActiveControl = null;
            SignUp_icon.Enabled = true;
            login_check = false;
            cnic_check = false;
            name_check = false;
            if (SignUp_check == false)
            {
                this.ActiveControl = null;
                source = Environment.CurrentDirectory + @"\SignUp.png";
                SignUp_icon.ImageLocation = source;
                source = Environment.CurrentDirectory + @"\DimmedLogin.png";
                login_Icon.ImageLocation = source;
                Information_Panel.Visible = true;
                MainCoice_btn.Text = "SignUp";
                CNIC_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                CNIC_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
                CNIC_tbox.TextAlign = HorizontalAlignment.Center;
                CNIC_tbox.Text = "Enter CNIC";
                Name_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Name_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
                Name_tbox.TextAlign = HorizontalAlignment.Center;
                Name_tbox.Text = "Enter Name";


            }

        }

        private void MainCoice_btn_Click(object sender, EventArgs e)
        {
            if(MainCoice_btn.Text=="Login")
            {
                byte status=ExistingPassenger.LogIN_Confirmation(CNIC_tbox.Text,Name_tbox.Text,ExistingPassenger);
                if(status==0)
                {
                    this.Hide();
                    PMenu.Show();
                }
                else if(status==1)
                {
                    MessageBox.Show("Name is not registered", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if(status==2)
                {
                    MessageBox.Show("CNIC is not registered", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if(status==3)
                {
                    MessageBox.Show("No user exists Sign Up", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (MainCoice_btn.Text == "SignUp")
            {
                bool status = ExistingPassenger.SignUP(CNIC_tbox.Text,Name_tbox.Text);
                if (status == true)
                {
                    MessageBox.Show("Passenger registered", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else 
                {
                    MessageBox.Show("Passenger already exists", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void CNIC_tbox_TextChanged(object sender, EventArgs e)
        {
            cnic_check = true;

        }

        private void CNIC_tbox_Click(object sender, EventArgs e)
        {
           
        }

        private void CNIC_tbox_BorderStyleChanged(object sender, EventArgs e)
        {
            
        }

        private void CNIC_tbox_MouseClick(object sender, MouseEventArgs e)
        {
 
                CNIC_tbox.Clear();
                CNIC_tbox.TextAlign = HorizontalAlignment.Left;
                CNIC_tbox.ForeColor = Color.Black;
                CNIC_tbox.Font = new Font(CNIC_tbox.Font, FontStyle.Regular);

            


        }

        private void Name_tbox_TextChanged(object sender, EventArgs e)
        {
            name_check = true;

        }

        private void Name_tbox_MouseClick(object sender, MouseEventArgs e)
        {
            
                Name_tbox.Clear();
                Name_tbox.TextAlign = HorizontalAlignment.Left;
                Name_tbox.ForeColor = Color.Black;
                Name_tbox.Font = new Font(CNIC_tbox.Font, FontStyle.Regular);


        }

        private void Information_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainCoice_btn_MouseEnter(object sender, EventArgs e)
        {
           
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

        private void button_enable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExistingPassenger.exit(ref counter,ref flight_counter);
            Application.Exit();
        }

        private void Options_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
