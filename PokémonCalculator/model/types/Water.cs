using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Water : Type
    {
        private static Water _instance = null;
        private Water() : base(Types.Water)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Fire] = 0.5;
            chart[Types.Ice] = 0.5;
            chart[Types.Steel] = 0.5;
            chart[Types.Water] = 0.5;
            chart[Types.Grass] = 2;
            chart[Types.Electric] = 2;
            this.SetChart(chart);
        }

        public static Water Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Water();
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
            resistances.Add(Types.Ice);
            resistances.Add(Types.Steel);
            resistances.Add(Types.Water);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Grass);
            weaknesses.Add(Types.Electric);

            return weaknesses;
        }
    }
}
