using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.pokémon
{
    public class EV
    {
        private Dictionary<Stats, uint> _evs;

        public EV(Dictionary<Stats, uint> evs)
        {
            if (evs == null || evs.Count == 0)
            {
                throw new ArgumentNullException("Null EVs");
            }
            if (evs.Count != 6)
            {
                throw new ArgumentException("EVs should include: HP, Atk, Def, SpA, SpD, Spe");
            }
            uint total = 0;
            foreach (var v in evs)
            {
                total += v.Value;
                if (v.Value < 0 || v.Value > 252)
                {
                    throw new ArgumentException("EVs should be between 0 and 252");
                }
            }
            if (total > 510)
            {
                throw new ArgumentException("EVs should be at maximum 510");
            }
            _evs = evs;
        }

        public static EV ZeroEV()
        {
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();

            foreach (Stats stat in Enum.GetValues(typeof(Stats))){
                evs.Add(stat, 0);
            }

            return new EV(evs);
        }

        public Dictionary<Stats, uint> GetEVs()
        {
            return _evs;
        }

        public uint GetHPEV()
        {
            return _evs[Stats.HP];
        }
        public uint GetAttackEV()
        {
            return _evs[Stats.Attack];
        }
        public uint GetDefenseEV()
        {
            return _evs[Stats.Defense];
        }
        public uint GetSpecialAttackEV()
        {
            return _evs[Stats.SpecialAttack];
        }
        public uint GetSpecialDefenseEV()
        {
            return _evs[Stats.SpecialDefense];
        }
        public uint GetSpeedEV()
        {
            return _evs[Stats.Speed];
        }
    }
}
