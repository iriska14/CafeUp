﻿using System;
using System.Collections.Generic;

namespace WpfApp1
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoseId { get; set; }

        public virtual Role Rose { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
