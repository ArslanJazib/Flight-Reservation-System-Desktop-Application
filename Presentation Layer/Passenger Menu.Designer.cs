namespace Assignment_2
{
    partial class Passenger_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passenger_Menu));
            this.User_Panel = new System.Windows.Forms.Panel();
            this.Login_Label = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.PictureBox();
            this.Seat_Status_icon = new System.Windows.Forms.PictureBox();
            this.Book_Seat_icon = new System.Windows.Forms.PictureBox();
            this.Cancel_Seat_icon = new System.Windows.Forms.PictureBox();
            this.Options_panel = new System.Windows.Forms.Panel();
            this.Cancel_label = new System.Windows.Forms.Label();
            this.book_label = new System.Windows.Forms.Label();
            this.CheckSeat_label = new System.Windows.Forms.Label();
            this.User_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seat_Status_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Seat_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel_Seat_icon)).BeginInit();
            this.Options_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // User_Panel
            // 
            this.User_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.User_Panel.Controls.Add(this.Login_Label);
            this.User_Panel.Controls.Add(this.Logout);
            this.User_Panel.Location = new System.Drawing.Point(12, 13);
            this.User_Panel.Name = "User_Panel";
            this.User_Panel.Size = new System.Drawing.Size(1068, 139);
            this.User_Panel.TabIndex = 0;
            // 
            // Login_Label
            // 
            this.Login_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label.Location = new System.Drawing.Point(956, 97);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(89, 29);
            this.Login_Label.TabIndex = 2;
            this.Login_Label.Text = "Log Out";
            this.Login_Label.Click += new System.EventHandler(this.Login_Label_Click);
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.Location = new System.Drawing.Point(948, 14);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(117, 80);
            this.Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logout.TabIndex = 0;
            this.Logout.TabStop = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            this.Logout.MouseLeave += new System.EventHandler(this.Logout_MouseLeave);
            this.Logout.MouseHover += new System.EventHandler(this.Logout_MouseHover);
            // 
            // Seat_Status_icon
            // 
            this.Seat_Status_icon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Seat_Status_icon.Image = ((System.Drawing.Image)(resources.GetObject("Seat_Status_icon.Image")));
            this.Seat_Status_icon.Location = new System.Drawing.Point(186, 3);
            this.Seat_Status_icon.Name = "Seat_Status_icon";
            this.Seat_Status_icon.Size = new System.Drawing.Size(117, 80);
            this.Seat_Status_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Seat_Status_icon.TabIndex = 1;
            this.Seat_Status_icon.TabStop = false;
            this.Seat_Status_icon.Click += new System.EventHandler(this.Seat_Status_icon_Click);
            this.Seat_Status_icon.MouseLeave += new System.EventHandler(this.Seat_Status_icon_MouseLeave);
            this.Seat_Status_icon.MouseHover += new System.EventHandler(this.Seat_Status_MouseHover);
            // 
            // Book_Seat_icon
            // 
            this.Book_Seat_icon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Book_Seat_icon.Image = ((System.Drawing.Image)(resources.GetObject("Book_Seat_icon.Image")));
            this.Book_Seat_icon.Location = new System.Drawing.Point(483, 3);
            this.Book_Seat_icon.Name = "Book_Seat_icon";
            this.Book_Seat_icon.Size = new System.Drawing.Size(117, 80);
            this.Book_Seat_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Book_Seat_icon.TabIndex = 2;
            this.Book_Seat_icon.TabStop = false;
            this.Book_Seat_icon.Click += new System.EventHandler(this.Book_Seat_icon_Click);
            this.Book_Seat_icon.MouseLeave += new System.EventHandler(this.Book_Seat_icon_MouseLeave);
            this.Book_Seat_icon.MouseHover += new System.EventHandler(this.Book_Seat_icon_MouseHover);
            // 
            // Cancel_Seat_icon
            // 
            this.Cancel_Seat_icon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cancel_Seat_icon.Image = ((System.Drawing.Image)(resources.GetObject("Cancel_Seat_icon.Image")));
            this.Cancel_Seat_icon.Location = new System.Drawing.Point(761, 3);
            this.Cancel_Seat_icon.Name = "Cancel_Seat_icon";
            this.Cancel_Seat_icon.Size = new System.Drawing.Size(117, 80);
            this.Cancel_Seat_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cancel_Seat_icon.TabIndex = 3;
            this.Cancel_Seat_icon.TabStop = false;
            this.Cancel_Seat_icon.Click += new System.EventHandler(this.Cancel_Seat_icon_Click);
            this.Cancel_Seat_icon.MouseLeave += new System.EventHandler(this.Cancel_Seat_icon_MouseLeave);
            this.Cancel_Seat_icon.MouseHover += new System.EventHandler(this.Cancel_Seat_icon_MouseHover);
            // 
            // Options_panel
            // 
            this.Options_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Options_panel.BackColor = System.Drawing.SystemColors.Window;
            this.Options_panel.Controls.Add(this.Cancel_label);
            this.Options_panel.Controls.Add(this.book_label);
            this.Options_panel.Controls.Add(this.CheckSeat_label);
            this.Options_panel.Controls.Add(this.Cancel_Seat_icon);
            this.Options_panel.Controls.Add(this.Seat_Status_icon);
            this.Options_panel.Controls.Add(this.Book_Seat_icon);
            this.Options_panel.Location = new System.Drawing.Point(12, 262);
            this.Options_panel.Name = "Options_panel";
            this.Options_panel.Size = new System.Drawing.Size(1068, 140);
            this.Options_panel.TabIndex = 4;
            // 
            // Cancel_label
            // 
            this.Cancel_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cancel_label.AutoSize = true;
            this.Cancel_label.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_label.Location = new System.Drawing.Point(704, 86);
            this.Cancel_label.Name = "Cancel_label";
            this.Cancel_label.Size = new System.Drawing.Size(236, 35);
            this.Cancel_label.TabIndex = 5;
            this.Cancel_label.Text = "Cancel Reservation";
            // 
            // book_label
            // 
            this.book_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.book_label.AutoSize = true;
            this.book_label.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_label.Location = new System.Drawing.Point(465, 86);
            this.book_label.Name = "book_label";
            this.book_label.Size = new System.Drawing.Size(154, 35);
            this.book_label.TabIndex = 5;
            this.book_label.Text = "Book A Seat";
            // 
            // CheckSeat_label
            // 
            this.CheckSeat_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckSeat_label.AutoSize = true;
            this.CheckSeat_label.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckSeat_label.Location = new System.Drawing.Point(136, 86);
            this.CheckSeat_label.Name = "CheckSeat_label";
            this.CheckSeat_label.Size = new System.Drawing.Size(220, 35);
            this.CheckSeat_label.TabIndex = 4;
            this.CheckSeat_label.Text = "Check Seat Status";
            // 
            // Passenger_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1092, 637);
            this.Controls.Add(this.Options_panel);
            this.Controls.Add(this.User_Panel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(913, 668);
            this.Name = "Passenger_Menu";
            this.Text = "Passenger Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Passenger_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Passenger_Menu_Load);
            this.User_Panel.ResumeLayout(false);
            this.User_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seat_Status_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Seat_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel_Seat_icon)).EndInit();
            this.Options_panel.ResumeLayout(false);
            this.Options_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel User_Panel;
        private System.Windows.Forms.PictureBox Logout;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.PictureBox Seat_Status_icon;
        private System.Windows.Forms.PictureBox Book_Seat_icon;
        private System.Windows.Forms.PictureBox Cancel_Seat_icon;
        private System.Windows.Forms.Panel Options_panel;
        private System.Windows.Forms.Label CheckSeat_label;
        private System.Windows.Forms.Label book_label;
        private System.Windows.Forms.Label Cancel_label;
    }
}