using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Sassy : Nature
    {
        private static Sassy _instance = null;
        private Sassy() : base(Natures.Sassy)
        {
            IncreasedStat = Stats.SpecialDefense;
            DecreasedStat = Stats.Speed;
        }
        public static Sassy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Sassy();
                }
                return _instance;
            }
        }
    }
}
