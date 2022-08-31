using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Rash : Nature
    {
        private static Rash _instance = null;
        private Rash() : base(Natures.Rash)
        {
            IncreasedStat = Stats.SpecialAttack;
            DecreasedStat = Stats.SpecialDefense;
        }
        public static Rash Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Rash();
                }
                return _instance;
            }
        }
    }
}
