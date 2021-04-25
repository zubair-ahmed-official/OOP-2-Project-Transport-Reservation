using Project.Controllers;
using Project.Models;
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
    public partial class SalesManDashBoard : Form
    {
        string bustype = "";
        int ticketId = 0;
        int managerId = 0;
        int salesmanId = 0;
        int customerId = 0;
        int busId = 0;
        int adminId = 0;

        public SalesManDashBoard()
        {
            InitializeComponent();
            reloadTickets();
            reloadBuses();
            reloadCustomer();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }
        private void HomeLabelClick(object sender, EventArgs e)
        {
            TicketsPanel.Hide();
            WelcomePanel.Show();
        }

        private void TickectsClick(object sender, EventArgs e)
        {

            TicketsPanel.Show();
            WelcomePanel.Hide();
            BusesPanel.Hide();
            CustomersPanel.Hide();
            HomeLabel.Visible = true;
        }

        private void BusClick(object sender, EventArgs e)
        {
            BusesPanel.Show();
            CustomersPanel.Hide();
            TicketsPanel.Hide();
            WelcomePanel.Hide();
            HomeLabel.Visible = true;
        }

        private void CustomersClick(object sender, EventArgs e)
        {
            CustomersPanel.Show();
            TicketsPanel.Hide();
            WelcomePanel.Hide();
            BusesPanel.Hide();
            HomeLabel.Visible = true;
        }

        private void SearchClick(object sender, EventArgs e)
        {
            string phone = phoneBox.Text;
            var customer = CustomerController.searchCustomer(phone);
            if (customer != null)
            {
                customerName.Text = customer.Name;
            }
            else customerName.Text = "";
        }

        private void TicketCancelClick(object sender, EventArgs e)
        {
            bool res = TicketsController.cancelTicket(ticketId);
            if (res) { reloadTickets(); MessageBox.Show("Ticket Cancelled"); }
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            var ticket = new
            {
                id = ticketId,
                name = customerName.Text.Trim(),
                phone = phoneBox.Text.Trim(),
                source = ticketSource.Text.Trim(),
                destination = ticketDest.Text.Trim(),
                coach = coachBox.Text.Trim(),
                type = bustype,
                date = journeyDate.Value.ToShortDateString(),
                time = journeyTime.Text.Trim()
            };

            bool res = TicketsController.updateTicket(ticket);
            if (res) { reloadTickets(); MessageBox.Show("Ticket updated"); }
        }

        private void BookTickets(object sender, EventArgs e)
        {
            var ticket = new
            {
                name = customerName.Text.Trim(),
                phone = phoneBox.Text.Trim(),
                source = ticketSource.Text.Trim(),
                destination = ticketDest.Text.Trim(),
                coach = coachBox.Text.Trim(),
                type = bustype,
                date = journeyDate.Value.ToShortDateString(),
                time = journeyTime.Text.Trim()
            };
            if (ticket.name.Length == 0 || ticket.phone.Length == 0 || ticket.source.Equals("Source") || ticket.destination.Equals("To") ||
                ticket.coach.Equals("Coach") || ticket.type.Length == 0 || ticket.time.Equals("Time"))
            {
                MessageBox.Show("Fill all the required fields");
                return;
            }
            try
            {
                bool res = TicketsController.boolTicket(ticket);
                if (res)
                {
                    reloadTickets();
                    MessageBox.Show("Ticket booked");
                }
                else MessageBox.Show("Could not booked");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LogoutClick(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void TrashClick(object sender, EventArgs e)
        {
            reloadTickets();
            trashTicket.Visible = false;
        }

        private void managerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ticketsGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       // string bustype = "";
       // private int ticketId = 0;
        public void reloadTickets()
        {
            ticketId = 0;
            customerName.Text = "";
            phoneBox.Text = "";
            ticketSource.Text = "From";
            ticketDest.Text = "To";
            coachBox.Text = "Coach";
            acRadioBtn.Checked = false;
            nonAcRadioBtn.Checked = false;
            journeyDate.Text = DateTime.Now.ToString();
            journeyTime.Text = "";

            ticketBookBtn.Enabled = true;

            var tickets = TicketsController.getAllTickets();
            ticketsGridView.DataSource = tickets;
        }

        private void RadioButtonAC(object sender, EventArgs e)
        {

            bustype = "AC";
        }

        private void RadioButtonNonAC(object sender, EventArgs e)
        {
            bustype = "Non AC";
        }

        private void TicketsGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ticketsGridView.Rows[e.RowIndex];
                ticketId = Int32.Parse(row.Cells["Id"].Value.ToString());
                customerName.Text = row.Cells["Name"].Value.ToString();
                phoneBox.Text = row.Cells["Phone"].Value.ToString();
                ticketSource.Text = row.Cells["Source"].Value.ToString();
                ticketDest.Text = row.Cells["Destination"].Value.ToString();
                coachBox.Text = row.Cells["Coach"].Value.ToString();
                //busType.Text = row.Cells["BusType"].Value.ToString();
                journeyDate.Text = row.Cells["Date"].Value.ToString();
                journeyTime.Text = row.Cells["Time"].Value.ToString();

                var abustype = row.Cells["BusType"].Value.ToString();
                if (abustype.Equals("AC"))
                {
                    acRadioBtn.Checked = true;
                    nonAcRadioBtn.Checked = false;
                }
                else if (abustype == "Non AC")
                {
                    nonAcRadioBtn.Checked = true;
                    acRadioBtn.Checked = false;
                }
                else
                {
                    acRadioBtn.Checked = false;
                    nonAcRadioBtn.Checked = false;
                }

                if (ticketId > 0)
                {
                    ticketBookBtn.Enabled = false;
                }
                trashTicket.Visible = true;
            }

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
        string busTypes = "";
        private void BusACRadioCLick(object sender, EventArgs e)
        {
            busTypes = "AC";
        }

        private void BusNonAcRadioClick(object sender, EventArgs e)
        {
            busTypes = "Non AC";
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

        private void BusAddClick(object sender, EventArgs e)
        {
            var bus = new
            {
                coach = busCoachBox.Text.Trim(),
                type = busTypes,
            };

            bool res = BusesController.addBus(bus);
            if (res) { reloadBuses(); MessageBox.Show("Bus Added"); }
        }

        private void BusSearchClick(object sender, EventArgs e)
        {
            string coach = busSearchBox.Text.Trim();
            var bus = BusesController.searchBus(coach);
            if (bus == null)
            {
                MessageBox.Show("Bus not found");
                return;
            }
            busCoachBox.Text = bus.Coach;
            if (bus.Type == "AC") busAcRadio.Checked = true;
            else busNonAcRadio.Checked = true;

            busId = bus.Id;

            busAddBtn.Enabled = false;
            busTrash.Visible = true;
        }

        private void BusTrashClick(object sender, EventArgs e)
        {
            reloadBuses();
        }

        private void BusUpdateClick(object sender, EventArgs e)
        {
            var bus = new
            {
                id = busId,
                coach = busCoachBox.Text.Trim(),
                type = busTypes,
            };

            bool res = BusesController.updateBus(bus);
            if (res) { reloadBuses(); MessageBox.Show("Bus updated"); }
        }

        private void BusRemoveClick(object sender, EventArgs e)
        {
            bool res = BusesController.deleteBus(busId);
            if (res) { reloadBuses(); MessageBox.Show("Bus deleted"); }
        }
    }
}
