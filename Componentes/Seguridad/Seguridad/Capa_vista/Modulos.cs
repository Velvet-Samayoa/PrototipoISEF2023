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
    public partial class Modulos : Form
    {
       

        Controlador cn = new Controlador();

        public Modulos()
        {
            InitializeComponent();
        }

        
        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1003";
            navegador1.actual = this;
            navegador1.tabla = Dgv_modulos;
            TextBox[] Grupotextbox = { txtIdModulo, txtNombre, txtDescripcion, txtact };
            TextBox[] Idtextbox = { txtIdModulo, txtNombre };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(Dgv_modulos, Grupotextbox, "colchoneria");
        }
    }
}
