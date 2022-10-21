using Class_9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9.Dao
{
    public interface IRepository<T> where T : Animal
    {
        void Add(T animal);
        IEnumerable<T> Get();
        T Search(string searchString);
    }
}
