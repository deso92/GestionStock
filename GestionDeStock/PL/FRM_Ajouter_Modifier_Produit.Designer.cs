
namespace GestionDeStock.PL
{
    partial class FRM_Ajouter_Modifier_Produit
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
            this.BtnFermerFrmClient = new System.Windows.Forms.Button();
            this.LblAjouterModifierProduit = new System.Windows.Forms.Label();
            this.BtnEnregistrerModifierProduit = new System.Windows.Forms.Button();
            this.BtnActualiserProduit = new System.Windows.Forms.Button();
            this.TxtQteProd = new System.Windows.Forms.TextBox();
            this.TxtPrixProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtNomProduit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCatProd = new System.Windows.Forms.ComboBox();
            this.BtnAjouterImageProduit = new System.Windows.Forms.Button();
            this.pictureBoxImageProduit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFermerFrmClient
            // 
            this.BtnFermerFrmClient.BackColor = System.Drawing.Color.Red;
            this.BtnFermerFrmClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermerFrmClient.ForeColor = System.Drawing.Color.White;
            this.BtnFermerFrmClient.Location = new System.Drawing.Point(775, 13);
            this.BtnFermerFrmClient.Name = "BtnFermerFrmClient";
            this.BtnFermerFrmClient.Size = new System.Drawing.Size(101, 33);
            this.BtnFermerFrmClient.TabIndex = 14;
            this.BtnFermerFrmClient.Text = "Fermer";
            this.BtnFermerFrmClient.UseVisualStyleBackColor = false;
            this.BtnFermerFrmClient.Click += new System.EventHandler(this.BtnFermerFrmClient_Click);
            // 
            // LblAjouterModifierProduit
            // 
            this.LblAjouterModifierProduit.AutoSize = true;
            this.LblAjouterModifierProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAjouterModifierProduit.Location = new System.Drawing.Point(12, 9);
            this.LblAjouterModifierProduit.Name = "LblAjouterModifierProduit";
            this.LblAjouterModifierProduit.Size = new System.Drawing.Size(187, 29);
            this.LblAjouterModifierProduit.TabIndex = 1;
            this.LblAjouterModifierProduit.Text = "Ajouter Produit";
            // 
            // BtnEnregistrerModifierProduit
            // 
            this.BtnEnregistrerModifierProduit.BackColor = System.Drawing.Color.Red;
            this.BtnEnregistrerModifierProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnregistrerModifierProduit.ForeColor = System.Drawing.Color.White;
            this.BtnEnregistrerModifierProduit.Location = new System.Drawing.Point(727, 372);
            this.BtnEnregistrerModifierProduit.Name = "BtnEnregistrerModifierProduit";
            this.BtnEnregistrerModifierProduit.Size = new System.Drawing.Size(149, 33);
            this.BtnEnregistrerModifierProduit.TabIndex = 3;
            this.BtnEnregistrerModifierProduit.Text = "Enregistrer";
            this.BtnEnregistrerModifierProduit.UseVisualStyleBackColor = false;
            this.BtnEnregistrerModifierProduit.Click += new System.EventHandler(this.BtnEnregistrerClient_Click);
            // 
            // BtnActualiserProduit
            // 
            this.BtnActualiserProduit.BackColor = System.Drawing.Color.Black;
            this.BtnActualiserProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualiserProduit.ForeColor = System.Drawing.Color.White;
            this.BtnActualiserProduit.Location = new System.Drawing.Point(577, 372);
            this.BtnActualiserProduit.Name = "BtnActualiserProduit";
            this.BtnActualiserProduit.Size = new System.Drawing.Size(144, 33);
            this.BtnActualiserProduit.TabIndex = 2;
            this.BtnActualiserProduit.Text = "Actualiser";
            this.BtnActualiserProduit.UseVisualStyleBackColor = false;
            this.BtnActualiserProduit.Click += new System.EventHandler(this.BtnActualiserClient_Click);
            // 
            // TxtQteProd
            // 
            this.TxtQteProd.Location = new System.Drawing.Point(593, 173);
            this.TxtQteProd.Name = "TxtQteProd";
            this.TxtQteProd.Size = new System.Drawing.Size(283, 22);
            this.TxtQteProd.TabIndex = 10;
            this.TxtQteProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQteProd_KeyPress);
            // 
            // TxtPrixProd
            // 
            this.TxtPrixProd.Location = new System.Drawing.Point(593, 265);
            this.TxtPrixProd.Name = "TxtPrixProd";
            this.TxtPrixProd.Size = new System.Drawing.Size(283, 22);
            this.TxtPrixProd.TabIndex = 9;
            this.TxtPrixProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrixProd_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Catégorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantité";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.TxtNomProduit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxCatProd);
            this.panel1.Controls.Add(this.BtnAjouterImageProduit);
            this.panel1.Controls.Add(this.pictureBoxImageProduit);
            this.panel1.Controls.Add(this.BtnFermerFrmClient);
            this.panel1.Controls.Add(this.LblAjouterModifierProduit);
            this.panel1.Controls.Add(this.BtnEnregistrerModifierProduit);
            this.panel1.Controls.Add(this.BtnActualiserProduit);
            this.panel1.Controls.Add(this.TxtQteProd);
            this.panel1.Controls.Add(this.TxtPrixProd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 435);
            this.panel1.TabIndex = 1;
            // 
            // TxtNomProduit
            // 
            this.TxtNomProduit.Location = new System.Drawing.Point(223, 379);
            this.TxtNomProduit.Name = "TxtNomProduit";
            this.TxtNomProduit.Size = new System.Drawing.Size(266, 22);
            this.TxtNomProduit.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nom du produit";
            // 
            // comboBoxCatProd
            // 
            this.comboBoxCatProd.FormattingEnabled = true;
            this.comboBoxCatProd.Location = new System.Drawing.Point(593, 80);
            this.comboBoxCatProd.Name = "comboBoxCatProd";
            this.comboBoxCatProd.Size = new System.Drawing.Size(283, 24);
            this.comboBoxCatProd.TabIndex = 17;
            // 
            // BtnAjouterImageProduit
            // 
            this.BtnAjouterImageProduit.BackColor = System.Drawing.Color.Black;
            this.BtnAjouterImageProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouterImageProduit.ForeColor = System.Drawing.Color.White;
            this.BtnAjouterImageProduit.Location = new System.Drawing.Point(103, 267);
            this.BtnAjouterImageProduit.Name = "BtnAjouterImageProduit";
            this.BtnAjouterImageProduit.Size = new System.Drawing.Size(195, 33);
            this.BtnAjouterImageProduit.TabIndex = 16;
            this.BtnAjouterImageProduit.Text = "Choisir l\'image";
            this.BtnAjouterImageProduit.UseVisualStyleBackColor = false;
            this.BtnAjouterImageProduit.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxImageProduit
            // 
            this.pictureBoxImageProduit.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxImageProduit.Location = new System.Drawing.Point(103, 68);
            this.pictureBoxImageProduit.Name = "pictureBoxImageProduit";
            this.pictureBoxImageProduit.Size = new System.Drawing.Size(280, 183);
            this.pictureBoxImageProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageProduit.TabIndex = 15;
            this.pictureBoxImageProduit.TabStop = false;
            // 
            // FRM_Ajouter_Modifier_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(911, 445);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Ajouter_Modifier_Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Ajouter_Modifier_Produit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageProduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BtnFermerFrmClient;
        public System.Windows.Forms.Label LblAjouterModifierProduit;
        public System.Windows.Forms.Button BtnEnregistrerModifierProduit;
        public System.Windows.Forms.Button BtnActualiserProduit;
        public System.Windows.Forms.TextBox TxtQteProd;
        public System.Windows.Forms.TextBox TxtPrixProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCatProd;
        public System.Windows.Forms.Button BtnAjouterImageProduit;
        public System.Windows.Forms.TextBox TxtNomProduit;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pictureBoxImageProduit;
    }
}