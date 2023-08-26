
namespace GestionDeStock.PL
{
    partial class FRM_CONNEXION
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnFermerLoginPage = new System.Windows.Forms.Button();
            this.BtnSeConnecter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbMotDePasse = new System.Windows.Forms.TextBox();
            this.TxbMailUtilisateur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnFermerLoginPage
            // 
            this.BtnFermerLoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermerLoginPage.Location = new System.Drawing.Point(357, 227);
            this.BtnFermerLoginPage.Name = "BtnFermerLoginPage";
            this.BtnFermerLoginPage.Size = new System.Drawing.Size(105, 23);
            this.BtnFermerLoginPage.TabIndex = 12;
            this.BtnFermerLoginPage.Text = "Fermer";
            this.BtnFermerLoginPage.UseVisualStyleBackColor = true;
            // 
            // BtnSeConnecter
            // 
            this.BtnSeConnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeConnecter.Location = new System.Drawing.Point(189, 227);
            this.BtnSeConnecter.Name = "BtnSeConnecter";
            this.BtnSeConnecter.Size = new System.Drawing.Size(147, 23);
            this.BtnSeConnecter.TabIndex = 11;
            this.BtnSeConnecter.Text = "Se connecter";
            this.BtnSeConnecter.UseVisualStyleBackColor = true;
            this.BtnSeConnecter.Click += new System.EventHandler(this.BtnSeConnecter_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom utilisateur";
            // 
            // TxbMotDePasse
            // 
            this.TxbMotDePasse.Location = new System.Drawing.Point(189, 157);
            this.TxbMotDePasse.Name = "TxbMotDePasse";
            this.TxbMotDePasse.Size = new System.Drawing.Size(273, 22);
            this.TxbMotDePasse.TabIndex = 8;
            // 
            // TxbMailUtilisateur
            // 
            this.TxbMailUtilisateur.Location = new System.Drawing.Point(189, 83);
            this.TxbMailUtilisateur.Name = "TxbMailUtilisateur";
            this.TxbMailUtilisateur.Size = new System.Drawing.Size(273, 22);
            this.TxbMailUtilisateur.TabIndex = 7;
            // 
            // FRM_CONNEXION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 332);
            this.Controls.Add(this.BtnFermerLoginPage);
            this.Controls.Add(this.BtnSeConnecter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbMotDePasse);
            this.Controls.Add(this.TxbMailUtilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_CONNEXION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_CONNEXION";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFermerLoginPage;
        private System.Windows.Forms.Button BtnSeConnecter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbMotDePasse;
        private System.Windows.Forms.TextBox TxbMailUtilisateur;
    }
}