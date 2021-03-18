using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProjeto
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripBtnEdit_Click(object sender, EventArgs e)
        {
            var frm = new FrmEdit();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripBtnDelete_Click(object sender, EventArgs e)
        {
            var frm = new FrmDelete();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripBtnList_Click(object sender, EventArgs e)
        {
            var frm = new FrmList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripBtnMoveStock_Click(object sender, EventArgs e)
        {
            var frm = new FrmMoveStock();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripBtnListStock_Click(object sender, EventArgs e)
        {
            var frm = new FrmListStock();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
