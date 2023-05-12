namespace AppGeradorLoterias.Formularios
{
    partial class FormLotomania
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
            this.lbClassMania = new System.Windows.Forms.Label();
            this.lbImparMania = new System.Windows.Forms.Label();
            this.lbParMania = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabelaMania = new System.Windows.Forms.DataGridView();
            this.ORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NÚMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLimparMania = new System.Windows.Forms.Button();
            this.btGerarMania = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaMania)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClassMania
            // 
            this.lbClassMania.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassMania.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbClassMania.Location = new System.Drawing.Point(57, 256);
            this.lbClassMania.Name = "lbClassMania";
            this.lbClassMania.Size = new System.Drawing.Size(190, 97);
            this.lbClassMania.TabIndex = 54;
            this.lbClassMania.Text = "CLASSIFICAÇÃO";
            // 
            // lbImparMania
            // 
            this.lbImparMania.AutoSize = true;
            this.lbImparMania.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImparMania.ForeColor = System.Drawing.Color.Purple;
            this.lbImparMania.Location = new System.Drawing.Point(103, 200);
            this.lbImparMania.Name = "lbImparMania";
            this.lbImparMania.Size = new System.Drawing.Size(89, 20);
            this.lbImparMania.TabIndex = 53;
            this.lbImparMania.Text = "ÍMPARES";
            // 
            // lbParMania
            // 
            this.lbParMania.AutoSize = true;
            this.lbParMania.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParMania.ForeColor = System.Drawing.Color.Purple;
            this.lbParMania.Location = new System.Drawing.Point(103, 158);
            this.lbParMania.Name = "lbParMania";
            this.lbParMania.Size = new System.Drawing.Size(69, 20);
            this.lbParMania.TabIndex = 52;
            this.lbParMania.Text = "PARES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(176, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "LOTOMANIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "NÚMEROS DA SORTE";
            // 
            // tabelaMania
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Plum;
            this.tabelaMania.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaMania.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaMania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaMania.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORD,
            this.NÚMERO});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaMania.DefaultCellStyle = dataGridViewCellStyle5;
            this.tabelaMania.Location = new System.Drawing.Point(299, 63);
            this.tabelaMania.Name = "tabelaMania";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaMania.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tabelaMania.Size = new System.Drawing.Size(163, 375);
            this.tabelaMania.TabIndex = 49;
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
            // btLimparMania
            // 
            this.btLimparMania.Location = new System.Drawing.Point(47, 91);
            this.btLimparMania.Name = "btLimparMania";
            this.btLimparMania.Size = new System.Drawing.Size(200, 23);
            this.btLimparMania.TabIndex = 48;
            this.btLimparMania.Text = "LIMPAR";
            this.btLimparMania.UseVisualStyleBackColor = true;
            // 
            // btGerarMania
            // 
            this.btGerarMania.Location = new System.Drawing.Point(47, 49);
            this.btGerarMania.Name = "btGerarMania";
            this.btGerarMania.Size = new System.Drawing.Size(200, 23);
            this.btGerarMania.TabIndex = 47;
            this.btGerarMania.Text = "GERAR NÚMEROS DA SORTE";
            this.btGerarMania.UseVisualStyleBackColor = true;
            // 
            // FormLotomania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 486);
            this.Controls.Add(this.lbClassMania);
            this.Controls.Add(this.lbImparMania);
            this.Controls.Add(this.lbParMania);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabelaMania);
            this.Controls.Add(this.btLimparMania);
            this.Controls.Add(this.btGerarMania);
            this.Name = "FormLotomania";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaMania)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClassMania;
        private System.Windows.Forms.Label lbImparMania;
        private System.Windows.Forms.Label lbParMania;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tabelaMania;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NÚMERO;
        private System.Windows.Forms.Button btLimparMania;
        private System.Windows.Forms.Button btGerarMania;
    }
}