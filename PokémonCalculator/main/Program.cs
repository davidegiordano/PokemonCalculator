using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokémonCalculator.model.types;
using PokémonCalculator.model.pokémon;
using Type = PokémonCalculator.model.types.Type;
using PokémonCalculator.model.natures;
using PokémonCalculator.persistence;
using PokémonCalculator.controller;
using PokémonCalculator.view;

namespace PokémonCalculator.main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*List<Type> type = new List<Type>();
            type.Add(Electric.Instance);
            type.Add(Flying.Instance);
            uint level = 50;
            Dictionary<Stats, uint> baseStats = new Dictionary<Stats, uint>();
            baseStats.Add(Stats.HP, 79);
            baseStats.Add(Stats.Attack, 115);
            baseStats.Add(Stats.Defense, 70);
            baseStats.Add(Stats.SpecialAttack, 125);
            baseStats.Add(Stats.SpecialDefense, 80);
            baseStats.Add(Stats.Speed, 111);
            uint total = 580;
            IV ivs = IV.MaxIV();
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            evs.Add(Stats.HP, 4);
            evs.Add(Stats.Attack, 252);
            evs.Add(Stats.Defense, 0);
            evs.Add(Stats.SpecialAttack, 0);
            evs.Add(Stats.SpecialDefense, 0);
            evs.Add(Stats.Speed, 252);
            Nature nature = Jolly.Instance;

            Move wildCharge = new Move(528, "Wild Charge", Electric.Instance, Category.Physical, 90, 100,
                "The user shrouds itself in electricity and smashes into its target. This also damages the user a little.", 15, isFixedDamage: false);
            Move fly = new Move(19, "Fly", Flying.Instance, Category.Physical, 90, 95,
                "The user flies up into the sky and then strikes its target on the next turn.", 15, isFixedDamage: false);
            Move protect = new Move(182, "Protect", Normal.Instance, Category.Status, null, null,
                "This move enables the user to protect itself from all attacks. Its chance of failing rises if it is used in succession.", 10, isFixedDamage: false);
            Move brickBreak = new Move(280, "Brick Break", Fighting.Instance, Category.Physical, 75, 100,
                "The user attacks with a swift chop. It can also break barriers, such as Light Screen and Reflect.", 15, isFixedDamage: false);
            List<Move> moves = new List<Move>();
            moves.Add(wildCharge);
            moves.Add(fly);
            moves.Add(protect);
            moves.Add(brickBreak);

            Pokémon pokémon1 = new Pokémon(642, "Thundurus", type, level, new BaseStats(baseStats, total), 5, ivs, new EV(evs), nature, moves);

            Console.WriteLine(pokémon1.VerboseToString());

            type = new List<Type>();
            type.Add(Water.Instance);
            level = 50;
            baseStats = new Dictionary<Stats, uint>();
            baseStats.Add(Stats.HP, 100);
            baseStats.Add(Stats.Attack, 100);
            baseStats.Add(Stats.Defense, 90);
            baseStats.Add(Stats.SpecialAttack, 150);
            baseStats.Add(Stats.SpecialDefense, 140);
            baseStats.Add(Stats.Speed, 90);
            total = 670;

            evs = new Dictionary<Stats, uint>();
            evs.Add(Stats.HP, 4);
            evs.Add(Stats.Attack, 0);
            evs.Add(Stats.Defense, 0);
            evs.Add(Stats.SpecialAttack, 252);
            evs.Add(Stats.SpecialDefense, 0);
            evs.Add(Stats.Speed, 252);
            nature = Timid.Instance;

            Move waterSpout = new Move(323, "Water Spout", Water.Instance, Category.Special, 150, 100,
                "The user spouts water to damage opposing Pokémon. The lower the user's HP, the lower the move's power.", 5, isFixedDamage: false);
            Move iceBeam = new Move(58, "Ice Beam", Ice.Instance, Category.Special, 90, 100,
                "The target is struck with an icy-cold beam of energy. This may also leave the target frozen.", 10, isFixedDamage: false);
            Move originPulse = new Move(618, "Origin Pulse", Water.Instance, Category.Special, 110, 85,
                "The user attacks opposing Pokémon with countless beams of light that glow a deep and brilliant blue. ", 10, isFixedDamage: false);

            moves = new List<Move>();
            moves.Add(waterSpout);
            moves.Add(iceBeam);
            moves.Add(originPulse);
            moves.Add(protect);

            Pokémon pokémon2 = new Pokémon(382, "Kyogre", type, level, new BaseStats(baseStats, total), 3, ivs, new EV(evs), nature, moves);

            Console.WriteLine(pokémon2.VerboseToString());

            Calculator calculator = new Calculator(pokémon1, pokémon2);
            calculator.CalculateDamageFrom1To2(wildCharge);
            calculator.CalculateDamageFrom2To1(waterSpout);
            //https://www.pikalytics.com/calc?attSet=eyJuYW1lIjoiS3lvZ3JlIiwic2V0Ijp7ImFiaWxpdHkiOiJEcml6emxlIiwiZXZzIjp7ImF0IjowLCJkZiI6MCwiaHAiOjQsInNhIjoyNTIsInNkIjowLCJzcCI6MjUyfSwiaXRlbSI6IiIsImxldmVsIjo1MCwibW92ZXMiOlsiV2F0ZXIgU3BvdXQiLCJJY2UgQmVhbSIsIk9yaWdpbiBQdWxzZSJdLCJpdnMiOnsiYXRrIjozMSwiZGVmIjozMSwiaHAiOjMxLCJzcGEiOjMxLCJzcGQiOjMxLCJzcGUiOjMxfSwibmF0dXJlIjoiVGltaWQifX0=&defSet=eyJuYW1lIjoiVGh1bmR1cnVzIiwic2V0Ijp7ImFiaWxpdHkiOiJEZWZpYW50IiwiZXZzIjp7ImF0IjoyNTIsImRmIjowLCJocCI6NCwic2EiOjAsInNkIjowLCJzcCI6MjUyfSwiaXRlbSI6IiIsImxldmVsIjo1MCwibW92ZXMiOlsiV2lsZCBDaGFyZ2UiLCJGbHkiLCJCcmljayBCcmVhayJdLCJpdnMiOnsiYXRrIjozMSwiZGVmIjozMSwiaHAiOjMxLCJzcGEiOjMxLCJzcGQiOjMxLCJzcGUiOjMxfSwibmF0dXJlIjoiSm9sbHkifX0=
            */

            /*ParsePokémon parserPokémon = ParsePokémon.Instance;
            ParseMoves parserMoves = ParseMoves.Instance;

            List<Move> moves = new List<Move>();
            IV ivs = IV.MaxIV();
            Dictionary<Stats, uint> evs = new Dictionary<Stats, uint>();
            evs.Add(Stats.HP, 4);
            evs.Add(Stats.Attack, 252);
            evs.Add(Stats.Defense, 0);
            evs.Add(Stats.SpecialAttack, 0);
            evs.Add(Stats.SpecialDefense, 0);
            evs.Add(Stats.Speed, 252);
            Nature nature = Jolly.Instance;

            Pokémon pokémon1 = parserPokémon.GetPokémonByName("Thundurus-Incarnate Forme");
            pokémon1.SetIVs(ivs);
            pokémon1.SetEVs(new EV(evs));
            pokémon1.Nature = nature;
            moves.Add(parserMoves.GetMoveByName("Wild Charge"));
            moves.Add(parserMoves.GetMoveByName("Fly"));
            moves.Add(parserMoves.GetMoveByName("Protect"));
            moves.Add(parserMoves.GetMoveByName("Brick Break"));
            pokémon1.Moves = moves;

            evs = new Dictionary<Stats, uint>();
            evs.Add(Stats.HP, 4);
            evs.Add(Stats.Attack, 0);
            evs.Add(Stats.Defense, 0);
            evs.Add(Stats.SpecialAttack, 252);
            evs.Add(Stats.SpecialDefense, 0);
            evs.Add(Stats.Speed, 252);
            nature = Timid.Instance;

            Pokémon pokémon2 = parserPokémon.GetPokémonByName("Kyogre");
            pokémon2.SetIVs(ivs);
            pokémon2.SetEVs(new EV(evs));
            pokémon2.Nature = nature;
            moves = new List<Move>();
            moves.Add(parserMoves.GetMoveByName("Water Spout"));
            moves.Add(parserMoves.GetMoveByName("Origin Pulse"));
            moves.Add(parserMoves.GetMoveByName("Protect"));
            moves.Add(parserMoves.GetMoveByName("Ice Beam"));
            pokémon2.Moves = moves;
            

            Calculator calculator = Calculator.Instance;

            calculator.CalculateDamageFrom1To2("Wild Charge");
            calculator.CalculateDamageFrom2To1("Water Spout");
            //https://www.pikalytics.com/calc?attSet=eyJuYW1lIjoiS3lvZ3JlIiwic2V0Ijp7ImFiaWxpdHkiOiJEcml6emxlIiwiZXZzIjp7ImF0IjowLCJkZiI6MCwiaHAiOjQsInNhIjoyNTIsInNkIjowLCJzcCI6MjUyfSwiaXRlbSI6IiIsImxldmVsIjo1MCwibW92ZXMiOlsiV2F0ZXIgU3BvdXQiLCJJY2UgQmVhbSIsIk9yaWdpbiBQdWxzZSJdLCJpdnMiOnsiYXRrIjozMSwiZGVmIjozMSwiaHAiOjMxLCJzcGEiOjMxLCJzcGQiOjMxLCJzcGUiOjMxfSwibmF0dXJlIjoiVGltaWQifX0=&defSet=eyJuYW1lIjoiVGh1bmR1cnVzIiwic2V0Ijp7ImFiaWxpdHkiOiJEZWZpYW50IiwiZXZzIjp7ImF0IjoyNTIsImRmIjowLCJocCI6NCwic2EiOjAsInNkIjowLCJzcCI6MjUyfSwiaXRlbSI6IiIsImxldmVsIjo1MCwibW92ZXMiOlsiV2lsZCBDaGFyZ2UiLCJGbHkiLCJCcmljayBCcmVhayJdLCJpdnMiOnsiYXRrIjozMSwiZGVmIjozMSwiaHAiOjMxLCJzcGEiOjMxLCJzcGQiOjMxLCJzcGUiOjMxfSwibmF0dXJlIjoiSm9sbHkifX0=

            */

            MainForm mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}