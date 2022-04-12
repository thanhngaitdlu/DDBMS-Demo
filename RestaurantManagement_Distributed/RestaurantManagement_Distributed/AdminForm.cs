using RestaurantManagement.BLL.Employees;
using RestaurantManagement.DAL;
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

namespace RestaurantManagement_Distributed
{
    public partial class AdminForm : Form
    {
        private IUnitOfWork _unitOfWork;
        private IEmployeeService _empService;

        public AdminForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _empService = new EmployeeService(_unitOfWork);

            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (WorkingContext.Instance.CurrentLoginInfo.RoleName != "CongTy") cbbBranch.Enabled = false;
                //dgvEmployee.DataSource = _empService.GetAll().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Sai thông tin đăng nhập \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            
        }
    }
}
