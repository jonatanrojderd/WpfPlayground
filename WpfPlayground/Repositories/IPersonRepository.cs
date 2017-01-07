using System.Collections.Generic;
using WpfPlayground.Models;

namespace WpfPlayground.Repositories
{
    public interface IPersonRepository
    {
        void Create(string firstName, string lastName);
        IList<Person> Read();
        void Update(Person person);
        void Delete(Person person);
    }
}