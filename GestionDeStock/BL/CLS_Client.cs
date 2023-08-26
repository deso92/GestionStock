using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Client
    {
        private GestionStockEntities db = new GestionStockEntities();
        private Client Clt;

        //Ajouter client dans la base
        public bool AjouterClient(string Nom, string Prenom, string Adresse, string Email, string Tel, string Pays, string Ville)
        {
            Client clt = new Client();
            clt.Nom_client = Nom;
            clt.Prenom_client = Prenom;
            clt.Adresse_client = Adresse;
            clt.Email_client = Email;
            clt.Telephone_client = Tel;
            clt.Pays_client = Pays;
            clt.Ville_client = Ville;
            
            //On vérifie si le nom et le prénom existe déja dans la base
            if(db.Client.SingleOrDefault(s=>s.Nom_client==Nom && s.Prenom_client == Prenom)==null)
            {
                db.Client.Add(clt);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        //Modifier client dans la base
        public void ModifierClient(int Id, string Nom, string Prenom, string Adresse, string Tel, string Pays, string Ville, string Email)
        {
            Clt = new Client();
            Clt = db.Client.SingleOrDefault(s => s.Id_client == Id);
            if(Clt != null)   
            {
                Clt.Nom_client = Nom;
                Clt.Prenom_client = Prenom;
                Clt.Adresse_client = Adresse;
                Clt.Telephone_client = Tel;
                Clt.Pays_client = Pays;
                Clt.Ville_client = Ville;
                Clt.Email_client = Email;
                db.SaveChanges();
            }
        }

        public string SupprimerClient(int IdClient)
        {
            Clt = new Client();
            Clt = db.Client.SingleOrDefault(s => s.Id_client == IdClient);
            if(Clt != null)
            {
                db.Client.Remove(Clt);
                db.SaveChanges();
                return "Suppression avec succès";
            }
            else
            {
                return "Suppression échouée";
            }
            return null;
        }
    }
}
