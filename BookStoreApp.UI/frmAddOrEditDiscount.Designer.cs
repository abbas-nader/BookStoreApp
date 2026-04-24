namespace BookStoreApp.UI
{
    partial class frmAddOrEditDiscount
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
            this.lblPercent = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbBasicInformation = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblInsertOrUpdateDiscount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbDiscountType = new System.Windows.Forms.GroupBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnLock = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearData = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.gbUsageLimits = new System.Windows.Forms.GroupBox();
            this.chbActive = new System.Windows.Forms.CheckBox();
            this.txtPercent = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbValidityPeriod = new System.Windows.Forms.GroupBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtStartDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEndDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaxUsage = new System.Windows.Forms.Label();
            this.lblMaxUsagePerCustomer = new System.Windows.Forms.Label();
            this.txtMaxUsage = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaxUsagePerCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbConditions = new System.Windows.Forms.GroupBox();
            this.lblMinimumPurchaseAmoun = new System.Windows.Forms.Label();
            this.txtMinimumPurchaseAmoun = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbtnPercentage = new System.Windows.Forms.RadioButton();
            this.rbtnFixedAmount = new System.Windows.Forms.RadioButton();
            this.txtUsedCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUsedCount = new System.Windows.Forms.Label();
            this.txtRequiredPoints = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRequiredPoints = new System.Windows.Forms.Label();
            this.gbBasicInformation.SuspendLayout();
            this.gbDiscountType.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.gbUsageLimits.SuspendLayout();
            this.gbValidityPeriod.SuspendLayout();
            this.gbConditions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(23, 88);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(47, 15);
            this.lblPercent.TabIndex = 1;
            this.lblPercent.Text = "Percent";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderColor = System.Drawing.Color.LightGray;
            this.txtAmount.BorderRadius = 8;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FillColor = System.Drawing.SystemColors.Control;
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Location = new System.Drawing.Point(76, 120);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtAmount.PlaceholderText = "Enter Amount";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(128, 33);
            this.txtAmount.TabIndex = 9;
            // 
            // gbBasicInformation
            // 
            this.gbBasicInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbBasicInformation.Controls.Add(this.chbActive);
            this.gbBasicInformation.Controls.Add(this.lblDescription);
            this.gbBasicInformation.Controls.Add(this.lblCode);
            this.gbBasicInformation.Controls.Add(this.txtDescription);
            this.gbBasicInformation.Controls.Add(this.txtCode);
            this.gbBasicInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBasicInformation.Location = new System.Drawing.Point(8, 103);
            this.gbBasicInformation.Name = "gbBasicInformation";
            this.gbBasicInformation.Size = new System.Drawing.Size(304, 168);
            this.gbBasicInformation.TabIndex = 31;
            this.gbBasicInformation.TabStop = false;
            this.gbBasicInformation.Text = "Basic Information";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(29, 69);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 15);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(61, 31);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 15);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderColor = System.Drawing.Color.LightGray;
            this.txtDescription.BorderRadius = 8;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FillColor = System.Drawing.SystemColors.Control;
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(102, 69);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtDescription.PlaceholderText = "Enter Description";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(185, 64);
            this.txtDescription.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.BorderColor = System.Drawing.Color.LightGray;
            this.txtCode.BorderRadius = 8;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DefaultText = "";
            this.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.FillColor = System.Drawing.SystemColors.Control;
            this.txtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.Location = new System.Drawing.Point(102, 31);
            this.txtCode.Name = "txtCode";
            this.txtCode.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtCode.PlaceholderText = "Enter Code";
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(185, 22);
            this.txtCode.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(19, 128);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount";
            // 
            // borderlessForm
            // 
            this.borderlessForm.BorderRadius = 30;
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // lblInsertOrUpdateDiscount
            // 
            this.lblInsertOrUpdateDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInsertOrUpdateDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblInsertOrUpdateDiscount.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblInsertOrUpdateDiscount.Location = new System.Drawing.Point(32, 51);
            this.lblInsertOrUpdateDiscount.Name = "lblInsertOrUpdateDiscount";
            this.lblInsertOrUpdateDiscount.Size = new System.Drawing.Size(254, 33);
            this.lblInsertOrUpdateDiscount.TabIndex = 32;
            this.lblInsertOrUpdateDiscount.Text = "Discount Insert/Update";
            // 
            // gbDiscountType
            // 
            this.gbDiscountType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbDiscountType.Controls.Add(this.rbtnFixedAmount);
            this.gbDiscountType.Controls.Add(this.rbtnPercentage);
            this.gbDiscountType.Controls.Add(this.lblPercent);
            this.gbDiscountType.Controls.Add(this.lblAmount);
            this.gbDiscountType.Controls.Add(this.txtPercent);
            this.gbDiscountType.Controls.Add(this.txtAmount);
            this.gbDiscountType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiscountType.Location = new System.Drawing.Point(318, 103);
            this.gbDiscountType.Name = "gbDiscountType";
            this.gbDiscountType.Size = new System.Drawing.Size(210, 168);
            this.gbDiscountType.TabIndex = 33;
            this.gbDiscountType.TabStop = false;
            this.gbDiscountType.Text = "DiscountType";
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
            this.btnExit.Location = new System.Drawing.Point(692, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 29);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
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
            this.btnLock.Location = new System.Drawing.Point(550, 3);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(54, 29);
            this.btnLock.TabIndex = 38;
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
            this.btnBack.Location = new System.Drawing.Point(490, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 29);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
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
            this.btnMinimize.Location = new System.Drawing.Point(611, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(77, 29);
            this.btnMinimize.TabIndex = 40;
            this.btnMinimize.Text = "Minimize";
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
            this.btnCancel.Location = new System.Drawing.Point(645, 61);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 36);
            this.btnCancel.TabIndex = 37;
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
            this.btnClearData.Location = new System.Drawing.Point(541, 61);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(100, 36);
            this.btnClearData.TabIndex = 36;
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
            this.btnSave.Location = new System.Drawing.Point(435, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.btnLock);
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.btnMinimize);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnClearData);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.gbConditions);
            this.pnlMain.Controls.Add(this.gbUsageLimits);
            this.pnlMain.Controls.Add(this.lblInsertOrUpdateDiscount);
            this.pnlMain.Controls.Add(this.gbValidityPeriod);
            this.pnlMain.Controls.Add(this.gbDiscountType);
            this.pnlMain.Controls.Add(this.gbBasicInformation);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(756, 453);
            this.pnlMain.TabIndex = 1;
            // 
            // gbUsageLimits
            // 
            this.gbUsageLimits.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbUsageLimits.Controls.Add(this.lblMaxUsage);
            this.gbUsageLimits.Controls.Add(this.lblUsedCount);
            this.gbUsageLimits.Controls.Add(this.lblMaxUsagePerCustomer);
            this.gbUsageLimits.Controls.Add(this.txtMaxUsage);
            this.gbUsageLimits.Controls.Add(this.txtUsedCount);
            this.gbUsageLimits.Controls.Add(this.txtMaxUsagePerCustomer);
            this.gbUsageLimits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsageLimits.Location = new System.Drawing.Point(8, 277);
            this.gbUsageLimits.Name = "gbUsageLimits";
            this.gbUsageLimits.Size = new System.Drawing.Size(304, 163);
            this.gbUsageLimits.TabIndex = 34;
            this.gbUsageLimits.TabStop = false;
            this.gbUsageLimits.Text = "Usage Limits";
            // 
            // chbActive
            // 
            this.chbActive.AutoSize = true;
            this.chbActive.Checked = true;
            this.chbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbActive.Location = new System.Drawing.Point(102, 139);
            this.chbActive.Name = "chbActive";
            this.chbActive.Size = new System.Drawing.Size(59, 19);
            this.chbActive.TabIndex = 3;
            this.chbActive.Text = "Active";
            this.chbActive.UseVisualStyleBackColor = true;
            // 
            // txtPercent
            // 
            this.txtPercent.BorderColor = System.Drawing.Color.LightGray;
            this.txtPercent.BorderRadius = 8;
            this.txtPercent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPercent.DefaultText = "";
            this.txtPercent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPercent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPercent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPercent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPercent.FillColor = System.Drawing.SystemColors.Control;
            this.txtPercent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPercent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPercent.ForeColor = System.Drawing.Color.Black;
            this.txtPercent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPercent.Location = new System.Drawing.Point(76, 81);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPercent.PlaceholderText = "Enter Percent";
            this.txtPercent.SelectedText = "";
            this.txtPercent.Size = new System.Drawing.Size(128, 33);
            this.txtPercent.TabIndex = 9;
            // 
            // gbValidityPeriod
            // 
            this.gbValidityPeriod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbValidityPeriod.Controls.Add(this.lblStartDate);
            this.gbValidityPeriod.Controls.Add(this.lblEndDate);
            this.gbValidityPeriod.Controls.Add(this.txtStartDate);
            this.gbValidityPeriod.Controls.Add(this.txtEndDate);
            this.gbValidityPeriod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValidityPeriod.Location = new System.Drawing.Point(534, 103);
            this.gbValidityPeriod.Name = "gbValidityPeriod";
            this.gbValidityPeriod.Size = new System.Drawing.Size(210, 168);
            this.gbValidityPeriod.TabIndex = 33;
            this.gbValidityPeriod.TabStop = false;
            this.gbValidityPeriod.Text = "Validity Period";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(10, 50);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 15);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(14, 88);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(54, 15);
            this.lblEndDate.TabIndex = 1;
            this.lblEndDate.Text = "End Date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderColor = System.Drawing.Color.LightGray;
            this.txtStartDate.BorderRadius = 8;
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
            this.txtStartDate.Location = new System.Drawing.Point(77, 42);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtStartDate.PlaceholderText = "Enter Start Date";
            this.txtStartDate.SelectedText = "";
            this.txtStartDate.Size = new System.Drawing.Size(127, 33);
            this.txtStartDate.TabIndex = 9;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderColor = System.Drawing.Color.LightGray;
            this.txtEndDate.BorderRadius = 8;
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
            this.txtEndDate.Location = new System.Drawing.Point(77, 81);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtEndDate.PlaceholderText = "Enter End Date";
            this.txtEndDate.SelectedText = "";
            this.txtEndDate.Size = new System.Drawing.Size(127, 33);
            this.txtEndDate.TabIndex = 9;
            // 
            // lblMaxUsage
            // 
            this.lblMaxUsage.AutoSize = true;
            this.lblMaxUsage.Location = new System.Drawing.Point(49, 50);
            this.lblMaxUsage.Name = "lblMaxUsage";
            this.lblMaxUsage.Size = new System.Drawing.Size(98, 15);
            this.lblMaxUsage.TabIndex = 10;
            this.lblMaxUsage.Text = "Max Usage(Total)";
            // 
            // lblMaxUsagePerCustomer
            // 
            this.lblMaxUsagePerCustomer.Location = new System.Drawing.Point(4, 91);
            this.lblMaxUsagePerCustomer.Name = "lblMaxUsagePerCustomer";
            this.lblMaxUsagePerCustomer.Size = new System.Drawing.Size(143, 15);
            this.lblMaxUsagePerCustomer.TabIndex = 11;
            this.lblMaxUsagePerCustomer.Text = "Max Usage Per Customer";
            // 
            // txtMaxUsage
            // 
            this.txtMaxUsage.BorderColor = System.Drawing.Color.LightGray;
            this.txtMaxUsage.BorderRadius = 8;
            this.txtMaxUsage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaxUsage.DefaultText = "";
            this.txtMaxUsage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaxUsage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaxUsage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaxUsage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaxUsage.FillColor = System.Drawing.SystemColors.Control;
            this.txtMaxUsage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaxUsage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaxUsage.ForeColor = System.Drawing.Color.Black;
            this.txtMaxUsage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaxUsage.Location = new System.Drawing.Point(153, 35);
            this.txtMaxUsage.Name = "txtMaxUsage";
            this.txtMaxUsage.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMaxUsage.PlaceholderText = "";
            this.txtMaxUsage.SelectedText = "";
            this.txtMaxUsage.Size = new System.Drawing.Size(134, 33);
            this.txtMaxUsage.TabIndex = 12;
            // 
            // txtMaxUsagePerCustomer
            // 
            this.txtMaxUsagePerCustomer.BorderColor = System.Drawing.Color.LightGray;
            this.txtMaxUsagePerCustomer.BorderRadius = 8;
            this.txtMaxUsagePerCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaxUsagePerCustomer.DefaultText = "";
            this.txtMaxUsagePerCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaxUsagePerCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaxUsagePerCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaxUsagePerCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaxUsagePerCustomer.FillColor = System.Drawing.SystemColors.Control;
            this.txtMaxUsagePerCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaxUsagePerCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaxUsagePerCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtMaxUsagePerCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaxUsagePerCustomer.Location = new System.Drawing.Point(153, 74);
            this.txtMaxUsagePerCustomer.Name = "txtMaxUsagePerCustomer";
            this.txtMaxUsagePerCustomer.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMaxUsagePerCustomer.PlaceholderText = "";
            this.txtMaxUsagePerCustomer.SelectedText = "";
            this.txtMaxUsagePerCustomer.Size = new System.Drawing.Size(134, 33);
            this.txtMaxUsagePerCustomer.TabIndex = 13;
            // 
            // gbConditions
            // 
            this.gbConditions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbConditions.Controls.Add(this.lblRequiredPoints);
            this.gbConditions.Controls.Add(this.lblMinimumPurchaseAmoun);
            this.gbConditions.Controls.Add(this.txtRequiredPoints);
            this.gbConditions.Controls.Add(this.txtMinimumPurchaseAmoun);
            this.gbConditions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConditions.Location = new System.Drawing.Point(318, 277);
            this.gbConditions.Name = "gbConditions";
            this.gbConditions.Size = new System.Drawing.Size(426, 163);
            this.gbConditions.TabIndex = 34;
            this.gbConditions.TabStop = false;
            this.gbConditions.Text = "Conditions";
            // 
            // lblMinimumPurchaseAmoun
            // 
            this.lblMinimumPurchaseAmoun.AutoSize = true;
            this.lblMinimumPurchaseAmoun.Location = new System.Drawing.Point(21, 53);
            this.lblMinimumPurchaseAmoun.Name = "lblMinimumPurchaseAmoun";
            this.lblMinimumPurchaseAmoun.Size = new System.Drawing.Size(154, 15);
            this.lblMinimumPurchaseAmoun.TabIndex = 10;
            this.lblMinimumPurchaseAmoun.Text = "Minimum Purchase Amoun";
            // 
            // txtMinimumPurchaseAmoun
            // 
            this.txtMinimumPurchaseAmoun.BorderColor = System.Drawing.Color.LightGray;
            this.txtMinimumPurchaseAmoun.BorderRadius = 8;
            this.txtMinimumPurchaseAmoun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinimumPurchaseAmoun.DefaultText = "";
            this.txtMinimumPurchaseAmoun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMinimumPurchaseAmoun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMinimumPurchaseAmoun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinimumPurchaseAmoun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinimumPurchaseAmoun.FillColor = System.Drawing.SystemColors.Control;
            this.txtMinimumPurchaseAmoun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMinimumPurchaseAmoun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMinimumPurchaseAmoun.ForeColor = System.Drawing.Color.Black;
            this.txtMinimumPurchaseAmoun.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMinimumPurchaseAmoun.Location = new System.Drawing.Point(187, 45);
            this.txtMinimumPurchaseAmoun.Name = "txtMinimumPurchaseAmoun";
            this.txtMinimumPurchaseAmoun.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMinimumPurchaseAmoun.PlaceholderText = "";
            this.txtMinimumPurchaseAmoun.SelectedText = "";
            this.txtMinimumPurchaseAmoun.Size = new System.Drawing.Size(233, 33);
            this.txtMinimumPurchaseAmoun.TabIndex = 12;
            // 
            // rbtnPercentage
            // 
            this.rbtnPercentage.AutoSize = true;
            this.rbtnPercentage.Location = new System.Drawing.Point(13, 34);
            this.rbtnPercentage.Name = "rbtnPercentage";
            this.rbtnPercentage.Size = new System.Drawing.Size(84, 19);
            this.rbtnPercentage.TabIndex = 10;
            this.rbtnPercentage.TabStop = true;
            this.rbtnPercentage.Text = "Percentage";
            this.rbtnPercentage.UseVisualStyleBackColor = true;
            // 
            // rbtnFixedAmount
            // 
            this.rbtnFixedAmount.AutoSize = true;
            this.rbtnFixedAmount.Location = new System.Drawing.Point(103, 34);
            this.rbtnFixedAmount.Name = "rbtnFixedAmount";
            this.rbtnFixedAmount.Size = new System.Drawing.Size(100, 19);
            this.rbtnFixedAmount.TabIndex = 10;
            this.rbtnFixedAmount.TabStop = true;
            this.rbtnFixedAmount.Text = "Fixed Amount";
            this.rbtnFixedAmount.UseVisualStyleBackColor = true;
            // 
            // txtUsedCount
            // 
            this.txtUsedCount.BorderColor = System.Drawing.Color.LightGray;
            this.txtUsedCount.BorderRadius = 8;
            this.txtUsedCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsedCount.DefaultText = "";
            this.txtUsedCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsedCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsedCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsedCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsedCount.FillColor = System.Drawing.SystemColors.Control;
            this.txtUsedCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsedCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsedCount.ForeColor = System.Drawing.Color.Black;
            this.txtUsedCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsedCount.Location = new System.Drawing.Point(153, 112);
            this.txtUsedCount.Name = "txtUsedCount";
            this.txtUsedCount.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtUsedCount.PlaceholderText = "";
            this.txtUsedCount.SelectedText = "";
            this.txtUsedCount.Size = new System.Drawing.Size(134, 33);
            this.txtUsedCount.TabIndex = 13;
            // 
            // lblUsedCount
            // 
            this.lblUsedCount.AutoSize = true;
            this.lblUsedCount.Location = new System.Drawing.Point(78, 123);
            this.lblUsedCount.Name = "lblUsedCount";
            this.lblUsedCount.Size = new System.Drawing.Size(69, 15);
            this.lblUsedCount.TabIndex = 11;
            this.lblUsedCount.Text = "Used Count";
            // 
            // txtRequiredPoints
            // 
            this.txtRequiredPoints.BorderColor = System.Drawing.Color.LightGray;
            this.txtRequiredPoints.BorderRadius = 8;
            this.txtRequiredPoints.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRequiredPoints.DefaultText = "";
            this.txtRequiredPoints.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRequiredPoints.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRequiredPoints.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRequiredPoints.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRequiredPoints.FillColor = System.Drawing.SystemColors.Control;
            this.txtRequiredPoints.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRequiredPoints.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRequiredPoints.ForeColor = System.Drawing.Color.Black;
            this.txtRequiredPoints.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRequiredPoints.Location = new System.Drawing.Point(187, 84);
            this.txtRequiredPoints.Name = "txtRequiredPoints";
            this.txtRequiredPoints.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtRequiredPoints.PlaceholderText = "";
            this.txtRequiredPoints.SelectedText = "";
            this.txtRequiredPoints.Size = new System.Drawing.Size(233, 33);
            this.txtRequiredPoints.TabIndex = 12;
            // 
            // lblRequiredPoints
            // 
            this.lblRequiredPoints.AutoSize = true;
            this.lblRequiredPoints.Location = new System.Drawing.Point(85, 92);
            this.lblRequiredPoints.Name = "lblRequiredPoints";
            this.lblRequiredPoints.Size = new System.Drawing.Size(90, 15);
            this.lblRequiredPoints.TabIndex = 10;
            this.lblRequiredPoints.Text = "Required Points";
            // 
            // frmAddOrEditDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 453);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddOrEditDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddOrEditDiscount";
            this.gbBasicInformation.ResumeLayout(false);
            this.gbBasicInformation.PerformLayout();
            this.gbDiscountType.ResumeLayout(false);
            this.gbDiscountType.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbUsageLimits.ResumeLayout(false);
            this.gbUsageLimits.PerformLayout();
            this.gbValidityPeriod.ResumeLayout(false);
            this.gbValidityPeriod.PerformLayout();
            this.gbConditions.ResumeLayout(false);
            this.gbConditions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPercent;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.GroupBox gbBasicInformation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCode;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private System.Windows.Forms.Label lblAmount;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnLock;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnClearData;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.GroupBox gbUsageLimits;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInsertOrUpdateDiscount;
        private System.Windows.Forms.GroupBox gbDiscountType;
        private System.Windows.Forms.CheckBox chbActive;
        private System.Windows.Forms.GroupBox gbValidityPeriod;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private Guna.UI2.WinForms.Guna2TextBox txtStartDate;
        private Guna.UI2.WinForms.Guna2TextBox txtEndDate;
        private Guna.UI2.WinForms.Guna2TextBox txtPercent;
        private System.Windows.Forms.GroupBox gbConditions;
        private System.Windows.Forms.Label lblMinimumPurchaseAmoun;
        private Guna.UI2.WinForms.Guna2TextBox txtMinimumPurchaseAmoun;
        private System.Windows.Forms.Label lblMaxUsage;
        private System.Windows.Forms.Label lblMaxUsagePerCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txtMaxUsage;
        private Guna.UI2.WinForms.Guna2TextBox txtMaxUsagePerCustomer;
        private System.Windows.Forms.RadioButton rbtnFixedAmount;
        private System.Windows.Forms.RadioButton rbtnPercentage;
        private System.Windows.Forms.Label lblUsedCount;
        private Guna.UI2.WinForms.Guna2TextBox txtUsedCount;
        private System.Windows.Forms.Label lblRequiredPoints;
        private Guna.UI2.WinForms.Guna2TextBox txtRequiredPoints;
    }
}