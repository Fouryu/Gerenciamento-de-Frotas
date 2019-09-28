namespace Controle_de_Frotas
{
    partial class FrmManutencao
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
            this.TxtDataEntrada = new System.Windows.Forms.TextBox();
            this.TxtDataSaida = new System.Windows.Forms.TextBox();
            this.LblDataSaida = new System.Windows.Forms.Label();
            this.LblDataEntrada = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.LblIdMecanico = new System.Windows.Forms.Label();
            this.LblPecas = new System.Windows.Forms.Label();
            this.LblIdMotorista = new System.Windows.Forms.Label();
            this.LblPlaca = new System.Windows.Forms.Label();
            this.TxtPecas = new System.Windows.Forms.TextBox();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.TxtIdMecanico = new System.Windows.Forms.TextBox();
            this.TxtMotorista = new System.Windows.Forms.TextBox();
            this.LblManutencao = new System.Windows.Forms.Label();
            this.CboManutencao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TxtDataEntrada
            // 
            this.TxtDataEntrada.Location = new System.Drawing.Point(531, 22);
            this.TxtDataEntrada.Name = "TxtDataEntrada";
            this.TxtDataEntrada.Size = new System.Drawing.Size(100, 20);
            this.TxtDataEntrada.TabIndex = 47;
            // 
            // TxtDataSaida
            // 
            this.TxtDataSaida.Location = new System.Drawing.Point(531, 82);
            this.TxtDataSaida.Name = "TxtDataSaida";
            this.TxtDataSaida.Size = new System.Drawing.Size(100, 20);
            this.TxtDataSaida.TabIndex = 46;
            // 
            // LblDataSaida
            // 
            this.LblDataSaida.AutoSize = true;
            this.LblDataSaida.Location = new System.Drawing.Point(460, 85);
            this.LblDataSaida.Name = "LblDataSaida";
            this.LblDataSaida.Size = new System.Drawing.Size(65, 13);
            this.LblDataSaida.TabIndex = 45;
            this.LblDataSaida.Text = "Data Saída:";
            // 
            // LblDataEntrada
            // 
            this.LblDataEntrada.AutoSize = true;
            this.LblDataEntrada.Location = new System.Drawing.Point(452, 25);
            this.LblDataEntrada.Name = "LblDataEntrada";
            this.LblDataEntrada.Size = new System.Drawing.Size(73, 13);
            this.LblDataEntrada.TabIndex = 44;
            this.LblDataEntrada.Text = "Data Entrada:";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(610, 391);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(105, 26);
            this.BtnSalvar.TabIndex = 43;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(99, 391);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(105, 26);
            this.BtnVoltar.TabIndex = 42;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // LblIdMecanico
            // 
            this.LblIdMecanico.AutoSize = true;
            this.LblIdMecanico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdMecanico.Location = new System.Drawing.Point(21, 88);
            this.LblIdMecanico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdMecanico.Name = "LblIdMecanico";
            this.LblIdMecanico.Size = new System.Drawing.Size(86, 16);
            this.LblIdMecanico.TabIndex = 41;
            this.LblIdMecanico.Text = "ID Mecanico:";
            // 
            // LblPecas
            // 
            this.LblPecas.AutoSize = true;
            this.LblPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPecas.Location = new System.Drawing.Point(13, 224);
            this.LblPecas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPecas.Name = "LblPecas";
            this.LblPecas.Size = new System.Drawing.Size(106, 16);
            this.LblPecas.TabIndex = 40;
            this.LblPecas.Text = "Peças trocadas:";
            // 
            // LblIdMotorista
            // 
            this.LblIdMotorista.AutoSize = true;
            this.LblIdMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdMotorista.Location = new System.Drawing.Point(20, 155);
            this.LblIdMotorista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdMotorista.Name = "LblIdMotorista";
            this.LblIdMotorista.Size = new System.Drawing.Size(82, 16);
            this.LblIdMotorista.TabIndex = 39;
            this.LblIdMotorista.Text = "ID Motorista:";
            // 
            // LblPlaca
            // 
            this.LblPlaca.AutoSize = true;
            this.LblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlaca.Location = new System.Drawing.Point(61, 19);
            this.LblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPlaca.Name = "LblPlaca";
            this.LblPlaca.Size = new System.Drawing.Size(46, 16);
            this.LblPlaca.TabIndex = 38;
            this.LblPlaca.Text = "Placa:";
            // 
            // TxtPecas
            // 
            this.TxtPecas.Location = new System.Drawing.Point(127, 223);
            this.TxtPecas.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPecas.Multiline = true;
            this.TxtPecas.Name = "TxtPecas";
            this.TxtPecas.Size = new System.Drawing.Size(257, 69);
            this.TxtPecas.TabIndex = 37;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(110, 22);
            this.TxtPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(168, 20);
            this.TxtPlaca.TabIndex = 36;
            // 
            // TxtIdMecanico
            // 
            this.TxtIdMecanico.Location = new System.Drawing.Point(110, 87);
            this.TxtIdMecanico.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdMecanico.Name = "TxtIdMecanico";
            this.TxtIdMecanico.Size = new System.Drawing.Size(168, 20);
            this.TxtIdMecanico.TabIndex = 35;
            // 
            // TxtMotorista
            // 
            this.TxtMotorista.Location = new System.Drawing.Point(110, 154);
            this.TxtMotorista.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMotorista.Name = "TxtMotorista";
            this.TxtMotorista.Size = new System.Drawing.Size(168, 20);
            this.TxtMotorista.TabIndex = 34;
            // 
            // LblManutencao
            // 
            this.LblManutencao.AutoSize = true;
            this.LblManutencao.Location = new System.Drawing.Point(26, 332);
            this.LblManutencao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblManutencao.Name = "LblManutencao";
            this.LblManutencao.Size = new System.Drawing.Size(163, 13);
            this.LblManutencao.TabIndex = 33;
            this.LblManutencao.Text = "Selecione o tipo de manutenção:";
            // 
            // CboManutencao
            // 
            this.CboManutencao.FormattingEnabled = true;
            this.CboManutencao.Location = new System.Drawing.Point(197, 329);
            this.CboManutencao.Margin = new System.Windows.Forms.Padding(4);
            this.CboManutencao.Name = "CboManutencao";
            this.CboManutencao.Size = new System.Drawing.Size(212, 21);
            this.CboManutencao.TabIndex = 32;
            // 
            // FrmManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDataEntrada);
            this.Controls.Add(this.TxtDataSaida);
            this.Controls.Add(this.LblDataSaida);
            this.Controls.Add(this.LblDataEntrada);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.LblIdMecanico);
            this.Controls.Add(this.LblPecas);
            this.Controls.Add(this.LblIdMotorista);
            this.Controls.Add(this.LblPlaca);
            this.Controls.Add(this.TxtPecas);
            this.Controls.Add(this.TxtPlaca);
            this.Controls.Add(this.TxtIdMecanico);
            this.Controls.Add(this.TxtMotorista);
            this.Controls.Add(this.LblManutencao);
            this.Controls.Add(this.CboManutencao);
            this.Name = "FrmManutencao";
            this.Text = "Manutencao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDataEntrada;
        private System.Windows.Forms.TextBox TxtDataSaida;
        private System.Windows.Forms.Label LblDataSaida;
        private System.Windows.Forms.Label LblDataEntrada;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label LblIdMecanico;
        private System.Windows.Forms.Label LblPecas;
        private System.Windows.Forms.Label LblIdMotorista;
        private System.Windows.Forms.Label LblPlaca;
        private System.Windows.Forms.TextBox TxtPecas;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.TextBox TxtIdMecanico;
        private System.Windows.Forms.TextBox TxtMotorista;
        private System.Windows.Forms.Label LblManutencao;
        private System.Windows.Forms.ComboBox CboManutencao;
    }
}