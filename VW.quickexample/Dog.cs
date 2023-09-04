using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW.quickexample
{
    public class Dog
    {
        private string _name;
        private string _breed;

        public Dog(string dogName, string dogBreed)
        {
            _name = dogName;
            _breed = dogBreed;
        }


        public string Name { get => _name; set => _name = value; }
        public string Breed { get => _breed; set => _breed = value; }

    }
}
