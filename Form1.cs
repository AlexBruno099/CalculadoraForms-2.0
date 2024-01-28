using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms2
{

    public partial class Calculadora : Form
    {
        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool porcentagem = false;
        bool resultado = false;
        public Calculadora()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.Gray;
            TxtResultado.Text += "1";
            txtOperacao.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.Gray;
            TxtResultado.Text += "2";
            txtOperacao.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.Gray;
            TxtResultado.Text += "3";
            txtOperacao.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button4.BackColor = System.Drawing.Color.Gray;
            TxtResultado.Text += "4";
            txtOperacao.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button5.BackColor = System.Drawing.Color.Gray;
            TxtResultado.Text += "5";
            txtOperacao.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.BackColor = System.Drawing.Color.Gray;
            TxtResultado.Text += "6";
            txtOperacao.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.button7.BackColor = System.Drawing.Color.Gray;
            TxtResultado.Text += "7";
            txtOperacao.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.button8.BackColor = System.Drawing.Color.Gray;
            TxtResultado.Text += "8";
            txtOperacao.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.button9.BackColor = System.Drawing.Color.Gray;
            TxtResultado.Text += "9";
            txtOperacao.Text += "9";
        }
        private void virgula_Click(object sender, EventArgs e)
        {
            this.button0.BackColor = System.Drawing.Color.Gray;
            TxtResultado.Text += ",";
            txtOperacao.Text += ",";

        }

        private void button0_click(object sender, EventArgs e)
        {
            this.button0.BackColor = System.Drawing.Color.Gray;
            TxtResultado.Text += "0";
            txtOperacao.Text += "0";
        }

        private void Adicao_Click(object sender, EventArgs e)
        {
            this.button0.BackColor = System.Drawing.Color.Gray;
            try
            {
                calculo = Convert.ToDecimal(TxtResultado.Text);
                txtOperacao.Text += "+";
                TxtResultado.Text = "";

                adicao = true;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
            }
            catch
            {
                MessageBox.Show("Operação incorreta");
            }
        }

        private void Subtracao_Click(object sender, EventArgs e)
        {
            this.button0.BackColor = System.Drawing.Color.Gray;
            try
            {
                calculo = Convert.ToDecimal(TxtResultado.Text);
                txtOperacao.Text += "-";
                TxtResultado.Text = "";

                adicao = false;
                subtracao = true;
                multiplicacao = false;
                divisao = false;
            }
            catch
            {
                MessageBox.Show("Operação incorreta");
            }
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            this.button0.BackColor = System.Drawing.Color.Gray;
            try
            {
                calculo = Convert.ToDecimal(TxtResultado.Text);
                txtOperacao.Text += "X";
                TxtResultado.Text = "";

                adicao = false;
                subtracao = false;
                multiplicacao = true;
                divisao = false;
            }
            catch
            {
                MessageBox.Show("Operação incorreta");
            }
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            this.button0.BackColor = System.Drawing.Color.Gray;
            try
            {
                calculo = Convert.ToDecimal(TxtResultado.Text);
                txtOperacao.Text += "÷";
                TxtResultado.Text = "";

                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = true;
            }
            catch
            {
                MessageBox.Show("Operação incorreta");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = string.Empty;
            TxtResultado.Text = string.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Resultado_Click(object sender, EventArgs e)
        {
            resultado = true;

            txtOperacao.Text += "=";

            if (adicao == true)
            {
                TxtResultado.Text = Convert.ToString(Convert.ToDecimal(TxtResultado.Text) + calculo);
                txtOperacao.Text = TxtResultado.Text;
            }

            if (subtracao == true)
            {
                TxtResultado.Text = Convert.ToString(Convert.ToDecimal(TxtResultado.Text) - calculo);

                txtOperacao.Text += TxtResultado.Text;
            }


            if (multiplicacao == true)
            {
                TxtResultado.Text = Convert.ToString(Convert.ToDecimal(TxtResultado.Text) * calculo);

                txtOperacao.Text += TxtResultado.Text;
            }


            if (divisao == true)
            {
                TxtResultado.Text = Convert.ToString(calculo / Convert.ToDecimal(TxtResultado.Text));

                txtOperacao.Text += TxtResultado.Text;
            }



            else if (porcentagem == true)
            {
                TxtResultado.Text = Convert.ToString((Convert.ToDecimal(TxtResultado.Text) / 100) * calculo);

            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string Apagar = TxtResultado.Text;

                    Apagar = Apagar.Remove(Apagar.Length - 1);

                    TxtResultado.Text = Apagar;

                    txtOperacao.Text = Apagar;
                }

                catch (Exception)
                {

                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Double.Parse(TxtResultado.Text);
                TxtResultado.Text = Convert.ToString(valor / 100);
                txtOperacao.Text += " %";
            }
            catch (Exception)
            {

            }
        }
    }
}
