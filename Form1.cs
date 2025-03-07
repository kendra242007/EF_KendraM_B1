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
            if ((int.TryParse(textnumero1.Text, out int numero1))&&(int.TryParse(textnumero2.Text, out int numero2)))
            {
                if (numero1 < numero2 )
                {
                    MessageBox.Show("El primer numero es menor a  " + numero2);
                }
                else if (numero1 == numero2)
                {
                    MessageBox.Show("El primer numero es igual a  " + numero2);
                }
                else
                {
                    MessageBox.Show("El primer es mayor a  " + numero2);
                }
                
            }
           
              
            else
            {
                MessageBox.Show("Ingrese un valor valido");
            }
        }
    }
}
