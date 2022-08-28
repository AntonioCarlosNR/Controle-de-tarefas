using Controle_de_tarefas.Classes;
using Controle_de_tarefas.gestaoView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_tarefas
{
    public partial class Form1 : Form
    {
        private Conexao conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listaTarefa_Click(object sender, EventArgs e)
        {
            conn = new Conexao();
            string strSql = "select * from TB_Tarefas";
           
            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());

            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewList.DataSource = contareceb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fecha tela atual
            this.Hide();
            //abre nova tela
            GestaoTarefas gt = new GestaoTarefas();
            gt.Closed += (s, args) => this.Close();
            gt.Show();
        }
    }
}
