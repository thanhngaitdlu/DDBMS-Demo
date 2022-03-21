using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.BLL.Security
{
    public interface IAuthenticateService
    {
        bool Login(string username, string password);
    }
}
