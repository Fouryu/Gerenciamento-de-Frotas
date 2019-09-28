namespace Controle_de_Frotas
{
    partial class FrmTelaGerenciarMotoristas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaGerenciarMotoristas));
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.LblAlterarMotorista = new System.Windows.Forms.Label();
            this.PicAlterarMotorista = new System.Windows.Forms.PictureBox();
            this.LblCadastrarMotorista = new System.Windows.Forms.Label();
            this.PicCadastrarMotorista = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicAlterarMotorista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCadastrarMotorista)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(49, 381);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(105, 26);
            this.BtnVoltar.TabIndex = 9;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // LblAlterarMotorista
            // 
            this.LblAlterarMotorista.AutoSize = true;
            this.LblAlterarMotorista.Location = new System.Drawing.Point(483, 244);
            this.LblAlterarMotorista.Name = "LblAlterarMotorista";
            this.LblAlterarMotorista.Size = new System.Drawing.Size(157, 13);
            this.LblAlterarMotorista.TabIndex = 8;
            this.LblAlterarMotorista.Text = "Alterar informações do motorista";
            // 
            // PicAlterarMotorista
            // 
            this.PicAlterarMotorista.Image = ((System.Drawing.Image)(resources.GetObject("PicAlterarMotorista.Image")));
            this.PicAlterarMotorista.Location = new System.Drawing.Point(509, 128);
            this.PicAlterarMotorista.Name = "PicAlterarMotorista";
            this.PicAlterarMotorista.Size = new System.Drawing.Size(99, 104);
            this.PicAlterarMotorista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicAlterarMotorista.TabIndex = 7;
            this.PicAlterarMotorista.TabStop = false;
            // 
            // LblCadastrarMotorista
            // 
            this.LblCadastrarMotorista.AutoSize = true;
            this.LblCadastrarMotorista.Location = new System.Drawing.Point(172, 244);
            this.LblCadastrarMotorista.Name = "LblCadastrarMotorista";
            this.LblCadastrarMotorista.Size = new System.Drawing.Size(172, 13);
            this.LblCadastrarMotorista.TabIndex = 6;
            this.LblCadastrarMotorista.Text = "Cadastrar informações do motorista";
            // 
            // PicCadastrarMotorista
            // 
            this.PicCadastrarMotorista.Image = ((System.Drawing.Image)(resources.GetObject("PicCadastrarMotorista.Image")));
            this.PicCadastrarMotorista.Location = new System.Drawing.Point(205, 128);
            this.PicCadastrarMotorista.Name = "PicCadastrarMotorista";
            this.PicCadastrarMotorista.Size = new System.Drawing.Size(99, 104);
            this.PicCadastrarMotorista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCadastrarMotorista.TabIndex = 5;
            this.PicCadastrarMotorista.TabStop = false;
            // 
            // FrmTelaGerenciarMotoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.LblAlterarMotorista);
            this.Controls.Add(this.PicAlterarMotorista);
            this.Controls.Add(this.LblCadastrarMotorista);
            this.Controls.Add(this.PicCadastrarMotorista);
            this.Name = "FrmTelaGerenciarMotoristas";
            this.Text = "Tela gerenciar motoristas";
            ((System.ComponentModel.ISupportInitialize)(this.PicAlterarMotorista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCadastrarMotorista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label LblAlterarMotorista;
        private System.Windows.Forms.PictureBox PicAlterarMotorista;
        private System.Windows.Forms.Label LblCadastrarMotorista;
        private System.Windows.Forms.PictureBox PicCadastrarMotorista;
    }
}