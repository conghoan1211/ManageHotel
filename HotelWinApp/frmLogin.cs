using HotelLibrary.BussinessObject;
using HotelLibrary.Respository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public IRespository AccRepository { get; set; }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (AccRepository == null)
            {
                AccRepository = new Repository();
            }
        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccRepository != null)
                {

                    int AccID = 0;
                    string Username = txtLoginName.Text;
                    string Password = txtLoginPass.Text;

                    // Thêm tài khoản nếu username chưa tồn tại
                    if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password) )
                    {
                       Account acc =  AccRepository.Login(Username, Password);
                        if ( acc != null )
                        {
                            frmHotelManagement frmHotelManagement = new frmHotelManagement();
                            frmHotelManagement.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username or Password weren't correct", "Notification");

                        }
                    }
                    else
                    {
                        MessageBox.Show("You must input full information", "Notification");
                    }
                }
                else
                {
                    // Xử lý khi AccRepository là null
                    MessageBox.Show("AccRepository is not initialized.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Hotel Management ");
            }
        }


    }
}
