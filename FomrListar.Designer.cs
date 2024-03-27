namespace Estaciona
{
    partial class FomrListar
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
            labelFuncionarioID = new Label();
            labelId = new Label();
            buttonPesquisar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Font = new Font("Arial", 12F);
            textBoxEndereco.Location = new Point(205, 337);
            textBoxEndereco.MaxLength = 200;
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(447, 26);
            textBoxEndereco.TabIndex = 5;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelEndereco.Location = new Point(77, 333);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(100, 25);
            labelEndereco.TabIndex = 19;
            labelEndereco.Text = "Endereço:";
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Font = new Font("Arial", 12F);
            textBoxTelefone.Location = new Point(205, 273);
            textBoxTelefone.MaxLength = 20;
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(447, 26);
            textBoxTelefone.TabIndex = 4;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelTelefone.Location = new Point(77, 268);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(92, 25);
            labelTelefone.TabIndex = 18;
            labelTelefone.Text = "Telefone:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Arial", 12F);
            textBoxEmail.Location = new Point(205, 211);
            textBoxEmail.MaxLength = 100;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(447, 26);
            textBoxEmail.TabIndex = 2;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelEmail.Location = new Point(77, 206);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(73, 25);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "E-Mail:";
            // 
            // textBoxCpf
            // 
            textBoxCpf.Font = new Font("Arial", 12F);
            textBoxCpf.Location = new Point(132, 92);
            textBoxCpf.MaxLength = 14;
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(183, 26);
            textBoxCpf.TabIndex = 1;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelCpf.Location = new Point(75, 90);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(51, 25);
            labelCpf.TabIndex = 12;
            labelCpf.Text = "CPF:";
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Arial", 12F);
            textBoxNome.Location = new Point(207, 161);
            textBoxNome.MaxLength = 100;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(447, 26);
            textBoxNome.TabIndex = 2;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblNome.Location = new Point(79, 156);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(71, 25);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome:";
            // 
            // labelFuncionarioID
            // 
            labelFuncionarioID.AutoSize = true;
            labelFuncionarioID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelFuncionarioID.Location = new Point(28, 30);
            labelFuncionarioID.Name = "labelFuncionarioID";
            labelFuncionarioID.Size = new Size(149, 25);
            labelFuncionarioID.TabIndex = 20;
            labelFuncionarioID.Text = "Funcionário ID:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelId.Location = new Point(189, 35);
            labelId.Name = "labelId";
            labelId.Size = new Size(0, 25);
            labelId.TabIndex = 21;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.BackColor = Color.LawnGreen;
            buttonPesquisar.FlatStyle = FlatStyle.Popup;
            buttonPesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPesquisar.Location = new Point(306, 391);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(167, 68);
            buttonPesquisar.TabIndex = 6;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = false;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(572, 35);
            button1.Name = "button1";
            button1.Size = new Size(164, 33);
            button1.TabIndex = 23;
            button1.Text = "Limpar Pesquisa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FomrListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
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
            Name = "FomrListar";
            Text = "Buscar Funcionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonListar;
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
        private Label labelFuncionarioID;
        private Label labelId;
        private Button buttonPesquisar;
        private Button button1;
    }
}