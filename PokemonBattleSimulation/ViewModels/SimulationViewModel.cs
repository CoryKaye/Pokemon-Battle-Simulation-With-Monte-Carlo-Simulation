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
    class SimulationViewModel : Screen
    {
        private Battle _battle;
        private int _wins = 0;
        private int _loses = 0;
        private int _numSims = 10;
        private int _numSers = 0;
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

        public SimulationViewModel(Battle battle)
        {
            _battle = battle;
            SeriesCollection = new SeriesCollection();

            YFormatter = value => value.ToString("P");
        }

        public async Task RunSeries()
        {
            Random random = new Random();
            var series = new LineSeries();
            series.Title = "Series " + _numSers.ToString();
            series.Values = new ChartValues<double>();
            Wins = 0;
            Loses = 0;

            //Run simulations for that series
            await Task.Run(() =>
            {
                for (int i = 0; i < NumSims; i++)
                {
                    if (random.Next(0, 2) == 0)
                    {
                        Wins++;
                    }
                    else
                    {
                        Loses++;
                    }

                    series.Values.Add(Wins / (Wins + (double)Loses));
                }
                SeriesCollection.Add(series);
            });

            _numSers++;
        }

        public void ClearRuns()
        {
            SeriesCollection.Clear();
        }
    }
}
