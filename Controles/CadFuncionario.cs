using Estaciona.Bd;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaciona.Controles
{
    internal class CadFuncionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Endereco { get; set; }

        //instancia da minha conecxão para o banco de dados
        MySqlConnection MyConect = new MySqlConnection(ConecxaoBd.conectaBD);

        public bool CadastroDeFuncionario()
        {
            try
            {
                //Abrindo a Conecxão do banco 
                MyConect.Open();

                //Comando SQL para inserção dos dados no Banco
                string insert = $"insert into funcionarios (nome,cpf, email, tel, edereco) value ('{Nome}', '{Cpf}', '{Email}', '{Tel}', '{Endereco}')";

                //Criando a variavel de comando, para que o comando Insert seja valido e entendido pelo MYSQL
                MySqlCommand comandoSql = MyConect.CreateCommand();
                comandoSql.CommandText = insert; //Isso faz o reconhecimento do Comando SQL

                //Executando o comando
                comandoSql.ExecuteNonQuery();

                //Resultado SE Positivo
                return true;
            }
            catch (Exception ex)
            {
                //Mensagem com o erro ao cadastrar o funcionario
                MessageBox.Show($"{ex.Message}");
                return false;
            }
        }


        public MySqlDataReader BuscaFuncionario()
        {
            try
            {
                //Abrindo a conexão com o banco de dados
                MyConect.Open();

                string select = $"select id, nome,cpf, email, tel, edereco From  funcionarios where cpf ='{Cpf}';";

                //Criando ação para o comando SQL
                MySqlCommand comandoSql = MyConect.CreateCommand();
                comandoSql.CommandText = select;


                //Ação apra leitura de apenas um e Exclusivo dado no meu SLQ
                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader; //Retona apenas o meu CPF, enviado no Comando SQL

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro no banco de dados: {ex.Message}");
                return null;
            }
        }


        public bool EditarFuncionario()
        {
            try
            {
                //Abrindo a Conecxão do banco 
                MyConect.Open();

                //Comando SQL para Atualizar dos dados no Banco
                string update = $"Update funcionarios set nome ='{Nome}',cpf='{Cpf }', email='{Email}', tel='{Tel}', edereco ='{Endereco}' Where id ='{Id}' ";

                //Criando a variavel de comando, para que o comando Insert seja valido e entendido pelo MYSQL
                MySqlCommand comandoSql = MyConect.CreateCommand();
                comandoSql.CommandText = update; //Isso faz o reconhecimento do Comando SQL

                //Executando o comando
                comandoSql.ExecuteNonQuery();

                //Resultado SE Positivo
                return true;
            }
            catch (Exception ex)
            {
                //Mensagem com o erro ao cadastrar o funcionario
                MessageBox.Show($"Erro no Banco de dados: {ex.Message}");
                return false;
            }
        }


        public bool DeletarFuncionario()
        {
            try
            {
                //Abrindo a Conecxão do banco 
                MyConect.Open();

                //Comando SQL para Deletar dos dados no Banco
                string delete = $"Delete From funcionarios Where id ='{Id}';";

                //Criando a variavel de comando, para que o comando Insert seja valido e entendido pelo MYSQL
                MySqlCommand comandoSql = MyConect.CreateCommand();
                comandoSql.CommandText = delete; //Isso faz o reconhecimento do Comando SQL

                //Executando o comando
                comandoSql.ExecuteNonQuery();

                //Resultado SE Positivo
                return true;
            }
            catch (Exception ex)
            {
                //Mensagem com o erro ao cadastrar o funcionario
                MessageBox.Show($"Erro no Banco de dados: {ex.Message}");
                return false;
            }
        }
    }
}
