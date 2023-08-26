using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GestionDeStock.PL
{
    public partial class FRM_Ajouter_Modifier_Client : Form
    {
        private UserControl userClient;
        public FRM_Ajouter_Modifier_Client(UserControl userControl)
        {
            InitializeComponent();
            this.userClient = userControl;
        }        

        public void actualiserChampsClient()
        {
            txtNom.Text = "";
            TxtAdresse.Text = "";
            TxtEmail.Text = "";
            TxtPays.Text = "";
            TxtPrenom.Text = "";
            TxtVille.Text = "";
            TxtTel.Text = "";
        }

        // Les champs obligatoires

        public string champsClientObligatoire()
        {
            if(txtNom.Text == "")
            {
                return "Le nom est obligatore";
            }
            else if (TxtPrenom.Text == "")
            {
                return "Prénom obligatoire";
            }
            else if(TxtAdresse.Text == "")
            {
                return "Adresse obligatoire";
            }
            else if (TxtTel.Text == "")
            {
                return "Téléphone obligatoire";
            }
            else if(TxtPays.Text == "")
            {
                return "Pays obligatoire";
            }
            else if (TxtEmail.Text == "")
            {
                return "Email obligatoire";
            }
            else if(TxtVille.Text == "")
            {
                return "Ville obligatoire";
            }
             if (TxtEmail.Text != "")
            {
                try
                {
                    new MailAddress(TxtEmail.Text);
                }
                catch (Exception e)
                {
                    return "Email invalide";
                }
            }


            return null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar<45 || e.KeyChar>57)
            {
                e.Handled = true;
            }
            if(e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void BtnActualiserClient_Click(object sender, EventArgs e)
        {
            actualiserChampsClient();


        }

        private void BtnFermerFrmClient_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int IDSelectList;

        private void BtnEnregistrerClient_Click(object sender, EventArgs e)
        {
            if(champsClientObligatoire() != null)
            {
                MessageBox.Show(champsClientObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(LblAjouterModifierClient.Text == "Ajouter Client")
                {
                    BL.CLS_Client cltfrm = new BL.CLS_Client();
                    if (cltfrm.AjouterClient(txtNom.Text, TxtPrenom.Text, TxtAdresse.Text, TxtEmail.Text, TxtTel.Text, TxtPays.Text, TxtVille.Text) == true)
                    {
                        MessageBox.Show("Client ajouté avec succès!", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        actualiserChampsClient();
                        (userClient as USER_Liste_Client).ActualiserDataViewGrid();
                    }
                    else
                    {
                        MessageBox.Show("Nom et prénom existent déjà dans la base", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else // Modifier le client
                {
                    BL.CLS_Client cltfrm = new BL.CLS_Client();
                    DialogResult R = MessageBox.Show("Voulez vous vraiment modifier le client?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        cltfrm.ModifierClient(IDSelectList, txtNom.Text, TxtPrenom.Text, TxtAdresse.Text, TxtTel.Text, TxtPays.Text, TxtVille.Text, TxtEmail.Text);
                        //Actualiser DataViewGrid
                        (userClient as USER_Liste_Client).ActualiserDataViewGrid();
                        MessageBox.Show("Client modifier avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }else
                    {
                        MessageBox.Show("Modification échouée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                }
              
            } 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
