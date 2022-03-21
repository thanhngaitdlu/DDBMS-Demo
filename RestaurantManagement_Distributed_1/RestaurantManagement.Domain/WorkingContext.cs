using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Domain
{
    public sealed class WorkingContext
    {
		
		private static WorkingContext _instance = null;

		public static WorkingContext Instance => _instance ?? (_instance = new WorkingContext());

		public Employee CurrentUser { get; set; }

		public string CurrentBranch { get; set; }

		public string CurrentConnection{ get; set; }

		private WorkingContext()
		{

		}

		public RestaurantContext CreateRestaurantContext()
		{
			return new RestaurantContext(CurrentConnection);
		}
	}
}
