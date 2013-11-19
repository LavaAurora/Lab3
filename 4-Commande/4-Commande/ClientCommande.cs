using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_Commande
{
    /*
     *  NB : le main n'est pas dans cette classe, car on ne peut pas
     *       déclarer de variable de classe dans une classe possédant un main.
     * 
     */

    public class ClientCommande
    {
        private ProducteurRequetes prodreq; //Producteur de requêtes
        private List<ICommande> requetes;   

        public ClientCommande()
        {
            this.prodreq = new ProducteurRequetes();
            this.requetes = this.prodreq.produire();

        }

        public void EnvoiDesRequetes()
        {
            foreach(ICommande commande in this.requetes)
            {
                //Exécute le code de la commande
                commande.Execute();
            }
        }


    }
}
