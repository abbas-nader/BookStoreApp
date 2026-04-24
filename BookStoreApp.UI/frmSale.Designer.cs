namespace BookStoreApp.UI
{
    partial class frmSale
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
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnLock = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearData = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbCustomerSelecetion = new System.Windows.Forms.GroupBox();
            this.lblPhonOrName = new System.Windows.Forms.Label();
            this.txtSearchCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNewSale = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnNewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBookSelectionAndCart = new System.Windows.Forms.GroupBox();
            this.gbBookResult = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBookSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtBookName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvBookSelected = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApply = new Guna.UI2.WinForms.Guna2Button();
            this.txtDiscountCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbAuthor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.gbCustomerSelecetion.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.gbBookSelectionAndCart.SuspendLayout();
            this.gbBookResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookSelected)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.dgvBookSelected);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.lblNewSale);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnClearData);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.gbBookSelectionAndCart);
            this.pnlMain.Controls.Add(this.gbCustomerSelecetion);
            this.pnlMain.Controls.Add(this.btnMinimize);
            this.pnlMain.Controls.Add(this.btnLock);
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(828, 634);
            this.pnlMain.TabIndex = 1;
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
            this.btnMinimize.Location = new System.Drawing.Point(678, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(77, 29);
            this.btnMinimize.TabIndex = 38;
            this.btnMinimize.Text = "Minimize";
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
            this.btnLock.Location = new System.Drawing.Point(617, 4);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(54, 29);
            this.btnLock.TabIndex = 36;
            this.btnLock.Text = "Lock";
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
            this.btnBack.Location = new System.Drawing.Point(557, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 29);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Back";
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
            this.btnExit.Location = new System.Drawing.Point(759, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 29);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "Exit";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Animated = true;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(714, 43);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 36);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // btnClearData
            // 
            this.btnClearData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearData.Animated = true;
            this.btnClearData.BorderRadius = 10;
            this.btnClearData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(123)))), ((int)(((byte)(18)))));
            this.btnClearData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearData.ForeColor = System.Drawing.Color.White;
            this.btnClearData.Location = new System.Drawing.Point(610, 43);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(100, 36);
            this.btnClearData.TabIndex = 46;
            this.btnClearData.Text = "ClearData";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(147)))), ((int)(((byte)(90)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(504, 43);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // gbCustomerSelecetion
            // 
            this.gbCustomerSelecetion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbCustomerSelecetion.Controls.Add(this.gbResult);
            this.gbCustomerSelecetion.Controls.Add(this.lblPhonOrName);
            this.gbCustomerSelecetion.Controls.Add(this.btnSearch);
            this.gbCustomerSelecetion.Controls.Add(this.btnNewCustomer);
            this.gbCustomerSelecetion.Controls.Add(this.txtSearchCustomer);
            this.gbCustomerSelecetion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerSelecetion.Location = new System.Drawing.Point(12, 85);
            this.gbCustomerSelecetion.Name = "gbCustomerSelecetion";
            this.gbCustomerSelecetion.Size = new System.Drawing.Size(437, 199);
            this.gbCustomerSelecetion.TabIndex = 40;
            this.gbCustomerSelecetion.TabStop = false;
            this.gbCustomerSelecetion.Text = "Customer Selecetion";
            // 
            // lblPhonOrName
            // 
            this.lblPhonOrName.AutoSize = true;
            this.lblPhonOrName.Location = new System.Drawing.Point(28, 46);
            this.lblPhonOrName.Name = "lblPhonOrName";
            this.lblPhonOrName.Size = new System.Drawing.Size(133, 15);
            this.lblPhonOrName.TabIndex = 1;
            this.lblPhonOrName.Text = "Customer Phone/Name";
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.BorderColor = System.Drawing.Color.LightGray;
            this.txtSearchCustomer.BorderRadius = 8;
            this.txtSearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCustomer.DefaultText = "";
            this.txtSearchCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomer.FillColor = System.Drawing.SystemColors.Control;
            this.txtSearchCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtSearchCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomer.Location = new System.Drawing.Point(31, 64);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearchCustomer.PlaceholderText = "Enter Phone/Name";
            this.txtSearchCustomer.SelectedText = "";
            this.txtSearchCustomer.Size = new System.Drawing.Size(185, 22);
            this.txtSearchCustomer.TabIndex = 1;
            // 
            // lblNewSale
            // 
            this.lblNewSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewSale.BackColor = System.Drawing.Color.Transparent;
            this.lblNewSale.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblNewSale.Location = new System.Drawing.Point(140, 43);
            this.lblNewSale.Name = "lblNewSale";
            this.lblNewSale.Size = new System.Drawing.Size(101, 33);
            this.lblNewSale.TabIndex = 48;
            this.lblNewSale.Text = "New Sale";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewCustomer.Animated = true;
            this.btnNewCustomer.BorderRadius = 10;
            this.btnNewCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewCustomer.FillColor = System.Drawing.Color.LightGray;
            this.btnNewCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNewCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnNewCustomer.Location = new System.Drawing.Point(259, 64);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(153, 36);
            this.btnNewCustomer.TabIndex = 47;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Animated = true;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.LightGray;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(259, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 36);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // gbResult
            // 
            this.gbResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbResult.Controls.Add(this.label2);
            this.gbResult.Controls.Add(this.label1);
            this.gbResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.Location = new System.Drawing.Point(18, 106);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(394, 77);
            this.gbResult.TabIndex = 48;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "CustomerName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current  Points:";
            // 
            // gbBookSelectionAndCart
            // 
            this.gbBookSelectionAndCart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbBookSelectionAndCart.Controls.Add(this.gbBookResult);
            this.gbBookSelectionAndCart.Controls.Add(this.btnBookSearch);
            this.gbBookSelectionAndCart.Controls.Add(this.txtBookName);
            this.gbBookSelectionAndCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookSelectionAndCart.Location = new System.Drawing.Point(12, 290);
            this.gbBookSelectionAndCart.Name = "gbBookSelectionAndCart";
            this.gbBookSelectionAndCart.Size = new System.Drawing.Size(437, 196);
            this.gbBookSelectionAndCart.TabIndex = 40;
            this.gbBookSelectionAndCart.TabStop = false;
            this.gbBookSelectionAndCart.Text = "Book Selection && Cart";
            // 
            // gbBookResult
            // 
            this.gbBookResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbBookResult.Controls.Add(this.label10);
            this.gbBookResult.Controls.Add(this.btnAdd);
            this.gbBookResult.Controls.Add(this.txtCount);
            this.gbBookResult.Controls.Add(this.label5);
            this.gbBookResult.Controls.Add(this.label3);
            this.gbBookResult.Controls.Add(this.label4);
            this.gbBookResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookResult.Location = new System.Drawing.Point(18, 78);
            this.gbBookResult.Name = "gbBookResult";
            this.gbBookResult.Size = new System.Drawing.Size(394, 105);
            this.gbBookResult.TabIndex = 48;
            this.gbBookResult.TabStop = false;
            this.gbBookResult.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Title: ";
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBookSearch.Animated = true;
            this.btnBookSearch.BorderRadius = 10;
            this.btnBookSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookSearch.FillColor = System.Drawing.Color.LightGray;
            this.btnBookSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBookSearch.ForeColor = System.Drawing.Color.Black;
            this.btnBookSearch.Location = new System.Drawing.Point(305, 36);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(107, 36);
            this.btnBookSearch.TabIndex = 47;
            this.btnBookSearch.Text = "Search";
            this.btnBookSearch.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // txtBookName
            // 
            this.txtBookName.BorderColor = System.Drawing.Color.LightGray;
            this.txtBookName.BorderRadius = 8;
            this.txtBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookName.DefaultText = "";
            this.txtBookName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookName.FillColor = System.Drawing.SystemColors.Control;
            this.txtBookName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookName.ForeColor = System.Drawing.Color.Black;
            this.txtBookName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookName.Location = new System.Drawing.Point(19, 43);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtBookName.PlaceholderText = "Enter Book Name";
            this.txtBookName.SelectedText = "";
            this.txtBookName.Size = new System.Drawing.Size(271, 22);
            this.txtBookName.TabIndex = 1;
            // 
            // dgvBookSelected
            // 
            this.dgvBookSelected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookSelected.Location = new System.Drawing.Point(12, 511);
            this.dgvBookSelected.Name = "dgvBookSelected";
            this.dgvBookSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookSelected.Size = new System.Drawing.Size(804, 111);
            this.dgvBookSelected.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Shopping Cart Table";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Stock:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Animated = true;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.LightGray;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(318, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 36);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // txtCount
            // 
            this.txtCount.BorderColor = System.Drawing.Color.LightGray;
            this.txtCount.BorderRadius = 8;
            this.txtCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCount.DefaultText = "";
            this.txtCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCount.FillColor = System.Drawing.SystemColors.Control;
            this.txtCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCount.ForeColor = System.Drawing.Color.Black;
            this.txtCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCount.Location = new System.Drawing.Point(231, 68);
            this.txtCount.Name = "txtCount";
            this.txtCount.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtCount.PlaceholderText = "";
            this.txtCount.SelectedText = "";
            this.txtCount.Size = new System.Drawing.Size(71, 22);
            this.txtCount.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.txtDiscountCode);
            this.groupBox1.Controls.Add(this.cmbAuthor);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(455, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 391);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApply.Animated = true;
            this.btnApply.BorderRadius = 10;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnApply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApply.FillColor = System.Drawing.Color.LightGray;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(270, 99);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(59, 36);
            this.btnApply.TabIndex = 59;
            this.btnApply.Text = "Apply";
            this.btnApply.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // txtDiscountCode
            // 
            this.txtDiscountCode.BorderColor = System.Drawing.Color.LightGray;
            this.txtDiscountCode.BorderRadius = 8;
            this.txtDiscountCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDiscountCode.DefaultText = "";
            this.txtDiscountCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscountCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscountCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscountCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscountCode.FillColor = System.Drawing.SystemColors.Control;
            this.txtDiscountCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscountCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiscountCode.ForeColor = System.Drawing.Color.Black;
            this.txtDiscountCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscountCode.Location = new System.Drawing.Point(129, 104);
            this.txtDiscountCode.Name = "txtDiscountCode";
            this.txtDiscountCode.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtDiscountCode.PlaceholderText = "";
            this.txtDiscountCode.SelectedText = "";
            this.txtDiscountCode.Size = new System.Drawing.Size(121, 22);
            this.txtDiscountCode.TabIndex = 58;
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAuthor.BackColor = System.Drawing.Color.Transparent;
            this.cmbAuthor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbAuthor.BorderRadius = 7;
            this.cmbAuthor.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbAuthor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAuthor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAuthor.ForeColor = System.Drawing.Color.Black;
            this.cmbAuthor.ItemHeight = 30;
            this.cmbAuthor.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Mobile"});
            this.cmbAuthor.Location = new System.Drawing.Point(38, 311);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(230, 36);
            this.cmbAuthor.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.Location = new System.Drawing.Point(35, 283);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Payment Method";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Location = new System.Drawing.Point(35, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Discount Amount:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 31);
            this.label14.TabIndex = 51;
            this.label14.Text = "Final Amount:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Location = new System.Drawing.Point(35, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Customer Current Points:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Location = new System.Drawing.Point(35, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Discount Code:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Location = new System.Drawing.Point(35, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Points To Be Earned:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(35, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Subtotal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Location = new System.Drawing.Point(35, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Discount:";
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(828, 634);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSale";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbCustomerSelecetion.ResumeLayout(false);
            this.gbCustomerSelecetion.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.gbBookSelectionAndCart.ResumeLayout(false);
            this.gbBookResult.ResumeLayout(false);
            this.gbBookResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookSelected)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private System.Windows.Forms.Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnLock;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnClearData;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.GroupBox gbCustomerSelecetion;
        private System.Windows.Forms.Label lblPhonOrName;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNewSale;
        private Guna.UI2.WinForms.Guna2Button btnNewCustomer;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.GroupBox gbBookSelectionAndCart;
        private System.Windows.Forms.GroupBox gbBookResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnBookSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtBookName;
        private System.Windows.Forms.DataGridView dgvBookSelected;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnApply;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscountCode;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAuthor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}