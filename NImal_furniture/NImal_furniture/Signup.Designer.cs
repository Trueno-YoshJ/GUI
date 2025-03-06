namespace NImal_furniture
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            panel1 = new Panel();
            signup_close = new Label();
            label6 = new Label();
            signup_password = new TextBox();
            signup_address = new TextBox();
            label5 = new Label();
            login_link = new LinkLabel();
            label4 = new Label();
            signup_checkbox = new CheckBox();
            signup_button = new Button();
            signup_contact = new TextBox();
            label3 = new Label();
            signup_email = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(signup_close);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(signup_password);
            panel1.Controls.Add(signup_address);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(login_link);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(signup_checkbox);
            panel1.Controls.Add(signup_button);
            panel1.Controls.Add(signup_contact);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(signup_email);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 512);
            panel1.TabIndex = 1;
            // 
            // signup_close
            // 
            signup_close.AutoSize = true;
            signup_close.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_close.Location = new Point(851, 8);
            signup_close.Name = "signup_close";
            signup_close.Size = new Size(27, 26);
            signup_close.TabIndex = 14;
            signup_close.Text = "X";
            signup_close.Click += signup_close_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(435, 314);
            label6.Name = "label6";
            label6.Size = new Size(109, 23);
            label6.TabIndex = 12;
            label6.Text = "Password";
            // 
            // signup_password
            // 
            signup_password.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_password.Location = new Point(435, 340);
            signup_password.Name = "signup_password";
            signup_password.Size = new Size(430, 31);
            signup_password.TabIndex = 13;
            // 
            // signup_address
            // 
            signup_address.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_address.Location = new Point(435, 230);
            signup_address.Multiline = true;
            signup_address.Name = "signup_address";
            signup_address.PasswordChar = '*';
            signup_address.Size = new Size(430, 81);
            signup_address.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(435, 204);
            label5.Name = "label5";
            label5.Size = new Size(95, 23);
            label5.TabIndex = 10;
            label5.Text = "Address";
            // 
            // login_link
            // 
            login_link.AutoSize = true;
            login_link.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_link.LinkColor = Color.Maroon;
            login_link.Location = new Point(651, 462);
            login_link.Name = "login_link";
            login_link.Size = new Size(61, 28);
            login_link.TabIndex = 9;
            login_link.TabStop = true;
            login_link.Text = "Login";
            login_link.LinkClicked += login_link_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(434, 467);
            label4.Name = "label4";
            label4.Size = new Size(211, 23);
            label4.TabIndex = 8;
            label4.Text = "Already have an account ?";
            // 
            // signup_checkbox
            // 
            signup_checkbox.AutoSize = true;
            signup_checkbox.ForeColor = SystemColors.ControlDarkDark;
            signup_checkbox.Location = new Point(778, 396);
            signup_checkbox.Name = "signup_checkbox";
            signup_checkbox.Size = new Size(75, 24);
            signup_checkbox.TabIndex = 7;
            signup_checkbox.Text = "Admin";
            signup_checkbox.UseVisualStyleBackColor = true;
            // 
            // signup_button
            // 
            signup_button.BackColor = Color.Peru;
            signup_button.Font = new Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_button.Location = new Point(435, 396);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(198, 56);
            signup_button.TabIndex = 6;
            signup_button.Text = "Signup";
            signup_button.UseVisualStyleBackColor = false;
            // 
            // signup_contact
            // 
            signup_contact.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_contact.Location = new Point(434, 161);
            signup_contact.Name = "signup_contact";
            signup_contact.PasswordChar = '*';
            signup_contact.Size = new Size(430, 31);
            signup_contact.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(435, 135);
            label3.Name = "label3";
            label3.Size = new Size(182, 23);
            label3.TabIndex = 4;
            label3.Text = "Contact Number";
            // 
            // signup_email
            // 
            signup_email.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_email.Location = new Point(435, 90);
            signup_email.Name = "signup_email";
            signup_email.Size = new Size(430, 31);
            signup_email.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(435, 64);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 512);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(751, 410);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 512);
            Controls.Add(panel1);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel login_link;
        private Label label4;
        private Button signup_button;
        private TextBox signup_contact;
        private Label label3;
        private TextBox signup_email;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox signup_address;
        private Label label5;
        private TextBox signup_password;
        private Label label6;
        private CheckBox signup_checkbox;
        private Label signup_close;
    }
}