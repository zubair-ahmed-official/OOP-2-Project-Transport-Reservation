using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project.Controllers;
using Project.Views;

namespace Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTB.Text.Trim();
            string password = passwordTB.Text.Trim();
            string role = comboBox.Text.ToString().Trim();

            if(username.Length==0 || password.Length == 0)
            {
                MessageBox.Show("Fill all the required field");
                return;
            }
            
            if (role.ToLower().Equals("admin") || role.ToLower().Equals("managers") || role.ToLower().Equals("salesman"))
            {
                var result = AuthenticateController.AuthController(username, password, role);
                
                if(result == null)
                {
                    MessageBox.Show("Invalid Credentials");
                    return;
                }

                if (role.ToLower().Equals("admin"))
                {
                    this.Hide();
                    new AdminDashboard().Show();
                }
                else if (role.ToLower().Equals("salesman"))
                {
                    this.Hide();
                    new SalesManDashBoard().Show();
                    //MessageBox.Show("Salesman Dashboard Will be Created");
                }
                else if (role.ToLower().Equals("managers"))
                {
                    this.Hide();
                    new ManagerDashboard().Show();
                }
            }
            else MessageBox.Show("Choose a Valid Role");
            
        }
    }
}
