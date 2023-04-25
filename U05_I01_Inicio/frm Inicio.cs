using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using System.Windows.Forms;
using U05_I01_Saludar;

namespace U05_I01_Inicio
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            
            // Establecer la apariencia del borde y la barra de título del formulario
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            // Establecer si el formulario tiene un botón de minimizar
            this.MinimizeBox = false; 
            // Establecer si el formulario tiene un botón de maximizar
            this.MaximizeBox = false; 
            // Establecer la posición del formulario al aparecer por primera vez
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_Saludar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_Nombre.Text;
            string apellido = this.txt_Apellido.Text;
            string materia = cbx_MeteriaFavorita.SelectedItem.ToString();

            if (Validar())
            {
                frmSaludar saludo = new frmSaludar(nombre, apellido, materia);
                saludo.Show(); // Muestra
                this.Hide(); // Oculta, no lo Elimina!!
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            cbx_MeteriaFavorita.Items.Add("Programacion I");
            cbx_MeteriaFavorita.Items.Add("Laboratorio de Computacion I");
            cbx_MeteriaFavorita.Items.Add("Ingles I");
            cbx_MeteriaFavorita.Items.Add("Sistema de Procesamiento de Datos");
            cbx_MeteriaFavorita.Items.Add("Matematicas");
            cbx_MeteriaFavorita.Items.Add("Programacion II");
            cbx_MeteriaFavorita.Items.Add("Laboratorio de Computacion II");
            cbx_MeteriaFavorita.Items.Add("Ingles II");
            cbx_MeteriaFavorita.Items.Add("Estadistica");
            cbx_MeteriaFavorita.Items.Add("Arquitectura y Sistemas Operativos");
            cbx_MeteriaFavorita.Items.Add("Metodologia de la investigacion");
            cbx_MeteriaFavorita.SelectedIndex = 0;
        }

        private bool Validar()
        {
            bool validar = true;

            StringBuilder anuncio = new StringBuilder();
            anuncio.AppendLine("Debe de completar los siguientes campos: ");

            if (string.IsNullOrWhiteSpace(txt_Nombre.Text)) // Verifico que no devuelva null 
            {
                validar = false;
                anuncio.AppendLine("            ( ! ) Nombre");
            }
            if (string.IsNullOrWhiteSpace(txt_Apellido.Text)) // Verifico que no devuelva null 
            {
                validar = false;
                anuncio.AppendLine("            ( ! ) Apellido");
            }

            if (!validar) // Verifico que no devuelva null 
            {
                // Muestra mensaje, titulo, con un icono de error y un botón "OK" para cerrar la ventana.
                MessageBox.Show(anuncio.ToString(), "( ! ) ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return validar;
        }



    }
}   