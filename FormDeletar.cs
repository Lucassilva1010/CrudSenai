using Estaciona.Controles;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estaciona
{
    public partial class FormDeletar : Form
    {
        public FormDeletar()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            CadFuncionario cadFuncionario = new CadFuncionario();
            try
            {
                //Verifica se os campos foram preenchidos
                if (!textBoxCpf.Text.Equals(""))
                {
                    //Pegando os campos digitados
                    cadFuncionario.Cpf = textBoxCpf.Text;

                    //Buscando o metodo que busca apenas o unico dado
                    MySqlDataReader reader = cadFuncionario.BuscaFuncionario();

                    //Verificando de o resultado está nulo
                    if (reader != null)
                    {
                        //Verificando se ele encontrou algum dado ou alguma linha preenchida
                        if (reader.HasRows)
                        {
                            reader.Read();//Ler todos os dados que ele encontrou


                            //Mostando os dados na tela
                            labelId.Text = reader["id"].ToString();
                            textBoxNome.Text = reader["nome"].ToString();
                            textBoxEmail.Text = reader["email"].ToString();
                            textBoxTelefone.Text = reader["tel"].ToString();
                            textBoxEndereco.Text = reader["edereco"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado!");
                            //Limpando os campos digitados
                            textBoxNome.Clear();
                            textBoxCpf.Clear();
                            textBoxEmail.Clear();
                            textBoxTelefone.Clear();
                            textBoxEndereco.Clear();
                            labelId.Text = "";
                            //Colocar o cursor no campo CPF para ser preenchido
                            textBoxCpf.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado!");
                        //Limpando os campos digitados
                        textBoxNome.Clear();
                        textBoxCpf.Clear();
                        textBoxEmail.Clear();
                        textBoxTelefone.Clear();
                        textBoxEndereco.Clear();
                        labelId.Text = "";
                        //Colocar o cursor no campo CPF para ser preenchido
                        textBoxCpf.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Preeencha o campo CPF para pesquisar o funcionário!");

                    //Limpando os campos digitados
                    textBoxNome.Clear();
                    textBoxCpf.Clear();
                    textBoxEmail.Clear();
                    textBoxTelefone.Clear();
                    textBoxEndereco.Clear();
                    labelId.Text = "";
                    //Colocar o cursor no campo CPF para ser preenchido
                    textBoxCpf.Focus();


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao encontrar o Funcionario: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpando os campos digitados
            textBoxNome.Clear();
            textBoxCpf.Clear();
            textBoxEmail.Clear();
            textBoxTelefone.Clear();
            textBoxEndereco.Clear();
            labelId.Text = "";
            //Colocar o cursor no campo CPF para ser preenchido
            textBoxCpf.Focus();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            CadFuncionario cadFuncionario = new CadFuncionario();
            try
            {
                if (!textBoxCpf.Text.Equals("") && !textBoxEmail.Text.Equals("") && !textBoxNome.Text.Equals("") && !textBoxTelefone.Text.Equals("") && !textBoxEndereco.Text.Equals(""))
                {

                    cadFuncionario.Id = int.Parse(labelId.Text);
                  
                    if (cadFuncionario.DeletarFuncionario())
                    {
                        MessageBox.Show($"Os dados do Funcionário {cadFuncionario.Nome}, foram Deletados com sucesso!");
                        //Limpando os campos digitados
                        textBoxNome.Clear();
                        textBoxCpf.Clear();
                        textBoxEmail.Clear();
                        textBoxTelefone.Clear();
                        textBoxEndereco.Clear();
                        labelId.Text = "";
                        //Colocar o cursor no campo CPF para ser preenchido
                        textBoxCpf.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"Não foi possivel deletar o cadastro do Funcionário {cadFuncionario.Nome}!");

                        //Limpando os campos digitados
                        textBoxNome.Clear();
                        textBoxCpf.Clear();
                        textBoxEmail.Clear();
                        textBoxTelefone.Clear();
                        textBoxEndereco.Clear();
                        labelId.Text = "";
                        //Colocar o cursor no campo CPF para ser preenchido
                        textBoxCpf.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Digite o CPF do Funcionário que deseja Deletar!");

                    //Limpando os campos digitados
                    textBoxNome.Clear();
                    textBoxCpf.Clear();
                    textBoxEmail.Clear();
                    textBoxTelefone.Clear();
                    textBoxEndereco.Clear();
                    labelId.Text = "";
                    //Colocar o cursor no campo CPF para ser preenchido
                    textBoxCpf.Focus();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao Editar o Funcionario: {ex.Message}");
            }

        }
    }
}
