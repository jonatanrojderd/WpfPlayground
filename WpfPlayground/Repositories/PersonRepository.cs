using System;
using System.Collections.Generic;
using System.Linq;
using WpfPlayground.Models;

namespace WpfPlayground.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public IList<Person> Persons { get; } = new List<Person>
        {
            new Person
            {
                Id = Guid.NewGuid(),
                FirstName = "Jonte",
                LastName = "RD"
            }
        };

        public IList<Person> Read()
        {
            return Persons;
        }

        public void Update(Person person)
        {
            Persons.Remove(Persons.First(p => p.Id == person.Id));
            Persons.Add(new Person
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName
            });
        }
    }
}
