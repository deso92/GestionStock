using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestionDeStock.PL
{
    public partial class USER_Liste_Produit : UserControl
    {
        private static USER_Liste_Produit Userproduit;
        private GestionStockEntities db;
        public static USER_Liste_Produit Instance
        {
            get
            {
                if (Userproduit == null)
                {
                    Userproduit = new USER_Liste_Produit();
                }
                return Userproduit;
            }
        }
        public USER_Liste_Produit()
        {
            InitializeComponent();
            db = new GestionStockEntities();
            TxtRechercherProduit.Enabled = false;
        }

        public string VerifSectProduit()
        {
            int NombreSelectionner = 0;

            // Parcours de toutes les lignes du DataGridView

            // Parcourez les lignes du DataGridView
            for (int i = 0; i < DgvProduit.Rows.Count; i++)
            {
                // Vérifiez si la case à cocher est cochée pour la ligne actuelle
                DataGridViewCheckBoxCell checkboxCell = DgvProduit.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkboxCell.Value) == true)
                {
                    NombreSelectionner++;
                }
            }

            if (NombreSelectionner == 0)
            {
                return "Aucun produit sélectionné";
            }
            if (NombreSelectionner > 1)
            {
                return "Veuillez sélectionner un seul produit";
            }

            return null;
        }

        public void ActualiserDataViewGridProduit()
        {
            db = new GestionStockEntities();
            DgvProduit.Rows.Clear(); // Vider dataviewgrid
            //Jointure 
            Categorie cat = new Categorie();
            foreach (var s in db.Produit)
            {
                //Si le Id_categorie de Categorie ==  id_categorie de produit
                cat = db.Categorie.SingleOrDefault(d => d.Id_categorie == s.Id_categororie);
                //On affiche le nom de la catégorie
                DgvProduit.Rows.Add(false, s.Id_produit, s.Nom_produit, s.Quantite_produit, s.Prix_produit, cat.Nom_categorie);
            }
        }

        private void BtnSupprimerClient_Click(object sender, EventArgs e)
        {
            BL.CLS_Produit Pr = new BL.CLS_Produit();

            int NombreSelectionner = 0;

            // Parcours de toutes les lignes du DataGridView

            // Parcourez les lignes du DataGridView
            for (int i = 0; i < DgvProduit.Rows.Count; i++)
            {
                // Vérifiez si la case à cocher est cochée pour la ligne actuelle
                DataGridViewCheckBoxCell checkboxCell = DgvProduit.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkboxCell.Value) == true)
                {
                    NombreSelectionner++;
                }
            }

            if (NombreSelectionner == 0)
            {
                MessageBox.Show("Aucun produit sélectionné", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult R= MessageBox.Show("Voulez vous vraiment supprimer le(s) produit sélectionné ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    
                    for (int i = 0; i < DgvProduit.Rows.Count; i++)
                    {
                        // Vérifiez si la case à cocher est cochée pour la ligne actuelle
                        DataGridViewCheckBoxCell checkboxCell = DgvProduit.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(checkboxCell.Value) == true)
                        {
                            Pr.SupprimerProduit(int.Parse(DgvProduit.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    ActualiserDataViewGridProduit();
                    MessageBox.Show("Suppression avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
        }

        private void BtnAjouterProduit_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Produit prod = new PL.FRM_Ajouter_Modifier_Produit(this);
            prod.ShowDialog();
        }

        private void BtnModifierProduit_Click(object sender, EventArgs e)
        {
           
            if(VerifSectProduit() == null)
            {
                PL.FRM_Ajouter_Modifier_Produit prod = new PL.FRM_Ajouter_Modifier_Produit(this);

                for (int i = 0; i < DgvProduit.Rows.Count; i++)
                {
                    // Vérifiez si la case à cocher est cochée pour la ligne actuelle
                    DataGridViewCheckBoxCell checkboxCell = DgvProduit.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(checkboxCell.Value) == true)
                    {
                        prod.IDSelectList = (int)DgvProduit.Rows[i].Cells[1].Value;
                        prod.TxtNomProduit.Text = DgvProduit.Rows[i].Cells[2].Value.ToString();
                        prod.TxtQteProd.Text = DgvProduit.Rows[i].Cells[3].Value.ToString();
                        prod.TxtPrixProd.Text = DgvProduit.Rows[i].Cells[4].Value.ToString();

                        int MyIdSelect = (int)DgvProduit.Rows[i].Cells[1].Value;
                        var PR = db.Produit.SingleOrDefault(s => s.Id_produit == MyIdSelect);

                        MemoryStream MS = new MemoryStream(PR.Image_produit);
                        prod.pictureBoxImageProduit.Image = Image.FromStream(MS);
                    }
                }
                prod.LblAjouterModifierProduit.Text = "Modifier produit";
                prod.BtnActualiserProduit.Visible = false;
                prod.ShowDialog();
            } else
            {
                MessageBox.Show(VerifSectProduit(), "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void USER_Liste_Produit_Load(object sender, EventArgs e)
        {
           ActualiserDataViewGridProduit();
        }

        private void BtnAfficherImageProduit_Click(object sender, EventArgs e)
        {
            if(VerifSectProduit() != null)
            {
                MessageBox.Show(VerifSectProduit(), "Afficher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < DgvProduit.Rows.Count; i++)
                {
                    // Vérifiez si la case à cocher est cochée pour la ligne actuelle
                    DataGridViewCheckBoxCell checkboxCell = DgvProduit.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(checkboxCell.Value) == true)
                    {
                        int MyIdSelect = (int)DgvProduit.Rows[i].Cells[1].Value;
                        var PR = db.Produit.SingleOrDefault(s => s.Id_produit == MyIdSelect);
                        if(PR != null)
                        {
                            PL.FRM_Afficher_Produit frmPhoto = new PL.FRM_Afficher_Produit();
                            MemoryStream MS = new MemoryStream(PR.Image_produit);
                            frmPhoto.pictureBoxAfficherProduit.Image = Image.FromStream(MS);
                            frmPhoto.LblNomProduit.Text = DgvProduit.Rows[i].Cells[2].Value.ToString();
                            frmPhoto.ShowDialog();
                        }
                    }
                }
            }
            
        }

        private void ComboRechProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Activer le textBox de recherche produit une fois le champ sélectionné
            TxtRechercherProduit.Enabled = true;
            TxtRechercherProduit.Text = "";
        }

        private void TxtRechercherProduit_TextChanged(object sender, EventArgs e)
        {
            db = new GestionStockEntities();
            var listProduitRechercher = db.Produit.ToList(); //Liste des clients recherchés
            if (TxtRechercherProduit.Text != "")
            {
                switch (ComboRechProduit.Text)
                {
                    case "Nom du produit":
                        listProduitRechercher = listProduitRechercher.Where(s => s.Nom_produit.IndexOf(TxtRechercherProduit.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        //StringComparison.CurrentCultureIgnoreCase == soit j'ai écrit la première lettre en majuscule ou minuscule 
                        // != -1 == existe dans la base de données
                        break;
                }
            }
            //Vider le datagrid view
            DgvProduit.Rows.Clear();
            foreach (var l in listProduitRechercher)
            {
                DgvProduit.Rows.Add(false, l.Id_produit, l.Nom_produit, l.Quantite_produit, l.Prix_produit, l.Id_categororie);
            }
        }
    }
}
