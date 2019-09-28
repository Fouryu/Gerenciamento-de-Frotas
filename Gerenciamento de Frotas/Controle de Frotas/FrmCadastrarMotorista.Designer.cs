namespace Controle_de_Frotas
{
    partial class FrmCadastrarMotorista
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
            this.LblValidadeCnh = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.LblRegiao = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblCnh = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblCelular = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.LblRg = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtRg = new System.Windows.Forms.TextBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtDataNascimento = new System.Windows.Forms.TextBox();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.TxtCnh = new System.Windows.Forms.TextBox();
            this.TxtValidadeCnh = new System.Windows.Forms.TextBox();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.CboRegiao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblValidadeCnh
            // 
            this.LblValidadeCnh.AutoSize = true;
            this.LblValidadeCnh.Location = new System.Drawing.Point(338, 273);
            this.LblValidadeCnh.Name = "LblValidadeCnh";
            this.LblValidadeCnh.Size = new System.Drawing.Size(89, 13);
            this.LblValidadeCnh.TabIndex = 68;
            this.LblValidadeCnh.Text = "Validade da CNH";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(127, 427);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 26);
            this.BtnCancelar.TabIndex = 66;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(578, 427);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(105, 26);
            this.BtnCadastrar.TabIndex = 65;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // LblRegiao
            // 
            this.LblRegiao.AutoSize = true;
            this.LblRegiao.Location = new System.Drawing.Point(52, 335);
            this.LblRegiao.Name = "LblRegiao";
            this.LblRegiao.Size = new System.Drawing.Size(41, 13);
            this.LblRegiao.TabIndex = 64;
            this.LblRegiao.Text = "Região";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(539, 273);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(52, 13);
            this.LblCategoria.TabIndex = 62;
            this.LblCategoria.Text = "Categoria";
            // 
            // LblCnh
            // 
            this.LblCnh.AutoSize = true;
            this.LblCnh.Location = new System.Drawing.Point(55, 273);
            this.LblCnh.Name = "LblCnh";
            this.LblCnh.Size = new System.Drawing.Size(34, 13);
            this.LblCnh.TabIndex = 60;
            this.LblCnh.Text = "*CNH";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(338, 165);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(31, 13);
            this.LblSexo.TabIndex = 57;
            this.LblSexo.Text = "Sexo";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(338, 221);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(49, 13);
            this.LblTelefone.TabIndex = 56;
            this.LblTelefone.Text = "Telefone";
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Location = new System.Drawing.Point(539, 218);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(39, 13);
            this.LblCelular.TabIndex = 54;
            this.LblCelular.Text = "Celular";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(55, 221);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(42, 13);
            this.LblEmail.TabIndex = 52;
            this.LblEmail.Text = "* E-mail";
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Location = new System.Drawing.Point(55, 165);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(109, 13);
            this.LblDataNascimento.TabIndex = 50;
            this.LblDataNascimento.Text = "* Data de nascimento";
            // 
            // LblRg
            // 
            this.LblRg.AutoSize = true;
            this.LblRg.Location = new System.Drawing.Point(52, 107);
            this.LblRg.Name = "LblRg";
            this.LblRg.Size = new System.Drawing.Size(30, 13);
            this.LblRg.TabIndex = 48;
            this.LblRg.Text = "* RG";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Location = new System.Drawing.Point(335, 107);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(34, 13);
            this.LblCpf.TabIndex = 46;
            this.LblCpf.Text = "* CPF";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(52, 54);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(88, 13);
            this.LblNome.TabIndex = 44;
            this.LblNome.Text = "* Nome completo";
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.Location = new System.Drawing.Point(310, 9);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(224, 31);
            this.LblCadastro.TabIndex = 43;
            this.LblCadastro.Text = "Cadastro Motorista";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(55, 70);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(523, 20);
            this.TxtNome.TabIndex = 69;
            // 
            // TxtRg
            // 
            this.TxtRg.Location = new System.Drawing.Point(55, 123);
            this.TxtRg.Name = "TxtRg";
            this.TxtRg.Size = new System.Drawing.Size(214, 20);
            this.TxtRg.TabIndex = 70;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(338, 123);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(240, 20);
            this.TxtCpf.TabIndex = 71;
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.Location = new System.Drawing.Point(55, 181);
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.Size = new System.Drawing.Size(157, 20);
            this.TxtDataNascimento.TabIndex = 72;
            this.TxtDataNascimento.Text = "__/__/____";
            this.TxtDataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CboSexo
            // 
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.CboSexo.Location = new System.Drawing.Point(341, 181);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(100, 21);
            this.CboSexo.TabIndex = 73;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(55, 237);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(253, 20);
            this.TxtEmail.TabIndex = 74;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(341, 237);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(160, 20);
            this.TxtTelefone.TabIndex = 75;
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(542, 237);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(177, 20);
            this.TxtCelular.TabIndex = 76;
            // 
            // TxtCnh
            // 
            this.TxtCnh.Location = new System.Drawing.Point(55, 289);
            this.TxtCnh.Name = "TxtCnh";
            this.TxtCnh.Size = new System.Drawing.Size(186, 20);
            this.TxtCnh.TabIndex = 77;
            // 
            // TxtValidadeCnh
            // 
            this.TxtValidadeCnh.Location = new System.Drawing.Point(341, 289);
            this.TxtValidadeCnh.Name = "TxtValidadeCnh";
            this.TxtValidadeCnh.Size = new System.Drawing.Size(157, 20);
            this.TxtValidadeCnh.TabIndex = 78;
            this.TxtValidadeCnh.Text = "__/__/____";
            this.TxtValidadeCnh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(542, 289);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(83, 20);
            this.TxtCategoria.TabIndex = 79;
            // 
            // CboRegiao
            // 
            this.CboRegiao.FormattingEnabled = true;
            this.CboRegiao.Items.AddRange(new object[] {
            "Norte",
            "Sul",
            "Leste",
            "Oeste",
            "Nordeste",
            "Noroeste",
            "Sudeste",
            "Sudoeste",
            "Centro-Oeste"});
            this.CboRegiao.Location = new System.Drawing.Point(55, 351);
            this.CboRegiao.Name = "CboRegiao";
            this.CboRegiao.Size = new System.Drawing.Size(186, 21);
            this.CboRegiao.TabIndex = 80;
            // 
            // FrmCadastrarMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.CboRegiao);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.TxtValidadeCnh);
            this.Controls.Add(this.TxtCnh);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.CboSexo);
            this.Controls.Add(this.TxtDataNascimento);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.TxtRg);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblValidadeCnh);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.LblRegiao);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblCnh);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.LblCelular);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblDataNascimento);
            this.Controls.Add(this.LblRg);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblCadastro);
            this.Name = "FrmCadastrarMotorista";
            this.Text = "Cadastrar motorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblValidadeCnh;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Label LblRegiao;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblCnh;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblDataNascimento;
        private System.Windows.Forms.Label LblRg;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtRg;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtDataNascimento;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.TextBox TxtCnh;
        private System.Windows.Forms.TextBox TxtValidadeCnh;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.ComboBox CboRegiao;
    }
}