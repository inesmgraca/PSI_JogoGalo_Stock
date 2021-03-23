using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockProjeto
{
    public partial class FrmListStock : Form
    {
        public FrmListStock()
        {
            InitializeComponent();
            dataGrid_Stock();
            txtPesquisa.Focus();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
                dataGrid_StockProduto();
            else
                dataGrid_Stock();
        }

        private void dataGrid_Stock()
        {
            var connString = System.Configuration.ConfigurationManager.ConnectionStrings["StockProjetoDB"].ConnectionString;
            var db = new SqlConnection(connString);

            try
            {
                db.Open();
                var cmd = new SqlCommand();
                cmd.Connection = db;

                cmd.CommandText = "select Codigo, sum(QtMov) as 'Stock' from MovimentoStock left join Produtos on MovimentoStock.ProdutoID = Produtos.ProdutoID group by Codigo;";

                var dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    var ds = new DataSet();
                    var dataTable = new DataTable("Results");
                    ds.Tables.Add(dataTable);
                    ds.Load(dr, LoadOption.PreserveChanges, ds.Tables["Results"]);
                    dataGridResults.DataSource = ds.Tables["Results"];
                }

                dr.Dispose();
                db.Close();
                db.Dispose();

                lblStockAtual.Visible = false;
                txtStockAtual.Visible = false;
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

        private void dataGrid_StockProduto()
        {
            var connString = System.Configuration.ConfigurationManager.ConnectionStrings["StockProjetoDB"].ConnectionString;
            var db = new SqlConnection(connString);

            try
            {
                db.Open();
                var cmd = new SqlCommand();
                cmd.Connection = db;

                cmd.CommandText = "select Codigo, QtMov as 'Stock' from MovimentoStock left join Produtos on MovimentoStock.ProdutoID = Produtos.ProdutoID where Codigo=@codigo;";
                cmd.Parameters.AddWithValue("@codigo", txtPesquisa.Text);

                var dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    var ds = new DataSet();
                    var dataTable = new DataTable("Results");
                    ds.Tables.Add(dataTable);
                    ds.Load(dr, LoadOption.PreserveChanges, ds.Tables["Results"]);
                    dataGridResults.DataSource = ds.Tables["Results"];

                    lblStockAtual.Visible = true;
                    txtStockAtual.Visible = true;

                    cmd = new SqlCommand();
                    cmd.Connection = db;

                    cmd.CommandText = "select sum(QtMov) as 'Stock' from MovimentoStock left join Produtos on MovimentoStock.ProdutoID = Produtos.ProdutoID where Codigo=@codigo;";
                    cmd.Parameters.AddWithValue("@codigo", txtPesquisa.Text);

                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            txtStockAtual.Text = dr["Stock"].ToString();
                        }
                    }
                }
                else
                    MessageBox.Show("Pesquisa inválida.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
    }
}
