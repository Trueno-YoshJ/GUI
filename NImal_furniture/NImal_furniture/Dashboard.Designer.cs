namespace NImal_furniture
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            button4 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 512);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(21, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(451, 380);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(488, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 389);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.Peru;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(208, 330);
            button4.Name = "button4";
            button4.Size = new Size(154, 43);
            button4.TabIndex = 3;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += update_btn;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(159, 102);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(203, 27);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += txtCurrentStock;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(159, 160);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(203, 27);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += txtStockValue;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 27);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += txtRemainingTime;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 271);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 27);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += txtLastUpdate;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 44);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Hello";
            textBox1.Size = new Size(203, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textbox1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 274);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 7;
            label5.Text = "Last update         :";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 214);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 6;
            label4.Text = "Remaining time  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 102);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 5;
            label3.Text = "Current Stock       :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 160);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 4;
            label2.Text = "Stock Value          :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 47);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 3;
            label1.Text = "Sales Progress     :";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Wheat;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(-6, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 46);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(385, 3);
            button1.Name = "button1";
            button1.Size = new Size(178, 40);
            button1.TabIndex = 2;
            button1.Text = "Orders";
            button1.UseVisualStyleBackColor = false;
            button1.Click += orders_btn;
            // 
            // button2
            // 
            button2.BackColor = Color.SaddleBrown;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Gold;
            button2.Location = new Point(201, 3);
            button2.Name = "button2";
            button2.Size = new Size(178, 40);
            button2.TabIndex = 3;
            button2.Text = "Inventory";
            button2.UseVisualStyleBackColor = false;
            button2.Click += inventory_btn;
            // 
            // button3
            // 
            button3.BackColor = Color.SaddleBrown;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Gold;
            button3.Location = new Point(17, 3);
            button3.Name = "button3";
            button3.Size = new Size(178, 40);
            button3.TabIndex = 4;
            button3.Text = "DashBoard";
            button3.UseVisualStyleBackColor = false;
            button3.Click += dashboard_btn;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 512);
            Controls.Add(panel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel3;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button button4;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox2;
    }
}