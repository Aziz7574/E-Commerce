using System;
using System.Collections.Generic;

namespace E_Commerce.Entities.Classes
{
    public class ShoppingCard
    {
        public Guid Id { get; set; }

        public User UserId { get; set; }    

        public ICollection<Order> Orders { get; set; }

        public string Description {  get; set; }

    }
}
