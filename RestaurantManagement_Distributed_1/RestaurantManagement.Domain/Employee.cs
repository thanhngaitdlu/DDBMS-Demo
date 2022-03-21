using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Domain
{
    [Table("Employee")]
    public class Employee : IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public int Salary { get; set; }

        public int Branch { get; set; }

        public virtual Branch BranchObj { get; set; }

        public ICollection<Bill> Bills { get; set; }

        public Employee()
        {
            Bills = new HashSet<Bill>();
        }


    }
}
