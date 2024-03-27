using Estaciona.Controles;
using System.Drawing.Text;


namespace Estaciona
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonCad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textBoxNome.Text.Equals("") && !textBoxCpf.Text.Equals("") && !textBoxEmail.Text.Equals("") && !textBoxTelefone.Text.Equals("") && !textBoxEndereco.Text.Equals(""))
                {
                    //Instância para criação dos e viculação com as propriedades da classe Funcionario
                    CadFuncionario cadFuncionario = new CadFuncionario();

                    //Passando os valores da tela para o Banco de dados
                    cadFuncionario.Nome = textBoxNome.Text;
                    cadFuncionario.Cpf = textBoxCpf.Text;
                    cadFuncionario.Email = textBoxEmail.Text;
                    cadFuncionario.Tel = textBoxTelefone.Text;
                    cadFuncionario.Endereco = textBoxEndereco.Text;

                    //Validando o cadastro
                    if (cadFuncionario.CadastroDeFuncionario())
                    {
                        MessageBox.Show($"O Funcionario {cadFuncionario.Nome}  foi cadastrado com sucesso!");

                        //Lipando os campos
                        textBoxNome.Clear();
                        textBoxCpf.Clear();
                        textBoxEmail.Clear();
                        textBoxTelefone.Clear();
                        textBoxEndereco.Clear();

                        //Depois de Limpo, deixar o foco no campo Nome com o cursor
                        textBoxNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"Não foi possivel cadastrar o funcionario {cadFuncionario.Nome}!");
                    }

                }
                else
                {
                    MessageBox.Show($"Preencha todos os campos!");

                    //Lipando os campos
                    textBoxNome.Clear();
                    textBoxCpf.Clear();
                    textBoxEmail.Clear();
                    textBoxTelefone.Clear();
                    textBoxEndereco.Clear();

                    //Depois de Limpo, deixar o foco no campo Nome com o cursor
                    textBoxNome.Focus();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao cadastrar o funcionario{ex.Message}");
            }
        }
    }

}


