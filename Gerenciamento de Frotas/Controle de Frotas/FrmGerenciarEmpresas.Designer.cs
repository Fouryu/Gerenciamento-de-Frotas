namespace Controle_de_Frotas
{
    partial class FrmGerenciarEmpresas
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
            this.BtnDesativar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.LblRc = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblEmpresa = new System.Windows.Forms.Label();
            this.TxtCNPJ = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtRC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDesativar
            // 
            this.BtnDesativar.Location = new System.Drawing.Point(341, 382);
            this.BtnDesativar.Name = "BtnDesativar";
            this.BtnDesativar.Size = new System.Drawing.Size(135, 23);
            this.BtnDesativar.TabIndex = 29;
            this.BtnDesativar.Text = "Desativar empresa";
            this.BtnDesativar.UseVisualStyleBackColor = true;
            this.BtnDesativar.Click += new System.EventHandler(this.BtnDesativar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(62, 382);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(135, 23);
            this.BtnVoltar.TabIndex = 28;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(597, 382);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(135, 23);
            this.BtnCadastrar.TabIndex = 27;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // LblRc
            // 
            this.LblRc.AutoSize = true;
            this.LblRc.Location = new System.Drawing.Point(299, 240);
            this.LblRc.Name = "LblRc";
            this.LblRc.Size = new System.Drawing.Size(22, 13);
            this.LblRc.TabIndex = 26;
            this.LblRc.Text = "RC";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(541, 141);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 24;
            this.LblEmail.Text = "E-mail";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(299, 141);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(49, 13);
            this.LblTelefone.TabIndex = 22;
            this.LblTelefone.Text = "Telefone";
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.Location = new System.Drawing.Point(32, 141);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(53, 13);
            this.LblEndereco.TabIndex = 20;
            this.LblEndereco.Text = "Endereço";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(299, 46);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 18;
            this.LblNome.Text = "Nome";
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.AutoSize = true;
            this.LblEmpresa.Location = new System.Drawing.Point(32, 46);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(92, 13);
            this.LblEmpresa.TabIndex = 16;
            this.LblEmpresa.Text = "CNPJ da empresa";
            // 
            // TxtCNPJ
            // 
            this.TxtCNPJ.Location = new System.Drawing.Point(35, 62);
            this.TxtCNPJ.Name = "TxtCNPJ";
            this.TxtCNPJ.Size = new System.Drawing.Size(233, 20);
            this.TxtCNPJ.TabIndex = 30;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(302, 62);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(465, 20);
            this.TxtNome.TabIndex = 31;
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(35, 157);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(217, 20);
            this.TxtEndereco.TabIndex = 32;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(302, 157);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(204, 20);
            this.TxtTelefone.TabIndex = 33;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(544, 157);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(223, 20);
            this.TxtEmail.TabIndex = 34;
            // 
            // TxtRC
            // 
            this.TxtRC.Location = new System.Drawing.Point(302, 256);
            this.TxtRC.Name = "TxtRC";
            this.TxtRC.Size = new System.Drawing.Size(204, 20);
            this.TxtRC.TabIndex = 35;
            // 
            // FrmGerenciarEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtRC);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtCNPJ);
            this.Controls.Add(this.BtnDesativar);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.LblRc);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.LblEndereco);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblEmpresa);
            this.Name = "FrmGerenciarEmpresas";
            this.Text = "Gerenciar empresas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDesativar;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label LblRc;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblEmpresa;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox TxtCNPJ;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtRC;
    }
}