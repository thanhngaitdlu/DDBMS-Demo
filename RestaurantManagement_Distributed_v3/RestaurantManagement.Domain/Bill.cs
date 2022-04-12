using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Domain
{
    public class Bill : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int TableId { get; set; }

        public int Employee { get; set; }

        public int Amount { get; set; }

        public float Discount { get; set; }

        public float Tax { get; set; }

        public bool Status { get; set; }

        public DateTime CheckOutDate { get; set; }

        public virtual Table Table { get; set; }

        public virtual Employee EmployeeObject { get; set; }

        public ICollection<BillDetail> BillDetail { get; set; }

        public Bill()
        {
            BillDetail = new HashSet<BillDetail>();
        }

    }
}
