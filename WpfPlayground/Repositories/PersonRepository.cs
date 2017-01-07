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

        public void Create(string firstName, string lastName)
        {
            Persons.Add(new Person
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName
            });
        }

        public IList<Person> Read()
        {
            return Persons;
        }

        public void Update(Person person)
        {
            var update = Persons.First(p => p.Id == person.Id);
            update.FirstName = person.FirstName;
            update.LastName = person.LastName;
        }

        public void Delete(Person person)
        {
            Persons.Remove(Persons.First(p => p.Id == person.Id));
        }
    }
}
