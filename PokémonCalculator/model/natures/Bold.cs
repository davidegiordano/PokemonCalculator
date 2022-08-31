using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Bold : Nature
    {
        private static Bold _instance = null;
        private Bold() : base(Natures.Bold)
        {
            IncreasedStat = Stats.Defense;
            DecreasedStat = Stats.Attack;
        }

        public static Bold Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Bold();
                }
                return _instance;
            }
        }
    }
}
