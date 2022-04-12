using System;

using RestaurantManagement.DAL;
using System.Configuration;
using RestaurantManagement.Domain.Models;
using RestaurantManagement.BLL.Common;
using System.Linq;
using System.Collections.Generic;

namespace RestaurantManagement.BLL.Security
{
    public class LoginService : CrudService<LoginModel>, IAuthenticateService
    {
        public LoginService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public LoginModel GetLoginInfo(string loginName)
        {
            return _unitOfWork.SprocQuery<LoginModel>("sp_GetLoginInfo", new object[] { loginName }).FirstOrDefault();
           
        }

        public List<LoginModel> GetAllLoginAccount()
        {
            return _unitOfWork.SprocQuery<LoginModel>("sp_GetAllUser", new object[] {}).ToList();

        }

        public List<LoginModel> GetAllLoginAccountFromRemote()
        {
            return _unitOfWork.SprocQuery<LoginModel>("LINK.RestaurantManagement.[dbo].sp_GetAllUser", new object[] { }).ToList();

        }
    }
}

