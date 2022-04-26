using System;
using System.Collections.Generic;

namespace WpfApp1
{
    public partial class DichInOrder
    {
        public int Id { get; set; }
        public int Orderid { get; set; }
        public int Dichid { get; set; }
        public int DichCount { get; set; }

        public virtual Dish Dich { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
