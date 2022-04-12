
using System;
using System.Linq;
using System.Windows.Forms;
using RestaurantManagement.BLL.Foods;
using RestaurantManagement.DAL;

namespace RestaurantManagement_Distributed
{
    public partial class MainForm : Form
    {
        private IUnitOfWork _unitOfWork;
        private IFoodService _foodService;
        public MainForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _foodService = new FoodService(_unitOfWork);
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                dgvFoodList.DataSource = _foodService.GetAll().ToList();
                tsslLoginName.Text += WorkingContext.Instance.CurrentLoginName;
                tsslBranch.Text += WorkingContext.Instance.CurrentBranch;
                tsslGroup.Text += WorkingContext.Instance.CurrentLoginInfo.RoleName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai thông tin đăng nhập \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void tsmiAdmin_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm(_unitOfWork);
            admin.ShowDialog();
        }
    }
}
