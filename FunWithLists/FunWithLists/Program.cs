// See https://aka.ms/new-console-template for more information
using FunWithLists;

Console.WriteLine("Hello, World!");
var theDogPound = new DogPound();

var goldenDoodle = new Dog { Breed = "Golden Doodle", Name = "Roma", Size = Size.Medium };
var poodle = new Dog { Breed = "Poodle", Name = "Yappy", Size = Size.Small };
var germanShepherd = new Dog { Breed = "German Shepherd", Name = "Chips", Size = Size.Large };

theDogPound.Add(goldenDoodle);
theDogPound.Add(poodle);
theDogPound.Add(germanShepherd);

DogRollCall.WriteToConsole(theDogPound);

//Removing the poodle at index 1
theDogPound.RemoveAt(1);

DogRollCall.WriteToConsole(theDogPound);

//Adding the poodle back
theDogPound.Add(poodle);

//Notice the poodle is now @ index 2 (3rd dog)
Console.WriteLine(theDogPound.IndexOf(poodle));

//Lets remove the german shephed by object reference now
theDogPound.Remove(germanShepherd);

//German shepherd is now gone.
DogRollCall.WriteToConsole(theDogPound);

//Let's add the German at a specific index this time
theDogPound.Insert(0, germanShepherd);

//Was the German Shepherd added?
if(theDogPound.Contains(germanShepherd))
{
    Console.WriteLine("Found the German Shepherd");
}

//Note the german shepherd should now be first
DogRollCall.WriteToConsole(theDogPound);

Console.ReadLine();