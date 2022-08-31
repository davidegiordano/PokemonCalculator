using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Dragon : Type
    {
        private static Dragon _instance = null;
        private Dragon() : base(Types.Dragon)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Fire] = 0.5;
            chart[Types.Water] = 0.5;
            chart[Types.Grass] = 0.5;
            chart[Types.Electric] = 0.5;
            chart[Types.Dragon] = 2;
            chart[Types.Fairy] = 2;
            chart[Types.Ice] = 2;
            this.SetChart(chart);
        }

        public static Dragon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Dragon();
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
            resistances.Add(Types.Fire);
            resistances.Add(Types.Water);
            resistances.Add(Types.Grass);
            resistances.Add(Types.Electric);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Dragon);
            weaknesses.Add(Types.Fairy);
            weaknesses.Add(Types.Ice);

            return weaknesses;
        }
    }
}
