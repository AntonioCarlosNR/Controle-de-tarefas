using Controle_de_tarefas.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_tarefas.Modelo
{
    class Controle: AbsProperties
    {
        Tarefa tarefa = new Tarefa();
        public void IdTarefa(int id)
        {

            //Tarefa tarefa = new Tarefa();
            tarefa.buscaIdTarefa(id);
            id = tarefa.id;
            descricao = tarefa.descricao;
            categoria = tarefa.categoria;
            situacao = tarefa.situacao;
            horaEstimada = tarefa.horaEstimada;


        }

        public string cadastrar(string descricao, string categoria, string situacao, string horaEstimada)
        {
            this.Mensagem = tarefa.cadastrar(descricao, categoria, situacao, horaEstimada);
            if (tarefa.Existe)
            {
                this.Existe = true;
            }
            return Mensagem;
        }
        public string atualizar(int id, string descricao, string categoria, string situacao, string horaEstimada)
        {
            this.Mensagem = tarefa.atualizar(id ,descricao, categoria, situacao, horaEstimada);
            if (tarefa.Existe)
            {
                this.Existe = true;
            }
            return Mensagem;
        }

        public bool apagar(int id)
        {
            this.Mensagem = "";
            Existe = tarefa.apagar(id);
            if (!Mensagem.Equals(""))
            {
                this.Mensagem = tarefa.Mensagem;
            }
            return Existe;
        }
    }
}
