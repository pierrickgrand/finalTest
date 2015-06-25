﻿using System;
using System.Collections.Generic;

namespace FinalTest.Tests
{
   
        public class CompteBancaire
        {
            private readonly string _numéroDeCompte;


            public CompteBancaire(CompteCréé newEvent, DépotRéalisé dépotRéalisé = null)
            {
                _numéroDeCompte = newEvent._numéroDeCompte;
            }


            public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
            {
                yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);
            }


            public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
            {
                yield return new DépotRéalisé(_numéroDeCompte, montantDepot, dateDepot);
            }


            public IEnumerable<IEvenementMetier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
            {
                yield return new RetraitRéalisé(_numéroDeCompte, montantRetrait, dateRetrait);
            }
        }
}