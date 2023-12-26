namespace kkk
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            column_ID = new DataGridViewTextBoxColumn();
            customer_name = new DataGridViewTextBoxColumn();
            column_Phone = new DataGridViewTextBoxColumn();
            column_City = new DataGridViewTextBoxColumn();
            customer_status = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            delete_button = new Button();
            rewrite_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { column_ID, customer_name, column_Phone, column_City, customer_status });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(922, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // column_ID
            // 
            column_ID.HeaderText = "ID";
            column_ID.MinimumWidth = 6;
            column_ID.Name = "column_ID";
            column_ID.ReadOnly = true;
            column_ID.Width = 125;
            // 
            // customer_name
            // 
            customer_name.HeaderText = "Name";
            customer_name.MinimumWidth = 6;
            customer_name.Name = "customer_name";
            customer_name.ReadOnly = true;
            customer_name.Width = 125;
            // 
            // column_Phone
            // 
            column_Phone.HeaderText = "Phone";
            column_Phone.MinimumWidth = 6;
            column_Phone.Name = "column_Phone";
            column_Phone.ReadOnly = true;
            column_Phone.Width = 125;
            // 
            // column_City
            // 
            column_City.HeaderText = "City";
            column_City.MinimumWidth = 6;
            column_City.Name = "column_City";
            column_City.ReadOnly = true;
            column_City.Width = 125;
            // 
            // customer_status
            // 
            customer_status.HeaderText = "Status";
            customer_status.MinimumWidth = 6;
            customer_status.Name = "customer_status";
            customer_status.ReadOnly = true;
            customer_status.Width = 125;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(676, 0);
            button1.Name = "button1";
            button1.Size = new Size(246, 59);
            button1.TabIndex = 1;
            button1.Text = "Выгрузить данные из базы / \r\nОбновить данные из базы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources._486390_plus_48x48;
            button2.Location = new Point(729, 65);
            button2.Name = "button2";
            button2.Size = new Size(47, 46);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // delete_button
            // 
            delete_button.Image = Properties.Resources.Delete;
            delete_button.Location = new Point(676, 65);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(47, 46);
            delete_button.TabIndex = 3;
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // rewrite_button
            // 
            rewrite_button.Image = Properties.Resources.copiraiting;
            rewrite_button.Location = new Point(782, 65);
            rewrite_button.Name = "rewrite_button";
            rewrite_button.Size = new Size(54, 46);
            rewrite_button.TabIndex = 4;
            rewrite_button.UseVisualStyleBackColor = true;
            rewrite_button.Click += rewrite_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 450);
            Controls.Add(rewrite_button);
            Controls.Add(delete_button);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button delete_button;
        private DataGridViewTextBoxColumn column_ID;
        private DataGridViewTextBoxColumn customer_name;
        private DataGridViewTextBoxColumn column_Phone;
        private DataGridViewTextBoxColumn column_City;
        private DataGridViewTextBoxColumn customer_status;
        private Button rewrite_button;
    }
}
