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
    public partial class WinPopup : Form
    {
        public WinPopup(string textWinPlayer)
        {
            InitializeComponent();
            lblWinPlayer.Text = textWinPlayer;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {



            // listBox1.Items.Add(mensagem); adiciona um elemento à listBox.
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
