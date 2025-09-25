namespace IT13_Admin_Page
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            input_PNL = new Panel();
            signInBtn = new Label();
            label4 = new Label();
            registerBtn = new Button();
            textBox1 = new TextBox();
            passwordTb = new TextBox();
            emailTb = new TextBox();
            label5 = new Label();
            unameTb = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            cntrl_PNL = new Panel();
            mnmz_BTN = new FontAwesome.Sharp.IconButton();
            mxmz_BTN = new FontAwesome.Sharp.IconButton();
            clse_BTN = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label7 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            progressBar1 = new ProgressBar();
            input_PNL.SuspendLayout();
            cntrl_PNL.SuspendLayout();
            SuspendLayout();
            // 
            // input_PNL
            // 
            input_PNL.Controls.Add(progressBar1);
            input_PNL.Controls.Add(signInBtn);
            input_PNL.Controls.Add(label4);
            input_PNL.Controls.Add(registerBtn);
            input_PNL.Controls.Add(textBox1);
            input_PNL.Controls.Add(passwordTb);
            input_PNL.Controls.Add(emailTb);
            input_PNL.Controls.Add(label5);
            input_PNL.Controls.Add(textBox4);
            input_PNL.Controls.Add(textBox2);
            input_PNL.Controls.Add(textBox3);
            input_PNL.Controls.Add(unameTb);
            input_PNL.Controls.Add(label3);
            input_PNL.Controls.Add(label6);
            input_PNL.Controls.Add(label9);
            input_PNL.Controls.Add(label8);
            input_PNL.Controls.Add(label7);
            input_PNL.Controls.Add(label2);
            input_PNL.Controls.Add(label1);
            input_PNL.Dock = DockStyle.Left;
            input_PNL.Location = new Point(0, 35);
            input_PNL.Name = "input_PNL";
            input_PNL.Size = new Size(362, 367);
            input_PNL.TabIndex = 19;
            // 
            // signInBtn
            // 
            signInBtn.AutoSize = true;
            signInBtn.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signInBtn.ForeColor = SystemColors.ControlDarkDark;
            signInBtn.Location = new Point(246, 337);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(50, 22);
            signInBtn.TabIndex = 5;
            signInBtn.Text = "Sign in";
            signInBtn.MouseEnter += signInBtn_MouseEnter;
            signInBtn.MouseLeave += signInBtn_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(83, 337);
            label4.Name = "label4";
            label4.Size = new Size(169, 22);
            label4.TabIndex = 5;
            label4.Text = "Already have an account?";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(229, 149, 0);
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerBtn.Location = new Point(123, 299);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(128, 34);
            registerBtn.TabIndex = 4;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Inter", 9F);
            textBox1.Location = new Point(35, 258);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(295, 22);
            textBox1.TabIndex = 3;
            // 
            // passwordTb
            // 
            passwordTb.Font = new Font("Inter", 9F);
            passwordTb.Location = new Point(35, 211);
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.Size = new Size(295, 22);
            passwordTb.TabIndex = 3;
            // 
            // emailTb
            // 
            emailTb.Font = new Font("Inter", 9F);
            emailTb.Location = new Point(33, 118);
            emailTb.Name = "emailTb";
            emailTb.Size = new Size(297, 22);
            emailTb.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Inter", 9F);
            label5.ForeColor = Color.FromArgb(62, 64, 80);
            label5.Location = new Point(35, 241);
            label5.Name = "label5";
            label5.Size = new Size(110, 14);
            label5.TabIndex = 2;
            label5.Text = "Confirm Password";
            // 
            // unameTb
            // 
            unameTb.Font = new Font("Inter", 9F);
            unameTb.Location = new Point(33, 72);
            unameTb.Name = "unameTb";
            unameTb.Size = new Size(145, 22);
            unameTb.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Inter", 9F);
            label3.ForeColor = Color.FromArgb(62, 64, 80);
            label3.Location = new Point(35, 194);
            label3.Name = "label3";
            label3.Size = new Size(63, 14);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Inter", 9F);
            label6.ForeColor = Color.FromArgb(62, 64, 80);
            label6.Location = new Point(35, 101);
            label6.Name = "label6";
            label6.Size = new Size(37, 14);
            label6.TabIndex = 1;
            label6.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Inter", 9F);
            label2.ForeColor = Color.FromArgb(62, 64, 80);
            label2.Location = new Point(33, 55);
            label2.Name = "label2";
            label2.Size = new Size(68, 14);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 18F);
            label1.ForeColor = Color.FromArgb(62, 64, 80);
            label1.Location = new Point(128, 11);
            label1.Name = "label1";
            label1.Size = new Size(116, 42);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // cntrl_PNL
            // 
            cntrl_PNL.BackColor = Color.FromArgb(62, 64, 80);
            cntrl_PNL.Controls.Add(mnmz_BTN);
            cntrl_PNL.Controls.Add(mxmz_BTN);
            cntrl_PNL.Controls.Add(clse_BTN);
            cntrl_PNL.Dock = DockStyle.Top;
            cntrl_PNL.Location = new Point(0, 0);
            cntrl_PNL.Name = "cntrl_PNL";
            cntrl_PNL.Padding = new Padding(0, 5, 5, 0);
            cntrl_PNL.Size = new Size(741, 35);
            cntrl_PNL.TabIndex = 17;
            // 
            // mnmz_BTN
            // 
            mnmz_BTN.Dock = DockStyle.Right;
            mnmz_BTN.FlatAppearance.BorderSize = 0;
            mnmz_BTN.FlatStyle = FlatStyle.Flat;
            mnmz_BTN.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            mnmz_BTN.IconColor = Color.WhiteSmoke;
            mnmz_BTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mnmz_BTN.IconSize = 20;
            mnmz_BTN.Location = new Point(661, 5);
            mnmz_BTN.Name = "mnmz_BTN";
            mnmz_BTN.Size = new Size(25, 30);
            mnmz_BTN.TabIndex = 12;
            mnmz_BTN.UseVisualStyleBackColor = true;
            // 
            // mxmz_BTN
            // 
            mxmz_BTN.Dock = DockStyle.Right;
            mxmz_BTN.FlatAppearance.BorderSize = 0;
            mxmz_BTN.FlatStyle = FlatStyle.Flat;
            mxmz_BTN.IconChar = FontAwesome.Sharp.IconChar.Expand;
            mxmz_BTN.IconColor = Color.WhiteSmoke;
            mxmz_BTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mxmz_BTN.IconSize = 20;
            mxmz_BTN.Location = new Point(686, 5);
            mxmz_BTN.Name = "mxmz_BTN";
            mxmz_BTN.Size = new Size(25, 30);
            mxmz_BTN.TabIndex = 11;
            mxmz_BTN.UseVisualStyleBackColor = true;
            // 
            // clse_BTN
            // 
            clse_BTN.Dock = DockStyle.Right;
            clse_BTN.FlatAppearance.BorderSize = 0;
            clse_BTN.FlatStyle = FlatStyle.Flat;
            clse_BTN.IconChar = FontAwesome.Sharp.IconChar.SquareXmark;
            clse_BTN.IconColor = Color.IndianRed;
            clse_BTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            clse_BTN.IconSize = 25;
            clse_BTN.Location = new Point(711, 5);
            clse_BTN.Name = "clse_BTN";
            clse_BTN.Size = new Size(25, 30);
            clse_BTN.TabIndex = 10;
            clse_BTN.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(368, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 367);
            panel1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Inter", 9F);
            label7.ForeColor = Color.FromArgb(62, 64, 80);
            label7.Location = new Point(184, 55);
            label7.Name = "label7";
            label7.Size = new Size(67, 14);
            label7.TabIndex = 1;
            label7.Text = "Last Name";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Inter", 9F);
            textBox2.Location = new Point(184, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 22);
            textBox2.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Inter", 9F);
            label8.ForeColor = Color.FromArgb(62, 64, 80);
            label8.Location = new Point(34, 147);
            label8.Name = "label8";
            label8.Size = new Size(100, 14);
            label8.TabIndex = 1;
            label8.Text = "Contact Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Inter", 9F);
            label9.ForeColor = Color.FromArgb(62, 64, 80);
            label9.Location = new Point(185, 147);
            label9.Name = "label9";
            label9.Size = new Size(58, 14);
            label9.TabIndex = 1;
            label9.Text = "Birthdate";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Inter", 9F);
            textBox3.Location = new Point(34, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 22);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Inter", 9F);
            textBox4.Location = new Point(185, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(145, 22);
            textBox4.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(35, 286);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(295, 5);
            progressBar1.TabIndex = 6;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 402);
            Controls.Add(panel1);
            Controls.Add(input_PNL);
            Controls.Add(cntrl_PNL);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            input_PNL.ResumeLayout(false);
            input_PNL.PerformLayout();
            cntrl_PNL.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel input_PNL;
        private Label label4;
        private Button registerBtn;
        private TextBox passwordTb;
        private TextBox unameTb;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel cntrl_PNL;
        private FontAwesome.Sharp.IconButton mnmz_BTN;
        private FontAwesome.Sharp.IconButton mxmz_BTN;
        private FontAwesome.Sharp.IconButton clse_BTN;
        private Label signInBtn;
        private Panel panel1;
        private TextBox emailTb;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label7;
        private ProgressBar progressBar1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label9;
        private Label label8;
    }
}