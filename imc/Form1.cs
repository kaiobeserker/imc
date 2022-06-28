using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttoncalcular_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);

            double resultado= n1/ (n2 *n2);

            labelresultcal.Text = resultado.ToString();

          if (resultado >= 18.6 && resultado <= 24.9)
            {
                labelcondicao.Text = "Saudavel";
            } 
          else if(resultado >= 25.0 && resultado <= 29.9)
            {
                labelcondicao.Text = "Levemente acima do peso ";
            }
          else if(resultado >= 30.0 && resultado <=34.9)
            {
                labelcondicao.Text = "obesidade grau 1";
            }
            else if (resultado >= 35.0 && resultado <= 39.9)
            {
                labelcondicao.Text = "obesidade grau 2";
            }
            else if (resultado >= 40)
            {
                labelcondicao.Text = "obesidade grau 3";
            }
            else if (resultado <= 18.5)
            {
                labelcondicao.Text = "abaixo do peso";
            }

        }

        private void labelIMcresult_Click(object sender, EventArgs e)
        {

        }
    }   
}
