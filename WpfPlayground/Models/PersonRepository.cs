using System.Collections.Generic;

namespace WpfPlayground.Models
{
    public class PersonRepository : IPersonRepository
    {
        public IList<string> Read()
        {
            return new List<string>
            {
                "Jonte",
                "Is This a Name?"
            };
        }
    }
}
