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
    public partial class FRM_Ajouter_Modifier_Produit : Form
    {
        private GestionStockEntities db;
        private UserControl userProduit;
        public FRM_Ajouter_Modifier_Produit(UserControl user)
        {
            InitializeComponent();
            db = new GestionStockEntities();
            this.userProduit = user;
            //Afficher toutes les catégories dans le comboBox
            comboBoxCatProd.DataSource = db.Categorie.ToList();

            //Affichons seulement le nom dans le combobox
            comboBoxCatProd.DisplayMember = "Nom_categorie";
            comboBoxCatProd.ValueMember = "Id_categorie";
        }

        //Champs obligatoires
        public string ChampsObligatoire()
        {
            if(pictureBoxImageProduit.Image == null)
            {
                return "L'image du produit est obligatoire";
            } else if(TxtNomProduit.Text == "")
            {
                return "Le nom du produit est obligatoire";
            } else if (TxtQteProd.Text == "")
            {
                return "La quantité du produit est obligatoire";
            }
              else if(TxtPrixProd.Text == ""){
                return "Le prix du produit est obligatoire";
            } 
            return null;
        }

        private void BtnFermerFrmClient_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Afficher fichier image
            OpenFileDialog Op = new OpenFileDialog();
            Op.Filter = "|*.JPG;*.PNG;*.GIF;*.GIF;*.JPEG"; //Pour afficher seulement les images
            if(Op.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImageProduit.Image = Image.FromFile(Op.FileName);
            }
        }

        private void BtnActualiserClient_Click(object sender, EventArgs e)
        {
            TxtPrixProd.Text = "";
            TxtQteProd.Text = "";
            TxtNomProduit.Text = "";
            pictureBoxImageProduit.Image = null;
        }

        private void TxtQteProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 45 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void TxtPrixProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 45 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        public int IDSelectList;

        private void BtnEnregistrerClient_Click(object sender, EventArgs e)
        {
            if(ChampsObligatoire() != null)
            {
                MessageBox.Show(ChampsObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if(LblAjouterModifierProduit.Text == "Ajouter Produit") 
                {
                    BL.CLS_Produit prod = new BL.CLS_Produit();

                    //On convertir l'image en format Byte
                    //On ajoute System.Io

                    MemoryStream MR = new MemoryStream();
                    pictureBoxImageProduit.Image.Save(MR, pictureBoxImageProduit.Image.RawFormat);
                    Byte[] byteImageP = MR.ToArray();//Convertir l'image en format byte[]

                    if(prod.AjouterProduit(TxtNomProduit.Text, int.Parse(TxtQteProd.Text), TxtPrixProd.Text, byteImageP, Convert.ToInt32(comboBoxCatProd.SelectedValue)) == true)
                    {
                        (userProduit as USER_Liste_Produit).ActualiserDataViewGridProduit();
                        MessageBox.Show("Produit ajouté avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //On actualise les champs après l'enregistrement réussie
                        TxtPrixProd.Text = "";
                        TxtQteProd.Text = "";
                        TxtNomProduit.Text = "";
                        pictureBoxImageProduit.Image = null;
                    } else
                    {
                        MessageBox.Show("Le produit existe déjà dans la base", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    BL.CLS_Produit prod = new BL.CLS_Produit();
                    DialogResult R = MessageBox.Show("Voulez vous vraiment modifier le produit ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        // Si l'image de produit doit être modifiée
                        if(pictureBoxImageProduit.Image != null)
                        {
                            //On convertir l'image en format Byte
                            //On ajoute System.Io
                            MemoryStream MR = new MemoryStream();
                            pictureBoxImageProduit.Image.Save(MR, pictureBoxImageProduit.Image.RawFormat);
                            Byte[] byteImageP = MR.ToArray();//Convertir l'image en format byte[]
                            if (prod.ModifierProduit(IDSelectList, TxtNomProduit.Text, int.Parse(TxtQteProd.Text), TxtPrixProd.Text, byteImageP, Convert.ToInt32(comboBoxCatProd.SelectedValue)) == true)
                            {
                                (userProduit as USER_Liste_Produit).ActualiserDataViewGridProduit();
                                MessageBox.Show("Produit modifié avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                //On actualise les champs après l'enregistrement réussie
                                TxtPrixProd.Text = "";
                                TxtQteProd.Text = "";
                                TxtNomProduit.Text = "";
                                pictureBoxImageProduit.Image = null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Veuillez sélectionner l'image du produit", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
              
            }
        }
    }
}
