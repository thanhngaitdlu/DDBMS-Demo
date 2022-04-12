using System;

using RestaurantManagement.DAL;
using System.Configuration;
using RestaurantManagement.Domain.Models;
using RestaurantManagement.BLL.Common;
using System.Linq;

namespace RestaurantManagement.BLL.Security
{
    public class LoginService : CrudService<LoginModel>, IAuthenticateService
    {
        public LoginService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public LoginModel GetLoginInfo(string loginName)
        {
            return _unitOfWork.SprocQuery<LoginModel>("SP_GetLoginInfo", new object[] { loginName }).FirstOrDefault();
           
        }
    }
}
