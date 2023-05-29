namespace _2___Aula
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_idade = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_peso = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_sexo = new System.Windows.Forms.ComboBox();
            this.tx_altura = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tx_resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tx_idade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_altura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(248, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(241, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(398, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo:";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(288, 152);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(262, 20);
            this.tx_nome.TabIndex = 5;
            this.tx_nome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tx_idade
            // 
            this.tx_idade.Location = new System.Drawing.Point(288, 207);
            this.tx_idade.Name = "tx_idade";
            this.tx_idade.Size = new System.Drawing.Size(104, 20);
            this.tx_idade.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(245, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Altura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(241, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "IMC";
            // 
            // tx_peso
            // 
            this.tx_peso.DecimalPlaces = 2;
            this.tx_peso.Location = new System.Drawing.Point(288, 234);
            this.tx_peso.Name = "tx_peso";
            this.tx_peso.Size = new System.Drawing.Size(262, 20);
            this.tx_peso.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(244, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Peso:";
            // 
            // tx_sexo
            // 
            this.tx_sexo.FormattingEnabled = true;
            this.tx_sexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.tx_sexo.Location = new System.Drawing.Point(438, 207);
            this.tx_sexo.Name = "tx_sexo";
            this.tx_sexo.Size = new System.Drawing.Size(112, 21);
            this.tx_sexo.TabIndex = 14;
            // 
            // tx_altura
            // 
            this.tx_altura.DecimalPlaces = 2;
            this.tx_altura.Location = new System.Drawing.Point(288, 260);
            this.tx_altura.Name = "tx_altura";
            this.tx_altura.Size = new System.Drawing.Size(262, 20);
            this.tx_altura.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_cpf
            // 
            this.tx_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_cpf.Location = new System.Drawing.Point(288, 181);
            this.tx_cpf.Mask = "000,000,000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(262, 20);
            this.tx_cpf.TabIndex = 18;
            this.tx_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tx_cpf_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "label9";
            // 
            // tx_resultado
            // 
            this.tx_resultado.AutoSize = true;
            this.tx_resultado.BackColor = System.Drawing.Color.Black;
            this.tx_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_resultado.ForeColor = System.Drawing.SystemColors.Control;
            this.tx_resultado.Location = new System.Drawing.Point(384, 323);
            this.tx_resultado.Name = "tx_resultado";
            this.tx_resultado.Size = new System.Drawing.Size(48, 15);
            this.tx_resultado.TabIndex = 21;
            this.tx_resultado.Text = "label10";
            this.tx_resultado.Click += new System.EventHandler(this.tx_resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_resultado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_altura);
            this.Controls.Add(this.tx_sexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx_peso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_idade);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tx_idade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_altura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.NumericUpDown tx_idade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown tx_peso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tx_sexo;
        private System.Windows.Forms.NumericUpDown tx_altura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label tx_resultado;
    }
}

