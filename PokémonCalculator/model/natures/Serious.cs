using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Serious : Nature
    {
        private static Serious _instance = null;
        private Serious() : base(Natures.Serious)
        {

        }
        public static Serious Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Serious();
                }
                return _instance;
            }
        }
    }
}
