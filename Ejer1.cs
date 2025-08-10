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
    public partial class Ejer1 : Form
    {
        public Ejer1()
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
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            label1.Text = "¡Hola, WinForms!";
            btnSaludar.Enabled = false;
        }
    }
}
