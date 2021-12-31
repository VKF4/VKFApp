namespace VKFApp
{
    partial class TypeExport
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
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.rbPDF = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.gbTypeExport = new System.Windows.Forms.GroupBox();
            this.gbTypeExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lkTitre
            // 
            this.lkTitre.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lkTitre.AutoSize = true;
            this.lkTitre.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkTitre.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lkTitre.Location = new System.Drawing.Point(12, 9);
            this.lkTitre.Name = "lkTitre";
            this.lkTitre.Size = new System.Drawing.Size(430, 31);
            this.lkTitre.TabIndex = 1;
            this.lkTitre.TabStop = true;
            this.lkTitre.Text = "Choisissez le type d\'exportation :";
            this.lkTitre.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lkTitre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkTitre_LinkClicked);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnValider.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(224, 139);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(80, 30);
            this.btnValider.TabIndex = 25;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnnuler.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(138, 139);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(80, 30);
            this.btnAnnuler.TabIndex = 24;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // rbPDF
            // 
            this.rbPDF.AutoSize = true;
            this.rbPDF.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPDF.Location = new System.Drawing.Point(32, 19);
            this.rbPDF.Name = "rbPDF";
            this.rbPDF.Size = new System.Drawing.Size(51, 21);
            this.rbPDF.TabIndex = 0;
            this.rbPDF.TabStop = true;
            this.rbPDF.Text = "PDF";
            this.rbPDF.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(102, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Excel";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // gbTypeExport
            // 
            this.gbTypeExport.Controls.Add(this.radioButton2);
            this.gbTypeExport.Controls.Add(this.rbPDF);
            this.gbTypeExport.Location = new System.Drawing.Point(109, 58);
            this.gbTypeExport.Name = "gbTypeExport";
            this.gbTypeExport.Size = new System.Drawing.Size(218, 57);
            this.gbTypeExport.TabIndex = 2;
            this.gbTypeExport.TabStop = false;
            // 
            // TypeExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(464, 181);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.gbTypeExport);
            this.Controls.Add(this.lkTitre);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "TypeExport";
            this.Text = "TypeExport";
            this.gbTypeExport.ResumeLayout(false);
            this.gbTypeExport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lkTitre;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.RadioButton rbPDF;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox gbTypeExport;
    }
}