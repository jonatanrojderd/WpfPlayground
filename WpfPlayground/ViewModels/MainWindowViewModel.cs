using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            Persons = new ObservableCollection<Person>(personRepository.Read());
            Names = new List<string>(Persons.Select(p => p.FullName));
        }

        public ObservableCollection<Person> Persons { get; private set; }
        public IList<string> Names { get; private set; }
    }
}
