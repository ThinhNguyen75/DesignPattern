using quanlyxekhach.StrateryPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyxekhach
{
    public partial class AccountManagement : Form
    {
        public AccountManagement()
        {
            InitializeComponent();
        }
        private void btnChangeDataAcc_Click(object sender, EventArgs e)
        {
   /*         if (myTextBox1.ivalidation.valid(myTextBox1.Text)) // code mẫu cách gọi mytextbox
            {
                textBox1.Text = "bạn đã nhập đúng định dạng";
            }
            else
            {
                textBox1.Text = "sai định dạng";
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }
    }
}
