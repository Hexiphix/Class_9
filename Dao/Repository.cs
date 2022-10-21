using Class_9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9.Dao
{
    public class Repository<T> : IRepository<T> where T : Animal
    {
        private Context _context;
        private List<T> animals;

        public Repository()
        {
            _context = new Context();
            animals = _context.Set<T>();
        }

        public void Add(T animal)
        {
            animals.Add(animal);
        }

        public IEnumerable<T> Get()
        {
            return animals;
        }

        public T Search(string searchString)
        {
            return animals.FirstOrDefault(a => a.Name.Contains(searchString, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
