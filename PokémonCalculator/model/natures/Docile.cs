using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Docile : Nature
    {
        private static Docile _instance = null;
        private Docile() : base(Natures.Docile)
        {

        }

        public static Docile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Docile();
                }
                return _instance;
            }
        }
    }
}
