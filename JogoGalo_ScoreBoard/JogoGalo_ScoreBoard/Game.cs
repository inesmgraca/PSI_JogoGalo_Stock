using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JogoGalo_ScoreBoard.Rules;

namespace JogoGalo_ScoreBoard
{
    public partial class Game : Form
    {
        private JogoDePollo jogo = new JogoDePollo();

        public Game()
        {
            InitializeComponent();
        }

        private void Startup()
        {
            jogo.IniciarJogo();

            foreach (Control item in this.Controls)
            {
                if ((item.Tag != null) && (item.Tag.ToString() != ""))
                    item.Text = "";
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {

            if (jogo.EndGame)
            {
                MessageBox.Show("Jogo já terminado!");
                return;
            }

            string strPosicao = (sender as Button).Tag.ToString();
            int posicao = Convert.ToInt32(strPosicao);

            EstadoJogo estadoJogada = jogo.Jogar(posicao);

            if (jogo.EndGame)
            {
                (sender as Button).Text = jogo.Peca;

                if (estadoJogada == EstadoJogo.Empate)
                    MessageBox.Show("Empate");
                else
                {
                    WinPopup winPopup;

                    switch (estadoJogada)
                    {
                        case EstadoJogo.Vitoria1:
                            winPopup = new WinPopup("Congrats Player 1!");
                            winPopup.Show();
                            break;
                        case EstadoJogo.Vitoria2:
                            winPopup = new WinPopup("Congrats Player 2!");
                            winPopup.Show();
                            break;
                    }
                }
            }
            else
            {
                if (!((estadoJogada == EstadoJogo.Invalido) ||
                 (estadoJogada == EstadoJogo.Ocupado)))
                {
                    if (jogo.Jogador == 1)
                    {
                        (sender as Button).Text = "O";

                    }
                    else
                    {
                        (sender as Button).Text = "X";
                    }

                }
                else
                {
                    MessageBox.Show($"Posição ocupada!");
                }
            }

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Startup();
        }
    }
}
