namespace Ejercicios_Formularios
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEje1_Click(object sender, EventArgs e)
        {
            Ejer1 ejer1 = new Ejer1();
            ejer1.Show();
            this.Hide();
        }

        private void btnEje2_Click(object sender, EventArgs e)
        {
            Ejer2 ejer2 = new Ejer2();
            ejer2.Show();
            this.Hide();
        }

        private void btnEje3_Click(object sender, EventArgs e)
        {
            Ejer3 ejer3 = new Ejer3();
            ejer3.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
