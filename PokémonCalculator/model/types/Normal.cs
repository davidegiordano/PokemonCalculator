using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Normal : Type
    {
        private static Normal _instance = null;
        private Normal() : base(Types.Normal)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Ghost] = 0;
            chart[Types.Fighting] = 2;
            this.SetChart(chart);
        }

        public static Normal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Normal();
                }
                return _instance;
            }
        }

        public override List<Types> GetImmunities()
        {
            List<Types> immunities = new List<Types>();
            immunities.Add(Types.Ghost);

            return immunities;
        }

        public override List<Types> GetResistances()
        {
            List<Types> resistances = new List<Types>();

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Fighting);

            return weaknesses;
        }
    }
}
