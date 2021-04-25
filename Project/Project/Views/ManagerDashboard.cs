using Project.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Views
{
    public partial class ManagerDashboard : Form
    {
        string bustype = "";
        int ticketId = 0;
        int managerId = 0;
        int salesmanId = 0;
        int customerId = 0;
        int busId = 0;

        public ManagerDashboard()
        {
            InitializeComponent();

            reloadTickets();
            reloadManager();
            reloadSalesman();
            reloadCustomer();
            reloadBuses();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void managerLabel_Click(object sender, EventArgs e)
        {
            managerLabel.BackColor = Color.Teal;

            ticketsLabel.BackColor = Color.DimGray;
            salesmanLabel.BackColor = Color.DimGray;
            busesLabel.BackColor = Color.DimGray;
            customersLabel.BackColor = Color.DimGray;

            AdminPanel.Hide();
            salesmanPanel.Hide();
            managersPanel.Show();
            ticketsPanel.Hide();
            busesPanel.Hide();
            customersPanel.Hide();

            homeLabel.Visible = true;

        }

        private void salesmanLabel_Click(object sender, EventArgs e)
        {
            salesmanLabel.BackColor = Color.Teal;

            ticketsLabel.BackColor = Color.DimGray;
            managerLabel.BackColor = Color.DimGray;
            busesLabel.BackColor = Color.DimGray;
            customersLabel.BackColor = Color.DimGray;

            AdminPanel.Hide();
            managersPanel.Hide();
            salesmanPanel.Show();
            ticketsPanel.Hide();
            busesPanel.Hide();
            customersPanel.Hide();

            homeLabel.Visible = true;
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            salesmanLabel.BackColor = Color.DimGray;
            ticketsLabel.BackColor = Color.DimGray;
            managerLabel.BackColor = Color.DimGray;
            busesLabel.BackColor = Color.DimGray;
            customersLabel.BackColor = Color.DimGray;

            AdminPanel.Show();
            managersPanel.Hide();
            salesmanPanel.Hide();
            ticketsPanel.Hide();
            busesPanel.Hide();
            customersPanel.Hide();

            homeLabel.Visible = false;
        }

        private void tickets_Click_2(object sender, EventArgs e)
        {
            ticketsLabel.BackColor = Color.Teal;

            salesmanLabel.BackColor = Color.DimGray;
            managerLabel.BackColor = Color.DimGray;
            busesLabel.BackColor = Color.DimGray;
            customersLabel.BackColor = Color.DimGray;

            AdminPanel.Hide();
            managersPanel.Hide();
            salesmanPanel.Hide();
            busesPanel.Hide();
            customersPanel.Hide();

            ticketsPanel.Show();

            homeLabel.Visible = true;
        }

        private void busesLabel_Click(object sender, EventArgs e)
        {
            busesLabel.BackColor = Color.Teal;

            ticketsLabel.BackColor = Color.DimGray;
            salesmanLabel.BackColor = Color.DimGray;
            managerLabel.BackColor = Color.DimGray;
            customersLabel.BackColor = Color.DimGray;

            AdminPanel.Hide();
            managersPanel.Hide();
            salesmanPanel.Hide();
            ticketsPanel.Hide();
            customersPanel.Hide();

            busesPanel.Show();

            homeLabel.Visible = true;
        }

        private void customersLabel_Click(object sender, EventArgs e)
        {
            customersLabel.BackColor = Color.Teal;

            ticketsLabel.BackColor = Color.DimGray;
            salesmanLabel.BackColor = Color.DimGray;
            managerLabel.BackColor = Color.DimGray;
            busesLabel.BackColor = Color.DimGray;

            AdminPanel.Hide();
            managersPanel.Hide();
            salesmanPanel.Hide();
            ticketsPanel.Hide();
            busesPanel.Hide();

            customersPanel.Show();

            homeLabel.Visible = true;
        }

        public void reloadManager()
        {

            managerName.Text = "";
            managerUsername.Text = "";
            managerPassword.Text = "";
            managerSearchBox.Text = "";

            managerId = 0;
            managerTrash.Visible = false;
            managerAddBtn.Enabled = true;

            dynamic managerlist = ManagersController.getAllManager();
            managerGridView.DataSource = managerlist;
        }
        public void reloadTickets()
        {
            ticketId = 0;
            customerName.Text = "";
            phoneBox.Text = "";
            ticketSource.Text = "From";
            ticketDest.Text = "To";
            coachBox.Text = "Coach";
            acRadioButton.Checked = false;
            nonAcRadioButton.Checked = false;
            journeyDate.Text = DateTime.Now.ToShortDateString();
            journeyTime.Text = "Time";

            journeyDate.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            // for manager and salesman
            journeyDate.MaxDate = DateTime.Parse(DateTime.Now.AddDays(6).ToShortDateString());

            ticketBookBtn.Enabled = true;
            trashTicket.Visible = false;

            var tickets = TicketsController.getAllTickets();
            ticketsGridView.DataSource = tickets;
        }
        public void reloadSalesman()
        {
            salesmanName.Text = "";
            salesmanUsername.Text = "";
            salesmanPassword.Text = "";
            salesmanSearchBox.Text = "";

            salesmanId = 0;
            salesmanAddBtn.Enabled = true;
            salesmanTrash.Visible = false;

            dynamic salesmanlist = SalesmanController.getAllSalesman();
            salesmanGridView.DataSource = salesmanlist;
        }
        public void reloadCustomer()
        {
            customerId = 0;
            customerNameBox.Text = "";
            customerPhoneBox.Text = "";
            customerSearchBox.Text = "";
            customerTrash.Visible = false;

            var customerlist = CustomerController.getAllCustomer();
            customerGridView.DataSource = customerlist;
        }
        public void reloadBuses()
        {
            busSearchBox.Text = "";
            busCoachBox.Text = "";
            busAcRadio.Checked = false;
            busNonAcRadio.Checked = false;

            busId = 0;

            busTrash.Visible = false;
            busAddBtn.Enabled = true;

            var bus = BusesController.getAllBus();
            busGridView.DataSource = bus;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
