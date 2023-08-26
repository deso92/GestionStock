
namespace GestionDeStock.PL
{
    partial class USER_Liste_Produit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvProduit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboRechProduit = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtRechercherProduit = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnModifierProduit = new System.Windows.Forms.Button();
            this.BtnSupprimerProduit = new System.Windows.Forms.Button();
            this.BtnAjouterProduit = new System.Windows.Forms.Button();
            this.BtnAfficherImageProduit = new System.Windows.Forms.Button();
            this.BtnImprimerToutProduit = new System.Windows.Forms.Button();
            this.BtnSauvegarderDansExcel = new System.Windows.Forms.Button();
            this.BtnImprimerProduitCocher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduit)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvProduit
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvProduit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProduit.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProduit.DefaultCellStyle = dataGridViewCellStyle9;
            this.DgvProduit.EnableHeadersVisualStyles = false;
            this.DgvProduit.Location = new System.Drawing.Point(0, 156);
            this.DgvProduit.Name = "DgvProduit";
            this.DgvProduit.RowHeadersVisible = false;
            this.DgvProduit.RowHeadersWidth = 51;
            this.DgvProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvProduit.RowTemplate.Height = 24;
            this.DgvProduit.Size = new System.Drawing.Size(1126, 294);
            this.DgvProduit.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom produit";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qté";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Catégorie";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // ComboRechProduit
            // 
            this.ComboRechProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRechProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboRechProduit.FormattingEnabled = true;
            this.ComboRechProduit.Items.AddRange(new object[] {
            "Nom du produit",
            "Catégorie"});
            this.ComboRechProduit.Location = new System.Drawing.Point(32, 101);
            this.ComboRechProduit.Name = "ComboRechProduit";
            this.ComboRechProduit.Size = new System.Drawing.Size(389, 33);
            this.ComboRechProduit.TabIndex = 21;
            this.ComboRechProduit.SelectedIndexChanged += new System.EventHandler(this.ComboRechProduit_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(543, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 3);
            this.panel2.TabIndex = 19;
            // 
            // TxtRechercherProduit
            // 
            this.TxtRechercherProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRechercherProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRechercherProduit.Location = new System.Drawing.Point(543, 105);
            this.TxtRechercherProduit.Name = "TxtRechercherProduit";
            this.TxtRechercherProduit.Size = new System.Drawing.Size(303, 20);
            this.TxtRechercherProduit.TabIndex = 20;
            this.TxtRechercherProduit.Text = "Rechercher";
            this.TxtRechercherProduit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtRechercherProduit.TextChanged += new System.EventHandler(this.TxtRechercherProduit_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(32, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 3);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1048, 3);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(0, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1048, 3);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Location = new System.Drawing.Point(0, 102);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1048, 3);
            this.panel6.TabIndex = 4;
            // 
            // BtnModifierProduit
            // 
            this.BtnModifierProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnModifierProduit.FlatAppearance.BorderSize = 0;
            this.BtnModifierProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModifierProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifierProduit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnModifierProduit.Location = new System.Drawing.Point(261, 9);
            this.BtnModifierProduit.Name = "BtnModifierProduit";
            this.BtnModifierProduit.Size = new System.Drawing.Size(211, 58);
            this.BtnModifierProduit.TabIndex = 17;
            this.BtnModifierProduit.Text = "Modifier";
            this.BtnModifierProduit.UseVisualStyleBackColor = false;
            this.BtnModifierProduit.Click += new System.EventHandler(this.BtnModifierProduit_Click);
            // 
            // BtnSupprimerProduit
            // 
            this.BtnSupprimerProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSupprimerProduit.FlatAppearance.BorderSize = 0;
            this.BtnSupprimerProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimerProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimerProduit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSupprimerProduit.Location = new System.Drawing.Point(527, 9);
            this.BtnSupprimerProduit.Name = "BtnSupprimerProduit";
            this.BtnSupprimerProduit.Size = new System.Drawing.Size(236, 58);
            this.BtnSupprimerProduit.TabIndex = 16;
            this.BtnSupprimerProduit.Text = "Supprimer";
            this.BtnSupprimerProduit.UseVisualStyleBackColor = false;
            this.BtnSupprimerProduit.Click += new System.EventHandler(this.BtnSupprimerClient_Click);
            // 
            // BtnAjouterProduit
            // 
            this.BtnAjouterProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAjouterProduit.FlatAppearance.BorderSize = 0;
            this.BtnAjouterProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjouterProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouterProduit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAjouterProduit.Location = new System.Drawing.Point(32, 9);
            this.BtnAjouterProduit.Name = "BtnAjouterProduit";
            this.BtnAjouterProduit.Size = new System.Drawing.Size(183, 58);
            this.BtnAjouterProduit.TabIndex = 15;
            this.BtnAjouterProduit.Text = "Ajouter";
            this.BtnAjouterProduit.UseVisualStyleBackColor = false;
            this.BtnAjouterProduit.Click += new System.EventHandler(this.BtnAjouterProduit_Click);
            // 
            // BtnAfficherImageProduit
            // 
            this.BtnAfficherImageProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAfficherImageProduit.FlatAppearance.BorderSize = 0;
            this.BtnAfficherImageProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAfficherImageProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficherImageProduit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAfficherImageProduit.Location = new System.Drawing.Point(810, 9);
            this.BtnAfficherImageProduit.Name = "BtnAfficherImageProduit";
            this.BtnAfficherImageProduit.Size = new System.Drawing.Size(278, 58);
            this.BtnAfficherImageProduit.TabIndex = 23;
            this.BtnAfficherImageProduit.Text = "Afficher image produit";
            this.BtnAfficherImageProduit.UseVisualStyleBackColor = false;
            this.BtnAfficherImageProduit.Click += new System.EventHandler(this.BtnAfficherImageProduit_Click);
            // 
            // BtnImprimerToutProduit
            // 
            this.BtnImprimerToutProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnImprimerToutProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnImprimerToutProduit.FlatAppearance.BorderSize = 0;
            this.BtnImprimerToutProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimerToutProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimerToutProduit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnImprimerToutProduit.Location = new System.Drawing.Point(397, 469);
            this.BtnImprimerToutProduit.Name = "BtnImprimerToutProduit";
            this.BtnImprimerToutProduit.Size = new System.Drawing.Size(233, 58);
            this.BtnImprimerToutProduit.TabIndex = 26;
            this.BtnImprimerToutProduit.Text = "Imprimer toutes";
            this.BtnImprimerToutProduit.UseVisualStyleBackColor = false;
            // 
            // BtnSauvegarderDansExcel
            // 
            this.BtnSauvegarderDansExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSauvegarderDansExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSauvegarderDansExcel.FlatAppearance.BorderSize = 0;
            this.BtnSauvegarderDansExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSauvegarderDansExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSauvegarderDansExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSauvegarderDansExcel.Location = new System.Drawing.Point(740, 469);
            this.BtnSauvegarderDansExcel.Name = "BtnSauvegarderDansExcel";
            this.BtnSauvegarderDansExcel.Size = new System.Drawing.Size(348, 58);
            this.BtnSauvegarderDansExcel.TabIndex = 25;
            this.BtnSauvegarderDansExcel.Text = "Sauvegarder dans excel";
            this.BtnSauvegarderDansExcel.UseVisualStyleBackColor = false;
            // 
            // BtnImprimerProduitCocher
            // 
            this.BtnImprimerProduitCocher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnImprimerProduitCocher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnImprimerProduitCocher.FlatAppearance.BorderSize = 0;
            this.BtnImprimerProduitCocher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimerProduitCocher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimerProduitCocher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnImprimerProduitCocher.Location = new System.Drawing.Point(32, 469);
            this.BtnImprimerProduitCocher.Name = "BtnImprimerProduitCocher";
            this.BtnImprimerProduitCocher.Size = new System.Drawing.Size(270, 58);
            this.BtnImprimerProduitCocher.TabIndex = 24;
            this.BtnImprimerProduitCocher.Text = "Imprimer Pr cocher";
            this.BtnImprimerProduitCocher.UseVisualStyleBackColor = false;
            // 
            // USER_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnImprimerToutProduit);
            this.Controls.Add(this.BtnSauvegarderDansExcel);
            this.Controls.Add(this.BtnImprimerProduitCocher);
            this.Controls.Add(this.BtnAfficherImageProduit);
            this.Controls.Add(this.DgvProduit);
            this.Controls.Add(this.ComboRechProduit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtRechercherProduit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnModifierProduit);
            this.Controls.Add(this.BtnSupprimerProduit);
            this.Controls.Add(this.BtnAjouterProduit);
            this.Name = "USER_Liste_Produit";
            this.Size = new System.Drawing.Size(1126, 546);
            this.Load += new System.EventHandler(this.USER_Liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduit)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProduit;
        private System.Windows.Forms.ComboBox ComboRechProduit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtRechercherProduit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnModifierProduit;
        private System.Windows.Forms.Button BtnSupprimerProduit;
        private System.Windows.Forms.Button BtnAjouterProduit;
        private System.Windows.Forms.Button BtnAfficherImageProduit;
        private System.Windows.Forms.Button BtnImprimerToutProduit;
        private System.Windows.Forms.Button BtnSauvegarderDansExcel;
        private System.Windows.Forms.Button BtnImprimerProduitCocher;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
