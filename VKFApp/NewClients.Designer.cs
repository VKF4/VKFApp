namespace VKFApp
{
    partial class NewClients
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
            this.lkTitre = new System.Windows.Forms.LinkLabel();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.tbNomClient = new System.Windows.Forms.TextBox();
            this.tbActivite = new System.Windows.Forms.TextBox();
            this.lblActivite = new System.Windows.Forms.Label();
            this.lblDateOuverture = new System.Windows.Forms.Label();
            this.dtpDateOuverture = new System.Windows.Forms.DateTimePicker();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.tbCodePostal = new System.Windows.Forms.TextBox();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.tbTelPortable = new System.Windows.Forms.TextBox();
            this.lblTelPortable = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbTelFixe = new System.Windows.Forms.TextBox();
            this.lblTelFixe = new System.Windows.Forms.Label();
            this.tbSIREN = new System.Windows.Forms.TextBox();
            this.lblSIREN = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lkTitre
            // 
            this.lkTitre.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lkTitre.AutoSize = true;
            this.lkTitre.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkTitre.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lkTitre.Location = new System.Drawing.Point(211, 20);
            this.lkTitre.Name = "lkTitre";
            this.lkTitre.Size = new System.Drawing.Size(364, 34);
            this.lkTitre.TabIndex = 0;
            this.lkTitre.TabStop = true;
            this.lkTitre.Text = "Ajout d\'un nouveau client";
            this.lkTitre.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomClient.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNomClient.Location = new System.Drawing.Point(12, 96);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(107, 21);
            this.lblNomClient.TabIndex = 1;
            this.lblNomClient.Text = "Nom client :";
            // 
            // tbNomClient
            // 
            this.tbNomClient.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomClient.Location = new System.Drawing.Point(125, 92);
            this.tbNomClient.Name = "tbNomClient";
            this.tbNomClient.Size = new System.Drawing.Size(253, 25);
            this.tbNomClient.TabIndex = 2;
            this.tbNomClient.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbActivite
            // 
            this.tbActivite.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActivite.Location = new System.Drawing.Point(125, 134);
            this.tbActivite.Name = "tbActivite";
            this.tbActivite.Size = new System.Drawing.Size(633, 25);
            this.tbActivite.TabIndex = 4;
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivite.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblActivite.Location = new System.Drawing.Point(37, 138);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(82, 21);
            this.lblActivite.TabIndex = 3;
            this.lblActivite.Text = "Activité :";
            // 
            // lblDateOuverture
            // 
            this.lblDateOuverture.AutoSize = true;
            this.lblDateOuverture.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOuverture.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDateOuverture.Location = new System.Drawing.Point(392, 96);
            this.lblDateOuverture.Name = "lblDateOuverture";
            this.lblDateOuverture.Size = new System.Drawing.Size(139, 21);
            this.lblDateOuverture.TabIndex = 5;
            this.lblDateOuverture.Text = "Date ouverture :";
            // 
            // dtpDateOuverture
            // 
            this.dtpDateOuverture.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOuverture.Location = new System.Drawing.Point(537, 92);
            this.dtpDateOuverture.Name = "dtpDateOuverture";
            this.dtpDateOuverture.Size = new System.Drawing.Size(221, 25);
            this.dtpDateOuverture.TabIndex = 7;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresse.Location = new System.Drawing.Point(125, 177);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(633, 25);
            this.tbAdresse.TabIndex = 9;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAdresse.Location = new System.Drawing.Point(37, 181);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(81, 21);
            this.lblAdresse.TabIndex = 8;
            this.lblAdresse.Text = "Adresse :";
            // 
            // tbVille
            // 
            this.tbVille.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVille.Location = new System.Drawing.Point(125, 220);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(343, 25);
            this.tbVille.TabIndex = 11;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVille.Location = new System.Drawing.Point(64, 224);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(54, 21);
            this.lblVille.TabIndex = 10;
            this.lblVille.Text = "Ville :";
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodePostal.Location = new System.Drawing.Point(591, 220);
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(167, 25);
            this.tbCodePostal.TabIndex = 13;
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePostal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCodePostal.Location = new System.Drawing.Point(474, 224);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(111, 21);
            this.lblCodePostal.TabIndex = 12;
            this.lblCodePostal.Text = "Code postal :";
            // 
            // tbTelPortable
            // 
            this.tbTelPortable.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelPortable.Location = new System.Drawing.Point(591, 263);
            this.tbTelPortable.Name = "tbTelPortable";
            this.tbTelPortable.Size = new System.Drawing.Size(167, 25);
            this.tbTelPortable.TabIndex = 17;
            // 
            // lblTelPortable
            // 
            this.lblTelPortable.AutoSize = true;
            this.lblTelPortable.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelPortable.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTelPortable.Location = new System.Drawing.Point(474, 267);
            this.lblTelPortable.Name = "lblTelPortable";
            this.lblTelPortable.Size = new System.Drawing.Size(115, 21);
            this.lblTelPortable.TabIndex = 16;
            this.lblTelPortable.Text = "Tel portable :";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(125, 263);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(343, 25);
            this.tbEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmail.Location = new System.Drawing.Point(55, 267);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 21);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email :";
            // 
            // tbTelFixe
            // 
            this.tbTelFixe.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelFixe.Location = new System.Drawing.Point(591, 305);
            this.tbTelFixe.Name = "tbTelFixe";
            this.tbTelFixe.Size = new System.Drawing.Size(167, 25);
            this.tbTelFixe.TabIndex = 21;
            // 
            // lblTelFixe
            // 
            this.lblTelFixe.AutoSize = true;
            this.lblTelFixe.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelFixe.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTelFixe.Location = new System.Drawing.Point(505, 309);
            this.lblTelFixe.Name = "lblTelFixe";
            this.lblTelFixe.Size = new System.Drawing.Size(80, 21);
            this.lblTelFixe.TabIndex = 20;
            this.lblTelFixe.Text = "Tel fixe :";
            // 
            // tbSIREN
            // 
            this.tbSIREN.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIREN.Location = new System.Drawing.Point(125, 305);
            this.tbSIREN.Name = "tbSIREN";
            this.tbSIREN.Size = new System.Drawing.Size(343, 25);
            this.tbSIREN.TabIndex = 19;
            // 
            // lblSIREN
            // 
            this.lblSIREN.AutoSize = true;
            this.lblSIREN.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSIREN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSIREN.Location = new System.Drawing.Point(46, 309);
            this.lblSIREN.Name = "lblSIREN";
            this.lblSIREN.Size = new System.Drawing.Size(73, 21);
            this.lblSIREN.TabIndex = 18;
            this.lblSIREN.Text = "SIREN :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnnuler.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(319, 360);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(80, 30);
            this.btnAnnuler.TabIndex = 22;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnValider.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(405, 360);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(80, 30);
            this.btnValider.TabIndex = 23;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // NewClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(779, 416);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.tbTelFixe);
            this.Controls.Add(this.lblTelFixe);
            this.Controls.Add(this.tbSIREN);
            this.Controls.Add(this.lblSIREN);
            this.Controls.Add(this.tbTelPortable);
            this.Controls.Add(this.lblTelPortable);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbCodePostal);
            this.Controls.Add(this.lblCodePostal);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.dtpDateOuverture);
            this.Controls.Add(this.lblDateOuverture);
            this.Controls.Add(this.tbActivite);
            this.Controls.Add(this.lblActivite);
            this.Controls.Add(this.tbNomClient);
            this.Controls.Add(this.lblNomClient);
            this.Controls.Add(this.lkTitre);
            this.Name = "NewClients";
            this.Text = "Ajout d\'un nouveau client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lkTitre;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.TextBox tbNomClient;
        private System.Windows.Forms.TextBox tbActivite;
        private System.Windows.Forms.Label lblActivite;
        private System.Windows.Forms.Label lblDateOuverture;
        private System.Windows.Forms.DateTimePicker dtpDateOuverture;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox tbCodePostal;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.TextBox tbTelPortable;
        private System.Windows.Forms.Label lblTelPortable;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbTelFixe;
        private System.Windows.Forms.Label lblTelFixe;
        private System.Windows.Forms.TextBox tbSIREN;
        private System.Windows.Forms.Label lblSIREN;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
    }
}