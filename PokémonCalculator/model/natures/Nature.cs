using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokémonCalculator.model.pokémon;

namespace PokémonCalculator.model.natures
{
    public enum Natures
    {
        Hardy,
        Lonely,
        Brave,
        Adamant,
        Naughty,
        Bold,
        Docile,
        Relaxed,
        Impish,
        Lax,
        Timid,
        Hasty,
        Serious,
        Jolly,
        Naive,
        Modest,
        Mild,
        Quiet,
        Bashful,
        Rash,
        Calm,
        Gentle,
        Sassy,
        Careful,
        Quirky
    }

    public abstract class Nature
    {
        private Natures _name;
        private Stats? _increasedStat = null;
        private Stats? _decreasedStat = null;

        public Nature(Natures n)
        {
            _name = n;
        }


        public Natures Name
        {
            get { return _name; }
        }

        public Stats? IncreasedStat
        {
            get { return _increasedStat; }
            protected set { _increasedStat = value; }
        }

        public Stats? DecreasedStat
        {
            get { return _decreasedStat; }
            protected set { _decreasedStat = value; }
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(_name.ToString());
            if (_increasedStat != null)
            {
                sb.Append(" (+" + _increasedStat.ToString());
            }
            if (_decreasedStat != null)
            {
                sb.Append(", -" + _decreasedStat.ToString() + ")");
            }

            return sb.ToString();
        }
    }
}
