namespace NImal_furniture
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            login_close = new Label();
            signup_link = new LinkLabel();
            label4 = new Label();
            login_checkBox = new CheckBox();
            login_button = new Button();
            login_password = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            login_username = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(login_close);
            panel1.Controls.Add(signup_link);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(login_checkBox);
            panel1.Controls.Add(login_button);
            panel1.Controls.Add(login_password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 512);
            panel1.TabIndex = 0;
            // 
            // login_close
            // 
            login_close.AutoSize = true;
            login_close.Font = new Font("Lucida Sans Typewriter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_close.Location = new Point(856, 9);
            login_close.Name = "login_close";
            login_close.Size = new Size(26, 26);
            login_close.TabIndex = 10;
            login_close.Text = "X";
            login_close.Click += login_close_Click_2;
            // 
            // signup_link
            // 
            signup_link.AutoSize = true;
            signup_link.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_link.LinkColor = Color.Maroon;
            signup_link.Location = new Point(637, 440);
            signup_link.Name = "signup_link";
            signup_link.Size = new Size(168, 28);
            signup_link.TabIndex = 9;
            signup_link.TabStop = true;
            signup_link.Text = "Create an account";
            signup_link.LinkClicked += signup_link_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(435, 445);
            label4.Name = "label4";
            label4.Size = new Size(196, 23);
            label4.TabIndex = 8;
            label4.Text = "Don't have an account ?";
            // 
            // login_checkBox
            // 
            login_checkBox.AutoSize = true;
            login_checkBox.ForeColor = SystemColors.ControlDarkDark;
            login_checkBox.Location = new Point(733, 302);
            login_checkBox.Name = "login_checkBox";
            login_checkBox.Size = new Size(132, 24);
            login_checkBox.TabIndex = 7;
            login_checkBox.Text = "Show Password";
            login_checkBox.UseVisualStyleBackColor = true;
            // 
            // login_button
            // 
            login_button.BackColor = Color.Peru;
            login_button.Font = new Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_button.Location = new Point(435, 321);
            login_button.Name = "login_button";
            login_button.Size = new Size(198, 56);
            login_button.TabIndex = 6;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // login_password
            // 
            login_password.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(435, 243);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(430, 31);
            login_password.TabIndex = 5;
            login_password.TextChanged += login_password_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(435, 203);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(436, 116);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 2;
            label2.Text = "Username";
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
            // login_username
            // 
            login_username.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(435, 158);
            login_username.Name = "login_username";
            login_username.PasswordChar = '*';
            login_username.Size = new Size(430, 31);
            login_username.TabIndex = 11;
            login_username.TextChanged += this.login_username_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 512);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private CheckBox login_checkBox;
        private Button login_button;
        private TextBox login_password;
        private Label label3;
        private Label label4;
        private LinkLabel signup_link;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label login_close;
        private TextBox login_username;
    }
}
