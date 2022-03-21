
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.Domain
{
    [Table("Branch")]
    public class Branch : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<Table> Tables { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public Branch()
        {
            Tables = new HashSet<Table>();
            Employees = new HashSet<Employee>();
        }
    }
}
