using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_cp_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            int idade;
            int tempoContribuicao;

            if (!int.TryParse(textBoxIdade.Text, out idade))
            {
                MessageBox.Show("Por favor, insira uma idade válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxTempoContribuicao.Text, out tempoContribuicao))
            {
                MessageBox.Show("Por favor, insira um tempo de contribuição válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string genero = comboBoxGenero.SelectedItem.ToString();

            if (genero == "Masculino")
            {
                int idadeMinima = 65;
                int tempoMinimoContribuicao = 20;

                string mensagem = "Você ainda não pode se aposentar.\n";

                bool podeAposentar = true;


                if (idade < idadeMinima)
                {
                    int anosRestantesIdade = idadeMinima - idade;
                    mensagem += $"Faltam {anosRestantesIdade} anos para atingir a idade mínima de 65 anos.\n";
                    podeAposentar = false;
                }


                if (tempoContribuicao < tempoMinimoContribuicao)
                {
                    int anosRestantesContribuicao = tempoMinimoContribuicao - tempoContribuicao;
                    mensagem += $"Faltam {anosRestantesContribuicao} anos de contribuição para atingir 20 anos.\n";
                    podeAposentar = false;
                }

                if (podeAposentar)
                {
                    MessageBox.Show("Você pode se aposentar!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (genero == "Feminino")
            {
                int idadeMinima = 60;
                int tempoMinimoContribuicao = 15;

                string mensagem = "Você ainda não pode se aposentar.\n";

                bool podeAposentar = true;


                if (idade < idadeMinima)
                {
                    int anosRestantesIdade = idadeMinima - idade;
                    mensagem += $"Faltam {anosRestantesIdade} anos para atingir a idade mínima de 60 anos.\n";
                    podeAposentar = false;
                }


                if (tempoContribuicao < tempoMinimoContribuicao)
                {
                    int anosRestantesContribuicao = tempoMinimoContribuicao - tempoContribuicao;
                    mensagem += $"Faltam {anosRestantesContribuicao} anos de contribuição para atingir 15 anos.\n";
                    podeAposentar = false;
                }

                if (podeAposentar)
                {
                    MessageBox.Show("Você pode se aposentar!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Gênero não reconhecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
