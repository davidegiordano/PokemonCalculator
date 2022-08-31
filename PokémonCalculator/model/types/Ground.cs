using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Ground : Type
    {
        private static Ground _instance = null;
        private Ground() : base(Types.Ground)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Electric] = 0;
            chart[Types.Poison] = 0.5;
            chart[Types.Rock] = 0.5;
            chart[Types.Ice] = 2;
            chart[Types.Water] = 2;
            chart[Types.Grass] = 2;
            this.SetChart(chart);
        }

        public static Ground Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Ground();
                }
                return _instance;
            }
        }

        public override List<Types> GetImmunities()
        {
            List<Types> immunities = new List<Types>();
            immunities.Add(Types.Electric); 

            return immunities;
        }

        public override List<Types> GetResistances()
        {
            List<Types> resistances = new List<Types>();
            resistances.Add(Types.Poison);
            resistances.Add(Types.Rock);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Grass);
            weaknesses.Add(Types.Ice);
            weaknesses.Add(Types.Water);

            return weaknesses;
        }
    }
}
