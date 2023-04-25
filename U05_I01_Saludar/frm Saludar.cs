using System.Windows.Forms;

namespace U05_I01_Saludar
{
    public partial class frmSaludar : Form
    {
        public frmSaludar()
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

        public frmSaludar(string nombre, string apellido, string materia) : this () 
        {
            lb_Saludo.Text = $"Soy {nombre} {apellido} y mi materia favorita es {materia}.";
        }
       

    }
}