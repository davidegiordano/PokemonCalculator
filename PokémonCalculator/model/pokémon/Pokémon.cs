using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PokémonCalculator.model.natures;
using PokémonCalculator.model.pokémon;
using PokémonCalculator.model.types;
using Type = PokémonCalculator.model.types.Type;

namespace PokémonCalculator.model.pokémon
{
    public class Pokémon
    {
        private readonly uint _id;
        private readonly uint _gen;
        private readonly List<Type> _type;
        private readonly string _name;
        private readonly Dictionary<Types, double> _chart;
        private uint _level;
        private readonly BaseStats _baseStats;
        private IV _ivs;
        private EV _evs;
        private Nature _nature;
        private Dictionary<Stats, uint> _stats;
        private List<Move> _moves;
        private uint _currentHP;

        public Pokémon(uint id, string n, List<Type> t, uint level, BaseStats baseStats, uint gen, IV ivs, EV evs, Nature nature, List<Move> moves) : this(id, n, t, level, baseStats, gen, ivs, evs, nature)
        {
            if (moves == null || moves.Count == 0)
            {
                throw new ArgumentNullException("A Pokémon must have at least a move");
            }
            if (moves.Count > 4)
            {
                throw new ArgumentException("A Pokémon must have at maximum 4 moves");
            }

            _moves = moves;
        }

        public Pokémon(uint id, string n, List<Type> t, uint level, BaseStats baseStats, uint gen, IV ivs, EV evs, Nature nature) : this(id, n, t, level, baseStats, gen)
        {
            if (ivs == null)
            {
                throw new ArgumentNullException("A Pokémon must have some IV");
            }
            if (evs == null)
            {
                throw new ArgumentNullException("A Pokémon must have some EV");
            }
            if (nature == null)
            {
                throw new ArgumentNullException("A Pokémon must have a nature");
            }

            _ivs = ivs;
            _evs = evs;
            _nature = nature;

            _stats = new Dictionary<Stats, uint>();
            CalculateStats();
            _currentHP = _stats[Stats.HP]; // max HP

            Move struggle = new Move(165, "Struggle", Normal.Instance, Category.Physical, 50, null,
                "This attack is used in desperation only if the user has no PP. It also damages the user a little.", 1, isFixedDamage: false);
            _moves = new List<Move>();
            _moves.Add(struggle);
        }

        public Pokémon(uint id, string n, List<Type> t, uint level, BaseStats baseStats, uint gen)
        {
            if (id == 0)
            {
                throw new ArgumentNullException("A Pokémon must have a positive id");
            }
            if (n.Trim() == "" || n == null)
            {
                throw new ArgumentNullException("A Pokémon must have a name");
            }
            if (t.Count == 0 || t == null)
            {
                throw new ArgumentNullException("A Pokémon must have at least a type");
            }
            if (t.Count > 2)
            {
                throw new ArgumentException("A Pokémon must have at maximum two types");
            }
            if (level <= 0 || level > 100)
            {
                throw new ArgumentException("A Pokémon must have a level between 1 and 100");
            }
            if (baseStats == null)
            {
                throw new ArgumentNullException("A Pokémon must have the base stats");
            }
            if (gen == 0 || gen > 8)
            {
                throw new ArgumentNullException("A Pokémon must belong to a Generation between 1 and 8");
            }
            _id = id;
            _gen = gen;
            _type = t;
            _name = n;
            _chart = new Dictionary<Types, double>();

            // 2 types
            if (t.Count == 2)
            {
                foreach (Types type in Enum.GetValues(typeof(Types)))
                {
                    _chart[type] = _type.ElementAt(0).GetChart()[type] *
                    _type.ElementAt(1).GetChart()[type]; // modifier1 * modifier2
                }
            }
            else
            {
                foreach (Types type in Enum.GetValues(typeof(Types)))
                {
                    _chart[type] = _type.ElementAt(0).GetChart()[type];
                }
            }

            _level = level;
            _baseStats = baseStats;
            _ivs = IV.ZeroIV();
            _evs = EV.ZeroEV();
            _nature = Hardy.Instance;

            _stats = new Dictionary<Stats, uint>();
            CalculateStats();
            _currentHP = _stats[Stats.HP]; // max HP

            Move struggle = new Move(165, "Struggle", Normal.Instance, Category.Physical, 50, null,
                "This attack is used in desperation only if the user has no PP. It also damages the user a little.", 1, isFixedDamage: false);
            _moves = new List<Move>();
            _moves.Add(struggle);
        }

