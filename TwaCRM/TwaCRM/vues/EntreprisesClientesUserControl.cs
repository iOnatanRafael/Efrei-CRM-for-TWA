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
    public partial class EntreprisesClientesUserControl : UserControl
    {
        public EntreprisesClientesUserControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Dock = DockStyle.Fill;
        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {

        }
    }
}
