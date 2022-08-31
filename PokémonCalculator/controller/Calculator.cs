using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokémonCalculator.model.pokémon;
using PokémonCalculator.model.natures;
using Type = PokémonCalculator.model.types.Type;
using PokémonCalculator.view;
using PokémonCalculator.persistence;

namespace PokémonCalculator.controller
{
    public class Calculator : IController
    {
        private ParsePokémon _parsePokémon;
        private ParseMoves _parseMoves;
        private ListNatures _listNatures;
        private Pokémon _pokémon1;
        private Pokémon _pokémon2;
        private static Random _random = new Random();
        private static Calculator _instance = null;


        public static Calculator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Calculator(ParsePokémon.Instance.GetPokémonByName("Abomasnow"), ParsePokémon.Instance.GetPokémonByName("Abomasnow"));
                }

                return _instance;
            }
        }

        private Calculator(Pokémon pokémon1, Pokémon pokémon2)
        {
            if (pokémon1 == null || pokémon2 == null)
            {
                throw new ArgumentNullException("Null Pokémon");
            }
            _pokémon1 = pokémon1;
            _pokémon2 = pokémon2;
            _parsePokémon = ParsePokémon.Instance;
            _parseMoves = ParseMoves.Instance;
            _listNatures = ListNatures.Instance;
        }

        public string CalculateDamageFrom1To2(string m)
        {
            if (m == null || m.Trim() == "")
            {
                throw new ArgumentNullException("Null move");
            }

            Move move = _parseMoves.GetMoveByName(m);

            if (!_pokémon1.Moves.Contains(move))
            {
                throw new ArgumentException(_pokémon1.Name + " doesn't know " + move.Name);
            }
            if (move.Category == Category.Status)
            {
                throw new ArgumentException("Status moves don't generate damage");
            }

            uint damage;
            StringBuilder sb = new StringBuilder();

            if (!move.IsFixedDamage)
            {
                uint partial;
                uint minDamage, maxDamage;
                double stab = 1;
                if (_pokémon1.Type.Contains(move.Type))
                {
                    stab = 1.5;
                }
                double roll = _random.NextDouble() * (1 - 0.85) + 0.85;
                double typeEff = _pokémon2.GetChart()[move.Type.GetType()];


                //damage = ( ( ( ( 2 * level / 5 ) + 2 ) * power * A/D ) / 50 ) + 2 )
                //    * targets * PB * Weather * Critical * random * STAB * Type * Burn * other * ZMove
                if (move.Category == Category.Physical)
                {
                    uint p1 = 2 * _pokémon1.Level / 5 + 2;
                    partial = (uint)(p1 * move.Power * _pokémon1.Attack / _pokémon2.Defense / 50 + 2);
                    damage = (uint)(partial * stab * roll * typeEff);
                    minDamage = (uint)(partial * stab * 0.849f * typeEff);
                    maxDamage = (uint)(partial * stab * 1 * typeEff);
                }
                else
                {
                    uint p1 = 2 * _pokémon1.Level / 5 + 2;
                    partial = (uint)(p1 * move.Power * _pokémon1.SpecialAttack / _pokémon2.SpecialDefense / 50 + 2);
                    damage = (uint)(partial * stab * roll * typeEff);
                    minDamage = (uint)(partial * stab * 0.849f * typeEff);
                    maxDamage = (uint)(partial * stab * 1 * typeEff);
                }

                double perc = (double)damage / _pokémon2.HP * 100;
                double minPerc = (double)minDamage / _pokémon2.HP * 100;
                double maxPerc = (double)maxDamage / _pokémon2.HP * 100;

                Console.WriteLine("Damage of " + move.Name + " on " + _pokémon2.Name + ": " + damage + string.Format(" ({0:N2}%)", perc) + ", could have been between " + minDamage + "-" + maxDamage +
                    string.Format(" ({0:N2}%", minPerc) + " - " + string.Format("{0:N2}%)", maxPerc));
                _pokémon2.CurrentHP -= damage;
                Console.WriteLine(_pokémon2.Name + ": " + _pokémon2.CurrentHP + "/" + _pokémon2.HP);

                sb.Append("Damage of " + move.Name + " on " + _pokémon2.Name + ": " + damage + string.Format(" ({0:N2}%)", perc) + ", could have been between " + minDamage + "-" + maxDamage +
                    string.Format(" ({0:N2}%", minPerc) + " - " + string.Format("{0:N2}%)", maxPerc));
            }
            else
            {
                damage = 0;
                double perc = (double)damage / _pokémon2.HP * 100;

                Console.WriteLine("Damage of " + move.Name + " on " + _pokémon2.Name + ": " + damage + string.Format(" ({0:N2}%)", perc));
                _pokémon2.CurrentHP -= damage;
                Console.WriteLine(_pokémon2.Name + ": " + _pokémon2.CurrentHP + "/" + _pokémon2.HP);

                sb.Append("Damage of " + move.Name + " on " + _pokémon2.Name + ": " + damage + string.Format(" ({0:N2}%)", perc));
            }

            return sb.ToString();
        }
        public string CalculateDamageFrom2To1(string m)
        {
            if (m == null || m.Trim() == "")
            {
                throw new ArgumentNullException("Null move");
            }

            Move move = _parseMoves.GetMoveByName(m);

            if (!_pokémon2.Moves.Contains(move))
            {
                throw new ArgumentException(_pokémon2.Name + " doesn't know " + move.Name);
            }
            if (move.Category == Category.Status)
            {
                throw new ArgumentException("Status moves don't generate damage");
            }

            uint damage;
            StringBuilder sb = new StringBuilder();

            if (!move.IsFixedDamage)
            {
                uint partial;
                uint minDamage, maxDamage;
                double stab = 1;
                if (_pokémon2.Type.Contains(move.Type))
                {
                    stab = 1.5;
                }
                double roll = _random.NextDouble() * (1 - 0.85) + 0.85;
                double typeEff = _pokémon1.GetChart()[move.Type.GetType()];


                //damage = ( ( ( ( 2 * level / 5 ) + 2 ) * power * A/D ) / 50 ) + 2 )
                //    * targets * PB * Weather * Critical * random * STAB * Type * Burn * other * ZMove
                if (move.Category == Category.Physical)
                {
                    uint p1 = 2 * _pokémon2.Level / 5 + 2;
                    partial = (uint)(p1 * move.Power * _pokémon2.Attack / _pokémon1.Defense / 50 + 2);
                    damage = (uint)(partial * stab * roll * typeEff);
                    minDamage = (uint)(partial * stab * 0.849f * typeEff);
                    maxDamage = (uint)(partial * stab * 1 * typeEff);
                }
                else
                {
                    uint p1 = 2 * _pokémon2.Level / 5 + 2;
                    partial = (uint)(p1 * move.Power * _pokémon2.SpecialAttack / _pokémon1.SpecialDefense / 50 + 2);
                    damage = (uint)(partial * stab * roll * typeEff);
                    minDamage = (uint)(partial * stab * 0.849f * typeEff);
                    maxDamage = (uint)(partial * stab * 1 * typeEff);
                }

                double perc = (double)damage / _pokémon1.HP * 100;
                double minPerc = (double)minDamage / _pokémon1.HP * 100;
                double maxPerc = (double)maxDamage / _pokémon1.HP * 100;

                Console.WriteLine("Damage of " + move.Name + " on " + _pokémon1.Name + ": " + damage + string.Format(" ({0:N2}%)", perc) + ", could have been between " + minDamage + "-" + maxDamage +
                    string.Format(" ({0:N2}%", minPerc) + " - " + string.Format("{0:N2}%)", maxPerc));
                _pokémon1.CurrentHP -= damage;
                Console.WriteLine(_pokémon1.Name + ": " + _pokémon1.CurrentHP + "/" + _pokémon1.HP);

                sb.Append("Damage of " + move.Name + " on " + _pokémon1.Name + ": " + damage + string.Format(" ({0:N2}%)", perc) + ", could have been between " + minDamage + "-" + maxDamage +
                    string.Format(" ({0:N2}%", minPerc) + " - " + string.Format("{0:N2}%)", maxPerc));
            }
            else
            {
                damage = 0;
                double perc = (double)damage / _pokémon1.HP * 100;

                Console.WriteLine("Damage of " + move.Name + " on " + _pokémon1.Name + ": " + damage + string.Format(" ({0:N2}%)", perc));
                _pokémon1.CurrentHP -= damage;
                Console.WriteLine(_pokémon1.Name + ": " + _pokémon1.CurrentHP + "/" + _pokémon1.HP);

                sb.Append("Damage of " + move.Name + " on " + _pokémon1.Name + ": " + damage + string.Format(" ({0:N2}%)", perc));
            }

            return sb.ToString();
        }


        /*
         * Pokémon 1
         */

        public Pokémon GetPokémon1()
        {
            return _pokémon1;
        }
        public string[] GetPokémon1Types()
        {
            string[] result = new string[2];

            result[0] = _pokémon1.Type[0].ToString();

            if (_pokémon1.Type.Count == 2)
            {
                result[1] = _pokémon1.Type[1].ToString();
            }
            else
            {
                result[1] = "(none)";
            }

            return result;
        }
        public void ChangePokémon1(Pokémon pokémon)
        {
            _pokémon1 = pokémon;
        }
        public void ChangePokémon1(string name)
        {
            Pokémon newPokémon;
            try
            {
                newPokémon = _parsePokémon.GetPokémonByName(name);
                _pokémon1 = newPokémon;
            }
            catch
            {
                return;
            }
        }
        public void ViewPokémon1Details()
        {
            Console.WriteLine(_pokémon1.VerboseToString());
        }

        public void ChangePokémon1Level(uint level)
        {
            _pokémon1.Level = level;
        }

        public void ChangePokémon1IV(IV ivs)
        {
            _pokémon1.SetIVs(ivs);
        }

        public void ChangePokémon1EV(EV evs)
        {
            _pokémon1.SetEVs(evs);
        }

        public void ChangePokémon1HPIV(uint value)
        {
            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: ivs.Add(stat, value); break;
                    case Stats.Attack: ivs.Add(stat, _pokémon1.GetIVs().GetAttackIV()); break;
                    case Stats.Defense: ivs.Add(stat, _pokémon1.GetIVs().GetDefenseIV()); break;
                    case Stats.SpecialAttack: ivs.Add(stat, _pokémon1.GetIVs().GetSpecialAttackIV()); break;
                    case Stats.SpecialDefense: ivs.Add(stat, _pokémon1.GetIVs().GetSpecialDefenseIV()); break;
                    case Stats.Speed: ivs.Add(stat, _pokémon1.GetIVs().GetSpeedIV()); break;
                }
            }
            _pokémon1.SetIVs(new IV(ivs));
        }

        public void ChangePokémon1AttackIV(uint value)
        {
            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: ivs.Add(stat, _pokémon1.GetIVs().GetHPIV()); break;
                    case Stats.Attack: ivs.Add(stat, value); break;
                    case Stats.Defense: ivs.Add(stat, _pokémon1.GetIVs().GetDefenseIV()); break;
                    case Stats.SpecialAttack: ivs.Add(stat, _pokémon1.GetIVs().GetSpecialAttackIV()); break;
                    case Stats.SpecialDefense: ivs.Add(stat, _pokémon1.GetIVs().GetSpecialDefenseIV()); break;
                    case Stats.Speed: ivs.Add(stat, _pokémon1.GetIVs().GetSpeedIV()); break;
                }
            }
            _pokémon1.SetIVs(new IV(ivs));
        }

        public void ChangePokémon1DefenseIV(uint value)
        {
            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: ivs.Add(stat, _pokémon1.GetIVs().GetHPIV()); break;
                    case Stats.Attack: ivs.Add(stat, _pokémon1.GetIVs().GetAttackIV()); break;
                    case Stats.Defense: ivs.Add(stat, value); break;
                    case Stats.SpecialAttack: ivs.Add(stat, _pokémon1.GetIVs().GetSpecialAttackIV()); break;
                    case Stats.SpecialDefense: ivs.Add(stat, _pokémon1.GetIVs().GetSpecialDefenseIV()); break;
                    case Stats.Speed: ivs.Add(stat, _pokémon1.GetIVs().GetSpeedIV()); break;
                }
            }
            _pokémon1.SetIVs(new IV(ivs));
        }

        public void ChangePokémon1SpecialAttackIV(uint value)
        {
            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: ivs.Add(stat, _pokémon1.GetIVs().GetHPIV()); break;
                    case Stats.Attack: ivs.Add(stat, _pokémon1.GetIVs().GetAttackIV()); break;
                    case Stats.Defense: ivs.Add(stat, _pokémon1.GetIVs().GetDefenseIV()); break;
                    case Stats.SpecialAttack: ivs.Add(stat, value); break;
                    case Stats.SpecialDefense: ivs.Add(stat, _pokémon1.GetIVs().GetSpecialDefenseIV()); break;
                    case Stats.Speed: ivs.Add(stat, _pokémon1.GetIVs().GetSpeedIV()); break;
                }
            }
            _pokémon1.SetIVs(new IV(ivs));
        }

        public void ChangePokémon1SpecialDefenseIV(uint value)
        {
            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: ivs.Add(stat, _pokémon1.GetIVs().GetHPIV()); break;
                    case Stats.Attack: ivs.Add(stat, _pokémon1.GetIVs().GetAttackIV()); break;
                    case Stats.Defense: ivs.Add(stat, _pokémon1.GetIVs().GetDefenseIV()); break;
                    case Stats.SpecialAttack: ivs.Add(stat, _pokémon1.GetIVs().GetSpecialAttackIV()); break;
                    case Stats.SpecialDefense: ivs.Add(stat, value); break;
                    case Stats.Speed: ivs.Add(stat, _pokémon1.GetIVs().GetSpeedIV()); break;
                }
            }
            _pokémon1.SetIVs(new IV(ivs));
        }

        public void ChangePokémon1SpeedIV(uint value)
        {
            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: ivs.Add(stat, _pokémon1.GetIVs().GetHPIV()); break;
                    case Stats.Attack: ivs.Add(stat, _pokémon1.GetIVs().GetAttackIV()); break;
                    case Stats.Defense: ivs.Add(stat, _pokémon1.GetIVs().GetDefenseIV()); break;
                    case Stats.SpecialAttack: ivs.Add(stat, _pokémon1.GetIVs().GetSpecialAttackIV()); break;
                    case Stats.SpecialDefense: ivs.Add(stat, _pokémon1.GetIVs().GetSpecialDefenseIV()); break;
                    case Stats.Speed: ivs.Add(stat, value); break;
                }
            }
            _pokémon1.SetIVs(new IV(ivs));
        }

        public void ChangePokémon1HPEV(uint value)
        {
            if (value > 252 || value < 0 || _pokémon1.GetTotalEV() + value > 510)
            {
                return;
            }
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: evs.Add(stat, value); break;
                    case Stats.Attack: evs.Add(stat, _pokémon1.GetEVs().GetAttackEV()); break;
                    case Stats.Defense: evs.Add(stat, _pokémon1.GetEVs().GetDefenseEV()); break;
                    case Stats.SpecialAttack: evs.Add(stat, _pokémon1.GetEVs().GetSpecialAttackEV()); break;
                    case Stats.SpecialDefense: evs.Add(stat, _pokémon1.GetEVs().GetSpecialDefenseEV()); break;
                    case Stats.Speed: evs.Add(stat, _pokémon1.GetEVs().GetSpeedEV()); break;
                }
            }
            _pokémon1.SetEVs(new EV(evs));
        }

        public void ChangePokémon1AttackEV(uint value)
        {
            if (value > 252 || value < 0 || _pokémon1.GetTotalEV() + value > 510)
            {
                return;
            }
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: evs.Add(stat, _pokémon1.GetEVs().GetHPEV()); break;
                    case Stats.Attack: evs.Add(stat, value); break;
                    case Stats.Defense: evs.Add(stat, _pokémon1.GetEVs().GetDefenseEV()); break;
                    case Stats.SpecialAttack: evs.Add(stat, _pokémon1.GetEVs().GetSpecialAttackEV()); break;
                    case Stats.SpecialDefense: evs.Add(stat, _pokémon1.GetEVs().GetSpecialDefenseEV()); break;
                    case Stats.Speed: evs.Add(stat, _pokémon1.GetEVs().GetSpeedEV()); break;
                }
            }
            _pokémon1.SetEVs(new EV(evs));
        }

        public void ChangePokémon1DefenseEV(uint value)
        {
            if (value > 252 || value < 0 || _pokémon1.GetTotalEV() + value > 510)
            {
                return;
            }
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: evs.Add(stat, _pokémon1.GetEVs().GetHPEV()); break;
                    case Stats.Attack: evs.Add(stat, _pokémon1.GetEVs().GetAttackEV()); break;
                    case Stats.Defense: evs.Add(stat, value); break;
                    case Stats.SpecialAttack: evs.Add(stat, _pokémon1.GetEVs().GetSpecialAttackEV()); break;
                    case Stats.SpecialDefense: evs.Add(stat, _pokémon1.GetEVs().GetSpecialDefenseEV()); break;
                    case Stats.Speed: evs.Add(stat, _pokémon1.GetEVs().GetSpeedEV()); break;
                }
            }
            _pokémon1.SetEVs(new EV(evs));
        }

        public void ChangePokémon1SpecialAttackEV(uint value)
        {
            if (value > 252 || value < 0 || _pokémon1.GetTotalEV() + value > 510)
            {
                return;
            }
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: evs.Add(stat, _pokémon1.GetEVs().GetHPEV()); break;
                    case Stats.Attack: evs.Add(stat, _pokémon1.GetEVs().GetAttackEV()); break;
                    case Stats.Defense: evs.Add(stat, _pokémon1.GetEVs().GetDefenseEV()); break;
                    case Stats.SpecialAttack: evs.Add(stat, value); break;
                    case Stats.SpecialDefense: evs.Add(stat, _pokémon1.GetEVs().GetSpecialDefenseEV()); break;
                    case Stats.Speed: evs.Add(stat, _pokémon1.GetEVs().GetSpeedEV()); break;
                }
            }
            _pokémon1.SetEVs(new EV(evs));
        }

        public void ChangePokémon1SpecialDefenseEV(uint value)
        {
            if (value > 252 || value < 0 || _pokémon1.GetTotalEV() + value > 510)
            {
                return;
            }
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: evs.Add(stat, _pokémon1.GetEVs().GetHPEV()); break;
                    case Stats.Attack: evs.Add(stat, _pokémon1.GetEVs().GetAttackEV()); break;
                    case Stats.Defense: evs.Add(stat, _pokémon1.GetEVs().GetDefenseEV()); break;
                    case Stats.SpecialAttack: evs.Add(stat, _pokémon1.GetEVs().GetSpecialAttackEV()); break;
                    case Stats.SpecialDefense: evs.Add(stat, value); break;
                    case Stats.Speed: evs.Add(stat, _pokémon1.GetEVs().GetSpeedEV()); break;
                }
            }
            _pokémon1.SetEVs(new EV(evs));
        }

        public void ChangePokémon1SpeedEV(uint value)
        {
            if (value > 252 || value < 0 || _pokémon1.GetTotalEV() + value > 510)
            {
                return;
            }
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: evs.Add(stat, _pokémon1.GetEVs().GetHPEV()); break;
                    case Stats.Attack: evs.Add(stat, _pokémon1.GetEVs().GetAttackEV()); break;
                    case Stats.Defense: evs.Add(stat, _pokémon1.GetEVs().GetDefenseEV()); break;
                    case Stats.SpecialAttack: evs.Add(stat, _pokémon1.GetEVs().GetSpecialAttackEV()); break;
                    case Stats.SpecialDefense: evs.Add(stat, _pokémon1.GetEVs().GetSpecialDefenseEV()); break;
                    case Stats.Speed: evs.Add(stat, value); break;
                }
            }
            _pokémon1.SetEVs(new EV(evs));
        }

        public void ChangePokémon1Nature(Nature nature)
        {
            _pokémon1.Nature = nature;
        }
        public void ChangePokémon1Nature(string name)
        {
            string n = name.Split(" ")[0]; //ex. Modest (+SpecialAttack, -Attack)
            Nature newNature = _listNatures.GetNatureByName(n);
            if (newNature == null)
            {
                return;
            }
            else
            {
                _pokémon1.Nature = newNature;
            }
        }

        public void ViewPokémon1Moves()
        {
            foreach (Move move in _pokémon1.Moves)
            {
                Console.WriteLine(move.ToString());
            }
        }

        public void ChangePokémon1Moves(List<Move> moves)
        {
            _pokémon1.Moves = moves;
        }
        public void ChangePokémon1Move(string name, int index)
        {
            if (name.Trim() == "(No move)" || index < 0 || index > 3)
            {
                return;
            }
            else
            {
                try
                {
                    Move move = _parseMoves.GetMoveByName(name);

                    if (index + 1 > _pokémon1.Moves.Count) { // if the Pokémon has 1 move and we want to teach it a new move
                        _pokémon1.Moves.Add(move);
                    }
                    else // replace move
                    {
                        _pokémon1.Moves[index] = move;
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        public void RemovePokémon1Move(Move move)
        {
            _pokémon1.Moves.Remove(move);
        }

        public void AddPokémon1Move(Move move)
        {
            _pokémon1.Moves.Add(move);
        }
        public string[] GetPokémon1MovesNames()
        {
            string[] result = new string[4];
            int i;

            for (i=0; i<_pokémon1.Moves.Count; i++)
            {
                result[i] = _pokémon1.Moves[i].Name;
            }

            // The others are "null"
            if (_pokémon1.Moves.Count < 4)
            {
                for (; i < 4; i++)
                {
                    result[i] = "(No move)";
                }
            }

            return result;
        }
        public uint[] GetPokémon1MovesPowers()
        {
            uint[] result = new uint[4];
            int i;

            for (i = 0; i < _pokémon1.Moves.Count; i++)
            {
                if (_pokémon1.Moves[i].Power != null)
                {
                    result[i] = _pokémon1.Moves[i].Power.Value;
                }
                else
                {
                    result[i] = 0;
                }
            }

            // The others are null
            if (_pokémon1.Moves.Count < 4)
            {
                for (; i < 4; i++)
                {
                    result[i] = 0;
                }
            }

            return result;
        }

        public string[] GetPokémon1MovesTypes()
        {
            string[] result = new string[4];
            int i;

            for (i = 0; i < _pokémon1.Moves.Count; i++)
            {
                result[i] = _pokémon1.Moves[i].Type.ToString();
            }

            // The others are "null"
            if (_pokémon1.Moves.Count < 4)
            {
                for (; i < 4; i++)
                {
                    result[i] = "Normal";
                }
            }

            return result;
        }

        public string[] GetPokémon1MovesCategories()
        {
            string[] result = new string[4];
            int i;

            for (i = 0; i < _pokémon1.Moves.Count; i++)
            {
                result[i] = _pokémon1.Moves[i].Category.ToString();
            }

            // The others are "null"
            if (_pokémon1.Moves.Count < 4)
            {
                for (; i < 4; i++)
                {
                    result[i] = "Physical";
                }
            }

            return result;
        }



        /*
         * Pokémon 2
         */

        public Pokémon GetPokémon2()
        {
            return _pokémon2;
        }
        public string[] GetPokémon2Types()
        {
            string[] result = new string[2];

            result[0] = _pokémon2.Type[0].ToString();

            if (_pokémon2.Type.Count == 2)
            {
                result[1] = _pokémon2.Type[1].ToString();
            }
            else
            {
                result[1] = "(none)";
            }

            return result;
        }
        public void ChangePokémon2(Pokémon pokémon)
        {
            _pokémon2 = pokémon;
        }
        public void ChangePokémon2(string name)
        {
            Pokémon newPokémon;
            try
            {
                newPokémon = _parsePokémon.GetPokémonByName(name);
                _pokémon2 = newPokémon;
            }
            catch
            {
                return;
            }
        }
        public void ViewPokémon2Details()
        {
            Console.WriteLine(_pokémon2.VerboseToString());
        }

        public void ChangePokémon2Level(uint level)
        {
            _pokémon2.Level = level;
        }

        public void ChangePokémon2IV(IV ivs)
        {
            _pokémon2.SetIVs(ivs);
        }

        public void ChangePokémon2EV(EV evs)
        {
            _pokémon2.SetEVs(evs);
        }

        public void ChangePokémon2HPIV(uint value)
        {
            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: ivs.Add(stat, value); break;
                    case Stats.Attack: ivs.Add(stat, _pokémon2.GetIVs().GetAttackIV()); break;
                    case Stats.Defense: ivs.Add(stat, _pokémon2.GetIVs().GetDefenseIV()); break;
                    case Stats.SpecialAttack: ivs.Add(stat, _pokémon2.GetIVs().GetSpecialAttackIV()); break;
                    case Stats.SpecialDefense: ivs.Add(stat, _pokémon2.GetIVs().GetSpecialDefenseIV()); break;
                    case Stats.Speed: ivs.Add(stat, _pokémon2.GetIVs().GetSpeedIV()); break;
                }
            }
            _pokémon2.SetIVs(new IV(ivs));
        }

        public void ChangePokémon2AttackIV(uint value)
        {
            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: ivs.Add(stat, _pokémon2.GetIVs().GetHPIV()); break;
                    case Stats.Attack: ivs.Add(stat, value); break;
                    case Stats.Defense: ivs.Add(stat, _pokémon2.GetIVs().GetDefenseIV()); break;
                    case Stats.SpecialAttack: ivs.Add(stat, _pokémon2.GetIVs().GetSpecialAttackIV()); break;
                    case Stats.SpecialDefense: ivs.Add(stat, _pokémon2.GetIVs().GetSpecialDefenseIV()); break;
                    case Stats.Speed: ivs.Add(stat, _pokémon2.GetIVs().GetSpeedIV()); break;
                }
            }
            _pokémon2.SetIVs(new IV(ivs));
        }

        public void ChangePokémon2DefenseIV(uint value)
        {
            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: ivs.Add(stat, _pokémon2.GetIVs().GetHPIV()); break;
                    case Stats.Attack: ivs.Add(stat, _pokémon2.GetIVs().GetAttackIV()); break;
                    case Stats.Defense: ivs.Add(stat, value); break;
                    case Stats.SpecialAttack: ivs.Add(stat, _pokémon2.GetIVs().GetSpecialAttackIV()); break;
                    case Stats.SpecialDefense: ivs.Add(stat, _pokémon2.GetIVs().GetSpecialDefenseIV()); break;
                    case Stats.Speed: ivs.Add(stat, _pokémon2.GetIVs().GetSpeedIV()); break;
                }
            }
            _pokémon2.SetIVs(new IV(ivs));
        }

        public void ChangePokémon2SpecialAttackIV(uint value)
        {
            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: ivs.Add(stat, _pokémon2.GetIVs().GetHPIV()); break;
                    case Stats.Attack: ivs.Add(stat, _pokémon2.GetIVs().GetAttackIV()); break;
                    case Stats.Defense: ivs.Add(stat, _pokémon2.GetIVs().GetDefenseIV()); break;
                    case Stats.SpecialAttack: ivs.Add(stat, value); break;
                    case Stats.SpecialDefense: ivs.Add(stat, _pokémon2.GetIVs().GetSpecialDefenseIV()); break;
                    case Stats.Speed: ivs.Add(stat, _pokémon2.GetIVs().GetSpeedIV()); break;
                }
            }
            _pokémon2.SetIVs(new IV(ivs));
        }

        public void ChangePokémon2SpecialDefenseIV(uint value)
        {
            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: ivs.Add(stat, _pokémon2.GetIVs().GetHPIV()); break;
                    case Stats.Attack: ivs.Add(stat, _pokémon2.GetIVs().GetAttackIV()); break;
                    case Stats.Defense: ivs.Add(stat, _pokémon2.GetIVs().GetDefenseIV()); break;
                    case Stats.SpecialAttack: ivs.Add(stat, _pokémon2.GetIVs().GetSpecialAttackIV()); break;
                    case Stats.SpecialDefense: ivs.Add(stat, value); break;
                    case Stats.Speed: ivs.Add(stat, _pokémon2.GetIVs().GetSpeedIV()); break;
                }
            }
            _pokémon2.SetIVs(new IV(ivs));
        }

        public void ChangePokémon2SpeedIV(uint value)
        {
            Dictionary<Stats, uint> ivs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: ivs.Add(stat, _pokémon2.GetIVs().GetHPIV()); break;
                    case Stats.Attack: ivs.Add(stat, _pokémon2.GetIVs().GetAttackIV()); break;
                    case Stats.Defense: ivs.Add(stat, _pokémon2.GetIVs().GetDefenseIV()); break;
                    case Stats.SpecialAttack: ivs.Add(stat, _pokémon2.GetIVs().GetSpecialAttackIV()); break;
                    case Stats.SpecialDefense: ivs.Add(stat, _pokémon2.GetIVs().GetSpecialDefenseIV()); break;
                    case Stats.Speed: ivs.Add(stat, value); break;
                }
            }
            _pokémon2.SetIVs(new IV(ivs));
        }

        public void ChangePokémon2HPEV(uint value)
        {
            if (value > 252 || value < 0 || _pokémon2.GetTotalEV() + value > 510)
            {
                return;
            }
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: evs.Add(stat, value); break;
                    case Stats.Attack: evs.Add(stat, _pokémon2.GetEVs().GetAttackEV()); break;
                    case Stats.Defense: evs.Add(stat, _pokémon2.GetEVs().GetDefenseEV()); break;
                    case Stats.SpecialAttack: evs.Add(stat, _pokémon2.GetEVs().GetSpecialAttackEV()); break;
                    case Stats.SpecialDefense: evs.Add(stat, _pokémon2.GetEVs().GetSpecialDefenseEV()); break;
                    case Stats.Speed: evs.Add(stat, _pokémon2.GetEVs().GetSpeedEV()); break;
                }
            }
            _pokémon2.SetEVs(new EV(evs));
        }

        public void ChangePokémon2AttackEV(uint value)
        {
            if (value > 252 || value < 0 || _pokémon2.GetTotalEV() + value > 510)
            {
                return;
            }
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: evs.Add(stat, _pokémon2.GetEVs().GetHPEV()); break;
                    case Stats.Attack: evs.Add(stat, value); break;
                    case Stats.Defense: evs.Add(stat, _pokémon2.GetEVs().GetDefenseEV()); break;
                    case Stats.SpecialAttack: evs.Add(stat, _pokémon2.GetEVs().GetSpecialAttackEV()); break;
                    case Stats.SpecialDefense: evs.Add(stat, _pokémon2.GetEVs().GetSpecialDefenseEV()); break;
                    case Stats.Speed: evs.Add(stat, _pokémon2.GetEVs().GetSpeedEV()); break;
                }
            }
            _pokémon2.SetEVs(new EV(evs));
        }

        public void ChangePokémon2DefenseEV(uint value)
        {
            if (value > 252 || value < 0 || _pokémon2.GetTotalEV() + value > 510)
            {
                return;
            }
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: evs.Add(stat, _pokémon1.GetEVs().GetHPEV()); break;
                    case Stats.Attack: evs.Add(stat, _pokémon1.GetEVs().GetAttackEV()); break;
                    case Stats.Defense: evs.Add(stat, value); break;
                    case Stats.SpecialAttack: evs.Add(stat, _pokémon1.GetEVs().GetSpecialAttackEV()); break;
                    case Stats.SpecialDefense: evs.Add(stat, _pokémon1.GetEVs().GetSpecialDefenseEV()); break;
                    case Stats.Speed: evs.Add(stat, _pokémon1.GetEVs().GetSpeedEV()); break;
                }
            }
            _pokémon1.SetEVs(new EV(evs));
        }

        public void ChangePokémon2SpecialAttackEV(uint value)
        {
            if (value > 252 || value < 0 || _pokémon2.GetTotalEV() + value > 510)
            {
                return;
            }
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: evs.Add(stat, _pokémon2.GetEVs().GetHPEV()); break;
                    case Stats.Attack: evs.Add(stat, _pokémon2.GetEVs().GetAttackEV()); break;
                    case Stats.Defense: evs.Add(stat, _pokémon2.GetEVs().GetDefenseEV()); break;
                    case Stats.SpecialAttack: evs.Add(stat, value); break;
                    case Stats.SpecialDefense: evs.Add(stat, _pokémon2.GetEVs().GetSpecialDefenseEV()); break;
                    case Stats.Speed: evs.Add(stat, _pokémon2.GetEVs().GetSpeedEV()); break;
                }
            }
            _pokémon2.SetEVs(new EV(evs));
        }

        public void ChangePokémon2SpecialDefenseEV(uint value)
        {
            if (value > 252 || value < 0 || _pokémon2.GetTotalEV() + value > 510)
            {
                return;
            }
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: evs.Add(stat, _pokémon2.GetEVs().GetHPEV()); break;
                    case Stats.Attack: evs.Add(stat, _pokémon2.GetEVs().GetAttackEV()); break;
                    case Stats.Defense: evs.Add(stat, _pokémon2.GetEVs().GetDefenseEV()); break;
                    case Stats.SpecialAttack: evs.Add(stat, _pokémon2.GetEVs().GetSpecialAttackEV()); break;
                    case Stats.SpecialDefense: evs.Add(stat, value); break;
                    case Stats.Speed: evs.Add(stat, _pokémon2.GetEVs().GetSpeedEV()); break;
                }
            }
            _pokémon2.SetEVs(new EV(evs));
        }

        public void ChangePokémon2SpeedEV(uint value)
        {
            if (value > 252 || value < 0 || _pokémon2.GetTotalEV() + value > 510)
            {
                return;
            }
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            foreach (Stats stat in Enum.GetValues(typeof(Stats)))
            {
                switch (stat)
                {
                    case Stats.HP: evs.Add(stat, _pokémon2.GetEVs().GetHPEV()); break;
                    case Stats.Attack: evs.Add(stat, _pokémon2.GetEVs().GetAttackEV()); break;
                    case Stats.Defense: evs.Add(stat, _pokémon2.GetEVs().GetDefenseEV()); break;
                    case Stats.SpecialAttack: evs.Add(stat, _pokémon2.GetEVs().GetSpecialAttackEV()); break;
                    case Stats.SpecialDefense: evs.Add(stat, _pokémon2.GetEVs().GetSpecialDefenseEV()); break;
                    case Stats.Speed: evs.Add(stat, value); break;
                }
            }
            _pokémon2.SetEVs(new EV(evs));
        }

        public void ChangePokémon2Nature(Nature nature)
        {
            _pokémon2.Nature = nature;
        }
        public void ChangePokémon2Nature(string name)
        {
            string n = name.Split(" ")[0]; //ex. Modest (+SpecialAttack, -Attack)
            Nature newNature = _listNatures.GetNatureByName(n);
            if (newNature == null)
            {
                return;
            }
            else
            {
                _pokémon2.Nature = newNature;
            }
        }

        public void ViewPokémon2Moves()
        {
            foreach (Move move in _pokémon1.Moves)
            {
                Console.WriteLine(move.ToString());
            }
        }

        public void ChangePokémon2Moves(List<Move> moves)
        {
            _pokémon2.Moves = moves;
        }

        public void ChangePokémon2Move(string name, int index)
        {
            if (name.Trim() == "(No move)" || index < 0 || index > 3)
            {
                return;
            }
            else
            {
                try
                {
                    Move move = _parseMoves.GetMoveByName(name);

                    if (index + 1 > _pokémon2.Moves.Count)
                    { // if the Pokémon has 1 move and we want to teach it a new move
                        _pokémon2.Moves.Add(move);
                    }
                    else // replace move
                    {
                        _pokémon2.Moves[index] = move;
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        public void RemovePokémon2Move(Move move)
        {
            _pokémon2.Moves.Remove(move);
        }

        public void AddPokémon2Move(Move move)
        {
            _pokémon2.Moves.Add(move);
        }

        public string[] GetPokémon2MovesNames()
        {
            string[] result = new string[4];
            int i;

            for (i = 0; i < _pokémon2.Moves.Count; i++)
            {
                result[i] = _pokémon2.Moves[i].Name;
            }

            // The others are "null"
            if (_pokémon2.Moves.Count < 4)
            {
                for (; i < 4; i++)
                {
                    result[i] = "(No move)";
                }
            }

            return result;
        }

        public uint[] GetPokémon2MovesPowers()
        {
            uint[] result = new uint[4];
            int i;

            for (i = 0; i < _pokémon2.Moves.Count; i++)
            {
                if (_pokémon2.Moves[i].Power != null)
                {
                    result[i] = _pokémon2.Moves[i].Power.Value;
                }
                else
                {
                    result[i] = 0;
                }
            }

            // The others are null
            if (_pokémon2.Moves.Count < 4)
            {
                for (; i < 4; i++)
                {
                    result[i] = 0;
                }
            }

            return result;
        }

        public string[] GetPokémon2MovesTypes()
        {
            string[] result = new string[4];
            int i;

            for (i = 0; i < _pokémon2.Moves.Count; i++)
            {
                result[i] = _pokémon2.Moves[i].Type.ToString();
            }

            // The others are "null"
            if (_pokémon2.Moves.Count < 4)
            {
                for (; i < 4; i++)
                {
                    result[i] = "Normal";
                }
            }

            return result;
        }

        public string[] GetPokémon2MovesCategories()
        {
            string[] result = new string[4];
            int i;

            for (i = 0; i < _pokémon2.Moves.Count; i++)
            {
                result[i] = _pokémon2.Moves[i].Category.ToString();
            }

            // The others are "null"
            if (_pokémon2.Moves.Count < 4)
            {
                for (; i < 4; i++)
                {
                    result[i] = "Physical";
                }
            }

            return result;
        }
    }
}
