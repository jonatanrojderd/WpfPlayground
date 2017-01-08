using System;
using System.ComponentModel.DataAnnotations;

namespace WpfPlayground.Models
{
    public class Person
    {
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public int Age { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
