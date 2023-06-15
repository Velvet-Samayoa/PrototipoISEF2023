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
    public partial class AsignacionAplicacion : Form
    {
        string table = "tbl_permisosaplicacionesusuario";

        Controlador cn = new Controlador();

        public AsignacionAplicacion()
        {
            InitializeComponent();
        }

      

        //Método que valida si los checkbox se han chequeado, el textbox de este se muestra en 1, en caso contrario se muestra en 0
        public void checks()
        {
            if (chBoxGuardar.Checked) { txtGuardar.Text = "1"; } else { txtGuardar.Text = "0"; }
            if (chBoxEliminar.Checked) { txtEliminar.Text = "1"; } else { txtEliminar.Text = "0"; }
            if (chBoxModificar.Checked) { txtModificar.Text = "1"; } else { txtModificar.Text = "0"; }
            if (chBoxBuscar.Checked) { txtBuscar.Text = "1"; } else { txtBuscar.Text = "0"; }
            if (chBoxImprimir.Checked) { txtImprimir.Text = "1"; } else { txtImprimir.Text = "0"; }
        }
        
        //Método que actualiza el datagridview de acuerdo al id del usuario
        public void actualizardatagriew()
        {
            string idUsuario = txtIdUsuario.Text;
            cn.llenarListApliUsuariosstring(ListaAsiganacion.Tag.ToString(), ListaAsiganacion,idUsuario);
        }

        //Método que obtiene las aplicaciones del perfil de acuerdo al textbox de perfil que se ingrese 
        public void getIds()
        {
            try
            {
                string dato;
                dato = listAplicacionesDB.CurrentCell.Value.ToString();
                if (txtCadenas.Text == "")
                {
                    txtCadenas.Text = dato;
                }
                else
                {
                    string valor = txtCadenas.Text;
                    txtCadenas.Text = valor + "," + dato;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
        }

        //Método que obtiene las aplicaciones del perfil de acuerdo al textbox de perfil que se ingrese 
        public void getIds2()
        {
            try
            {
                string dato;
                dato = ListUsuarios.CurrentCell.Value.ToString();
                txtIdUsuario.Text = dato;
                            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
        }

        //Método que ingresa los registros de acuerdo al id de la aplicación
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtIdUsuario.Text == "" || txtCadenas.Text == "" || txtIdAplicacion.Text == "")
            {
                MessageBox.Show("Porfavor llene los campos necesarios");
            }
            else
            {
                checks();
                char[] delimiterChars = { ',' };
                string text = txtCadenas.Text;
                string[] words = text.Split(delimiterChars);

                foreach (var word in words)
                {
                    txtIdAplicacion.Text = word;
                    TextBox[] textbox = { txtIdUsuario, txtIdAplicacion, txtGuardar, txtEliminar, txtModificar, txtBuscar, txtImprimir };
                    cn.ingresar(textbox, table);
                }
                string message = "Registro Guardado";
                actualizardatagriew();
                MessageBox.Show(message);
                listAplicacionesDB.Visible = false;
                Size = new Size(672, 466);
                CheckBox[] checkBoxes = { chBoxGuardar, chBoxModificar, chBoxEliminar, chBoxBuscar, chBoxImprimir };
                cn.limpiarCheckbox(checkBoxes);
                TextBox[] textBoxes = { txtBuscar, txtEliminar, txtGuardar, txtIdAplicacion, txtIdUsuario, txtImprimir, txtModificar, txtCadenas };
                cn.limpiarTextbox(textBoxes);
            }
        }

        //Método que chequea todos los checkbox
        private void button2_Click(object sender, EventArgs e)
        {
            CheckBox[] checkBoxes = { chBoxGuardar, chBoxModificar, chBoxEliminar, chBoxBuscar, chBoxImprimir };
            cn.marcarCheckbox(checkBoxes);
        }

        //Método que llena las lsitas de las aplicaciones, usuarios
        private void AsignacionAplicacion_Load(object sender, EventArgs e)
        {
            cn.llenarListAplicaciones(listAplicacionesDB.Tag.ToString(), listAplicacionesDB);
            cn.llenarListUsuarios(ListUsuarios.Tag.ToString(), ListUsuarios);
            ListUsuarios.Visible = false;
            listAplicacionesDB.Visible = false;
            Size = new Size(672,466);
            TextBox[] textBoxes = { txtBuscar, txtEliminar, txtGuardar, txtImprimir, txtModificar, txtIdAplicacion };
            cn.desabilitarTextbox(textBoxes);
            ListUsuarios.Visible = false;
        }

        //Método que llama al método actualizardatagridview
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //limpiar();
            actualizardatagriew();
        }
        //Método que hace visible la lista de aplicaciones
        private void button2_Click_1(object sender, EventArgs e)
        {
            ListUsuarios.Visible = false;
            /*1062; 466*/
            if (listAplicacionesDB.Visible == false)
            {
                listAplicacionesDB.Visible = true;
                Size = new Size(1062, 466);
            }
            else
            {
                listAplicacionesDB.Visible = false;
                Size = new Size(672, 466);
            }
            
        }
        //Método que llama al método getIds
        private void listAplicacionesDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getIds();
        }
        //Método que hace visible las listas de las aplicaciones
        private void button3_Click(object sender, EventArgs e)
        {
            listAplicacionesDB.Visible = false;
            if (ListUsuarios.Visible == false)
            {
                ListUsuarios.Visible = true;
                Size = new Size(1062, 466);
            }
            else
            {
                ListUsuarios.Visible = false;
                Size = new Size(672, 466);
            }
        }
        //Método que llama al método de getIds2
        private void ListUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getIds2();
        }
        //Método que muestra el formulario indicado
        private void button6_Click(object sender, EventArgs e)
        {
            AyudaAsignacionAplicacionUsuarios b = new AyudaAsignacionAplicacionUsuarios();
            b.Show();
        }

        private void chBoxGuardar_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
