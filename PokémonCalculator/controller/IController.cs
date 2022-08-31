using PokémonCalculator.model.natures;
using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.controller
{
    public interface IController
    {
        public Pokémon GetPokémon1();
        public void ChangePokémon1(string name);
        public void ViewPokémon1Details();
        public void ChangePokémon1Level(uint level);
        public void ChangePokémon1HPIV(uint value);
        public void ChangePokémon1AttackIV(uint value);
        public void ChangePokémon1DefenseIV(uint value);
        public void ChangePokémon1SpecialAttackIV(uint value);
        public void ChangePokémon1SpecialDefenseIV(uint value);
        public void ChangePokémon1SpeedIV(uint value);
        public void ChangePokémon1HPEV(uint value);
        public void ChangePokémon1AttackEV(uint value);
        public void ChangePokémon1DefenseEV(uint value);
        public void ChangePokémon1SpecialAttackEV(uint value);
        public void ChangePokémon1SpecialDefenseEV(uint value);
        public void ChangePokémon1SpeedEV(uint value);
        public void ChangePokémon1Nature(string name);
        public void ViewPokémon1Moves();
        public void ChangePokémon1Move(string name, int index);
        public void RemovePokémon1Move(Move move);
        public void AddPokémon1Move(Move move);
        public string[] GetPokémon1MovesNames();
        public uint[] GetPokémon1MovesPowers();
        public string[] GetPokémon1MovesTypes();
        public string[] GetPokémon1MovesCategories();
        public string[] GetPokémon1Types();
        public string CalculateDamageFrom1To2(string move);

        public Pokémon GetPokémon2();
        public void ChangePokémon2(string name);
        public void ViewPokémon2Details();
        public void ChangePokémon2Level(uint level);
        public void ChangePokémon2HPIV(uint value);
        public void ChangePokémon2AttackIV(uint value);
        public void ChangePokémon2DefenseIV(uint value);
        public void ChangePokémon2SpecialAttackIV(uint value);
        public void ChangePokémon2SpecialDefenseIV(uint value);
        public void ChangePokémon2SpeedIV(uint value);
        public void ChangePokémon2HPEV(uint value);
        public void ChangePokémon2AttackEV(uint value);
        public void ChangePokémon2DefenseEV(uint value);
        public void ChangePokémon2SpecialAttackEV(uint value);
        public void ChangePokémon2SpecialDefenseEV(uint value);
        public void ChangePokémon2SpeedEV(uint value);
        public void ChangePokémon2Nature(string name);
        public void ViewPokémon2Moves();
        public void ChangePokémon2Move(string name, int index);
        public void RemovePokémon2Move(Move move);
        public void AddPokémon2Move(Move move);
        public string[] GetPokémon2MovesNames();
        public uint[] GetPokémon2MovesPowers();
        public string[] GetPokémon2MovesTypes();
        public string[] GetPokémon2MovesCategories();
        public string[] GetPokémon2Types();
        public string CalculateDamageFrom2To1(string move);
    }
}
