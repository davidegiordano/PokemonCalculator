using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokémonCalculator.model.pokémon;

namespace PokémonCalculator.model.natures
{
    public class Lonely : Nature
    {
        private static Lonely _instance = null;
        private Lonely() : base(Natures.Lonely)
        {
            IncreasedStat = Stats.Attack;
            DecreasedStat = Stats.Defense;
        }
        public static Lonely Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lonely();
                }
                return _instance;
            }
        }
    }
}
