using System.Windows.Forms;

namespace U05_I01_Saludar
{
    public partial class frmSaludar : Form
    {
        public frmSaludar()
        {
            InitializeComponent();
            // Establecer la apariencia del borde y la barra de t�tulo del formulario
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Establecer si el formulario tiene un bot�n de minimizar
            this.MinimizeBox = false;
            // Establecer si el formulario tiene un bot�n de maximizar
            this.MaximizeBox = false;
            // Establecer la posici�n del formulario al aparecer por primera vez
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frmSaludar(string nombre, string apellido, string materia) : this () 
        {
            lb_Saludo.Text = $"Soy {nombre} {apellido} y mi materia favorita es {materia}.";
        }
       

    }
}