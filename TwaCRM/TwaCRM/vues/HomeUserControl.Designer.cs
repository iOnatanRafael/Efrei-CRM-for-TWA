namespace TwaCRM.vues
{
    partial class HomeUserControl
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
            this.buttonEntreprisesClientes = new System.Windows.Forms.Button();
            this.buttonInterimaires = new System.Windows.Forms.Button();
            this.buttonMissions = new System.Windows.Forms.Button();
            this.buttonFirstInit = new System.Windows.Forms.Button();
            this.buttonSauvegarder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEntreprisesClientes
            // 
            this.buttonEntreprisesClientes.Location = new System.Drawing.Point(283, 20);
            this.buttonEntreprisesClientes.Name = "buttonEntreprisesClientes";
            this.buttonEntreprisesClientes.Size = new System.Drawing.Size(641, 134);
            this.buttonEntreprisesClientes.TabIndex = 0;
            this.buttonEntreprisesClientes.Text = "ENTREPRISES CLIENTES";
            this.buttonEntreprisesClientes.UseVisualStyleBackColor = true;
            this.buttonEntreprisesClientes.Click += new System.EventHandler(this.buttonEntreprisesClientes_Click);
            // 
            // buttonInterimaires
            // 
            this.buttonInterimaires.Location = new System.Drawing.Point(283, 178);
            this.buttonInterimaires.Name = "buttonInterimaires";
            this.buttonInterimaires.Size = new System.Drawing.Size(641, 134);
            this.buttonInterimaires.TabIndex = 1;
            this.buttonInterimaires.Text = "EMPLOYES INTERIMAIRES";
            this.buttonInterimaires.UseVisualStyleBackColor = true;
            this.buttonInterimaires.Click += new System.EventHandler(this.buttonInterimaires_Click);
            // 
            // buttonMissions
            // 
            this.buttonMissions.Location = new System.Drawing.Point(283, 336);
            this.buttonMissions.Name = "buttonMissions";
            this.buttonMissions.Size = new System.Drawing.Size(641, 134);
            this.buttonMissions.TabIndex = 2;
            this.buttonMissions.Text = "MISSIONS";
            this.buttonMissions.UseVisualStyleBackColor = true;
            this.buttonMissions.Click += new System.EventHandler(this.buttonMissions_Click);
            // 
            // buttonFirstInit
            // 
            this.buttonFirstInit.Location = new System.Drawing.Point(283, 492);
            this.buttonFirstInit.Name = "buttonFirstInit";
            this.buttonFirstInit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonFirstInit.Size = new System.Drawing.Size(640, 33);
            this.buttonFirstInit.TabIndex = 3;
            this.buttonFirstInit.Text = "Initialiser pour la première fois";
            this.buttonFirstInit.UseVisualStyleBackColor = true;
            this.buttonFirstInit.Click += new System.EventHandler(this.buttonFirstInit_Click);
            // 
            // buttonSauvegarder
            // 
            this.buttonSauvegarder.Location = new System.Drawing.Point(283, 531);
            this.buttonSauvegarder.Name = "buttonSauvegarder";
            this.buttonSauvegarder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSauvegarder.Size = new System.Drawing.Size(640, 33);
            this.buttonSauvegarder.TabIndex = 4;
            this.buttonSauvegarder.Text = "Sauvegarder les données";
            this.buttonSauvegarder.UseVisualStyleBackColor = true;
            this.buttonSauvegarder.Click += new System.EventHandler(this.buttonSauvegarder_Click);
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSauvegarder);
            this.Controls.Add(this.buttonFirstInit);
            this.Controls.Add(this.buttonMissions);
            this.Controls.Add(this.buttonInterimaires);
            this.Controls.Add(this.buttonEntreprisesClientes);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(1180, 580);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEntreprisesClientes;
        private System.Windows.Forms.Button buttonInterimaires;
        private System.Windows.Forms.Button buttonMissions;
        private System.Windows.Forms.Button buttonFirstInit;
        private System.Windows.Forms.Button buttonSauvegarder;

    }
}
