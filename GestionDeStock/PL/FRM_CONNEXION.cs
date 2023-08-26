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
    public partial class FRM_CONNEXION : Form
    {
        private GestionStockEntities db;
        private Form formMenu;
        //Classe de connexion
        BL.CLS_Connexion Con = new BL.CLS_Connexion();


        public FRM_CONNEXION(Form Menu)
        {
            InitializeComponent();
            this.formMenu = Menu;
            db = new GestionStockEntities();
        }

        string VerifTextBoxUtilisateur()
        {
            if(TxbMailUtilisateur.Text == "")
            {
                return "Entrer le nom d'utilisateur";
            }
            else if(TxbMotDePasse.Text == "")
            {
                return "Entrer le mot de passe";
            }
            return null;
        }

        private void BtnFermerLoginPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSeConnecter_Click(object sender, EventArgs e)
        {
        }

        private void TxbMotDePasse_Enter(object sender, EventArgs e)
        {
            TxbMotDePasse.PasswordChar = '*';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSeConnecter_Click_2(object sender, EventArgs e)
        {
            if (VerifTextBoxUtilisateur() == null)
            {
                //MessageBox.Show(TxbMailUtilisateur.Text);
                if (Con.ConnexionValide(db, TxbMailUtilisateur.Text, TxbMotDePasse.Text) == true)
                {
                    MessageBox.Show("Connexion réussie", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (formMenu as FRM_MENU).activeForm();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Connexion échouée", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(VerifTextBoxUtilisateur(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
