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
            WorkingContext.Instance.CurrentBranch = cbbBranch.SelectedText;
            string loginName = txtLoginName.Text;
            string password = txtPassword.Text;

            if (txtLoginName.Text == "" || txtPassword.Text == "")
            {
                lblMessage.Text = "Vui lòng nhập thông tin đăng nhập";
                return;
            }

            var connectionName = string.Format("Branch{0}", cbbBranch.SelectedIndex + 1);
            var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            WorkingContext.Instance.CurrentConnection = string.Format(connectionString, loginName, password);
            //WorkingContext.Instance.CurrentUser = 

            AdminForm form = new AdminForm();
            form.ShowDialog();
                
        }
    }
}
