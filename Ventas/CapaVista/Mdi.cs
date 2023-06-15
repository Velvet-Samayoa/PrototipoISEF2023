using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaVista
{
    public partial class Mdi : Form
    {
        public Mdi()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Mdi_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Clientes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Vendedores());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new ReporteClientes());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
          //AbrirFormEnPanel(new ReporteClientes());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Cotizacion());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Venta());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Devolucion());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Pedido());
        }
    }
}
