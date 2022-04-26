using System;
using System.Collections.Generic;

namespace WpfApp1
{
    public partial class Order
    {
        public Order()
        {
            DichInOrders = new HashSet<DichInOrder>();
        }

        public int Id { get; set; }
        public int IdUser { get; set; }
        public DateTime DateCreate { get; set; }

        public virtual User IdUserNavigation { get; set; } = null!;
        public virtual ICollection<DichInOrder> DichInOrders { get; set; }
    }
}
