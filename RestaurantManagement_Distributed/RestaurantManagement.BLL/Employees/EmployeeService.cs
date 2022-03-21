using RestaurantManagement.BLL.Common;
using RestaurantManagement.DAL;
using RestaurantManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.BLL.Employees
{
    public class EmployeeService : CrudService<Employee>, IEmployeeService
    {
        public EmployeeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IQueryable<Employee> GetAll()
        {
            return this._repository.GetAll();
        }
    }
}
