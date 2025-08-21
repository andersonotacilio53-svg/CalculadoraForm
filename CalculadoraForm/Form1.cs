using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm
{
    public partial class Form1 : Form
    {
        // Variáveis globais:
        bool operadorClicado = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //implementar depois
        }

        private void numero_Click(object sender, EventArgs e)
        {
            // obter o botão que está chamando esse evento:
            Button botaoClicado = (Button)sender;

            // Adicionar o Test do botão clicado no textBox:
            txbTela.Text += botaoClicado.Text;

            // "abaixar a bandeirinha"
            operadorClicado = false;
        }
        private void operador_Click(object sender, EventArgs e)
        {
            // Verificar se o operador não foi clicado:
            if (operadorClicado == false)
            {
                // obter o botão que está chamando esse evento:
                Button botaoClicado = (Button)sender;

                // Adicionar o Test do botão clicado no textBox:
                txbTela.Text += botaoClicado.Text;

                // Mudar o operador clicado para true (levantar a bandeirinha):
                operadorClicado = true;
            }
           

        }
    }
}
