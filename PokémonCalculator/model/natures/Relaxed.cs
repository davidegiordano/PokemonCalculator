using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Relaxed : Nature
    {
        private static Relaxed _instance = null;
        private Relaxed() : base(Natures.Relaxed)
        {
            IncreasedStat = Stats.Defense;
            DecreasedStat = Stats.Speed;
        }
        public static Relaxed Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Relaxed();
                }
                return _instance;
            }
        }
    }
}
