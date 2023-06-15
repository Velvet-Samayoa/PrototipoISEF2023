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
    public partial class MenuSeguridad : Form
    {

        Controlador cn = new Controlador();

        //Método que guarda en un arreglo de tipo botón los botones que se tienen en el formulario. Se les da permiso a los diferentes botones de acuerdo a la función que realice este
        public MenuSeguridad()
        {
            InitializeComponent();
            Button[] apps = { btnusuarios, btnaplicaciones, btnmodulos, button1, btnmodaplicacion, btnappperfil, btnperfilusuario, btncambiarcontra, btbitacor };
            cn.deshabilitarApps(apps);

            cn.getAccesoApp(1001, apps[0]);
            cn.getAccesoApp(1002, apps[1]);
            cn.getAccesoApp(1003, apps[2]);
            cn.getAccesoApp(1004, apps[3]);

            cn.getAccesoApp(1101, apps[4]);
            cn.getAccesoApp(1102, apps[5]);
            cn.getAccesoApp(1103, apps[6]);


            cn.getAccesoApp(1201, apps[7]);


            cn.getAccesoApp(1301, apps[8]);


        }
        
        //Validaciones que si son visibles los panales los oculta
        private void hideSubMenu()
        {
            
            if (panelTranportes.Visible == true)
                panelTranportes.Visible = false;
            if (PanelAuditoria.Visible == true)
                PanelAuditoria.Visible = false;
            if (panelseguridad.Visible == true)
                panelseguridad.Visible = false;
            if (panelayuda.Visible == true)
                panelayuda.Visible = false;
        }
        //Método que valida si el submenu no es visible oculta el submenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //Método que muestra el panel indicado
        private void btnmanteniminetos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTranportes);
        }
        //Método que muestra el panel indicado
        private void btnasignaciones_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelAuditoria);
        }
        //Método que muestra el panel indicado
        private void btnbitacora_Click(object sender, EventArgs e)
        {
            showSubMenu(panelayuda);
        }
        //Método que muestra el panel indicado
        private void btncontrase_Click(object sender, EventArgs e)
        {
            showSubMenu(panelseguridad);
        }
        //Método que muestra el formulario indicado
        private void btnusuarios_Click(object sender, EventArgs e)
        {
            Usuario b = new Usuario();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }
        //Método que muestra el formulario indicado
        private void btnaplicaciones_Click(object sender, EventArgs e)
        {
            Aplicacion b = new Aplicacion();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }
        //Método que muestra el formulario indicado
        private void btnmodulos_Click(object sender, EventArgs e)
        {
            Modulos b = new Modulos();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }
        //Método que muestra el formulario indicado
        private void button1_Click(object sender, EventArgs e)
        {
            Perfiles b = new Perfiles();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }
        //Método que muestra el formulario indicado
        private void btnmodaplicacion_Click(object sender, EventArgs e)
        {
            AsignacionModuloAplicacion b = new AsignacionModuloAplicacion();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }
        //Método que muestra el formulario indicado
        private void btnappperfil_Click(object sender, EventArgs e)
        {
            AsignacionAplicacionesPerfiles b = new AsignacionAplicacionesPerfiles();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }
        //Método que muestra el formulario indicado
        private void btnperfilusuario_Click(object sender, EventArgs e)
        {
            AsignacionPerfiles b = new AsignacionPerfiles();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btncambiarcontra_Click(object sender, EventArgs e)
        {
            Contrase b = new Contrase();
            //b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }
        //Método que muestra el formulario indicado
        private void btbitacor_Click(object sender, EventArgs e)
        {
            Bitacora b = new Bitacora();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }
        //Método que oculta el formulario

        private void btninicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Método que oculta el formulario
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Método que muestra el formulario indicado
        private void btnayuda_Click(object sender, EventArgs e)
        {
            AyudaMenuSeguridad b = new AyudaMenuSeguridad();
            b.Show();
        }

       
    }
}
