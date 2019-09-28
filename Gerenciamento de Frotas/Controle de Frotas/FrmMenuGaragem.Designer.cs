namespace Controle_de_Frotas
{
    partial class FrmMenuGaragem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuGaragem));
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblEstoque = new System.Windows.Forms.Label();
            this.PicGerenciarEstoque = new System.Windows.Forms.PictureBox();
            this.LblManutencao = new System.Windows.Forms.Label();
            this.PicRealizarManutencao = new System.Windows.Forms.PictureBox();
            this.LblVeiculos = new System.Windows.Forms.Label();
            this.PicGerenciarVeiculos = new System.Windows.Forms.PictureBox();
            this.LblGaragem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicGerenciarEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRealizarManutencao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGerenciarVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(651, 388);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(105, 26);
            this.BtnSair.TabIndex = 16;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            // 
            // LblEstoque
            // 
            this.LblEstoque.AutoSize = true;
            this.LblEstoque.Location = new System.Drawing.Point(600, 280);
            this.LblEstoque.Name = "LblEstoque";
            this.LblEstoque.Size = new System.Drawing.Size(94, 13);
            this.LblEstoque.TabIndex = 15;
            this.LblEstoque.Text = "Gerenciar estoque";
            // 
            // PicGerenciarEstoque
            // 
            this.PicGerenciarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("PicGerenciarEstoque.Image")));
            this.PicGerenciarEstoque.Location = new System.Drawing.Point(603, 192);
            this.PicGerenciarEstoque.Name = "PicGerenciarEstoque";
            this.PicGerenciarEstoque.Size = new System.Drawing.Size(90, 85);
            this.PicGerenciarEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicGerenciarEstoque.TabIndex = 14;
            this.PicGerenciarEstoque.TabStop = false;
            // 
            // LblManutencao
            // 
            this.LblManutencao.AutoSize = true;
            this.LblManutencao.Location = new System.Drawing.Point(330, 280);
            this.LblManutencao.Name = "LblManutencao";
            this.LblManutencao.Size = new System.Drawing.Size(166, 13);
            this.LblManutencao.TabIndex = 13;
            this.LblManutencao.Text = "Realizar manutenção de veículos";
            // 
            // PicRealizarManutencao
            // 
            this.PicRealizarManutencao.Image = ((System.Drawing.Image)(resources.GetObject("PicRealizarManutencao.Image")));
            this.PicRealizarManutencao.Location = new System.Drawing.Point(368, 192);
            this.PicRealizarManutencao.Name = "PicRealizarManutencao";
            this.PicRealizarManutencao.Size = new System.Drawing.Size(90, 85);
            this.PicRealizarManutencao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicRealizarManutencao.TabIndex = 12;
            this.PicRealizarManutencao.TabStop = false;
            // 
            // LblVeiculos
            // 
            this.LblVeiculos.AutoSize = true;
            this.LblVeiculos.Location = new System.Drawing.Point(109, 280);
            this.LblVeiculos.Name = "LblVeiculos";
            this.LblVeiculos.Size = new System.Drawing.Size(97, 13);
            this.LblVeiculos.TabIndex = 11;
            this.LblVeiculos.Text = "Gerenciar veículos";
            // 
            // PicGerenciarVeiculos
            // 
            this.PicGerenciarVeiculos.Image = ((System.Drawing.Image)(resources.GetObject("PicGerenciarVeiculos.Image")));
            this.PicGerenciarVeiculos.Location = new System.Drawing.Point(112, 192);
            this.PicGerenciarVeiculos.Name = "PicGerenciarVeiculos";
            this.PicGerenciarVeiculos.Size = new System.Drawing.Size(90, 85);
            this.PicGerenciarVeiculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicGerenciarVeiculos.TabIndex = 10;
            this.PicGerenciarVeiculos.TabStop = false;
            // 
            // LblGaragem
            // 
            this.LblGaragem.AutoSize = true;
            this.LblGaragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGaragem.Location = new System.Drawing.Point(335, 33);
            this.LblGaragem.Name = "LblGaragem";
            this.LblGaragem.Size = new System.Drawing.Size(173, 42);
            this.LblGaragem.TabIndex = 9;
            this.LblGaragem.Text = "Garagem";
            // 
            // FrmMenuGaragem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblEstoque);
            this.Controls.Add(this.PicGerenciarEstoque);
            this.Controls.Add(this.LblManutencao);
            this.Controls.Add(this.PicRealizarManutencao);
            this.Controls.Add(this.LblVeiculos);
            this.Controls.Add(this.PicGerenciarVeiculos);
            this.Controls.Add(this.LblGaragem);
            this.Name = "FrmMenuGaragem";
            this.Text = "Menu Garagem";
            ((System.ComponentModel.ISupportInitialize)(this.PicGerenciarEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRealizarManutencao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGerenciarVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblEstoque;
        private System.Windows.Forms.PictureBox PicGerenciarEstoque;
        private System.Windows.Forms.Label LblManutencao;
        private System.Windows.Forms.PictureBox PicRealizarManutencao;
        private System.Windows.Forms.Label LblVeiculos;
        private System.Windows.Forms.PictureBox PicGerenciarVeiculos;
        private System.Windows.Forms.Label LblGaragem;
    }
}