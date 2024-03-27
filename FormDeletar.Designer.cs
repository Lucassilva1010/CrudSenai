namespace Estaciona
{
    partial class FormDeletar
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
            buttonEditar = new Button();
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
            SuspendLayout();
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.Red;
            buttonEditar.FlatStyle = FlatStyle.Popup;
            buttonEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(374, 371);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(167, 68);
            buttonEditar.TabIndex = 53;
            buttonEditar.Text = "Deletar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(590, 17);
            button1.Name = "button1";
            button1.Size = new Size(164, 33);
            button1.TabIndex = 52;
            button1.Text = "Limpar Pesquisa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelFuncionarioID
            // 
            labelFuncionarioID.AutoSize = true;
            labelFuncionarioID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelFuncionarioID.Location = new Point(46, 12);
            labelFuncionarioID.Name = "labelFuncionarioID";
            labelFuncionarioID.Size = new Size(149, 25);
            labelFuncionarioID.TabIndex = 50;
            labelFuncionarioID.Text = "Funcionário ID:";
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.BackColor = Color.LawnGreen;
            buttonPesquisar.FlatStyle = FlatStyle.Popup;
            buttonPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPesquisar.Location = new Point(356, 70);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(114, 37);
            buttonPesquisar.TabIndex = 44;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = false;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelId.Location = new Point(207, 17);
            labelId.Name = "labelId";
            labelId.Size = new Size(0, 25);
            labelId.TabIndex = 51;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Font = new Font("Arial", 12F);
            textBoxEndereco.Location = new Point(223, 319);
            textBoxEndereco.MaxLength = 200;
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(447, 26);
            textBoxEndereco.TabIndex = 43;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelEndereco.Location = new Point(95, 315);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(100, 25);
            labelEndereco.TabIndex = 49;
            labelEndereco.Text = "Endereço:";
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Font = new Font("Arial", 12F);
            textBoxTelefone.Location = new Point(223, 255);
            textBoxTelefone.MaxLength = 20;
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(447, 26);
            textBoxTelefone.TabIndex = 42;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelTelefone.Location = new Point(95, 250);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(92, 25);
            labelTelefone.TabIndex = 48;
            labelTelefone.Text = "Telefone:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Arial", 12F);
            textBoxEmail.Location = new Point(223, 193);
            textBoxEmail.MaxLength = 100;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(447, 26);
            textBoxEmail.TabIndex = 40;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelEmail.Location = new Point(95, 188);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(73, 25);
            labelEmail.TabIndex = 47;
            labelEmail.Text = "E-Mail:";
            // 
            // textBoxCpf
            // 
            textBoxCpf.Font = new Font("Arial", 12F);
            textBoxCpf.Location = new Point(150, 74);
            textBoxCpf.MaxLength = 14;
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(183, 26);
            textBoxCpf.TabIndex = 39;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelCpf.Location = new Point(93, 72);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(51, 25);
            labelCpf.TabIndex = 46;
            labelCpf.Text = "CPF:";
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Arial", 12F);
            textBoxNome.Location = new Point(225, 143);
            textBoxNome.MaxLength = 100;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(447, 26);
            textBoxNome.TabIndex = 41;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblNome.Location = new Point(97, 138);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(71, 25);
            lblNome.TabIndex = 45;
            lblNome.Text = "Nome:";
            // 
            // FormDeletar
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
            Name = "FormDeletar";
            Text = "Deletar Funcionário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEditar;
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
    }
}