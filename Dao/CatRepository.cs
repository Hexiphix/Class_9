using Class_9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9.Dao
{
    public class CatRepository : IRepository
    {
        private Context _context;

        public CatRepository()
        {
            _context = new Context();
        }

        public void Add(Animal cat)
        {
            _context.Cats.Add(cat);
        }

        public List<Animal> Get()
        {
            return _context.Cats;
        }

        public Animal Search(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