        public Pokémon(uint id, string n, List<Type> t, BaseStats baseStats, uint gen)
        {
            if (id == 0)
            {
                throw new ArgumentNullException("A Pokémon must have a positive id");
            }
            if (n == "" || n == null)
            {
                throw new ArgumentNullException("A Pokémon must have a name");
            }
            if (t.Count == 0 || t == null)
            {
                throw new ArgumentNullException("A Pokémon must have at least a type");
            }
            if (t.Count > 2)
            {
                throw new ArgumentException("A Pokémon must have at maximum two types");
            }
            if (baseStats == null)
            {
                throw new ArgumentNullException("A Pokémon must have the base stats");
            }
            if (gen == 0 || gen > 8)
            {
                throw new ArgumentNullException("A Pokémon must belong to a Generation between 1 and 8");
            }
            _id = id;
            _gen = gen;
            _type = t;
            _name = n;
            _level = 50;
            _chart = new Dictionary<Types, double>();

            // 2 types
            if (t.Count == 2)
            {
                foreach (Types type in Enum.GetValues(typeof(Types)))
                {
                    _chart[type] = _type.ElementAt(0).GetChart()[type] *
                    _type.ElementAt(1).GetChart()[type]; // modifier1 * modifier2
                }
            }
            else
            {
                foreach (Types type in Enum.GetValues(typeof(Types)))
                {
                    _chart[type] = _type.ElementAt(0).GetChart()[type];
                }
            }

            _baseStats = baseStats;
            _ivs = IV.ZeroIV();
            _evs = EV.ZeroEV();
            _nature = Hardy.Instance;

            _stats = new Dictionary<Stats, uint>();
            CalculateStats();
            _currentHP = _stats[Stats.HP]; // max HP

            Move struggle = new Move(165, "Struggle", Normal.Instance, Category.Physical, 50, null,
                "This attack is used in desperation only if the user has no PP. It also damages the user a little.", 1, isFixedDamage: false);
            _moves = new List<Move>();
            _moves.Add(struggle);
        }

        public uint ID
        {
            get { return _id; }
        }

        public uint Gen
        {
            get { return _gen; }
        }

        public List<Type> Type
        {
            get { return _type; }
        }

        public string Name
        {
            get { return _name; }
        }

