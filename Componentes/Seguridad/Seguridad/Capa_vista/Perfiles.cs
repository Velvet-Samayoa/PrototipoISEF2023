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
    public partial class Perfiles : Form
    {

        Controlador cn = new Controlador();

        public Perfiles()
        {
            InitializeComponent();
        }
        

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1003";
            navegador1.actual = this;
            navegador1.tabla = Dgv_perfiles;
            TextBox[] Grupotextbox = { txtIdPerfiles, txtNombre, txtDescripcion, txtEstado };
            TextBox[] Idtextbox = { txtIdPerfiles, txtNombre };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(Dgv_perfiles, Grupotextbox, "colchoneria");
        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
