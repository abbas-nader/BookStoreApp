namespace BookStoreApp.UI
{
    partial class frmAddOrEditEmployee
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
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnLock = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearData = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbEmploymentInformation = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.txtSalary = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblSalary = new System.Windows.Forms.Label();
            this.cmbEmploymentType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblEmploymentType = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.txtEnterHireDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbJobTitle = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblInsertOrUpdateEmployee = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbContactInformation = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbPersonalInformation = new System.Windows.Forms.GroupBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtBirthDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.txtNationalCode = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlMain.SuspendLayout();
            this.gbEmploymentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalary)).BeginInit();
            this.gbContactInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber)).BeginInit();
            this.gbPersonalInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationalCode)).BeginInit();
            this.SuspendLayout();
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
            this.pnlMain.Controls.Add(this.gbEmploymentInformation);
            this.pnlMain.Controls.Add(this.lblInsertOrUpdateEmployee);
            this.pnlMain.Controls.Add(this.gbContactInformation);
            this.pnlMain.Controls.Add(this.gbPersonalInformation);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(673, 517);
            this.pnlMain.TabIndex = 0;
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
            this.btnExit.Location = new System.Drawing.Point(611, 5);
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
            this.btnLock.Location = new System.Drawing.Point(469, 6);
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
            this.btnBack.Location = new System.Drawing.Point(409, 6);
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
            this.btnMinimize.Location = new System.Drawing.Point(530, 6);
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
            this.btnCancel.Location = new System.Drawing.Point(563, 61);
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
            this.btnClearData.Location = new System.Drawing.Point(459, 61);
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
            this.btnSave.Location = new System.Drawing.Point(353, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // gbEmploymentInformation
            // 
            this.gbEmploymentInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbEmploymentInformation.Controls.Add(this.lblStatus);
            this.gbEmploymentInformation.Controls.Add(this.rbtnActive);
            this.gbEmploymentInformation.Controls.Add(this.rbtnInactive);
            this.gbEmploymentInformation.Controls.Add(this.txtSalary);
            this.gbEmploymentInformation.Controls.Add(this.lblSalary);
            this.gbEmploymentInformation.Controls.Add(this.cmbEmploymentType);
            this.gbEmploymentInformation.Controls.Add(this.lblEmploymentType);
            this.gbEmploymentInformation.Controls.Add(this.lblHireDate);
            this.gbEmploymentInformation.Controls.Add(this.txtEnterHireDate);
            this.gbEmploymentInformation.Controls.Add(this.cmbJobTitle);
            this.gbEmploymentInformation.Controls.Add(this.lblJobTitle);
            this.gbEmploymentInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmploymentInformation.Location = new System.Drawing.Point(8, 340);
            this.gbEmploymentInformation.Name = "gbEmploymentInformation";
            this.gbEmploymentInformation.Size = new System.Drawing.Size(649, 163);
            this.gbEmploymentInformation.TabIndex = 34;
            this.gbEmploymentInformation.TabStop = false;
            this.gbEmploymentInformation.Text = "Employment Information";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(32, 127);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Status";
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Location = new System.Drawing.Point(87, 125);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(58, 19);
            this.rbtnActive.TabIndex = 15;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Location = new System.Drawing.Point(158, 125);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(66, 19);
            this.rbtnInactive.TabIndex = 16;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.Transparent;
            this.txtSalary.BorderColor = System.Drawing.Color.LightGray;
            this.txtSalary.BorderRadius = 8;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.FillColor = System.Drawing.SystemColors.Control;
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalary.Location = new System.Drawing.Point(401, 75);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(242, 24);
            this.txtSalary.TabIndex = 14;
            this.txtSalary.UpDownButtonFillColor = System.Drawing.SystemColors.Control;
            this.txtSalary.UpDownButtonForeColor = System.Drawing.Color.DimGray;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(357, 82);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(38, 15);
            this.lblSalary.TabIndex = 21;
            this.lblSalary.Text = "Salary";
            // 
            // cmbEmploymentType
            // 
            this.cmbEmploymentType.BackColor = System.Drawing.Color.Transparent;
            this.cmbEmploymentType.BorderColor = System.Drawing.Color.LightGray;
            this.cmbEmploymentType.BorderRadius = 8;
            this.cmbEmploymentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmploymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmploymentType.FillColor = System.Drawing.SystemColors.Control;
            this.cmbEmploymentType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmploymentType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmploymentType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEmploymentType.ForeColor = System.Drawing.Color.Black;
            this.cmbEmploymentType.ItemHeight = 30;
            this.cmbEmploymentType.Location = new System.Drawing.Point(401, 22);
            this.cmbEmploymentType.Name = "cmbEmploymentType";
            this.cmbEmploymentType.Size = new System.Drawing.Size(242, 36);
            this.cmbEmploymentType.TabIndex = 13;
            // 
            // lblEmploymentType
            // 
            this.lblEmploymentType.AutoSize = true;
            this.lblEmploymentType.Location = new System.Drawing.Point(293, 33);
            this.lblEmploymentType.Name = "lblEmploymentType";
            this.lblEmploymentType.Size = new System.Drawing.Size(102, 15);
            this.lblEmploymentType.TabIndex = 19;
            this.lblEmploymentType.Text = "Employment Type";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(15, 75);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(56, 15);
            this.lblHireDate.TabIndex = 17;
            this.lblHireDate.Text = "Hire Date";
            // 
            // txtEnterHireDate
            // 
            this.txtEnterHireDate.BorderColor = System.Drawing.Color.LightGray;
            this.txtEnterHireDate.BorderRadius = 8;
            this.txtEnterHireDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnterHireDate.DefaultText = "";
            this.txtEnterHireDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEnterHireDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnterHireDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterHireDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterHireDate.FillColor = System.Drawing.SystemColors.Control;
            this.txtEnterHireDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnterHireDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEnterHireDate.ForeColor = System.Drawing.Color.Black;
            this.txtEnterHireDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnterHireDate.Location = new System.Drawing.Point(81, 75);
            this.txtEnterHireDate.Name = "txtEnterHireDate";
            this.txtEnterHireDate.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtEnterHireDate.PlaceholderText = "Enter Hire Date";
            this.txtEnterHireDate.SelectedText = "";
            this.txtEnterHireDate.Size = new System.Drawing.Size(206, 22);
            this.txtEnterHireDate.TabIndex = 12;
            // 
            // cmbJobTitle
            // 
            this.cmbJobTitle.BackColor = System.Drawing.Color.Transparent;
            this.cmbJobTitle.BorderColor = System.Drawing.Color.LightGray;
            this.cmbJobTitle.BorderRadius = 8;
            this.cmbJobTitle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbJobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobTitle.FillColor = System.Drawing.SystemColors.Control;
            this.cmbJobTitle.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbJobTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbJobTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbJobTitle.ForeColor = System.Drawing.Color.Black;
            this.cmbJobTitle.ItemHeight = 30;
            this.cmbJobTitle.Location = new System.Drawing.Point(81, 22);
            this.cmbJobTitle.Name = "cmbJobTitle";
            this.cmbJobTitle.Size = new System.Drawing.Size(206, 36);
            this.cmbJobTitle.TabIndex = 11;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(21, 33);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(50, 15);
            this.lblJobTitle.TabIndex = 15;
            this.lblJobTitle.Text = "Job Title";
            // 
            // lblInsertOrUpdateEmployee
            // 
            this.lblInsertOrUpdateEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInsertOrUpdateEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblInsertOrUpdateEmployee.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblInsertOrUpdateEmployee.Location = new System.Drawing.Point(26, 68);
            this.lblInsertOrUpdateEmployee.Name = "lblInsertOrUpdateEmployee";
            this.lblInsertOrUpdateEmployee.Size = new System.Drawing.Size(262, 33);
            this.lblInsertOrUpdateEmployee.TabIndex = 32;
            this.lblInsertOrUpdateEmployee.Text = "Employee Insert/Update";
            // 
            // gbContactInformation
            // 
            this.gbContactInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbContactInformation.Controls.Add(this.txtPhoneNumber);
            this.gbContactInformation.Controls.Add(this.lblPhoneNumber);
            this.gbContactInformation.Controls.Add(this.lblAddress);
            this.gbContactInformation.Controls.Add(this.txtAddress);
            this.gbContactInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContactInformation.Location = new System.Drawing.Point(334, 103);
            this.gbContactInformation.Name = "gbContactInformation";
            this.gbContactInformation.Size = new System.Drawing.Size(323, 231);
            this.gbContactInformation.TabIndex = 33;
            this.gbContactInformation.TabStop = false;
            this.gbContactInformation.Text = "Contact Information";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.LightGray;
            this.txtPhoneNumber.BorderRadius = 8;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.FillColor = System.Drawing.SystemColors.Control;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(110, 31);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(130, 24);
            this.txtPhoneNumber.TabIndex = 8;
            this.txtPhoneNumber.UpDownButtonFillColor = System.Drawing.SystemColors.Control;
            this.txtPhoneNumber.UpDownButtonForeColor = System.Drawing.Color.DimGray;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(16, 38);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(88, 15);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(43, 76);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.LightGray;
            this.txtAddress.BorderRadius = 8;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FillColor = System.Drawing.SystemColors.Control;
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(110, 69);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtAddress.PlaceholderText = "Enter Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(177, 147);
            this.txtAddress.TabIndex = 9;
            // 
            // gbPersonalInformation
            // 
            this.gbPersonalInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbPersonalInformation.Controls.Add(this.lblBirthDate);
            this.gbPersonalInformation.Controls.Add(this.txtBirthDate);
            this.gbPersonalInformation.Controls.Add(this.rbtnMale);
            this.gbPersonalInformation.Controls.Add(this.rbtnFemale);
            this.gbPersonalInformation.Controls.Add(this.txtNationalCode);
            this.gbPersonalInformation.Controls.Add(this.lblLastName);
            this.gbPersonalInformation.Controls.Add(this.lblNationalCode);
            this.gbPersonalInformation.Controls.Add(this.lblFirstName);
            this.gbPersonalInformation.Controls.Add(this.txtLastName);
            this.gbPersonalInformation.Controls.Add(this.txtFirstName);
            this.gbPersonalInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonalInformation.Location = new System.Drawing.Point(8, 103);
            this.gbPersonalInformation.Name = "gbPersonalInformation";
            this.gbPersonalInformation.Size = new System.Drawing.Size(304, 231);
            this.gbPersonalInformation.TabIndex = 31;
            this.gbPersonalInformation.TabStop = false;
            this.gbPersonalInformation.Text = "Identification";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(35, 151);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(59, 15);
            this.lblBirthDate.TabIndex = 12;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.BorderColor = System.Drawing.Color.LightGray;
            this.txtBirthDate.BorderRadius = 8;
            this.txtBirthDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBirthDate.DefaultText = "";
            this.txtBirthDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBirthDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBirthDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBirthDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBirthDate.FillColor = System.Drawing.SystemColors.Control;
            this.txtBirthDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBirthDate.ForeColor = System.Drawing.Color.Black;
            this.txtBirthDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBirthDate.Location = new System.Drawing.Point(101, 151);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtBirthDate.PlaceholderText = "Enter Birth Date";
            this.txtBirthDate.SelectedText = "";
            this.txtBirthDate.Size = new System.Drawing.Size(186, 22);
            this.txtBirthDate.TabIndex = 4;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(98, 197);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(51, 19);
            this.rbtnMale.TabIndex = 5;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(169, 197);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(63, 19);
            this.rbtnFemale.TabIndex = 6;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.BackColor = System.Drawing.Color.Transparent;
            this.txtNationalCode.BorderColor = System.Drawing.Color.LightGray;
            this.txtNationalCode.BorderRadius = 8;
            this.txtNationalCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalCode.FillColor = System.Drawing.SystemColors.Control;
            this.txtNationalCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNationalCode.Location = new System.Drawing.Point(102, 105);
            this.txtNationalCode.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(119, 24);
            this.txtNationalCode.TabIndex = 3;
            this.txtNationalCode.UpDownButtonFillColor = System.Drawing.SystemColors.Control;
            this.txtNationalCode.UpDownButtonForeColor = System.Drawing.Color.DimGray;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(36, 69);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(60, 15);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "LastName";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Location = new System.Drawing.Point(16, 114);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(80, 15);
            this.lblNationalCode.TabIndex = 1;
            this.lblNationalCode.Text = "NationalCode";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(35, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(61, 15);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "FirstName";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderColor = System.Drawing.Color.LightGray;
            this.txtLastName.BorderRadius = 8;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FillColor = System.Drawing.SystemColors.Control;
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(102, 69);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtLastName.PlaceholderText = "Enter LastName";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(185, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderColor = System.Drawing.Color.LightGray;
            this.txtFirstName.BorderRadius = 8;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FillColor = System.Drawing.SystemColors.Control;
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(102, 31);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtFirstName.PlaceholderText = "Enter FirstName";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(185, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // borderlessForm
            // 
            this.borderlessForm.BorderRadius = 30;
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // frmAddOrEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(673, 517);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAddOrEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddOrEditEmployee";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbEmploymentInformation.ResumeLayout(false);
            this.gbEmploymentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalary)).EndInit();
            this.gbContactInformation.ResumeLayout(false);
            this.gbContactInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber)).EndInit();
            this.gbPersonalInformation.ResumeLayout(false);
            this.gbPersonalInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationalCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnLock;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnClearData;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.GroupBox gbEmploymentInformation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEmploymentType;
        private System.Windows.Forms.Label lblEmploymentType;
        private System.Windows.Forms.Label lblHireDate;
        private Guna.UI2.WinForms.Guna2TextBox txtEnterHireDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbJobTitle;
        private System.Windows.Forms.Label lblJobTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInsertOrUpdateEmployee;
        private System.Windows.Forms.GroupBox gbContactInformation;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.GroupBox gbPersonalInformation;
        private System.Windows.Forms.Label lblBirthDate;
        private Guna.UI2.WinForms.Guna2TextBox txtBirthDate;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtNationalCode;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
    }
}