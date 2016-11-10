using System;
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

            _updatePersonCommand = new RelayCommand(DoUpdatePerson, IsAnyPersonSelected);
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

        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                _updatePersonCommand.RaiseCanExecuteChanged();
                OnPropertyChanged();
            }
        }

        private readonly RelayCommand _updatePersonCommand;
        public ICommand UpdatePersonCommand => _updatePersonCommand;

        private void DoUpdatePerson()
        {
            _personRepository.Update(_selectedPerson);
            Persons = new ObservableCollection<Person>(_personRepository.Read());
        }

        private bool IsAnyPersonSelected()
        {
            return _selectedPerson != null;
        }
    }
}
