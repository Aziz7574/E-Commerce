using System;

namespace E_Commerce.Entities.Classes
{
    public class Product
    {
        public Guid Id {  get; set; }   

        public string Name { get; set; }    

        public decimal Price { get; set; }

        public DateTimeOffset ExpirationDate { get; set; }

        public DateTimeOffset ProducedTime {  get; set; } 

        public string Description {  get; set; }   

    }
}
