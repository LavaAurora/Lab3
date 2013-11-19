using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_Commande
{
    public class ProducteurRequetes
    {

        public List<ICommande> produire()
        {
            List<ICommande> list = new List<ICommande>();

            //Ajoute les commandes concrètes
            list.Add(new Programmeur());
            list.Add(new Politicien());
            list.Add(new IngenieurDomestique());

            return list;
            
        }

    }
}
