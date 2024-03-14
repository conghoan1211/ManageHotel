using HotelLibrary.BussinessObject;
using HotelLibrary.DataAccess;
using HotelLibrary.Respository;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelWinApp
{
    public partial class frmAccountDetails : Form
    {

        IRespository EmplRespository = null;

        BindingSource source;


        public frmAccountDetails()
        {
            InitializeComponent();
            if (EmplRespository == null)
            {
                EmplRespository = new Repository();
            }
            rdGenderMale.Checked = true;
            LoadListAccount();
        }

        private void frmAccountDetails_Load(object sender, EventArgs e)
        {
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

                    bool existingAcc = EmplRespository.IsUsernameExist(Username, -1);
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
                            MessageBox.Show("Add Successfully");
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
            LoadListAccount();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ClearText();
            LoadListAccount();
        }
        public void LoadListAccount()
        {
            var list = EmplRespository.GetAccounts(-1, 1);
            try
            {
                dgvEmployeeData.DataSource = null;
                dgvEmployeeData.DataSource = list.Select(x => new
                {
                    AccID = x.AccID,
                    Username = x.Username,
                    Password = x.Password,
                    Phone = x.Phone,
                    CitizenID = x.CitizenID,
                    Address = x.Address,
                    DOB = x.DOB,
                    Gender = x.Gender.GenderName,
                    Role = x.Role.RoleName,
                }).ToList();

                /*source = new BindingSource();
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
                 // Trong phần gắn kết dữ liệu của RadioButton
                 rdGenderFemale.DataBindings.Add("Checked", source, "Gender");
                 rdGenderMale.DataBindings.Add("Checked", source, "Gender");

                 // Trong phần gắn kết dữ liệu của RadioButton hoặc CheckBox (tùy thuộc vào controls bạn sử dụng)
                 cbRole.DataBindings.Add("Checked", source, "Role");

                 dgvEmployeeData.DataSource = null;
                 dgvEmployeeData.DataSource = source;*/


                if (list.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    int total = list.Count();
                    lbTotalCount.Text = $"Total: {total} record";
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
                MessageBox.Show("Delete Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Account");
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtEmpID.Text);

                if (id <= 0)
                {
                    MessageBox.Show("Input Account ID first!", "Search Account");
                    return;
                }

                Account account = EmplRespository.GetAccountByID(id);
                if (account == null)
                {
                    MessageBox.Show("Account ID is not exist", "Search Account");
                    return;
                }

                List<Account> list = new List<Account> { account };

                // Hiển thị thông tin tìm kiếm trong DataGridView
                dgvEmployeeData.DataSource = list.Select(acc => new
                {
                    AccID = acc.AccID,
                    Username = acc.Username,
                    Password = acc.Password,
                    Phone = acc.Phone,
                    Address = acc.Address,
                    DOB = acc.DOB,
                    CitizenID = acc.CitizenID,
                    Gender = acc.Gender.GenderName,
                    Role = acc.Role.RoleName,
                }).ToList();
                int total = list.Count();
                lbTotalCount.Text = $"Total: {total} record";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Account ID format!", "Search Account");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Search Account");
            }
        }
        private void btnSearchName_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtEmpName.Text;

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Input Account Name first!", "Search Account");
                    return;
                }

                var listAcc = EmplRespository.GetAccounts(-1, 1);
                var listSearch = listAcc.Where(account => account.Username.Contains(name));

                if (listSearch == null)
                {
                    MessageBox.Show("No Account name contain " + name, "Search Account");
                    return;
                }

                // Hiển thị thông tin tìm kiếm trong DataGridView
                dgvEmployeeData.DataSource = listSearch.Select(acc => new
                {
                    AccID = acc.AccID,
                    Username = acc.Username,
                    Password = acc.Password,
                    Phone = acc.Phone,
                    Address = acc.Address,
                    DOB = acc.DOB,
                    CitizenID = acc.CitizenID,
                    Gender = acc.Gender.GenderName,
                    Role = acc.Role.RoleName,
                }).ToList();
                int total = listSearch.Count();
                lbTotalCount.Text = $"Total: {total} record";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Account ID format!", "Search Account");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Search Account");
            }
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
                    bool existingAcc = EmplRespository.IsUsernameExist(Username, AccID);
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
                MessageBox.Show(ex.Message, "Update Account fail");
            }
            LoadListAccount();

        }

        private void dgvEmployeeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvEmployeeData.Rows.Count)
            {
                string? accid = dgvEmployeeData.Rows[e.RowIndex].Cells[0].FormattedValue?.ToString();

                if (accid != null)
                {
                    Account acc = EmplRespository.GetAccountByID(Int32.Parse(accid));
                    txtEmpID.Value = int.Parse(acc.AccID.ToString());
                    txtEmpName.Text = acc.Username;
                    txtPassword.Text = acc.Password;
                    txtEmpPhone.Text = acc.Phone;
                    txtEmpCCCD.Text = acc.CitizenID;
                    txtEmpAddress.Text = acc.Address;
                    dateEmpDOB.Value = acc.DOB;
                    cbRole.Checked = acc.Role.RoleId == 2 ? true : false;
                    rdGenderFemale.Checked = acc.Gender.GenderId == 2 ? true : false;
                    rdGenderMale.Checked = acc.Gender.GenderId == 1 ? true : false;
                }
                else
                {
                    MessageBox.Show("Account ID is not exist");
                }
            }
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
                    Gender = new Gender
                    {
                        GenderId = rdGenderMale.Checked ? 1 : 2,
                        GenderName = rdGenderMale.Checked ? "Male" : "Female"
                    },
                    Username = txtEmpName.Text,
                    Password = txtPassword.Text,
                    Role = cbRole.Checked ? new Role
                    {
                        RoleId = 2,
                        RoleName = "Employee"
                    }
                    : new Role
                    {
                        RoleId = 1,
                        RoleName = "Customer"
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Account");
            }
            return account;
        }
        private void ClearText()
        {
            txtEmpName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmpPhone.Text = string.Empty;
            txtEmpCCCD.Text = string.Empty;
            txtEmpAddress.Text = string.Empty;
            dateEmpDOB.Text = string.Empty;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbFilterRole.SelectedIndex;
            if (selectedIndex == 0)
            {
                selectedIndex = -1;
            }

            var list = EmplRespository.GetAccounts(selectedIndex, 1);
            try
            {
                dgvEmployeeData.DataSource = null;
                dgvEmployeeData.DataSource = list.Select(x => new
                {
                    AccID = x.AccID,
                    Username = x.Username,
                    Password = x.Password,
                    Phone = x.Phone,
                    CitizenID = x.CitizenID,
                    Address = x.Address,
                    DOB = x.DOB,
                    Gender = x.Gender.GenderName,
                    Role = x.Role.RoleName,
                }).ToList();

                if (list.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    int total = list.Count();
                    lbTotalCount.Text = $"Total: {total} record";
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load List Account Employee");
            }
        }

        private void cbFilterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbFilterName.SelectedIndex;
            var list = EmplRespository.GetAccounts(-1, selectedIndex);
            try
            {
                dgvEmployeeData.DataSource = null;
                dgvEmployeeData.DataSource = list.Select(x => new
                {
                    AccID = x.AccID,
                    Username = x.Username,
                    Password = x.Password,
                    Phone = x.Phone,
                    CitizenID = x.CitizenID,
                    Address = x.Address,
                    DOB = x.DOB,
                    Gender = x.Gender.GenderName,
                    Role = x.Role.RoleName,
                }).ToList();

                if (list.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    int total = list.Count();
                    lbTotalCount.Text = $"Total: {total} record";
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load List Account Employee");
            }
        }
    }
}
