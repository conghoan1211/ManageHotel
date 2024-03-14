namespace HotelWinApp
{
    partial class frmHotelManagement
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
            menuStrip1 = new MenuStrip();
            catalogToolStripMenuItem = new ToolStripMenuItem();
            menuMnAcc = new ToolStripMenuItem();
            menuMnRoom = new ToolStripMenuItem();
            menuLoadRoom = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            menuBtnListOrder = new ToolStripMenuItem();
            menuBtnLoadCheckout = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            vietnameseToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            chineseToolStripMenuItem = new ToolStripMenuItem();
            koreanToolStripMenuItem = new ToolStripMenuItem();
            japaneseToolStripMenuItem = new ToolStripMenuItem();
            frenchToolStripMenuItem = new ToolStripMenuItem();
            musicToolStripMenuItem = new ToolStripMenuItem();
            turnOnToolStripMenuItem = new ToolStripMenuItem();
            turnOffToolStripMenuItem = new ToolStripMenuItem();
            displayToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            btnLogout = new ToolStripMenuItem();
            existToolStripMenuItem = new ToolStripMenuItem();
            supportToolStripMenuItem = new ToolStripMenuItem();
            feedbackToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { catalogToolStripMenuItem, orderToolStripMenuItem, settingsToolStripMenuItem, supportToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1031, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // catalogToolStripMenuItem
            // 
            catalogToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuMnAcc, menuMnRoom, menuLoadRoom });
            catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            catalogToolStripMenuItem.Size = new Size(75, 24);
            catalogToolStripMenuItem.Text = "Catalog";
            // 
            // menuMnAcc
            // 
            menuMnAcc.Name = "menuMnAcc";
            menuMnAcc.Size = new Size(208, 26);
            menuMnAcc.Text = "Manage Account ";
            menuMnAcc.Click += manageAccountToolStripMenuItem_Click;
            // 
            // menuMnRoom
            // 
            menuMnRoom.Name = "menuMnRoom";
            menuMnRoom.Size = new Size(208, 26);
            menuMnRoom.Text = "Manage Room";
            menuMnRoom.Click += menuMnRoom_Click;
            // 
            // menuLoadRoom
            // 
            menuLoadRoom.Name = "menuLoadRoom";
            menuLoadRoom.Size = new Size(208, 26);
            menuLoadRoom.Text = "Load Rooms";
            menuLoadRoom.Click += loadRoomsToolStripMenuItem_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuBtnListOrder, menuBtnLoadCheckout });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(67, 24);
            orderToolStripMenuItem.Text = "Orders";
            // 
            // menuBtnListOrder
            // 
            menuBtnListOrder.Name = "menuBtnListOrder";
            menuBtnListOrder.Size = new Size(162, 26);
            menuBtnListOrder.Text = "List Orders";
            // 
            // menuBtnLoadCheckout
            // 
            menuBtnLoadCheckout.Name = "menuBtnLoadCheckout";
            menuBtnLoadCheckout.Size = new Size(162, 26);
            menuBtnLoadCheckout.Text = "Checkout";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { languageToolStripMenuItem, musicToolStripMenuItem, displayToolStripMenuItem, btnLogout, existToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vietnameseToolStripMenuItem, englishToolStripMenuItem, chineseToolStripMenuItem, koreanToolStripMenuItem, japaneseToolStripMenuItem, frenchToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(228, 26);
            languageToolStripMenuItem.Text = "Language";
            // 
            // vietnameseToolStripMenuItem
            // 
            vietnameseToolStripMenuItem.Name = "vietnameseToolStripMenuItem";
            vietnameseToolStripMenuItem.Size = new Size(169, 26);
            vietnameseToolStripMenuItem.Text = "Vietnamese";
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(169, 26);
            englishToolStripMenuItem.Text = "English";
            // 
            // chineseToolStripMenuItem
            // 
            chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
            chineseToolStripMenuItem.Size = new Size(169, 26);
            chineseToolStripMenuItem.Text = "Chinese";
            // 
            // koreanToolStripMenuItem
            // 
            koreanToolStripMenuItem.Name = "koreanToolStripMenuItem";
            koreanToolStripMenuItem.Size = new Size(169, 26);
            koreanToolStripMenuItem.Text = "Korean";
            // 
            // japaneseToolStripMenuItem
            // 
            japaneseToolStripMenuItem.Name = "japaneseToolStripMenuItem";
            japaneseToolStripMenuItem.Size = new Size(169, 26);
            japaneseToolStripMenuItem.Text = "Japanese";
            // 
            // frenchToolStripMenuItem
            // 
            frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            frenchToolStripMenuItem.Size = new Size(169, 26);
            frenchToolStripMenuItem.Text = "French";
            // 
            // musicToolStripMenuItem
            // 
            musicToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { turnOnToolStripMenuItem, turnOffToolStripMenuItem });
            musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            musicToolStripMenuItem.Size = new Size(228, 26);
            musicToolStripMenuItem.Text = "Music";
            // 
            // turnOnToolStripMenuItem
            // 
            turnOnToolStripMenuItem.Name = "turnOnToolStripMenuItem";
            turnOnToolStripMenuItem.Size = new Size(144, 26);
            turnOnToolStripMenuItem.Text = "Turn on";
            // 
            // turnOffToolStripMenuItem
            // 
            turnOffToolStripMenuItem.Name = "turnOffToolStripMenuItem";
            turnOffToolStripMenuItem.Size = new Size(144, 26);
            turnOffToolStripMenuItem.Text = "Turn off";
            // 
            // displayToolStripMenuItem
            // 
            displayToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkToolStripMenuItem, lightToolStripMenuItem });
            displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            displayToolStripMenuItem.Size = new Size(228, 26);
            displayToolStripMenuItem.Text = "Display & Assessibility";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(125, 26);
            darkToolStripMenuItem.Text = "Dark";
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new Size(125, 26);
            lightToolStripMenuItem.Text = "Light";
            // 
            // btnLogout
            // 
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(228, 26);
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // existToolStripMenuItem
            // 
            existToolStripMenuItem.Name = "existToolStripMenuItem";
            existToolStripMenuItem.Size = new Size(228, 26);
            existToolStripMenuItem.Text = "Exist";
            existToolStripMenuItem.Click += existToolStripMenuItem_Click;
            // 
            // supportToolStripMenuItem
            // 
            supportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { feedbackToolStripMenuItem, helpToolStripMenuItem, reportToolStripMenuItem });
            supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            supportToolStripMenuItem.Size = new Size(76, 24);
            supportToolStripMenuItem.Text = "Support";
            // 
            // feedbackToolStripMenuItem
            // 
            feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            feedbackToolStripMenuItem.Size = new Size(155, 26);
            feedbackToolStripMenuItem.Text = "Feedback";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(155, 26);
            helpToolStripMenuItem.Text = "Help";
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(155, 26);
            reportToolStripMenuItem.Text = "Report";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(28, 43);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(978, 500);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // frmHotelManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 580);
            Controls.Add(menuStrip1);
            Controls.Add(flowLayoutPanel1);
            MainMenuStrip = menuStrip1;
            Name = "frmHotelManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHotelManagement";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem catalogToolStripMenuItem;
        private ToolStripMenuItem menuMnAcc;
        private ToolStripMenuItem menuMnRoom;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem menuBtnListOrder;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem musicToolStripMenuItem;
        private ToolStripMenuItem displayToolStripMenuItem;
        private ToolStripMenuItem btnLogout;
        private ToolStripMenuItem existToolStripMenuItem;
        private ToolStripMenuItem supportToolStripMenuItem;
        private ToolStripMenuItem feedbackToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem menuBtnLoadCheckout;
        private ToolStripMenuItem vietnameseToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem chineseToolStripMenuItem;
        private ToolStripMenuItem koreanToolStripMenuItem;
        private ToolStripMenuItem japaneseToolStripMenuItem;
        private ToolStripMenuItem frenchToolStripMenuItem;
        private ToolStripMenuItem turnOnToolStripMenuItem;
        private ToolStripMenuItem turnOffToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
        private PictureBox pictureBox3;
        private ToolStripMenuItem menuLoadRoom;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
    }
}