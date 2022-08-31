using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Steel : Type
    {
        private static Steel _instance = null;
        private Steel() : base(Types.Steel)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Poison] = 0;
            chart[Types.Dragon] = 0.5;
            chart[Types.Fairy] = 0.5;
            chart[Types.Bug] = 0.5;
            chart[Types.Flying] = 0.5;
            chart[Types.Grass] = 0.5;
            chart[Types.Ice] = 0.5;
            chart[Types.Normal] = 0.5;
            chart[Types.Psychic] = 0.5;
            chart[Types.Rock] = 0.5;
            chart[Types.Steel] = 0.5;
            chart[Types.Fire] = 2;
            chart[Types.Fighting] = 2;
            chart[Types.Ground] = 2;
            this.SetChart(chart);
        }

        public static Steel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Steel();
                }
                return _instance;
            }
        }

        public override List<Types> GetImmunities()
        {
            List<Types> immunities = new List<Types>();
            immunities.Add(Types.Poison);

            return immunities;
        }

        public override List<Types> GetResistances()
        {
            List<Types> resistances = new List<Types>();
            resistances.Add(Types.Dragon);
            resistances.Add(Types.Fairy);
            resistances.Add(Types.Bug);
            resistances.Add(Types.Flying);
            resistances.Add(Types.Grass);
            resistances.Add(Types.Ice);
            resistances.Add(Types.Normal);
            resistances.Add(Types.Psychic);
            resistances.Add(Types.Rock);
            resistances.Add(Types.Steel);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Fire);
            weaknesses.Add(Types.Fighting);
            weaknesses.Add(Types.Ground);

            return weaknesses;
        }
    }
}
