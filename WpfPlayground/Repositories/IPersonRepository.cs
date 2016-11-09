using System.Collections.Generic;
using WpfPlayground.Models;

namespace WpfPlayground.Repositories
{
    public interface IPersonRepository
    {
        IList<Person> Read();
    }
}