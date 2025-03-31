using KingMeServer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PI_3_Defensores_de_Hastings
{
    public partial class frmLobbyDaPartida : Form
    {
        private readonly int _idSala;
        private readonly Dictionary<string, string> _personagensDict = new Dictionary<string, string>()
        {
            { "A", "Adilson Konrad" }, { "B", "Beatriz Paiva" }, { "C", "Claro" }, { "D", "Douglas Baquiao" },
            { "E", "Eduardo Takeo" }, { "G", "Guilherme Rey" }, { "H", "Heredia" }, { "K", "Karin" },
            { "L", "Leonardo Takuno" }, { "M", "Mario Toledo" }, { "Q", "Quintas" }, { "R", "Ranulffo" },
            { "T", "Toshio" }
        };

        public frmLobbyDaPartida(int idSala, string a, string b)
        {
            InitializeComponent();
            _idSala = idSala;
            lblMostraID.Text = a;
            lblMostraSenha.Text = b;
            lblEstadoJogo.Visible = false;
        }

        private void bntComecar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out var idDoJogador))
            {
                MessageBox.Show("ID do jogador inválido. Insira um número válido.");
                return;
            }

            try
            {
                var senha = txtSenha.Text;
                Jogo.Iniciar(idDoJogador, senha);

                var cartas = Jogo.ListarCartas(idDoJogador, senha);
                txtCartas.Text = cartas;

                AtualizarLista(lstbPersonagens, Jogo.ListarPersonagens());
                AtualizarListaComPersonagens(TXBCartas, cartas);
                AtualizarLista(lstbSetores, Jogo.ListarSetores());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnColocarPersonagem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEscolheSetor.Text, out var setor) || !int.TryParse(lblMostraID.Text, out var idJogador))
            {
                MessageBox.Show("Valores inválidos. Verifique os campos e tente novamente.");
                return;
            }

            var estadoDoJogo = Jogo.ColocarPersonagem(idJogador, txtSenha.Text, setor, txtEscolhaPersonagem.Text);
            AtualizarLista(lstEstadoDoJogo, estadoDoJogo);
            lblEstadoJogo.Text = estadoDoJogo;
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            AtualizarLista(lstbJogadores, Jogo.ListarJogadores(_idSala));
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            var vez = Jogo.VerificarVez(_idSala).Split(',');
            lblMostraVez.Text = vez[0];
        }

        private void btnVerMapa_Click(object sender, EventArgs e)
        {
            new Form2(lblEstadoJogo.Text).ShowDialog();
        }

        private void AtualizarLista(ListBox listBox, string conteudo)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(conteudo.Replace("\r", "").Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries));

        }

        private void AtualizarListaComPersonagens(ListBox listBox, string cartas)
        {
            listBox.Items.Clear();
            foreach (var letra in cartas)
            {
                listBox.Items.Add(_personagensDict.TryGetValue(letra.ToString(), out var nome) ? nome : letra.ToString());
            }
        }
    }
}
