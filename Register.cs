using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT13_Admin_Page
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }


        private void signInBtn_MouseEnter(object sender, EventArgs e)
        {
            signInBtn.ForeColor = Color.Blue;
            signInBtn.Font = new Font(signInBtn.Font, FontStyle.Underline);
        }

        private void signInBtn_MouseLeave(object sender, EventArgs e)
        {
            signInBtn.ForeColor = Color.Black;
            signInBtn.Font = new Font(signInBtn.Font, FontStyle.Regular);
        }
    }
}
