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
    public partial class Aplicacion : Form
    {
        
        Controlador cn = new Controlador();

        public Aplicacion()
        {
            InitializeComponent();
        }

        

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1002";
            navegador1.actual = this;
            navegador1.tabla = Dgv_modulos;
            TextBox[] Grupotextbox = { idapp, txtNombre, txtDescripcion, txtact };
            TextBox[] Idtextbox = { idapp, txtNombre };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(Dgv_modulos, Grupotextbox, "colchoneria");
        }

       
    }
}
