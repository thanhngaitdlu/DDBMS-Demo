using RestaurantManagement.BLL.Employees;
using RestaurantManagement.BLL.Security;
using RestaurantManagement.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement_Distributed
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string branch, loginName, password;
            

            if (txtLoginName.Text == "" || txtPassword.Text == "" )
            {
                lblMessage.Text = "Vui lòng nhập thông tin đăng nhập";
                
            }
            if(cbbBranch.SelectedIndex < 0)
            {
                lblMessage.Text = "Vui lòng chọn chi nhánh ";
                return;
            }

            branch = cbbBranch.Text;
            int branchId = cbbBranch.SelectedIndex + 1;
            loginName = txtLoginName.Text;
            password = txtPassword.Text;

            WorkingContext.Instance.CurrentBranch = branch;
            WorkingContext.Instance.CurrentBranchId = branchId;
            WorkingContext.Instance.CurrentLoginName = loginName;

            var connectionName = string.Format("Branch{0}", branchId);
            var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            
            connectionString = string.Format(connectionString, loginName, password);
            WorkingContext.Instance.Initialize(connectionString);

            var unitOfWork = WorkingContext.Instance.GetUnitOfWork();
            var authService = new LoginService(unitOfWork);
            try
            {
                var loginInfo = authService.GetLoginInfo(loginName);
                WorkingContext.Instance.CurrentLoginInfo = loginInfo;

                MainForm form = new MainForm(unitOfWork);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai thông tin đăng nhập \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
