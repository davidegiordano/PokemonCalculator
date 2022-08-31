using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Rock : Type
    {
        private static Rock _instance = null;
        private Rock() : base(Types.Rock)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Fire] = 0.5;
            chart[Types.Flying] = 0.5;
            chart[Types.Normal] = 0.5;
            chart[Types.Poison] = 0.5;
            chart[Types.Grass] = 2;
            chart[Types.Water] = 2;
            chart[Types.Steel] = 2;
            chart[Types.Fighting] = 2;
            chart[Types.Ground] = 2;
            this.SetChart(chart);
        }

        public static Rock Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Rock();
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
            resistances.Add(Types.Flying);
            resistances.Add(Types.Normal);
            resistances.Add(Types.Poison);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Grass);
            weaknesses.Add(Types.Water);
            weaknesses.Add(Types.Steel);
            weaknesses.Add(Types.Fighting);
            weaknesses.Add(Types.Ground);

            return weaknesses;
        }
    }
}
