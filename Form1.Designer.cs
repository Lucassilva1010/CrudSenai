namespace Estaciona
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            textBoxNome = new TextBox();
            textBoxCpf = new TextBox();
            labelCpf = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxTelefone = new TextBox();
            labelTelefone = new Label();
            textBoxEndereco = new TextBox();
            labelEndereco = new Label();
            buttonCad = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblNome.Location = new Point(48, 71);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(71, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Arial", 12F);
            textBoxNome.Location = new Point(176, 76);
            textBoxNome.MaxLength = 100;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(447, 26);
            textBoxNome.TabIndex = 1;
            // 
            // textBoxCpf
            // 
            textBoxCpf.Font = new Font("Arial", 12F);
            textBoxCpf.Location = new Point(176, 136);
            textBoxCpf.MaxLength = 14;
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(447, 26);
            textBoxCpf.TabIndex = 2;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelCpf.Location = new Point(48, 131);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(51, 25);
            labelCpf.TabIndex = 2;
            labelCpf.Text = "CPF:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Arial", 12F);
            textBoxEmail.Location = new Point(176, 198);
            textBoxEmail.MaxLength = 100;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(447, 26);
            textBoxEmail.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelEmail.Location = new Point(48, 193);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(73, 25);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "E-Mail:";
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Font = new Font("Arial", 12F);
            textBoxTelefone.Location = new Point(176, 260);
            textBoxTelefone.MaxLength = 20;
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(447, 26);
            textBoxTelefone.TabIndex = 4;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelTelefone.Location = new Point(48, 255);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(92, 25);
            labelTelefone.TabIndex = 6;
            labelTelefone.Text = "Telefone:";
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Font = new Font("Arial", 12F);
            textBoxEndereco.Location = new Point(176, 324);
            textBoxEndereco.MaxLength = 200;
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(447, 26);
            textBoxEndereco.TabIndex = 5;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelEndereco.Location = new Point(48, 320);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(100, 25);
            labelEndereco.TabIndex = 8;
            labelEndereco.Text = "Endereço:";
            // 
            // buttonCad
            // 
            buttonCad.BackColor = Color.Aqua;
            buttonCad.FlatStyle = FlatStyle.Popup;
            buttonCad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCad.ForeColor = Color.Black;
            buttonCad.Location = new Point(73, 393);
            buttonCad.Name = "buttonCad";
            buttonCad.Size = new Size(142, 59);
            buttonCad.TabIndex = 6;
            buttonCad.Text = "Cadastrar";
            buttonCad.UseVisualStyleBackColor = false;
            buttonCad.Click += buttonCad_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 479);
            Controls.Add(buttonCad);
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
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormPrincipal";
            Text = "Cadastro de Funcionarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox textBoxNome;
        private TextBox textBoxCpf;
        private Label labelCpf;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxTelefone;
        private Label labelTelefone;
        private TextBox textBoxEndereco;
        private Label labelEndereco;
        private Button buttonCad;
    }
}
