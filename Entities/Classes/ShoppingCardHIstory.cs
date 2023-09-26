using System;

namespace E_Commerce.Entities.Classes
{
    public class ShoppingCardHistory
    {
        public Guid Id { get; set; }

        public User UserId { get; set; }

        public ShoppingCardHistory ShoppingCardHistories { get; set; }

        public DateTimeOffset CreatedAt {  get; set; }  

        public string Description {  get; set; }
    }
}
