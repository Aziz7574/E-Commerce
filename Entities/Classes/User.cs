
using E_Commerce.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Entities.Classes
{
    public class User
    {
        [Required(ErrorMessage = "Id is required")]
        public Guid Id {  get; set; }

        [Required(ErrorMessage = "Name is required")]

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }    

        public DateTimeOffset BirthDate { get; set; }   

        public string Email { get; set; }

        public ClassCondition ClassCondition { get; set; }

        public string PasswordCode { get; set; }    
    }
}
