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
    public partial class FRM_MENU : Form
    {
        public FRM_MENU()
        {
            InitializeComponent();
            PnlParametre.Visible = false;
        }

        //Fonction pour désactiver les rubriques du menu tant que l'utilisateur n'est connecté
        public void desactiveForm()
        {
            BtnClient.Enabled = false;
            BtnCategorie.Enabled = false;
            BtnCommande.Enabled = false;
            BtnProduit.Enabled = false;
            BtnSeDeconnecter.Enabled = false;
            BtnUtilisateur.Enabled = false;
            BtnRestaurer.Enabled = false;
            BtnCopie.Enabled = false;
            PnlBut.Enabled = false;
            BtnSeConnecter.Enabled = true;
        }

        //Fonction pour activer les rubriques du menu si l'utilisateur est connecté
        public void activeForm()
        {
            BtnClient.Enabled = true;
            BtnCategorie.Enabled = true;
            BtnCommande.Enabled = true;
            BtnProduit.Enabled = true;
            BtnSeDeconnecter.Enabled = true;
            BtnUtilisateur.Enabled = true;
            BtnRestaurer.Enabled = true;
            BtnCopie.Enabled = true;
            PnlBut.Enabled = true;
            BtnSeConnecter.Enabled = false;
            PnlParametre.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnProduit_Click(object sender, EventArgs e)
        {
            PnlBut.Top = BtnProduit.Top;
            if (!PnlAfficher.Controls.Contains(USER_Liste_Produit.Instance))
            {
                PnlAfficher.Controls.Add(USER_Liste_Produit.Instance);
                USER_Liste_Produit.Instance.Dock = DockStyle.Fill;
                USER_Liste_Produit.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Produit.Instance.BringToFront();
            }
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            PnlBut.Top = BtnClient.Top;
            if(!PnlAfficher.Controls.Contains(USER_Liste_Client.Instance))
            {
                PnlAfficher.Controls.Add(USER_Liste_Client.Instance);
                USER_Liste_Client.Instance.Dock = DockStyle.Fill;
                USER_Liste_Client.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Client.Instance.BringToFront();
            }
        }

        private void BtnCategorie_Click(object sender, EventArgs e)
        {
            PnlBut.Top = BtnCategorie.Top;
        }

        private void BtnCommande_Click(object sender, EventArgs e)
        {
            PnlBut.Top = BtnCommande.Top;
        }

        private void BtnUtilisateur_Click(object sender, EventArgs e)
        {
            PnlBut.Top = BtnUtilisateur.Top;
        }

        private void BtnParamètre_Click(object sender, EventArgs e)
        {
            PnlParametre.Visible = !PnlParametre.Visible;
        }

        private void BtnSeConnecter_Click(object sender, EventArgs e)
        {
            FRM_CONNEXION frmconx = new FRM_CONNEXION(this);//This = FRM_MENU
            frmconx.ShowDialog();
        }

        private void FRM_MENU_Load(object sender, EventArgs e)
        {
            desactiveForm();
        }

        private void BtnSeDeconnecter_Click(object sender, EventArgs e)
        {
            desactiveForm();
        }
    }
}
