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
    
    public partial class Client
    {
        public Client()
        {
            this.Commande = new HashSet<Commande>();
        }
    
        public int Id_client { get; set; }
        public string Nom_client { get; set; }
        public string Prenom_client { get; set; }
        public string Adresse_client { get; set; }
        public string Telephone_client { get; set; }
        public string Pays_client { get; set; }
        public string Ville_client { get; set; }
        public string Email_client { get; set; }
    
        public virtual ICollection<Commande> Commande { get; set; }
    }
}
