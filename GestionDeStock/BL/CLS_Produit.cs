using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Produit
    {
        private GestionStockEntities db = new GestionStockEntities();
        private Produit prod;

        public bool AjouterProduit(string NomP, int QteProd, string PrixProd, Byte[] ImageProduit, int IdCategorieProd)
        {
            prod = new Produit();
            prod.Nom_produit = NomP;
            prod.Quantite_produit = QteProd;
            prod.Prix_produit = PrixProd;
            prod.Id_categororie = IdCategorieProd;
            prod.Image_produit = ImageProduit;

            //Vérifier si le produit existe déjà dans la base d données
            if(db.Produit.SingleOrDefault(s=>s.Nom_produit == NomP)!=null)
            {
                return false;
            } else
            {
                db.Produit.Add(prod);
                db.SaveChanges();
                return true;

            }    
        }

        public bool ModifierProduit(int Idproduit, string NomP, int QteProd, string PrixProd, Byte[] ImageProduit, int IdCategorieProd)
        {
            Produit Prd = new Produit();
            Prd = db.Produit.SingleOrDefault(s => s.Id_produit == Idproduit);
            if(Prd != null)
            {
                Prd.Nom_produit = NomP;
                Prd.Quantite_produit = QteProd;
                Prd.Prix_produit = PrixProd;
                Prd.Id_categororie = IdCategorieProd;

                //On vérifie si l'image est à modifier ou nom
                if(ImageProduit == null)
                {
                    db.SaveChanges();
                } else
                {
                    Prd.Image_produit = ImageProduit;
                    db.SaveChanges();
                }
                return true;
            }
            return false;
        }

        public bool SupprimerProduit(int Idproduit)
        {
            Produit pr = new Produit();
            pr = db.Produit.SingleOrDefault(s => s.Id_produit == Idproduit);
            if(pr != null)
            {
                db.Produit.Remove(pr);
                db.SaveChanges();
                return true;
            }else
            {
                return false;
            }
        }
    }
}
