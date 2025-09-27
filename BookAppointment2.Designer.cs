namespace IT13_Admin_Page
{
    partial class BookAppointment2
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
            label12 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            monthCalendar1 = new MonthCalendar();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(15, 11);
            label12.Name = "label12";
            label12.Size = new Size(188, 25);
            label12.TabIndex = 9;
            label12.Text = "Book Appointment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(221, 72);
            label1.Name = "label1";
            label1.Size = new Size(24, 26);
            label1.TabIndex = 10;
            label1.Text = "1";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(265, 84);
            panel5.Name = "panel5";
            panel5.Size = new Size(50, 5);
            panel5.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(344, 72);
            label2.Name = "label2";
            label2.Size = new Size(24, 26);
            label2.TabIndex = 13;
            label2.Text = "2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(391, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 5);
            panel1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(466, 72);
            label3.Name = "label3";
            label3.Size = new Size(24, 26);
            label3.TabIndex = 14;
            label3.Text = "3";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGray;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(593, 72);
            label4.Name = "label4";
            label4.Size = new Size(24, 26);
            label4.TabIndex = 15;
            label4.Text = "4";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(518, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(50, 5);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(monthCalendar1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(0, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(849, 543);
            panel3.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(62, 64, 80);
            button1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(245, 240, 246);
            button1.Location = new Point(618, 481);
            button1.Name = "button1";
            button1.Size = new Size(121, 32);
            button1.TabIndex = 18;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(89, 471);
            button2.Name = "button2";
            button2.Size = new Size(121, 32);
            button2.TabIndex = 17;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(89, 17);
            label5.Name = "label5";
            label5.Size = new Size(185, 22);
            label5.TabIndex = 0;
            label5.Text = "Pick Date and Time";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(89, 96);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(185, 73);
            label6.Name = "label6";
            label6.Size = new Size(103, 22);
            label6.TabIndex = 20;
            label6.Text = "Select Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(439, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 21;
            // 
            // BookAppointment2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(panel5);
            Controls.Add(label1);
            Controls.Add(label12);
            Name = "BookAppointment2";
            Size = new Size(849, 650);
            Load += BookAppointment2_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label1;
        private Panel panel5;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Label label5;
        private MonthCalendar monthCalendar1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
    }
}
