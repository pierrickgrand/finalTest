using System;
using System.Collections.Generic;
using System.Linq;

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

        IEnumerable<int> keep_only_number()
        {
            return _keyValuePairs.Select(pair => pair.Value).Where(number => is_pair(number));
        }


        public IEnumerable<int> NombresPairs
        {

            get
            {
                return keep_only_number();
            }
         
        }
    }
}