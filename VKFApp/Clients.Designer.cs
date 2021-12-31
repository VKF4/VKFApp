namespace VKFApp
{
    partial class Clients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.numClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOuverture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExporter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNouveau.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(972, 12);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(80, 30);
            this.btnNouveau.TabIndex = 0;
            this.btnNouveau.Text = "&Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClients.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numClient,
            this.nomClient,
            this.activite,
            this.adresse,
            this.ville,
            this.codePostal,
            this.email,
            this.portable,
            this.fixe,
            this.siren,
            this.dateOuverture});
            this.dgvClients.Location = new System.Drawing.Point(0, 76);
            this.dgvClients.Name = "dgvClients";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClients.Size = new System.Drawing.Size(1064, 605);
            this.dgvClients.TabIndex = 1;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            // 
            // numClient
            // 
            this.numClient.HeaderText = "N°Client";
            this.numClient.Name = "numClient";
            this.numClient.Width = 76;
            // 
            // nomClient
            // 
            this.nomClient.HeaderText = "Client";
            this.nomClient.Name = "nomClient";
            this.nomClient.Width = 62;
            // 
            // activite
            // 
            this.activite.HeaderText = "Activité";
            this.activite.Name = "activite";
            this.activite.Width = 73;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "Adresse";
            this.adresse.Name = "adresse";
            this.adresse.Width = 71;
            // 
            // ville
            // 
            this.ville.HeaderText = "Ville";
            this.ville.Name = "ville";
            this.ville.Width = 53;
            // 
            // codePostal
            // 
            this.codePostal.HeaderText = "CP";
            this.codePostal.Name = "codePostal";
            this.codePostal.Width = 46;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 59;
            // 
            // portable
            // 
            this.portable.HeaderText = "Portable";
            this.portable.Name = "portable";
            this.portable.Width = 75;
            // 
            // fixe
            // 
            this.fixe.HeaderText = "Fixe";
            this.fixe.Name = "fixe";
            this.fixe.Width = 51;
            // 
            // siren
            // 
            this.siren.HeaderText = "SIREN";
            this.siren.Name = "siren";
            this.siren.Width = 66;
            // 
            // dateOuverture
            // 
            this.dateOuverture.HeaderText = "Ouvert le";
            this.dateOuverture.Name = "dateOuverture";
            this.dateOuverture.Width = 80;
            // 
            // btnExporter
            // 
            this.btnExporter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExporter.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExporter.Location = new System.Drawing.Point(875, 12);
            this.btnExporter.Name = "btnExporter";
            this.btnExporter.Size = new System.Drawing.Size(80, 30);
            this.btnExporter.TabIndex = 2;
            this.btnExporter.Text = "&Exporter";
            this.btnExporter.UseVisualStyleBackColor = false;
            this.btnExporter.Click += new System.EventHandler(this.btnExporter_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnExporter);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btnNouveau);
            this.Name = "Clients";
            this.Text = "Clients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn numClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn activite;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn portable;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixe;
        private System.Windows.Forms.DataGridViewTextBoxColumn siren;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOuverture;
        private System.Windows.Forms.Button btnExporter;
    }
}