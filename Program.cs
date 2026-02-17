using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._02._26_Структуры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var village = new Village("Tiro");
            Console.WriteLine(village.People[0].HairColor);
        }
    }

    public struct Person
    {
        private string _gender;
        private string _hairColor;
        private bool _hat;
        private bool _facialHair;
        private string _equipment;

        public string Gender => _gender;
        public string HairColor => _hairColor;
        public bool Hat => _hat;
        public bool FacialHair => _facialHair;
        public string Equipment => _equipment;
        
        public Person(string gender,  string hairColor, bool hat, bool facialHair, string equipment)
        {
            _gender = gender;
            _hairColor = hairColor;
            _hat = hat;
            _facialHair = facialHair;
            _equipment = equipment;
        }

        public void Print()
        {
            Console.WriteLine($"{_gender} {_hairColor} {_hat} {_facialHair} {_equipment}");
        }
    }

    public struct Village
    {
        private string _name;
        private Person[] _people;

        public Person[] People => _people;

        public Village(string name)
        {
            _name = name;
            _people = new Person[]
            {
                new Person("male", "black", true, true, "stick"),
                new Person("male", "gray", true, false, "bag"),
                new Person("female", "red", false, false, "bag"),
                new Person("female", "black", true, false, "none"),
                new Person("male", "black", true, true, "bucket"),
                new Person("female", "black", true, false, "none"),
                new Person("male", "brown", true, false, "stick"),
                new Person("female", "gray", true, false, "none"),
            };
        }

    }
}
