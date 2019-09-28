namespace Controle_de_Frotas
{
    partial class FrmSolicitarVeiculo
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
            this.TxtDataDevolucao = new System.Windows.Forms.TextBox();
            this.TxtDataPedido = new System.Windows.Forms.TextBox();
            this.LblDataDevolucao = new System.Windows.Forms.Label();
            this.LblDataPedido = new System.Windows.Forms.Label();
            this.TxtCartao = new System.Windows.Forms.TextBox();
            this.LblCartao = new System.Windows.Forms.Label();
            this.CboVeiculo = new System.Windows.Forms.ComboBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtRg = new System.Windows.Forms.TextBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.LblVeiculo = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblRg = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnSolicitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDataDevolucao
            // 
            this.TxtDataDevolucao.Location = new System.Drawing.Point(372, 301);
            this.TxtDataDevolucao.Name = "TxtDataDevolucao";
            this.TxtDataDevolucao.Size = new System.Drawing.Size(120, 20);
            this.TxtDataDevolucao.TabIndex = 49;
            // 
            // TxtDataPedido
            // 
            this.TxtDataPedido.Location = new System.Drawing.Point(372, 259);
            this.TxtDataPedido.Name = "TxtDataPedido";
            this.TxtDataPedido.Size = new System.Drawing.Size(120, 20);
            this.TxtDataPedido.TabIndex = 48;
            // 
            // LblDataDevolucao
            // 
            this.LblDataDevolucao.AutoSize = true;
            this.LblDataDevolucao.Location = new System.Drawing.Point(263, 304);
            this.LblDataDevolucao.Name = "LblDataDevolucao";
            this.LblDataDevolucao.Size = new System.Drawing.Size(100, 13);
            this.LblDataDevolucao.TabIndex = 47;
            this.LblDataDevolucao.Text = "Data de Devolução";
            // 
            // LblDataPedido
            // 
            this.LblDataPedido.AutoSize = true;
            this.LblDataPedido.Location = new System.Drawing.Point(263, 262);
            this.LblDataPedido.Name = "LblDataPedido";
            this.LblDataPedido.Size = new System.Drawing.Size(81, 13);
            this.LblDataPedido.TabIndex = 46;
            this.LblDataPedido.Text = "Data de Pedido";
            // 
            // TxtCartao
            // 
            this.TxtCartao.Location = new System.Drawing.Point(355, 173);
            this.TxtCartao.Name = "TxtCartao";
            this.TxtCartao.Size = new System.Drawing.Size(236, 20);
            this.TxtCartao.TabIndex = 45;
            // 
            // LblCartao
            // 
            this.LblCartao.AutoSize = true;
            this.LblCartao.Location = new System.Drawing.Point(263, 176);
            this.LblCartao.Name = "LblCartao";
            this.LblCartao.Size = new System.Drawing.Size(92, 13);
            this.LblCartao.TabIndex = 44;
            this.LblCartao.Text = "Número do cartão";
            // 
            // CboVeiculo
            // 
            this.CboVeiculo.FormattingEnabled = true;
            this.CboVeiculo.Location = new System.Drawing.Point(330, 215);
            this.CboVeiculo.Name = "CboVeiculo";
            this.CboVeiculo.Size = new System.Drawing.Size(180, 21);
            this.CboVeiculo.TabIndex = 43;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(299, 40);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(228, 20);
            this.TxtNome.TabIndex = 42;
            // 
            // TxtRg
            // 
            this.TxtRg.Location = new System.Drawing.Point(299, 88);
            this.TxtRg.Name = "TxtRg";
            this.TxtRg.Size = new System.Drawing.Size(228, 20);
            this.TxtRg.TabIndex = 41;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(299, 132);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(228, 20);
            this.TxtCpf.TabIndex = 40;
            // 
            // LblVeiculo
            // 
            this.LblVeiculo.AutoSize = true;
            this.LblVeiculo.Location = new System.Drawing.Point(263, 218);
            this.LblVeiculo.Name = "LblVeiculo";
            this.LblVeiculo.Size = new System.Drawing.Size(44, 13);
            this.LblVeiculo.TabIndex = 39;
            this.LblVeiculo.Text = "Veículo";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Location = new System.Drawing.Point(263, 132);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(27, 13);
            this.LblCpf.TabIndex = 38;
            this.LblCpf.Text = "CPF";
            // 
            // LblRg
            // 
            this.LblRg.AutoSize = true;
            this.LblRg.Location = new System.Drawing.Point(263, 91);
            this.LblRg.Name = "LblRg";
            this.LblRg.Size = new System.Drawing.Size(23, 13);
            this.LblRg.TabIndex = 37;
            this.LblRg.Text = "RG";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(255, 43);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 36;
            this.LblNome.Text = "Nome";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(34, 388);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(135, 23);
            this.BtnVoltar.TabIndex = 35;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnSolicitar
            // 
            this.BtnSolicitar.Location = new System.Drawing.Point(610, 388);
            this.BtnSolicitar.Name = "BtnSolicitar";
            this.BtnSolicitar.Size = new System.Drawing.Size(135, 23);
            this.BtnSolicitar.TabIndex = 34;
            this.BtnSolicitar.Text = "Solicitar veiculo";
            this.BtnSolicitar.UseVisualStyleBackColor = true;
            // 
            // FrmSolicitarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDataDevolucao);
            this.Controls.Add(this.TxtDataPedido);
            this.Controls.Add(this.LblDataDevolucao);
            this.Controls.Add(this.LblDataPedido);
            this.Controls.Add(this.TxtCartao);
            this.Controls.Add(this.LblCartao);
            this.Controls.Add(this.CboVeiculo);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtRg);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.LblVeiculo);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblRg);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnSolicitar);
            this.Name = "FrmSolicitarVeiculo";
            this.Text = "Solicitar veiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDataDevolucao;
        private System.Windows.Forms.TextBox TxtDataPedido;
        private System.Windows.Forms.Label LblDataDevolucao;
        private System.Windows.Forms.Label LblDataPedido;
        private System.Windows.Forms.TextBox TxtCartao;
        private System.Windows.Forms.Label LblCartao;
        private System.Windows.Forms.ComboBox CboVeiculo;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtRg;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.Label LblVeiculo;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblRg;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnSolicitar;
    }
}