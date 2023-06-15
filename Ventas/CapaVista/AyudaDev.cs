using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas_CapaControlador;

namespace CapaVista
{
    public partial class AyudaDev : Form
    {
        Controlador cn = new Controlador();
        string table;
        TextBox txtIdVenta, txtIdAlmacen, txtOrden, txtIdProducto;
        public AyudaDev(string tabla, TextBox txtIdVenta, TextBox txtIdAlmacen, TextBox txtOrden, TextBox txtIdProducto)
        {
            InitializeComponent();
            table = tabla;
            this.txtIdVenta = txtIdVenta;
            this.txtIdAlmacen = txtIdAlmacen;
            this.txtOrden = txtOrden;
            this.txtIdProducto = txtIdProducto;
        }
        public DataGridView tabla;


        private void button1_Click(object sender, EventArgs e)
        {
            tabla = dataGridView1;
            cn.fillTable(tabla.Tag.ToString(), dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                txtIdVenta.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtIdAlmacen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (dataGridView1.CurrentCell != null)
                {
                    //txtIdTipo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    //txtNombreTipo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    this.Close();
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabla = dataGridView2;
            cn.fillTable(tabla.Tag.ToString(), dataGridView2);
        }
    }
}
