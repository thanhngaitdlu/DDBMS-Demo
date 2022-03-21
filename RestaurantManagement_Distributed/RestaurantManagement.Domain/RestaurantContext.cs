using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Domain
{
    public class RestaurantContext:DbContext
    {
		public DbSet<Branch> Branchs { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Food> Foods { get; set; }
		public DbSet<Table> Tables { get; set; }
		public DbSet<Bill> Bills { get; set; }
		public DbSet<BillDetail> BillDetails { get; set; }

		public RestaurantContext()
		{

		}

		public RestaurantContext(string connectionString):base(connectionString)
		{

		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//base.OnModelCreating(modelBuilder);
		}
	}
}
