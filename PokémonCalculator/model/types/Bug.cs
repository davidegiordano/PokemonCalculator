using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public class Bug : Type
    {
        private static Bug _instance = null;

        private Bug() : base(Types.Bug)
        {
            Dictionary<Types, double> chart = this.GetChart();
            chart[Types.Fighting] = 0.5;
            chart[Types.Ground] = 0.5;
            chart[Types.Grass] = 0.5;
            chart[Types.Flying] = 2;
            chart[Types.Rock] = 2;
            chart[Types.Fire] = 2;
            this.SetChart(chart);
        }

        public static Bug Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Bug();
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
            resistances.Add(Types.Ground);
            resistances.Add(Types.Grass);

            return resistances;
        }

        public override List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();
            weaknesses.Add(Types.Flying);
            weaknesses.Add(Types.Rock);
            weaknesses.Add(Types.Fire);

            return weaknesses;
        }
    }
}
