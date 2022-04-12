using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantManagement.Domain;

namespace RestaurantManagement.BLL.Foods
{
    public interface IFoodService: ICrudService<Food>
    {
       IQueryable<Food> GetAll();
    }
}
