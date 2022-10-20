using Class_9.Dao;
using System;
using System.Linq;
using Class_9.Models;

namespace Class_9.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{
    private readonly IRepository _repo;

    //private Nullable<int> myInt;
    //private int? myInt2;

    public MainService(IRepository repo)
    {
        _repo = repo;
    }

    public void Invoke()
    {
        var animals = _repo.Get();

        var searchedAnimal = _repo.Search("Rover");
        Console.WriteLine(searchedAnimal.Name);
        Console.WriteLine("============");

        foreach (var animal in animals.OrderBy(a => a.Name))
        {
            Console.WriteLine(animal?.Name);
        }

        //var filteredAnimals = animals.Where(a => FilterAnimals(a));
        //var filteredAnimals = animals.Where(FilterAnimals);
        //var animal = animals.FirstOrDefault(a => a.Name == "Snoopy");

        var pageSize = 3;
        var page = 0;

        for (int i = 0; i < animals.Count/pageSize; i++)
        {
            var pagedAnimals = animals.Skip(page*pageSize).Take(pageSize);
            page++;

            foreach (var animal in pagedAnimals)
            {
                Console.WriteLine(animal?.Name);
            }
            Console.WriteLine("------");
        }
    }

    private bool FilterAnimals(Animal a)
    {
        return a.Name == "Rover";
    }
}
