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
    public partial class FRM_Afficher_Produit : Form
    {
        public FRM_Afficher_Produit()
        {
            InitializeComponent();
        }

        private void BtnFermerFrmClient_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
