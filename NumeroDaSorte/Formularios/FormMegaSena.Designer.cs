namespace AppGeradorLoterias.Formularios
{
    partial class FormMegaSena
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbClassMegaSena = new System.Windows.Forms.Label();
            this.lbImparMegaSena = new System.Windows.Forms.Label();
            this.lbParMegaSena = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabelaMegaSena = new System.Windows.Forms.DataGridView();
            this.ORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NÚMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLimparMegaSena = new System.Windows.Forms.Button();
            this.btGerarMgaSena = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaMegaSena)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClassMegaSena
            // 
            this.lbClassMegaSena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassMegaSena.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbClassMegaSena.Location = new System.Drawing.Point(28, 256);
            this.lbClassMegaSena.Name = "lbClassMegaSena";
            this.lbClassMegaSena.Size = new System.Drawing.Size(190, 97);
            this.lbClassMegaSena.TabIndex = 54;
            this.lbClassMegaSena.Text = "CLASSIFICAÇÃO";
            // 
            // lbImparMegaSena
            // 
            this.lbImparMegaSena.AutoSize = true;
            this.lbImparMegaSena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImparMegaSena.ForeColor = System.Drawing.Color.Purple;
            this.lbImparMegaSena.Location = new System.Drawing.Point(74, 200);
            this.lbImparMegaSena.Name = "lbImparMegaSena";
            this.lbImparMegaSena.Size = new System.Drawing.Size(89, 20);
            this.lbImparMegaSena.TabIndex = 53;
            this.lbImparMegaSena.Text = "ÍMPARES";
            // 
            // lbParMegaSena
            // 
            this.lbParMegaSena.AutoSize = true;
            this.lbParMegaSena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParMegaSena.ForeColor = System.Drawing.Color.Purple;
            this.lbParMegaSena.Location = new System.Drawing.Point(74, 158);
            this.lbParMegaSena.Name = "lbParMegaSena";
            this.lbParMegaSena.Size = new System.Drawing.Size(69, 20);
            this.lbParMegaSena.TabIndex = 52;
            this.lbParMegaSena.Text = "PARES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(147, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "MEGASENA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "NÚMEROS DA SORTE";
            // 
            // tabelaMegaSena
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Plum;
            this.tabelaMegaSena.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaMegaSena.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tabelaMegaSena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaMegaSena.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORD,
            this.NÚMERO});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaMegaSena.DefaultCellStyle = dataGridViewCellStyle11;
            this.tabelaMegaSena.Location = new System.Drawing.Point(270, 63);
            this.tabelaMegaSena.Name = "tabelaMegaSena";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaMegaSena.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.tabelaMegaSena.Size = new System.Drawing.Size(163, 375);
            this.tabelaMegaSena.TabIndex = 49;
            // 
            // ORD
            // 
            this.ORD.DataPropertyName = "ord";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ORD.DefaultCellStyle = dataGridViewCellStyle9;
            this.ORD.HeaderText = "ORD";
            this.ORD.Name = "ORD";
            this.ORD.Visible = false;
            // 
            // NÚMERO
            // 
            this.NÚMERO.DataPropertyName = "Numero";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NÚMERO.DefaultCellStyle = dataGridViewCellStyle10;
            this.NÚMERO.HeaderText = "NÚMERO";
            this.NÚMERO.Name = "NÚMERO";
            // 
            // btLimparMegaSena
            // 
            this.btLimparMegaSena.Location = new System.Drawing.Point(18, 91);
            this.btLimparMegaSena.Name = "btLimparMegaSena";
            this.btLimparMegaSena.Size = new System.Drawing.Size(200, 23);
            this.btLimparMegaSena.TabIndex = 48;
            this.btLimparMegaSena.Text = "LIMPAR";
            this.btLimparMegaSena.UseVisualStyleBackColor = true;
            // 
            // btGerarMgaSena
            // 
            this.btGerarMgaSena.Location = new System.Drawing.Point(18, 49);
            this.btGerarMgaSena.Name = "btGerarMgaSena";
            this.btGerarMgaSena.Size = new System.Drawing.Size(200, 23);
            this.btGerarMgaSena.TabIndex = 47;
            this.btGerarMgaSena.Text = "GERAR NÚMEROS DA SORTE";
            this.btGerarMgaSena.UseVisualStyleBackColor = true;
            // 
            // FormMegaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 457);
            this.Controls.Add(this.lbClassMegaSena);
            this.Controls.Add(this.lbImparMegaSena);
            this.Controls.Add(this.lbParMegaSena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabelaMegaSena);
            this.Controls.Add(this.btLimparMegaSena);
            this.Controls.Add(this.btGerarMgaSena);
            this.Name = "FormMegaSena";
            this.Text = "FormMegaSena";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaMegaSena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClassMegaSena;
        private System.Windows.Forms.Label lbImparMegaSena;
        private System.Windows.Forms.Label lbParMegaSena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tabelaMegaSena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NÚMERO;
        private System.Windows.Forms.Button btLimparMegaSena;
        private System.Windows.Forms.Button btGerarMgaSena;
    }
}