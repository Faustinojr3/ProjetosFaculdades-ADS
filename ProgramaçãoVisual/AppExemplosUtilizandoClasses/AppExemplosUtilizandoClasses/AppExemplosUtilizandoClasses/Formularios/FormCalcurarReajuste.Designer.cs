namespace AppExemplosUtilizandoClasses.Formularios
{
    partial class FormCalcurarReajuste
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
            this.label3 = new System.Windows.Forms.Label();
            this.TxtReajustado = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReaju = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSalAt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "SALÁRIO REAJUSTADO:";
            // 
            // TxtReajustado
            // 
            this.TxtReajustado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReajustado.Location = new System.Drawing.Point(41, 277);
            this.TxtReajustado.Name = "TxtReajustado";
            this.TxtReajustado.Size = new System.Drawing.Size(233, 26);
            this.TxtReajustado.TabIndex = 22;
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(160, 200);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(114, 34);
            this.btNovo.TabIndex = 21;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = true;
            // 
            // btCalc
            // 
            this.btCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalc.Location = new System.Drawing.Point(41, 200);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(114, 34);
            this.btCalc.TabIndex = 20;
            this.btCalc.Text = "CALCULAR";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "PERC(%) REAJUSTE:";
            // 
            // txtReaju
            // 
            this.txtReaju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReaju.Location = new System.Drawing.Point(41, 130);
            this.txtReaju.Name = "txtReaju";
            this.txtReaju.Size = new System.Drawing.Size(233, 26);
            this.txtReaju.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "SALÁRIO ATUAL:";
            // 
            // TxtSalAt
            // 
            this.TxtSalAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalAt.Location = new System.Drawing.Point(41, 49);
            this.TxtSalAt.Name = "TxtSalAt";
            this.TxtSalAt.Size = new System.Drawing.Size(233, 26);
            this.TxtSalAt.TabIndex = 16;
            // 
            // FormCalcurarReajuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtReajustado);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReaju);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSalAt);
            this.Name = "FormCalcurarReajuste";
            this.Text = "FormCalcurarReajuste";
            this.Load += new System.EventHandler(this.FormCalcurarReajuste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtReajustado;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReaju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSalAt;
    }
}