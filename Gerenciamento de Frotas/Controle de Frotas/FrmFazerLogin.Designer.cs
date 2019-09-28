namespace Controle_de_Frotas
{
    partial class FrmFazerLogin
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
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.BtnEsqueciSenha = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnEsqueciLogin = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.LblEmpresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(118, 205);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(235, 20);
            this.TxtSenha.TabIndex = 19;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(118, 153);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(235, 20);
            this.TxtUsuario.TabIndex = 18;
            // 
            // BtnEsqueciSenha
            // 
            this.BtnEsqueciSenha.Location = new System.Drawing.Point(275, 296);
            this.BtnEsqueciSenha.Name = "BtnEsqueciSenha";
            this.BtnEsqueciSenha.Size = new System.Drawing.Size(128, 23);
            this.BtnEsqueciSenha.TabIndex = 17;
            this.BtnEsqueciSenha.Text = "Esqueci minha senha";
            this.BtnEsqueciSenha.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(176, 296);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 16;
            this.BtnLogin.Text = "Fazer login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // BtnEsqueciLogin
            // 
            this.BtnEsqueciLogin.Location = new System.Drawing.Point(28, 296);
            this.BtnEsqueciLogin.Name = "BtnEsqueciLogin";
            this.BtnEsqueciLogin.Size = new System.Drawing.Size(115, 23);
            this.BtnEsqueciLogin.TabIndex = 15;
            this.BtnEsqueciLogin.Text = "Esqueci meu login";
            this.BtnEsqueciLogin.UseVisualStyleBackColor = true;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(69, 153);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(43, 13);
            this.LblUsuario.TabIndex = 13;
            this.LblUsuario.Text = "Usuário";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Location = new System.Drawing.Point(74, 205);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(38, 13);
            this.LblSenha.TabIndex = 12;
            this.LblSenha.Text = "Senha";
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.AutoSize = true;
            this.LblEmpresa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpresa.Location = new System.Drawing.Point(26, 78);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(377, 27);
            this.LblEmpresa.TabIndex = 11;
            this.LblEmpresa.Text = "Bem vindo a empresa JohnsonControl";
            // 
            // FrmFazerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 396);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.BtnEsqueciSenha);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnEsqueciLogin);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblEmpresa);
            this.Name = "FrmFazerLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Button BtnEsqueciSenha;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnEsqueciLogin;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.Label LblEmpresa;
    }
}