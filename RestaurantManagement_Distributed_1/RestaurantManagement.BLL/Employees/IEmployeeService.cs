using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantManagement.Domain;

namespace RestaurantManagement.BLL.Employees
{
    public interface IEmployeeService : ICrudService<Employee>
    {
        IQueryable<Employee> GetAll();
    }
}
