using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalTest.Tests;

namespace FinalTest
{
    public class Multiplication : IOperation
    {

        public Boolean PeutCalculer(string valeurString)
        {
            String[] str = valeurString.Split('*');

            if (str.Length != 2) return false;

            return true;
        }

        public double Calculer(string valeurString)
        {
            String[] str = valeurString.Split('*');

            if (!PeutCalculer(valeurString)) return 0;

            double nb1 = Convert.ToDouble(str[0]);
            double nb2 = Convert.ToDouble(str[1]);

            return nb1 * nb2;
        }
    }
}
