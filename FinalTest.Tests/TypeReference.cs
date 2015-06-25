using NUnit.Framework;

namespace FinalTest.Tests
{
    public class TypeReference
    {
        private int valeur;
        public TypeReference(int valeur)
        {
            this.valeur = valeur;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            TypeReference typeReferenceObj = obj as TypeReference;
            if (typeReferenceObj.valeur != this.valeur) return false;
            return true;
        }

    }
}