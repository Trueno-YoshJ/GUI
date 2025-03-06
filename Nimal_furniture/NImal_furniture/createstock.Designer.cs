namespace NImal_furniture
{
    partial class create_client
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_price = new TextBox();
            tb_name = new TextBox();
            tb_type = new TextBox();
            tb_qty = new TextBox();
            btn_save = new Button();
            btn_cancel = new Button();
            lbId = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 48);
            label2.Name = "label2";
            label2.Size = new Size(95, 24);
            label2.TabIndex = 1;
            label2.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 94);
            label3.Name = "label3";
            label3.Size = new Size(121, 24);
            label3.TabIndex = 2;
            label3.Text = "Product name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 195);
            label4.Name = "label4";
            label4.Size = new Size(77, 24);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 144);
            label5.Name = "label5";
            label5.Size = new Size(113, 24);
            label5.TabIndex = 4;
            label5.Text = "Product type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(61, 242);
            label6.Name = "label6";
            label6.Size = new Size(49, 24);
            label6.TabIndex = 5;
            label6.Text = "Price";
            // 
            // tb_price
            // 
            tb_price.Location = new Point(214, 239);
            tb_price.Name = "tb_price";
            tb_price.PlaceholderText = "$";
            tb_price.Size = new Size(303, 27);
            tb_price.TabIndex = 7;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(214, 94);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(303, 27);
            tb_name.TabIndex = 8;
            // 
            // tb_type
            // 
            tb_type.Location = new Point(214, 141);
            tb_type.Name = "tb_type";
            tb_type.Size = new Size(303, 27);
            tb_type.TabIndex = 9;
            // 
            // tb_qty
            // 
            tb_qty.Location = new Point(214, 192);
            tb_qty.Name = "tb_qty";
            tb_qty.Size = new Size(303, 27);
            tb_qty.TabIndex = 10;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.SaddleBrown;
            btn_save.ForeColor = Color.Gold;
            btn_save.Location = new Point(157, 317);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(142, 36);
            btn_save.TabIndex = 11;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.SaddleBrown;
            btn_cancel.ForeColor = Color.Gold;
            btn_cancel.Location = new Point(328, 317);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(142, 36);
            btn_cancel.TabIndex = 12;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(214, 48);
            lbId.Name = "lbId";
            lbId.Size = new Size(0, 20);
            lbId.TabIndex = 13;
            // 
            // create_client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(554, 450);
            Controls.Add(lbId);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(tb_qty);
            Controls.Add(tb_type);
            Controls.Add(tb_name);
            Controls.Add(tb_price);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "create_client";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "create_client";
            Load += create_client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_price;
        private TextBox tb_name;
        private TextBox tb_type;
        private TextBox tb_qty;
        private Button btn_save;
        private Button btn_cancel;
        private Label lbId;
    }
}