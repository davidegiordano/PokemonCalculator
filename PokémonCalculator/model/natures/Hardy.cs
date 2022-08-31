using PokémonCalculator.model.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Hardy : Nature
    {
        private static Hardy _instance = null;
        private Hardy() : base(Natures.Hardy)
        {

        }
        public static Hardy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Hardy();
                }
                return _instance;
            }
        }
    }
}
