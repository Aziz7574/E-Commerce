using E_Commerce.Entities.Enums;
using Microsoft.Extensions.Options;
using System;  

namespace E_Commerce.Entities.Classes
{
    public class Order
    {
        public Guid Id { get; set; }

        public OrderCondition Condition { get; set; }

        public User UserId {  get; set; }

        public Product ProductId { get; set; }

        public int Count {  get; set; } 

        public DateTimeOffset ProducedTime { get; set; }  
        
        public ClassCondition ClassCondition { get; set; } 

    }
}
