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
    public partial class recuperacion : Form
    {
        public recuperacion()
        {
            InitializeComponent();
        }

        Controlador cn = new Controlador();

        //Método que se utiliza para recuperar contraseña, si los datos son correctos se efectua la recuperación
        //En case contrario muestra un mensaje en donde indica que no coinciden los datos
        public void autenticar()
        {

            if (cn.validarRecuperacion(TBusuario.Text, Controlador.SetHash(TxtRe.Text)))
            {
                Controlador.Username = Controlador.SetHash(TBusuario.Text);
                //cn.setBtitacora("0001", "login");
                //cn.setBtitacora("8000", "Recuperacion Contraseña");
                Cambio b = new Cambio();
                b.MdiParent = this;
                b.Show();
                groupBox1.Visible = false;
            } else
            {
                MessageBox.Show("No conciden los datos");
            }
        }
        //Método que retorna el método de llenarpregunta de acuerdo a lo ingresado en el textbox usuario
        public string llenap()
        {
            return cn.llenarPregunta(TBusuario.Text);
        }

        //Método que llama al método autenticar
        private void button1_Click(object sender, EventArgs e)
        {
            autenticar();
            
        }

        private void recuperacion_Load(object sender, EventArgs e)
        {

        }

        //Método que muestra la pregunta  de acuerdo al textbox usuario
        private void TBusuario_Leave(object sender, EventArgs e)
        {
            string res;
            res = llenap();
            TxtPa.Text = res;
        }

        private void TxtRe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
