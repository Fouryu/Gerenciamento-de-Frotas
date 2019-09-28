namespace Controle_de_Frotas
{
    partial class FrmGerenciarSaidaDoVeiculo
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
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.LblIdMecanico = new System.Windows.Forms.Label();
            this.LblIdMotorista = new System.Windows.Forms.Label();
            this.LblPlaca = new System.Windows.Forms.Label();
            this.LblSaida = new System.Windows.Forms.Label();
            this.TxtIdMecanico = new System.Windows.Forms.TextBox();
            this.TxtIdMotorista = new System.Windows.Forms.TextBox();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.TxtSaida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(661, 369);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(105, 26);
            this.BtnSalvar.TabIndex = 29;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(28, 369);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(105, 26);
            this.BtnVoltar.TabIndex = 28;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // LblIdMecanico
            // 
            this.LblIdMecanico.AutoSize = true;
            this.LblIdMecanico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdMecanico.Location = new System.Drawing.Point(268, 243);
            this.LblIdMecanico.Name = "LblIdMecanico";
            this.LblIdMecanico.Size = new System.Drawing.Size(86, 16);
            this.LblIdMecanico.TabIndex = 27;
            this.LblIdMecanico.Text = "ID Mecanico:";
            // 
            // LblIdMotorista
            // 
            this.LblIdMotorista.AutoSize = true;
            this.LblIdMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdMotorista.Location = new System.Drawing.Point(272, 194);
            this.LblIdMotorista.Name = "LblIdMotorista";
            this.LblIdMotorista.Size = new System.Drawing.Size(82, 16);
            this.LblIdMotorista.TabIndex = 26;
            this.LblIdMotorista.Text = "ID Motorista:";
            // 
            // LblPlaca
            // 
            this.LblPlaca.AutoSize = true;
            this.LblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlaca.Location = new System.Drawing.Point(308, 146);
            this.LblPlaca.Name = "LblPlaca";
            this.LblPlaca.Size = new System.Drawing.Size(46, 16);
            this.LblPlaca.TabIndex = 25;
            this.LblPlaca.Text = "Placa:";
            // 
            // LblSaida
            // 
            this.LblSaida.AutoSize = true;
            this.LblSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaida.Location = new System.Drawing.Point(240, 90);
            this.LblSaida.Name = "LblSaida";
            this.LblSaida.Size = new System.Drawing.Size(114, 16);
            this.LblSaida.TabIndex = 24;
            this.LblSaida.Text = "Horário de Saída:";
            // 
            // TxtIdMecanico
            // 
            this.TxtIdMecanico.Location = new System.Drawing.Point(356, 243);
            this.TxtIdMecanico.Name = "TxtIdMecanico";
            this.TxtIdMecanico.Size = new System.Drawing.Size(160, 20);
            this.TxtIdMecanico.TabIndex = 23;
            // 
            // TxtIdMotorista
            // 
            this.TxtIdMotorista.Location = new System.Drawing.Point(356, 193);
            this.TxtIdMotorista.Name = "TxtIdMotorista";
            this.TxtIdMotorista.Size = new System.Drawing.Size(160, 20);
            this.TxtIdMotorista.TabIndex = 22;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(356, 146);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(160, 20);
            this.TxtPlaca.TabIndex = 21;
            // 
            // TxtSaida
            // 
            this.TxtSaida.Location = new System.Drawing.Point(356, 89);
            this.TxtSaida.Name = "TxtSaida";
            this.TxtSaida.Size = new System.Drawing.Size(160, 20);
            this.TxtSaida.TabIndex = 20;
            // 
            // FrmGerenciarSaidaDoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.LblIdMecanico);
            this.Controls.Add(this.LblIdMotorista);
            this.Controls.Add(this.LblPlaca);
            this.Controls.Add(this.LblSaida);
            this.Controls.Add(this.TxtIdMecanico);
            this.Controls.Add(this.TxtIdMotorista);
            this.Controls.Add(this.TxtPlaca);
            this.Controls.Add(this.TxtSaida);
            this.Name = "FrmGerenciarSaidaDoVeiculo";
            this.Text = "Gerenciar saida do veiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label LblIdMecanico;
        private System.Windows.Forms.Label LblIdMotorista;
        private System.Windows.Forms.Label LblPlaca;
        private System.Windows.Forms.Label LblSaida;
        private System.Windows.Forms.TextBox TxtIdMecanico;
        private System.Windows.Forms.TextBox TxtIdMotorista;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.TextBox TxtSaida;
        private System.Windows.Forms.Button BtnVoltar;
    }
}