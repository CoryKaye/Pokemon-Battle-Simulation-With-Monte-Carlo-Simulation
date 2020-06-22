using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulation.Models
{
    class Move
    {
        private int _id;
        private string _name;
        private int _accuracy;
        private int _effect_chance;
        private int _pp;
        private int _power;
        private int _damage_class;
        private string _flavor_text;
        private string[] _stat_changes;
        public Move(int id, string name, int acc, int ec, int pp, int pow, int dc, string ft, string[] sc)
        {
            _id = id;
            _name = name;
            _accuracy = acc;
            _effect_chance = ec;
            _pp = pp;
            _power = pow;
            _damage_class = dc;
            _stat_changes = sc;
        }
    }
}
