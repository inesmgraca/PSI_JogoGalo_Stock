using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProjeto
{
    public partial class FrmDelete : Form
    {
        public FrmDelete()
        {
            InitializeComponent();
            txtCodigo.Focus();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
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
                        lblDescricao.Visible = true;
                        txtDescricao.Visible = true;
                        btnDelete.Visible = true;

                        while (dr.Read())
                        {
                            txtDescricao.Text = dr["Descricao"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não existe um produto com este código.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dr.Close();
                    db.Close();
                    db.Dispose();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Mensagem de erro: " + ex.Message, "Erro de Base de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mensagem de erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O código não pode estar vazio.", "Aviso!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende editar este produto?", "Submeter?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var connString = System.Configuration.ConfigurationManager.ConnectionStrings["StockProjetoDB"].ConnectionString;
                var db = new SqlConnection(connString);

                try
                {
                    db.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = db;

                    cmd.CommandText = "delete from Produtos where Codigo=@codigo;";
                    cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);

                    var eliminar = cmd.ExecuteNonQuery();

                    if (eliminar == 1)
                    {
                        MessageBox.Show("O produto foi eliminado.", "Sucesso!", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                        MessageBox.Show("Houve um erro ao eliminar.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    db.Close();
                    db.Dispose();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Mensagem de erro: " + ex.Message, "Erro de Base de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mensagem de erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            lblDescricao.Visible = false;
            txtDescricao.Visible = false;
            btnDelete.Visible = false;
        }
    }
}
