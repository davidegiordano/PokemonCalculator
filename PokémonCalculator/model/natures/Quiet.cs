using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Quiet : Nature
    {
        private static Quiet _instance = null;
        private Quiet() : base(Natures.Quiet)
        {
            IncreasedStat = Stats.SpecialAttack;
            DecreasedStat = Stats.Speed;
        }
        public static Quiet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Quiet();
                }
                return _instance;
            }
        }
    }
}
