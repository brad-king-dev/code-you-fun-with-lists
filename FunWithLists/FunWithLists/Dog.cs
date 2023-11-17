using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLists
{
    public class Dog
    {
        public string Breed { get; set; }
        public string Name { get; set; }
        public Size Size { get; set; }
    }

    public enum Size { Undefined, Small, Medium, Large }
}
