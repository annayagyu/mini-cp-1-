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
    public partial class Form2: Form
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
                if (idade < 65 || tempoContribuicao < 20)
                {
                    MessageBox.Show("Você ainda não pode se aposentar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você pode se aposentar!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (genero == "Feminino")
            {
                if (idade < 60 || tempoContribuicao < 15)
                {
                    MessageBox.Show("Você ainda não pode se aposentar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você pode se aposentar!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Gênero não reconhecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
