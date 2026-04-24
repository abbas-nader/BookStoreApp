namespace BookStoreApp.UI
{
    partial class frmReport
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
            this.components = new System.ComponentModel.Container();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtEndDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStartDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbInventoryStaffReports = new System.Windows.Forms.GroupBox();
            this.btnBookInvertoryList = new Guna.UI2.WinForms.Guna2Button();
            this.btnLowStockOutOfStock = new Guna.UI2.WinForms.Guna2Button();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.btnNewCustomerRegistrations = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDemographics = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerNearThreshold = new Guna.UI2.WinForms.Guna2Button();
            this.btnMostValuableCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.gbSales = new System.Windows.Forms.GroupBox();
            this.btnMonthlyRevenue = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalesByBookCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnDailySalesSummary = new Guna.UI2.WinForms.Guna2Button();
            this.btnTopSellingAuthors = new Guna.UI2.WinForms.Guna2Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnLock = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain.SuspendLayout();
            this.gbInventoryStaffReports.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.gbSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderlessForm
            // 
            this.borderlessForm.BorderRadius = 30;
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Controls.Add(this.btnLock);
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.btnMinimize);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.txtEndDate);
            this.pnlMain.Controls.Add(this.txtStartDate);
            this.pnlMain.Controls.Add(this.gbInventoryStaffReports);
            this.pnlMain.Controls.Add(this.gbCustomer);
            this.pnlMain.Controls.Add(this.gbSales);
            this.pnlMain.Controls.Add(this.lblEndDate);
            this.pnlMain.Controls.Add(this.lblStartDate);
            this.pnlMain.Controls.Add(this.lblReports);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(815, 504);
            this.pnlMain.TabIndex = 0;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderColor = System.Drawing.Color.LightGray;
            this.txtEndDate.BorderRadius = 6;
            this.txtEndDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndDate.DefaultText = "";
            this.txtEndDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEndDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEndDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndDate.FillColor = System.Drawing.SystemColors.Control;
            this.txtEndDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEndDate.ForeColor = System.Drawing.Color.Black;
            this.txtEndDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndDate.Location = new System.Drawing.Point(546, 59);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtEndDate.PlaceholderText = "Enter End Date";
            this.txtEndDate.SelectedText = "";
            this.txtEndDate.Size = new System.Drawing.Size(200, 35);
            this.txtEndDate.TabIndex = 13;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderColor = System.Drawing.Color.LightGray;
            this.txtStartDate.BorderRadius = 6;
            this.txtStartDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartDate.DefaultText = "";
            this.txtStartDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStartDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStartDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStartDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStartDate.FillColor = System.Drawing.SystemColors.Control;
            this.txtStartDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStartDate.ForeColor = System.Drawing.Color.Black;
            this.txtStartDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStartDate.Location = new System.Drawing.Point(266, 59);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtStartDate.PlaceholderText = "Enter Start Date";
            this.txtStartDate.SelectedText = "";
            this.txtStartDate.Size = new System.Drawing.Size(200, 35);
            this.txtStartDate.TabIndex = 12;
            // 
            // gbInventoryStaffReports
            // 
            this.gbInventoryStaffReports.Controls.Add(this.btnBookInvertoryList);
            this.gbInventoryStaffReports.Controls.Add(this.btnLowStockOutOfStock);
            this.gbInventoryStaffReports.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInventoryStaffReports.Location = new System.Drawing.Point(10, 379);
            this.gbInventoryStaffReports.Name = "gbInventoryStaffReports";
            this.gbInventoryStaffReports.Padding = new System.Windows.Forms.Padding(15);
            this.gbInventoryStaffReports.Size = new System.Drawing.Size(794, 100);
            this.gbInventoryStaffReports.TabIndex = 9;
            this.gbInventoryStaffReports.TabStop = false;
            this.gbInventoryStaffReports.Text = "Inventory && Staff Reports";
            // 
            // btnBookInvertoryList
            // 
            this.btnBookInvertoryList.Animated = true;
            this.btnBookInvertoryList.BorderRadius = 10;
            this.btnBookInvertoryList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookInvertoryList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookInvertoryList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookInvertoryList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookInvertoryList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookInvertoryList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.btnBookInvertoryList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBookInvertoryList.ForeColor = System.Drawing.Color.White;
            this.btnBookInvertoryList.Location = new System.Drawing.Point(27, 34);
            this.btnBookInvertoryList.Name = "btnBookInvertoryList";
            this.btnBookInvertoryList.Size = new System.Drawing.Size(180, 45);
            this.btnBookInvertoryList.TabIndex = 0;
            this.btnBookInvertoryList.Text = "Book Invertory List";
            // 
            // btnLowStockOutOfStock
            // 
            this.btnLowStockOutOfStock.Animated = true;
            this.btnLowStockOutOfStock.BorderRadius = 10;
            this.btnLowStockOutOfStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLowStockOutOfStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLowStockOutOfStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLowStockOutOfStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLowStockOutOfStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLowStockOutOfStock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnLowStockOutOfStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLowStockOutOfStock.ForeColor = System.Drawing.Color.White;
            this.btnLowStockOutOfStock.Location = new System.Drawing.Point(213, 34);
            this.btnLowStockOutOfStock.Name = "btnLowStockOutOfStock";
            this.btnLowStockOutOfStock.Size = new System.Drawing.Size(205, 45);
            this.btnLowStockOutOfStock.TabIndex = 0;
            this.btnLowStockOutOfStock.Text = "Low Stock/ Out Of Stock";
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.btnNewCustomerRegistrations);
            this.gbCustomer.Controls.Add(this.btnCustomerDemographics);
            this.gbCustomer.Controls.Add(this.btnCustomerNearThreshold);
            this.gbCustomer.Controls.Add(this.btnMostValuableCustomers);
            this.gbCustomer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomer.Location = new System.Drawing.Point(10, 220);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Padding = new System.Windows.Forms.Padding(15);
            this.gbCustomer.Size = new System.Drawing.Size(794, 143);
            this.gbCustomer.TabIndex = 10;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer Reports";
            // 
            // btnNewCustomerRegistrations
            // 
            this.btnNewCustomerRegistrations.Animated = true;
            this.btnNewCustomerRegistrations.BorderRadius = 10;
            this.btnNewCustomerRegistrations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCustomerRegistrations.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewCustomerRegistrations.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewCustomerRegistrations.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewCustomerRegistrations.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewCustomerRegistrations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.btnNewCustomerRegistrations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNewCustomerRegistrations.ForeColor = System.Drawing.Color.White;
            this.btnNewCustomerRegistrations.Location = new System.Drawing.Point(18, 85);
            this.btnNewCustomerRegistrations.Name = "btnNewCustomerRegistrations";
            this.btnNewCustomerRegistrations.Size = new System.Drawing.Size(232, 45);
            this.btnNewCustomerRegistrations.TabIndex = 0;
            this.btnNewCustomerRegistrations.Text = "New Customer Registrations";
            // 
            // btnCustomerDemographics
            // 
            this.btnCustomerDemographics.Animated = true;
            this.btnCustomerDemographics.BorderRadius = 10;
            this.btnCustomerDemographics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerDemographics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDemographics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDemographics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDemographics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDemographics.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.btnCustomerDemographics.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCustomerDemographics.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDemographics.Location = new System.Drawing.Point(18, 34);
            this.btnCustomerDemographics.Name = "btnCustomerDemographics";
            this.btnCustomerDemographics.Size = new System.Drawing.Size(205, 45);
            this.btnCustomerDemographics.TabIndex = 0;
            this.btnCustomerDemographics.Text = "Customer Demographics";
            // 
            // btnCustomerNearThreshold
            // 
            this.btnCustomerNearThreshold.Animated = true;
            this.btnCustomerNearThreshold.BorderRadius = 10;
            this.btnCustomerNearThreshold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerNearThreshold.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerNearThreshold.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerNearThreshold.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerNearThreshold.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerNearThreshold.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnCustomerNearThreshold.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCustomerNearThreshold.ForeColor = System.Drawing.Color.White;
            this.btnCustomerNearThreshold.Location = new System.Drawing.Point(442, 34);
            this.btnCustomerNearThreshold.Name = "btnCustomerNearThreshold";
            this.btnCustomerNearThreshold.Size = new System.Drawing.Size(228, 45);
            this.btnCustomerNearThreshold.TabIndex = 0;
            this.btnCustomerNearThreshold.Text = "Customer Near Threshold";
            // 
            // btnMostValuableCustomers
            // 
            this.btnMostValuableCustomers.Animated = true;
            this.btnMostValuableCustomers.BorderRadius = 10;
            this.btnMostValuableCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostValuableCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMostValuableCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMostValuableCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMostValuableCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMostValuableCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.btnMostValuableCustomers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMostValuableCustomers.ForeColor = System.Drawing.Color.White;
            this.btnMostValuableCustomers.Location = new System.Drawing.Point(226, 34);
            this.btnMostValuableCustomers.Name = "btnMostValuableCustomers";
            this.btnMostValuableCustomers.Size = new System.Drawing.Size(210, 45);
            this.btnMostValuableCustomers.TabIndex = 0;
            this.btnMostValuableCustomers.Text = "Most Valuable Customers";
            // 
            // gbSales
            // 
            this.gbSales.BackColor = System.Drawing.Color.Transparent;
            this.gbSales.Controls.Add(this.btnMonthlyRevenue);
            this.gbSales.Controls.Add(this.btnSalesByBookCategory);
            this.gbSales.Controls.Add(this.btnDailySalesSummary);
            this.gbSales.Controls.Add(this.btnTopSellingAuthors);
            this.gbSales.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSales.Location = new System.Drawing.Point(10, 114);
            this.gbSales.Name = "gbSales";
            this.gbSales.Padding = new System.Windows.Forms.Padding(15);
            this.gbSales.Size = new System.Drawing.Size(794, 100);
            this.gbSales.TabIndex = 11;
            this.gbSales.TabStop = false;
            this.gbSales.Text = "Sales && Revenue Reports";
            // 
            // btnMonthlyRevenue
            // 
            this.btnMonthlyRevenue.Animated = true;
            this.btnMonthlyRevenue.BorderRadius = 10;
            this.btnMonthlyRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthlyRevenue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonthlyRevenue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonthlyRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonthlyRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonthlyRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.btnMonthlyRevenue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMonthlyRevenue.ForeColor = System.Drawing.Color.White;
            this.btnMonthlyRevenue.Location = new System.Drawing.Point(412, 37);
            this.btnMonthlyRevenue.Name = "btnMonthlyRevenue";
            this.btnMonthlyRevenue.Size = new System.Drawing.Size(180, 45);
            this.btnMonthlyRevenue.TabIndex = 0;
            this.btnMonthlyRevenue.Text = "Monthly Revenue";
            // 
            // btnSalesByBookCategory
            // 
            this.btnSalesByBookCategory.Animated = true;
            this.btnSalesByBookCategory.BorderRadius = 10;
            this.btnSalesByBookCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesByBookCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalesByBookCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalesByBookCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalesByBookCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalesByBookCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.btnSalesByBookCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSalesByBookCategory.ForeColor = System.Drawing.Color.White;
            this.btnSalesByBookCategory.Location = new System.Drawing.Point(203, 37);
            this.btnSalesByBookCategory.Name = "btnSalesByBookCategory";
            this.btnSalesByBookCategory.Size = new System.Drawing.Size(203, 45);
            this.btnSalesByBookCategory.TabIndex = 0;
            this.btnSalesByBookCategory.Text = "Sales By Book Category";
            // 
            // btnDailySalesSummary
            // 
            this.btnDailySalesSummary.Animated = true;
            this.btnDailySalesSummary.BorderRadius = 10;
            this.btnDailySalesSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDailySalesSummary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDailySalesSummary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDailySalesSummary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDailySalesSummary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDailySalesSummary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.btnDailySalesSummary.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDailySalesSummary.ForeColor = System.Drawing.Color.White;
            this.btnDailySalesSummary.Location = new System.Drawing.Point(18, 37);
            this.btnDailySalesSummary.Name = "btnDailySalesSummary";
            this.btnDailySalesSummary.Size = new System.Drawing.Size(180, 45);
            this.btnDailySalesSummary.TabIndex = 0;
            this.btnDailySalesSummary.Text = "Daily Sales Summary";
            // 
            // btnTopSellingAuthors
            // 
            this.btnTopSellingAuthors.Animated = true;
            this.btnTopSellingAuthors.BorderRadius = 10;
            this.btnTopSellingAuthors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopSellingAuthors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTopSellingAuthors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTopSellingAuthors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTopSellingAuthors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTopSellingAuthors.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.btnTopSellingAuthors.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnTopSellingAuthors.ForeColor = System.Drawing.Color.White;
            this.btnTopSellingAuthors.Location = new System.Drawing.Point(598, 37);
            this.btnTopSellingAuthors.Name = "btnTopSellingAuthors";
            this.btnTopSellingAuthors.Size = new System.Drawing.Size(180, 45);
            this.btnTopSellingAuthors.TabIndex = 0;
            this.btnTopSellingAuthors.Text = "Top-Selling Authors";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(486, 72);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(54, 15);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(202, 72);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 15);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(38, 59);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(97, 31);
            this.lblReports.TabIndex = 6;
            this.lblReports.Text = "Reports";
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.BorderRadius = 8;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(750, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 29);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Animated = true;
            this.btnMinimize.BorderRadius = 8;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(669, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(77, 29);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.Text = "Minimize";
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 8;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(548, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 29);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            // 
            // btnLock
            // 
            this.btnLock.Animated = true;
            this.btnLock.BorderRadius = 8;
            this.btnLock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnLock.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.Location = new System.Drawing.Point(608, 4);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(54, 29);
            this.btnLock.TabIndex = 14;
            this.btnLock.Text = "Lock";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(815, 504);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbInventoryStaffReports.ResumeLayout(false);
            this.gbCustomer.ResumeLayout(false);
            this.gbSales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private System.Windows.Forms.Panel pnlMain;
        private Guna.UI2.WinForms.Guna2TextBox txtEndDate;
        private Guna.UI2.WinForms.Guna2TextBox txtStartDate;
        private System.Windows.Forms.GroupBox gbInventoryStaffReports;
        private Guna.UI2.WinForms.Guna2Button btnBookInvertoryList;
        private Guna.UI2.WinForms.Guna2Button btnLowStockOutOfStock;
        private System.Windows.Forms.GroupBox gbCustomer;
        private Guna.UI2.WinForms.Guna2Button btnNewCustomerRegistrations;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDemographics;
        private Guna.UI2.WinForms.Guna2Button btnCustomerNearThreshold;
        private Guna.UI2.WinForms.Guna2Button btnMostValuableCustomers;
        private System.Windows.Forms.GroupBox gbSales;
        private Guna.UI2.WinForms.Guna2Button btnMonthlyRevenue;
        private Guna.UI2.WinForms.Guna2Button btnSalesByBookCategory;
        private Guna.UI2.WinForms.Guna2Button btnDailySalesSummary;
        private Guna.UI2.WinForms.Guna2Button btnTopSellingAuthors;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblReports;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnLock;
    }
}