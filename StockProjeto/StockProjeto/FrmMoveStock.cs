using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockProjeto
{
    public partial class FrmMoveStock : Form
    {
        public FrmMoveStock()
        {
            InitializeComponent();
            cmbBoxCodigo.Focus();

            var connString = System.Configuration.ConfigurationManager.ConnectionStrings["StockProjetoDB"].ConnectionString;
            var db = new SqlConnection(connString);

            try
            {
                db.Open();
                var cmd = new SqlCommand();
                cmd.Connection = db;

                cmd.CommandText = "select ProdutoID, Codigo from Produtos order by Codigo;";

                var dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    var ds = new DataSet();
                    var dataTable = new DataTable("Codigos");
                    ds.Tables.Add(dataTable);
                    ds.Load(dr, LoadOption.PreserveChanges, ds.Tables["Codigos"]);
                    cmbBoxCodigo.ValueMember = "ProdutoID";
                    cmbBoxCodigo.DisplayMember = "Codigo";
                    cmbBoxCodigo.DataSource = ds.Tables["Codigos"];
                }

                dr.Dispose();
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

        private void btnMoveStock_Click(object sender, EventArgs e)
        {
            if (txtQtMov.Text == "")
            {
                MessageBox.Show("A quantidade tem de ser um número inteiro positivo.", "Aviso!");
            }
            else if (!uint.TryParse(txtQtMov.Text, out var num))
            {
                MessageBox.Show("A quantidade tem de ser um número inteiro positivo.", "Aviso!");
            }
            else
            {
                int qtStock = 0;
                int.TryParse(txtQtMov.Text, out var qtMov);

                if (rdBtnRemoveStock.Checked)
                    qtMov *= -1;

                var connString = System.Configuration.ConfigurationManager.ConnectionStrings["StockProjetoDB"].ConnectionString;
                var db = new SqlConnection(connString);

                try
                {
                    db.Open();

                    var cmd = new SqlCommand();
                    cmd.Connection = db;

                    cmd.CommandText = "select ProdutoID, sum(QtMov) as 'Stock' from MovimentoStock where ProdutoID=@produtoID group by ProdutoID;";
                    cmd.Parameters.AddWithValue("@produtoID", cmbBoxCodigo.SelectedValue);

                    var dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                            int.TryParse(dr["Stock"].ToString(), out qtStock);
                    }

                    if (qtStock + qtMov < 0)
                    {
                        MessageBox.Show("Não existe stock para realizar esta ação.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show("Tem a certeza que pretende mover o stock?", "Adicionar?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            cmd = new SqlCommand();
                            cmd.Connection = db;

                            cmd.CommandText = "insert into MovimentoStock (ProdutoID, QtMov) values (@produtoID, @qtMov)";
                            cmd.Parameters.AddWithValue("@produtoID", cmbBoxCodigo.SelectedValue);
                            cmd.Parameters.AddWithValue("@qtMov", qtMov);

                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("O stock foi movido.", "Sucesso!", MessageBoxButtons.OK);
                                Close();
                            }
                            else
                                MessageBox.Show("Houve um erro ao mover o stock.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            db.Close();
                            db.Dispose();
                            Close();
                        }
                    }
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
}
