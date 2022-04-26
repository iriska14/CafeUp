using System;
using System.Collections.Generic;

namespace WpfApp1
{
    public partial class Dish
    {
        public Dish()
        {
            DichInOrders = new HashSet<DichInOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }

        public virtual ICollection<DichInOrder> DichInOrders { get; set; }
    }
}
