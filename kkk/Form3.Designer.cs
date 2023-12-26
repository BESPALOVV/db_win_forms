namespace kkk
{
    partial class Form3
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
        public void InitializeComponent()
        {
            label1 = new Label();
            tb_phone = new TextBox();
            tb_City = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button_add = new Button();
            tb_name1 = new TextBox();
            label4 = new Label();
            cb_status = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // tb_phone
            // 
            tb_phone.BorderStyle = BorderStyle.FixedSingle;
            tb_phone.Location = new Point(25, 39);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(179, 27);
            tb_phone.TabIndex = 2;
            // 
            // tb_City
            // 
            tb_City.BorderStyle = BorderStyle.FixedSingle;
            tb_City.ForeColor = Color.DarkBlue;
            tb_City.Location = new Point(210, 39);
            tb_City.Name = "tb_City";
            tb_City.Size = new Size(179, 27);
            tb_City.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 9);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 4;
            label2.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 9);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Phone";
            // 
            // button_add
            // 
            button_add.Location = new Point(343, 72);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 6;
            button_add.Text = "Изменить";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // tb_name1
            // 
            tb_name1.BorderStyle = BorderStyle.FixedSingle;
            tb_name1.Location = new Point(395, 39);
            tb_name1.Name = "tb_name1";
            tb_name1.Size = new Size(179, 27);
            tb_name1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Location = new Point(455, 9);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Name";
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Items.AddRange(new object[] { "VIP", "Standart", "BANNED" });
            cb_status.Location = new Point(580, 39);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(151, 28);
            cb_status.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(622, 9);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 10;
            label5.Text = "Status";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 107);
            Controls.Add(label5);
            Controls.Add(cb_status);
            Controls.Add(label4);
            Controls.Add(tb_name1);
            Controls.Add(button_add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_City);
            Controls.Add(tb_phone);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox tb_phone;
        private TextBox tb_City;
        private Label label2;
        private Label label3;
        private Button button_add;
        private TextBox tb_name1;
        private Label label4;
        private ComboBox cb_status;
        private Label label5;
    }
}