using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Naive : Nature
    {
        private static Naive _instance = null;
        private Naive() : base(Natures.Naive)
        {
            IncreasedStat = Stats.Speed;
            DecreasedStat = Stats.SpecialDefense;
        }
        public static Naive Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Naive();
                }
                return _instance;
            }
        }
    }
}
