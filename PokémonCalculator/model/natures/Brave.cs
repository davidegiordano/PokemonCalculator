using PokémonCalculator.model.natures;
using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Brave : Nature
    {
        private static Brave _instance = null;
        private Brave() : base(Natures.Brave)
        {
            IncreasedStat = Stats.Attack;
            DecreasedStat = Stats.Speed;
        }
        public static Brave Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Brave();
                }
                return _instance;
            }
        }
    }
}
