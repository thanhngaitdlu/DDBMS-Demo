using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.Domain
{
    [Table("Table")]
    public class Table : IEntity
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		[DefaultValue(0)]
		public TableStatus Status { get; set; } // 0: Trống, 1: Có người

		//public bool IsDeleted { get; set; }

		
		public int Capacity { get; set; }

		public int Floor { get; set; }

		public int Branch { get; set; }

		public virtual Branch BranchObj { get; set; }

		public ICollection<Bill> Bills { get; set; }

		public Table()
		{
			Bills = new HashSet<Bill>();
		}

	}

	public enum TableStatus
	{
		Available,
		Reserved,
		Busy,
		NotUsed
	}
}
