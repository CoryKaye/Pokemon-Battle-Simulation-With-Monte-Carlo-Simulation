using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using LiveCharts;
using LiveCharts.Wpf;
using PokemonBattleSimulation.Models;

namespace PokemonBattleSimulation.ViewModels
{
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive
    {
        private int _wins = 0;
        private int _loses = 0;
        private int _numSims = 10;
        private int _numSers = 0;
        private Battle _battle;
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        #region Properties
        public int Wins
        {
            get => _wins;
            set
            {
                _wins = value;
                NotifyOfPropertyChange(() => Wins);
            }
        }
        public int Loses
        {
            get => _loses;
            set
            {
                _loses = value;
                NotifyOfPropertyChange(() => Loses);
            }
        }
        public int NumSims
        {
            get => _numSims;
            set
            {
                _numSims = value;
                NotifyOfPropertyChange(() => NumSims);
            }
        }
        #endregion

        public ShellViewModel()
        {
            _battle = new Battle();
            ActivateTeamBuilderScreen();
        }

        //TODO: Activate TeamBuilderScreen
        public void ActivateTeamBuilderScreen()
        {
            ActivateItem(new TeamBuilderViewModel(_battle));
        }

        //TODO: Activate SimluationScreen
        public void ActivateSimulationScreen()
        {
            ActivateItem(new SimulationViewModel(_battle));
        }
    }
}
