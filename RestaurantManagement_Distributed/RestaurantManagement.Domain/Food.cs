
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.Domain
{
	[Table("Food")]
    public class Food : IEntity
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public int CategoryId { get; set; }

		public int Price { get; set; }

		public string Unit { get; set; }

		public string Notes { get; set; }

		//public bool IsDeleted { get; set; }

		public virtual Category Category { get; set; }

		public ICollection<BillDetail> BillInfos { get; set; }

		public Food()
		{
			BillInfos = new HashSet<BillDetail>();
		}
	}
}
