using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLists
{
    public static class DogRollCall
    {
        public static void WriteToConsole(IEnumerable<Dog> dogs)
        {
            Console.WriteLine($"_______Dog Roll Call for: {dogs.Count()} Dogs______");
            foreach (var dog in dogs)
            {
                Console.WriteLine($"{dog.Breed} - {dog.Name} - {dog.Size}");
            }
            Console.WriteLine($"__________________End Roll Call____________________");
        }
    }
}
