namespace IT13_Admin_Page
{
    partial class Settings
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
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            groupBox1 = new GroupBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 25);
            label2.Name = "label2";
            label2.Size = new Size(328, 34);
            label2.TabIndex = 1;
            label2.Text = "MANAGE YOUR BARBERSHOP CONFIGURATION\r\n\r\n";
            label2.Click += label2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(849, 557);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(841, 519);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(841, 519);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Scheduling";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(841, 59);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Notifications";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(841, 59);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Appearance";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(37, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(769, 449);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Business Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 82);
            label3.Name = "label3";
            label3.Size = new Size(135, 22);
            label3.TabIndex = 0;
            label3.Text = "Business Name";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(29, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 28);
            textBox1.TabIndex = 1;
            textBox1.Text = "Classic Cuts Barbershop";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 305);
            label7.Name = "label7";
            label7.Size = new Size(141, 22);
            label7.TabIndex = 8;
            label7.Text = "Business Logo";
            // 
            // button1
            // 
            button1.Location = new Point(29, 330);
            button1.Name = "button1";
            button1.Size = new Size(173, 34);
            button1.TabIndex = 9;
            button1.Text = "Upload Image";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(426, 82);
            label4.Name = "label4";
            label4.Size = new Size(130, 22);
            label4.TabIndex = 10;
            label4.Text = "Phone Number";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 170);
            label5.Name = "label5";
            label5.Size = new Size(125, 22);
            label5.TabIndex = 11;
            label5.Text = "Email Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(426, 170);
            label6.Name = "label6";
            label6.Size = new Size(154, 22);
            label6.TabIndex = 12;
            label6.Text = "Business Address";
            label6.Click += label6_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(426, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 28);
            textBox2.TabIndex = 13;
            textBox2.Text = "09097227964";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(29, 208);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 28);
            textBox3.TabIndex = 14;
            textBox3.Text = "It13@gmail.com";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(426, 208);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(277, 28);
            textBox4.TabIndex = 15;
            textBox4.Text = "Davao City";
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(689, 17);
            button2.Name = "button2";
            button2.Size = new Size(121, 32);
            button2.TabIndex = 16;
            button2.Text = "Back to Home";
            button2.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Settings";
            Size = new Size(849, 650);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
    }
}
