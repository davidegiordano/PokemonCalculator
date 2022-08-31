using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Naughty : Nature
    {
        private static Naughty _instance = null;
        private Naughty() : base(Natures.Naughty)
        {
            IncreasedStat = Stats.Attack;
            DecreasedStat = Stats.SpecialDefense;
        }
        public static Naughty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Naughty();
                }
                return _instance;
            }
        }
    }
}
