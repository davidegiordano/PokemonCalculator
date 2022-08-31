using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PokémonCalculator.model.pokémon
{
    public enum Stats
    {
        HP,
        Attack,
        Defense,
        [Display(Name = "Special Attack")]
        SpecialAttack,
        [Display(Name = "Special Defense")]
        SpecialDefense,
        Speed
    }

    public class BaseStats
    {
        private readonly Dictionary<Stats, uint> _baseStats;
        private readonly uint _totalStats;

        public BaseStats(Dictionary<Stats, uint> baseStats, uint total)
        {
            if (baseStats == null || baseStats.Count == 0)
            {
                throw new ArgumentNullException("Null base stats");
            }
            if (baseStats.Count != 6)
            {
                throw new ArgumentException("Base stats should include: HP, Atk, Def, SpA, SpD, Spe");
            }
            uint t = 0;
            foreach(var stat in baseStats)
            {
                t += stat.Value;
                if (stat.Value <= 0)
                {
                    throw new ArgumentException("Base stats cannot be <= 0");
                }
            }
            if (total != t) //Total
            {
                throw new ArgumentException("Error in Total Base Stats");
            } 
            _baseStats = baseStats;
            _totalStats = total;
        }

        public Dictionary<Stats, uint> GetBaseStats()
        {
            return _baseStats;
        }

        public uint GetHPBaseStats()
        {
            return _baseStats[Stats.HP];
        }
        public uint GetAttackBaseStats()
        {
            return _baseStats[Stats.Attack];
        }
        public uint GetDefenseBaseStats()
        {
            return _baseStats[Stats.Defense];
        }
        public uint GetSpecialAttackBaseStats()
        {
            return _baseStats[Stats.SpecialAttack];
        }
        public uint GetSpecialDefenseBaseStats()
        {
            return _baseStats[Stats.SpecialDefense];
        }
        public uint GetSpeedBaseStats()
        {
            return _baseStats[Stats.Speed];
        }

        public uint GetTotalStats()
        {
            return _totalStats;
        }
    }
}
