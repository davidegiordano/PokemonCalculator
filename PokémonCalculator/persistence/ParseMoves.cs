using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = PokémonCalculator.model.types.Type;
using PokémonCalculator.model.pokémon;
using PokémonCalculator.model.types;
using System.Xml.Linq;

namespace PokémonCalculator.persistence
{
    public class ParseMoves
    {
        private List<Move> _allMoves;
        private List<Move> _damagingMoves;
        private List<Move> _fixedDamageMoves;
        private static ParseMoves _instance = null;

        public static ParseMoves Instance
        {
            get
            {
                if (_instance == null)
                {
                    string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string sFile = "";

                    // Workaround for tests
                    if (sCurrentDirectory.Contains("PokémonTests"))
                    {
                        sFile = System.IO.Path.Combine(sCurrentDirectory, @"../../../../../PokémonCalculator/persistence/Moves.txt");
                    } else
                    {
                        sFile = System.IO.Path.Combine(sCurrentDirectory, @"../../../persistence/Moves.txt");
                    }

                    string sFilePath = Path.GetFullPath(sFile);
                    _instance = new ParseMoves(sFilePath);
                }
                return _instance;
            }
        }

        public ParseMoves(string filePath)
        {
            IEnumerable<string> allLines;
            if (!File.Exists(filePath))
            {
                throw new ArgumentException("File " + filePath + " does not exist");
            }
            _allMoves = new List<Move>();
            _damagingMoves = new List<Move>();
            _fixedDamageMoves = new List<Move>();

            //Read all content of the files and skip line 1 (header)
            allLines = File.ReadLines(filePath).Skip(1);

            uint id, pp;
            uint? power = null, accuracy = null;
            string name, gen;
            Type type;
            Category category;
            bool isFixedDamage;
            Move move;

            Move noMove = new Move(0, "(No move)", Normal.Instance, Category.Physical, 0, 100, "N/A", 1, false);
            _allMoves.Add(noMove);

            //# 	Name 	Type 	Category 	PP 	Power 	Accuracy 	Gen
            foreach (string line in allLines)
            {
                string[] values = line.Split('\t');

                isFixedDamage = false;
                power = null; accuracy = null;

                id = uint.Parse(values[0]);
                name = values[1].Trim();
                Types t = (Types)Enum.Parse(typeof(Types), values[2].Trim());
                category = (Category)Enum.Parse(typeof(Category), values[3].Trim());
                pp = uint.Parse(values[4].Trim());

                if (values[5].Trim().Equals("—") && category != Category.Status) //OHKO and fixed damage moves like Dragon Rage
                {
                    isFixedDamage = true;
                }
                if (!values[5].Trim().Equals("—"))
                {
                    isFixedDamage = false;
                    power = uint.Parse(values[5].Trim());
                }
                if (values[6].Trim() != "—")
                {
                    accuracy = uint.Parse(values[6].Replace("%", ""));
                }
                gen = values[7];

                switch (t)
                {
                    case Types.Normal: type = Normal.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Fighting: type = Fighting.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Flying: type = Flying.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Poison: type = Poison.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Ground: type = Ground.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Rock: type = Rock.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Bug: type = Bug.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Ghost: type = Ghost.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Steel: type = Steel.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Fire: type = Fire.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Water: type = Water.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Grass: type = Grass.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Electric: type = Electric.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Psychic: type = Psychic.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Ice: type = Ice.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Dragon: type = Dragon.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Dark: type = Dark.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                    case Types.Fairy: type = Fairy.Instance; move = new Move(id, name, type, category, power, accuracy, "N/A", pp, isFixedDamage); _allMoves.Add(move); break;
                }
            }
            foreach (Move m in _allMoves)
            {
                if (m.Category != Category.Status)
                {
                    _damagingMoves.Add(m);
                    if (m.IsFixedDamage)
                    {
                        _fixedDamageMoves.Add(m);
                    }
                }
            }
        }

        public Move GetMoveByName(string name)
        {
            if (name == null || name.Trim() == "")
            {
                throw new ArgumentNullException("Error with the name inserted in the move search");
            }

            Move result = null;
            foreach (Move move in _allMoves)
            {
                if (name.ToUpper().Equals(move.Name.ToUpper()))
                {
                    result = move;
                    break;
                }
            }

            if (result == null)
            {
                throw new ArgumentException("The move " + name + " does not exist");
            }

            return result;
        }

        public List<Move> GetAllMoves()
        {
            return sortMovesByName(_allMoves);
        }

        public List<Move> GetDamagingMoves()
        {
            return sortMovesByName(_damagingMoves);
        }
        public List<Move> GetFixedDamageMoves()
        {
            return sortMovesByName(_fixedDamageMoves);
        }

        public List<Move> sortMovesByName(List<Move> moves)
        {
            if(moves == null || moves.Count== 0)
            {
                throw new ArgumentException("The list of moves is empty!");
            }
            return moves.OrderBy(move => move.Name).ToList();
        }
    }
}
