using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.Domain
{
    public class BillDetail:IEntity
    {
		public int Id { get; set; }

		[Required]
		public int BillId { get; set; }
		[Required]
		public int FoodId { get; set; }

		[Required]
		[DefaultValue(0)]
		public int Quantity { get; set; }

		public int CurrentUnitPrice { get; set; }

		// Computed properties

		[NotMapped]
		public int Amount => (Quantity * CurrentUnitPrice);

		// Navigation properties
		public virtual Bill Bill { get; set; }
		public virtual Food Food { get; set; }

		
	}
}
