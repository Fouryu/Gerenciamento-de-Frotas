namespace Controle_de_Frotas
{
    partial class FrmTelaGerenciarVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaGerenciarVeiculos));
            this.LblCadastrarVeiculo = new System.Windows.Forms.Label();
            this.PicCadastrarVeiculo = new System.Windows.Forms.PictureBox();
            this.LblGerenciarSaida = new System.Windows.Forms.Label();
            this.PicGerenciarSaida = new System.Windows.Forms.PictureBox();
            this.LblGerenciarEntrada = new System.Windows.Forms.Label();
            this.PicGerenciarEntrada = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicCadastrarVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGerenciarSaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGerenciarEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCadastrarVeiculo
            // 
            this.LblCadastrarVeiculo.AutoSize = true;
            this.LblCadastrarVeiculo.Location = new System.Drawing.Point(609, 250);
            this.LblCadastrarVeiculo.Name = "LblCadastrarVeiculo";
            this.LblCadastrarVeiculo.Size = new System.Drawing.Size(91, 13);
            this.LblCadastrarVeiculo.TabIndex = 13;
            this.LblCadastrarVeiculo.Text = "Cadastrar veículo";
            // 
            // PicCadastrarVeiculo
            // 
            this.PicCadastrarVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("PicCadastrarVeiculo.Image")));
            this.PicCadastrarVeiculo.Location = new System.Drawing.Point(602, 154);
            this.PicCadastrarVeiculo.Name = "PicCadastrarVeiculo";
            this.PicCadastrarVeiculo.Size = new System.Drawing.Size(98, 93);
            this.PicCadastrarVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCadastrarVeiculo.TabIndex = 12;
            this.PicCadastrarVeiculo.TabStop = false;
            // 
            // LblGerenciarSaida
            // 
            this.LblGerenciarSaida.AutoSize = true;
            this.LblGerenciarSaida.Location = new System.Drawing.Point(349, 250);
            this.LblGerenciarSaida.Name = "LblGerenciarSaida";
            this.LblGerenciarSaida.Size = new System.Drawing.Size(137, 13);
            this.LblGerenciarSaida.TabIndex = 11;
            this.LblGerenciarSaida.Text = "Gerenciar saída do veículo";
            // 
            // PicGerenciarSaida
            // 
            this.PicGerenciarSaida.Image = ((System.Drawing.Image)(resources.GetObject("PicGerenciarSaida.Image")));
            this.PicGerenciarSaida.Location = new System.Drawing.Point(365, 154);
            this.PicGerenciarSaida.Name = "PicGerenciarSaida";
            this.PicGerenciarSaida.Size = new System.Drawing.Size(98, 93);
            this.PicGerenciarSaida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicGerenciarSaida.TabIndex = 10;
            this.PicGerenciarSaida.TabStop = false;
            // 
            // LblGerenciarEntrada
            // 
            this.LblGerenciarEntrada.AutoSize = true;
            this.LblGerenciarEntrada.Location = new System.Drawing.Point(95, 250);
            this.LblGerenciarEntrada.Name = "LblGerenciarEntrada";
            this.LblGerenciarEntrada.Size = new System.Drawing.Size(146, 13);
            this.LblGerenciarEntrada.TabIndex = 9;
            this.LblGerenciarEntrada.Text = "Gerenciar entrada do veículo";
            // 
            // PicGerenciarEntrada
            // 
            this.PicGerenciarEntrada.Image = ((System.Drawing.Image)(resources.GetObject("PicGerenciarEntrada.Image")));
            this.PicGerenciarEntrada.Location = new System.Drawing.Point(117, 154);
            this.PicGerenciarEntrada.Name = "PicGerenciarEntrada";
            this.PicGerenciarEntrada.Size = new System.Drawing.Size(98, 93);
            this.PicGerenciarEntrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicGerenciarEntrada.TabIndex = 8;
            this.PicGerenciarEntrada.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmTelaGerenciarVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblCadastrarVeiculo);
            this.Controls.Add(this.PicCadastrarVeiculo);
            this.Controls.Add(this.LblGerenciarSaida);
            this.Controls.Add(this.PicGerenciarSaida);
            this.Controls.Add(this.LblGerenciarEntrada);
            this.Controls.Add(this.PicGerenciarEntrada);
            this.Controls.Add(this.button1);
            this.Name = "FrmTelaGerenciarVeiculos";
            this.Text = "Tela gerenciar veiculos";
            ((System.ComponentModel.ISupportInitialize)(this.PicCadastrarVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGerenciarSaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGerenciarEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCadastrarVeiculo;
        private System.Windows.Forms.PictureBox PicCadastrarVeiculo;
        private System.Windows.Forms.Label LblGerenciarSaida;
        private System.Windows.Forms.PictureBox PicGerenciarSaida;
        private System.Windows.Forms.Label LblGerenciarEntrada;
        private System.Windows.Forms.PictureBox PicGerenciarEntrada;
        private System.Windows.Forms.Button button1;
    }
}