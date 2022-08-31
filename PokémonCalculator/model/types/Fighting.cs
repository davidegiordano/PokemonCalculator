using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Fighting : Type
    {
        private static Fighting _instance = null;
        private Fighting() : base(Types.Fighting)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Bug] = 0.5;
            chart[Types.Rock] = 0.5;
            chart[Types.Dark] = 0.5;
            chart[Types.Fairy] = 2;
            chart[Types.Flying] = 2;
            chart[Types.Psychic] = 2;
            this.SetChart(chart);
        }

        public static Fighting Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Fighting();
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
            resistances.Add(Types.Rock);
            resistances.Add(Types.Dark);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Fairy);
            weaknesses.Add(Types.Flying);
            weaknesses.Add(Types.Psychic);

            return weaknesses;
        }
    }
}
