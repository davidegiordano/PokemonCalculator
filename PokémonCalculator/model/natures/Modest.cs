using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Modest : Nature
    {
        private static Modest _instance = null;
        private Modest() : base(Natures.Modest)
        {
            IncreasedStat = Stats.SpecialAttack;
            DecreasedStat = Stats.Attack;
        }
        public static Modest Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Modest();
                }
                return _instance;
            }
        }
    }
}
