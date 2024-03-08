namespace HotelWinApp
{
    partial class frmAccountDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            lbAccID = new Label();
            txtEmpPhone = new TextBox();
            lbName = new Label();
            txtEmpName = new TextBox();
            txtEmpAddress = new TextBox();
            lbAddress = new Label();
            lbPhone = new Label();
            lbDob = new Label();
            lbGender = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dateEmpDOB = new DateTimePicker();
            lbCccd = new Label();
            txtEmpCCCD = new MaskedTextBox();
            btnUpdate = new Button();
            btnLoad = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            dgvEmployeeData = new DataGridView();
            rdGenderMale = new RadioButton();
            rdGenderFemale = new RadioButton();
            txtEmpID = new NumericUpDown();
            lbPassword = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            cbRole = new CheckBox();
            btnClose = new Button();
            lbTotalCount = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmpID).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ScrollBar;
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.Location = new Point(426, 242);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 36);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbAccID
            // 
            lbAccID.AutoSize = true;
            lbAccID.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbAccID.Location = new Point(95, 34);
            lbAccID.Name = "lbAccID";
            lbAccID.Size = new Size(33, 23);
            lbAccID.TabIndex = 1;
            lbAccID.Text = "ID ";
            // 
            // txtEmpPhone
            // 
            txtEmpPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpPhone.Location = new Point(184, 94);
            txtEmpPhone.Margin = new Padding(3, 4, 3, 4);
            txtEmpPhone.MaxLength = 10;
            txtEmpPhone.Name = "txtEmpPhone";
            txtEmpPhone.Size = new Size(257, 30);
            txtEmpPhone.TabIndex = 2;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.Location = new Point(507, 34);
            lbName.Name = "lbName";
            lbName.Size = new Size(57, 23);
            lbName.TabIndex = 3;
            lbName.Text = "Name";
            // 
            // txtEmpName
            // 
            txtEmpName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpName.Location = new Point(613, 31);
            txtEmpName.Margin = new Padding(3, 4, 3, 4);
            txtEmpName.MaxLength = 39;
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(287, 30);
            txtEmpName.TabIndex = 4;
            // 
            // txtEmpAddress
            // 
            txtEmpAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpAddress.Location = new Point(1065, 95);
            txtEmpAddress.Margin = new Padding(3, 4, 3, 4);
            txtEmpAddress.Name = "txtEmpAddress";
            txtEmpAddress.Size = new Size(293, 30);
            txtEmpAddress.TabIndex = 5;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbAddress.Location = new Point(947, 99);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(74, 23);
            lbAddress.TabIndex = 10;
            lbAddress.Text = "Address";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbPhone.Location = new Point(85, 96);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(59, 23);
            lbPhone.TabIndex = 12;
            lbPhone.Text = "Phone";
            // 
            // lbDob
            // 
            lbDob.AutoSize = true;
            lbDob.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbDob.Location = new Point(959, 165);
            lbDob.Name = "lbDob";
            lbDob.Size = new Size(47, 23);
            lbDob.TabIndex = 13;
            lbDob.Text = "DOB";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbGender.Location = new Point(77, 172);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(68, 23);
            lbGender.TabIndex = 14;
            lbGender.Text = "Gender";
            // 
            // dateEmpDOB
            // 
            dateEmpDOB.Location = new Point(1065, 165);
            dateEmpDOB.Margin = new Padding(3, 4, 3, 4);
            dateEmpDOB.Name = "dateEmpDOB";
            dateEmpDOB.Size = new Size(293, 27);
            dateEmpDOB.TabIndex = 15;
            // 
            // lbCccd
            // 
            lbCccd.AutoSize = true;
            lbCccd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbCccd.Location = new Point(507, 98);
            lbCccd.Name = "lbCccd";
            lbCccd.Size = new Size(54, 23);
            lbCccd.TabIndex = 16;
            lbCccd.Text = "CCCD";
            // 
            // txtEmpCCCD
            // 
            txtEmpCCCD.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpCCCD.Location = new Point(613, 98);
            txtEmpCCCD.Margin = new Padding(3, 4, 3, 4);
            txtEmpCCCD.Mask = "000000000000";
            txtEmpCCCD.Name = "txtEmpCCCD";
            txtEmpCCCD.Size = new Size(287, 30);
            txtEmpCCCD.TabIndex = 18;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ScrollBar;
            btnUpdate.FlatStyle = FlatStyle.System;
            btnUpdate.Location = new Point(696, 242);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 36);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ScrollBar;
            btnLoad.FlatStyle = FlatStyle.System;
            btnLoad.Location = new Point(178, 242);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(125, 36);
            btnLoad.TabIndex = 20;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ScrollBar;
            btnDelete.FlatStyle = FlatStyle.System;
            btnDelete.Location = new Point(978, 242);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 36);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ScrollBar;
            btnSearch.FlatStyle = FlatStyle.System;
            btnSearch.Location = new Point(1233, 242);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 36);
            btnSearch.TabIndex = 22;
            btnSearch.Text = " Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvEmployeeData
            // 
            dgvEmployeeData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeData.Location = new Point(149, 379);
            dgvEmployeeData.Margin = new Padding(3, 4, 3, 4);
            dgvEmployeeData.Name = "dgvEmployeeData";
            dgvEmployeeData.RowHeadersWidth = 51;
            dgvEmployeeData.RowTemplate.Height = 29;
            dgvEmployeeData.Size = new Size(1209, 336);
            dgvEmployeeData.TabIndex = 23;
            dgvEmployeeData.CellContentClick += dgvEmployeeData_CellContentClick;
            // 
            // rdGenderMale
            // 
            rdGenderMale.AutoSize = true;
            rdGenderMale.Checked = true;
            rdGenderMale.Location = new Point(194, 169);
            rdGenderMale.Margin = new Padding(3, 4, 3, 4);
            rdGenderMale.Name = "rdGenderMale";
            rdGenderMale.Size = new Size(63, 24);
            rdGenderMale.TabIndex = 24;
            rdGenderMale.TabStop = true;
            rdGenderMale.Text = "Male";
            rdGenderMale.UseVisualStyleBackColor = true;
            // 
            // rdGenderFemale
            // 
            rdGenderFemale.AutoSize = true;
            rdGenderFemale.Location = new Point(309, 169);
            rdGenderFemale.Margin = new Padding(3, 4, 3, 4);
            rdGenderFemale.Name = "rdGenderFemale";
            rdGenderFemale.Size = new Size(78, 24);
            rdGenderFemale.TabIndex = 26;
            rdGenderFemale.Text = "Female";
            rdGenderFemale.UseVisualStyleBackColor = true;
            // 
            // txtEmpID
            // 
            txtEmpID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpID.Location = new Point(184, 30);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(257, 30);
            txtEmpID.TabIndex = 27;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbPassword.Location = new Point(947, 36);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(85, 23);
            lbPassword.TabIndex = 28;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(1065, 29);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.MaxLength = 39;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(293, 30);
            txtPassword.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(507, 168);
            label1.Name = "label1";
            label1.Size = new Size(45, 23);
            label1.TabIndex = 30;
            label1.Text = "Role";
            // 
            // cbRole
            // 
            cbRole.AutoSize = true;
            cbRole.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbRole.Location = new Point(629, 165);
            cbRole.Margin = new Padding(3, 4, 3, 4);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(117, 27);
            cbRole.TabIndex = 31;
            cbRole.Text = "isEmployee";
            cbRole.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ScrollBar;
            btnClose.FlatStyle = FlatStyle.System;
            btnClose.Location = new Point(640, 745);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(129, 36);
            btnClose.TabIndex = 32;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lbTotalCount
            // 
            lbTotalCount.AutoSize = true;
            lbTotalCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotalCount.ForeColor = SystemColors.Highlight;
            lbTotalCount.Location = new Point(167, 316);
            lbTotalCount.Name = "lbTotalCount";
            lbTotalCount.Size = new Size(136, 28);
            lbTotalCount.TabIndex = 33;
            lbTotalCount.Text = "Total: 0 record";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Customer", "Employee", "Admin" });
            comboBox1.Location = new Point(411, 314);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 31);
            comboBox1.TabIndex = 34;
            comboBox1.Text = "Choose a option";
            // 
            // frmAccountDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1514, 810);
            Controls.Add(comboBox1);
            Controls.Add(lbTotalCount);
            Controls.Add(btnClose);
            Controls.Add(cbRole);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtEmpID);
            Controls.Add(rdGenderFemale);
            Controls.Add(rdGenderMale);
            Controls.Add(dgvEmployeeData);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(btnUpdate);
            Controls.Add(txtEmpCCCD);
            Controls.Add(lbCccd);
            Controls.Add(dateEmpDOB);
            Controls.Add(lbGender);
            Controls.Add(lbDob);
            Controls.Add(lbPhone);
            Controls.Add(lbAddress);
            Controls.Add(txtEmpAddress);
            Controls.Add(txtEmpName);
            Controls.Add(lbName);
            Controls.Add(txtEmpPhone);
            Controls.Add(lbAccID);
            Controls.Add(btnAdd);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAccountDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Management";
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeData).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmpID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label lbAccID;
        private TextBox txtEmpPhone;
        private Label lbName;
        private TextBox txtEmpName;
        private TextBox txtEmpAddress;
        private Label lbAddress;
        private Label lbPhone;
        private Label lbDob;
        private Label lbGender;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker dateEmpDOB;
        private Label lbCccd;
        private MaskedTextBox tbidDrop;
        private MaskedTextBox txtEmpCCCD;
        private Button btnUpdate;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnSearch;
        private DataGridView dgvEmployeeData;
        private RadioButton rdGenderMale;
        private RadioButton rdGenderFemale;
        private NumericUpDown txtEmpID;
        private Label lbPassword;
        private TextBox txtPassword;
        private Label label1;
        private CheckBox cbRole;
        private Button btnClose;
        private Label lbTotalCount;
        private ComboBox comboBox1;
    }
}
