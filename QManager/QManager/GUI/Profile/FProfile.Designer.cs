namespace QManager.GUI.Profile
{
    partial class FProfile
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
            this.TableLayoutParent = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelPhoneNo = new System.Windows.Forms.Label();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.LabelDoB = new System.Windows.Forms.Label();
            this.TextBoxFullName = new System.Windows.Forms.TextBox();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.TextBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.LabelFullName = new System.Windows.Forms.Label();
            this.PanelTableDoBAndGender = new System.Windows.Forms.TableLayoutPanel();
            this.LabelGender = new System.Windows.Forms.Label();
            this.TextBoxDoBDay = new System.Windows.Forms.TextBox();
            this.TextBoxDoBMonth = new System.Windows.Forms.TextBox();
            this.TextBoxDoBYear = new System.Windows.Forms.TextBox();
            this.ComboBoxGender = new System.Windows.Forms.ComboBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.PanelTableBottomHalf = new System.Windows.Forms.TableLayoutPanel();
            this.LabelDepartment = new System.Windows.Forms.Label();
            this.LabelJobTitle = new System.Windows.Forms.Label();
            this.TextBoxJobTitle = new System.Windows.Forms.TextBox();
            this.LabelRole = new System.Windows.Forms.Label();
            this.LabelStaffCode = new System.Windows.Forms.Label();
            this.TextBoxStaffCode = new System.Windows.Forms.TextBox();
            this.LabelContractCode = new System.Windows.Forms.Label();
            this.TextBoxContractCode = new System.Windows.Forms.TextBox();
            this.LabelStartDate = new System.Windows.Forms.Label();
            this.TextBoxStartDate = new System.Windows.Forms.TextBox();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ComboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.ComboBoxRole = new System.Windows.Forms.ComboBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TableLayoutParent.SuspendLayout();
            this.TableLayoutPanelInfo.SuspendLayout();
            this.PanelTableDoBAndGender.SuspendLayout();
            this.PanelTableBottomHalf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutParent
            // 
            this.TableLayoutParent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableLayoutParent.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableLayoutParent.ColumnCount = 2;
            this.TableLayoutParent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutParent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.TableLayoutParent.Controls.Add(this.TableLayoutPanelInfo, 0, 0);
            this.TableLayoutParent.Controls.Add(this.PanelTableBottomHalf, 0, 1);
            this.TableLayoutParent.Controls.Add(this.pictureBox1, 1, 0);
            this.TableLayoutParent.Location = new System.Drawing.Point(15, 15);
            this.TableLayoutParent.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutParent.Name = "TableLayoutParent";
            this.TableLayoutParent.RowCount = 2;
            this.TableLayoutParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.TableLayoutParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutParent.Size = new System.Drawing.Size(570, 330);
            this.TableLayoutParent.TabIndex = 0;
            // 
            // TableLayoutPanelInfo
            // 
            this.TableLayoutPanelInfo.ColumnCount = 2;
            this.TableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelInfo.Controls.Add(this.LabelEmail, 0, 4);
            this.TableLayoutPanelInfo.Controls.Add(this.LabelPhoneNo, 0, 3);
            this.TableLayoutPanelInfo.Controls.Add(this.LabelAddress, 0, 2);
            this.TableLayoutPanelInfo.Controls.Add(this.LabelDoB, 0, 1);
            this.TableLayoutPanelInfo.Controls.Add(this.TextBoxFullName, 1, 0);
            this.TableLayoutPanelInfo.Controls.Add(this.TextBoxAddress, 1, 2);
            this.TableLayoutPanelInfo.Controls.Add(this.TextBoxPhoneNo, 1, 3);
            this.TableLayoutPanelInfo.Controls.Add(this.LabelFullName, 0, 0);
            this.TableLayoutPanelInfo.Controls.Add(this.PanelTableDoBAndGender, 1, 1);
            this.TableLayoutPanelInfo.Controls.Add(this.TextBoxEmail, 1, 4);
            this.TableLayoutPanelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelInfo.Location = new System.Drawing.Point(1, 1);
            this.TableLayoutPanelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelInfo.Name = "TableLayoutPanelInfo";
            this.TableLayoutPanelInfo.RowCount = 5;
            this.TableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelInfo.Size = new System.Drawing.Size(417, 150);
            this.TableLayoutPanelInfo.TabIndex = 3;
            // 
            // LabelEmail
            // 
            this.LabelEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelEmail.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(0, 120);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(120, 30);
            this.LabelEmail.TabIndex = 104;
            this.LabelEmail.Text = "Email:";
            this.LabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPhoneNo
            // 
            this.LabelPhoneNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPhoneNo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPhoneNo.Location = new System.Drawing.Point(0, 90);
            this.LabelPhoneNo.Margin = new System.Windows.Forms.Padding(0);
            this.LabelPhoneNo.Name = "LabelPhoneNo";
            this.LabelPhoneNo.Size = new System.Drawing.Size(120, 30);
            this.LabelPhoneNo.TabIndex = 103;
            this.LabelPhoneNo.Text = "Số điện thoại:";
            this.LabelPhoneNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAddress
            // 
            this.LabelAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelAddress.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.Location = new System.Drawing.Point(0, 60);
            this.LabelAddress.Margin = new System.Windows.Forms.Padding(0);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(120, 30);
            this.LabelAddress.TabIndex = 102;
            this.LabelAddress.Text = "Địa chỉ:";
            this.LabelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDoB
            // 
            this.LabelDoB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDoB.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDoB.Location = new System.Drawing.Point(0, 30);
            this.LabelDoB.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDoB.Name = "LabelDoB";
            this.LabelDoB.Size = new System.Drawing.Size(120, 30);
            this.LabelDoB.TabIndex = 101;
            this.LabelDoB.Text = "Ngày sinh:";
            this.LabelDoB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxFullName
            // 
            this.TextBoxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFullName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFullName.Location = new System.Drawing.Point(120, 0);
            this.TextBoxFullName.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxFullName.Name = "TextBoxFullName";
            this.TextBoxFullName.Size = new System.Drawing.Size(297, 30);
            this.TextBoxFullName.TabIndex = 1;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAddress.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAddress.Location = new System.Drawing.Point(120, 60);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(297, 30);
            this.TextBoxAddress.TabIndex = 6;
            // 
            // TextBoxPhoneNo
            // 
            this.TextBoxPhoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPhoneNo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPhoneNo.Location = new System.Drawing.Point(120, 90);
            this.TextBoxPhoneNo.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxPhoneNo.Name = "TextBoxPhoneNo";
            this.TextBoxPhoneNo.Size = new System.Drawing.Size(297, 30);
            this.TextBoxPhoneNo.TabIndex = 7;
            // 
            // LabelFullName
            // 
            this.LabelFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelFullName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFullName.Location = new System.Drawing.Point(0, 0);
            this.LabelFullName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelFullName.Name = "LabelFullName";
            this.LabelFullName.Size = new System.Drawing.Size(120, 30);
            this.LabelFullName.TabIndex = 100;
            this.LabelFullName.Text = "Họ và tên:";
            this.LabelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelTableDoBAndGender
            // 
            this.PanelTableDoBAndGender.ColumnCount = 5;
            this.PanelTableDoBAndGender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PanelTableDoBAndGender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PanelTableDoBAndGender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PanelTableDoBAndGender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.PanelTableDoBAndGender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTableDoBAndGender.Controls.Add(this.LabelGender, 3, 0);
            this.PanelTableDoBAndGender.Controls.Add(this.TextBoxDoBDay, 0, 0);
            this.PanelTableDoBAndGender.Controls.Add(this.TextBoxDoBMonth, 1, 0);
            this.PanelTableDoBAndGender.Controls.Add(this.TextBoxDoBYear, 2, 0);
            this.PanelTableDoBAndGender.Controls.Add(this.ComboBoxGender, 4, 0);
            this.PanelTableDoBAndGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTableDoBAndGender.Location = new System.Drawing.Point(120, 30);
            this.PanelTableDoBAndGender.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTableDoBAndGender.Name = "PanelTableDoBAndGender";
            this.PanelTableDoBAndGender.RowCount = 1;
            this.PanelTableDoBAndGender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTableDoBAndGender.Size = new System.Drawing.Size(297, 30);
            this.PanelTableDoBAndGender.TabIndex = 1;
            // 
            // LabelGender
            // 
            this.LabelGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelGender.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGender.Location = new System.Drawing.Point(110, 0);
            this.LabelGender.Margin = new System.Windows.Forms.Padding(0);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(80, 30);
            this.LabelGender.TabIndex = 4;
            this.LabelGender.Text = "Giới tính:";
            this.LabelGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxDoBDay
            // 
            this.TextBoxDoBDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDoBDay.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDoBDay.Location = new System.Drawing.Point(0, 0);
            this.TextBoxDoBDay.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxDoBDay.Name = "TextBoxDoBDay";
            this.TextBoxDoBDay.Size = new System.Drawing.Size(30, 30);
            this.TextBoxDoBDay.TabIndex = 2;
            this.TextBoxDoBDay.TextChanged += new System.EventHandler(this.TextBoxDoBDay_TextChanged);
            // 
            // TextBoxDoBMonth
            // 
            this.TextBoxDoBMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDoBMonth.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDoBMonth.Location = new System.Drawing.Point(30, 0);
            this.TextBoxDoBMonth.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxDoBMonth.Name = "TextBoxDoBMonth";
            this.TextBoxDoBMonth.Size = new System.Drawing.Size(30, 30);
            this.TextBoxDoBMonth.TabIndex = 3;
            this.TextBoxDoBMonth.TextChanged += new System.EventHandler(this.TextBoxDoBMonth_TextChanged);
            // 
            // TextBoxDoBYear
            // 
            this.TextBoxDoBYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDoBYear.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDoBYear.Location = new System.Drawing.Point(60, 0);
            this.TextBoxDoBYear.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxDoBYear.Name = "TextBoxDoBYear";
            this.TextBoxDoBYear.Size = new System.Drawing.Size(50, 30);
            this.TextBoxDoBYear.TabIndex = 4;
            this.TextBoxDoBYear.TextChanged += new System.EventHandler(this.TextBoxDoBYear_TextChanged);
            // 
            // ComboBoxGender
            // 
            this.ComboBoxGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxGender.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxGender.FormattingEnabled = true;
            this.ComboBoxGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.ComboBoxGender.Location = new System.Drawing.Point(190, 0);
            this.ComboBoxGender.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBoxGender.Name = "ComboBoxGender";
            this.ComboBoxGender.Size = new System.Drawing.Size(107, 31);
            this.ComboBoxGender.TabIndex = 5;
            this.ComboBoxGender.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGender_SelectedIndexChanged);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmail.Location = new System.Drawing.Point(120, 120);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(297, 30);
            this.TextBoxEmail.TabIndex = 8;
            // 
            // PanelTableBottomHalf
            // 
            this.PanelTableBottomHalf.ColumnCount = 4;
            this.TableLayoutParent.SetColumnSpan(this.PanelTableBottomHalf, 2);
            this.PanelTableBottomHalf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.PanelTableBottomHalf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelTableBottomHalf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.PanelTableBottomHalf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelTableBottomHalf.Controls.Add(this.LabelDepartment, 0, 0);
            this.PanelTableBottomHalf.Controls.Add(this.LabelJobTitle, 2, 0);
            this.PanelTableBottomHalf.Controls.Add(this.TextBoxJobTitle, 3, 0);
            this.PanelTableBottomHalf.Controls.Add(this.LabelRole, 0, 1);
            this.PanelTableBottomHalf.Controls.Add(this.LabelStaffCode, 2, 1);
            this.PanelTableBottomHalf.Controls.Add(this.TextBoxStaffCode, 3, 1);
            this.PanelTableBottomHalf.Controls.Add(this.LabelContractCode, 0, 2);
            this.PanelTableBottomHalf.Controls.Add(this.TextBoxContractCode, 1, 2);
            this.PanelTableBottomHalf.Controls.Add(this.LabelStartDate, 2, 2);
            this.PanelTableBottomHalf.Controls.Add(this.TextBoxStartDate, 3, 2);
            this.PanelTableBottomHalf.Controls.Add(this.ButtonRegister, 0, 4);
            this.PanelTableBottomHalf.Controls.Add(this.ButtonCancel, 2, 4);
            this.PanelTableBottomHalf.Controls.Add(this.ComboBoxDepartment, 1, 0);
            this.PanelTableBottomHalf.Controls.Add(this.ComboBoxRole, 1, 1);
            this.PanelTableBottomHalf.Controls.Add(this.LabelUsername, 0, 3);
            this.PanelTableBottomHalf.Controls.Add(this.LabelPassword, 2, 3);
            this.PanelTableBottomHalf.Controls.Add(this.TextBoxUsername, 1, 3);
            this.PanelTableBottomHalf.Controls.Add(this.TextBoxPassword, 3, 3);
            this.PanelTableBottomHalf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTableBottomHalf.Location = new System.Drawing.Point(1, 152);
            this.PanelTableBottomHalf.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTableBottomHalf.Name = "PanelTableBottomHalf";
            this.PanelTableBottomHalf.RowCount = 5;
            this.PanelTableBottomHalf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PanelTableBottomHalf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PanelTableBottomHalf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PanelTableBottomHalf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PanelTableBottomHalf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTableBottomHalf.Size = new System.Drawing.Size(568, 177);
            this.PanelTableBottomHalf.TabIndex = 4;
            // 
            // LabelDepartment
            // 
            this.LabelDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDepartment.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDepartment.Location = new System.Drawing.Point(0, 0);
            this.LabelDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDepartment.Name = "LabelDepartment";
            this.LabelDepartment.Size = new System.Drawing.Size(120, 30);
            this.LabelDepartment.TabIndex = 105;
            this.LabelDepartment.Text = "Bộ phận:";
            this.LabelDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelJobTitle
            // 
            this.LabelJobTitle.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelJobTitle.Location = new System.Drawing.Point(284, 0);
            this.LabelJobTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LabelJobTitle.Name = "LabelJobTitle";
            this.LabelJobTitle.Size = new System.Drawing.Size(120, 30);
            this.LabelJobTitle.TabIndex = 108;
            this.LabelJobTitle.Text = "Chức vụ:";
            this.LabelJobTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxJobTitle
            // 
            this.TextBoxJobTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxJobTitle.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxJobTitle.Location = new System.Drawing.Point(404, 0);
            this.TextBoxJobTitle.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxJobTitle.Name = "TextBoxJobTitle";
            this.TextBoxJobTitle.Size = new System.Drawing.Size(164, 30);
            this.TextBoxJobTitle.TabIndex = 10;
            // 
            // LabelRole
            // 
            this.LabelRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelRole.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRole.Location = new System.Drawing.Point(0, 30);
            this.LabelRole.Margin = new System.Windows.Forms.Padding(0);
            this.LabelRole.Name = "LabelRole";
            this.LabelRole.Size = new System.Drawing.Size(120, 30);
            this.LabelRole.TabIndex = 106;
            this.LabelRole.Text = "Cấp bậc:";
            this.LabelRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelStaffCode
            // 
            this.LabelStaffCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelStaffCode.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStaffCode.Location = new System.Drawing.Point(284, 30);
            this.LabelStaffCode.Margin = new System.Windows.Forms.Padding(0);
            this.LabelStaffCode.Name = "LabelStaffCode";
            this.LabelStaffCode.Size = new System.Drawing.Size(120, 30);
            this.LabelStaffCode.TabIndex = 109;
            this.LabelStaffCode.Text = "Mã NV:";
            this.LabelStaffCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxStaffCode
            // 
            this.TextBoxStaffCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxStaffCode.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxStaffCode.Location = new System.Drawing.Point(404, 30);
            this.TextBoxStaffCode.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxStaffCode.Name = "TextBoxStaffCode";
            this.TextBoxStaffCode.Size = new System.Drawing.Size(164, 30);
            this.TextBoxStaffCode.TabIndex = 12;
            // 
            // LabelContractCode
            // 
            this.LabelContractCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelContractCode.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContractCode.Location = new System.Drawing.Point(0, 60);
            this.LabelContractCode.Margin = new System.Windows.Forms.Padding(0);
            this.LabelContractCode.Name = "LabelContractCode";
            this.LabelContractCode.Size = new System.Drawing.Size(120, 30);
            this.LabelContractCode.TabIndex = 107;
            this.LabelContractCode.Text = "Mã hợp đồng:";
            this.LabelContractCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxContractCode
            // 
            this.TextBoxContractCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxContractCode.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxContractCode.Location = new System.Drawing.Point(120, 60);
            this.TextBoxContractCode.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxContractCode.Name = "TextBoxContractCode";
            this.TextBoxContractCode.Size = new System.Drawing.Size(164, 30);
            this.TextBoxContractCode.TabIndex = 13;
            // 
            // LabelStartDate
            // 
            this.LabelStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelStartDate.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStartDate.Location = new System.Drawing.Point(284, 60);
            this.LabelStartDate.Margin = new System.Windows.Forms.Padding(0);
            this.LabelStartDate.Name = "LabelStartDate";
            this.LabelStartDate.Size = new System.Drawing.Size(120, 30);
            this.LabelStartDate.TabIndex = 110;
            this.LabelStartDate.Text = "Ngày bắt đầu:";
            this.LabelStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxStartDate
            // 
            this.TextBoxStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxStartDate.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxStartDate.Location = new System.Drawing.Point(404, 60);
            this.TextBoxStartDate.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxStartDate.Name = "TextBoxStartDate";
            this.TextBoxStartDate.Size = new System.Drawing.Size(164, 30);
            this.TextBoxStartDate.TabIndex = 14;
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PanelTableBottomHalf.SetColumnSpan(this.ButtonRegister, 2);
            this.ButtonRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonRegister.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonRegister.FlatAppearance.BorderSize = 0;
            this.ButtonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegister.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRegister.Location = new System.Drawing.Point(0, 120);
            this.ButtonRegister.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(284, 57);
            this.ButtonRegister.TabIndex = 111;
            this.ButtonRegister.Text = "Đăng ký";
            this.ButtonRegister.UseVisualStyleBackColor = false;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PanelTableBottomHalf.SetColumnSpan(this.ButtonCancel, 2);
            this.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Location = new System.Drawing.Point(284, 120);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(284, 57);
            this.ButtonCancel.TabIndex = 112;
            this.ButtonCancel.Text = "Hủy bỏ";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ComboBoxDepartment
            // 
            this.ComboBoxDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxDepartment.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDepartment.FormattingEnabled = true;
            this.ComboBoxDepartment.Location = new System.Drawing.Point(120, 0);
            this.ComboBoxDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBoxDepartment.Name = "ComboBoxDepartment";
            this.ComboBoxDepartment.Size = new System.Drawing.Size(164, 31);
            this.ComboBoxDepartment.TabIndex = 9;
            // 
            // ComboBoxRole
            // 
            this.ComboBoxRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxRole.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRole.FormattingEnabled = true;
            this.ComboBoxRole.Location = new System.Drawing.Point(120, 30);
            this.ComboBoxRole.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBoxRole.Name = "ComboBoxRole";
            this.ComboBoxRole.Size = new System.Drawing.Size(164, 31);
            this.ComboBoxRole.TabIndex = 11;
            // 
            // LabelUsername
            // 
            this.LabelUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelUsername.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(0, 90);
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(0);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(120, 30);
            this.LabelUsername.TabIndex = 107;
            this.LabelUsername.Text = "Tài khoản:";
            this.LabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPassword
            // 
            this.LabelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPassword.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(284, 90);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(120, 30);
            this.LabelPassword.TabIndex = 107;
            this.LabelPassword.Text = "Mật khẩu:";
            this.LabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(120, 90);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(164, 30);
            this.TextBoxUsername.TabIndex = 15;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(404, 90);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(164, 30);
            this.TextBoxPassword.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QManager.Properties.Resources.friendly_for_facebook;
            this.pictureBox1.Location = new System.Drawing.Point(439, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20, 10, 10, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.TableLayoutParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FProfile";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Hồ sơ";
            this.Load += new System.EventHandler(this.FRegister_Load);
            this.TableLayoutParent.ResumeLayout(false);
            this.TableLayoutPanelInfo.ResumeLayout(false);
            this.TableLayoutPanelInfo.PerformLayout();
            this.PanelTableDoBAndGender.ResumeLayout(false);
            this.PanelTableDoBAndGender.PerformLayout();
            this.PanelTableBottomHalf.ResumeLayout(false);
            this.PanelTableBottomHalf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutParent;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelInfo;
        private System.Windows.Forms.TextBox TextBoxFullName;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.TextBox TextBoxPhoneNo;
        private System.Windows.Forms.Label LabelFullName;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelPhoneNo;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.Label LabelDoB;
        private System.Windows.Forms.Label LabelGender;
        private System.Windows.Forms.ComboBox ComboBoxGender;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TableLayoutPanel PanelTableBottomHalf;
        private System.Windows.Forms.Label LabelDepartment;
        private System.Windows.Forms.Label LabelJobTitle;
        private System.Windows.Forms.TextBox TextBoxJobTitle;
        private System.Windows.Forms.Label LabelRole;
        private System.Windows.Forms.Label LabelStaffCode;
        private System.Windows.Forms.TextBox TextBoxStaffCode;
        private System.Windows.Forms.Label LabelContractCode;
        private System.Windows.Forms.TextBox TextBoxContractCode;
        private System.Windows.Forms.Label LabelStartDate;
        private System.Windows.Forms.TextBox TextBoxStartDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TableLayoutPanel PanelTableDoBAndGender;
        private System.Windows.Forms.TextBox TextBoxDoBDay;
        private System.Windows.Forms.TextBox TextBoxDoBMonth;
        private System.Windows.Forms.TextBox TextBoxDoBYear;
        private System.Windows.Forms.ComboBox ComboBoxDepartment;
        private System.Windows.Forms.ComboBox ComboBoxRole;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxPassword;
    }
}