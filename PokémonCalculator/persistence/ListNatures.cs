using PokémonCalculator.model.natures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonCalculator.persistence
{
    public class ListNatures
    {
        private readonly List<Nature> _natures;
        private static ListNatures _instance = null;

        public static ListNatures Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListNatures();
                }
                return _instance;
            }
        }

        private ListNatures()
        {
            _natures = new List<Nature>();

            _natures.Add(Hardy.Instance);
            _natures.Add(Lonely.Instance);
            _natures.Add(Brave.Instance);
            _natures.Add(Adamant.Instance);
            _natures.Add(Naughty.Instance);
            _natures.Add(Bold.Instance);
            _natures.Add(Docile.Instance);
            _natures.Add(Relaxed.Instance);
            _natures.Add(Impish.Instance);
            _natures.Add(Lax.Instance);
            _natures.Add(Timid.Instance);
            _natures.Add(Hasty.Instance);
            _natures.Add(Serious.Instance);
            _natures.Add(Jolly.Instance);
            _natures.Add(Naive.Instance);
            _natures.Add(Modest.Instance);
            _natures.Add(Mild.Instance);
            _natures.Add(Quiet.Instance);
            _natures.Add(Bashful.Instance);
            _natures.Add(Rash.Instance);
            _natures.Add(Calm.Instance);
            _natures.Add(Gentle.Instance);
            _natures.Add(Sassy.Instance);
            _natures.Add(Careful.Instance);
            _natures.Add(Quirky.Instance);
        }

        public List<Nature> GetNatures()
        {
            return _natures;
        }

        public Nature GetNatureByName(string name)
        {
            Nature result = null;

            switch (name.Trim())
            {
                case "Hardy": result = Hardy.Instance; break;
                case "Lonely": result = Lonely.Instance; break;
                case "Brave": result = Brave.Instance; break;
                case "Adamant": result = Adamant.Instance; break;
                case "Naughty": result = Naughty.Instance; break;
                case "Bold": result = Bold.Instance; break;
                case "Docile": result = Docile.Instance; break;
                case "Relaxed": result = Relaxed.Instance; break;
                case "Impish": result = Impish.Instance; break;
                case "Lax": result = Lax.Instance; break;
                case "Timid": result = Timid.Instance; break;
                case "Hasty": result = Hasty.Instance; break;
                case "Serious": result = Serious.Instance; break;
                case "Jolly": result = Jolly.Instance; break;
                case "Naive": result = Naive.Instance; break;
                case "Modest": result = Modest.Instance; break;
                case "Mild": result = Mild.Instance; break;
                case "Quiet": result = Quiet.Instance; break;
                case "Bashful": result = Bashful.Instance; break;
                case "Rash": result = Rash.Instance; break;
                case "Calm": result = Calm.Instance; break;
                case "Gentle": result = Gentle.Instance; break;
                case "Sassy": result = Sassy.Instance; break;
                case "Careful": result = Careful.Instance; break;
                case "Quirky": result = Quirky.Instance; break;
            }

            return result;
        }
    }
}
