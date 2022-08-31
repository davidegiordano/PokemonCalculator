using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.pokémon
{
    public class IV
    {
        private Dictionary<Stats, uint> _ivs;

        public IV(Dictionary<Stats, uint> ivs)
        {
            if (ivs == null || ivs.Count == 0)
            {
                throw new ArgumentNullException("Null IVs");
            }
            if (ivs.Count != 6)
            {
                throw new ArgumentException("IVs should include: HP, Atk, Def, SpA, SpD, Spe");
            }
            foreach (var v in ivs)
            {
                if (v.Value < 0 || v.Value > 31)
                {
                    throw new ArgumentException("IVs should be between 0 and 31");
                }
            }
            _ivs = ivs;
        }

        public static IV MaxIV()
        {
            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint> ();

            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                ivs.Add(stat, 31);
            }

            return new IV(ivs);
        }

        public static IV ZeroIV()
        {
            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint>();

            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                ivs.Add(stat, 0);
            }

            return new IV(ivs);
        }

        public Dictionary<Stats, uint> GetIVs()
        {
            return _ivs;
        }

        public uint GetHPIV()
        {
            return _ivs[Stats.HP];
        }
        public uint GetAttackIV()
        {
            return _ivs[Stats.Attack];
        }
        public uint GetDefenseIV()
        {
            return _ivs[Stats.Defense];
        }
        public uint GetSpecialAttackIV()
        {
            return _ivs[Stats.SpecialAttack];
        }
        public uint GetSpecialDefenseIV()
        {
            return _ivs[Stats.SpecialDefense];
        }
        public uint GetSpeedIV()
        {
            return _ivs[Stats.Speed];
        }
    }
}
