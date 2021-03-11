using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JogoGalo.Regras;

namespace JogoGalo
{
    public partial class JogoGalo : Form
    {
        JogoDePollo jogo;

        public JogoGalo()
        {
            InitializeComponent();
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            jogo = new JogoDePollo();
            btnPosicao1.Enabled = true;
            btnPosicao1.Text = "";
            btnPosicao2.Enabled = true;
            btnPosicao2.Text = "";
            btnPosicao3.Enabled = true;
            btnPosicao3.Text = "";
            btnPosicao4.Enabled = true;
            btnPosicao4.Text = "";
            btnPosicao5.Enabled = true;
            btnPosicao5.Text = "";
            btnPosicao6.Enabled = true;
            btnPosicao6.Text = "";
            btnPosicao7.Enabled = true;
            btnPosicao7.Text = "";
            btnPosicao8.Enabled = true;
            btnPosicao8.Text = "";
            btnPosicao9.Enabled = true;
            btnPosicao9.Text = "";
            btnIniciarJogo.Text = "Reiniciar Jogo";
        }

        private void btnPosicao1_Click(object sender, EventArgs e)
        {
            posicaoJogar(1, btnPosicao1);
        }

        private void btnPosicao2_Click(object sender, EventArgs e)
        {
            posicaoJogar(2, btnPosicao2);
        }

        private void btnPosicao3_Click(object sender, EventArgs e)
        {
            posicaoJogar(3, btnPosicao3);
        }

        private void btnPosicao4_Click(object sender, EventArgs e)
        {
            posicaoJogar(4, btnPosicao4);
        }

        private void btnPosicao5_Click(object sender, EventArgs e)
        {
            posicaoJogar(5, btnPosicao5);
        }

        private void btnPosicao6_Click(object sender, EventArgs e)
        {
            posicaoJogar(6, btnPosicao6);
        }

        private void btnPosicao7_Click(object sender, EventArgs e)
        {
            posicaoJogar(7, btnPosicao7);
        }

        private void btnPosicao8_Click(object sender, EventArgs e)
        {
            posicaoJogar(8, btnPosicao8);
        }

        private void btnPosicao9_Click(object sender, EventArgs e)
        {
            posicaoJogar(9, btnPosicao9);
        }

        private void posicaoJogar(int posicaoJogada, Button btnJogada)
        {
            if (jogo != null)
            {
                var jogada = jogo.Jogar(posicaoJogada);

                if (jogo.EndGame)
                {
                    if (jogada == EstadoJogo.Empate)
                    {
                        btnJogada.Text = jogo.Peca == "X" ? "O" : "X";
                        txtEndGame.Text += "\nEmpate!";
                    }
                    if (jogada == EstadoJogo.Vitoria1)
                    {
                        btnJogada.Text = jogo.Peca;
                        txtEndGame.Text += "\nVitória do Jogador X!";
                    }
                    if (jogada == EstadoJogo.Vitoria2)
                    {
                        btnJogada.Text = jogo.Peca;
                        txtEndGame.Text += "\nVitória do Jogador O!";
                    }

                    jogo = null;
                    btnPosicao1.Enabled = false;
                    btnPosicao2.Enabled = false;
                    btnPosicao3.Enabled = false;
                    btnPosicao4.Enabled = false;
                    btnPosicao5.Enabled = false;
                    btnPosicao6.Enabled = false;
                    btnPosicao7.Enabled = false;
                    btnPosicao8.Enabled = false;
                    btnPosicao9.Enabled = false;
                }
                else if (jogada == EstadoJogo.Valido)
                {
                    btnJogada.Text = jogo.Peca == "X" ? "O" : "X";
                }
            }
        }
    }
}
