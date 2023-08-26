
namespace GestionDeStock.PL
{
    partial class USER_Liste_Client
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboRechClient = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtRechercherClient = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnModifierClient = new System.Windows.Forms.Button();
            this.BtnSupprimerClient = new System.Windows.Forms.Button();
            this.BtnAjouterClient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClient)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvClient);
            this.panel1.Controls.Add(this.ComboRechClient);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TxtRechercherClient);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.BtnModifierClient);
            this.panel1.Controls.Add(this.BtnSupprimerClient);
            this.panel1.Controls.Add(this.BtnAjouterClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 546);
            this.panel1.TabIndex = 0;
            // 
            // DgvClient
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClient.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvClient.DefaultCellStyle = dataGridViewCellStyle9;
            this.DgvClient.EnableHeadersVisualStyles = false;
            this.DgvClient.Location = new System.Drawing.Point(0, 156);
            this.DgvClient.Name = "DgvClient";
            this.DgvClient.RowHeadersVisible = false;
            this.DgvClient.RowHeadersWidth = 51;
            this.DgvClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvClient.RowTemplate.Height = 24;
            this.DgvClient.Size = new System.Drawing.Size(1126, 381);
            this.DgvClient.TabIndex = 14;
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
            this.Column2.HeaderText = "Nom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prénom";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adresse";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Téléphone";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Pays";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ville";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Email";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // ComboRechClient
            // 
            this.ComboRechClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRechClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboRechClient.FormattingEnabled = true;
            this.ComboRechClient.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Adresse",
            "Téléphone",
            "Pays",
            "Ville",
            "Email"});
            this.ComboRechClient.Location = new System.Drawing.Point(32, 101);
            this.ComboRechClient.Name = "ComboRechClient";
            this.ComboRechClient.Size = new System.Drawing.Size(389, 33);
            this.ComboRechClient.TabIndex = 13;
            this.ComboRechClient.SelectedIndexChanged += new System.EventHandler(this.ComboRechClient_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(516, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 3);
            this.panel2.TabIndex = 11;
            // 
            // TxtRechercherClient
            // 
            this.TxtRechercherClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRechercherClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRechercherClient.Location = new System.Drawing.Point(516, 108);
            this.TxtRechercherClient.Name = "TxtRechercherClient";
            this.TxtRechercherClient.Size = new System.Drawing.Size(303, 20);
            this.TxtRechercherClient.TabIndex = 12;
            this.TxtRechercherClient.Text = "Rechercher";
            this.TxtRechercherClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtRechercherClient.TextChanged += new System.EventHandler(this.TxtRechercherClient_TextChanged);
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
            this.panel3.TabIndex = 10;
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
            // BtnModifierClient
            // 
            this.BtnModifierClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnModifierClient.FlatAppearance.BorderSize = 0;
            this.BtnModifierClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModifierClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifierClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnModifierClient.Location = new System.Drawing.Point(440, 9);
            this.BtnModifierClient.Name = "BtnModifierClient";
            this.BtnModifierClient.Size = new System.Drawing.Size(241, 58);
            this.BtnModifierClient.TabIndex = 9;
            this.BtnModifierClient.Text = "Modifier";
            this.BtnModifierClient.UseVisualStyleBackColor = false;
            this.BtnModifierClient.Click += new System.EventHandler(this.BtnModifierClient_Click_1);
            // 
            // BtnSupprimerClient
            // 
            this.BtnSupprimerClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSupprimerClient.FlatAppearance.BorderSize = 0;
            this.BtnSupprimerClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimerClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSupprimerClient.Location = new System.Drawing.Point(848, 9);
            this.BtnSupprimerClient.Name = "BtnSupprimerClient";
            this.BtnSupprimerClient.Size = new System.Drawing.Size(241, 58);
            this.BtnSupprimerClient.TabIndex = 8;
            this.BtnSupprimerClient.Text = "Supprimer";
            this.BtnSupprimerClient.UseVisualStyleBackColor = false;
            this.BtnSupprimerClient.Click += new System.EventHandler(this.BtnSupprimerClient_Click);
            // 
            // BtnAjouterClient
            // 
            this.BtnAjouterClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAjouterClient.FlatAppearance.BorderSize = 0;
            this.BtnAjouterClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouterClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAjouterClient.Location = new System.Drawing.Point(32, 9);
            this.BtnAjouterClient.Name = "BtnAjouterClient";
            this.BtnAjouterClient.Size = new System.Drawing.Size(241, 58);
            this.BtnAjouterClient.TabIndex = 7;
            this.BtnAjouterClient.Text = "Ajouter";
            this.BtnAjouterClient.UseVisualStyleBackColor = false;
            this.BtnAjouterClient.Click += new System.EventHandler(this.BtnAjouterClient_Click_1);
            // 
            // USER_Liste_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "USER_Liste_Client";
            this.Size = new System.Drawing.Size(1126, 546);
            this.Load += new System.EventHandler(this.USER_Liste_Client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClient)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvClient;
        private System.Windows.Forms.ComboBox ComboRechClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtRechercherClient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnModifierClient;
        private System.Windows.Forms.Button BtnSupprimerClient;
        private System.Windows.Forms.Button BtnAjouterClient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
