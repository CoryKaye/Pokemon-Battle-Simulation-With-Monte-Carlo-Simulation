using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulation.Models
{
    //Will be the "stage" of simulations
    class Battle
    {
        private List<Trainer> _trainers;
        private int _total_wins;
        private int _total_battles;

        public double WinPercentage
        {
            get => _total_wins / (double)_total_battles;
        }
        public List<Trainer> Trainers
        {
            get => _trainers;
        }

        public Battle()
        {
            _total_battles = 0;
            _total_wins = 0;
            _trainers = new List<Trainer>();
        }

        public void AddTrainer(Trainer trainer)
        {
            _trainers.Add(trainer);
        }

        public void RunBattle()
        {
            _total_battles++;

            //TODO: Logic for running a singular battle

        }
    }
}
