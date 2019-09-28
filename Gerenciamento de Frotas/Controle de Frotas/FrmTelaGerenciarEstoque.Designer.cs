namespace Controle_de_Frotas
{
    partial class FrmTelaGerenciarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaGerenciarEstoque));
            this.LblAtualizaEstoque = new System.Windows.Forms.Label();
            this.PicAtualizaEstoque = new System.Windows.Forms.PictureBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.LblSolicitaPeca = new System.Windows.Forms.Label();
            this.PicSolicitaPeca = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicAtualizaEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSolicitaPeca)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAtualizaEstoque
            // 
            this.LblAtualizaEstoque.AutoSize = true;
            this.LblAtualizaEstoque.Location = new System.Drawing.Point(503, 257);
            this.LblAtualizaEstoque.Name = "LblAtualizaEstoque";
            this.LblAtualizaEstoque.Size = new System.Drawing.Size(85, 13);
            this.LblAtualizaEstoque.TabIndex = 9;
            this.LblAtualizaEstoque.Text = "Atualiza estoque";
            // 
            // PicAtualizaEstoque
            // 
            this.PicAtualizaEstoque.Image = ((System.Drawing.Image)(resources.GetObject("PicAtualizaEstoque.Image")));
            this.PicAtualizaEstoque.Location = new System.Drawing.Point(489, 137);
            this.PicAtualizaEstoque.Name = "PicAtualizaEstoque";
            this.PicAtualizaEstoque.Size = new System.Drawing.Size(108, 106);
            this.PicAtualizaEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicAtualizaEstoque.TabIndex = 8;
            this.PicAtualizaEstoque.TabStop = false;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(55, 377);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(105, 26);
            this.BtnVoltar.TabIndex = 7;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // LblSolicitaPeca
            // 
            this.LblSolicitaPeca.AutoSize = true;
            this.LblSolicitaPeca.Location = new System.Drawing.Point(242, 257);
            this.LblSolicitaPeca.Name = "LblSolicitaPeca";
            this.LblSolicitaPeca.Size = new System.Drawing.Size(68, 13);
            this.LblSolicitaPeca.TabIndex = 6;
            this.LblSolicitaPeca.Text = "Solicita peça";
            // 
            // PicSolicitaPeca
            // 
            this.PicSolicitaPeca.Image = ((System.Drawing.Image)(resources.GetObject("PicSolicitaPeca.Image")));
            this.PicSolicitaPeca.Location = new System.Drawing.Point(221, 137);
            this.PicSolicitaPeca.Name = "PicSolicitaPeca";
            this.PicSolicitaPeca.Size = new System.Drawing.Size(108, 106);
            this.PicSolicitaPeca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSolicitaPeca.TabIndex = 5;
            this.PicSolicitaPeca.TabStop = false;
            // 
            // FrmTelaGerenciarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAtualizaEstoque);
            this.Controls.Add(this.PicAtualizaEstoque);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.LblSolicitaPeca);
            this.Controls.Add(this.PicSolicitaPeca);
            this.Name = "FrmTelaGerenciarEstoque";
            this.Text = "Tela gerenciar estoque";
            ((System.ComponentModel.ISupportInitialize)(this.PicAtualizaEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSolicitaPeca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAtualizaEstoque;
        private System.Windows.Forms.PictureBox PicAtualizaEstoque;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label LblSolicitaPeca;
        private System.Windows.Forms.PictureBox PicSolicitaPeca;
    }
}