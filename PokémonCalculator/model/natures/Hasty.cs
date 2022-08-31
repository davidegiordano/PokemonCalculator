using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Hasty : Nature
    {
        private static Hasty _instance = null;
        private Hasty() : base(Natures.Hasty)
        {
            IncreasedStat = Stats.Speed;
            DecreasedStat = Stats.Defense;
        }
        public static Hasty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Hasty();
                }
                return _instance;
            }
        }
    }
}
