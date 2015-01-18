namespace TwaCRM.vues
{
    partial class InterimairesUserControl
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
            this.buttonLister = new System.Windows.Forms.Button();
            this.buttonChercher = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLister
            // 
            this.buttonLister.Location = new System.Drawing.Point(231, 21);
            this.buttonLister.Name = "buttonLister";
            this.buttonLister.Size = new System.Drawing.Size(713, 88);
            this.buttonLister.TabIndex = 1;
            this.buttonLister.Text = "Lister les employés intérimaires";
            this.buttonLister.UseVisualStyleBackColor = true;
            // 
            // buttonChercher
            // 
            this.buttonChercher.Location = new System.Drawing.Point(231, 130);
            this.buttonChercher.Name = "buttonChercher";
            this.buttonChercher.Size = new System.Drawing.Size(713, 88);
            this.buttonChercher.TabIndex = 2;
            this.buttonChercher.Text = "Chercher des employés intérimaires";
            this.buttonChercher.UseVisualStyleBackColor = true;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(231, 239);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(713, 88);
            this.buttonAjouter.TabIndex = 3;
            this.buttonAjouter.Text = "Ajouter un employé intérimaire";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(231, 352);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(713, 88);
            this.buttonSupprimer.TabIndex = 4;
            this.buttonSupprimer.Text = "Supprimer un employé intérimaire";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.Location = new System.Drawing.Point(231, 489);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(713, 23);
            this.buttonAccueil.TabIndex = 5;
            this.buttonAccueil.Text = "Retourner à l\'accueil";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            // 
            // InterimaireUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAccueil);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonChercher);
            this.Controls.Add(this.buttonLister);
            this.Name = "InterimaireUserControl";
            this.Size = new System.Drawing.Size(1180, 580);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLister;
        private System.Windows.Forms.Button buttonChercher;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonAccueil;
    }
}
