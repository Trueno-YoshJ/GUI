namespace Nimal_furniture
{
    partial class Inventory
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            clientstable = new DataGridView();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)clientstable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.SaddleBrown;
            button1.Font = new Font("Segoe UI Variable Small", 10.8F, FontStyle.Bold);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(454, 1);
            button1.Name = "button1";
            button1.Size = new Size(140, 49);
            button1.TabIndex = 6;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Insert_btn;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.SaddleBrown;
            button2.Font = new Font("Segoe UI Variable Small", 10.8F, FontStyle.Bold);
            button2.ForeColor = Color.Gold;
            button2.Location = new Point(746, 0);
            button2.Name = "button2";
            button2.Size = new Size(140, 48);
            button2.TabIndex = 7;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Delete_btn;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.SaddleBrown;
            button3.Font = new Font("Segoe UI Variable Small", 10.8F, FontStyle.Bold);
            button3.ForeColor = Color.Gold;
            button3.Location = new Point(600, 0);
            button3.Name = "button3";
            button3.Size = new Size(140, 50);
            button3.TabIndex = 8;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Update_btn;
            // 
            // clientstable
            // 
            clientstable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clientstable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientstable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientstable.Location = new Point(12, 121);
            clientstable.MultiSelect = false;
            clientstable.Name = "clientstable";
            clientstable.RowHeadersWidth = 51;
            clientstable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientstable.Size = new Size(867, 379);
            clientstable.TabIndex = 9;
            clientstable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = NImal_furniture.Properties.Resources.toplogo1;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-7, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(901, 52);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(845, 12);
            label1.Name = "label1";
            label1.Size = new Size(34, 34);
            label1.TabIndex = 12;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(891, 512);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(clientstable);
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)clientstable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView clientstable;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
    }
}