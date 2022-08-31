using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Calm : Nature
    {
        private static Calm _instance = null;
        private Calm() : base(Natures.Calm)
        {
            IncreasedStat = Stats.SpecialDefense;
            DecreasedStat = Stats.Attack;
        }
        public static Calm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Calm();
                }
                return _instance;
            }
        }
    }
}
