namespace Controle_de_Frotas
{
    partial class FrmSolicitarManutencao
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
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnManutencao = new System.Windows.Forms.Button();
            this.CboUsuario = new System.Windows.Forms.ComboBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblLocal = new System.Windows.Forms.Label();
            this.LblCnh = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtLocal = new System.Windows.Forms.TextBox();
            this.TxtCnh = new System.Windows.Forms.TextBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblMotivo = new System.Windows.Forms.Label();
            this.TxtMotivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(657, 404);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(135, 23);
            this.BtnVoltar.TabIndex = 40;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnManutencao
            // 
            this.BtnManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManutencao.ImageKey = "(none)";
            this.BtnManutencao.Location = new System.Drawing.Point(657, 259);
            this.BtnManutencao.Name = "BtnManutencao";
            this.BtnManutencao.Size = new System.Drawing.Size(135, 41);
            this.BtnManutencao.TabIndex = 39;
            this.BtnManutencao.Text = "Solicitar Manutenção";
            this.BtnManutencao.UseVisualStyleBackColor = true;
            // 
            // CboUsuario
            // 
            this.CboUsuario.FormattingEnabled = true;
            this.CboUsuario.Location = new System.Drawing.Point(541, 24);
            this.CboUsuario.Name = "CboUsuario";
            this.CboUsuario.Size = new System.Drawing.Size(189, 21);
            this.CboUsuario.TabIndex = 38;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(427, 24);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(108, 16);
            this.LblUsuario.TabIndex = 37;
            this.LblUsuario.Text = "Tipo de Usuário:";
            // 
            // LblLocal
            // 
            this.LblLocal.AutoSize = true;
            this.LblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocal.Location = new System.Drawing.Point(64, 167);
            this.LblLocal.Name = "LblLocal";
            this.LblLocal.Size = new System.Drawing.Size(44, 16);
            this.LblLocal.TabIndex = 36;
            this.LblLocal.Text = "Local:";
            // 
            // LblCnh
            // 
            this.LblCnh.AutoSize = true;
            this.LblCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCnh.Location = new System.Drawing.Point(68, 117);
            this.LblCnh.Name = "LblCnh";
            this.LblCnh.Size = new System.Drawing.Size(40, 16);
            this.LblCnh.TabIndex = 35;
            this.LblCnh.Text = "CNH:";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpf.Location = new System.Drawing.Point(71, 70);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(37, 16);
            this.LblCpf.TabIndex = 34;
            this.LblCpf.Text = "CPF:";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Location = new System.Drawing.Point(84, 25);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(24, 16);
            this.LblId.TabIndex = 33;
            this.LblId.Text = "ID:";
            // 
            // TxtLocal
            // 
            this.TxtLocal.BackColor = System.Drawing.SystemColors.Window;
            this.TxtLocal.Location = new System.Drawing.Point(114, 166);
            this.TxtLocal.Name = "TxtLocal";
            this.TxtLocal.Size = new System.Drawing.Size(258, 20);
            this.TxtLocal.TabIndex = 32;
            // 
            // TxtCnh
            // 
            this.TxtCnh.Location = new System.Drawing.Point(114, 117);
            this.TxtCnh.Name = "TxtCnh";
            this.TxtCnh.Size = new System.Drawing.Size(258, 20);
            this.TxtCnh.TabIndex = 31;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(114, 70);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(258, 20);
            this.TxtCpf.TabIndex = 30;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(114, 24);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(258, 20);
            this.TxtId.TabIndex = 29;
            // 
            // LblMotivo
            // 
            this.LblMotivo.AutoSize = true;
            this.LblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMotivo.Location = new System.Drawing.Point(9, 214);
            this.LblMotivo.Name = "LblMotivo";
            this.LblMotivo.Size = new System.Drawing.Size(57, 18);
            this.LblMotivo.TabIndex = 28;
            this.LblMotivo.Text = "Motivo:";
            // 
            // TxtMotivo
            // 
            this.TxtMotivo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtMotivo.Location = new System.Drawing.Point(12, 235);
            this.TxtMotivo.Multiline = true;
            this.TxtMotivo.Name = "TxtMotivo";
            this.TxtMotivo.Size = new System.Drawing.Size(639, 192);
            this.TxtMotivo.TabIndex = 27;
            // 
            // FrmSolicitarManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnManutencao);
            this.Controls.Add(this.CboUsuario);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblLocal);
            this.Controls.Add(this.LblCnh);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.TxtLocal);
            this.Controls.Add(this.TxtCnh);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblMotivo);
            this.Controls.Add(this.TxtMotivo);
            this.Name = "FrmSolicitarManutencao";
            this.Text = "Solicitar manutencao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnManutencao;
        private System.Windows.Forms.ComboBox CboUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblLocal;
        private System.Windows.Forms.Label LblCnh;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtLocal;
        private System.Windows.Forms.TextBox TxtCnh;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblMotivo;
        private System.Windows.Forms.TextBox TxtMotivo;
    }
}