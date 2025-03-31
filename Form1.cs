using KingMeServer; // :) Importa o namespace KingMeServer
using System; // :) Importa o namespace System
using System.Collections.Generic; // :) Importa o namespace para coleções genéricas
using System.ComponentModel; // :) Importa o namespace para componentes
using System.Data; // :) Importa o namespace para acesso a dados
using System.Drawing; // :) Importa o namespace para manipulação gráfica
using System.Linq; // :) Importa o namespace LINQ
using System.Text; // :) Importa o namespace para manipulação de texto
using System.Threading.Tasks; // :) Importa o namespace para tarefas assíncronas
using System.Windows.Forms; // :) Importa o namespace para Windows Forms

namespace PI_3_Defensores_de_Hastings // :) Define o namespace da aplicação
{
    public partial class Form1 : Form // :) Declara a classe Form1 que herda de Form
    {
        public string versao { get; set; } // :) Declara a propriedade pública 'versao' com get e set

        public Form1() // :) Construtor da classe Form1
        {
            InitializeComponent(); // :) Inicializa os componentes do formulário
        }

        public void AtualizarTela() // :) Método para atualizar a tela
        {
            //lblControleDeVersao.Text = versao; // :) Atualiza o label de controle de versão com o valor da propriedade 'versao'
        }

        private void btnPartida_Click(object sender, EventArgs e) // :) Evento de clique do botão btnPartida
        {
            string nome = nomeDaPartida.Text; // :) Armazena o texto do controle nomeDaPartida na variável 'nome'
            string senha = senhaDaPartida.Text; // :) Armazena o texto do controle senhaDaPartida na variável 'senha'
            string grupo = nomeDoGrupo.Text; // :) Armazena o texto do controle nomeDoGrupo na variável 'grupo'

            string id = KingMeServer.Jogo.CriarPartida(nome, senha, grupo); // :) Cria uma partida chamando o método CriarPartida e armazena o ID retornado
            idDaPartida.Text = id; // :) Exibe o ID da partida no controle idDaPartida

            if (nome == string.Empty) // :) Verifica se o nome está vazio
            {
                MessageBox.Show("Insira o nome da partida: ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); // :) Exibe mensagem de erro se o nome estiver vazio
                return; // :) Encerra o método se o nome estiver vazio
            }

            if (senha == string.Empty) // :) Verifica se a senha está vazia
            {
                MessageBox.Show("Insira a sua senha: ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); // :) Exibe mensagem de erro se a senha estiver vazia
                return; // :) Encerra o método se a senha estiver vazia
            }

            if (grupo == string.Empty) // :) Verifica se o nome do grupo está vazio
            {
                MessageBox.Show("Insira o nome do grupo: ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); // :) Exibe mensagem de erro se o grupo estiver vazio
                return; // :) Encerra o método se o grupo estiver vazio
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e) // :) Evento de alteração de seleção do listBox1 (primeira ocorrência)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // :) Evento de alteração de texto no textBox1
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) // :) Evento de alteração de seleção do listBox1 (segunda ocorrência)
        {
        }

        private void Form1_Load(object sender, EventArgs e) // :) Evento de carregamento do formulário Form1
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) // :) Outro evento de alteração de texto no textBox1
        {
        }

        private void label2_Click(object sender, EventArgs e) // :) Evento de clique no label2
        {
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e) // :) Mais um evento de alteração de texto no textBox1
        {
        }

        private void label4_Click(object sender, EventArgs e) // :) Evento de clique no label4
        {
        }

        private void label3_Click(object sender, EventArgs e) // :) Evento de clique no label3
        {
        }

        private void idDaPartida_TextChanged(object sender, EventArgs e) // :) Evento de alteração de texto no controle idDaPartida
        {
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) // :) Evento de alteração de seleção no listBox2
        {
        }

        private void label1_Click(object sender, EventArgs e) // :) Evento de clique no label1
        {
        }

        private void btnChamaForms2_Click(object sender, EventArgs e) // :) Evento de clique do botão btnChamaForms2
        {
            this.Close(); // :) Fecha o formulário atual
        }

        private void lblControleDeVersao_Click(object sender, EventArgs e) // :) Evento de clique no label lblControleDeVersao
        {
        }

        private void lblData_Click(object sender, EventArgs e) // :) Evento de clique no label lblData
        {
        }

        private void nomeDoGrupo_TextChanged(object sender, EventArgs e) // :) Evento de alteração de texto no controle nomeDoGrupo
        {
        }

        private void nomeDaPartida_TextChanged(object sender, EventArgs e) // :) Evento de alteração de texto no controle nomeDaPartida
        {
        }
    }
}