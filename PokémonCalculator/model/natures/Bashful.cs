using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Bashful : Nature
    {
        private static Bashful _instance = null;
        private Bashful() : base(Natures.Bashful)
        {

        }

        public static Bashful Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Bashful();
                }
                return _instance;
            }
        }
    }
}
