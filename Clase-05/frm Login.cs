using MenuPrincipal;

namespace Clase_05
{
    public partial class Form1 : Form
    {
        // LOGICA DE LA APLICACION
        public Form1()
        {
            InitializeComponent(); // constructor
        }

        private void button_Click(object sender, EventArgs e)
        {
            // User: Marcos 
            // Password: AAA222

            string user = this.txbUser.Text;
            string password = this.txbPassword.Text;

            // MessageBox.Show(user); 
            if (user == "Marcos" && password == "AAA222")
            {
                fmrMenu menu = new fmrMenu(user);
                menu.Show(); // Muestra
                this.Hide(); // Oculta, no lo Elimina!!
            }
            else
            {
                MessageBox.Show("User invalido");
            }

        }

        private void chkMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarContraseña.Checked)
            {
                txbPassword.PasswordChar = '\0';
            }
            else
            {
                txbPassword.PasswordChar = '*';
            }
        }
    }
}