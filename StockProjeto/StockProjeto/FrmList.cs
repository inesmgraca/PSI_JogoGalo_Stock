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
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
            var connString = System.Configuration.ConfigurationManager.ConnectionStrings["StockProjetoDB"].ConnectionString;
            var db = new SqlConnection(connString);

            try
            {
                db.Open();
                var cmd = new SqlCommand();
                cmd.Connection = db;

                cmd.CommandText = "select Codigo, Descricao from Produtos;";

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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
            {
                var connString = System.Configuration.ConfigurationManager.ConnectionStrings["StockProjetoDB"].ConnectionString;
                var db = new SqlConnection(connString);

                try
                {
                    db.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = db;

                    cmd.CommandText = "select Codigo, Descricao from Produtos where Codigo like @codigo or Descricao like @descricao;";
                    cmd.Parameters.AddWithValue("@codigo", $"%{txtPesquisa.Text}%");
                    cmd.Parameters.AddWithValue("@descricao", $"%{txtPesquisa.Text}%");

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
                var connString = System.Configuration.ConfigurationManager.ConnectionStrings["StockProjetoDB"].ConnectionString;
                var db = new SqlConnection(connString);

                try
                {
                    db.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = db;

                    cmd.CommandText = "select Codigo, Descricao from Produtos;";

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
