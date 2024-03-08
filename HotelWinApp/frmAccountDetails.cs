using HotelLibrary.BussinessObject;
using HotelLibrary.DataAccess;
using HotelLibrary.Respository;
using System.Xml.Linq;

namespace HotelWinApp
{
    public partial class frmAccountDetails : Form
    {

        IRespository EmplRespository = null;

        BindingSource source;

        public static string Status = "-1";

        public frmAccountDetails()
        {
            InitializeComponent();
            if (EmplRespository == null)
            {
                EmplRespository = new Repository();
            }
            LoadListAccount();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            try
            {
                if (EmplRespository != null)
                {
                    int AccID = 0;
                    string Username = txtEmpName.Text;
                    string Password = txtPassword.Text;
                    string Address = txtEmpAddress.Text;
                    string Phone = txtEmpPhone.Text;
                    string CitizenID = txtEmpCCCD.Text;
                    DateTime DOB = DateTime.Parse(dateEmpDOB.Text);
                    int Gender = rdGenderFemale.Checked ? 2 : 1;
                    int Role = cbRole.Checked ? 2 : 1;

                    bool existingAcc = EmplRespository.IsUsernameExist(Username);
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
                            EmplRespository.InsertAccount(Username, Password, Phone, CitizenID, Address, Gender, DOB, Role);
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
            source.Position = source.Count - 1;
            LoadListAccount();
        }

        private void ClearText()
        {
            txtEmpID.Text = string.Empty;
            txtEmpName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmpPhone.Text = string.Empty;
            txtEmpCCCD.Text = string.Empty;
            txtEmpAddress.Text = string.Empty;
            dateEmpDOB.Text = string.Empty;
        }

        private Account GetAccountObject()
        {
            Account account = null;
            try
            {
                account = new Account()
                {
                    AccID = int.Parse(txtEmpID.Value.ToString()),
                    Phone = txtEmpPhone.Text,
                    Address = txtEmpAddress.Text,
                    CitizenID = txtEmpCCCD.Text,
                    DOB = DateTime.Parse(dateEmpDOB.Text),
                    Gender = rdGenderMale.Checked ? "Male" : "Female",
                    Username = txtEmpName.Text,
                    Password = txtPassword.Text,
                    Role = cbRole.Checked ? "Employee" : "Customer",

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Account");
            }
            return account;
        }

        private void dgvEmployeeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadListAccount();
        }
        public void LoadListAccount()
        {
            var list = EmplRespository.GetAccounts(2);
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtEmpID.DataBindings.Clear();
                txtEmpName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtEmpPhone.DataBindings.Clear();
                txtEmpCCCD.DataBindings.Clear();
                txtEmpAddress.DataBindings.Clear();
                dateEmpDOB.DataBindings.Clear();
                rdGenderFemale.DataBindings.Clear();
                rdGenderMale.DataBindings.Clear();

                txtEmpID.DataBindings.Add("Text", source, "AccID");
                txtEmpName.DataBindings.Add("Text", source, "Username");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtEmpPhone.DataBindings.Add("Text", source, "Phone");
                txtEmpCCCD.DataBindings.Add("Text", source, "CitizenID");
                txtEmpAddress.DataBindings.Add("Text", source, "Address");
                dateEmpDOB.DataBindings.Add("Text", source, "DOB");
                rdGenderFemale.DataBindings.Add("Text", source, "Gender");
                rdGenderMale.DataBindings.Add("Text", source, "Gender");

                dgvEmployeeData.DataSource = null;
                dgvEmployeeData.DataSource = source;
                if (list.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load List Account Employee");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var acc = GetAccountObject();
                EmplRespository.DeleteAccount(acc.AccID);
                LoadListAccount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Account");
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            try
            {
                if (EmplRespository != null)
                {
                    int AccID = int.Parse(txtEmpID.Value.ToString());
                    string Username = txtEmpName.Text;
                    string Password = txtPassword.Text;
                    string Address = txtEmpAddress.Text;
                    string Phone = txtEmpPhone.Text;
                    string CitizenID = txtEmpCCCD.Text;
                    DateTime DOB = DateTime.Parse(dateEmpDOB.Text);
                    int Gender = rdGenderFemale.Checked ? 2 : 1;
                    int Role = cbRole.Checked ? 2 : 1;
                    bool existingAcc = EmplRespository.IsUsernameExist(Username);
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
                            EmplRespository.UpdateAccount(AccID, Username, Password, Phone, CitizenID, Address, Gender, DOB, Role);
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
            source.Position = source.Count - 1;
            LoadListAccount();
        }
    }
}
