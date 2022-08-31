using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Gentle : Nature
    {
        private static Gentle _instance = null;
        private Gentle() : base(Natures.Gentle)
        {
            IncreasedStat = Stats.SpecialDefense;
            DecreasedStat = Stats.Defense;
        }
        public static Gentle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Gentle();
                }
                return _instance;
            }
        }
    }
}
