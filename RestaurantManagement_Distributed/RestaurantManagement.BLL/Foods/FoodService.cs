using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManagement.BLL.Common;
using RestaurantManagement.DAL;
using RestaurantManagement.Domain;

namespace RestaurantManagement.BLL.Foods
{
    public class FoodService : CrudService<Food>, IFoodService
    {
        public FoodService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IQueryable<Food> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
