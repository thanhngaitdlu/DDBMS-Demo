using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.Domain
{
    [Table("Category")]
    public class Category : IEntity
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }

		public int Type { get; set; }

		//public bool IsDeleted { get; set; }

		public ICollection<Food> Foods { get; set; }

		public Category()
		{
			Foods = new HashSet<Food>();
		}
	}
}
