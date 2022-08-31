using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Poison : Type
    {
        private static Poison _instance = null;
        private Poison() : base(Types.Poison)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Fighting] = 0.5;
            chart[Types.Poison] = 0.5;
            chart[Types.Bug] = 0.5;
            chart[Types.Grass] = 0.5;
            chart[Types.Fairy] = 0.5;
            chart[Types.Ground] = 2;
            chart[Types.Psychic] = 2;
            this.SetChart(chart);
        }

        public static Poison Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Poison();
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
            resistances.Add(Types.Poison);
            resistances.Add(Types.Bug);
            resistances.Add(Types.Grass);
            resistances.Add(Types.Fairy);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Ground);
            weaknesses.Add(Types.Psychic);

            return weaknesses;
        }
    }
}
