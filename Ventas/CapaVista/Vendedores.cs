using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Vendedores : Form
    {
        public Vendedores()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2001";
            TextBox[] Grupotextbox = { txt_id, txt_dpi, txt_nombre, txt_apellido, txt_estado, txt_nit, txt_edad };
            TextBox[] Idtextbox = { txt_id, txt_dpi };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "sig");
        }

        private void Vendedores_Load(object sender, EventArgs e)
        {

        }
    }
}
