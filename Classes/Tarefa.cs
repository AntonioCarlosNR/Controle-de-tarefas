using Controle_de_tarefas.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_tarefas.Classes
{
    class Tarefa : AbsProperties 
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public int id;
        public void buscaIdTarefa(int id)
        {
            cmd.CommandText = "select * from TB_Tarefas where ID_Cliente = @id";
            //comandos SQL se existem no BD 
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = con.conectar();
                //ExecuteReader() usado quando tem retorno tipo select
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Existe = true;
                    dr.Read();
                    id = dr.GetInt32(0);
                    descricao = dr.GetString(1);
                    categoria = dr.GetString(3);
                    situacao = dr.GetString(4);                    

                }
                con.desconection();
                dr.Close();
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com o Banco de dados!!";
            }
        }
        public string cadastrar(string descricao, string categoria, string situacao)
        {
            Existe = false;

            cmd.CommandText = "insert into TB_Tarefas (Ds_Tarefa, Ct_CategoriaTarefa,St_Tarefa) values (@descricao,@categoria,@situacao);";
            
            //cmd.CommandText = "insert into TB_Cliente (Nm_Cliente,Ds_Endereco,Ds_email,Ds_Senha,Nm_telefone,Nm_Documento) values (@nome,@endereco,@email,@senha,@telefone,@cpf);";
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@categoria", categoria);
            cmd.Parameters.AddWithValue("@situacao", situacao);

            try
            {
                cmd.Connection = con.conectar();
                //ExecuteNonQuery() usado para quando se tem um insert
                cmd.ExecuteNonQuery();
                con.desconection();
                this.Mensagem = "Cadastrado com sucesso!!!";
                Existe = true;
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com banco de dados";
            }

            return Mensagem;
        }
        public string atualizar(int id, string descricao, string categoria, string situacao)
        {
            Existe = false;

            cmd.CommandText = "update TB_Tarefas set Ds_Tarefa = @descricao ,Ct_CategoriaTarefa = @categoria, St_Tarefa = @situacao where ID_Cliente = @id";

            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@categoria", categoria);
            cmd.Parameters.AddWithValue("@situacao", situacao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = con.conectar();
                //ExecuteNonQuery() usado para quando se tem um insert
                cmd.ExecuteNonQuery();
                con.desconection();
                this.Mensagem = "Dados atualizados com sucesso!!!";
                Existe = true;
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com banco de dados";
            }

            return Mensagem;
        }
        public bool apagar(int id)
        {
            cmd.CommandText = "delete from TB_Tarefas where ID_Cliente = @id";
            
            //comandos SQL se existem no BD 
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = con.conectar();
                //ExecuteReader() usado quando tem retorno tipo select
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Existe = true;
                }
                con.desconection();
                dr.Close();
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com o Banco de dados!!";
            }
            return Existe;
        }
    }
}
