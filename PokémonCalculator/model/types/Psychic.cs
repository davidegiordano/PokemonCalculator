using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Psychic : Type
    {
        private static Psychic _instance = null;
        private Psychic() : base(Types.Psychic)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Psychic] = 0.5;
            chart[Types.Fighting] = 0.5;
            chart[Types.Dark] = 2;
            chart[Types.Bug] = 2;
            chart[Types.Ghost] = 2;
            this.SetChart(chart);
        }

        public static Psychic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Psychic();
                }
                return _instance;
            }
        }

        public override List<Types> GetImmunities()
        {
            List<Types> immunities = new List<Types>();

            return immunities;
        }

        public override List<Types> GetResistances()
        {
            List<Types> resistances = new List<Types>();
            resistances.Add(Types.Fighting);
            resistances.Add(Types.Psychic);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Dark);
            weaknesses.Add(Types.Bug);
            weaknesses.Add(Types.Ghost);

            return weaknesses;
        }
    }
}
