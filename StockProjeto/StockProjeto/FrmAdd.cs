using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StockProjeto
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
            txtCodigo.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" && txtDescricao.Text != "")
            {
                MessageBox.Show("O código deve estar preenchido.", "Aviso!", MessageBoxIcon.);
            }
            else if (txtCodigo.Text != "" && txtDescricao.Text == "")
            {
                MessageBox.Show("A descrição deve estar preenchida.", "Aviso!");
            }
            else if (txtCodigo.Text == "" && txtDescricao.Text == "")
            {
                MessageBox.Show("Os campos devem estar preenchidos.", "Aviso!");
            }
            else
            {
                

                if (MessageBox.Show("Tem a certeza que pretende adicionar este produto?", "Adicionar?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                }
            }
        }
    }
}
