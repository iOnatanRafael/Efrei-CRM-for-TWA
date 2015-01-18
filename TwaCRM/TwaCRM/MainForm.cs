using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwaCRM.vues;

namespace TwaCRM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            homeUserControl1.OnButtonEntreprisesClientesClick += new EventHandler(HomeUserControl_ButtonEntreprisesClientesClick);
            homeUserControl1.OnButtonInterimairesClick += new EventHandler(HomeUserControl_ButtonInterimairesClick);
            homeUserControl1.OnButtonMissionsClick += new EventHandler(HomeUserControl_ButtonMissionsClick);
        }

        protected void HomeUserControl_ButtonEntreprisesClientesClick(object sender, EventArgs e)
        {
            homeUserControl1.Visible = false;
            entreprisesClientesUserControl1.Visible = true;
        }

        protected void HomeUserControl_ButtonInterimairesClick(object sender, EventArgs e)
        {
            homeUserControl1.Visible = false;
            interimairesUserControl1.Visible = true;
        }

        protected void HomeUserControl_ButtonMissionsClick(object sender, EventArgs e)
        {
            homeUserControl1.Visible = false;
            missionsUserControl1.Visible = true;
        }
    }
}
