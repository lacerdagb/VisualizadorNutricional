using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizadorNutricional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e) // Define tamanho fixo para o pictureBox2 ao ser clicado.
        {
            pictureBox2.Width = 200; // Defina a largura
            pictureBox2.Height = 200; // Defina a altura igual à largura
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtém uma lista de arquivos de imagem da pasta de produtos.
            string[] nomeFotoProdutos = Directory.GetFiles(@"C:\Users\Gabriel\OneDrive\Documentos\Estudos\Projetos\VisualizadorNutricional\imagens");
            foreach (string img in nomeFotoProdutos) // Para cada imagem encontrada na pasta de produtos.
            {
                string[] separador = img.Split('\\'); // Separa o caminho do arquivo em partes, usando o caractere "\".
                string[] nomeSelecionado = separador[9].Split('.'); // Pega o nome do arquivo sem a extensão.

                if (comboBox2.Text == nomeSelecionado[0]) // Verifica se o item selecionado no comboBox2 corresponde ao nome da imagem.
                {
                    // Define a imagem do produto no pictureBox1.
                    pictureBox1.ImageLocation = @"C:\Users\Gabriel\OneDrive\Documentos\Estudos\Projetos\VisualizadorNutricional\imagens\" + comboBox2.Text + ".png";
                }
                // Obtém uma lista de arquivos de imagem da pasta de tabelas nutricionais.
                string[] nomeFotoTabela = Directory.GetFiles(@"C:\Users\Gabriel\OneDrive\Documentos\Estudos\Projetos\VisualizadorNutricional\tabela");
                foreach (string img2 in nomeFotoTabela) // Para cada imagem de tabela nutricional encontrada.
                {
                    string[] separador2 = img2.Split('\\'); // Separa o caminho do arquivo em partes.
                    string[] nomeSelecionado2 = separador2[9].Split('.'); // Pega o nome do arquivo sem a extensão.


                    if (comboBox2.Text == nomeSelecionado2[0]) // Verifica se o item selecionado no comboBox2 corresponde ao nome da tabela.
                    {
                        // Define a tabela nutricional no pictureBox2.
                        pictureBox2.ImageLocation = @"C:\Users\Gabriel\OneDrive\Documentos\Estudos\Projetos\VisualizadorNutricional\tabela\" + comboBox2.Text + ".png";
                    }
                }

                if (comboBox2.Text == nomeSelecionado[0])
                {
                    pictureBox2.ImageLocation = @"C:\Users\Gabriel\OneDrive\Documentos\Estudos\Projetos\VisualizadorNutricional\tabela\" + comboBox2.Text + ".png";
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty; // Limpa a seleção do comboBox2.

            if (comboBox1.Text == "Frutas") // Define os itens do comboBox2 de acordo com a categoria selecionada.
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Maça");
                comboBox2.Items.Add("Banana");
                comboBox2.Items.Add("Abacate");
            }
            else if (comboBox1.Text == "Legumes")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Abóbora");
                comboBox2.Items.Add("Batata");
                comboBox2.Items.Add("Beterraba");
            }
            else if (comboBox1.Text == "Industrializados")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Biscoito");
                comboBox2.Items.Add("Macarrão");
                comboBox2.Items.Add("Creme de leite");
            }
            else
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Refrigerante");
                comboBox2.Items.Add("Iogurte");
                comboBox2.Items.Add("Energético");
            }



        }
    }

}
