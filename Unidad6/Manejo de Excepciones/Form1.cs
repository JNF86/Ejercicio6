using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejo_de_Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          lblResultado.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                a = int.Parse(txtNumero1.Text);
                b = int.Parse(txtNumero2.Text);

                lblResultado.Visible = true;
                lblResultado.Text = (a + b).ToString();

            }
            catch (FormatException ex)
            {
                
                MessageBox.Show("ERROR, una de las variables ingresadas no es un mumero");
                //throw;
            }
            catch(DivideByZeroException ex) 
            {
                MessageBox.Show("No se puede dividir por 0");
            }   
            catch (OverflowException ex)
            {
                MessageBox.Show("Ha ingresado un mumero muy grande");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Comuniquese con el administrador del sistema");
            }

        }
    }
}
