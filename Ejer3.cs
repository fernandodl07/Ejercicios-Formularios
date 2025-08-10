using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Formularios
{
    public partial class Ejer3 : Form
    {
        Operation operation = new Operation();

        public Ejer3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtNumber1.Clear();
            txtNumber2.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formMain form1 = new formMain();
            form1.Show();
            this.Hide();
        }

        private void Ejer3_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (!operation.IsNumeric(txtNumber1.Text) && !operation.IsNumeric(txtNumber2.Text))
            {
                txtResultado.Text = ("Ingrese un numero valido");
            }
            else
            {
                double suma = operation.suma(Convert.ToInt32(txtNumber1.Text), Convert.ToInt32(txtNumber2.Text));
                txtResultado.Text = Convert.ToString(suma);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (!operation.IsNumeric(txtNumber1.Text) && !operation.IsNumeric(txtNumber2.Text))
            {
                txtResultado.Text = ("Ingrese un numero valido");
            }
            else
            {
                double suma = operation.resta(Convert.ToInt32(txtNumber1.Text), Convert.ToInt32(txtNumber2.Text));
                txtResultado.Text = Convert.ToString(suma);
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (!operation.IsNumeric(txtNumber1.Text) && !operation.IsNumeric(txtNumber2.Text))
            {
                txtResultado.Text = ("Ingrese un numero valido");
            }
            else
            {
                double suma = operation.multi(Convert.ToInt32(txtNumber1.Text), Convert.ToInt32(txtNumber2.Text));
                txtResultado.Text = Convert.ToString(suma);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double num2 = Convert.ToDouble(txtNumber2.Text);

            if (!operation.IsNumeric(txtNumber1.Text) && !operation.IsNumeric(txtNumber2.Text))
            {
                txtResultado.Text = ("Ingrese un numero valido");
            }
            else
            {
                if (num2 == 0)
                {
                    txtResultado.Text = "No se puede dividir entre cero";
                }
                else 
                {
                    double suma = operation.divi(Convert.ToInt32(txtNumber1.Text), Convert.ToInt32(txtNumber2.Text));
                    txtResultado.Text = Convert.ToString(suma);
                }
                
            }
        }
    }
}
