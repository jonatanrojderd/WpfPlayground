using System.Collections.Generic;
using System.Linq;
using WpfPlayground.Models;
using WpfPlayground.Repositories;

namespace WpfPlayground.ViewModels
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IPersonRepository _personRepository;

        public MainWindowViewModel(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
            Persons = new List<Person>(personRepository.Read());
            Names = new List<string>(Persons.Select(n => n.FullName));
        }

        public IList<Person> Persons { get; private set; }
        public IList<string> Names { get; private set; }
    }
}
