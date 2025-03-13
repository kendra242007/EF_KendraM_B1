using System;
using System.Windows.Forms;

namespace EF_KendraM_B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if ((((int.TryParse(textnumero1.Text, out int numero1))) &&(int.TryParse(textnumero2.Text, out int numero2))) &&(int.TryParse(textnumero3.Text, out int numero3)))
            {
                if ((numero1 < numero2)  && (numero1 < numero3))
                {
                    MessageBox.Show(numero1 + " es < que " + numero2 + " y es < que " + numero3);
                }
                else if ((numero1 == numero2) && (numero2 == numero3))
                {
                    MessageBox.Show(numero1 + " es = que " + numero2 + " es = que " + numero3 );
                }
                else if ((numero1 < numero2) && (numero2 > numero3))
                {
                    MessageBox.Show(numero1 +" es < que " + numero2 + " es > que " + numero3);
                }
                else if ((numero1 > numero2) && (numero2 < numero3))
                {
                    MessageBox.Show(numero1 + " es > que " + numero2 + " es < que " + numero3);
                }
                else if ((numero1 == numero2) && (numero2 > numero3))
                {
                    MessageBox.Show(numero1 + " es = que " + numero2 + " es > que " + numero3);
                }
                else if ((numero1 == numero2) && (numero2 < numero3))
                {
                    MessageBox.Show(numero1 + " es = que " + numero2 + " es < que " + numero3);
                }
                else if ((numero1 > numero2) && (numero2 == numero3))
                {
                    MessageBox.Show(numero1 + " es > que " + numero2 + " es = que " + numero3);
                }
                else if ((numero1 < numero2) && (numero2 == numero3))
                {
                    MessageBox.Show(numero1 + " es < que " + numero2 + " es = que " + numero3);
                }
                else
                {
                    MessageBox.Show(numero1 + " es > que " + numero2 + " es > que " + numero3);
                }
                
            }
           
              
            else
            {
                MessageBox.Show("Ingrese un valor valido");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
