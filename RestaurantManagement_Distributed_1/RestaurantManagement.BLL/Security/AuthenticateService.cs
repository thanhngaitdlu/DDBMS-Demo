using System;

using RestaurantManagement.DAL;
using System.Configuration;

namespace RestaurantManagement.BLL.Security
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly IUnitOfWork _unitOfWork;

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
