
using RestaurantManagement.Domain.Models;

namespace RestaurantManagement.BLL.Account
{
	internal interface IAccountServices
	{ 
		AccountModel GetAll(string loginName);

		bool CreateAccount(string loginName, string passWord, string userName, string roleName);

		bool ResetPassword(string newPassword);

	}
}
