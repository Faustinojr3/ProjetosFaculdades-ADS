namespace Atividade_04_05_2022
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Altura = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtPeso = new TextBox();
            txtCPF = new MaskedTextBox();
            btCalcular = new Button();
            txtSexo = new ComboBox();
            label2 = new Label();
            label6 = new Label();
            txtAltura = new MaskedTextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 63);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // Altura
            // 
            Altura.AutoSize = true;
            Altura.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Altura.Location = new Point(536, 95);
            Altura.Name = "Altura";
            Altura.Size = new Size(42, 17);
            Altura.TabIndex = 1;
            Altura.Text = "Altura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 87);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 3;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 124);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 4;
            label4.Text = "Sexo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 156);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 5;
            label5.Text = "Idade";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(113, 58);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 6;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(113, 156);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 8;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPeso.Location = new Point(328, 115);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(68, 39);
            txtPeso.TabIndex = 10;
            txtPeso.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(113, 87);
            txtCPF.Mask = "999,999,999-99";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 23);
            txtCPF.TabIndex = 12;
            // 
            // btCalcular
            // 
            btCalcular.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btCalcular.Location = new Point(402, 171);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(103, 56);
            btCalcular.TabIndex = 14;
            btCalcular.Text = "Calcular ";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // txtSexo
            // 
            txtSexo.FormattingEnabled = true;
            txtSexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Outros(as)" });
            txtSexo.Location = new Point(113, 124);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(100, 23);
            txtSexo.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(328, 95);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 2;
            label2.Text = "Peso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(402, 132);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 16;
            label6.Text = "Kg";
            label6.Click += label6_Click;
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltura.Location = new Point(536, 118);
            txtAltura.Mask = "9.99";
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(46, 39);
            txtAltura.TabIndex = 17;
            txtAltura.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(450, 123);
            label7.Name = "label7";
            label7.Size = new Size(22, 30);
            label7.TabIndex = 18;
            label7.Text = "/";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(509, 123);
            label8.Name = "label8";
            label8.Size = new Size(21, 30);
            label8.TabIndex = 19;
            label8.Text = "(";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(606, 123);
            label9.Name = "label9";
            label9.Size = new Size(21, 30);
            label9.TabIndex = 20;
            label9.Text = ")";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(621, 106);
            label10.Name = "label10";
            label10.Size = new Size(15, 17);
            label10.TabIndex = 21;
            label10.Text = "2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(433, 49);
            label11.Name = "label11";
            label11.Size = new Size(53, 30);
            label11.TabIndex = 22;
            label11.Text = "IMC";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(582, 142);
            label12.Name = "label12";
            label12.Size = new Size(18, 15);
            label12.TabIndex = 23;
            label12.Text = "m";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(70, 9);
            label13.Name = "label13";
            label13.Size = new Size(179, 30);
            label13.TabIndex = 24;
            label13.Text = "Dados Cadastrais";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 239);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtAltura);
            Controls.Add(label6);
            Controls.Add(txtSexo);
            Controls.Add(btCalcular);
            Controls.Add(txtCPF);
            Controls.Add(txtPeso);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Altura);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Altura;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtPeso;
        private MaskedTextBox txtCPF;
        private Button btCalcular;
        private ComboBox txtSexo;
        private Label label2;
        private Label label6;
        private MaskedTextBox txtAltura;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}