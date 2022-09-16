using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace OperadoresAritmeticos
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(TxbNumero1.Text);
            int numero2 = Convert.ToInt32(TxbNumero2.Text);
            int resultado = numero1 + numero2;
            txbResultado.Text = resultado.ToString();           
            
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(TxbNumero1.Text);
            int numero2 = Convert.ToInt32(TxbNumero2.Text);
            //int resultado = numero1 - numero2;
            //txbResultado.Text = resultado.ToString();
            txbResultado.Text = Subtrair(numero1,numero2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(TxbNumero1.Text);
            int numero2 = Convert.ToInt32(TxbNumero2.Text);           
            txbResultado.Text = Multiplicar(numero1, numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(TxbNumero1.Text);
            int numero2 = Convert.ToInt32(TxbNumero2.Text);
            numero1 /= numero2;
            txbResultado.Text = numero1.ToString();
        }

        int Subtrair (int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }
        int Multiplicar (int nume1, int nume2) 
        {
            nume1 *= nume2;
            return nume1;
        }

    }
}
