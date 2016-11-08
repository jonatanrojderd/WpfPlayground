using System.Collections.Generic;
using WpfPlayground.Models;

namespace WpfPlayground.ViewModels
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IPersonRepository _personRepository;

        public MainWindowViewModel(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
            Names = new List<string>(personRepository.Read());
        }

        public IList<string> Names { get; private set; }
    }
}
