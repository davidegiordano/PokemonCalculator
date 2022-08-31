using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Lax : Nature
    {
        private static Lax _instance = null;
        private Lax() : base(Natures.Lax)
        {
            IncreasedStat = Stats.Defense;
            DecreasedStat = Stats.SpecialDefense;
        }
        public static Lax Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lax();
                }
                return _instance;
            }
        }
    }
}
