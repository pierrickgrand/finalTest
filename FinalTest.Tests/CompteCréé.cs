namespace FinalTest.Tests
{
    public class CompteCréé : IEvenementMetier 
     { 
        public string _numéroDeCompte; 
        public int _autorisationDeCrédit; 

 
        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit) 
         { 
             _numéroDeCompte = numéroDeCompte; 
             _autorisationDeCrédit = autorisationDeCrédit; 
         } 
 
 
         // override object.Equals 
         public override bool Equals(object obj) 
         { 
             if (obj == null || GetType() != obj.GetType()) 
             { 
                 return false; 
             } 
 
 
             CompteCréé compteCrééObj = obj as CompteCréé; 
 
 
             if (compteCrééObj._numéroDeCompte != this._numéroDeCompte) return false; 
             if (compteCrééObj._autorisationDeCrédit != this._autorisationDeCrédit) return false; 
 
 
             return true; 
         } 
     } 

}