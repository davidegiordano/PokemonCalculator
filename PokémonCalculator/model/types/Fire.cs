using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Fire : Type
    {
        private static Fire _instance = null;
        private Fire() : base(Types.Fire)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Fire] = 0.5;
            chart[Types.Bug] = 0.5;
            chart[Types.Grass] = 0.5;
            chart[Types.Fairy] = 0.5;
            chart[Types.Steel] = 0.5;
            chart[Types.Ice] = 0.5;
            chart[Types.Ground] = 2;
            chart[Types.Rock] = 2;
            chart[Types.Water] = 2;
            this.SetChart(chart);
        }

        public static Fire Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Fire();
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
            resistances.Add(Types.Bug);
            resistances.Add(Types.Fairy);
            resistances.Add(Types.Fire);
            resistances.Add(Types.Grass);
            resistances.Add(Types.Ice);
            resistances.Add(Types.Steel); 

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Ground);
            weaknesses.Add(Types.Rock);
            weaknesses.Add(Types.Water);

            return weaknesses;
        }
    }
}
