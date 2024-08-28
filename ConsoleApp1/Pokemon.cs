using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSkarpC
{
    public class Pokemon
    {
        public string Name;
        public int Level;
        public int Health;

        public void ShowPokemon()
        {
            Console.WriteLine($"{Name} har {Health}HP og er level {Level}");
        }

        public Pokemon(string name, int level = 0, int health = 1000)
        {
            Name = name;
            Level = level;
            Health = health;
            
        }
        //public Pokemon(string name)
        //{
        //    Name = name;

        //}
    }
}
