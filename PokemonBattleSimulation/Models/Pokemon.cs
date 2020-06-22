using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulation.Models
{
    class Pokemon
    {
        private int _id;
        private string _name;
        private Ability _ability;
        // handle items
        private List<Move> _moves;
        private List<int> _types;
        private int _hp;
        private int _atk;
        private int _sp_atk;
        private int _def;
        private int _sp_def;
        private int _speed;

        public Pokemon(int id, string name, Ability ability, List<Move> moves, List<int> types, int hp, int atk, int sp_atk, int def, int sp_def, int speed)
        {
            _id = id;
            _name = name;
            _ability = ability;
            _moves = new List<Move>();
            _types = new List<int>();
            _hp = hp;
            _atk = atk;
            _sp_atk = sp_atk;
            _def = def;
            _sp_def = sp_def;
            _speed = speed;
        }

        public void AddMove(Move move)
        {
            if (_moves.Count >= 4)
            {
                throw new Exception("Cannot Add More Than 4 Moves!");
            }
            else
            {
                _moves.Add(move);
            }
        }
        
        public void RemoveMove(Move move)
        {
            try
            {
                _moves.Remove(move);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
