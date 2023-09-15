using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para4
{
    public class Dog
    {
        List<Dog> dogs = new List<Dog>();

        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
            dogs = new List<Dog>();
        }

        //Add dog method

        public void AddDog(Dog dog) 
        {
            dogs.Add(dog);
        }
    }
}
