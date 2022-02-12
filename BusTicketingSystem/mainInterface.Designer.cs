using LoginForm;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace badmintonProject
{
    partial class mainInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Adding panels
        List<Panel> myListPanel = new List<Panel>();
        List<string> itemsToShow = new List<string>();
        int indexPanel;
        private Graphics g;
        MainUI objectUI = new MainUI();
        bool checkSeat = false;
        string selectedListDelete = "None";
        int rowItemOnExcel;
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainInterface));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLight3 = new System.Windows.Forms.Panel();
            this.panelLight2 = new System.Windows.Forms.Panel();
            this.panelLight1 = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonReserv = new System.Windows.Forms.Button();
            this.groupBoxHelp = new System.Windows.Forms.GroupBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label49 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBoxRefund = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.listviewRefresh = new System.Windows.Forms.ListView();
            this.colNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCityDep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCityAr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSeat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxReserv = new System.Windows.Forms.GroupBox();
            this.panelSeat = new System.Windows.Forms.Panel();
            this.labelSeatSelectedShow = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.labelClassSelected = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.panelDrawSeat = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonCheckSeat = new System.Windows.Forms.Button();
            this.labelBusSelected = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.buttonSubmitBook = new System.Windows.Forms.Button();
            this.panelDate = new System.Windows.Forms.Panel();
            this.radioRoundNo = new System.Windows.Forms.RadioButton();
            this.radioRoundYes = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panelListBus = new System.Windows.Forms.Panel();
            this.labelDateBusList = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.buttonCheckBus = new System.Windows.Forms.Button();
            this.labelArrival = new System.Windows.Forms.Label();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.listViewBus = new System.Windows.Forms.ListView();
            this.numColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameBus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.picPrev = new System.Windows.Forms.PictureBox();
            this.picBoxNext = new System.Windows.Forms.PictureBox();
            this.panelIDForm = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textResidentID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxRefund.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxReserv.SuspendLayout();
            this.panelSeat.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.panelListBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNext)).BeginInit();
            this.panelIDForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panelLight3);
            this.panel1.Controls.Add(this.panelLight2);
            this.panel1.Controls.Add(this.panelLight1);
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonReserv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 622);
            this.panel1.TabIndex = 0;
            // 
            // panelLight3
            // 
            this.panelLight3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelLight3.Location = new System.Drawing.Point(0, 397);
            this.panelLight3.Name = "panelLight3";
            this.panelLight3.Size = new System.Drawing.Size(10, 61);
            this.panelLight3.TabIndex = 7;
            // 
            // panelLight2
            // 
            this.panelLight2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelLight2.Location = new System.Drawing.Point(0, 296);
            this.panelLight2.Name = "panelLight2";
            this.panelLight2.Size = new System.Drawing.Size(10, 61);
            this.panelLight2.TabIndex = 6;
            // 
            // panelLight1
            // 
            this.panelLight1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelLight1.Location = new System.Drawing.Point(0, 198);
            this.panelLight1.Name = "panelLight1";
            this.panelLight1.Size = new System.Drawing.Size(10, 61);
            this.panelLight1.TabIndex = 5;
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.Black;
            this.buttonHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp.Image")));
            this.buttonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.Location = new System.Drawing.Point(16, 399);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(212, 56);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Help Details";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(16, 298);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(212, 56);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "    Cancellation";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonReserv
            // 
            this.buttonReserv.FlatAppearance.BorderSize = 0;
            this.buttonReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReserv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReserv.ForeColor = System.Drawing.Color.Black;
            this.buttonReserv.Image = ((System.Drawing.Image)(resources.GetObject("buttonReserv.Image")));
            this.buttonReserv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReserv.Location = new System.Drawing.Point(16, 200);
            this.buttonReserv.Name = "buttonReserv";
            this.buttonReserv.Size = new System.Drawing.Size(212, 56);
            this.buttonReserv.TabIndex = 0;
            this.buttonReserv.Text = "Reservation";
            this.buttonReserv.UseVisualStyleBackColor = true;
            this.buttonReserv.Click += new System.EventHandler(this.buttonReserv_Click);
            // 
            // groupBoxHelp
            // 
            this.groupBoxHelp.Controls.Add(this.label53);
            this.groupBoxHelp.Controls.Add(this.label52);
            this.groupBoxHelp.Controls.Add(this.label51);
            this.groupBoxHelp.Controls.Add(this.label50);
            this.groupBoxHelp.Controls.Add(this.linkLabel1);
            this.groupBoxHelp.Controls.Add(this.label49);
            this.groupBoxHelp.Controls.Add(this.label45);
            this.groupBoxHelp.Controls.Add(this.label18);
            this.groupBoxHelp.Controls.Add(this.label16);
            this.groupBoxHelp.Controls.Add(this.pictureBox2);
            this.groupBoxHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxHelp.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHelp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxHelp.Location = new System.Drawing.Point(255, 144);
            this.groupBoxHelp.Name = "groupBoxHelp";
            this.groupBoxHelp.Size = new System.Drawing.Size(754, 449);
            this.groupBoxHelp.TabIndex = 23;
            this.groupBoxHelp.TabStop = false;
            this.groupBoxHelp.Text = "Help Support";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(654, 419);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(77, 21);
            this.label53.TabIndex = 33;
            this.label53.Text = "aditiopp";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(73, 345);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(122, 32);
            this.label52.TabIndex = 32;
            this.label52.Text = "Source:\r\npinterest (Dr.Noodles)";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(303, 317);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(97, 21);
            this.label51.TabIndex = 31;
            this.label51.Text = "Thank you!!";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(303, 290);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(229, 21);
            this.label50.TabIndex = 30;
            this.label50.Text = "So, we can discuss it further..";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(322, 237);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 23);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "my instagram";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(303, 211);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(213, 21);
            this.label49.TabIndex = 28;
            this.label49.Text = "Please kindly reach me on:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(303, 154);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(428, 21);
            this.label45.TabIndex = 27;
            this.label45.Text = "I know it is embarassing, let me know what happened";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(303, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(277, 21);
            this.label18.TabIndex = 26;
            this.label18.Text = "Looks like you got a problem there.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(277, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 32);
            this.label16.TabIndex = 25;
            this.label16.Text = "Uh\'oh!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(76, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 216);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // groupBoxRefund
            // 
            this.groupBoxRefund.Controls.Add(this.buttonDelete);
            this.groupBoxRefund.Controls.Add(this.buttonRefresh);
            this.groupBoxRefund.Controls.Add(this.label47);
            this.groupBoxRefund.Controls.Add(this.listviewRefresh);
            this.groupBoxRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxRefund.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRefund.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxRefund.Location = new System.Drawing.Point(255, 144);
            this.groupBoxRefund.Name = "groupBoxRefund";
            this.groupBoxRefund.Size = new System.Drawing.Size(754, 451);
            this.groupBoxRefund.TabIndex = 20;
            this.groupBoxRefund.TabStop = false;
            this.groupBoxRefund.Text = "Cancellation Details";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(538, 214);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(86, 26);
            this.buttonDelete.TabIndex = 36;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(635, 214);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(86, 26);
            this.buttonRefresh.TabIndex = 34;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(20, 41);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(154, 20);
            this.label47.TabIndex = 33;
            this.label47.Text = "Data Management:";
            // 
            // listviewRefresh
            // 
            this.listviewRefresh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.colFirst,
            this.colLast,
            this.colID,
            this.colPhone,
            this.colDate,
            this.colTime,
            this.colCityDep,
            this.colCityAr,
            this.colName,
            this.colClass,
            this.colSeat,
            this.colPrice});
            this.listviewRefresh.Enabled = false;
            this.listviewRefresh.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewRefresh.FullRowSelect = true;
            this.listviewRefresh.Location = new System.Drawing.Point(29, 73);
            this.listviewRefresh.Name = "listviewRefresh";
            this.listviewRefresh.Size = new System.Drawing.Size(700, 135);
            this.listviewRefresh.TabIndex = 30;
            this.listviewRefresh.UseCompatibleStateImageBehavior = false;
            this.listviewRefresh.View = System.Windows.Forms.View.Details;
            this.listviewRefresh.SelectedIndexChanged += new System.EventHandler(this.listviewRefresh_SelectedIndexChanged);
            // 
            // colNo
            // 
            this.colNo.Text = "No";
            this.colNo.Width = 46;
            // 
            // colFirst
            // 
            this.colFirst.Text = "First Name";
            this.colFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colFirst.Width = 96;
            // 
            // colLast
            // 
            this.colLast.Text = "Last Name";
            this.colLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLast.Width = 76;
            // 
            // colID
            // 
            this.colID.Text = "Resident ID";
            this.colID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colID.Width = 84;
            // 
            // colPhone
            // 
            this.colPhone.Text = "Phone Number";
            // 
            // colDate
            // 
            this.colDate.Text = "Date Departure";
            this.colDate.Width = 66;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            // 
            // colCityDep
            // 
            this.colCityDep.Text = "Departure";
            // 
            // colCityAr
            // 
            this.colCityAr.Text = "Arrival";
            // 
            // colName
            // 
            this.colName.Text = "Bus";
            this.colName.Width = 44;
            // 
            // colClass
            // 
            this.colClass.Text = "Class";
            // 
            // colSeat
            // 
            this.colSeat.Text = "Seat";
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(231, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 26);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(295, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 128);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "MyBus";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxReserv
            // 
            this.groupBoxReserv.Controls.Add(this.panelSeat);
            this.groupBoxReserv.Controls.Add(this.panelDate);
            this.groupBoxReserv.Controls.Add(this.label15);
            this.groupBoxReserv.Controls.Add(this.panelListBus);
            this.groupBoxReserv.Controls.Add(this.pictureBox7);
            this.groupBoxReserv.Controls.Add(this.label14);
            this.groupBoxReserv.Controls.Add(this.pictureBox6);
            this.groupBoxReserv.Controls.Add(this.label13);
            this.groupBoxReserv.Controls.Add(this.pictureBox5);
            this.groupBoxReserv.Controls.Add(this.label12);
            this.groupBoxReserv.Controls.Add(this.pictureBox4);
            this.groupBoxReserv.Controls.Add(this.label11);
            this.groupBoxReserv.Controls.Add(this.label10);
            this.groupBoxReserv.Controls.Add(this.picPrev);
            this.groupBoxReserv.Controls.Add(this.picBoxNext);
            this.groupBoxReserv.Controls.Add(this.panelIDForm);
            this.groupBoxReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxReserv.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReserv.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxReserv.Location = new System.Drawing.Point(255, 144);
            this.groupBoxReserv.Name = "groupBoxReserv";
            this.groupBoxReserv.Size = new System.Drawing.Size(754, 451);
            this.groupBoxReserv.TabIndex = 3;
            this.groupBoxReserv.TabStop = false;
            this.groupBoxReserv.Text = "Booking Details";
            // 
            // panelSeat
            // 
            this.panelSeat.Controls.Add(this.labelSeatSelectedShow);
            this.panelSeat.Controls.Add(this.label48);
            this.panelSeat.Controls.Add(this.labelClassSelected);
            this.panelSeat.Controls.Add(this.label46);
            this.panelSeat.Controls.Add(this.panelDrawSeat);
            this.panelSeat.Controls.Add(this.panel6);
            this.panelSeat.Controls.Add(this.panel5);
            this.panelSeat.Controls.Add(this.label44);
            this.panelSeat.Controls.Add(this.label43);
            this.panelSeat.Controls.Add(this.label42);
            this.panelSeat.Controls.Add(this.label41);
            this.panelSeat.Controls.Add(this.label40);
            this.panelSeat.Controls.Add(this.label39);
            this.panelSeat.Controls.Add(this.label38);
            this.panelSeat.Controls.Add(this.label37);
            this.panelSeat.Controls.Add(this.label36);
            this.panelSeat.Controls.Add(this.label35);
            this.panelSeat.Controls.Add(this.label34);
            this.panelSeat.Controls.Add(this.label33);
            this.panelSeat.Controls.Add(this.label32);
            this.panelSeat.Controls.Add(this.label31);
            this.panelSeat.Controls.Add(this.label30);
            this.panelSeat.Controls.Add(this.label29);
            this.panelSeat.Controls.Add(this.label26);
            this.panelSeat.Controls.Add(this.label25);
            this.panelSeat.Controls.Add(this.label19);
            this.panelSeat.Controls.Add(this.buttonCheckSeat);
            this.panelSeat.Controls.Add(this.labelBusSelected);
            this.panelSeat.Controls.Add(this.label27);
            this.panelSeat.Controls.Add(this.label28);
            this.panelSeat.Controls.Add(this.buttonSubmitBook);
            this.panelSeat.Location = new System.Drawing.Point(43, 106);
            this.panelSeat.Name = "panelSeat";
            this.panelSeat.Size = new System.Drawing.Size(686, 277);
            this.panelSeat.TabIndex = 17;
            // 
            // labelSeatSelectedShow
            // 
            this.labelSeatSelectedShow.AutoSize = true;
            this.labelSeatSelectedShow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeatSelectedShow.Location = new System.Drawing.Point(377, 41);
            this.labelSeatSelectedShow.Name = "labelSeatSelectedShow";
            this.labelSeatSelectedShow.Size = new System.Drawing.Size(52, 21);
            this.labelSeatSelectedShow.TabIndex = 96;
            this.labelSeatSelectedShow.Text = "None";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(327, 42);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(46, 19);
            this.label48.TabIndex = 95;
            this.label48.Text = "Seat:";
            // 
            // labelClassSelected
            // 
            this.labelClassSelected.AutoSize = true;
            this.labelClassSelected.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassSelected.Location = new System.Drawing.Point(222, 41);
            this.labelClassSelected.Name = "labelClassSelected";
            this.labelClassSelected.Size = new System.Drawing.Size(52, 21);
            this.labelClassSelected.TabIndex = 94;
            this.labelClassSelected.Text = "None";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(172, 42);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(52, 19);
            this.label46.TabIndex = 93;
            this.label46.Text = "Class:";
            // 
            // panelDrawSeat
            // 
            this.panelDrawSeat.Location = new System.Drawing.Point(126, 78);
            this.panelDrawSeat.Name = "panelDrawSeat";
            this.panelDrawSeat.Size = new System.Drawing.Size(463, 118);
            this.panelDrawSeat.TabIndex = 72;
            this.panelDrawSeat.Click += new System.EventHandler(this.panelDrawSeat_Click);
            this.panelDrawSeat.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrawSeat_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Location = new System.Drawing.Point(598, 198);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(61, 10);
            this.panel6.TabIndex = 92;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Location = new System.Drawing.Point(20, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(61, 10);
            this.panel5.TabIndex = 91;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(12, 209);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(76, 17);
            this.label44.TabIndex = 90;
            this.label44.Text = "Front Door";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(591, 210);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(75, 17);
            this.label43.TabIndex = 89;
            this.label43.Text = "Back Door";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(101, 179);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(18, 17);
            this.label42.TabIndex = 88;
            this.label42.Text = "D";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(101, 147);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(19, 17);
            this.label41.TabIndex = 87;
            this.label41.Text = "C";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(101, 109);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(15, 17);
            this.label40.TabIndex = 86;
            this.label40.Text = "B";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(101, 82);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(17, 17);
            this.label39.TabIndex = 85;
            this.label39.Text = "A";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(550, 199);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(22, 17);
            this.label38.TabIndex = 84;
            this.label38.Text = "13";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(516, 199);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(22, 17);
            this.label37.TabIndex = 83;
            this.label37.Text = "12";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(480, 199);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(22, 17);
            this.label36.TabIndex = 82;
            this.label36.Text = "11";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(446, 199);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(22, 17);
            this.label35.TabIndex = 81;
            this.label35.Text = "10";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(415, 199);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(15, 17);
            this.label34.TabIndex = 80;
            this.label34.Text = "9";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(380, 199);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(15, 17);
            this.label33.TabIndex = 79;
            this.label33.Text = "8";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(343, 199);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(15, 17);
            this.label32.TabIndex = 78;
            this.label32.Text = "7";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(308, 199);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(15, 17);
            this.label31.TabIndex = 77;
            this.label31.Text = "6";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(273, 199);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(15, 17);
            this.label30.TabIndex = 76;
            this.label30.Text = "5";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(237, 199);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(15, 17);
            this.label29.TabIndex = 75;
            this.label29.Text = "4";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(203, 199);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(15, 17);
            this.label26.TabIndex = 74;
            this.label26.Text = "3";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(167, 199);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(15, 17);
            this.label25.TabIndex = 73;
            this.label25.Text = "2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(132, 199);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 17);
            this.label19.TabIndex = 72;
            this.label19.Text = "1";
            // 
            // buttonCheckSeat
            // 
            this.buttonCheckSeat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckSeat.Location = new System.Drawing.Point(548, 32);
            this.buttonCheckSeat.Name = "buttonCheckSeat";
            this.buttonCheckSeat.Size = new System.Drawing.Size(95, 31);
            this.buttonCheckSeat.TabIndex = 71;
            this.buttonCheckSeat.Text = "Check Seat";
            this.buttonCheckSeat.UseVisualStyleBackColor = true;
            this.buttonCheckSeat.Click += new System.EventHandler(this.buttonCheckSeat_Click);
            // 
            // labelBusSelected
            // 
            this.labelBusSelected.AutoSize = true;
            this.labelBusSelected.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusSelected.Location = new System.Drawing.Point(41, 42);
            this.labelBusSelected.Name = "labelBusSelected";
            this.labelBusSelected.Size = new System.Drawing.Size(52, 21);
            this.labelBusSelected.TabIndex = 4;
            this.labelBusSelected.Text = "None";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(6, 43);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(38, 19);
            this.label27.TabIndex = 1;
            this.label27.Text = "Bus:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 3);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(118, 23);
            this.label28.TabIndex = 0;
            this.label28.Text = "Select Seat:";
            // 
            // buttonSubmitBook
            // 
            this.buttonSubmitBook.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSubmitBook.FlatAppearance.BorderSize = 0;
            this.buttonSubmitBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmitBook.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitBook.ForeColor = System.Drawing.Color.White;
            this.buttonSubmitBook.Location = new System.Drawing.Point(29, 233);
            this.buttonSubmitBook.Name = "buttonSubmitBook";
            this.buttonSubmitBook.Size = new System.Drawing.Size(104, 30);
            this.buttonSubmitBook.TabIndex = 12;
            this.buttonSubmitBook.Text = "Submit";
            this.buttonSubmitBook.UseVisualStyleBackColor = false;
            this.buttonSubmitBook.Click += new System.EventHandler(this.buttonSubmitBook_Click);
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.radioRoundNo);
            this.panelDate.Controls.Add(this.radioRoundYes);
            this.panelDate.Controls.Add(this.label20);
            this.panelDate.Controls.Add(this.dateReturn);
            this.panelDate.Controls.Add(this.labelReturnDate);
            this.panelDate.Controls.Add(this.dateTimePicker1);
            this.panelDate.Controls.Add(this.label17);
            this.panelDate.Location = new System.Drawing.Point(43, 106);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(686, 277);
            this.panelDate.TabIndex = 15;
            // 
            // radioRoundNo
            // 
            this.radioRoundNo.AutoSize = true;
            this.radioRoundNo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRoundNo.Location = new System.Drawing.Point(457, 97);
            this.radioRoundNo.Name = "radioRoundNo";
            this.radioRoundNo.Size = new System.Drawing.Size(48, 24);
            this.radioRoundNo.TabIndex = 7;
            this.radioRoundNo.TabStop = true;
            this.radioRoundNo.Text = "No";
            this.radioRoundNo.UseVisualStyleBackColor = true;
            this.radioRoundNo.CheckedChanged += new System.EventHandler(this.radioRoundNo_CheckedChanged);
            // 
            // radioRoundYes
            // 
            this.radioRoundYes.AutoSize = true;
            this.radioRoundYes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRoundYes.Location = new System.Drawing.Point(457, 67);
            this.radioRoundYes.Name = "radioRoundYes";
            this.radioRoundYes.Size = new System.Drawing.Size(50, 24);
            this.radioRoundYes.TabIndex = 6;
            this.radioRoundYes.TabStop = true;
            this.radioRoundYes.Text = "Yes";
            this.radioRoundYes.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(417, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 23);
            this.label20.TabIndex = 5;
            this.label20.Text = "A round-trip:";
            // 
            // dateReturn
            // 
            this.dateReturn.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReturn.Location = new System.Drawing.Point(29, 174);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(333, 31);
            this.dateReturn.TabIndex = 4;
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Location = new System.Drawing.Point(25, 141);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(121, 23);
            this.labelReturnDate.TabIndex = 3;
            this.labelReturnDate.Text = "Return Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 31);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 23);
            this.label17.TabIndex = 1;
            this.label17.Text = "Departure Date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(602, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Choose Seat";
            // 
            // panelListBus
            // 
            this.panelListBus.Controls.Add(this.labelDateBusList);
            this.panelListBus.Controls.Add(this.label24);
            this.panelListBus.Controls.Add(this.buttonCheckBus);
            this.panelListBus.Controls.Add(this.labelArrival);
            this.panelListBus.Controls.Add(this.labelDeparture);
            this.panelListBus.Controls.Add(this.listViewBus);
            this.panelListBus.Controls.Add(this.label23);
            this.panelListBus.Controls.Add(this.label22);
            this.panelListBus.Controls.Add(this.label21);
            this.panelListBus.Location = new System.Drawing.Point(43, 106);
            this.panelListBus.Name = "panelListBus";
            this.panelListBus.Size = new System.Drawing.Size(686, 277);
            this.panelListBus.TabIndex = 16;
            // 
            // labelDateBusList
            // 
            this.labelDateBusList.AutoSize = true;
            this.labelDateBusList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateBusList.Location = new System.Drawing.Point(138, 39);
            this.labelDateBusList.Name = "labelDateBusList";
            this.labelDateBusList.Size = new System.Drawing.Size(52, 21);
            this.labelDateBusList.TabIndex = 8;
            this.labelDateBusList.Text = "None";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(42, 41);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 19);
            this.label24.TabIndex = 7;
            this.label24.Text = "Date:";
            // 
            // buttonCheckBus
            // 
            this.buttonCheckBus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckBus.Location = new System.Drawing.Point(21, 238);
            this.buttonCheckBus.Name = "buttonCheckBus";
            this.buttonCheckBus.Size = new System.Drawing.Size(103, 29);
            this.buttonCheckBus.TabIndex = 6;
            this.buttonCheckBus.Text = "Check Bus";
            this.buttonCheckBus.UseVisualStyleBackColor = true;
            this.buttonCheckBus.Click += new System.EventHandler(this.buttonCheckBus_Click);
            // 
            // labelArrival
            // 
            this.labelArrival.AutoSize = true;
            this.labelArrival.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrival.Location = new System.Drawing.Point(378, 65);
            this.labelArrival.Name = "labelArrival";
            this.labelArrival.Size = new System.Drawing.Size(66, 21);
            this.labelArrival.TabIndex = 5;
            this.labelArrival.Text = "label25";
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeparture.Location = new System.Drawing.Point(138, 65);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(66, 21);
            this.labelDeparture.TabIndex = 4;
            this.labelDeparture.Text = "label24";
            // 
            // listViewBus
            // 
            this.listViewBus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numColumn,
            this.nameBus,
            this.classColumn,
            this.timeColumn,
            this.priceColumn});
            this.listViewBus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBus.FullRowSelect = true;
            this.listViewBus.Location = new System.Drawing.Point(76, 96);
            this.listViewBus.MultiSelect = false;
            this.listViewBus.Name = "listViewBus";
            this.listViewBus.Size = new System.Drawing.Size(513, 131);
            this.listViewBus.TabIndex = 3;
            this.listViewBus.UseCompatibleStateImageBehavior = false;
            this.listViewBus.View = System.Windows.Forms.View.Details;
            this.listViewBus.SelectedIndexChanged += new System.EventHandler(this.listViewBus_SelectedIndexChanged);
            // 
            // numColumn
            // 
            this.numColumn.Text = "No.";
            this.numColumn.Width = 37;
            // 
            // nameBus
            // 
            this.nameBus.Text = "Name Bus";
            this.nameBus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameBus.Width = 152;
            // 
            // classColumn
            // 
            this.classColumn.Text = "Class";
            this.classColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.classColumn.Width = 121;
            // 
            // timeColumn
            // 
            this.timeColumn.Text = "Time";
            this.timeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeColumn.Width = 91;
            // 
            // priceColumn
            // 
            this.priceColumn.Text = "Price";
            this.priceColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceColumn.Width = 107;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(316, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 19);
            this.label23.TabIndex = 2;
            this.label23.Text = "Arrival:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(42, 67);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 19);
            this.label22.TabIndex = 1;
            this.label22.Text = "Departure:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 23);
            this.label21.TabIndex = 0;
            this.label21.Text = "Bus List:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(627, 44);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(450, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Select Bus";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(464, 44);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(260, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Pick Schedule";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(287, 41);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(68, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Set Destination";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(97, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(535, 424);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Previous";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(645, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Next";
            // 
            // picPrev
            // 
            this.picPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPrev.Image = ((System.Drawing.Image)(resources.GetObject("picPrev.Image")));
            this.picPrev.Location = new System.Drawing.Point(548, 389);
            this.picPrev.Name = "picPrev";
            this.picPrev.Size = new System.Drawing.Size(32, 32);
            this.picPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPrev.TabIndex = 7;
            this.picPrev.TabStop = false;
            this.picPrev.Click += new System.EventHandler(this.picPrev_Click);
            // 
            // picBoxNext
            // 
            this.picBoxNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxNext.Image = ((System.Drawing.Image)(resources.GetObject("picBoxNext.Image")));
            this.picBoxNext.Location = new System.Drawing.Point(648, 389);
            this.picBoxNext.Name = "picBoxNext";
            this.picBoxNext.Size = new System.Drawing.Size(32, 32);
            this.picBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxNext.TabIndex = 6;
            this.picBoxNext.TabStop = false;
            this.picBoxNext.Click += new System.EventHandler(this.picBoxNext_Click);
            // 
            // panelIDForm
            // 
            this.panelIDForm.Controls.Add(this.label4);
            this.panelIDForm.Controls.Add(this.textLastName);
            this.panelIDForm.Controls.Add(this.comboBox2);
            this.panelIDForm.Controls.Add(this.label9);
            this.panelIDForm.Controls.Add(this.comboBox1);
            this.panelIDForm.Controls.Add(this.label8);
            this.panelIDForm.Controls.Add(this.textResidentID);
            this.panelIDForm.Controls.Add(this.label7);
            this.panelIDForm.Controls.Add(this.textPhoneNumber);
            this.panelIDForm.Controls.Add(this.label6);
            this.panelIDForm.Controls.Add(this.textFirstName);
            this.panelIDForm.Controls.Add(this.label5);
            this.panelIDForm.Location = new System.Drawing.Point(43, 106);
            this.panelIDForm.Name = "panelIDForm";
            this.panelIDForm.Size = new System.Drawing.Size(686, 268);
            this.panelIDForm.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(356, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Last Name:";
            // 
            // textLastName
            // 
            this.textLastName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLastName.Location = new System.Drawing.Point(470, 35);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(164, 26);
            this.textLastName.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(360, 194);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(274, 25);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(356, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Arrival:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 25);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(25, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Departure:";
            // 
            // textResidentID
            // 
            this.textResidentID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResidentID.Location = new System.Drawing.Point(470, 96);
            this.textResidentID.Name = "textResidentID";
            this.textResidentID.Size = new System.Drawing.Size(164, 26);
            this.textResidentID.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(356, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Resident ID:";
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhoneNumber.Location = new System.Drawing.Point(155, 95);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(164, 26);
            this.textPhoneNumber.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(25, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Phone Number: ";
            // 
            // textFirstName
            // 
            this.textFirstName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirstName.Location = new System.Drawing.Point(155, 35);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(164, 26);
            this.textFirstName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(25, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome:";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(426, 74);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(65, 22);
            this.labelUserID.TabIndex = 5;
            this.labelUserID.Text = "label4";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.White;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogout.Location = new System.Drawing.Point(891, 69);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(118, 36);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // mainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 622);
            this.Controls.Add(this.groupBoxHelp);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.groupBoxRefund);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxReserv);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainInterface";
            this.Load += new System.EventHandler(this.mainInterface_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxHelp.ResumeLayout(false);
            this.groupBoxHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxRefund.ResumeLayout(false);
            this.groupBoxRefund.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxReserv.ResumeLayout(false);
            this.groupBoxReserv.PerformLayout();
            this.panelSeat.ResumeLayout(false);
            this.panelSeat.PerformLayout();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.panelListBus.ResumeLayout(false);
            this.panelListBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNext)).EndInit();
            this.panelIDForm.ResumeLayout(false);
            this.panelIDForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonReserv;
        private System.Windows.Forms.GroupBox groupBoxReserv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picPrev;
        private System.Windows.Forms.PictureBox picBoxNext;
        private System.Windows.Forms.Panel panelIDForm;
        private System.Windows.Forms.Button buttonSubmitBook;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textResidentID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelLight1;
        private System.Windows.Forms.Panel panelLight3;
        private System.Windows.Forms.Panel panelLight2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.GroupBox groupBoxRefund;
        private System.Windows.Forms.GroupBox groupBoxHelp;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioRoundNo;
        private System.Windows.Forms.RadioButton radioRoundYes;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dateReturn;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.Panel panelListBus;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.ListView listViewBus;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panelSeat;
        private System.Windows.Forms.Label labelBusSelected;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private Button buttonCheckBus;
        private ColumnHeader numColumn;
        private ColumnHeader nameBus;
        private ColumnHeader classColumn;
        private ColumnHeader timeColumn;
        private ColumnHeader priceColumn;
        private Label labelDateBusList;
        private Label label24;
        private Button buttonCheckSeat;
        private Panel panelDrawSeat;
        private Panel panel6;
        private Panel panel5;
        private Label label44;
        private Label label43;
        private Label label42;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label26;
        private Label label25;
        private Label label19;
        private Label labelSeatSelectedShow;
        private Label label48;
        private Label labelClassSelected;
        private Label label46;
        private Button buttonDelete;
        private Button buttonRefresh;
        private Label label47;
        private ListView listviewRefresh;
        private ColumnHeader colNo;
        private ColumnHeader colFirst;
        private ColumnHeader colLast;
        private ColumnHeader colID;
        private ColumnHeader colPhone;
        private ColumnHeader colDate;
        private ColumnHeader colTime;
        private ColumnHeader colCityDep;
        private ColumnHeader colCityAr;
        private ColumnHeader colName;
        private ColumnHeader colClass;
        private ColumnHeader colSeat;
        private ColumnHeader colPrice;
        private Label label52;
        private Label label51;
        private Label label50;
        private LinkLabel linkLabel1;
        private Label label49;
        private Label label45;
        private Label label18;
        private Label label16;
        private PictureBox pictureBox2;
        private Label label53;
    }
}