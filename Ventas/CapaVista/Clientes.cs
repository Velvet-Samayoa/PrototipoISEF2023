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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        

        

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2101";
            TextBox[] Grupotextbox = { txt_id, txt_dpi, txt_nombre, txt_apellido, txt_fechanac, txt_nit, txt_estado, txt_direccion, txt_telefono, txt_vendedor, txt_smesanterior,txt_saldoactual,txt_cargomes,txt_abonomes,txt_cargosacum,txt_abonosacum };
            TextBox[] Idtextbox = { txt_id, txt_dpi };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "sig");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAyudaClientes ayudaClientes = new MenuAyudaClientes();
            ayudaClientes.Show();
        }
    }
}
