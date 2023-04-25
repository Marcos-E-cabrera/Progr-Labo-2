namespace U05_I01_Saludar
{
    public partial class frmSaludar : Form
    {
        public frmSaludar()
        {
            InitializeComponent();
        }

        public frmSaludar(string nombre, string apellido) : this () 
        {
            lb_Saludo.Text = $"Soy {nombre} {apellido}.";
        }
    }
}