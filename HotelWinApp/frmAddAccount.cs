using HotelLibrary.BussinessObject;
using HotelLibrary.Respository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelWinApp
{
    public partial class frmAddAccount : Form
    {
        public frmAddAccount()
        {
            InitializeComponent();
        }

        public IRespository AccRepository { get; set; }

        public bool InsertOrUpdate { get; set; }
        public Account AccoutInfo { get; set; }


        private void frmAddAccount_Load(object sender, EventArgs e)
        {
            rdMale.Checked = true;
            cbRole.Checked = true;
            if (AccRepository == null)
            {
                AccRepository = new Repository();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccRepository != null)
                {

                    int AccID = 0;
                    string Username = txtName.Text;
                    string Password = txtPassword.Text;
                    string Address = txtAddress.Text;
                    string Phone = txtPhone.Text;
                    string CitizenID = txtCCCD.Text;
                    DateTime DOB = DateTime.Parse(dateDOB.Text);
                    int Gender = rdFemale.Checked ? 2 : 1;
                    int Role = cbRole.Checked ? 2 : 1;

                    bool existingAcc = AccRepository.IsUsernameExist(Username, -1);
                    if (existingAcc)
                    {
                        MessageBox.Show("Username is already exist", "Notification");
                    }
                    else
                    {
                        // Thêm tài khoản nếu username chưa tồn tại
                        if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password) && !string.IsNullOrWhiteSpace(Address)
                            && !string.IsNullOrWhiteSpace(Phone) && !string.IsNullOrWhiteSpace(CitizenID))
                        {
                            AccRepository.InsertAccount(Username, Password, Phone, CitizenID, Address, Gender, DOB, Role);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("You must input full information", "Notification");
                        }
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
                MessageBox.Show(ex.Message, "Add Account fail");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
