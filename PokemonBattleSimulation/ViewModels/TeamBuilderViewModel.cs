using Caliburn.Micro;
using PokemonBattleSimulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulation.ViewModels
{
    class TeamBuilderViewModel : Screen
    {
        private Battle _battle;
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

        #region UI Properties
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                NotifyOfPropertyChange(() => Id);
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }
        public Ability Ability
        {
            get => _ability;
            set
            {
                Ability = value;
                NotifyOfPropertyChange(() => Ability);
            }
        }
        public List<Move> Moves
        {
            get => _moves;
            set
            {
                _moves = value;
                NotifyOfPropertyChange(() => Moves);
            }
        }
        public List<int> Types
        {
            get => _types;
            set
            {
                _types = value;
                NotifyOfPropertyChange(() => Types);
            }
        }
        public int Hp
        {
            get => _hp;
            set
            {
                _hp = value;
                NotifyOfPropertyChange(() => Hp);
            }
        }
        public int Atk
        {
            get => _atk;
            set
            {
                _atk = value;
                NotifyOfPropertyChange(() => Atk);
            }
        }
        public int SpAtk
        {
            get => _sp_atk;
            set
            {
                _sp_atk = value;
                NotifyOfPropertyChange(() => SpAtk);
            }
        }
        public int Def
        {
            get => _def;
            set
            {
                _def = value;
                NotifyOfPropertyChange(() => Def);
            }
        }
        public int SpDef
        {
            get => _sp_def;
            set
            {
                _sp_def = value;
                NotifyOfPropertyChange(() => SpDef);
            }
        }
        public int Speed
        {
            get => _speed;
            set
            {
                _speed = value;
                NotifyOfPropertyChange(() => Speed);
            }
        }

        public Trainer PlayerTrainer
        {
            get => _battle.Trainers[0];
        }
        public Trainer EnemyTrainer
        {
            get => _battle.Trainers[1];
        }
        #endregion

        public TeamBuilderViewModel(Battle battle)
        {
            _battle = battle;
            battle.AddTrainer(new Trainer("Player Trainer"));
            battle.AddTrainer(new Trainer("Enemy Trainer"));
        }

        public void AddPokemonToPlayer()
        {
            var newPokemon = new Pokemon(_id, _name, _ability, _moves, _types, _hp, _atk, _sp_atk, _def, _sp_def, _speed);
            PlayerTrainer.AddPokemon(newPokemon);
        }

        public void AddPokemonToEnemy()
        {
            var newPokemon = new Pokemon(_id, _name, _ability, _moves, _types, _hp, _atk, _sp_atk, _def, _sp_def, _speed);
            EnemyTrainer.AddPokemon(newPokemon);
        }
    }
}
