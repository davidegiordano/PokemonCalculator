﻿using PokémonCalculator.model.pokémon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.model.natures
{
    public class Timid : Nature
    {
        private static Timid _instance = null;
        private Timid() : base(Natures.Timid)
        {
            IncreasedStat = Stats.Speed;
            DecreasedStat = Stats.Attack;
        }
        public static Timid Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Timid();
                }
                return _instance;
            }
        }
    }
}
