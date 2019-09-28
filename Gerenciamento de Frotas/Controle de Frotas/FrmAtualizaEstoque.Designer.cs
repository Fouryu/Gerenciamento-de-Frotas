namespace Controle_de_Frotas
{
    partial class FrmAtualizaEstoque
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
            this.LblDataSaida = new System.Windows.Forms.Label();
            this.LblIdPeca = new System.Windows.Forms.Label();
            this.LblIdMecanico = new System.Windows.Forms.Label();
            this.TxtIdMecanico = new System.Windows.Forms.TextBox();
            this.TxtDataSaida = new System.Windows.Forms.TextBox();
            this.TxtIdPeca = new System.Windows.Forms.TextBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDataSaida
            // 
            this.LblDataSaida.AutoSize = true;
            this.LblDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataSaida.Location = new System.Drawing.Point(259, 190);
            this.LblDataSaida.Name = "LblDataSaida";
            this.LblDataSaida.Size = new System.Drawing.Size(107, 18);
            this.LblDataSaida.TabIndex = 23;
            this.LblDataSaida.Text = "Data De Saída:";
            // 
            // LblIdPeca
            // 
            this.LblIdPeca.AutoSize = true;
            this.LblIdPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdPeca.Location = new System.Drawing.Point(302, 120);
            this.LblIdPeca.Name = "LblIdPeca";
            this.LblIdPeca.Size = new System.Drawing.Size(64, 18);
            this.LblIdPeca.TabIndex = 22;
            this.LblIdPeca.Text = "ID Peça:";
            // 
            // LblIdMecanico
            // 
            this.LblIdMecanico.AutoSize = true;
            this.LblIdMecanico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdMecanico.Location = new System.Drawing.Point(271, 47);
            this.LblIdMecanico.Name = "LblIdMecanico";
            this.LblIdMecanico.Size = new System.Drawing.Size(95, 18);
            this.LblIdMecanico.TabIndex = 21;
            this.LblIdMecanico.Text = "ID Mecanico:";
            // 
            // TxtIdMecanico
            // 
            this.TxtIdMecanico.Location = new System.Drawing.Point(372, 47);
            this.TxtIdMecanico.Name = "TxtIdMecanico";
            this.TxtIdMecanico.Size = new System.Drawing.Size(132, 20);
            this.TxtIdMecanico.TabIndex = 20;
            // 
            // TxtDataSaida
            // 
            this.TxtDataSaida.Location = new System.Drawing.Point(372, 190);
            this.TxtDataSaida.Name = "TxtDataSaida";
            this.TxtDataSaida.Size = new System.Drawing.Size(91, 20);
            this.TxtDataSaida.TabIndex = 19;
            // 
            // TxtIdPeca
            // 
            this.TxtIdPeca.Location = new System.Drawing.Point(372, 121);
            this.TxtIdPeca.Name = "TxtIdPeca";
            this.TxtIdPeca.Size = new System.Drawing.Size(132, 20);
            this.TxtIdPeca.TabIndex = 18;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(84, 377);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(105, 26);
            this.BtnVoltar.TabIndex = 17;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Location = new System.Drawing.Point(581, 377);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(105, 26);
            this.BtnAtualizar.TabIndex = 16;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            // 
            // FrmAtualizaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblDataSaida);
            this.Controls.Add(this.LblIdPeca);
            this.Controls.Add(this.LblIdMecanico);
            this.Controls.Add(this.TxtIdMecanico);
            this.Controls.Add(this.TxtDataSaida);
            this.Controls.Add(this.TxtIdPeca);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnAtualizar);
            this.Name = "FrmAtualizaEstoque";
            this.Text = "Atualiza estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDataSaida;
        private System.Windows.Forms.Label LblIdPeca;
        private System.Windows.Forms.Label LblIdMecanico;
        private System.Windows.Forms.TextBox TxtIdMecanico;
        private System.Windows.Forms.TextBox TxtDataSaida;
        private System.Windows.Forms.TextBox TxtIdPeca;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnAtualizar;
    }
}