        public uint Level
        {
            get { return _level; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentException("A Pokémon must have a level between 1 and 100");
                }
                _level = value;
                CalculateStats(); //Recalculate stats
            }
        }
        public Nature Nature
        {
            get { return _nature; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Inserted nature is null");
                }
                _nature = value;
                CalculateStats(); //Recalculate stats
            }
        }

        public Dictionary<Types, double> GetChart()
        {
            return _chart;
        }

        public IV GetIVs()
        {
            return _ivs;
        }
        public EV GetEVs()
        {
            return _evs;
        }

        public void SetIVs(IV ivs)
        {
            if (ivs == null)
            {
                throw new ArgumentNullException("Inserted IVs are null");
            }
            _ivs = ivs;
            CalculateStats(); //Recalculate stats
        }
        public void SetEVs(EV evs)
        {
            if (evs == null)
            {
                throw new ArgumentNullException("Inserted EVs are null");
            }
            _evs = evs;
            CalculateStats(); //Recalculate stats
        }
        public uint GetTotalIV()
        {
            uint result = 0;

            foreach (Stats stat in _ivs.GetIVs().Keys){
                result += _ivs.GetIVs()[stat];
            }

            return result;
        }
        public uint GetTotalEV()
        {
            uint result = 0;

            foreach (Stats stat in _evs.GetEVs().Keys)
            {
                result += _evs.GetEVs()[stat];
            }

            return result;
        }

        public uint CurrentHP
        {
            get { return _currentHP; }
            set
            {
                if (value > _currentHP)
                {
                    _currentHP = 0;
                }
                else
                {
                    _currentHP = value;
                }
            }
        }

        public uint HP
        {
            get { return _stats[Stats.HP]; }
        }
        public uint Attack
        {
            get { return _stats[Stats.Attack]; }
        }
        public uint Defense
        {
            get { return _stats[Stats.Defense]; }
        }
        public uint SpecialAttack
        {
            get { return _stats[Stats.SpecialAttack]; }
        }
        public uint SpecialDefense
        {
            get { return _stats[Stats.SpecialDefense]; }
        }
        public uint Speed
        {
            get { return _stats[Stats.Speed]; }
        }
        public BaseStats BaseStats { get { return _baseStats; } }
        public uint BaseStatTotal
        {
            get { return _baseStats.GetTotalStats(); }
        }

        public List<Move> Moves
        {
            get { return _moves; }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentNullException("A Pokémon must have at least a move");
                }
                if (value.Count > 4)
                {
                    throw new ArgumentException("A Pokémon must have at maximum 4 moves");
                }
                _moves = value;
            }
        }

        public List<Types> GetImmunities()
        {
            List<Types> immunities = new List<Types>();

            foreach (Type t in _type)
            {
                immunities.AddRange(t.GetImmunities());
            }

            return immunities.Distinct().ToList();
        }

        public List<Types> GetResistances()
        {
            List<Types> resistances = new List<Types>();

            foreach (Type t in _type)
            {
                resistances.AddRange(t.GetResistances());
            }
            foreach (Type t in _type)
            {
                resistances.RemoveAll(c => t.GetWeaknesses().Contains(c));
                resistances.RemoveAll(c => t.GetImmunities().Contains(c));
            }

            return resistances.Distinct().ToList();
        }

        public List<Types> GetWeaknesses()
        {
            List<Types> weaknesses = new List<Types>();

            foreach (Type t in _type)
            {
                weaknesses.AddRange(t.GetWeaknesses());
            }
            foreach (Type t in _type)
            {
                weaknesses.RemoveAll(c => t.GetResistances().Contains(c));
                weaknesses.RemoveAll(c => t.GetImmunities().Contains(c));
            }

            return weaknesses.Distinct().ToList();
        }

        private void CalculateStats()
        {
            _stats = new Dictionary<Stats, uint>();
            uint value;
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                if (stat == Stats.HP)
                {
                    uint floor = (uint)Math.Floor((2 * _baseStats.GetHPBaseStats() + _ivs.GetHPIV() + Math.Floor((double)_evs.GetHPEV() / 4)) * _level / 100);
                    value = floor + _level + 10;

                    _stats.Add(Stats.HP, value);
                }
                else
                {
                    uint innerFloor;
                    if (stat == _nature.IncreasedStat)
                    {
                        innerFloor = (uint)Math.Floor((2 * _baseStats.GetBaseStats()[stat] + _ivs.GetIVs()[stat] + Math.Floor((double)_evs.GetEVs()[stat] / 4)) * _level / 100);
                        value = (uint)Math.Floor((innerFloor + 5) * 1.1);
                    }
                    else if (stat == _nature.DecreasedStat)
                    {
                        innerFloor = (uint)Math.Floor((2 * _baseStats.GetBaseStats()[stat] + _ivs.GetIVs()[stat] + Math.Floor((double)_evs.GetEVs()[stat] / 4)) * _level / 100);
                        value = (uint)Math.Floor((innerFloor + 5) * 0.9);
                    }
                    else
                    {
                        innerFloor = (uint)Math.Floor((2 * _baseStats.GetBaseStats()[stat] + _ivs.GetIVs()[stat] + Math.Floor((double)_evs.GetEVs()[stat] / 4)) * _level / 100);
                        value = (uint)Math.Floor((double)innerFloor + 5);
                    }
                    _stats.Add(stat, value);
                }
            }
        }

        public override string ToString()
        {
            return _name;
        }

        public string VerboseToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Pokémon " + Name + " of type ");

            foreach (Type t in _type)
            {
                sb.Append(t.ToString());
                sb.Append(" ");
            }
            sb.Append("level " + _level);

            sb.Append(" is weak to");
            foreach (Types t in GetWeaknesses())
            {
                sb.Append(" " + t.ToString());
            }
            sb.Append(" is resistant to");
            if (GetResistances().Count != 0)
            {
                foreach (Types t in GetResistances())
                {
                    sb.Append(" " + t.ToString());
                }
            }
            else
            {
                sb.Append(" None");
            }
            sb.Append(" and is immune to");
            if (GetImmunities().Count != 0)
            {
                foreach (Types t in GetImmunities())
                {
                    sb.Append(" " + t.ToString());
                }
            }
            else
            {
                sb.Append(" None");
            }
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine("Type effectiveness:");
            sb.AppendLine();

            var sortedChart = from entry in _chart orderby entry.Value descending select entry;
            foreach (var value in sortedChart)
            {
                sb.AppendLine(value.ToString());
            }
            sb.AppendLine();
            sb.AppendLine("\tBase  \tIVs  \tEVs");
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                if (stat == Stats.SpecialAttack)
                {
                    sb.AppendLine("SpA" + "\t" + _baseStats.GetSpecialAttackBaseStats() + "\t" + _ivs.GetSpecialAttackIV() + "\t" + _evs.GetSpecialAttackEV() + "\t" + _stats[Stats.SpecialAttack]);
                }
                else if (stat == Stats.SpecialDefense)
                {
                    sb.AppendLine("SpD" + "\t" + _baseStats.GetSpecialDefenseBaseStats() + "\t" + _ivs.GetSpecialDefenseIV() + "\t" + _evs.GetSpecialDefenseEV() + "\t" + _stats[Stats.SpecialDefense]);
                }
                else
                {
                    sb.AppendLine(stat.ToString() + "\t" + _baseStats.GetBaseStats()[stat] + "\t" + _ivs.GetIVs()[stat] + "\t" + _evs.GetEVs()[stat] + "\t" + _stats[stat]);
                }
            }
            sb.AppendLine("Total\t" + _baseStats.GetTotalStats());

            sb.AppendLine();
            sb.AppendLine("Moves:");
            sb.AppendLine();
            sb.AppendLine("Name\t\tType\t  Category\t  PP\tPower\tAccuracy\tDescription");
            sb.AppendLine(String.Join("\t \n", _moves));

            return sb.ToString();
        }
    }
}
