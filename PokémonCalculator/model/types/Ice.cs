using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Ice : Type
    {
        private static Ice _instance = null;
        private Ice() : base(Types.Ice)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Ice] = 0.5;
            chart[Types.Fire] = 2;
            chart[Types.Steel] = 2;
            chart[Types.Fighting] = 2;
            chart[Types.Rock] = 2;
            this.SetChart(chart);
        }

        public static Ice Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Ice();
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
            resistances.Add(Types.Ice);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Fire);
            weaknesses.Add(Types.Steel);
            weaknesses.Add(Types.Fighting);
            weaknesses.Add(Types.Rock);

            return weaknesses;
        }
    }
}
