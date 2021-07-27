namespace Assignment_2
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Welcome_Label = new System.Windows.Forms.Label();
            this.Login_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_Icon = new System.Windows.Forms.PictureBox();
            this.SignUp_icon = new System.Windows.Forms.PictureBox();
            this.Options_Panel = new System.Windows.Forms.Panel();
            this.Information_Panel = new System.Windows.Forms.Panel();
            this.button_enable = new System.Windows.Forms.Panel();
            this.MainCoice_btn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Name_tbox = new System.Windows.Forms.TextBox();
            this.CNIC_tbox = new System.Windows.Forms.TextBox();
            this.Main_Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.login_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignUp_icon)).BeginInit();
            this.Options_Panel.SuspendLayout();
            this.Information_Panel.SuspendLayout();
            this.button_enable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome_Label
            // 
            this.Welcome_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Welcome_Label.AutoSize = true;
            this.Welcome_Label.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_Label.Location = new System.Drawing.Point(328, 18);
            this.Welcome_Label.Name = "Welcome_Label";
            this.Welcome_Label.Size = new System.Drawing.Size(420, 44);
            this.Welcome_Label.TabIndex = 0;
            this.Welcome_Label.Text = "Flight Management System";
            this.Welcome_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Welcome_Label.Click += new System.EventHandler(this.Welcome_Label_Click);
            // 
            // Login_Label
            // 
            this.Login_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label.Location = new System.Drawing.Point(297, 102);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(99, 44);
            this.Login_Label.TabIndex = 1;
            this.Login_Label.Text = "Login";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sign Up";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // login_Icon
            // 
            this.login_Icon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.login_Icon.Image = ((System.Drawing.Image)(resources.GetObject("login_Icon.Image")));
            this.login_Icon.Location = new System.Drawing.Point(296, 3);
            this.login_Icon.Name = "login_Icon";
            this.login_Icon.Size = new System.Drawing.Size(100, 96);
            this.login_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.login_Icon.TabIndex = 3;
            this.login_Icon.TabStop = false;
            this.login_Icon.Click += new System.EventHandler(this.login_Icon_Click);
            // 
            // SignUp_icon
            // 
            this.SignUp_icon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SignUp_icon.Image = ((System.Drawing.Image)(resources.GetObject("SignUp_icon.Image")));
            this.SignUp_icon.Location = new System.Drawing.Point(636, 3);
            this.SignUp_icon.Name = "SignUp_icon";
            this.SignUp_icon.Size = new System.Drawing.Size(100, 96);
            this.SignUp_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SignUp_icon.TabIndex = 4;
            this.SignUp_icon.TabStop = false;
            this.SignUp_icon.Click += new System.EventHandler(this.SignUp_icon_Click);
            // 
            // Options_Panel
            // 
            this.Options_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Options_Panel.BackColor = System.Drawing.SystemColors.Window;
            this.Options_Panel.Controls.Add(this.SignUp_icon);
            this.Options_Panel.Controls.Add(this.login_Icon);
            this.Options_Panel.Controls.Add(this.Login_Label);
            this.Options_Panel.Controls.Add(this.label2);
            this.Options_Panel.Location = new System.Drawing.Point(12, 233);
            this.Options_Panel.Name = "Options_Panel";
            this.Options_Panel.Size = new System.Drawing.Size(1024, 179);
            this.Options_Panel.TabIndex = 5;
            this.Options_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Options_Panel_Paint);
            // 
            // Information_Panel
            // 
            this.Information_Panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Information_Panel.Controls.Add(this.button_enable);
            this.Information_Panel.Controls.Add(this.pictureBox3);
            this.Information_Panel.Controls.Add(this.pictureBox2);
            this.Information_Panel.Controls.Add(this.Name_tbox);
            this.Information_Panel.Controls.Add(this.CNIC_tbox);
            this.Information_Panel.Location = new System.Drawing.Point(299, 418);
            this.Information_Panel.Name = "Information_Panel";
            this.Information_Panel.Size = new System.Drawing.Size(440, 221);
            this.Information_Panel.TabIndex = 6;
            this.Information_Panel.Visible = false;
            this.Information_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Information_Panel_Paint);
            // 
            // button_enable
            // 
            this.button_enable.Controls.Add(this.MainCoice_btn);
            this.button_enable.Location = new System.Drawing.Point(140, 147);
            this.button_enable.Name = "button_enable";
            this.button_enable.Size = new System.Drawing.Size(242, 73);
            this.button_enable.TabIndex = 7;
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
            this.MainCoice_btn.UseVisualStyleBackColor = false;
            this.MainCoice_btn.Click += new System.EventHandler(this.MainCoice_btn_Click);
            this.MainCoice_btn.MouseEnter += new System.EventHandler(this.MainCoice_btn_MouseEnter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(71, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(71, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Name_tbox
            // 
            this.Name_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Name_tbox.Location = new System.Drawing.Point(177, 115);
            this.Name_tbox.Name = "Name_tbox";
            this.Name_tbox.Size = new System.Drawing.Size(162, 26);
            this.Name_tbox.TabIndex = 1;
            this.Name_tbox.Text = "Enter Name";
            this.Name_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_tbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Name_tbox_MouseClick);
            this.Name_tbox.TextChanged += new System.EventHandler(this.Name_tbox_TextChanged);
            // 
            // CNIC_tbox
            // 
            this.CNIC_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNIC_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CNIC_tbox.Location = new System.Drawing.Point(177, 59);
            this.CNIC_tbox.Name = "CNIC_tbox";
            this.CNIC_tbox.Size = new System.Drawing.Size(162, 26);
            this.CNIC_tbox.TabIndex = 0;
            this.CNIC_tbox.Text = "Enter CNIC";
            this.CNIC_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CNIC_tbox.BorderStyleChanged += new System.EventHandler(this.CNIC_tbox_BorderStyleChanged);
            this.CNIC_tbox.Click += new System.EventHandler(this.CNIC_tbox_Click);
            this.CNIC_tbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CNIC_tbox_MouseClick);
            this.CNIC_tbox.TextChanged += new System.EventHandler(this.CNIC_tbox_TextChanged);
            // 
            // Main_Icon
            // 
            this.Main_Icon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Main_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Main_Icon.Image")));
            this.Main_Icon.Location = new System.Drawing.Point(754, 18);
            this.Main_Icon.Name = "Main_Icon";
            this.Main_Icon.Size = new System.Drawing.Size(100, 96);
            this.Main_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Main_Icon.TabIndex = 7;
            this.Main_Icon.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1048, 651);
            this.Controls.Add(this.Main_Icon);
            this.Controls.Add(this.Information_Panel);
            this.Controls.Add(this.Options_Panel);
            this.Controls.Add(this.Welcome_Label);
            this.MinimumSize = new System.Drawing.Size(779, 665);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResizeEnd += new System.EventHandler(this.MainMenu_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.login_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignUp_icon)).EndInit();
            this.Options_Panel.ResumeLayout(false);
            this.Options_Panel.PerformLayout();
            this.Information_Panel.ResumeLayout(false);
            this.Information_Panel.PerformLayout();
            this.button_enable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_Label;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox login_Icon;
        private System.Windows.Forms.PictureBox SignUp_icon;
        private System.Windows.Forms.Panel Options_Panel;
        private System.Windows.Forms.Panel Information_Panel;
        private System.Windows.Forms.TextBox Name_tbox;
        private System.Windows.Forms.TextBox CNIC_tbox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button MainCoice_btn;
        private System.Windows.Forms.Panel button_enable;
        private System.Windows.Forms.PictureBox Main_Icon;
    }
}

