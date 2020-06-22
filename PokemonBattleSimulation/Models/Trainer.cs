using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulation.Models
{
    class Trainer
    {
        private string _name;
        private List<Pokemon> _team;

        public Trainer(string name)
        {
            _name = name;
            _team = new List<Pokemon>();
        }

        public void AddPokemon(Pokemon pokemon)
        {
            if (_team.Count >= 6)
            {
                throw new Exception("Team Cannot Contain More Than 6 Pokemon!");
            }
            else
            {
                _team.Add(pokemon);
            }
        }

        public void RemovePokemon(Pokemon pokemon)
        {
            try
            {
                _team.Remove(pokemon);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
