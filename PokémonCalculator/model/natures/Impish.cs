using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Impish : Nature
    {
        private static Impish _instance = null;
        private Impish() : base(Natures.Impish)
        {
            IncreasedStat = Stats.Defense;
            DecreasedStat = Stats.SpecialAttack;
        }

        public static Impish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Impish();
                }
                return _instance;
            }
        }
    }
}
