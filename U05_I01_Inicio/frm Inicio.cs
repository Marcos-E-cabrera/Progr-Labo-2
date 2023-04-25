using Microsoft.VisualBasic.ApplicationServices;
using U05_I01_Saludar;

namespace U05_I01_Inicio
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Saludar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_Nombre.Text;
            string apellido = this.txt_Apellido.Text;

            frmSaludar saludo = new frmSaludar(nombre, apellido);
            saludo.Show(); // Muestra
            this.Hide(); // Oculta, no lo Elimina!!
        }
    }
}