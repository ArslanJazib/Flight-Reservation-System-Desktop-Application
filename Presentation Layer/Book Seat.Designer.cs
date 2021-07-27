namespace Assignment_2
{
    partial class Book_Seat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Seat));
            this.Main_RLabel = new System.Windows.Forms.Label();
            this.RFor_Self = new System.Windows.Forms.RadioButton();
            this.RFor_Other = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Side_Option = new System.Windows.Forms.Label();
            this.Right_Side = new System.Windows.Forms.RadioButton();
            this.Left_Side = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Win_AisOpt = new System.Windows.Forms.Label();
            this.Aisle_Side = new System.Windows.Forms.RadioButton();
            this.Window_Side = new System.Windows.Forms.RadioButton();
            this.Show_Seats = new System.Windows.Forms.Button();
            this.input_gbox = new System.Windows.Forms.GroupBox();
            this.button_enable = new System.Windows.Forms.Panel();
            this.MainCoice_btn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Name_tbox = new System.Windows.Forms.TextBox();
            this.CNIC_tbox = new System.Windows.Forms.TextBox();
            this.Login_Label = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewSeatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSeatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.input_gbox.SuspendLayout();
            this.button_enable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_RLabel
            // 
            this.Main_RLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Main_RLabel.AutoSize = true;
            this.Main_RLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_RLabel.Location = new System.Drawing.Point(379, 35);
            this.Main_RLabel.Name = "Main_RLabel";
            this.Main_RLabel.Size = new System.Drawing.Size(309, 40);
            this.Main_RLabel.TabIndex = 0;
            this.Main_RLabel.Text = "Seat Reservation";
            this.Main_RLabel.Click += new System.EventHandler(this.Main_RLabel_Click);
            // 
            // RFor_Self
            // 
            this.RFor_Self.AutoSize = true;
            this.RFor_Self.Location = new System.Drawing.Point(302, 3);
            this.RFor_Self.Name = "RFor_Self";
            this.RFor_Self.Size = new System.Drawing.Size(209, 24);
            this.RFor_Self.TabIndex = 0;
            this.RFor_Self.TabStop = true;
            this.RFor_Self.Text = "Reserving for yourself";
            this.RFor_Self.UseVisualStyleBackColor = true;
            this.RFor_Self.CheckedChanged += new System.EventHandler(this.RFor_Self_CheckedChanged);
            // 
            // RFor_Other
            // 
            this.RFor_Other.AutoSize = true;
            this.RFor_Other.Location = new System.Drawing.Point(519, 3);
            this.RFor_Other.Name = "RFor_Other";
            this.RFor_Other.Size = new System.Drawing.Size(262, 24);
            this.RFor_Other.TabIndex = 1;
            this.RFor_Other.TabStop = true;
            this.RFor_Other.Text = "Reserving for someone else ";
            this.RFor_Other.UseVisualStyleBackColor = true;
            this.RFor_Other.CheckedChanged += new System.EventHandler(this.RFor_Other_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RFor_Other);
            this.panel1.Controls.Add(this.RFor_Self);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 33);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Side_Option);
            this.panel2.Controls.Add(this.Right_Side);
            this.panel2.Controls.Add(this.Left_Side);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 33);
            this.panel2.TabIndex = 2;
            // 
            // Side_Option
            // 
            this.Side_Option.AutoSize = true;
            this.Side_Option.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Side_Option.Location = new System.Drawing.Point(3, 7);
            this.Side_Option.Name = "Side_Option";
            this.Side_Option.Size = new System.Drawing.Size(209, 20);
            this.Side_Option.TabIndex = 2;
            this.Side_Option.Text = "Choose side of the plane";
            // 
            // Right_Side
            // 
            this.Right_Side.AutoSize = true;
            this.Right_Side.Location = new System.Drawing.Point(519, 3);
            this.Right_Side.Name = "Right_Side";
            this.Right_Side.Size = new System.Drawing.Size(77, 24);
            this.Right_Side.TabIndex = 1;
            this.Right_Side.TabStop = true;
            this.Right_Side.Text = "Right";
            this.Right_Side.UseVisualStyleBackColor = true;
            this.Right_Side.CheckedChanged += new System.EventHandler(this.Right_Side_CheckedChanged);
            // 
            // Left_Side
            // 
            this.Left_Side.AutoSize = true;
            this.Left_Side.Location = new System.Drawing.Point(302, 3);
            this.Left_Side.Name = "Left_Side";
            this.Left_Side.Size = new System.Drawing.Size(66, 24);
            this.Left_Side.TabIndex = 0;
            this.Left_Side.TabStop = true;
            this.Left_Side.Text = "Left";
            this.Left_Side.UseVisualStyleBackColor = true;
            this.Left_Side.CheckedChanged += new System.EventHandler(this.Left_Side_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Win_AisOpt);
            this.panel3.Controls.Add(this.Aisle_Side);
            this.panel3.Controls.Add(this.Window_Side);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 33);
            this.panel3.TabIndex = 3;
            // 
            // Win_AisOpt
            // 
            this.Win_AisOpt.AutoSize = true;
            this.Win_AisOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Win_AisOpt.Location = new System.Drawing.Point(3, 7);
            this.Win_AisOpt.Name = "Win_AisOpt";
            this.Win_AisOpt.Size = new System.Drawing.Size(110, 20);
            this.Win_AisOpt.TabIndex = 2;
            this.Win_AisOpt.Text = "Choose seat";
            // 
            // Aisle_Side
            // 
            this.Aisle_Side.AutoSize = true;
            this.Aisle_Side.Location = new System.Drawing.Point(519, 3);
            this.Aisle_Side.Name = "Aisle_Side";
            this.Aisle_Side.Size = new System.Drawing.Size(73, 24);
            this.Aisle_Side.TabIndex = 1;
            this.Aisle_Side.TabStop = true;
            this.Aisle_Side.Text = "Aisle";
            this.Aisle_Side.UseVisualStyleBackColor = true;
            this.Aisle_Side.CheckedChanged += new System.EventHandler(this.Aisle_Side_CheckedChanged);
            // 
            // Window_Side
            // 
            this.Window_Side.AutoSize = true;
            this.Window_Side.Location = new System.Drawing.Point(302, 3);
            this.Window_Side.Name = "Window_Side";
            this.Window_Side.Size = new System.Drawing.Size(96, 24);
            this.Window_Side.TabIndex = 0;
            this.Window_Side.TabStop = true;
            this.Window_Side.Text = "Window";
            this.Window_Side.UseVisualStyleBackColor = true;
            this.Window_Side.CheckedChanged += new System.EventHandler(this.Window_Side_CheckedChanged);
            // 
            // Show_Seats
            // 
            this.Show_Seats.BackColor = System.Drawing.SystemColors.Window;
            this.Show_Seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Seats.Location = new System.Drawing.Point(448, 96);
            this.Show_Seats.Name = "Show_Seats";
            this.Show_Seats.Size = new System.Drawing.Size(144, 50);
            this.Show_Seats.TabIndex = 4;
            this.Show_Seats.Text = "Show Seats";
            this.Show_Seats.UseVisualStyleBackColor = false;
            this.Show_Seats.Visible = false;
            this.Show_Seats.Click += new System.EventHandler(this.Show_Seats_Click);
            // 
            // input_gbox
            // 
            this.input_gbox.Controls.Add(this.button_enable);
            this.input_gbox.Controls.Add(this.pictureBox3);
            this.input_gbox.Controls.Add(this.pictureBox2);
            this.input_gbox.Controls.Add(this.Name_tbox);
            this.input_gbox.Controls.Add(this.CNIC_tbox);
            this.input_gbox.Location = new System.Drawing.Point(3, 3);
            this.input_gbox.Name = "input_gbox";
            this.input_gbox.Size = new System.Drawing.Size(335, 226);
            this.input_gbox.TabIndex = 6;
            this.input_gbox.TabStop = false;
            this.input_gbox.Text = "Enter Data";
            this.input_gbox.Visible = false;
            this.input_gbox.Enter += new System.EventHandler(this.input_gbox_Enter);
            // 
            // button_enable
            // 
            this.button_enable.Controls.Add(this.MainCoice_btn);
            this.button_enable.Location = new System.Drawing.Point(75, 137);
            this.button_enable.Name = "button_enable";
            this.button_enable.Size = new System.Drawing.Size(242, 73);
            this.button_enable.TabIndex = 12;
            this.button_enable.Paint += new System.Windows.Forms.PaintEventHandler(this.button_enable_Paint);
            this.button_enable.MouseEnter += new System.EventHandler(this.button_enable_MouseEnter);
            // 
            // MainCoice_btn
            // 
            this.MainCoice_btn.BackColor = System.Drawing.SystemColors.Window;
            this.MainCoice_btn.Enabled = false;
            this.MainCoice_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainCoice_btn.Location = new System.Drawing.Point(37, 14);
            this.MainCoice_btn.Name = "MainCoice_btn";
            this.MainCoice_btn.Size = new System.Drawing.Size(162, 40);
            this.MainCoice_btn.TabIndex = 6;
            this.MainCoice_btn.Text = "Submit";
            this.MainCoice_btn.UseVisualStyleBackColor = false;
            this.MainCoice_btn.Click += new System.EventHandler(this.MainCoice_btn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Name_tbox
            // 
            this.Name_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Name_tbox.Location = new System.Drawing.Point(112, 105);
            this.Name_tbox.Name = "Name_tbox";
            this.Name_tbox.Size = new System.Drawing.Size(162, 26);
            this.Name_tbox.TabIndex = 9;
            this.Name_tbox.Text = "Enter Name";
            this.Name_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_tbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Name_tbox_MouseClick);
            this.Name_tbox.TextChanged += new System.EventHandler(this.Name_tbox_TextChanged);
            // 
            // CNIC_tbox
            // 
            this.CNIC_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNIC_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CNIC_tbox.Location = new System.Drawing.Point(112, 49);
            this.CNIC_tbox.Name = "CNIC_tbox";
            this.CNIC_tbox.Size = new System.Drawing.Size(162, 26);
            this.CNIC_tbox.TabIndex = 8;
            this.CNIC_tbox.Text = "Enter CNIC";
            this.CNIC_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CNIC_tbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CNIC_tbox_MouseClick);
            this.CNIC_tbox.TextChanged += new System.EventHandler(this.CNIC_tbox_TextChanged);
            // 
            // Login_Label
            // 
            this.Login_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label.Location = new System.Drawing.Point(946, 95);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(89, 29);
            this.Login_Label.TabIndex = 14;
            this.Login_Label.Text = "Log Out";
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.Location = new System.Drawing.Point(938, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(117, 80);
            this.Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logout.TabIndex = 13;
            this.Logout.TabStop = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            this.Logout.MouseLeave += new System.EventHandler(this.Logout_MouseLeave);
            this.Logout.MouseHover += new System.EventHandler(this.Logout_MouseHover);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.input_gbox);
            this.panel4.Controls.Add(this.Show_Seats);
            this.panel4.Location = new System.Drawing.Point(12, 382);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1043, 234);
            this.panel4.TabIndex = 16;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSeatsToolStripMenuItem,
            this.deleteSeatsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewSeatsToolStripMenuItem
            // 
            this.viewSeatsToolStripMenuItem.Name = "viewSeatsToolStripMenuItem";
            this.viewSeatsToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.viewSeatsToolStripMenuItem.Text = "View Seats";
            this.viewSeatsToolStripMenuItem.Click += new System.EventHandler(this.viewSeatsToolStripMenuItem_Click);
            // 
            // deleteSeatsToolStripMenuItem
            // 
            this.deleteSeatsToolStripMenuItem.Name = "deleteSeatsToolStripMenuItem";
            this.deleteSeatsToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
            this.deleteSeatsToolStripMenuItem.Text = "Delete Seats";
            this.deleteSeatsToolStripMenuItem.Click += new System.EventHandler(this.deleteSeatsToolStripMenuItem_Click);
            // 
            // Book_Seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 628);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Login_Label);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Main_RLabel);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(1089, 684);
            this.MinimumSize = new System.Drawing.Size(1089, 684);
            this.Name = "Book_Seat";
            this.Text = "Book_Seat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Book_Seat_FormClosing);
            this.Load += new System.EventHandler(this.Book_Seat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.input_gbox.ResumeLayout(false);
            this.input_gbox.PerformLayout();
            this.button_enable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).EndInit();
            this.panel4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Main_RLabel;
        private System.Windows.Forms.RadioButton RFor_Self;
        private System.Windows.Forms.RadioButton RFor_Other;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Side_Option;
        private System.Windows.Forms.RadioButton Right_Side;
        private System.Windows.Forms.RadioButton Left_Side;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Win_AisOpt;
        private System.Windows.Forms.RadioButton Aisle_Side;
        private System.Windows.Forms.RadioButton Window_Side;
        private System.Windows.Forms.Button Show_Seats;
        private System.Windows.Forms.GroupBox input_gbox;
        private System.Windows.Forms.Panel button_enable;
        private System.Windows.Forms.Button MainCoice_btn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Name_tbox;
        private System.Windows.Forms.TextBox CNIC_tbox;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.PictureBox Logout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewSeatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSeatsToolStripMenuItem;
    }
}