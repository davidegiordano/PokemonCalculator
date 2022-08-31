using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Flying : Type
    {
        private static Flying _instance = null;
        private Flying() : base(Types.Flying)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Ground] = 0;
            chart[Types.Fighting] = 0.5;
            chart[Types.Grass] = 0.5;
            chart[Types.Bug] = 0.5;
            chart[Types.Ice] = 2;
            chart[Types.Rock] = 2;
            chart[Types.Electric] = 2;
            this.SetChart(chart);
        }

        public static Flying Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Flying();
                }
                return _instance;
            }
        }

        public override List<Types> GetImmunities()
        {
            List<Types> immunities = new List<Types>();
            immunities.Add(Types.Ground);

            return immunities;
        }

        public override List<Types> GetResistances()
        {
            List<Types> resistances = new List<Types>();
            resistances.Add(Types.Fighting);
            resistances.Add(Types.Grass);
            resistances.Add(Types.Bug);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Ice);
            weaknesses.Add(Types.Rock);
            weaknesses.Add(Types.Electric);

            return weaknesses;
        }
    }
}
