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
        public Ejer3()
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

        private void Ejer3_Load(object sender, EventArgs e)
        {

        }
    }
}
