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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            clientstable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)clientstable).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 56);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Product name";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += name_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(536, 56);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Price";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(405, 56);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Quantity";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += qty_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(274, 56);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Product type";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += type_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 56);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Id";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 5;
            textBox6.TextChanged += Id_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(448, 86);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Insert_btn;
            // 
            // button2
            // 
            button2.Location = new Point(681, 86);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Delete_btn;
            // 
            // button3
            // 
            button3.Location = new Point(567, 86);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
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
            clientstable.Size = new Size(763, 317);
            clientstable.TabIndex = 9;
            clientstable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clientstable);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Inventory";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)clientstable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView clientstable;
    }
}