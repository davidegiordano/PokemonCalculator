using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Grass : Type
    {
        private static Grass _instance = null;
        private Grass() : base(Types.Grass)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Electric] = 0.5;
            chart[Types.Grass] = 0.5;
            chart[Types.Ground] = 0.5;
            chart[Types.Water] = 0.5;
            chart[Types.Fire] = 2;
            chart[Types.Ice] = 2;
            chart[Types.Flying] = 2;
            chart[Types.Bug] = 2;
            chart[Types.Poison] = 2;
            this.SetChart(chart);
        }

        public static Grass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Grass();
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
            resistances.Add(Types.Grass);
            resistances.Add(Types.Water);
            resistances.Add(Types.Ground);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Fire);
            weaknesses.Add(Types.Ice);
            weaknesses.Add(Types.Flying);
            weaknesses.Add(Types.Bug);
            weaknesses.Add(Types.Poison);

            return weaknesses;
        }
    }
}
