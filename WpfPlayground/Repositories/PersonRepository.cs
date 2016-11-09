using System;
using System.Collections.Generic;
using WpfPlayground.Models;

namespace WpfPlayground.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public IList<Person> Read()
        {
            return new List<Person>
            {
                new Person
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jonte",
                    LastName = "RD"
                }
            };
        }
    }
}
