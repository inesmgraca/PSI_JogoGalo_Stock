using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockProjeto
{
    public partial class FrmEdit : Form
    {
        private string Descricao;

        public FrmEdit()
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
                        btnEdit.Visible = true;

                        while (dr.Read())
                        {
                            txtDescricao.Text = dr["Descricao"].ToString();
                            Descricao = dr["Descricao"].ToString();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Descricao.Equals(txtDescricao.Text))
            {
                MessageBox.Show("Não foram realizadas alterações.", "Aviso!");
            }
            else
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

                        cmd.CommandText = "update Produtos set Descricao=@descricao where Codigo=@codigo;";
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                        cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("O produto foi editado.", "Sucesso!", MessageBoxButtons.OK);
                            Close();
                        }
                        else
                            MessageBox.Show("Houve um erro ao editar.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Descricao = "";
            lblDescricao.Visible = false;
            txtDescricao.Visible = false;
            btnEdit.Visible = false;
        }
    }
}
