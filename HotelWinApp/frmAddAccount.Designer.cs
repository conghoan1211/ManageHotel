namespace HotelWinApp
{
    partial class frmAddAccount
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
            lbName = new Label();
            txtName = new TextBox();
            lbPhone = new Label();
            lbAddress = new Label();
            lbGender = new Label();
            lbDob = new Label();
            lbPassword = new Label();
            lbRoleId = new Label();
            txtAddress = new TextBox();
            txtPassword = new TextBox();
            dateDOB = new DateTimePicker();
            rdMale = new RadioButton();
            btnSave = new Button();
            btnCancel = new Button();
            lbCCCD = new Label();
            cbRole = new CheckBox();
            txtCCCD = new MaskedTextBox();
            rdFemale = new RadioButton();
            txtPhone = new MaskedTextBox();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(31, 46);
            lbName.Name = "lbName";
            lbName.Size = new Size(87, 23);
            lbName.TabIndex = 0;
            lbName.Text = "Username";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(137, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(207, 30);
            txtName.TabIndex = 2;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbPhone.Location = new Point(31, 118);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(59, 23);
            lbPhone.TabIndex = 3;
            lbPhone.Text = "Phone";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbAddress.Location = new Point(24, 254);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(70, 23);
            lbAddress.TabIndex = 4;
            lbAddress.Text = "Address";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbGender.Location = new Point(24, 187);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(66, 23);
            lbGender.TabIndex = 5;
            lbGender.Text = "Gender";
            // 
            // lbDob
            // 
            lbDob.AutoSize = true;
            lbDob.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbDob.Location = new Point(390, 125);
            lbDob.Name = "lbDob";
            lbDob.Size = new Size(45, 23);
            lbDob.TabIndex = 7;
            lbDob.Text = "DOB";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.Location = new Point(376, 53);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(80, 23);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Password";
            // 
            // lbRoleId
            // 
            lbRoleId.AutoSize = true;
            lbRoleId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbRoleId.Location = new Point(385, 190);
            lbRoleId.Name = "lbRoleId";
            lbRoleId.Size = new Size(43, 23);
            lbRoleId.TabIndex = 9;
            lbRoleId.Text = "Role";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(137, 247);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(207, 30);
            txtAddress.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(478, 50);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(259, 30);
            txtPassword.TabIndex = 12;
            // 
            // dateDOB
            // 
            dateDOB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateDOB.Location = new Point(463, 125);
            dateDOB.Name = "dateDOB";
            dateDOB.Size = new Size(274, 27);
            dateDOB.TabIndex = 13;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(137, 189);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(63, 24);
            rdMale.TabIndex = 16;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(210, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 38);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(429, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 38);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbCCCD
            // 
            lbCCCD.AutoSize = true;
            lbCCCD.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbCCCD.Location = new Point(390, 254);
            lbCCCD.Name = "lbCCCD";
            lbCCCD.Size = new Size(55, 23);
            lbCCCD.TabIndex = 20;
            lbCCCD.Text = "CCCD";
            // 
            // cbRole
            // 
            cbRole.AutoSize = true;
            cbRole.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbRole.Location = new Point(478, 191);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(117, 27);
            cbRole.TabIndex = 22;
            cbRole.Text = "isEmployee";
            cbRole.UseVisualStyleBackColor = true;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(478, 254);
            txtCCCD.Mask = "000000000000";
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(259, 27);
            txtCCCD.TabIndex = 24;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(242, 189);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(78, 24);
            rdFemale.TabIndex = 17;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(137, 127);
            txtPhone.Mask = "0000000000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(207, 30);
            txtPhone.TabIndex = 26;
            // 
            // frmAddAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 424);
            Controls.Add(txtPhone);
            Controls.Add(txtCCCD);
            Controls.Add(cbRole);
            Controls.Add(lbCCCD);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(dateDOB);
            Controls.Add(txtPassword);
            Controls.Add(txtAddress);
            Controls.Add(lbRoleId);
            Controls.Add(lbPassword);
            Controls.Add(lbDob);
            Controls.Add(lbGender);
            Controls.Add(lbAddress);
            Controls.Add(lbPhone);
            Controls.Add(txtName);
            Controls.Add(lbName);
            Name = "frmAddAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddAccount";
            Load += frmAddAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private TextBox txtName;
        private Label lbPhone;
        private Label lbAddress;
        private Label lbGender;
        private Label lbDob;
        private Label lbPassword;
        private Label lbRoleId;
        private TextBox maskedTextBox1;
        private TextBox txtAddress;
        private TextBox txtPassword;
        private DateTimePicker dateDOB;
        private RadioButton rdMale;
        private Button btnSave;
        private Button btnCancel;
        private Label lbCCCD;
        private CheckBox cbRole;
        private MaskedTextBox txtCCCD;
        private RadioButton rdFemale;
        private MaskedTextBox txtPhone;
    }
}