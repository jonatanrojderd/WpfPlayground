using System.Collections.ObjectModel;
using WpfPlayground.Models;
using WpfPlayground.Repositories;

namespace WpfPlayground.ViewModels
{
    public class MainWindowViewModel : BindableBase, IMainWindowViewModel
    {
        private readonly IPersonRepository _personRepository;

        public MainWindowViewModel(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
            Persons = new ObservableCollection<Person>(personRepository.Read());
        }

        public ObservableCollection<Person> Persons { get; }

        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value; 
                OnPropertyChanged();
            }
        }
    }
}
