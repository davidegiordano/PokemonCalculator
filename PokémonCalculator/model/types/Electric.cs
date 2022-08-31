using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Electric : Type
    {
        private static Electric _instance = null;
        private Electric() : base(Types.Electric)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Electric] = 0.5;
            chart[Types.Flying] = 0.5;
            chart[Types.Steel] = 0.5;
            chart[Types.Ground] = 2;
            this.SetChart(chart);
        }

        public static Electric Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Electric();
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
            resistances.Add(Types.Electric);
            resistances.Add(Types.Flying);
            resistances.Add(Types.Steel);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Ground);

            return weaknesses;
        }
    }
}
