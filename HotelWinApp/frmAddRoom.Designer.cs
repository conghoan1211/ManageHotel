namespace HotelWinApp
{
    partial class frmAddRoom
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
            btnAddRoom = new Button();
            lbRoomID = new Label();
            numRoomID = new NumericUpDown();
            lbTypeRoom = new Label();
            lbTypeBed = new Label();
            lbPrice = new Label();
            cbTypeRoom = new ComboBox();
            cbTypeBed = new ComboBox();
            numPrice = new NumericUpDown();
            lbAccId = new Label();
            cbCustomerID = new ComboBox();
            btnUpdate = new Button();
            btnHideRoom = new Button();
            btnLoadRoom = new Button();
            btnSeacrhRoom = new Button();
            btnAddCustomer = new Button();
            dgvDataRoom = new DataGridView();
            btnClose = new Button();
            lbTotalRoom = new Label();
            cbFilterStatus = new ComboBox();
            filterTypeBed = new ComboBox();
            filterTypeRoom = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numRoomID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDataRoom).BeginInit();
            SuspendLayout();
            // 
            // btnAddRoom
            // 
            btnAddRoom.Location = new Point(331, 183);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(113, 41);
            btnAddRoom.TabIndex = 0;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // lbRoomID
            // 
            lbRoomID.AutoSize = true;
            lbRoomID.Location = new Point(82, 51);
            lbRoomID.Name = "lbRoomID";
            lbRoomID.Size = new Size(64, 20);
            lbRoomID.TabIndex = 1;
            lbRoomID.Text = "RoomID";
            // 
            // numRoomID
            // 
            numRoomID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numRoomID.Location = new Point(187, 46);
            numRoomID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numRoomID.Name = "numRoomID";
            numRoomID.Size = new Size(222, 30);
            numRoomID.TabIndex = 3;
            // 
            // lbTypeRoom
            // 
            lbTypeRoom.AutoSize = true;
            lbTypeRoom.Location = new Point(454, 50);
            lbTypeRoom.Name = "lbTypeRoom";
            lbTypeRoom.Size = new Size(84, 20);
            lbTypeRoom.TabIndex = 4;
            lbTypeRoom.Text = "Type Room";
            // 
            // lbTypeBed
            // 
            lbTypeBed.AutoSize = true;
            lbTypeBed.Location = new Point(810, 50);
            lbTypeBed.Name = "lbTypeBed";
            lbTypeBed.Size = new Size(70, 20);
            lbTypeBed.TabIndex = 5;
            lbTypeBed.Text = "Type Bed";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(85, 112);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 6;
            lbPrice.Text = "Price";
            // 
            // cbTypeRoom
            // 
            cbTypeRoom.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbTypeRoom.FormattingEnabled = true;
            cbTypeRoom.Items.AddRange(new object[] { "VIP", "Normal" });
            cbTypeRoom.Location = new Point(570, 45);
            cbTypeRoom.Name = "cbTypeRoom";
            cbTypeRoom.Size = new Size(199, 31);
            cbTypeRoom.TabIndex = 7;
            cbTypeRoom.Text = "Choose type room";
            // 
            // cbTypeBed
            // 
            cbTypeBed.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbTypeBed.FormattingEnabled = true;
            cbTypeBed.Items.AddRange(new object[] { "One Bed", "Two Bed" });
            cbTypeBed.Location = new Point(926, 45);
            cbTypeBed.Name = "cbTypeBed";
            cbTypeBed.Size = new Size(199, 31);
            cbTypeBed.TabIndex = 8;
            cbTypeBed.Text = "Choose type bed";
            // 
            // numPrice
            // 
            numPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numPrice.Location = new Point(187, 108);
            numPrice.Maximum = new decimal(new int[] { 2147483640, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(222, 30);
            numPrice.TabIndex = 9;
            // 
            // lbAccId
            // 
            lbAccId.AutoSize = true;
            lbAccId.Location = new Point(455, 116);
            lbAccId.Name = "lbAccId";
            lbAccId.Size = new Size(91, 20);
            lbAccId.TabIndex = 10;
            lbAccId.Text = "Customer ID";
            // 
            // cbCustomerID
            // 
            cbCustomerID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCustomerID.FormattingEnabled = true;
            cbCustomerID.Items.AddRange(new object[] { "One Bed", "Two Bed" });
            cbCustomerID.Location = new Point(570, 111);
            cbCustomerID.Name = "cbCustomerID";
            cbCustomerID.Size = new Size(199, 31);
            cbCustomerID.TabIndex = 11;
            cbCustomerID.Text = "Choose a customer";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(633, 183);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 41);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnHideRoom
            // 
            btnHideRoom.Location = new Point(788, 183);
            btnHideRoom.Name = "btnHideRoom";
            btnHideRoom.Size = new Size(113, 41);
            btnHideRoom.TabIndex = 13;
            btnHideRoom.Text = "Inactive";
            btnHideRoom.UseVisualStyleBackColor = true;
            btnHideRoom.Click += btnHideRoom_Click;
            // 
            // btnLoadRoom
            // 
            btnLoadRoom.Location = new Point(183, 183);
            btnLoadRoom.Name = "btnLoadRoom";
            btnLoadRoom.Size = new Size(113, 41);
            btnLoadRoom.TabIndex = 14;
            btnLoadRoom.Text = "Load";
            btnLoadRoom.UseVisualStyleBackColor = true;
            btnLoadRoom.Click += btnLoadRoom_Click;
            // 
            // btnSeacrhRoom
            // 
            btnSeacrhRoom.Location = new Point(938, 183);
            btnSeacrhRoom.Name = "btnSeacrhRoom";
            btnSeacrhRoom.Size = new Size(113, 41);
            btnSeacrhRoom.TabIndex = 15;
            btnSeacrhRoom.Text = "Search";
            btnSeacrhRoom.UseVisualStyleBackColor = true;
            btnSeacrhRoom.Click += btnSeacrhRoom_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(476, 183);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(124, 41);
            btnAddCustomer.TabIndex = 16;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // dgvDataRoom
            // 
            dgvDataRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataRoom.Location = new Point(147, 347);
            dgvDataRoom.Name = "dgvDataRoom";
            dgvDataRoom.RowHeadersWidth = 51;
            dgvDataRoom.RowTemplate.Height = 29;
            dgvDataRoom.Size = new Size(961, 320);
            dgvDataRoom.TabIndex = 17;
            dgvDataRoom.CellClick += dgvDataRoom_CellClick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(558, 694);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(113, 41);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbTotalRoom
            // 
            lbTotalRoom.AutoSize = true;
            lbTotalRoom.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotalRoom.ForeColor = SystemColors.Highlight;
            lbTotalRoom.Location = new Point(147, 273);
            lbTotalRoom.Name = "lbTotalRoom";
            lbTotalRoom.Size = new Size(145, 30);
            lbTotalRoom.TabIndex = 19;
            lbTotalRoom.Text = "Total: 0 Room";
            // 
            // cbFilterStatus
            // 
            cbFilterStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbFilterStatus.FormattingEnabled = true;
            cbFilterStatus.Items.AddRange(new object[] { "Not used yet", "Be used", "Inactive" });
            cbFilterStatus.Location = new Point(323, 276);
            cbFilterStatus.Name = "cbFilterStatus";
            cbFilterStatus.Size = new Size(168, 28);
            cbFilterStatus.TabIndex = 20;
            cbFilterStatus.Text = "Filter Status Room";
            cbFilterStatus.SelectedIndexChanged += cbFilterStatus_SelectedIndexChanged;
            // 
            // filterTypeBed
            // 
            filterTypeBed.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterTypeBed.FormattingEnabled = true;
            filterTypeBed.Items.AddRange(new object[] { "One Bed", "Two Bed" });
            filterTypeBed.Location = new Point(520, 276);
            filterTypeBed.Name = "filterTypeBed";
            filterTypeBed.Size = new Size(163, 28);
            filterTypeBed.TabIndex = 21;
            filterTypeBed.Text = "Filter Type Bed";
            filterTypeBed.SelectedIndexChanged += filterTypeBed_SelectedIndexChanged;
            // 
            // filterTypeRoom
            // 
            filterTypeRoom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterTypeRoom.FormattingEnabled = true;
            filterTypeRoom.Items.AddRange(new object[] { "VIP", "Normal" });
            filterTypeRoom.Location = new Point(730, 276);
            filterTypeRoom.Name = "filterTypeRoom";
            filterTypeRoom.Size = new Size(163, 28);
            filterTypeRoom.TabIndex = 22;
            filterTypeRoom.Text = "Filter Type Room";
            filterTypeRoom.SelectedIndexChanged += filterTypeRoom_SelectedIndexChanged;
            // 
            // frmAddRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 747);
            Controls.Add(filterTypeRoom);
            Controls.Add(filterTypeBed);
            Controls.Add(cbFilterStatus);
            Controls.Add(lbTotalRoom);
            Controls.Add(btnClose);
            Controls.Add(dgvDataRoom);
            Controls.Add(btnAddCustomer);
            Controls.Add(btnSeacrhRoom);
            Controls.Add(btnLoadRoom);
            Controls.Add(btnHideRoom);
            Controls.Add(btnUpdate);
            Controls.Add(cbCustomerID);
            Controls.Add(lbAccId);
            Controls.Add(numPrice);
            Controls.Add(cbTypeBed);
            Controls.Add(cbTypeRoom);
            Controls.Add(lbPrice);
            Controls.Add(lbTypeBed);
            Controls.Add(lbTypeRoom);
            Controls.Add(numRoomID);
            Controls.Add(lbRoomID);
            Controls.Add(btnAddRoom);
            Name = "frmAddRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Room";
            ((System.ComponentModel.ISupportInitialize)numRoomID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDataRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddRoom;
        private Label lbRoomID;
        private NumericUpDown numRoomID;
        private Label lbTypeRoom;
        private Label lbTypeBed;
        private Label lbPrice;
        private ComboBox cbTypeRoom;
        private ComboBox cbTypeBed;
        private NumericUpDown numPrice;
        private Label lbAccId;
        private ComboBox cbCustomerID;
        private Button btnUpdate;
        private Button btnHideRoom;
        private Button btnLoadRoom;
        private Button btnSeacrhRoom;
        private Button btnAddCustomer;
        private DataGridView dgvDataRoom;
        private Button btnClose;
        private Label lbTotalRoom;
        private ComboBox cbFilterStatus;
        private ComboBox filterTypeBed;
        private ComboBox filterTypeRoom;
    }
}