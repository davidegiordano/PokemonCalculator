using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Ghost : Type
    {
        private static Ghost _instance = null;
        private Ghost() : base(Types.Ghost)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Normal] = 0;
            chart[Types.Fighting] = 0;
            chart[Types.Poison] = 0.5;
            chart[Types.Bug] = 0.5;
            chart[Types.Dark] = 2;
            chart[Types.Ghost] = 2;
            this.SetChart(chart);
        }

        public static Ghost Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Ghost();
                }
                return _instance;
            }
        }

        public override List<Types> GetImmunities()
        {
            List<Types> immunities = new List<Types>();
            immunities.Add(Types.Normal);
            immunities.Add(Types.Fighting);

            return immunities;
        }

        public override List<Types> GetResistances()
        {
            List<Types> resistances = new List<Types>();
            resistances.Add(Types.Poison);
            resistances.Add(Types.Bug);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Dark);
            weaknesses.Add(Types.Ghost);

            return weaknesses;
        }
    }
}
