using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGalo_ScoreBoard
{
    public partial class JogoGalo : Form
    {
        public JogoGalo()
        {
            InitializeComponent();
        }

        private void menuStripBtnNew_Click(object sender, EventArgs e)
        {
            var game = new Game();
            game.MdiParent = this;
            game.Show();
        }

        private void menuStripBtnEnd_Click(object sender, EventArgs e)
        {
            var activeChild = this.ActiveMdiChild;

            if (activeChild != null)
                activeChild.Close();
        }

        private void menuStripExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Exit?", MessageBoxButtons.OK) == DialogResult.OK)
                Application.Exit();
        }
    }
}
