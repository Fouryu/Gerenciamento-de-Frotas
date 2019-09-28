namespace Controle_de_Frotas
{
    partial class FrmMenuAtendente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuAtendente));
            this.LblVeiculo = new System.Windows.Forms.Label();
            this.LblManutencao = new System.Windows.Forms.Label();
            this.LblMotoristas = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PicSolicitarVeiculo = new System.Windows.Forms.PictureBox();
            this.PicSolicitarManutencao = new System.Windows.Forms.PictureBox();
            this.PicGerenciarMotoristas = new System.Windows.Forms.PictureBox();
            this.LblAtendente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicSolicitarVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSolicitarManutencao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGerenciarMotoristas)).BeginInit();
            this.SuspendLayout();
            // 
            // LblVeiculo
            // 
            this.LblVeiculo.AutoSize = true;
            this.LblVeiculo.Location = new System.Drawing.Point(614, 293);
            this.LblVeiculo.Name = "LblVeiculo";
            this.LblVeiculo.Size = new System.Drawing.Size(83, 13);
            this.LblVeiculo.TabIndex = 16;
            this.LblVeiculo.Text = "Solicitar veículo";
            // 
            // LblManutencao
            // 
            this.LblManutencao.AutoSize = true;
            this.LblManutencao.Location = new System.Drawing.Point(360, 293);
            this.LblManutencao.Name = "LblManutencao";
            this.LblManutencao.Size = new System.Drawing.Size(106, 13);
            this.LblManutencao.TabIndex = 15;
            this.LblManutencao.Text = "Solicitar manutenção";
            // 
            // LblMotoristas
            // 
            this.LblMotoristas.AutoSize = true;
            this.LblMotoristas.Location = new System.Drawing.Point(92, 293);
            this.LblMotoristas.Name = "LblMotoristas";
            this.LblMotoristas.Size = new System.Drawing.Size(103, 13);
            this.LblMotoristas.TabIndex = 14;
            this.LblMotoristas.Text = "Gerenciar motoristas";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(650, 391);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(105, 26);
            this.BtnSair.TabIndex = 13;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            // 
            // PicSolicitarVeiculo
            // 
            this.PicSolicitarVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("PicSolicitarVeiculo.Image")));
            this.PicSolicitarVeiculo.Location = new System.Drawing.Point(607, 195);
            this.PicSolicitarVeiculo.Name = "PicSolicitarVeiculo";
            this.PicSolicitarVeiculo.Size = new System.Drawing.Size(90, 85);
            this.PicSolicitarVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSolicitarVeiculo.TabIndex = 12;
            this.PicSolicitarVeiculo.TabStop = false;
            // 
            // PicSolicitarManutencao
            // 
            this.PicSolicitarManutencao.Image = ((System.Drawing.Image)(resources.GetObject("PicSolicitarManutencao.Image")));
            this.PicSolicitarManutencao.Location = new System.Drawing.Point(363, 195);
            this.PicSolicitarManutencao.Name = "PicSolicitarManutencao";
            this.PicSolicitarManutencao.Size = new System.Drawing.Size(90, 85);
            this.PicSolicitarManutencao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSolicitarManutencao.TabIndex = 11;
            this.PicSolicitarManutencao.TabStop = false;
            // 
            // PicGerenciarMotoristas
            // 
            this.PicGerenciarMotoristas.Image = ((System.Drawing.Image)(resources.GetObject("PicGerenciarMotoristas.Image")));
            this.PicGerenciarMotoristas.Location = new System.Drawing.Point(95, 195);
            this.PicGerenciarMotoristas.Name = "PicGerenciarMotoristas";
            this.PicGerenciarMotoristas.Size = new System.Drawing.Size(90, 85);
            this.PicGerenciarMotoristas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicGerenciarMotoristas.TabIndex = 10;
            this.PicGerenciarMotoristas.TabStop = false;
            // 
            // LblAtendente
            // 
            this.LblAtendente.AutoSize = true;
            this.LblAtendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtendente.Location = new System.Drawing.Point(321, 33);
            this.LblAtendente.Name = "LblAtendente";
            this.LblAtendente.Size = new System.Drawing.Size(189, 42);
            this.LblAtendente.TabIndex = 9;
            this.LblAtendente.Text = "Atendente";
            // 
            // FrmMenuAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblVeiculo);
            this.Controls.Add(this.LblManutencao);
            this.Controls.Add(this.LblMotoristas);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.PicSolicitarVeiculo);
            this.Controls.Add(this.PicSolicitarManutencao);
            this.Controls.Add(this.PicGerenciarMotoristas);
            this.Controls.Add(this.LblAtendente);
            this.Name = "FrmMenuAtendente";
            this.Text = "Menu Atendente";
            ((System.ComponentModel.ISupportInitialize)(this.PicSolicitarVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSolicitarManutencao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGerenciarMotoristas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVeiculo;
        private System.Windows.Forms.Label LblManutencao;
        private System.Windows.Forms.Label LblMotoristas;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.PictureBox PicSolicitarVeiculo;
        private System.Windows.Forms.PictureBox PicSolicitarManutencao;
        private System.Windows.Forms.PictureBox PicGerenciarMotoristas;
        private System.Windows.Forms.Label LblAtendente;
    }
}