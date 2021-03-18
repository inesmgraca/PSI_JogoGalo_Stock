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
                MessageBox.Show("O código deve estar preenchido.", "Aviso!");
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
                var connString = System.Configuration.ConfigurationManager.ConnectionStrings["StockProjetoDB"].ConnectionString;
                var db = new SqlConnection(connString);

                try
                {
                    db.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = db;

                    cmd.CommandText = "select * from Produtos where Codigo=@codigo;";
                    cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);

                    var dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        MessageBox.Show("Já existe um produto com este código.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show("Tem a certeza que pretende adicionar este produto?", "Adicionar?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            cmd = new SqlCommand();
                            cmd.Connection = db;

                            cmd.CommandText = "insert into Produtos (Codigo, Descricao) values (@codigo, @descricao)";
                            cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);

                            cmd.ExecuteNonQuery();
                            cmd.Dispose();

                            MessageBox.Show("O produto foi adicionado.", "Sucesso!", MessageBoxButtons.OK);
                            Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mensagem de erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }
    }
}
