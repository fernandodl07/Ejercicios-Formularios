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
    public partial class Ejer2 : Form
    {
        ErrorProvider errorProvider = new ErrorProvider
            {
                BlinkStyle = ErrorBlinkStyle.NeverBlink // no intrusivo
            };


        public Ejer2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        

    private void btnBack_Click(object sender, EventArgs e)
        {
            formMain form1 = new formMain();
            form1.Show();
            this.Hide();
        }

        private void Ejer2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor;
            if (!double.TryParse(txtTempera.Text, out valor))
            {
                errorProvider.SetError(txtTempera, "Ingresa un número válido");
                return;
            }
            errorProvider.SetError(txtTempera, "");

            double resultado;
            if (cbxTemp.SelectedIndex == 0) // C a F
                resultado = (valor * 9 / 5) + 32;
            else // F a C
                resultado = (valor - 32) * 5 / 9;

            txtValor.Text = "El resultado es: " + resultado.ToString("F2");
        }
    }
}
