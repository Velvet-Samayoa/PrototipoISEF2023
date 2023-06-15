using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;
//Comentado por George Mayén 25/02/2023
namespace Vista_Seguridad
{
    public partial class Contrase : Form
    {
        public Contrase()
        {
            InitializeComponent();
        }

        Controlador cn = new Controlador();

        //Método que valida el usuario y contraseña del login y de acuerdo a eso muestra el formulario de cambio, en caso contrario muestra un mensaje de error
        public void autenticar()
        {
            if (cn.validarLogin(TBusuario.Text, Controlador.SetHash(TBcontrasena.Text)))
            {
                Controlador.Username = Controlador.SetHash(TBusuario.Text);
                //cn.setBtitacora("0001", "login");
                Cambio b = new Cambio();
                b.MdiParent = this;
                b.Show();
                groupBox1.Visible = false;
            } else
            {
                MessageBox.Show("NO CONCIDEN LOS DATOS");
            }
        }


        //Método que llama al método autenticar
        private void button1_Click(object sender, EventArgs e)
        {
            autenticar();
            

        }
        //Mëtodo para asignar un valor, si se ha chequeado asigna '\0', en caso contrario '*'
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // TBcontraseña.PasswordChar = '*';
                TBcontrasena.PasswordChar = '\0';
            }
            else
                       if (TBcontrasena.Text != "")
            {
                // TBcontraseña.PasswordChar = '\0';
                TBcontrasena.PasswordChar = '*';
            }
        }

        //Método que muestra el formulario de ayuda contraseña 
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AyudaContraseña b = new AyudaContraseña();
            b.Show();
        }
    }
}
