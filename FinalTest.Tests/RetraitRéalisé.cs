using System;

namespace FinalTest.Tests
{
    
     public class RetraitRéalisé : IEvenementMetier 
     { 
         private readonly string _numéroDeCompte; 
         private readonly Montant _montantRetrait; 
         private readonly DateTime _dateRetrait; 
 
 
         public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait) 
         { 
             _numéroDeCompte = numéroDeCompte; 
             _montantRetrait = montantRetrait; 
             _dateRetrait = dateRetrait; 
         } 
 
 
         // override object.Equals 
         public override bool Equals(object obj) 
         { 
             if (obj == null || GetType() != obj.GetType()) 
             { 
                 return false; 
             } 
 
 
             RetraitRéalisé dépotRéalisé = obj as RetraitRéalisé; 
 
 
             if (dépotRéalisé._numéroDeCompte != this._numéroDeCompte) return false; 
             if (dépotRéalisé._montantRetrait != this._montantRetrait) return false; 
             if (dépotRéalisé._dateRetrait != this._dateRetrait) return false; 
 
 
             return true; 
         } 
    } 

}