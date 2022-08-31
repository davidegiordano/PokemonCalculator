using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Jolly : Nature
    {
        private static Jolly _instance = null;
        private Jolly() : base(Natures.Jolly)
        {
            IncreasedStat = Stats.Speed;
            DecreasedStat = Stats.SpecialAttack;
        }
        public static Jolly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Jolly();
                }
                return _instance;
            }
        }
    }
}
