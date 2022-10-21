using Class_9.Dao;
using System;
using System.Linq;
using Class_9.Models;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Class_9.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{
    private readonly IRepository<Dog> _dogRepo;
    private readonly IRepository<Cat> _catRepo;

    public MainService(IRepository<Dog> dogRepo, IRepository<Cat> catRepo)
    {
        _dogRepo = dogRepo;
        _catRepo = catRepo;
    }

    public void Invoke()
    {
        string userInput = null;
        do
        {
            Console.WriteLine("Choose your selection:");
            Console.WriteLine("1: List Dogs");
            Console.WriteLine("2: List Cats");
            Console.WriteLine("3: Search for a Pet by Name");
            Console.WriteLine("X: Exit");

            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    var dogs = _dogRepo.Get().ToList();
                    dogs.ForEach(x => Console.WriteLine(x.Name));
                    break;

                case "2":
                    var cats = _catRepo.Get().ToList();
                    cats.ForEach(x => Console.WriteLine(x.Name));
                    break;

                case "3":
                    Console.WriteLine("Enter the pet name:");
                    var petName = Console.ReadLine();

                    var dog = _dogRepo.Search(petName);
                    if (dog == null)
                    {
                        Console.WriteLine($"You didn't find a dog with name containing {petName}!");
                    }
                    else
                    {
                        Console.WriteLine($"You found a dog named {dog.Name}!");
                    }

                    var cat = _catRepo.Search(petName);
                    if (cat == null)
                    {
                        Console.WriteLine($"You didn't find a cat with name containing {petName}!");
                    }
                    else
                    {
                        Console.WriteLine($"You found a cat named {cat.Name}!");
                    }
                    break;

                default:
                    break;
            }
        } while (userInput != null && userInput != "X");
    }

}
