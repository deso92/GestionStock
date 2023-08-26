
namespace GestionDeStock.PL
{
    partial class FRM_Afficher_Produit
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
            this.pictureBoxAfficherProduit = new System.Windows.Forms.PictureBox();
            this.LblNomProduit = new System.Windows.Forms.Label();
            this.BtnFermerFrmClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfficherProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAfficherProduit
            // 
            this.pictureBoxAfficherProduit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAfficherProduit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxAfficherProduit.Location = new System.Drawing.Point(12, 68);
            this.pictureBoxAfficherProduit.Name = "pictureBoxAfficherProduit";
            this.pictureBoxAfficherProduit.Size = new System.Drawing.Size(611, 387);
            this.pictureBoxAfficherProduit.TabIndex = 0;
            this.pictureBoxAfficherProduit.TabStop = false;
            // 
            // LblNomProduit
            // 
            this.LblNomProduit.AutoSize = true;
            this.LblNomProduit.Location = new System.Drawing.Point(9, 30);
            this.LblNomProduit.Name = "LblNomProduit";
            this.LblNomProduit.Size = new System.Drawing.Size(53, 17);
            this.LblNomProduit.TabIndex = 1;
            this.LblNomProduit.Text = "Produit";
            // 
            // BtnFermerFrmClient
            // 
            this.BtnFermerFrmClient.BackColor = System.Drawing.Color.Red;
            this.BtnFermerFrmClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermerFrmClient.ForeColor = System.Drawing.Color.White;
            this.BtnFermerFrmClient.Location = new System.Drawing.Point(522, 21);
            this.BtnFermerFrmClient.Name = "BtnFermerFrmClient";
            this.BtnFermerFrmClient.Size = new System.Drawing.Size(101, 33);
            this.BtnFermerFrmClient.TabIndex = 15;
            this.BtnFermerFrmClient.Text = "Fermer";
            this.BtnFermerFrmClient.UseVisualStyleBackColor = false;
            this.BtnFermerFrmClient.Click += new System.EventHandler(this.BtnFermerFrmClient_Click);
            // 
            // FRM_Afficher_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.BtnFermerFrmClient);
            this.Controls.Add(this.LblNomProduit);
            this.Controls.Add(this.pictureBoxAfficherProduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Afficher_Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Afficher_Produit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfficherProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button BtnFermerFrmClient;
        public System.Windows.Forms.PictureBox pictureBoxAfficherProduit;
        public System.Windows.Forms.Label LblNomProduit;
    }
}