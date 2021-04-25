
namespace Project.Views
{
    partial class SalesManDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesManDashBoard));
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.journeyTime = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.journeyDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.ticketDest = new System.Windows.Forms.ComboBox();
            this.nonAcRadioBtn = new System.Windows.Forms.RadioButton();
            this.ticketSource = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ticketBookBtn = new System.Windows.Forms.Button();
            this.ticketCancelBtn = new System.Windows.Forms.Button();
            this.ticketUpdateBtn = new System.Windows.Forms.Button();
            this.customerName = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.acRadioBtn = new System.Windows.Forms.RadioButton();
            this.trashTicket = new System.Windows.Forms.Label();
            this.ticketsGridView = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.ticketSearchBtn = new System.Windows.Forms.Button();
            this.coachBox = new System.Windows.Forms.ComboBox();
            this.busType = new System.Windows.Forms.GroupBox();
            this.TicketsPanel = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.WelcomePanel = new System.Windows.Forms.Label();
            this.customersLabel = new System.Windows.Forms.Label();
            this.busesLabel = new System.Windows.Forms.Label();
            this.ticketsLabel = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.customerTrash = new System.Windows.Forms.Label();
            this.customerSearchBtn = new System.Windows.Forms.Button();
            this.customerSearchBox = new System.Windows.Forms.TextBox();
            this.customerPhoneBox = new System.Windows.Forms.TextBox();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.customerRemoveBtn = new System.Windows.Forms.Button();
            this.customerUpdateBtn = new System.Windows.Forms.Button();
            this.BusesPanel = new System.Windows.Forms.Panel();
            this.busCoachBox = new System.Windows.Forms.TextBox();
            this.busTrash = new System.Windows.Forms.Label();
            this.busSearchBtn = new System.Windows.Forms.Button();
            this.busSearchBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.busGridView = new System.Windows.Forms.DataGridView();
            this.busRadioGroup = new System.Windows.Forms.GroupBox();
            this.busNonAcRadio = new System.Windows.Forms.RadioButton();
            this.busAcRadio = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.busAddBtn = new System.Windows.Forms.Button();
            this.busRemoveBtn = new System.Windows.Forms.Button();
            this.busUpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsGridView)).BeginInit();
            this.busType.SuspendLayout();
            this.TicketsPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.CustomersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.BusesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busGridView)).BeginInit();
            this.busRadioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(333, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 24);
            this.label22.TabIndex = 23;
            this.label22.Text = "Coach";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(333, 57);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 24);
            this.label21.TabIndex = 22;
            this.label21.Text = "Bus Type";
            // 
            // journeyTime
            // 
            this.journeyTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journeyTime.FormattingEnabled = true;
            this.journeyTime.Items.AddRange(new object[] {
            "07:00 AM",
            "10:00 AM",
            "12:00 PM",
            "02:00 PM",
            "05:00 PM",
            "07:00 PM",
            "10:00 PM"});
            this.journeyTime.Location = new System.Drawing.Point(500, 140);
            this.journeyTime.Name = "journeyTime";
            this.journeyTime.Size = new System.Drawing.Size(206, 28);
            this.journeyTime.TabIndex = 21;
            this.journeyTime.Text = "Time";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(333, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 24);
            this.label17.TabIndex = 20;
            this.label17.Text = "Journey Time";
            // 
            // journeyDate
            // 
            this.journeyDate.CustomFormat = "";
            this.journeyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journeyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.journeyDate.Location = new System.Drawing.Point(500, 98);
            this.journeyDate.MinDate = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            this.journeyDate.Name = "journeyDate";
            this.journeyDate.Size = new System.Drawing.Size(205, 27);
            this.journeyDate.TabIndex = 19;
            this.journeyDate.Value = new System.DateTime(2021, 4, 15, 0, 0, 0, 0);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(333, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 24);
            this.label16.TabIndex = 18;
            this.label16.Text = "Journey Date";
            // 
            // ticketDest
            // 
            this.ticketDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketDest.FormattingEnabled = true;
            this.ticketDest.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Rajshahi",
            "Khulna",
            "Barishal",
            "Sylhet",
            "Rangpur"});
            this.ticketDest.Location = new System.Drawing.Point(93, 140);
            this.ticketDest.Name = "ticketDest";
            this.ticketDest.Size = new System.Drawing.Size(235, 28);
            this.ticketDest.TabIndex = 17;
            this.ticketDest.Text = "To";
            // 
            // nonAcRadioBtn
            // 
            this.nonAcRadioBtn.AutoSize = true;
            this.nonAcRadioBtn.Location = new System.Drawing.Point(97, 7);
            this.nonAcRadioBtn.Name = "nonAcRadioBtn";
            this.nonAcRadioBtn.Size = new System.Drawing.Size(86, 23);
            this.nonAcRadioBtn.TabIndex = 1;
            this.nonAcRadioBtn.TabStop = true;
            this.nonAcRadioBtn.Text = "Non AC";
            this.nonAcRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ticketSource
            // 
            this.ticketSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketSource.FormattingEnabled = true;
            this.ticketSource.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Rajshahi",
            "Khulna",
            "Barishal",
            "Sylhet",
            "Rangpur"});
            this.ticketSource.Location = new System.Drawing.Point(93, 98);
            this.ticketSource.Name = "ticketSource";
            this.ticketSource.Size = new System.Drawing.Size(235, 28);
            this.ticketSource.TabIndex = 16;
            this.ticketSource.Text = "From";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 145);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 24);
            this.label20.TabIndex = 15;
            this.label20.Text = "Dest.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 24);
            this.label19.TabIndex = 14;
            this.label19.Text = "Source";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 24);
            this.label15.TabIndex = 13;
            this.label15.Text = "Phone";
            // 
            // ticketBookBtn
            // 
            this.ticketBookBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ticketBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketBookBtn.Location = new System.Drawing.Point(735, 98);
            this.ticketBookBtn.Name = "ticketBookBtn";
            this.ticketBookBtn.Size = new System.Drawing.Size(133, 71);
            this.ticketBookBtn.TabIndex = 12;
            this.ticketBookBtn.Text = "Book Ticket";
            this.ticketBookBtn.UseVisualStyleBackColor = false;
            this.ticketBookBtn.Click += new System.EventHandler(this.BookTickets);
            // 
            // ticketCancelBtn
            // 
            this.ticketCancelBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.ticketCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketCancelBtn.Location = new System.Drawing.Point(735, 7);
            this.ticketCancelBtn.Name = "ticketCancelBtn";
            this.ticketCancelBtn.Size = new System.Drawing.Size(133, 32);
            this.ticketCancelBtn.TabIndex = 11;
            this.ticketCancelBtn.Text = "CancelTicket";
            this.ticketCancelBtn.UseVisualStyleBackColor = false;
            this.ticketCancelBtn.Click += new System.EventHandler(this.TicketCancelClick);
            // 
            // ticketUpdateBtn
            // 
            this.ticketUpdateBtn.BackColor = System.Drawing.Color.Gold;
            this.ticketUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketUpdateBtn.Location = new System.Drawing.Point(735, 51);
            this.ticketUpdateBtn.Name = "ticketUpdateBtn";
            this.ticketUpdateBtn.Size = new System.Drawing.Size(133, 32);
            this.ticketUpdateBtn.TabIndex = 10;
            this.ticketUpdateBtn.Text = "Update";
            this.ticketUpdateBtn.UseVisualStyleBackColor = false;
            this.ticketUpdateBtn.Click += new System.EventHandler(this.UpdateClick);
            // 
            // customerName
            // 
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(92, 53);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(236, 28);
            this.customerName.TabIndex = 3;
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.Location = new System.Drawing.Point(92, 6);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(144, 28);
            this.phoneBox.TabIndex = 0;
            // 
            // acRadioBtn
            // 
            this.acRadioBtn.AutoSize = true;
            this.acRadioBtn.Location = new System.Drawing.Point(14, 7);
            this.acRadioBtn.Name = "acRadioBtn";
            this.acRadioBtn.Size = new System.Drawing.Size(53, 23);
            this.acRadioBtn.TabIndex = 0;
            this.acRadioBtn.TabStop = true;
            this.acRadioBtn.Text = "AC";
            this.acRadioBtn.UseVisualStyleBackColor = true;
            // 
            // trashTicket
            // 
            this.trashTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trashTicket.Image = ((System.Drawing.Image)(resources.GetObject("trashTicket.Image")));
            this.trashTicket.Location = new System.Drawing.Point(827, 189);
            this.trashTicket.Name = "trashTicket";
            this.trashTicket.Size = new System.Drawing.Size(41, 32);
            this.trashTicket.TabIndex = 29;
            this.trashTicket.Visible = false;
            this.trashTicket.Click += new System.EventHandler(this.TrashClick);
            // 
            // ticketsGridView
            // 
            this.ticketsGridView.AllowUserToAddRows = false;
            this.ticketsGridView.AllowUserToDeleteRows = false;
            this.ticketsGridView.AllowUserToResizeColumns = false;
            this.ticketsGridView.AllowUserToResizeRows = false;
            this.ticketsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ticketsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsGridView.Location = new System.Drawing.Point(4, 224);
            this.ticketsGridView.MultiSelect = false;
            this.ticketsGridView.Name = "ticketsGridView";
            this.ticketsGridView.ReadOnly = true;
            this.ticketsGridView.RowHeadersVisible = false;
            this.ticketsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ticketsGridView.RowTemplate.Height = 24;
            this.ticketsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ticketsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ticketsGridView.ShowCellErrors = false;
            this.ticketsGridView.ShowEditingIcon = false;
            this.ticketsGridView.Size = new System.Drawing.Size(877, 230);
            this.ticketsGridView.TabIndex = 27;
            this.ticketsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.managerGridView_CellContentClick);
            this.ticketsGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketsGridView_CellContentDoubleClick);
            this.ticketsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketsGridView_CellContentDoubleClick);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Location = new System.Drawing.Point(4, 201);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(877, 23);
            this.label23.TabIndex = 28;
            this.label23.Text = "Tickets List";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ticketSearchBtn
            // 
            this.ticketSearchBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.ticketSearchBtn.Location = new System.Drawing.Point(242, 4);
            this.ticketSearchBtn.Name = "ticketSearchBtn";
            this.ticketSearchBtn.Size = new System.Drawing.Size(86, 30);
            this.ticketSearchBtn.TabIndex = 26;
            this.ticketSearchBtn.Text = "Search";
            this.ticketSearchBtn.UseVisualStyleBackColor = false;
            this.ticketSearchBtn.Click += new System.EventHandler(this.SearchClick);
            // 
            // coachBox
            // 
            this.coachBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coachBox.FormattingEnabled = true;
            this.coachBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.coachBox.Location = new System.Drawing.Point(500, 10);
            this.coachBox.Name = "coachBox";
            this.coachBox.Size = new System.Drawing.Size(206, 28);
            this.coachBox.TabIndex = 25;
            this.coachBox.Text = "Coach";
            // 
            // busType
            // 
            this.busType.Controls.Add(this.nonAcRadioBtn);
            this.busType.Controls.Add(this.acRadioBtn);
            this.busType.Location = new System.Drawing.Point(500, 45);
            this.busType.Name = "busType";
            this.busType.Size = new System.Drawing.Size(205, 35);
            this.busType.TabIndex = 24;
            this.busType.TabStop = false;
            // 
            // TicketsPanel
            // 
            this.TicketsPanel.Controls.Add(this.trashTicket);
            this.TicketsPanel.Controls.Add(this.ticketsGridView);
            this.TicketsPanel.Controls.Add(this.label23);
            this.TicketsPanel.Controls.Add(this.ticketSearchBtn);
            this.TicketsPanel.Controls.Add(this.coachBox);
            this.TicketsPanel.Controls.Add(this.busType);
            this.TicketsPanel.Controls.Add(this.label22);
            this.TicketsPanel.Controls.Add(this.label21);
            this.TicketsPanel.Controls.Add(this.journeyTime);
            this.TicketsPanel.Controls.Add(this.label17);
            this.TicketsPanel.Controls.Add(this.journeyDate);
            this.TicketsPanel.Controls.Add(this.label16);
            this.TicketsPanel.Controls.Add(this.ticketDest);
            this.TicketsPanel.Controls.Add(this.ticketSource);
            this.TicketsPanel.Controls.Add(this.label20);
            this.TicketsPanel.Controls.Add(this.label19);
            this.TicketsPanel.Controls.Add(this.label15);
            this.TicketsPanel.Controls.Add(this.ticketBookBtn);
            this.TicketsPanel.Controls.Add(this.ticketCancelBtn);
            this.TicketsPanel.Controls.Add(this.ticketUpdateBtn);
            this.TicketsPanel.Controls.Add(this.customerName);
            this.TicketsPanel.Controls.Add(this.label18);
            this.TicketsPanel.Controls.Add(this.phoneBox);
            this.TicketsPanel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketsPanel.Location = new System.Drawing.Point(138, 97);
            this.TicketsPanel.Name = "TicketsPanel";
            this.TicketsPanel.Size = new System.Drawing.Size(883, 460);
            this.TicketsPanel.TabIndex = 29;
            this.TicketsPanel.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 24);
            this.label18.TabIndex = 2;
            this.label18.Text = "Name";
            // 
            // HomeLabel
            // 
            this.HomeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeLabel.Image = ((System.Drawing.Image)(resources.GetObject("HomeLabel.Image")));
            this.HomeLabel.Location = new System.Drawing.Point(29, 8);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(54, 46);
            this.HomeLabel.TabIndex = 28;
            this.HomeLabel.Visible = false;
            this.HomeLabel.Click += new System.EventHandler(this.HomeLabelClick);
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.AutoSize = true;
            this.WelcomePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomePanel.Location = new System.Drawing.Point(171, 245);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(800, 55);
            this.WelcomePanel.TabIndex = 27;
            this.WelcomePanel.Text = "Welcome to Sales-Man Dashboard";
            // 
            // customersLabel
            // 
            this.customersLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.customersLabel.Image = ((System.Drawing.Image)(resources.GetObject("customersLabel.Image")));
            this.customersLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customersLabel.Location = new System.Drawing.Point(0, 400);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(112, 62);
            this.customersLabel.TabIndex = 4;
            this.customersLabel.Text = "Customers";
            this.customersLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customersLabel.Click += new System.EventHandler(this.CustomersClick);
            // 
            // busesLabel
            // 
            this.busesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.busesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busesLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.busesLabel.Image = ((System.Drawing.Image)(resources.GetObject("busesLabel.Image")));
            this.busesLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.busesLabel.Location = new System.Drawing.Point(1, 218);
            this.busesLabel.Name = "busesLabel";
            this.busesLabel.Size = new System.Drawing.Size(112, 62);
            this.busesLabel.TabIndex = 3;
            this.busesLabel.Text = "Buses";
            this.busesLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.busesLabel.Click += new System.EventHandler(this.BusClick);
            // 
            // ticketsLabel
            // 
            this.ticketsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ticketsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.ticketsLabel.Image = ((System.Drawing.Image)(resources.GetObject("ticketsLabel.Image")));
            this.ticketsLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ticketsLabel.Location = new System.Drawing.Point(0, 38);
            this.ticketsLabel.Name = "ticketsLabel";
            this.ticketsLabel.Size = new System.Drawing.Size(113, 62);
            this.ticketsLabel.TabIndex = 0;
            this.ticketsLabel.Text = "Tickets";
            this.ticketsLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ticketsLabel.Click += new System.EventHandler(this.TickectsClick);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.DimGray;
            this.menuPanel.Controls.Add(this.customersLabel);
            this.menuPanel.Controls.Add(this.busesLabel);
            this.menuPanel.Controls.Add(this.ticketsLabel);
            this.menuPanel.Location = new System.Drawing.Point(0, 59);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(112, 545);
            this.menuPanel.TabIndex = 26;
            // 
            // logoutLabel
            // 
            this.logoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.Image = ((System.Drawing.Image)(resources.GetObject("logoutLabel.Image")));
            this.logoutLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logoutLabel.Location = new System.Drawing.Point(941, 8);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(80, 53);
            this.logoutLabel.TabIndex = 25;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoutLabel.Click += new System.EventHandler(this.LogoutClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1010, 72);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sales-Man Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.Controls.Add(this.customerTrash);
            this.CustomersPanel.Controls.Add(this.customerSearchBtn);
            this.CustomersPanel.Controls.Add(this.customerSearchBox);
            this.CustomersPanel.Controls.Add(this.customerPhoneBox);
            this.CustomersPanel.Controls.Add(this.customerNameBox);
            this.CustomersPanel.Controls.Add(this.label25);
            this.CustomersPanel.Controls.Add(this.customerGridView);
            this.CustomersPanel.Controls.Add(this.label26);
            this.CustomersPanel.Controls.Add(this.label27);
            this.CustomersPanel.Controls.Add(this.customerRemoveBtn);
            this.CustomersPanel.Controls.Add(this.customerUpdateBtn);
            this.CustomersPanel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersPanel.Location = new System.Drawing.Point(138, 91);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Size = new System.Drawing.Size(883, 460);
            this.CustomersPanel.TabIndex = 30;
            this.CustomersPanel.Visible = false;
            // 
            // customerTrash
            // 
            this.customerTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerTrash.Image = ((System.Drawing.Image)(resources.GetObject("customerTrash.Image")));
            this.customerTrash.Location = new System.Drawing.Point(229, 99);
            this.customerTrash.Name = "customerTrash";
            this.customerTrash.Size = new System.Drawing.Size(41, 32);
            this.customerTrash.TabIndex = 33;
            this.customerTrash.Visible = false;
            // 
            // customerSearchBtn
            // 
            this.customerSearchBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.customerSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSearchBtn.Location = new System.Drawing.Point(276, 99);
            this.customerSearchBtn.Name = "customerSearchBtn";
            this.customerSearchBtn.Size = new System.Drawing.Size(147, 32);
            this.customerSearchBtn.TabIndex = 32;
            this.customerSearchBtn.Text = "Search";
            this.customerSearchBtn.UseVisualStyleBackColor = false;
            // 
            // customerSearchBox
            // 
            this.customerSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSearchBox.Location = new System.Drawing.Point(62, 53);
            this.customerSearchBox.Name = "customerSearchBox";
            this.customerSearchBox.Size = new System.Drawing.Size(361, 28);
            this.customerSearchBox.TabIndex = 31;
            // 
            // customerPhoneBox
            // 
            this.customerPhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhoneBox.Location = new System.Drawing.Point(126, 267);
            this.customerPhoneBox.Name = "customerPhoneBox";
            this.customerPhoneBox.Size = new System.Drawing.Size(297, 28);
            this.customerPhoneBox.TabIndex = 30;
            // 
            // customerNameBox
            // 
            this.customerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameBox.Location = new System.Drawing.Point(126, 220);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(297, 28);
            this.customerNameBox.TabIndex = 29;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(460, 23);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(397, 23);
            this.label25.TabIndex = 28;
            this.label25.Text = "Customers List";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerGridView
            // 
            this.customerGridView.AllowDrop = true;
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AllowUserToDeleteRows = false;
            this.customerGridView.AllowUserToResizeColumns = false;
            this.customerGridView.AllowUserToResizeRows = false;
            this.customerGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(460, 53);
            this.customerGridView.MultiSelect = false;
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.ReadOnly = true;
            this.customerGridView.RowHeadersWidth = 95;
            this.customerGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customerGridView.RowTemplate.Height = 24;
            this.customerGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customerGridView.ShowEditingIcon = false;
            this.customerGridView.Size = new System.Drawing.Size(397, 404);
            this.customerGridView.TabIndex = 27;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(34, 220);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 24);
            this.label26.TabIndex = 23;
            this.label26.Text = "Name";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(34, 273);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 24);
            this.label27.TabIndex = 22;
            this.label27.Text = "Phone";
            // 
            // customerRemoveBtn
            // 
            this.customerRemoveBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.customerRemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerRemoveBtn.Location = new System.Drawing.Point(126, 317);
            this.customerRemoveBtn.Name = "customerRemoveBtn";
            this.customerRemoveBtn.Size = new System.Drawing.Size(147, 32);
            this.customerRemoveBtn.TabIndex = 11;
            this.customerRemoveBtn.Text = "Remove";
            this.customerRemoveBtn.UseVisualStyleBackColor = false;
            // 
            // customerUpdateBtn
            // 
            this.customerUpdateBtn.BackColor = System.Drawing.Color.Gold;
            this.customerUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerUpdateBtn.Location = new System.Drawing.Point(276, 317);
            this.customerUpdateBtn.Name = "customerUpdateBtn";
            this.customerUpdateBtn.Size = new System.Drawing.Size(147, 32);
            this.customerUpdateBtn.TabIndex = 10;
            this.customerUpdateBtn.Text = "Update";
            this.customerUpdateBtn.UseVisualStyleBackColor = false;
            // 
            // BusesPanel
            // 
            this.BusesPanel.Controls.Add(this.label6);
            this.BusesPanel.Controls.Add(this.busCoachBox);
            this.BusesPanel.Controls.Add(this.busTrash);
            this.BusesPanel.Controls.Add(this.busSearchBtn);
            this.BusesPanel.Controls.Add(this.busSearchBox);
            this.BusesPanel.Controls.Add(this.busGridView);
            this.BusesPanel.Controls.Add(this.busRadioGroup);
            this.BusesPanel.Controls.Add(this.label7);
            this.BusesPanel.Controls.Add(this.label24);
            this.BusesPanel.Controls.Add(this.busAddBtn);
            this.BusesPanel.Controls.Add(this.busRemoveBtn);
            this.BusesPanel.Controls.Add(this.busUpdateBtn);
            this.BusesPanel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusesPanel.Location = new System.Drawing.Point(138, 84);
            this.BusesPanel.Name = "BusesPanel";
            this.BusesPanel.Size = new System.Drawing.Size(900, 520);
            this.BusesPanel.TabIndex = 31;
            this.BusesPanel.Visible = false;
            // 
            // busCoachBox
            // 
            this.busCoachBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busCoachBox.Location = new System.Drawing.Point(571, 215);
            this.busCoachBox.Name = "busCoachBox";
            this.busCoachBox.Size = new System.Drawing.Size(297, 28);
            this.busCoachBox.TabIndex = 37;
            // 
            // busTrash
            // 
            this.busTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.busTrash.Image = ((System.Drawing.Image)(resources.GetObject("busTrash.Image")));
            this.busTrash.Location = new System.Drawing.Point(665, 99);
            this.busTrash.Name = "busTrash";
            this.busTrash.Size = new System.Drawing.Size(41, 32);
            this.busTrash.TabIndex = 36;
            this.busTrash.Visible = false;
            this.busTrash.Click += new System.EventHandler(this.BusTrashClick);
            // 
            // busSearchBtn
            // 
            this.busSearchBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.busSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busSearchBtn.Location = new System.Drawing.Point(712, 99);
            this.busSearchBtn.Name = "busSearchBtn";
            this.busSearchBtn.Size = new System.Drawing.Size(147, 32);
            this.busSearchBtn.TabIndex = 35;
            this.busSearchBtn.Text = "Search";
            this.busSearchBtn.UseVisualStyleBackColor = false;
            this.busSearchBtn.Click += new System.EventHandler(this.BusSearchClick);
            // 
            // busSearchBox
            // 
            this.busSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busSearchBox.Location = new System.Drawing.Point(498, 53);
            this.busSearchBox.Name = "busSearchBox";
            this.busSearchBox.Size = new System.Drawing.Size(361, 28);
            this.busSearchBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Bus List";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // busGridView
            // 
            this.busGridView.AllowUserToAddRows = false;
            this.busGridView.AllowUserToDeleteRows = false;
            this.busGridView.AllowUserToOrderColumns = true;
            this.busGridView.AllowUserToResizeColumns = false;
            this.busGridView.AllowUserToResizeRows = false;
            this.busGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busGridView.Location = new System.Drawing.Point(15, 53);
            this.busGridView.Name = "busGridView";
            this.busGridView.RowHeadersWidth = 95;
            this.busGridView.RowTemplate.Height = 24;
            this.busGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.busGridView.Size = new System.Drawing.Size(397, 404);
            this.busGridView.TabIndex = 27;
            // 
            // busRadioGroup
            // 
            this.busRadioGroup.Controls.Add(this.busNonAcRadio);
            this.busRadioGroup.Controls.Add(this.busAcRadio);
            this.busRadioGroup.Location = new System.Drawing.Point(571, 258);
            this.busRadioGroup.Name = "busRadioGroup";
            this.busRadioGroup.Size = new System.Drawing.Size(297, 35);
            this.busRadioGroup.TabIndex = 24;
            this.busRadioGroup.TabStop = false;
            // 
            // busNonAcRadio
            // 
            this.busNonAcRadio.AutoSize = true;
            this.busNonAcRadio.Location = new System.Drawing.Point(150, 7);
            this.busNonAcRadio.Name = "busNonAcRadio";
            this.busNonAcRadio.Size = new System.Drawing.Size(86, 23);
            this.busNonAcRadio.TabIndex = 1;
            this.busNonAcRadio.TabStop = true;
            this.busNonAcRadio.Text = "Non AC";
            this.busNonAcRadio.UseVisualStyleBackColor = true;
            this.busNonAcRadio.Click += new System.EventHandler(this.BusNonAcRadioClick);
            // 
            // busAcRadio
            // 
            this.busAcRadio.AutoSize = true;
            this.busAcRadio.Location = new System.Drawing.Point(22, 7);
            this.busAcRadio.Name = "busAcRadio";
            this.busAcRadio.Size = new System.Drawing.Size(53, 23);
            this.busAcRadio.TabIndex = 0;
            this.busAcRadio.TabStop = true;
            this.busAcRadio.Text = "AC";
            this.busAcRadio.UseVisualStyleBackColor = true;
            this.busAcRadio.Click += new System.EventHandler(this.BusACRadioCLick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Coach";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(437, 270);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 24);
            this.label24.TabIndex = 22;
            this.label24.Text = "Bus Type";
            // 
            // busAddBtn
            // 
            this.busAddBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.busAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busAddBtn.Location = new System.Drawing.Point(571, 314);
            this.busAddBtn.Name = "busAddBtn";
            this.busAddBtn.Size = new System.Drawing.Size(297, 32);
            this.busAddBtn.TabIndex = 12;
            this.busAddBtn.Text = "Add Bus";
            this.busAddBtn.UseVisualStyleBackColor = false;
            this.busAddBtn.Click += new System.EventHandler(this.BusAddClick);
            // 
            // busRemoveBtn
            // 
            this.busRemoveBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.busRemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busRemoveBtn.Location = new System.Drawing.Point(571, 361);
            this.busRemoveBtn.Name = "busRemoveBtn";
            this.busRemoveBtn.Size = new System.Drawing.Size(147, 32);
            this.busRemoveBtn.TabIndex = 11;
            this.busRemoveBtn.Text = "Remove";
            this.busRemoveBtn.UseVisualStyleBackColor = false;
            this.busRemoveBtn.Click += new System.EventHandler(this.BusRemoveClick);
            // 
            // busUpdateBtn
            // 
            this.busUpdateBtn.BackColor = System.Drawing.Color.Gold;
            this.busUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busUpdateBtn.Location = new System.Drawing.Point(721, 361);
            this.busUpdateBtn.Name = "busUpdateBtn";
            this.busUpdateBtn.Size = new System.Drawing.Size(147, 32);
            this.busUpdateBtn.TabIndex = 10;
            this.busUpdateBtn.Text = "Update";
            this.busUpdateBtn.UseVisualStyleBackColor = false;
            this.busUpdateBtn.Click += new System.EventHandler(this.BusUpdateClick);
            // 
            // SalesManDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 628);
            this.Controls.Add(this.BusesPanel);
            this.Controls.Add(this.CustomersPanel);
            this.Controls.Add(this.TicketsPanel);
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.WelcomePanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.label1);
            this.Name = "SalesManDashBoard";
            this.Text = "SalesManDashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.ticketsGridView)).EndInit();
            this.busType.ResumeLayout(false);
            this.busType.PerformLayout();
            this.TicketsPanel.ResumeLayout(false);
            this.TicketsPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.CustomersPanel.ResumeLayout(false);
            this.CustomersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.BusesPanel.ResumeLayout(false);
            this.BusesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busGridView)).EndInit();
            this.busRadioGroup.ResumeLayout(false);
            this.busRadioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox journeyTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker journeyDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox ticketDest;
        private System.Windows.Forms.RadioButton nonAcRadioBtn;
        private System.Windows.Forms.ComboBox ticketSource;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ticketBookBtn;
        private System.Windows.Forms.Button ticketCancelBtn;
        private System.Windows.Forms.Button ticketUpdateBtn;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.RadioButton acRadioBtn;
        private System.Windows.Forms.Label trashTicket;
        private System.Windows.Forms.DataGridView ticketsGridView;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button ticketSearchBtn;
        private System.Windows.Forms.ComboBox coachBox;
        private System.Windows.Forms.GroupBox busesTypes;
        private System.Windows.Forms.Panel TicketsPanel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Label WelcomePanel;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.Label busesLabel;
        private System.Windows.Forms.Label ticketsLabel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CustomersPanel;
        private System.Windows.Forms.Label customerTrash;
        private System.Windows.Forms.Button customerSearchBtn;
        private System.Windows.Forms.TextBox customerSearchBox;
        private System.Windows.Forms.TextBox customerPhoneBox;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button customerRemoveBtn;
        private System.Windows.Forms.Button customerUpdateBtn;
        private System.Windows.Forms.Panel BusesPanel;
        private System.Windows.Forms.TextBox busCoachBox;
        private System.Windows.Forms.Label busTrash;
        private System.Windows.Forms.Button busSearchBtn;
        private System.Windows.Forms.TextBox busSearchBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView busGridView;
        private System.Windows.Forms.GroupBox busRadioGroup;
        private System.Windows.Forms.RadioButton busNonAcRadio;
        private System.Windows.Forms.RadioButton busAcRadio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button busAddBtn;
        private System.Windows.Forms.Button busRemoveBtn;
        private System.Windows.Forms.Button busUpdateBtn;
    }
}