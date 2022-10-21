using Class_9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9.Dao
{
    public class DataServiceFactory
    {
        public static TRepository GetRepositoryInstance<T, TRepository>() where TRepository : class, new()
        {
            return new TRepository();
        }
    }
}
