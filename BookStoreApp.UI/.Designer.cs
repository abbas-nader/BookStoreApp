namespace BookStoreApp.UI
{
    partial class frmAddOrEditBook
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.cmbCoverType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbGenre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPageCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblCoverType = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.txtSummary = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLanguage = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.gbInvertory = new System.Windows.Forms.GroupBox();
            this.cmbStockStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtStockQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearData = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnLock = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.gbIdentification = new System.Windows.Forms.GroupBox();
            this.lblIsbn13 = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblIsbn10 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtIsbn13 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIsbn10 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSubtitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddOrEditTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbPublishing = new System.Windows.Forms.GroupBox();
            this.txtEditionNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblEditionNumber = new System.Windows.Forms.Label();
            this.txtPublicationYear = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblPublicationYear = new System.Windows.Forms.Label();
            this.lblTranslator = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtPublisher = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTranslator = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlMain.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageCount)).BeginInit();
            this.gbInvertory.SuspendLayout();
            this.gbIdentification.SuspendLayout();
            this.gbPublishing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditionNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPublicationYear)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbDetails);
            this.pnlMain.Controls.Add(this.btnMinimize);
            this.pnlMain.Controls.Add(this.gbInvertory);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnClearData);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnLock);
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.gbIdentification);
            this.pnlMain.Controls.Add(this.lblAddOrEditTitle);
            this.pnlMain.Controls.Add(this.gbPublishing);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(787, 580);
            this.pnlMain.TabIndex = 0;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.cmbCoverType);
            this.gbDetails.Controls.Add(this.cmbGenre);
            this.gbDetails.Controls.Add(this.txtPageCount);
            this.gbDetails.Controls.Add(this.lblPageCount);
            this.gbDetails.Controls.Add(this.lblCoverType);
            this.gbDetails.Controls.Add(this.lblSummary);
            this.gbDetails.Controls.Add(this.lblGenre);
            this.gbDetails.Controls.Add(this.lblLanguage);
            this.gbDetails.Controls.Add(this.txtSummary);
            this.gbDetails.Controls.Add(this.txtLanguage);
            this.gbDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(385, 108);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(369, 298);
            this.gbDetails.TabIndex = 31;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // cmbCoverType
            // 
            this.cmbCoverType.BackColor = System.Drawing.Color.Transparent;
            this.cmbCoverType.BorderColor = System.Drawing.Color.LightGray;
            this.cmbCoverType.BorderRadius = 8;
            this.cmbCoverType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCoverType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoverType.FillColor = System.Drawing.SystemColors.Control;
            this.cmbCoverType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCoverType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCoverType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCoverType.ForeColor = System.Drawing.Color.Black;
            this.cmbCoverType.ItemHeight = 30;
            this.cmbCoverType.Location = new System.Drawing.Point(104, 212);
            this.cmbCoverType.Name = "cmbCoverType";
            this.cmbCoverType.Size = new System.Drawing.Size(242, 36);
            this.cmbCoverType.TabIndex = 15;
            // 
            // cmbGenre
            // 
            this.cmbGenre.BackColor = System.Drawing.Color.Transparent;
            this.cmbGenre.BorderColor = System.Drawing.Color.LightGray;
            this.cmbGenre.BorderRadius = 8;
            this.cmbGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FillColor = System.Drawing.SystemColors.Control;
            this.cmbGenre.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGenre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGenre.ForeColor = System.Drawing.Color.Black;
            this.cmbGenre.ItemHeight = 30;
            this.cmbGenre.Location = new System.Drawing.Point(104, 173);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(242, 36);
            this.cmbGenre.TabIndex = 14;
            // 
            // txtPageCount
            // 
            this.txtPageCount.BackColor = System.Drawing.Color.Transparent;
            this.txtPageCount.BorderColor = System.Drawing.Color.LightGray;
            this.txtPageCount.BorderRadius = 8;
            this.txtPageCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPageCount.FillColor = System.Drawing.SystemColors.Control;
            this.txtPageCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPageCount.Location = new System.Drawing.Point(104, 254);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(100, 24);
            this.txtPageCount.TabIndex = 16;
            this.txtPageCount.UpDownButtonFillColor = System.Drawing.SystemColors.Control;
            this.txtPageCount.UpDownButtonForeColor = System.Drawing.Color.DimGray;
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(29, 256);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(69, 15);
            this.lblPageCount.TabIndex = 1;
            this.lblPageCount.Text = "Page Count";
            // 
            // lblCoverType
            // 
            this.lblCoverType.AutoSize = true;
            this.lblCoverType.Location = new System.Drawing.Point(33, 221);
            this.lblCoverType.Name = "lblCoverType";
            this.lblCoverType.Size = new System.Drawing.Size(65, 15);
            this.lblCoverType.TabIndex = 1;
            this.lblCoverType.Text = "Cover Type";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(40, 59);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(58, 15);
            this.lblSummary.TabIndex = 1;
            this.lblSummary.Text = "Summary";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(60, 184);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(38, 15);
            this.lblGenre.TabIndex = 1;
            this.lblGenre.Text = "Genre";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(39, 31);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(59, 15);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Text = "Language";
            // 
            // txtSummary
            // 
            this.txtSummary.BorderColor = System.Drawing.Color.LightGray;
            this.txtSummary.BorderRadius = 8;
            this.txtSummary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSummary.DefaultText = "";
            this.txtSummary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSummary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSummary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSummary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSummary.FillColor = System.Drawing.SystemColors.Control;
            this.txtSummary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSummary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSummary.ForeColor = System.Drawing.Color.Black;
            this.txtSummary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSummary.Location = new System.Drawing.Point(104, 59);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSummary.PlaceholderText = "Enter Summary";
            this.txtSummary.SelectedText = "";
            this.txtSummary.Size = new System.Drawing.Size(242, 108);
            this.txtSummary.TabIndex = 13;
            // 
            // txtLanguage
            // 
            this.txtLanguage.BorderColor = System.Drawing.Color.LightGray;
            this.txtLanguage.BorderRadius = 8;
            this.txtLanguage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLanguage.DefaultText = "";
            this.txtLanguage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLanguage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLanguage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLanguage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLanguage.FillColor = System.Drawing.SystemColors.Control;
            this.txtLanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLanguage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLanguage.ForeColor = System.Drawing.Color.Black;
            this.txtLanguage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLanguage.Location = new System.Drawing.Point(104, 31);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtLanguage.PlaceholderText = "Enter Language";
            this.txtLanguage.SelectedText = "";
            this.txtLanguage.Size = new System.Drawing.Size(242, 22);
            this.txtLanguage.TabIndex = 12;
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
            this.btnMinimize.Location = new System.Drawing.Point(640, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(77, 29);
            this.btnMinimize.TabIndex = 38;
            this.btnMinimize.Text = "Minimize";
            // 
            // gbInvertory
            // 
            this.gbInvertory.Controls.Add(this.cmbStockStatus);
            this.gbInvertory.Controls.Add(this.lblStockQuantity);
            this.gbInvertory.Controls.Add(this.lblStockStatus);
            this.gbInvertory.Controls.Add(this.lblPrice);
            this.gbInvertory.Controls.Add(this.txtStockQuantity);
            this.gbInvertory.Controls.Add(this.txtPrice);
            this.gbInvertory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInvertory.Location = new System.Drawing.Point(385, 412);
            this.gbInvertory.Name = "gbInvertory";
            this.gbInvertory.Size = new System.Drawing.Size(369, 155);
            this.gbInvertory.TabIndex = 32;
            this.gbInvertory.TabStop = false;
            this.gbInvertory.Text = "Invertory";
            // 
            // cmbStockStatus
            // 
            this.cmbStockStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStockStatus.BorderColor = System.Drawing.Color.LightGray;
            this.cmbStockStatus.BorderRadius = 8;
            this.cmbStockStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStockStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStockStatus.FillColor = System.Drawing.SystemColors.Control;
            this.cmbStockStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStockStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStockStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStockStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbStockStatus.ItemHeight = 30;
            this.cmbStockStatus.Location = new System.Drawing.Point(104, 99);
            this.cmbStockStatus.Name = "cmbStockStatus";
            this.cmbStockStatus.Size = new System.Drawing.Size(242, 36);
            this.cmbStockStatus.TabIndex = 20;
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(13, 71);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(85, 15);
            this.lblStockQuantity.TabIndex = 1;
            this.lblStockQuantity.Text = "Stock Quantity";
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.Location = new System.Drawing.Point(20, 110);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(71, 15);
            this.lblStockStatus.TabIndex = 1;
            this.lblStockStatus.Text = "Stock Status";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(58, 38);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.BorderColor = System.Drawing.Color.LightGray;
            this.txtStockQuantity.BorderRadius = 8;
            this.txtStockQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockQuantity.DefaultText = "";
            this.txtStockQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStockQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStockQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStockQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStockQuantity.FillColor = System.Drawing.SystemColors.Control;
            this.txtStockQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStockQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStockQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtStockQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStockQuantity.Location = new System.Drawing.Point(104, 64);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtStockQuantity.PlaceholderText = "Enter Stock Quantity";
            this.txtStockQuantity.SelectedText = "";
            this.txtStockQuantity.Size = new System.Drawing.Size(242, 22);
            this.txtStockQuantity.TabIndex = 19;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColor = System.Drawing.Color.LightGray;
            this.txtPrice.BorderRadius = 8;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FillColor = System.Drawing.SystemColors.Control;
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(104, 31);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPrice.PlaceholderText = "Enter Price";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(242, 22);
            this.txtPrice.TabIndex = 18;
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
            this.btnCancel.Location = new System.Drawing.Point(649, 66);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 36);
            this.btnCancel.TabIndex = 35;
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
            this.btnClearData.Location = new System.Drawing.Point(545, 66);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(100, 36);
            this.btnClearData.TabIndex = 34;
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
            this.btnSave.Location = new System.Drawing.Point(439, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
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
            this.btnLock.Location = new System.Drawing.Point(579, 4);
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
            this.btnBack.Location = new System.Drawing.Point(519, 4);
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
            this.btnExit.Location = new System.Drawing.Point(721, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 29);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "Exit";
            // 
            // gbIdentification
            // 
            this.gbIdentification.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbIdentification.Controls.Add(this.lblIsbn13);
            this.gbIdentification.Controls.Add(this.lblSubtitle);
            this.gbIdentification.Controls.Add(this.lblIsbn10);
            this.gbIdentification.Controls.Add(this.lblTitle);
            this.gbIdentification.Controls.Add(this.txtIsbn13);
            this.gbIdentification.Controls.Add(this.txtIsbn10);
            this.gbIdentification.Controls.Add(this.txtSubtitle);
            this.gbIdentification.Controls.Add(this.txtTitle);
            this.gbIdentification.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentification.Location = new System.Drawing.Point(16, 108);
            this.gbIdentification.Name = "gbIdentification";
            this.gbIdentification.Size = new System.Drawing.Size(363, 199);
            this.gbIdentification.TabIndex = 28;
            this.gbIdentification.TabStop = false;
            this.gbIdentification.Text = "Identification";
            // 
            // lblIsbn13
            // 
            this.lblIsbn13.AutoSize = true;
            this.lblIsbn13.Location = new System.Drawing.Point(23, 152);
            this.lblIsbn13.Name = "lblIsbn13";
            this.lblIsbn13.Size = new System.Drawing.Size(49, 15);
            this.lblIsbn13.TabIndex = 1;
            this.lblIsbn13.Text = "ISBN-13";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(25, 69);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(47, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Subtitle";
            // 
            // lblIsbn10
            // 
            this.lblIsbn10.AutoSize = true;
            this.lblIsbn10.Location = new System.Drawing.Point(23, 114);
            this.lblIsbn10.Name = "lblIsbn10";
            this.lblIsbn10.Size = new System.Drawing.Size(49, 15);
            this.lblIsbn10.TabIndex = 1;
            this.lblIsbn10.Text = "ISBN-10";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(43, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(29, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // txtIsbn13
            // 
            this.txtIsbn13.BorderColor = System.Drawing.Color.LightGray;
            this.txtIsbn13.BorderRadius = 8;
            this.txtIsbn13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIsbn13.DefaultText = "";
            this.txtIsbn13.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIsbn13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIsbn13.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIsbn13.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIsbn13.FillColor = System.Drawing.SystemColors.Control;
            this.txtIsbn13.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIsbn13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIsbn13.ForeColor = System.Drawing.Color.Black;
            this.txtIsbn13.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIsbn13.Location = new System.Drawing.Point(77, 145);
            this.txtIsbn13.Name = "txtIsbn13";
            this.txtIsbn13.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtIsbn13.PlaceholderText = "Enter ISBN-13";
            this.txtIsbn13.SelectedText = "";
            this.txtIsbn13.Size = new System.Drawing.Size(242, 22);
            this.txtIsbn13.TabIndex = 4;
            // 
            // txtIsbn10
            // 
            this.txtIsbn10.BorderColor = System.Drawing.Color.LightGray;
            this.txtIsbn10.BorderRadius = 8;
            this.txtIsbn10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIsbn10.DefaultText = "";
            this.txtIsbn10.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIsbn10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIsbn10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIsbn10.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIsbn10.FillColor = System.Drawing.SystemColors.Control;
            this.txtIsbn10.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIsbn10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIsbn10.ForeColor = System.Drawing.Color.Black;
            this.txtIsbn10.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIsbn10.Location = new System.Drawing.Point(77, 107);
            this.txtIsbn10.Name = "txtIsbn10";
            this.txtIsbn10.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtIsbn10.PlaceholderText = "Enter ISBN-10";
            this.txtIsbn10.SelectedText = "";
            this.txtIsbn10.Size = new System.Drawing.Size(242, 22);
            this.txtIsbn10.TabIndex = 3;
            // 
            // txtSubtitle
            // 
            this.txtSubtitle.BorderColor = System.Drawing.Color.LightGray;
            this.txtSubtitle.BorderRadius = 8;
            this.txtSubtitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubtitle.DefaultText = "";
            this.txtSubtitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSubtitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSubtitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubtitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubtitle.FillColor = System.Drawing.SystemColors.Control;
            this.txtSubtitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSubtitle.ForeColor = System.Drawing.Color.Black;
            this.txtSubtitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubtitle.Location = new System.Drawing.Point(77, 69);
            this.txtSubtitle.Name = "txtSubtitle";
            this.txtSubtitle.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSubtitle.PlaceholderText = "Enter Subtitle";
            this.txtSubtitle.SelectedText = "";
            this.txtSubtitle.Size = new System.Drawing.Size(242, 22);
            this.txtSubtitle.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderColor = System.Drawing.Color.LightGray;
            this.txtTitle.BorderRadius = 8;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FillColor = System.Drawing.SystemColors.Control;
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Location = new System.Drawing.Point(77, 31);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTitle.PlaceholderText = "Enter Title";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(242, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // lblAddOrEditTitle
            // 
            this.lblAddOrEditTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddOrEditTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAddOrEditTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOrEditTitle.Location = new System.Drawing.Point(25, 69);
            this.lblAddOrEditTitle.Name = "lblAddOrEditTitle";
            this.lblAddOrEditTitle.Size = new System.Drawing.Size(214, 33);
            this.lblAddOrEditTitle.TabIndex = 29;
            this.lblAddOrEditTitle.Text = "Book Insert/Update";
            // 
            // gbPublishing
            // 
            this.gbPublishing.Controls.Add(this.txtEditionNumber);
            this.gbPublishing.Controls.Add(this.lblEditionNumber);
            this.gbPublishing.Controls.Add(this.txtPublicationYear);
            this.gbPublishing.Controls.Add(this.lblPublicationYear);
            this.gbPublishing.Controls.Add(this.lblTranslator);
            this.gbPublishing.Controls.Add(this.lblPublisher);
            this.gbPublishing.Controls.Add(this.lblAuthor);
            this.gbPublishing.Controls.Add(this.txtPublisher);
            this.gbPublishing.Controls.Add(this.txtTranslator);
            this.gbPublishing.Controls.Add(this.txtAuthor);
            this.gbPublishing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPublishing.Location = new System.Drawing.Point(16, 313);
            this.gbPublishing.Name = "gbPublishing";
            this.gbPublishing.Size = new System.Drawing.Size(363, 254);
            this.gbPublishing.TabIndex = 30;
            this.gbPublishing.TabStop = false;
            this.gbPublishing.Text = "Publishing";
            // 
            // txtEditionNumber
            // 
            this.txtEditionNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtEditionNumber.BorderColor = System.Drawing.Color.LightGray;
            this.txtEditionNumber.BorderRadius = 8;
            this.txtEditionNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditionNumber.FillColor = System.Drawing.SystemColors.Control;
            this.txtEditionNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEditionNumber.Location = new System.Drawing.Point(104, 193);
            this.txtEditionNumber.Name = "txtEditionNumber";
            this.txtEditionNumber.Size = new System.Drawing.Size(100, 24);
            this.txtEditionNumber.TabIndex = 10;
            this.txtEditionNumber.UpDownButtonFillColor = System.Drawing.SystemColors.Control;
            // 
            // lblEditionNumber
            // 
            this.lblEditionNumber.AutoSize = true;
            this.lblEditionNumber.Location = new System.Drawing.Point(6, 195);
            this.lblEditionNumber.Name = "lblEditionNumber";
            this.lblEditionNumber.Size = new System.Drawing.Size(91, 15);
            this.lblEditionNumber.TabIndex = 1;
            this.lblEditionNumber.Text = "Edition Number";
            // 
            // txtPublicationYear
            // 
            this.txtPublicationYear.BackColor = System.Drawing.Color.Transparent;
            this.txtPublicationYear.BorderColor = System.Drawing.Color.LightGray;
            this.txtPublicationYear.BorderRadius = 8;
            this.txtPublicationYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublicationYear.FillColor = System.Drawing.SystemColors.Control;
            this.txtPublicationYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPublicationYear.Location = new System.Drawing.Point(104, 154);
            this.txtPublicationYear.Name = "txtPublicationYear";
            this.txtPublicationYear.Size = new System.Drawing.Size(100, 24);
            this.txtPublicationYear.TabIndex = 9;
            this.txtPublicationYear.UpDownButtonFillColor = System.Drawing.SystemColors.Control;
            // 
            // lblPublicationYear
            // 
            this.lblPublicationYear.AutoSize = true;
            this.lblPublicationYear.Location = new System.Drawing.Point(6, 156);
            this.lblPublicationYear.Name = "lblPublicationYear";
            this.lblPublicationYear.Size = new System.Drawing.Size(92, 15);
            this.lblPublicationYear.TabIndex = 1;
            this.lblPublicationYear.Text = "Publication Year";
            // 
            // lblTranslator
            // 
            this.lblTranslator.AutoSize = true;
            this.lblTranslator.Location = new System.Drawing.Point(40, 71);
            this.lblTranslator.Name = "lblTranslator";
            this.lblTranslator.Size = new System.Drawing.Size(58, 15);
            this.lblTranslator.TabIndex = 1;
            this.lblTranslator.Text = "Translator";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(42, 116);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(56, 15);
            this.lblPublisher.TabIndex = 1;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(54, 31);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(44, 15);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // txtPublisher
            // 
            this.txtPublisher.BorderColor = System.Drawing.Color.LightGray;
            this.txtPublisher.BorderRadius = 8;
            this.txtPublisher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublisher.DefaultText = "";
            this.txtPublisher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPublisher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPublisher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPublisher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPublisher.FillColor = System.Drawing.SystemColors.Control;
            this.txtPublisher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPublisher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPublisher.ForeColor = System.Drawing.Color.Black;
            this.txtPublisher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPublisher.Location = new System.Drawing.Point(104, 116);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPublisher.PlaceholderText = "Enter Publisher";
            this.txtPublisher.SelectedText = "";
            this.txtPublisher.Size = new System.Drawing.Size(242, 22);
            this.txtPublisher.TabIndex = 8;
            // 
            // txtTranslator
            // 
            this.txtTranslator.BorderColor = System.Drawing.Color.LightGray;
            this.txtTranslator.BorderRadius = 8;
            this.txtTranslator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTranslator.DefaultText = "";
            this.txtTranslator.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTranslator.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTranslator.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTranslator.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTranslator.FillColor = System.Drawing.SystemColors.Control;
            this.txtTranslator.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTranslator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTranslator.ForeColor = System.Drawing.Color.Black;
            this.txtTranslator.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTranslator.Location = new System.Drawing.Point(104, 71);
            this.txtTranslator.Name = "txtTranslator";
            this.txtTranslator.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTranslator.PlaceholderText = "Enter Translator";
            this.txtTranslator.SelectedText = "";
            this.txtTranslator.Size = new System.Drawing.Size(242, 22);
            this.txtTranslator.TabIndex = 7;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderColor = System.Drawing.Color.LightGray;
            this.txtAuthor.BorderRadius = 8;
            this.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthor.DefaultText = "";
            this.txtAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthor.FillColor = System.Drawing.SystemColors.Control;
            this.txtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAuthor.ForeColor = System.Drawing.Color.Black;
            this.txtAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthor.Location = new System.Drawing.Point(104, 31);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtAuthor.PlaceholderText = "Enter Author";
            this.txtAuthor.SelectedText = "";
            this.txtAuthor.Size = new System.Drawing.Size(242, 22);
            this.txtAuthor.TabIndex = 6;
            // 
            // borderlessForm
            // 
            this.borderlessForm.BorderRadius = 30;
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // frmAddOrEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(787, 580);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddOrEditBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddOrEditBook";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageCount)).EndInit();
            this.gbInvertory.ResumeLayout(false);
            this.gbInvertory.PerformLayout();
            this.gbIdentification.ResumeLayout(false);
            this.gbIdentification.PerformLayout();
            this.gbPublishing.ResumeLayout(false);
            this.gbPublishing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditionNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPublicationYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbDetails;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCoverType;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGenre;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtPageCount;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblCoverType;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblLanguage;
        private Guna.UI2.WinForms.Guna2TextBox txtSummary;
        private Guna.UI2.WinForms.Guna2TextBox txtLanguage;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private System.Windows.Forms.GroupBox gbInvertory;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStockStatus;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtStockQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnClearData;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnLock;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.GroupBox gbIdentification;
        private System.Windows.Forms.Label lblIsbn13;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblIsbn10;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtIsbn13;
        private Guna.UI2.WinForms.Guna2TextBox txtIsbn10;
        private Guna.UI2.WinForms.Guna2TextBox txtSubtitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddOrEditTitle;
        private System.Windows.Forms.GroupBox gbPublishing;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtEditionNumber;
        private System.Windows.Forms.Label lblEditionNumber;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtPublicationYear;
        private System.Windows.Forms.Label lblPublicationYear;
        private System.Windows.Forms.Label lblTranslator;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblAuthor;
        private Guna.UI2.WinForms.Guna2TextBox txtPublisher;
        private Guna.UI2.WinForms.Guna2TextBox txtTranslator;
        private Guna.UI2.WinForms.Guna2TextBox txtAuthor;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
    }
}