namespace AppExemplosUtilizandoClasses
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btOperacoes = new System.Windows.Forms.Button();
            this.btReajuste = new System.Windows.Forms.Button();
            this.btCalcularJuros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOperacoes
            // 
            this.btOperacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOperacoes.Location = new System.Drawing.Point(158, 120);
            this.btOperacoes.Name = "btOperacoes";
            this.btOperacoes.Size = new System.Drawing.Size(270, 34);
            this.btOperacoes.TabIndex = 0;
            this.btOperacoes.Text = "CALCULAR VALORES";
            this.btOperacoes.UseVisualStyleBackColor = true;
            this.btOperacoes.Click += new System.EventHandler(this.btOperacoes_Click);
            // 
            // btReajuste
            // 
            this.btReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReajuste.Location = new System.Drawing.Point(158, 179);
            this.btReajuste.Name = "btReajuste";
            this.btReajuste.Size = new System.Drawing.Size(270, 34);
            this.btReajuste.TabIndex = 1;
            this.btReajuste.Text = "CALCULAR REAJUSTE";
            this.btReajuste.UseVisualStyleBackColor = true;
            this.btReajuste.Click += new System.EventHandler(this.btReajuste_Click);
            // 
            // btCalcularJuros
            // 
            this.btCalcularJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcularJuros.Location = new System.Drawing.Point(158, 242);
            this.btCalcularJuros.Name = "btCalcularJuros";
            this.btCalcularJuros.Size = new System.Drawing.Size(270, 34);
            this.btCalcularJuros.TabIndex = 2;
            this.btCalcularJuros.Text = "CALCULAR JUROS";
            this.btCalcularJuros.UseVisualStyleBackColor = true;
            this.btCalcularJuros.Click += new System.EventHandler(this.btCalcularJuros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.btCalcularJuros);
            this.Controls.Add(this.btReajuste);
            this.Controls.Add(this.btOperacoes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOperacoes;
        private System.Windows.Forms.Button btReajuste;
        private System.Windows.Forms.Button btCalcularJuros;
    }
}

