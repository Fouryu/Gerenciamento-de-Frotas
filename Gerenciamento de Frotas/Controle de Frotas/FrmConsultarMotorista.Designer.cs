namespace Controle_de_Frotas
{
    partial class FrmConsultarMotorista
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
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.LblMotorista = new System.Windows.Forms.Label();
            this.TxtIdMotorista = new System.Windows.Forms.TextBox();
            this.dgTabela = new System.Windows.Forms.DataGridView();
            this.BtnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(563, 75);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 16;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // LblMotorista
            // 
            this.LblMotorista.AutoSize = true;
            this.LblMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMotorista.Location = new System.Drawing.Point(351, 52);
            this.LblMotorista.Name = "LblMotorista";
            this.LblMotorista.Size = new System.Drawing.Size(96, 20);
            this.LblMotorista.TabIndex = 15;
            this.LblMotorista.Text = "ID Motorista";
            // 
            // TxtIdMotorista
            // 
            this.TxtIdMotorista.Location = new System.Drawing.Point(251, 75);
            this.TxtIdMotorista.Name = "TxtIdMotorista";
            this.TxtIdMotorista.Size = new System.Drawing.Size(286, 20);
            this.TxtIdMotorista.TabIndex = 14;
            // 
            // dgTabela
            // 
            this.dgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabela.Location = new System.Drawing.Point(12, 121);
            this.dgTabela.Name = "dgTabela";
            this.dgTabela.Size = new System.Drawing.Size(784, 262);
            this.dgTabela.TabIndex = 17;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(35, 404);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 18;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // FrmConsultarMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.dgTabela);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.LblMotorista);
            this.Controls.Add(this.TxtIdMotorista);
            this.Name = "FrmConsultarMotorista";
            this.Text = "Consultar motorista";
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label LblMotorista;
        private System.Windows.Forms.TextBox TxtIdMotorista;
        private System.Windows.Forms.DataGridView dgTabela;
        private System.Windows.Forms.Button BtnVoltar;
    }
}