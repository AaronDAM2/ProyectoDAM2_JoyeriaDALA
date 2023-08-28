using JoyeriaDALA_EscritorioWinForms.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyeriaDALA_EscritorioWinForms.Formularios
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text==null || txtUser.Text ==" ") {
                MessageBox.Show("Rellena el nombre de usuario");
            }
            if (txtPass.Text == null || txtPass.Text == " ")
            {
                MessageBox.Show("Rellena la contraseña");
            }
            string username=txtUser.Text;
            string pass=txtPass.Text;
            if(await Herramientas.Login(username, pass))
            {
                Form1 inicio=new Form1();
                inicio.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private async void LoginFrm_Load(object sender, EventArgs e)
        {
            var users = new List<Usuario>();
            users= await Herramientas.GetUsuariosAsync();
            if(users==null||users.Count==0)
            {
               if (MessageBox.Show("Parece que no hay usuarios registrados. tal vez sea tu primera instalación. ¿Quieres agregar datos a la base de datos? Podrás modificarlos después", "Agregar Datos", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    await Herramientas.InicializarDB();
                    MessageBox.Show("Datos añadidos. Puedes acceder usando las credenciales admin/admin. Asegurate de crear tu propia cuenta al iniciar");
                }
            }

            if (await Herramientas.GetTiposProductoAsync() == null)
            {
                MessageBox.Show("Error al comunicar con la API. Asegurate de que esté conectada");
            }
        }
    }
}
