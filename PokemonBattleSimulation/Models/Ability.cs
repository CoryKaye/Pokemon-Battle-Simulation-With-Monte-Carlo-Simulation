using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulation.Models
{
    class Ability
    {
        private int _id;
        private string _name;

        public Ability(int id, string n)
        {
            _id = id;
            _name = n;
        }
    }
}
