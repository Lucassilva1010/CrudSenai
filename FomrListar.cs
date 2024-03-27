using Estaciona.Controles;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;
using System.Drawing.Text;


namespace Estaciona
{
    public partial class FomrListar : Form
    {
        public FomrListar()
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

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

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
    }
}
