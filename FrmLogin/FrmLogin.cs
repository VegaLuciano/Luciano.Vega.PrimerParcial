using Tools;
using Entidades;
using Forms;

namespace FrmLogin
{
    public partial class FrmLogin : Form
    {
        private Usuario usuario;
        private List<Usuario> usuariosRegistrados;
        private string pathUsuariosRegistrados = "usuarios.json";
        public FrmLogin()
        {
            InitializeComponent();
            this.usuario = new Usuario();
            this.usuariosRegistrados = new List<Usuario>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblError.Text = string.Empty;
            this.CargarUsuarios();
            
        }


        /// <summary>
        /// Levanta la lista de usuarios guardad en el archivo .json, si hay algun error, muestra un messagebox
        /// </summary>
        public void CargarUsuarios()
        {
            List<Usuario>? listAux = Archivo.LeerArchivoJson<Usuario>(this.pathUsuariosRegistrados);
            if (listAux != null)
            {
                this.usuariosRegistrados = listAux;
                MessageBox.Show("Se cargo la wea");
            }
            else
            {
                MessageBox.Show("Error al Leer los usuarios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.lblError.Text = "No podrá iniciar seción";
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuarioAux = new Usuario(this.txtMail.Text, this.txtContraseña.Text);

            int indexUser = Usuario.FindUser(usuarioAux, this.usuariosRegistrados);
            if (indexUser != -1)
            {
                this.usuario = this.usuariosRegistrados[indexUser];
                FrmMenuPrincipal1 frmMenuPrincipal = new FrmMenuPrincipal1(this.usuariosRegistrados, this.usuario);
                frmMenuPrincipal.Show();
                //this.Close();
            }
            else
            {
                this.lblError.Text = "Error, contraseña o mail incorrectos";
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistrarse frmRegistrarse = new FrmRegistrarse(this.usuariosRegistrados);
            frmRegistrarse.ShowDialog();
        }
    }
}