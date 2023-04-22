using Microsoft.VisualBasic.ApplicationServices;

namespace MenuPrincipal
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
            label1.Text = "Helo user";
        }

        public fmrMenu(string user) : this()
        {
            label1.Text = $"Hola {user}";
        }
    }
}