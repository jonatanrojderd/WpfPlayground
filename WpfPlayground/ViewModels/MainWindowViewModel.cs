using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfPlayground.Commands;
using WpfPlayground.Models;
using WpfPlayground.Repositories;

namespace WpfPlayground.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, IMainWindowViewModel
    {
        private readonly IPersonRepository _personRepository;

        public MainWindowViewModel(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
            Persons = new ObservableCollection<Person>(personRepository.Read());

            _addPersonCommand = new RelayCommand(DoAddPerson, CheckIfEmpty);
            _updatePersonCommand = new RelayCommand(DoUpdatePerson, IsAnyPersonSelected);
            _removePersonCommand = new RelayCommand(DoRemovePerson, IsAnyPersonSelected);
        }

        private ObservableCollection<Person> _persons;
        public ObservableCollection<Person> Persons
        {
            get
            {
                return _persons;
            }
            set
            {
                _persons = value;
                OnPropertyChanged();
            }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;

                if (_selectedPerson != null)
                {
                    FirstName = _selectedPerson.FirstName;
                    LastName = _selectedPerson.LastName;
                }

                _updatePersonCommand.RaiseCanExecuteChanged();
                OnPropertyChanged();
            }
        }

        private readonly RelayCommand _addPersonCommand;
        public ICommand AddPersonCommand => _addPersonCommand;

        private void DoAddPerson()
        {
            _personRepository.Create(FirstName, LastName);
            
            CleanUp();
        }

        private readonly RelayCommand _updatePersonCommand;
        public ICommand UpdatePersonCommand => _updatePersonCommand;

        private void DoUpdatePerson()
        {
            _selectedPerson.FirstName = _firstName;
            _selectedPerson.LastName = _lastName;
            _personRepository.Update(_selectedPerson);

            CleanUp();
        }

        private readonly RelayCommand _removePersonCommand;
        public ICommand RemovePersonCommand => _removePersonCommand;

        private void DoRemovePerson()
        {
            _personRepository.Delete(_selectedPerson);

            CleanUp();
        }

        private void CleanUp()
        {
            Persons = new ObservableCollection<Person>(_personRepository.Read());

            SelectedPerson = null;
            FirstName = "";
            LastName = "";
        }

        private bool IsAnyPersonSelected()
        {
            return _selectedPerson != null;
        }

        private bool CheckIfEmpty()
        {
            return !string.IsNullOrWhiteSpace(_firstName)
                && !string.IsNullOrWhiteSpace(_lastName)
                && !IsAnyPersonSelected();
        }
    }
}
