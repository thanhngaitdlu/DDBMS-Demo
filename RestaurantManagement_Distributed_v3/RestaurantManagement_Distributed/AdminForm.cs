using RestaurantManagement.BLL.Employees;
using RestaurantManagement.DAL;
using RestaurantManagement.BLL.Security;
using RestaurantManagement.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagement.Domain.Models;

namespace RestaurantManagement_Distributed
{
    public partial class AdminForm : Form
    {
        private IUnitOfWork _unitOfWork;
        private IEmployeeService _empService;
        private LoginService loginService;
        private IList<Employee> remoteEmpList;

        public AdminForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _empService = new EmployeeService(_unitOfWork);
            loginService = new LoginService(_unitOfWork);

            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (WorkingContext.Instance.CurrentLoginInfo.RoleName != "GIAMDOC")
                {
                    cbbBranch.Enabled = false;
                    cbbBranch_Add.Enabled = false;
                    cbbBranch_View.Enabled = false;
                }

                int currentBranch = WorkingContext.Instance.CurrentBranchId;
                cbbBranch.SelectedIndex = currentBranch - 1;
                cbbBranch_Add.SelectedIndex = currentBranch - 1;
                cbbBranch_View.SelectedIndex = currentBranch - 1;

                cbbBranch.SelectedValue = currentBranch;
                cbbBranch_Add.SelectedValue = currentBranch;
                cbbBranch_View.SelectedValue = currentBranch;

                //dgvEmployee.DataSource = _empService.GetAll().ToList();

                //List<LoginModel> list = loginService.GetAllLoginAccount();
                //DisplayAccountInfoLV(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Sai thông tin đăng nhập \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            
        }

        private void DisplayAccountInfoLV(List<LoginModel> list)
        {
            foreach (var login in list)
            {
                
                int branchId = cbbBranch_View.SelectedIndex + 1;
                int empId = int.Parse(login.Id);
                Employee emp;
                if (branchId != WorkingContext.Instance.CurrentBranchId)
                {
                    if(remoteEmpList == null)
                        remoteEmpList = _empService.GetAllFromRemote();
                    emp = remoteEmpList.Where(p => p.Id == empId).FirstOrDefault();
                }
                else
                {
                    emp = _empService.GetById(empId);
                }
              
                ListViewItem lvItem = new ListViewItem(emp.Id.ToString());
                lvItem.SubItems.Add(emp.LastName);
                lvItem.SubItems.Add(emp.FirstName);
                lvItem.SubItems.Add(emp.BranchId.ToString());
                lvItem.SubItems.Add(login.RoleName);

                lvAccountList.Items.Add(lvItem);
            }
        }

        private void cbbBranch_View_SelectedIndexChanged(object sender, EventArgs e)
        {
            int branchId = cbbBranch_View.SelectedIndex+ 1;
            
            List<LoginModel> list = new List<LoginModel>();

            if (branchId == WorkingContext.Instance.CurrentBranchId)
                list = loginService.GetAllLoginAccount();
            else
                list = loginService.GetAllLoginAccountFromRemote();

            lvAccountList.Items.Clear();
            DisplayAccountInfoLV(list);
        }

        private void cbbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int branchId = cbbBranch.SelectedIndex + 1;

            if (branchId == WorkingContext.Instance.CurrentBranchId)
                dgvEmployee.DataSource = _empService.GetAll().ToList();
            else
            {
                remoteEmpList = _empService.GetAllFromRemote();
                dgvEmployee.DataSource = remoteEmpList;
            }
                
        }
    }
}
