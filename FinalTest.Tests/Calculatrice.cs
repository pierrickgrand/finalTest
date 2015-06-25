using System;

namespace FinalTest.Tests
{
    public class Calculatrice
    {
        private IOperation []operation;
        public Calculatrice(IOperation []operation)
        {
            this.operation = operation;
        }

        public double Calculer(string p0)
        {
            for (int i = 0; i < operation.Length; i++)
            {
                if (operation[i].PeutCalculer(p0))
                {
                    return operation[i].Calculer(p0);
                }
            }
            return -1;
        }
    }
}