using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManagement.Domain.Models;

namespace RestaurantManagement.BLL.Security
{
    public interface IAuthenticateService
    {
        LoginModel GetLoginInfo(string loginName);
    }
}
