using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2___Aula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string cpf = tx_cpf.Text;
            int idade = Convert.ToInt32(tx_idade.Text);
            double altura = Convert.ToDouble(tx_altura.Text);
            double peso = Convert.ToDouble(tx_peso.Text);
            string sexo = tx_sexo.Text;
            Pessoa p = new Pessoa (nome, cpf, idade, sexo, peso, altura);
            (double a, string b, string c) = p.CalcularIMC();
            tx_resultado.Text = $"O IMC é {a.ToString("0.00")} \n Classificação: {b} \n Grau: {c}";
            bool resultCPF = Validacoes.ValidaCPF(cpf);
            MessageBox.Show(resultCPF.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tx_resultado_Click(object sender, EventArgs e)
        {

        }

        private void tx_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
