//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionDeStock
{
    using System;
    using System.Collections.Generic;
    
    public partial class Commande
    {
        public Commande()
        {
            this.DetailsCommande = new HashSet<DetailsCommande>();
        }
    
        public int Id_commande { get; set; }
        public System.DateTime Date_commande { get; set; }
        public int Id_client { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual ICollection<DetailsCommande> DetailsCommande { get; set; }
    }
}
