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
    public partial class AsignacionPerfiles : Form
    {
        string table = "tbl_asignacionesperfilsusuario";

        Controlador cn = new Controlador();

        public AsignacionPerfiles()
        {
            InitializeComponent();
        }

        
        //Método que oculta el id del perfil
        public void ocultar()
        {
            txtIdPerfil.Visible = false;
        }

        //Método que obtiene las aplicaciones del perfil de acuerdo al textbox de perfil que se ingrese 
        public void getIds()
        {
            try
            {
                string dato;
                dato = listPerfilesDB.CurrentCell.Value.ToString();
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
        public void getId()
        {
            try
            {
                string dato;
                dato = ListUsuario.CurrentCell.Value.ToString();
                txtIdUsuario.Text = dato;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
        }

        //Método para actualizar el grid de acuerdo al id del usuario que ingresemos
        public void actualizardatagriew()
        {
            string id = txtIdUsuario.Text;
            cn.llenarListApliUsuariosstring(listPerfilUsuario.Tag.ToString(), listPerfilUsuario, id);
        }

        //Método que oculta el formulario
        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        //Método que agrega un perfil de acuerdo al id y posteriormente se registra en nuestro datagridview y lo actualiza
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "" || txtCadenas.Text == "")
            {
                MessageBox.Show("Porfavor llene los campos necesarios");
            }
            else
            {
                char[] delimiterChars = { ',' };
                string text = txtCadenas.Text;
                string[] words = text.Split(delimiterChars);

                foreach (var word in words)
                {
                    txtIdPerfil.Text = word;
                    TextBox[] textbox = { txtIdPerfil, txtIdUsuario };
                    cn.ingresar(textbox, table);
                }
                string message = "Registro Guardado";
                actualizardatagriew();
                TextBox[] textBoxes = { txtCadenas, txtIdUsuario, txtIdPerfil };
                cn.limpiarTextbox(textBoxes);
                MessageBox.Show(message);
                cn.setBtitacora("1103", "Asigno Perfil-Aplicacion");
                listPerfilesDB.Visible = false;
                //663; 369
                Size = new Size(663, 369);
            }
        }

        //Método que asigna perfiles 
        private void AsignacionPerfiles_Load(object sender, EventArgs e)
        {
            cn.llenarListPerfiles(listPerfilesDB.Tag.ToString(), listPerfilesDB);
            cn.llenarListUsuarios(ListUsuario.Tag.ToString(), ListUsuario);
            Size = new Size(663, 369);
            ocultar();
        }

        //Método que actualiza el datagridview de acuerdo al id de usuario que se ingrese
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string texto = txtIdUsuario.Text;
            if (texto == "")
            {
                string message = "Debe Ingresar un ID Usuario";
                MessageBox.Show(message);
            }
            else
            {
                actualizardatagriew();
                TextBox[] textBoxes = { txtCadenas, txtIdUsuario, txtIdPerfil };
                cn.limpiarTextbox(textBoxes);
            }
            
           
        }
        //Método que llama al método getIds
        private void listAplicacionesDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getIds();
        }
        //Método que muestra la lista de los usuarios 
        private void button2_Click(object sender, EventArgs e)
        {
            ListUsuario.Visible = false;
            //1040; 369
            if (listPerfilesDB.Visible == false)
            {
                listPerfilesDB.Visible = true;
                Size = new Size(1040, 369);
            }
            else
            {
                listPerfilesDB.Visible = false;
                Size = new Size(663, 369);
            }
        }
        //Método que muestra la lista de los usuarios 
        private void button1_Click(object sender, EventArgs e)
        {
            listPerfilesDB.Visible = false;
                //1040; 369
            if (ListUsuario.Visible == false)
            {
                ListUsuario.Visible = true;
                Size = new Size(1040, 369);
            }
            else
            {
                ListUsuario.Visible = false;
                Size = new Size(663, 369);
            }
        }

        private void ListUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getId();
        }

        //Método que muestra un mensaje de eliminación y si se responde con si, elimina el registro de acuerdo al perfil 
        private void listPerfilUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                String dato1 = listPerfilUsuario.CurrentRow.Cells[0].Value.ToString();
                String dato2 = listPerfilUsuario.CurrentRow.Cells[3].Value.ToString();
                int campo1 = int.Parse(dato1);
                string condicion1 = txtIdUsuario.Tag.ToString();
                int campo2 = int.Parse(dato2);
                string condicion2 = txtIdPerfil.Tag.ToString();
                cn.eliminarAsiganaciones(table, condicion1, campo1, condicion2, campo2);
                listPerfilUsuario.Columns.Clear();
                cn.setBtitacora("1103", "Elimino Perfil-Aplicacion");
            }
            else
            {
                TextBox[] textBoxes = { txtCadenas, txtIdUsuario, txtIdPerfil };
                cn.limpiarTextbox(textBoxes);
            }
        }

        //Método que llama al formulario indicado
        private void button6_Click(object sender, EventArgs e)
        {
            AyudaAsignacionPerfilesUsuario b = new AyudaAsignacionPerfilesUsuario();
            b.Show();
        }

        private void ListUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
