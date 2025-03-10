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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxLogin.Text))
            {
                MessageBox.Show("O campo Login é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(BoxSenha.Text))
            {
                MessageBox.Show("O campo Senha é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se o login e a senha são corretos
            if (BoxLogin.Text == "RM550360" && BoxSenha.Text == "123")
            {
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Enviar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
