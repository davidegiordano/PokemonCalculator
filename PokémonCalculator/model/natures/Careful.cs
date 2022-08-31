using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Careful : Nature
    {
        private static Careful _instance = null;
        private Careful() : base(Natures.Careful)
        {
            IncreasedStat = Stats.SpecialDefense;
            DecreasedStat = Stats.SpecialAttack;
        }
        public static Careful Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Careful();
                }
                return _instance;
            }
        }
    }
}
