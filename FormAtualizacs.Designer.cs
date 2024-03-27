namespace Estaciona
{
    partial class FormAtualizacs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            labelFuncionarioID = new Label();
            buttonPesquisar = new Button();
            labelId = new Label();
            textBoxEndereco = new TextBox();
            labelEndereco = new Label();
            textBoxTelefone = new TextBox();
            labelTelefone = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxCpf = new TextBox();
            labelCpf = new Label();
            textBoxNome = new TextBox();
            lblNome = new Label();
            buttonEditar = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(590, 16);
            button1.Name = "button1";
            button1.Size = new Size(164, 33);
            button1.TabIndex = 37;
            button1.Text = "Limpar Pesquisa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelFuncionarioID
            // 
            labelFuncionarioID.AutoSize = true;
            labelFuncionarioID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelFuncionarioID.Location = new Point(46, 11);
            labelFuncionarioID.Name = "labelFuncionarioID";
            labelFuncionarioID.Size = new Size(149, 25);
            labelFuncionarioID.TabIndex = 35;
            labelFuncionarioID.Text = "Funcionário ID:";
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.BackColor = Color.LawnGreen;
            buttonPesquisar.FlatStyle = FlatStyle.Popup;
            buttonPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPesquisar.Location = new Point(356, 69);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(114, 37);
            buttonPesquisar.TabIndex = 29;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = false;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelId.Location = new Point(207, 16);
            labelId.Name = "labelId";
            labelId.Size = new Size(0, 25);
            labelId.TabIndex = 36;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Font = new Font("Arial", 12F);
            textBoxEndereco.Location = new Point(223, 318);
            textBoxEndereco.MaxLength = 200;
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(447, 26);
            textBoxEndereco.TabIndex = 28;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelEndereco.Location = new Point(95, 314);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(100, 25);
            labelEndereco.TabIndex = 34;
            labelEndereco.Text = "Endereço:";
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Font = new Font("Arial", 12F);
            textBoxTelefone.Location = new Point(223, 254);
            textBoxTelefone.MaxLength = 20;
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(447, 26);
            textBoxTelefone.TabIndex = 27;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelTelefone.Location = new Point(95, 249);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(92, 25);
            labelTelefone.TabIndex = 33;
            labelTelefone.Text = "Telefone:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Arial", 12F);
            textBoxEmail.Location = new Point(223, 192);
            textBoxEmail.MaxLength = 100;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(447, 26);
            textBoxEmail.TabIndex = 25;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelEmail.Location = new Point(95, 187);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(73, 25);
            labelEmail.TabIndex = 32;
            labelEmail.Text = "E-Mail:";
            // 
            // textBoxCpf
            // 
            textBoxCpf.Font = new Font("Arial", 12F);
            textBoxCpf.Location = new Point(150, 73);
            textBoxCpf.MaxLength = 14;
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(183, 26);
            textBoxCpf.TabIndex = 24;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelCpf.Location = new Point(93, 71);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(51, 25);
            labelCpf.TabIndex = 31;
            labelCpf.Text = "CPF:";
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Arial", 12F);
            textBoxNome.Location = new Point(225, 142);
            textBoxNome.MaxLength = 100;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(447, 26);
            textBoxNome.TabIndex = 26;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblNome.Location = new Point(97, 137);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(71, 25);
            lblNome.TabIndex = 30;
            lblNome.Text = "Nome:";
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.Orange;
            buttonEditar.FlatStyle = FlatStyle.Popup;
            buttonEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditar.Location = new Point(374, 370);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(167, 68);
            buttonEditar.TabIndex = 38;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // FormAtualizacs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEditar);
            Controls.Add(button1);
            Controls.Add(labelFuncionarioID);
            Controls.Add(buttonPesquisar);
            Controls.Add(labelId);
            Controls.Add(textBoxEndereco);
            Controls.Add(labelEndereco);
            Controls.Add(textBoxTelefone);
            Controls.Add(labelTelefone);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxCpf);
            Controls.Add(labelCpf);
            Controls.Add(textBoxNome);
            Controls.Add(lblNome);
            Name = "FormAtualizacs";
            Text = "Editar Funcionário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label labelFuncionarioID;
        private Button buttonPesquisar;
        private Label labelId;
        private TextBox textBoxEndereco;
        private Label labelEndereco;
        private TextBox textBoxTelefone;
        private Label labelTelefone;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxCpf;
        private Label labelCpf;
        private TextBox textBoxNome;
        private Label lblNome;
        private Button buttonEditar;
    }
}