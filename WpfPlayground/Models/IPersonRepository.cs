using System.Collections.Generic;

namespace WpfPlayground.Models
{
    public interface IPersonRepository
    {
        IList<string> Read();
    }
}