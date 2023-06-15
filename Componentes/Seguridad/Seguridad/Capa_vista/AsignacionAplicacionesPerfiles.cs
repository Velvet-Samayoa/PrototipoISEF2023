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
    public partial class AsignacionAplicacionesPerfiles : Form
    {
        string table = "tbl_permisosaplicacionperfil";

        Controlador cn = new Controlador();

        public AsignacionAplicacionesPerfiles()
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
        
      
        //Método que obtiene las aplicaciones del perfil de acuerdo al textbox de cadenas que se ingrese 
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

        //Método que obtiene las aplicaciones del perfil de acuerdo al id textbox de perfil que se ingrese 
        public void getId()
        {
            try
            {
                string dato;
                dato = ListaPerfil.CurrentCell.Value.ToString();
                txtIdPerfil.Text = dato;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
        }
        //Método que actualiza el datagridview de acuerdo al id de los perfiles
        public void actualizardatagriew()
        {
            string id = txtIdPerfil.Text;
            cn.llenarListApliUsuariosstring(listAplicacionPerfil.Tag.ToString(), listAplicacionPerfil, id);
        }
        //Método que oculta el formulario
        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
        //Método que ingresa los registros de acuerdo al id de la aplicación
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtIdPerfil.Text == "" || txtCadenas.Text == "")
            {
                MessageBox.Show("Porfavor llene todos los campos");
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
                TextBox[] textbox = { txtIdPerfil, txtIdAplicacion, txtGuardar, txtEliminar, txtModificar, txtBuscar, txtImprimir };
                cn.ingresar(textbox, table);
            }
            string message = "Registro Guardado";
            actualizardatagriew();
            CheckBox[] checkBoxes = { chBoxGuardar, chBoxModificar, chBoxEliminar, chBoxBuscar, chBoxImprimir };
            cn.limpiarCheckbox(checkBoxes);
            TextBox[] textBoxes = { txtBuscar, txtEliminar, txtGuardar, txtIdAplicacion, txtIdPerfil,  txtImprimir, txtModificar, txtCadenas };
            cn.limpiarTextbox(textBoxes);
            MessageBox.Show(message);
            cn.setBtitacora("1102", "Asigno Aplicacion-Perfil");
            Size = new Size(623, 455);
            }
        }
        //Método que llena las lsitas de las aplicaciones, usuarios
        private void AsignacionAplicacionesPerfiles_Load(object sender, EventArgs e)
        {
            cn.llenarListAplicaciones(listAplicacionesDB.Tag.ToString(), listAplicacionesDB);
            cn.llenarListPerfiles(ListaPerfil.Tag.ToString(), ListaPerfil);
            Size = new Size(623, 455);
            txtBuscar.Visible = false;
            txtEliminar.Visible = false;
            txtGuardar.Visible = false;
            txtImprimir.Visible = false;
            txtModificar.Visible = false;
            txtIdAplicacion.Visible = false;
            TextBox[] textBoxes = { txtBuscar, txtEliminar, txtGuardar, txtIdAplicacion, txtImprimir, txtModificar };
            cn.desabilitarTextbox(textBoxes);
            
        }
        //Método que actualiza el datagridview de acuerdo al id del perfil
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            string texto = txtIdPerfil.Text;
            if(texto == "")
            {
                string message = "Debe Ingresar un ID Perfil";
                MessageBox.Show(message);
            }
            else
            {
                actualizardatagriew();
                CheckBox[] checkBoxes = { chBoxGuardar, chBoxModificar, chBoxEliminar, chBoxBuscar, chBoxImprimir };
                cn.limpiarCheckbox(checkBoxes);
                TextBox[] textBoxes = { txtBuscar, txtEliminar, txtGuardar, txtIdAplicacion, txtIdPerfil, txtImprimir, txtModificar, txtCadenas };
                cn.limpiarTextbox(textBoxes);
            }
            
        }
        //Método que chequea todos los checkbox
        private void btnAll_Click(object sender, EventArgs e)
        {
            CheckBox[] checkBoxes = { chBoxGuardar, chBoxModificar, chBoxEliminar, chBoxBuscar, chBoxImprimir };
            cn.marcarCheckbox(checkBoxes);
        }
        //Método que llama al método getIds
        private void listAplicacionesDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getIds();
        }
        //Método que hace visible la lista de aplicaciones
        private void button2_Click(object sender, EventArgs e)
        {
            ListaPerfil.Visible = false;
            /*994; 455*/
            if (listAplicacionesDB.Visible == false)
            {
                listAplicacionesDB.Visible = true;
                Size = new Size(994, 455);
            }
            else
            {
                //623; 455
                listAplicacionesDB.Visible = false;
                Size = new Size(623, 455);
            }
        }
        //Método que hace visible la lista de aplicaciones
        private void button1_Click(object sender, EventArgs e)
        {
            listAplicacionesDB.Visible = false;
            /*994; 455*/
            if (ListaPerfil.Visible == false)
            {
                ListaPerfil.Visible = true;
                Size = new Size(994, 455);
            }
            else
            {
                //623; 455
                ListaPerfil.Visible = false;
                Size = new Size(623, 455);
            }
        }
        //Método que llama al método getId
        private void ListaPerfil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getId();
        }
        //Método que muestra un mensaje de eliminación y si se responde con si, elimina el registro de acuerdo al perfil 
        private void listAplicacionPerfil_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                String dato1 = listAplicacionPerfil.CurrentRow.Cells[0].Value.ToString();
                String dato2 = listAplicacionPerfil.CurrentRow.Cells[2].Value.ToString();

                /*string message2= "Debe "+ dato1 + " "+ dato2 + "";
                MessageBox.Show(message2);*/
                int campo1 = int.Parse(dato1);
                string condicion1 = txtIdPerfil.Tag.ToString();
                int campo2 = int.Parse(dato2);
                string condicion2 = txtIdAplicacion.Tag.ToString();
                cn.eliminarAsiganaciones(table, condicion1, campo1, condicion2, campo2);
                cn.setBtitacora("1102", "Elimino Aplicacion-Perfil");
                listAplicacionPerfil.Columns.Clear();
            }
            else
            {
                CheckBox[] checkBoxes = { chBoxGuardar, chBoxModificar, chBoxEliminar, chBoxBuscar, chBoxImprimir };
                cn.limpiarCheckbox(checkBoxes);
                TextBox[] textBoxes = { txtBuscar, txtEliminar, txtGuardar, txtIdAplicacion, txtIdPerfil, txtImprimir, txtModificar, txtCadenas };
                cn.limpiarTextbox(textBoxes);
            }
        }
        //Método que muestra el fomulario indicado
        private void button6_Click(object sender, EventArgs e)
        {
            AyudaAsignacionAplicacionesPerfiles b = new AyudaAsignacionAplicacionesPerfiles();
            b.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
