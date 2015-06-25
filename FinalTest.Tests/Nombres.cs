using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace FinalTest.Tests
{
    public class Nombres
    {
        private IEnumerable<KeyValuePair<string, int>> _keyValuePairs;
        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
           _keyValuePairs = keyValuePairs;
        }

        private bool is_pair(int nb)
        {
            if ((nb % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        IEnumerable<int> keep_only_pair_number()
        {
            return _keyValuePairs.Select(pair => pair.Value).Where(number => is_pair(number));
        }


        public IEnumerable<int> NombresPairs
        {

            get
            {
                return keep_only_pair_number();
            }
         
        }

        public string text_liste()
        {
            return _keyValuePairs.OrderBy(x => x.Value).Where(number => !is_pair(number.Value))
                .Select(pair => pair.Key).Aggregate((i, j) => i + ", " + j);


        }

        public string TexteNombresImpairs
        {
            get { return text_liste(); }
        }

        public string PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get
            {
               return  _keyValuePairs.Select(pair => pair.Key).First(x=>x.Length>5);
            }
        }

        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get
            {
                return _keyValuePairs.OrderBy(nombre => nombre.Value)
                    .Select(pair => pair.Value)
                    .Where(nombre => nombre > 3)
                    .Skip(0).Take(4); 
            }
        }
    }
}