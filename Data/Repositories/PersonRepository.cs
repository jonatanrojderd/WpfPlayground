using System;
using System.Collections.Generic;
using System.Linq;
using Data.Context;
using WpfPlayground.Models;

namespace WpfPlayground.Repositories
{
    public class PersonRepository : IPersonRepository
    {

        public void Create(string firstName, string lastName)
        {
            using (var context = new DatabaseContext())
            {
                context.Persons.Add(new Person
                {
                    Id = Guid.NewGuid(),
                    FirstName = firstName,
                    LastName = lastName
                });
                context.SaveChanges();
            }
        }

        public IList<Person> Read()
        {
            using (var context = new DatabaseContext())
            {
                return context.Persons.ToList();
            }
        }

        public void Update(Person person)
        {
            using (var context = new DatabaseContext())
            {
                var update = context.Persons.First(p => p.Id == person.Id);
                update.FirstName = person.FirstName;
                update.LastName = person.LastName;

                context.SaveChanges();
            }
        }

        public void Delete(Person person)
        {
            using (var context = new DatabaseContext())
            {
                var delete = context.Persons.First(p => p.Id == person.Id);

                context.Persons.Remove(delete);
                context.SaveChanges();
            }
        }
    }
}
