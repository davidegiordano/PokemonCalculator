using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.types
{
    public enum Types
    {
        Normal,
        Fighting,
        Flying,
        Poison,
        Ground,
        Rock,
        Bug,
        Ghost,
        Steel,
        Fire,
        Water,
        Grass,
        Electric,
        Psychic,
        Ice,
        Dragon,
        Dark,
        Fairy
    }
    public abstract class Type
    {
        private Types _type;
        private Dictionary<Types, double> _chart;

        public Type(Types t)
        {
            _type = t;
            _chart = new Dictionary<Types, double>();

            foreach (var type in Enum.GetValues(typeof(Types)))
            {
                _chart.Add((Types) type, 1);
            }
        }

        public new Types GetType()
        {
            return _type;
        }

        public Dictionary<Types, double> GetChart()
        {
            return _chart;
        }
        protected void SetChart(Dictionary<Types, double> chart)
        {
            if(chart == null || chart.Count == 0)
            {
                throw new ArgumentException();
            }
            _chart = chart;
        }

        public override string ToString()
        {
            return _type.ToString();
        }

        public abstract List<Types> GetResistances();
        public abstract List<Types> GetWeaknesses();
        public abstract List<Types> GetImmunities();
    }
}
