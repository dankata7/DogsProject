using DogApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogApp.Abstraction
{
    interface IDogServices
    {
       
        bool Create(string name, int age, string breed, string picture);

        bool UpdateDog(int dogid, string name, int age, string breed, string picture);

        List<Dog> GetDogs();

        Dog GetDogById(int dogId);

        bool RemoveById(int dogId);
    }
}
