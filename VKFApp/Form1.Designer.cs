namespace VKFApp
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.développeursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traitementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boitesÀOutilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.gestionsToolStripMenuItem,
            this.basesToolStripMenuItem,
            this.traitementToolStripMenuItem,
            this.boitesÀOutilsToolStripMenuItem,
            this.paramètresToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.accueilToolStripMenuItem.Text = "&Accueil";
            // 
            // gestionsToolStripMenuItem
            // 
            this.gestionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projetsToolStripMenuItem});
            this.gestionsToolStripMenuItem.Name = "gestionsToolStripMenuItem";
            this.gestionsToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.gestionsToolStripMenuItem.Text = "&Gestions";
            // 
            // projetsToolStripMenuItem
            // 
            this.projetsToolStripMenuItem.Name = "projetsToolStripMenuItem";
            this.projetsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.projetsToolStripMenuItem.Text = "&Projets";
            // 
            // basesToolStripMenuItem
            // 
            this.basesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.fournisseursToolStripMenuItem,
            this.développeursToolStripMenuItem});
            this.basesToolStripMenuItem.Name = "basesToolStripMenuItem";
            this.basesToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.basesToolStripMenuItem.Text = "&Bases";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientsToolStripMenuItem.Text = "&Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // fournisseursToolStripMenuItem
            // 
            this.fournisseursToolStripMenuItem.Name = "fournisseursToolStripMenuItem";
            this.fournisseursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fournisseursToolStripMenuItem.Text = "&Fournisseurs";
            // 
            // développeursToolStripMenuItem
            // 
            this.développeursToolStripMenuItem.Name = "développeursToolStripMenuItem";
            this.développeursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.développeursToolStripMenuItem.Text = "&Développeurs";
            // 
            // traitementToolStripMenuItem
            // 
            this.traitementToolStripMenuItem.Name = "traitementToolStripMenuItem";
            this.traitementToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.traitementToolStripMenuItem.Text = "&Traitement";
            // 
            // boitesÀOutilsToolStripMenuItem
            // 
            this.boitesÀOutilsToolStripMenuItem.Name = "boitesÀOutilsToolStripMenuItem";
            this.boitesÀOutilsToolStripMenuItem.Size = new System.Drawing.Size(106, 21);
            this.boitesÀOutilsToolStripMenuItem.Text = "&Boites à outils";
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.paramètresToolStripMenuItem.Text = "&Paramètres";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(27, 21);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "VKFApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traitementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boitesÀOutilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem projetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem développeursToolStripMenuItem;
    }
}

