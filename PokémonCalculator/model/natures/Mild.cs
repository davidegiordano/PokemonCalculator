using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Mild : Nature
    {
        private static Mild _instance = null;
        private Mild() : base(Natures.Mild)
        {
            IncreasedStat = Stats.SpecialAttack;
            DecreasedStat = Stats.Defense;
        }
        public static Mild Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Mild();
                }
                return _instance;
            }
        }
    }
}
