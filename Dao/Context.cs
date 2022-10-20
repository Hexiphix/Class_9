using Class_9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9.Dao
{
    public class Context
    {
        public List<Animal> Dogs { get; set; }
        public List<Animal> Cats { get; set; }

        public Context()
        {
            Dogs = new List<Animal>
            {
                new Dog {Name="Rover", DogOwner="Roger"},
                new Dog {Name="Spot", DogOwner="Scott"},
                new Dog {Name="Fido", DogOwner="Fred"}
            };
            Cats = new List<Animal>
            {
                new Cat {Name="Fluffy", CatOwner="Fifi"},
                new Cat {Name="Garfield", CatOwner="Jon"},
                new Cat {Name="Felix", CatOwner="Frank"}
            };
        }
    }
}
