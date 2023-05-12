namespace AppGeradorLoterias.Formularios
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbImparQuina = new System.Windows.Forms.Label();
            this.lbParQuina = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.ORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NÚMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLimparQuina = new System.Windows.Forms.Button();
            this.btGerarQuina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClass
            // 
            this.lbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbClass.Location = new System.Drawing.Point(54, 256);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(190, 97);
            this.lbClass.TabIndex = 54;
            this.lbClass.Text = "CLASSIFICAÇÃO";
            // 
            // lbImparQuina
            // 
            this.lbImparQuina.AutoSize = true;
            this.lbImparQuina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImparQuina.ForeColor = System.Drawing.Color.Purple;
            this.lbImparQuina.Location = new System.Drawing.Point(100, 200);
            this.lbImparQuina.Name = "lbImparQuina";
            this.lbImparQuina.Size = new System.Drawing.Size(89, 20);
            this.lbImparQuina.TabIndex = 53;
            this.lbImparQuina.Text = "ÍMPARES";
            // 
            // lbParQuina
            // 
            this.lbParQuina.AutoSize = true;
            this.lbParQuina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParQuina.ForeColor = System.Drawing.Color.Purple;
            this.lbParQuina.Location = new System.Drawing.Point(100, 158);
            this.lbParQuina.Name = "lbParQuina";
            this.lbParQuina.Size = new System.Drawing.Size(69, 20);
            this.lbParQuina.TabIndex = 52;
            this.lbParQuina.Text = "PARES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(192, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "QUINA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "NÚMEROS DA SORTE";
            // 
            // tabela
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Plum;
            this.tabela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORD,
            this.NÚMERO});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela.DefaultCellStyle = dataGridViewCellStyle5;
            this.tabela.Location = new System.Drawing.Point(296, 63);
            this.tabela.Name = "tabela";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tabela.Size = new System.Drawing.Size(163, 375);
            this.tabela.TabIndex = 49;
            // 
            // ORD
            // 
            this.ORD.DataPropertyName = "ord";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ORD.DefaultCellStyle = dataGridViewCellStyle3;
            this.ORD.HeaderText = "ORD";
            this.ORD.Name = "ORD";
            this.ORD.Visible = false;
            // 
            // NÚMERO
            // 
            this.NÚMERO.DataPropertyName = "Numero";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NÚMERO.DefaultCellStyle = dataGridViewCellStyle4;
            this.NÚMERO.HeaderText = "NÚMERO";
            this.NÚMERO.Name = "NÚMERO";
            // 
            // btLimparQuina
            // 
            this.btLimparQuina.Location = new System.Drawing.Point(44, 91);
            this.btLimparQuina.Name = "btLimparQuina";
            this.btLimparQuina.Size = new System.Drawing.Size(200, 23);
            this.btLimparQuina.TabIndex = 48;
            this.btLimparQuina.Text = "LIMPAR";
            this.btLimparQuina.UseVisualStyleBackColor = true;
            // 
            // btGerarQuina
            // 
            this.btGerarQuina.Location = new System.Drawing.Point(44, 49);
            this.btGerarQuina.Name = "btGerarQuina";
            this.btGerarQuina.Size = new System.Drawing.Size(200, 23);
            this.btGerarQuina.TabIndex = 47;
            this.btGerarQuina.Text = "GERAR NÚMEROS DA SORTE";
            this.btGerarQuina.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 469);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.lbImparQuina);
            this.Controls.Add(this.lbParQuina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.btLimparQuina);
            this.Controls.Add(this.btGerarQuina);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbImparQuina;
        private System.Windows.Forms.Label lbParQuina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NÚMERO;
        private System.Windows.Forms.Button btLimparQuina;
        private System.Windows.Forms.Button btGerarQuina;
    }
}