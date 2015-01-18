namespace TwaCRM
{
    partial class MainForm
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
            this.entreprisesClientesUserControl1 = new TwaCRM.vues.EntreprisesClientesUserControl();
            this.homeUserControl1 = new TwaCRM.vues.HomeUserControl();
            this.interimaireUserControl1 = new TwaCRM.vues.InterimairesUserControl();
            this.missionUserControl1 = new TwaCRM.vues.MissionsUserControl();
            this.SuspendLayout();
            // 
            // entreprisesClientesUserControl1
            // 
            this.entreprisesClientesUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entreprisesClientesUserControl1.Location = new System.Drawing.Point(0, 0);
            this.entreprisesClientesUserControl1.Name = "entreprisesClientesUserControl1";
            this.entreprisesClientesUserControl1.Size = new System.Drawing.Size(1184, 582);
            this.entreprisesClientesUserControl1.TabIndex = 1;
            this.entreprisesClientesUserControl1.Visible = false;
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeUserControl1.Location = new System.Drawing.Point(0, 0);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(1184, 582);
            this.homeUserControl1.TabIndex = 0;
            // 
            // interimaireUserControl1
            // 
            this.interimaireUserControl1.Location = new System.Drawing.Point(0, 0);
            this.interimaireUserControl1.Name = "interimaireUserControl1";
            this.interimaireUserControl1.Size = new System.Drawing.Size(1180, 580);
            this.interimaireUserControl1.TabIndex = 2;
            this.interimaireUserControl1.Visible = false;
            // 
            // missionUserControl1
            // 
            this.missionUserControl1.Location = new System.Drawing.Point(0, 0);
            this.missionUserControl1.Name = "missionUserControl1";
            this.missionUserControl1.Size = new System.Drawing.Size(1180, 580);
            this.missionUserControl1.TabIndex = 3;
            this.missionUserControl1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 582);
            this.Controls.Add(this.missionUserControl1);
            this.Controls.Add(this.interimaireUserControl1);
            this.Controls.Add(this.entreprisesClientesUserControl1);
            this.Controls.Add(this.homeUserControl1);
            this.Name = "MainForm";
            this.Text = "TwaCRM par Killian Herbunot & William Zhong";
            this.ResumeLayout(false);

        }

        #endregion

        private vues.HomeUserControl homeUserControl1;
        private vues.EntreprisesClientesUserControl entreprisesClientesUserControl1;
        private vues.InterimairesUserControl interimairesUserControl1;
        private vues.MissionsUserControl missionsUserControl1;

    }
}

