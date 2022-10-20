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

    public MainService(IRepository repo)
    {
        _repo = repo;
    }

    public void Invoke()
    {
        var animals = _repo.Get();
        //var filteredAnimals = animals.Where(a => FilterAnimals(a));
        //var filteredAnimals = animals.Where(FilterAnimals);
        var filteredAnimals = animals.Where(a => a.Name == "Rover");        


        foreach (var animal in filteredAnimals)
        {
            Console.WriteLine(animal.Name);
        }
    }

    private bool FilterAnimals(Animal a)
    {
        return a.Name == "Rover";
    }
}
