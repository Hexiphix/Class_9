﻿using Class_9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9.Dao
{
    public class DogRepository : IRepository<Dog>
    {
        private Context _context;

        public DogRepository()
        {
            _context = new Context();
        }

        public void Add(Animal dog)
        {
            _context.Dogs.Add(dog);
        }

        public List<Animal> Get()
        {
            return _context.Dogs;
        }

        public Animal Search(string searchString)
        {
            return _context.Dogs.First(a => a.Name == searchString);
        }
    }
}
