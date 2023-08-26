using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Connexion
    {
        public bool ConnexionValide(GestionStockEntities db, string Mail, string MotDePasse)
        {
            Utilisateurs U = new Utilisateurs();
            U.email_utilisateur = Mail;
            U.Mot_de_passe = MotDePasse;
            if(db.Utilisateurs.SingleOrDefault(s=>s.email_utilisateur == Mail && s.Mot_de_passe == MotDePasse)!=null)
            {
                return true;
            }else
            {
                return false;
            }
            
        }
    }
}
