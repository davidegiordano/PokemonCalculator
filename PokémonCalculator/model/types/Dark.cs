using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Dark : Type
    {
        private static Dark _instance = null;
        private Dark() : base(Types.Dark)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Psychic] = 0;
            chart[Types.Dark] = 0.5;
            chart[Types.Ghost] = 0.5;
            chart[Types.Fighting] = 2;
            chart[Types.Bug] = 2;
            chart[Types.Fairy] = 2;
            this.SetChart(chart);
        }

        public static Dark Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Dark();
                }
                return _instance;
            }
        }

        public override List<Types> GetImmunities()
        {
            List<Types> immunities = new List<Types>();
            immunities.Add(Types.Psychic);

            return immunities;
        }

        public override List<Types> GetResistances()
        {
            List<Types> resistances = new List<Types>();
            resistances.Add(Types.Dark);
            resistances.Add(Types.Ghost);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Bug);
            weaknesses.Add(Types.Fairy);
            weaknesses.Add(Types.Fighting);

            return weaknesses;
        }
    }
}
