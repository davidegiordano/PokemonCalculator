using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Adamant : Nature
    {
        private static Adamant _instance = null;
        private Adamant() : base(Natures.Adamant)
        {
            IncreasedStat = Stats.Attack;
            DecreasedStat = Stats.SpecialAttack;
        }

        public static Adamant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Adamant();
                }
                return _instance;
            }
        }
    }
}
