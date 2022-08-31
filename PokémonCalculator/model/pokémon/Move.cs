using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = PokémonCalculator.model.types.Type;

namespace PokémonCalculator.model.pokémon
{
    public enum Category
    {
        Physical,
        Special,
        Status
    }

    public class Move
    {
        private readonly uint _id;
        private readonly string _name;
        private readonly Type _type;
        private readonly Category _category;
        private readonly uint? _accuracy;
        private readonly uint? _power;
        private readonly string _description;
        private readonly uint _pp;
        private readonly bool _isFixedDamage;
        private uint _fixedDamage;

        public Move(uint id, string name, Type type, Category category, uint? power, uint? accuracy, string description, uint pp, bool isFixedDamage)
        {
            if (id == 0 && name.Trim() != "(No move)")
            {
                throw new ArgumentNullException("A move must have a positive id");
            }
            if (name == null || name == "")
            {
                throw new ArgumentNullException("A move must have a name");
            }
            if (type == null)
            {
                throw new ArgumentNullException("A move must have a type");
            }
            if (description == null)
            {
                throw new ArgumentNullException("A move must have a description");
            }
            if (accuracy != null)
            {
                if (accuracy < 1 || accuracy > 100)
                {
                    throw new ArgumentException("A move must have an accuracy between 1 and 100");
                }
                if (accuracy % 5 != 0)
                {
                    throw new ArgumentException("A move must have an accuracy multiple of 5");
                }
            }
            if (category == Category.Status && power != null)
            {
                throw new ArgumentException("A status move cannot have a power");
            }
            if (category != Category.Status && power == null && !isFixedDamage)
            {
                throw new ArgumentException("A physical or special move must have a power");
            }
            if (pp < 1 || pp > 40)
            {
                throw new ArgumentException("A move must have PP between 1 and 40");
            }
            _name = name;
            _type = type;
            _category = category;
            _accuracy = accuracy; //null indicates accuracy -%
            _power = power;
            _description = description;
            _pp = pp;
            _isFixedDamage = isFixedDamage;
        }

        public uint ID { get { return _id; } }
        public string Name { get { return _name; } }
        public Type Type { get { return _type; } }
        public Category Category { get { return _category; } }
        public string Description { get { return _description; } }
        public uint? Power { get { return _power; } }
        public uint? Accuracy { get { return _accuracy; } }
        public uint PP { get { return _pp; } }
        public bool IsFixedDamage { get { return _isFixedDamage; } }

        public uint GetFixedDamage()
        {
            return _fixedDamage;
        }

        public void SetFixedDamage(uint value)
        {
            _fixedDamage = value;
        }

        public override string ToString()
        {
            return _name;
        }

        public string VerboseToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(_name + "\t" + _type.ToString() + "\t  " + _category.ToString() + "\t  " + _pp + "\t");
            if (_power == null)
            {
                sb.Append("-\t");
            }
            else
            {
                sb.Append(_power.ToString() + "\t");
            }
            if (_accuracy == null)
            {
                sb.Append("-%\t\t");
            }
            else
            {
                sb.Append(_accuracy.ToString() + "%\t\t");
            }
            sb.Append(_description);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Move);
        }

        public bool Equals(Move other)
        {
            return other != null &&
                Type == other.Type &&
                Power == other.Power &&
                Accuracy == other.Accuracy &&
                Name == other.Name;
        }

    }
}
