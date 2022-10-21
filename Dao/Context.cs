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
        public List<Dog> Dogs { get; set; }
        public List<Cat> Cats { get; set; }

        public Context()
        {
            Dogs = new List<Dog>
            {
                new Dog {Name="Rover", DogOwner="Roger"},
                new Dog {Name="Spot", DogOwner="Scott"},
                new Dog {Name="Fido", DogOwner="Fred"},
                new Dog {Name="Arianna", DogOwner="Adam"},
                new Dog {Name="Breanna", DogOwner="Bert"},
                new Dog {Name="Snoopy", DogOwner="Charlie"},
                new Dog {Name="Duckie", DogOwner="Donald"},
                new Dog {Name="Eddie", DogOwner="Edwin"},
                new Dog {Name="Gertie", DogOwner="Gary"},
                new Dog {Name="Hank", DogOwner="Henry"},
                new Dog {Name="Sasha", DogOwner="Mark"}
            };
            Cats = new List<Cat>
            {
                new Cat {Name="Fluffy", CatOwner="Fifi"},
                new Cat {Name="Garfield", CatOwner="Jon"},
                new Cat {Name="Felix", CatOwner="Frank"},
                new Cat {Name="Mr Snuggles", CatOwner="Ainsley"},
                new Cat {Name="Capt Cuddles", CatOwner="Beth"},
                new Cat {Name="Loopy", CatOwner="Lynn"}
            };
        }

        public List<T> Set<T>()
        {
            var type = typeof(T);
            var contextTables = this.GetType().GetProperties();

            foreach (var property in contextTables)
            {
                if (property.Name.Contains(type.Name))
                {
                    var value = property.GetValue(this, null);
                    return (List<T>)value;
                }
            }

            return null;
        }
    }
}
