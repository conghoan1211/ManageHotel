namespace HotelWinApp
{
    partial class frmLogin
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
            label1 = new Label();
            lbLoginName = new Label();
            lbLoginPass = new Label();
            txtLoginName = new TextBox();
            txtLoginPass = new TextBox();
            btnLoginCancel = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(279, 39);
            label1.Name = "label1";
            label1.Size = new Size(185, 46);
            label1.TabIndex = 0;
            label1.Text = "Login Page";
            // 
            // lbLoginName
            // 
            lbLoginName.AutoSize = true;
            lbLoginName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLoginName.Location = new Point(105, 126);
            lbLoginName.Name = "lbLoginName";
            lbLoginName.Size = new Size(99, 28);
            lbLoginName.TabIndex = 1;
            lbLoginName.Text = "Username";
            // 
            // lbLoginPass
            // 
            lbLoginPass.AutoSize = true;
            lbLoginPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLoginPass.Location = new Point(105, 205);
            lbLoginPass.Name = "lbLoginPass";
            lbLoginPass.Size = new Size(93, 28);
            lbLoginPass.TabIndex = 2;
            lbLoginPass.Text = "Password";
            // 
            // txtLoginName
            // 
            txtLoginName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginName.Location = new Point(259, 126);
            txtLoginName.Name = "txtLoginName";
            txtLoginName.Size = new Size(306, 39);
            txtLoginName.TabIndex = 3;
            // 
            // txtLoginPass
            // 
            txtLoginPass.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginPass.Location = new Point(259, 200);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.PasswordChar = '*';
            txtLoginPass.Size = new Size(306, 39);
            txtLoginPass.TabIndex = 4;
            // 
            // btnLoginCancel
            // 
            btnLoginCancel.BackColor = SystemColors.Menu;
            btnLoginCancel.Location = new Point(460, 276);
            btnLoginCancel.Name = "btnLoginCancel";
            btnLoginCancel.Size = new Size(105, 41);
            btnLoginCancel.TabIndex = 5;
            btnLoginCancel.Text = "Cancel";
            btnLoginCancel.UseVisualStyleBackColor = false;
            btnLoginCancel.Click += btnLoginCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Menu;
            btnLogin.Location = new Point(259, 276);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(106, 41);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 420);
            Controls.Add(btnLogin);
            Controls.Add(btnLoginCancel);
            Controls.Add(txtLoginPass);
            Controls.Add(txtLoginName);
            Controls.Add(lbLoginPass);
            Controls.Add(lbLoginName);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbLoginName;
        private Label lbLoginPass;
        private TextBox txtLoginName;
        private TextBox txtLoginPass;
        private Button btnLoginCancel;
        private Button btnLogin;
    }
}