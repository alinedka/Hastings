using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PI_3_Defensores_de_Hastings
{
    public partial class Form2 : Form
    {
        private string estadoJogo; // :) Armazena o estado do jogo como string
        private string[] arEstadoDoJogo; // :) Array para dividir os valores do estado do jogo
        private Panel pnlPersonagem; // :) Painel onde o personagem será exibido

        public Form2(string estadoDoJogo)
        {
            InitializeComponent(); // :) Inicializa os componentes do formulário
            estadoJogo = estadoDoJogo; // :) Atribui o estado do jogo recebido como parâmetro
            arEstadoDoJogo = estadoJogo.Split(','); // :) Divide a string do estado do jogo em partes
            CarregarImagem(); // :) Chama o método para carregar a imagem de fundo
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CarregarImagem(); // :) Recarrega a imagem ao clicar no PictureBox
        }

        private void CarregarImagem()
        {
            string imagePath = @"C:\\Users\\willi\\Downloads\\Hastings\\imagens\\tabuleiro.jpg"; // :) Caminho da imagem de fundo

            if (File.Exists(imagePath)) // :) Verifica se o arquivo existe
            {
                if (pictureBox1.Image == null) // :) Só carrega a imagem se ainda não estiver carregada
                {
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read)) // :) Usa FileStream para evitar bloqueio do arquivo
                    {
                        pictureBox1.Image = Image.FromStream(fs); // :) Carrega a imagem no PictureBox
                    }
                }
            }
            else
            {
                MessageBox.Show("Imagem não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); // :) Exibe mensagem de erro se a imagem não for encontrada
            }
        }

        private void Colocar1()
        {
            if (arEstadoDoJogo == null || arEstadoDoJogo.Length < 2) // :) Verifica se há informações suficientes no estado do jogo
            {
                MessageBox.Show("Dados do jogo incompletos!"); // :) Exibe um alerta caso os dados estejam incompletos
                return;
            }

            string nivel = arEstadoDoJogo[0]; // :) Obtém o nível do jogo
            string letraPersonagem = arEstadoDoJogo[1].Replace("'", "").Trim().ToUpper(); // :) Remove aspas simples e converte a letra para maiúscula

            Dictionary<string, string> personagensDict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) // :) Dicionário que relaciona as letras aos arquivos de imagem
            {
                { "A", "Adilson Konrad.png" }, { "B", "Beatriz Paiva.png" }, { "C", "Claro.png" },
                { "D", "Douglas Baquiao.png" }, { "E", "Eduardo Takeo.png" }, { "G", "Guilherme Rey.png" },
                { "H", "Heredia.png" }, { "K", "Kelly Kiyumi.png" }, { "L", "Leonardo Takuno.png" },
                { "M", "Mario Toledo.png" }, { "Q", "Quintas.png" }, { "R", "Ranulfo.png" },
                { "T", "Toshio.png" }
            };

            if (nivel == "1" && personagensDict.TryGetValue(letraPersonagem, out string nomeArquivo)) // :) Verifica se o personagem existe no dicionário
            {
                string caminhoImagem = Path.Combine(@"C:\\Users\\willi\\Downloads\\Hastings\\imagens", nomeArquivo); // :) Monta o caminho da imagem do personagem

                if (!File.Exists(caminhoImagem)) // :) Verifica se o arquivo da imagem existe
                {
                    MessageBox.Show($"Arquivo não encontrado: {caminhoImagem}"); // :) Exibe um alerta se a imagem não for encontrada
                    return;
                }

                if (pnlPersonagem == null) // :) Se o painel do personagem ainda não foi criado, cria um novo painel
                {
                    pnlPersonagem = new Panel
                    {
                        Size = new Size(50, 50), // :) Define o tamanho do painel
                        BackgroundImageLayout = ImageLayout.Stretch, // :) Ajusta a imagem para ocupar todo o painel
                        Location = new Point(275, 535) // :) Define a posição inicial do personagem
                    };
                    this.Controls.Add(pnlPersonagem); // :) Adiciona o painel ao formulário
                }

                try
                {
                    using (FileStream fs = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read)) // :) Usa FileStream para carregar a imagem sem bloqueá-la
                    {
                        pnlPersonagem.BackgroundImage = Image.FromStream(fs); // :) Define a imagem de fundo do painel como a imagem do personagem
                    }
                    pnlPersonagem.BringToFront(); // :) Traz o personagem para frente de outros elementos da tela
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar imagem: {ex.Message}"); // :) Exibe um erro caso algo dê errado ao carregar a imagem
                }
            }
            else
            {
                MessageBox.Show($"Personagem '{letraPersonagem}' não encontrado. Opções válidas: " + // :) Exibe um alerta caso a letra do personagem não seja válida
                                string.Join(", ", personagensDict.Keys));
            }
        }

        private void btnColocarPerso_Click(object sender, EventArgs e)
        {
            Colocar1(); // :) Chama o método para posicionar o personagem ao clicar no botão
        }
    }
}
