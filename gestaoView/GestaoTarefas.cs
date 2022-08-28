using Controle_de_tarefas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_tarefas.gestaoView
{
    public partial class GestaoTarefas : Form
    {
        public GestaoTarefas()
        {
            InitializeComponent();
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            if (textBoxIdTarefa.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir algum valor para a pesquisa", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBoxIdTarefa.Text);
                controle.IdTarefa(id);

                textBoxDescricao.Text = controle.descricao;
                comboBoxCategoria.Text = controle.categoria;
                comboBoxSituacao.Text = controle.situacao;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
           
            string mensagem = controle.cadastrar(textBoxDescricao.Text, comboBoxCategoria.Text, comboBoxSituacao.Text);

            if (controle.Existe)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }
            textBoxDescricao.Clear();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            //fecha tela atual
            this.Hide();
            //abre nova tela
            Form1 open = new Form1();
            open.Closed += (s, args) => this.Close();
            open.Show();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            int id = Convert.ToInt32(textBoxIdTarefa.Text);

            string mensagem = controle.atualizar(id,textBoxDescricao.Text, comboBoxCategoria.Text, comboBoxSituacao.Text);

            if (controle.Existe)
            {
                MessageBox.Show(mensagem, "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            int id = Convert.ToInt32(textBoxIdTarefa.Text);

            controle.apagar(id);

            if (controle.Mensagem.Equals(""))
            {
                MessageBox.Show("Registro apagado com sucesso!!", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.Mensagem + " " + "Não foi possível apagar esse registro, favor informar um id", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void criar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            string mensagem = controle.cadastrar(textBoxDescricao.Text, comboBoxCategoria.Text, comboBoxSituacao.Text);

            if (controle.Existe)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }
            textBoxDescricao.Clear();
        }
    }
}
