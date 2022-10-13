using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokémonCalculator.model.types;
using Type = PokémonCalculator.model.types.Type;
using PokémonCalculator.model.pokémon;

namespace PokémonCalculator.persistence
{
    public class ParsePokémon
    {
        private List<Pokémon> _pokémons;
        private static ParsePokémon _instance = null;

        public static ParsePokémon Instance
        {
            get
            {
                if (_instance == null)
                {
                    string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string sFile = System.IO.Path.Combine(sCurrentDirectory, @"../../../persistence/Pokemon.csv");
                    string sFilePath = Path.GetFullPath(sFile);
                    _instance = new ParsePokémon(sFilePath);
                    //_instance = new ParsePokémon("C:\\Users\\wwwli\\source\\repos\\PokémonCalculator\\PokémonCalculator\\persistence\\Pokemon.csv");
                }
                return _instance;
            }
        }

        private ParsePokémon(string filePath)
        {
            IEnumerable<string> allLines;
            if (!File.Exists(filePath))
            {
                throw new ArgumentException("File " + filePath + " does not exist");
            }
            _pokémons = new List<Pokémon>();

            //Read all content of the files and skip line 1 (header)
            allLines = File.ReadLines(filePath).Skip(1);

            uint id, total, hp, att, def, spA, spD, spe, gen;
            string name;
            List<Type> type;
            Dictionary<Stats, uint> baseStats;
            Pokémon pokémon;

            //"ID","Name","Form","Type1","Type2","Total","HP","Attack","Defense","Sp. Atk","Sp. Def","Speed","Generation"
            foreach (string line in allLines)
            {
                string[] values = line.Split(',');

                id = uint.Parse(values[0]);
                name = values[1].Replace("\"", "");
                if (values[2].Replace("\"", "").Trim() != "")
                {
                    name = name + "-" + values[2].Replace("\"", "");
                }
                type = new List<Type>();
                Types t = (Types)Enum.Parse(typeof(Types), values[3].Replace("\"", ""));
                switch (t)
                {
                    case Types.Normal: type.Add(Normal.Instance); break;
                    case Types.Fighting: type.Add(Fighting.Instance); break;
                    case Types.Flying: type.Add(Flying.Instance); break;
                    case Types.Poison: type.Add(Poison.Instance); break;
                    case Types.Ground: type.Add(Ground.Instance); break;
                    case Types.Rock: type.Add(Rock.Instance); break;
                    case Types.Bug: type.Add(Bug.Instance); break;
                    case Types.Ghost: type.Add(Ghost.Instance); break;
                    case Types.Steel: type.Add(Steel.Instance); break;
                    case Types.Fire: type.Add(Fire.Instance); break;
                    case Types.Water: type.Add(Water.Instance); break;
                    case Types.Grass: type.Add(Grass.Instance); break;
                    case Types.Electric: type.Add(Electric.Instance); break;
                    case Types.Psychic: type.Add(Psychic.Instance); break;
                    case Types.Ice: type.Add(Ice.Instance); break;
                    case Types.Dragon: type.Add(Dragon.Instance); break;
                    case Types.Dark: type.Add(Dark.Instance); break;
                    case Types.Fairy: type.Add(Fairy.Instance); break;
                }

                if (values[4].Replace("\"", "").Trim() != "")
                {
                    t = (Types)Enum.Parse(typeof(Types), values[4].Replace("\"", ""));
                    switch (t)
                    {
                        case Types.Normal: type.Add(Normal.Instance); break;
                        case Types.Fighting: type.Add(Fighting.Instance); break;
                        case Types.Flying: type.Add(Flying.Instance); break;
                        case Types.Poison: type.Add(Poison.Instance); break;
                        case Types.Ground: type.Add(Ground.Instance); break;
                        case Types.Rock: type.Add(Rock.Instance); break;
                        case Types.Bug: type.Add(Bug.Instance); break;
                        case Types.Ghost: type.Add(Ghost.Instance); break;
                        case Types.Steel: type.Add(Steel.Instance); break;
                        case Types.Fire: type.Add(Fire.Instance); break;
                        case Types.Water: type.Add(Water.Instance); break;
                        case Types.Grass: type.Add(Grass.Instance); break;
                        case Types.Electric: type.Add(Electric.Instance); break;
                        case Types.Psychic: type.Add(Psychic.Instance); break;
                        case Types.Ice: type.Add(Ice.Instance); break;
                        case Types.Dragon: type.Add(Dragon.Instance); break;
                        case Types.Dark: type.Add(Dark.Instance); break;
                        case Types.Fairy: type.Add(Fairy.Instance); break;
                    }
                }
                total = uint.Parse(values[5]);
                hp = uint.Parse(values[6]);
                att = uint.Parse(values[7]);
                def = uint.Parse(values[8]);
                spA = uint.Parse(values[9]);
                spD = uint.Parse(values[10]);
                spe = uint.Parse(values[11]);
                gen = uint.Parse(values[12]);
                baseStats = new Dictionary<Stats, uint>();
                foreach (Stats stat in Enum.GetValues(typeof(Stats)))
                {
                    switch (stat)
                    {
                        case Stats.HP: baseStats[stat] = hp; break;
                        case Stats.Attack: baseStats[stat] = att; break;
                        case Stats.Defense: baseStats[stat] = def; break;
                        case Stats.SpecialAttack: baseStats[stat] = spA; break;
                        case Stats.SpecialDefense: baseStats[stat] = spD; break;
                        case Stats.Speed: baseStats[stat] = spe; break;
                    }
                }
                pokémon = new Pokémon(id, name, type, new BaseStats(baseStats, total), gen);
                //Console.WriteLine(pokémon.ToString());

                _pokémons.Add(pokémon);
            }
        }

        public List<Pokémon> GetPokémons()
        {
            return _pokémons;
        }

        public Pokémon GetPokémonByName(string name)
        {
            if (name == null || name.Trim() == "")
            {
                throw new ArgumentNullException("Error with the name inserted in the Pokémon search");
            }

            Pokémon result = null;
            foreach (Pokémon pokémon in _pokémons)
            {
                if (name.ToUpper().Equals(pokémon.Name.ToUpper()))
                {
                    result = pokémon;
                    break;
                }
            }

            if (result == null)
            {
                throw new ArgumentException("The Pokémon " + name + " does not exist");
            }

            return result;
        }

        public List<Pokémon> GetPokémonsByGen(uint gen)
        {
            if (gen == 0 || gen > 8)
            {
                throw new ArgumentNullException("The generation inserted for search must be between 1 and 8");
            }

            List<Pokémon> result = new List<Pokémon>();
            var pokémonsByGen = _pokémons.Where(p => p.Gen == gen).ToList();

            foreach (Pokémon pokémon in pokémonsByGen)
            {
                result.Add(pokémon);
            }

            return result;
        }

        public List<Pokémon> GetTop100Pokémons()
        {
            List<Pokémon> result = new List<Pokémon>();
            uint count = 0;

            foreach (Pokémon pokémon in _pokémons.OrderByDescending(p => p.BaseStatTotal))
            {
                if (count < 100)
                {
                    result.Add(pokémon);
                }
                count++;
            }

            return result;
        }
    }
}
