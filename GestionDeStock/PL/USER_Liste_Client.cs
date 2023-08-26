using GestionDeStock.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class USER_Liste_Client : UserControl
    {
        private static USER_Liste_Client Userclient;
        private GestionStockEntities db;
        public static USER_Liste_Client Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_Liste_Client();
                }
                return Userclient;
            }
        }
        public USER_Liste_Client()
        {
            InitializeComponent();
            db = new GestionStockEntities();

            //Désactiver TextBox rechercher client
            TxtRechercherClient.Enabled = false;
        }

        //Ajouter dans DataViewGrid

        public void ActualiserDataViewGrid()
        {
            db = new GestionStockEntities();
            DgvClient.Rows.Clear(); // Vider dataviewgrid
            foreach (var s in db.Client)
            {
                DgvClient.Rows.Add(false, s.Id_client, s.Nom_client, s.Prenom_client, s.Adresse_client, s.Telephone_client, s.Pays_client, s.Ville_client, s.Email_client);
            }
        }

        public string VerifSect()
        {
            int NombreSelectionner = 0;

            // Parcours de toutes les lignes du DataGridView

            // Parcourez les lignes du DataGridView
            for (int i = 0; i < DgvClient.Rows.Count; i++)
            {
                // Vérifiez si la case à cocher est cochée pour la ligne actuelle
                DataGridViewCheckBoxCell checkboxCell = DgvClient.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkboxCell.Value) == true)
                {
                    NombreSelectionner++;
                }
            }

            if (NombreSelectionner == 0)
            {
                return "Sélectionner le client que vous voulez modifier";
            }
            if (NombreSelectionner > 1)
            {
                return "Sélectionner seulement un seul client pour modifier";
            }

            return null;
        }

        private void TxtRechercher_Enter(object sender, EventArgs e)
        {
            if (TxtRechercherClient.Text == "Rechercher")
            {
                TxtRechercherClient.Text = "";
                TxtRechercherClient.ForeColor = Color.Black;
            }
        }

        private void USER_Liste_Client_Load(object sender, EventArgs e)
        {
            ActualiserDataViewGrid();
        }

        private void BtnAjouterClient_Click(object sender, EventArgs e)
        {

        }

        private void BtnModifierClient_Click(object sender, EventArgs e)
        {

        }

        private void BtnAjouterClient_Click_1(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Client frmclient = new PL.FRM_Ajouter_Modifier_Client(this);
            frmclient.ShowDialog();
        }


        private void BtnModifierClient_Click_1(object sender, EventArgs e)
        {

            PL.FRM_Ajouter_Modifier_Client frmClient = new PL.FRM_Ajouter_Modifier_Client(this);
            if (VerifSect() == null)
            {


                for (int i = 0; i < DgvClient.Rows.Count; i++)
                {
                    // Vérifiez si la case à cocher est cochée pour la ligne actuelle
                    DataGridViewCheckBoxCell checkboxCell = DgvClient.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(checkboxCell.Value) == true)
                    {
                        frmClient.IDSelectList = (int)DgvClient.Rows[i].Cells[1].Value;
                        frmClient.txtNom.Text = DgvClient.Rows[i].Cells[2].Value.ToString();
                        frmClient.TxtPrenom.Text = DgvClient.Rows[i].Cells[3].Value.ToString();
                        frmClient.TxtAdresse.Text = DgvClient.Rows[i].Cells[4].Value.ToString();
                        frmClient.TxtTel.Text = DgvClient.Rows[i].Cells[5].Value.ToString();
                        frmClient.TxtPays.Text = DgvClient.Rows[i].Cells[6].Value.ToString();
                        frmClient.TxtVille.Text = DgvClient.Rows[i].Cells[7].Value.ToString();
                        frmClient.TxtEmail.Text = DgvClient.Rows[i].Cells[8].Value.ToString();

                    }
                }


                frmClient.LblAjouterModifierClient.Text = "Modifier client";
                frmClient.BtnActualiserClient.Visible = false;
                frmClient.BtnEnregistrerClient.Text = "Modifier";
                frmClient.ShowDialog();
            }
            else
            {
                MessageBox.Show(VerifSect(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnSupprimerClient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Client frmClient = new PL.FRM_Ajouter_Modifier_Client(this);
            BL.CLS_Client client = new CLS_Client();


            int NombreSelectionner = 0;

            // Parcours de toutes les lignes du DataGridView

            // Parcourez les lignes du DataGridView
            for (int i = 0; i < DgvClient.Rows.Count; i++)
            {
                // Vérifiez si la case à cocher est cochée pour la ligne actuelle
                DataGridViewCheckBoxCell checkboxCell = DgvClient.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkboxCell.Value) == true)
                {
                    NombreSelectionner++;
                }
            }

            if (NombreSelectionner == 0)
            {
                MessageBox.Show("Aucun client sélectionné", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez vous vraiment supprimer le(s) client(s) ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < DgvClient.Rows.Count; i++)
                    {
                        // Vérifiez si la case à cocher est cochée pour la ligne actuelle
                        DataGridViewCheckBoxCell checkboxCell = DgvClient.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(checkboxCell.Value) == true)
                        {
                            client.SupprimerClient(int.Parse(DgvClient.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    ActualiserDataViewGrid();
                    MessageBox.Show("Suppression avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression échouée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

        private void ComboRechClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Activer le textBox de recherche client une fois le champ sélectionné
            TxtRechercherClient.Enabled = true;
            TxtRechercherClient.Text = "";

        }

        private void TxtRechercherClient_TextChanged(object sender, EventArgs e)
        {
            db = new GestionStockEntities();
            var listClientRechercher = db.Client.ToList(); //Liste des clients recherchés
            if(TxtRechercherClient.Text !="")
            {
                switch (ComboRechClient.Text)
                {
                    case "Nom":
                        listClientRechercher = listClientRechercher.Where(s => s.Nom_client.IndexOf(TxtRechercherClient.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        //StringComparison.CurrentCultureIgnoreCase == soit j'ai écrit la première lettre en majuscule ou minuscule 
                        // != -1 == existe dans la base de données
                        break;
                    case "Prenom":
                        listClientRechercher = listClientRechercher.Where(s => s.Prenom_client.IndexOf(TxtRechercherClient.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Adresse":
                        listClientRechercher = listClientRechercher.Where(s => s.Adresse_client.IndexOf(TxtRechercherClient.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Téléphone":
                        listClientRechercher = listClientRechercher.Where(s => s.Telephone_client.IndexOf(TxtRechercherClient.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Pays":
                        listClientRechercher = listClientRechercher.Where(s => s.Pays_client.IndexOf(TxtRechercherClient.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Ville":
                        listClientRechercher = listClientRechercher.Where(s => s.Ville_client.IndexOf(TxtRechercherClient.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        listClientRechercher = listClientRechercher.Where(s => s.Email_client.IndexOf(TxtRechercherClient.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                }
            }
            //Vider le datagrid view
            DgvClient.Rows.Clear();
            foreach(var l in listClientRechercher)
            {
                DgvClient.Rows.Add(false, l.Id_client, l.Nom_client, l.Prenom_client, l.Adresse_client, l.Telephone_client, l.Pays_client, l.Ville_client, l.Email_client);
            }
        }
    }
}
