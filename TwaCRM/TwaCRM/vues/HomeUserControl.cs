using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwaCRM.vues
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Dock = DockStyle.Fill;
        }

        private void buttonFirstInit_Click(object sender, EventArgs e)
        {
            TwaCrm.firstInit();
        }

        private void buttonSauvegarder_Click(object sender, EventArgs e)
        {
            TwaCrm.sauvegarderPools();
        }

        public event EventHandler OnButtonEntreprisesClientesClick;

        private void buttonEntreprisesClientes_Click(object sender, EventArgs e)
        {
            if (this.OnButtonEntreprisesClientesClick != null)
            {
                this.OnButtonEntreprisesClientesClick(this, e);
            }
        }

        public event EventHandler OnButtonInterimairesClick;

        private void buttonInterimaires_Click(object sender, EventArgs e)
        {
            if (this.OnButtonInterimairesClick != null)
            {
                this.OnButtonInterimairesClick(this, e);
            }
        }

        public event EventHandler OnButtonMissionsClick;

        private void buttonMissions_Click(object sender, EventArgs e)
        {
            if (this.OnButtonMissionsClick != null)
            {
                this.OnButtonMissionsClick(this, e);
            }
        }
    }
}
