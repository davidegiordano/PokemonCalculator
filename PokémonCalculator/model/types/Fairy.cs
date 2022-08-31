using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Fairy : Type
    {
        private static Fairy _instance = null;
        private Fairy() : base(Types.Fairy)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Dragon] = 0;
            chart[Types.Fighting] = 0.5;
            chart[Types.Dark] = 0.5;
            chart[Types.Bug] = 0.5;
            chart[Types.Poison] = 2;
            chart[Types.Steel] = 2;
            this.SetChart(chart);
        }

        public static Fairy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Fairy();
                }
                return _instance;
            }
        }

        public override List<Types> GetImmunities()
        {
            List<Types> immunities = new List<Types>();
            immunities.Add(Types.Dragon);

            return immunities;
        }

        public override List<Types> GetResistances()
        {
            List<Types> resistances = new List<Types>();
            resistances.Add(Types.Fighting);
            resistances.Add(Types.Dark);
            resistances.Add(Types.Bug);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Poison);
            weaknesses.Add(Types.Steel);

            return weaknesses;
        }
    }
}
