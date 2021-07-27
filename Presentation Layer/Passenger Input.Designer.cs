namespace Assignment_2
{
    partial class Passenger_Input
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passenger_Input));
            this.input_gbox = new System.Windows.Forms.GroupBox();
            this.button_enable = new System.Windows.Forms.Panel();
            this.MainCoice_btn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Name_tbox = new System.Windows.Forms.TextBox();
            this.CNIC_tbox = new System.Windows.Forms.TextBox();
            this.RFor_Other = new System.Windows.Forms.RadioButton();
            this.RFor_Self = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.input_gbox.SuspendLayout();
            this.button_enable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_gbox
            // 
            this.input_gbox.Controls.Add(this.button_enable);
            this.input_gbox.Controls.Add(this.pictureBox3);
            this.input_gbox.Controls.Add(this.pictureBox2);
            this.input_gbox.Controls.Add(this.Name_tbox);
            this.input_gbox.Controls.Add(this.CNIC_tbox);
            this.input_gbox.Location = new System.Drawing.Point(170, 133);
            this.input_gbox.Name = "input_gbox";
            this.input_gbox.Size = new System.Drawing.Size(335, 226);
            this.input_gbox.TabIndex = 7;
            this.input_gbox.TabStop = false;
            this.input_gbox.Text = "Enter Data";
            // 
            // button_enable
            // 
            this.button_enable.Controls.Add(this.MainCoice_btn);
            this.button_enable.Location = new System.Drawing.Point(75, 137);
            this.button_enable.Name = "button_enable";
            this.button_enable.Size = new System.Drawing.Size(242, 73);
            this.button_enable.TabIndex = 12;
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
            // RFor_Other
            // 
            this.RFor_Other.AutoSize = true;
            this.RFor_Other.Location = new System.Drawing.Point(329, 3);
            this.RFor_Other.Name = "RFor_Other";
            this.RFor_Other.Size = new System.Drawing.Size(235, 24);
            this.RFor_Other.TabIndex = 9;
            this.RFor_Other.TabStop = true;
            this.RFor_Other.Text = "Reserving for someone else ";
            this.RFor_Other.UseVisualStyleBackColor = true;
            this.RFor_Other.CheckedChanged += new System.EventHandler(this.RFor_Other_CheckedChanged);
            // 
            // RFor_Self
            // 
            this.RFor_Self.AutoSize = true;
            this.RFor_Self.Location = new System.Drawing.Point(112, 3);
            this.RFor_Self.Name = "RFor_Self";
            this.RFor_Self.Size = new System.Drawing.Size(187, 24);
            this.RFor_Self.TabIndex = 8;
            this.RFor_Self.TabStop = true;
            this.RFor_Self.Text = "Reserving for yourself";
            this.RFor_Self.UseVisualStyleBackColor = true;
            this.RFor_Self.CheckedChanged += new System.EventHandler(this.RFor_Self_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.RFor_Other);
            this.panel1.Controls.Add(this.RFor_Self);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 41);
            this.panel1.TabIndex = 10;
            // 
            // Passenger_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(711, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.input_gbox);
            this.Name = "Passenger_Input";
            this.Text = "Passenger_Input";
            this.Load += new System.EventHandler(this.Passenger_Input_Load);
            this.input_gbox.ResumeLayout(false);
            this.input_gbox.PerformLayout();
            this.button_enable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox input_gbox;
        private System.Windows.Forms.Panel button_enable;
        private System.Windows.Forms.Button MainCoice_btn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Name_tbox;
        private System.Windows.Forms.TextBox CNIC_tbox;
        private System.Windows.Forms.RadioButton RFor_Other;
        private System.Windows.Forms.RadioButton RFor_Self;
        private System.Windows.Forms.Panel panel1;
    }
}