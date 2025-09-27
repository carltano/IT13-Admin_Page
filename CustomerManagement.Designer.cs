namespace IT13_Admin_Page
{
    partial class CustomerManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel5 = new Panel();
            label17 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            Customer = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            LastVisit = new DataGridViewTextBoxColumn();
            Totalvisit = new DataGridViewTextBoxColumn();
            Spent = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewTextBoxColumn();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(236, 25);
            label1.TabIndex = 1;
            label1.Text = "Customer Management";
            // 
            // panel5
            // 
            panel5.BackColor = Color.SkyBlue;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Font = new Font("Microsoft Sans Serif", 8F);
            panel5.Location = new Point(26, 79);
            panel5.Name = "panel5";
            panel5.Size = new Size(179, 83);
            panel5.TabIndex = 4;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(17, 5);
            label17.Name = "label17";
            label17.Size = new Size(131, 20);
            label17.TabIndex = 2;
            label17.Text = "Total Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(28, 58);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 1;
            label3.Text = "+50 From last month";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 33);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 0;
            label2.Text = "300";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Font = new Font("Microsoft Sans Serif", 8F);
            panel1.Location = new Point(425, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 83);
            panel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 5);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 2;
            label4.Text = "Ave Visit/Month";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGoldenrod;
            label5.Location = new Point(32, 58);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 1;
            label5.Text = "+0.3 from last month";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(56, 33);
            label6.Name = "label6";
            label6.Size = new Size(31, 17);
            label6.TabIndex = 0;
            label6.Text = "2.4";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Font = new Font("Microsoft Sans Serif", 8F);
            panel2.Location = new Point(222, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 83);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 5);
            label7.Name = "label7";
            label7.Size = new Size(140, 20);
            label7.TabIndex = 2;
            label7.Text = "Active Customer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 192, 0);
            label8.Location = new Point(38, 58);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 1;
            label8.Text = "82% retention rate";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(56, 33);
            label9.Name = "label9";
            label9.Size = new Size(32, 17);
            label9.TabIndex = 0;
            label9.Text = "299";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MistyRose;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Font = new Font("Microsoft Sans Serif", 8F);
            panel3.Location = new Point(637, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(188, 83);
            panel3.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(-1, 5);
            label10.Name = "label10";
            label10.Size = new Size(187, 20);
            label10.TabIndex = 2;
            label10.Text = "Customer Satisfaction";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(29, 58);
            label11.Name = "label11";
            label11.Size = new Size(126, 15);
            label11.TabIndex = 1;
            label11.Text = "based on 156 reviews";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(56, 33);
            label12.Name = "label12";
            label12.Size = new Size(45, 17);
            label12.TabIndex = 0;
            label12.Text = "4.8/5";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 201);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(798, 91);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(555, 227);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(694, 227);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "Export";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(438, 31);
            textBox2.TabIndex = 10;
            textBox2.Text = "Search customers by name or email....";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Customer, Contact, LastVisit, Totalvisit, Spent, Status, Actions });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 298);
            dataGridView1.Margin = new Padding(1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(849, 352);
            dataGridView1.TabIndex = 11;
            // 
            // Customer
            // 
            Customer.HeaderText = "Customer";
            Customer.MinimumWidth = 8;
            Customer.Name = "Customer";
            Customer.Width = 150;
            // 
            // Contact
            // 
            Contact.HeaderText = "Contact";
            Contact.MinimumWidth = 8;
            Contact.Name = "Contact";
            Contact.Width = 150;
            // 
            // LastVisit
            // 
            LastVisit.HeaderText = "LastVisit";
            LastVisit.MinimumWidth = 8;
            LastVisit.Name = "LastVisit";
            LastVisit.Width = 150;
            // 
            // Totalvisit
            // 
            Totalvisit.HeaderText = "TotalVisit";
            Totalvisit.MinimumWidth = 8;
            Totalvisit.Name = "Totalvisit";
            Totalvisit.Width = 150;
            // 
            // Spent
            // 
            Spent.HeaderText = "Spent";
            Spent.MinimumWidth = 8;
            Spent.Name = "Spent";
            Spent.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.MinimumWidth = 8;
            Actions.Name = "Actions";
            Actions.Width = 150;
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(label1);
            Name = "CustomerManagement";
            Size = new Size(849, 650);
            Load += CustomerManagement_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel5;
        private Label label17;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel3;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn LastVisit;
        private DataGridViewTextBoxColumn Totalvisit;
        private DataGridViewTextBoxColumn Spent;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Actions;
    }
}
