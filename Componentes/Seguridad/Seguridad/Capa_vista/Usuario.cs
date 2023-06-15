using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;
using NavegadorVista;
//Comentado por George Mayén 25/02/2023
namespace Vista_Seguridad
{
    public partial class Usuario : Form
    {
      
        Controlador cn = new Controlador();


        public Usuario()
        {
            InitializeComponent();
        }



        //Mëtodo para asignar un valor, si se ha chequeado asigna '\0', en caso contrario '*'
        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (check.Checked == true)
            {
                // TBcontraseña.PasswordChar = '*';
                txtcontraseña.PasswordChar = '\0';
            }
            else
                      if (txtcontraseña.Text != "")
            {
                // TBcontraseña.PasswordChar = '\0';
                txtcontraseña.PasswordChar = '*';
            }
        }

        private void navegador1_Load(object sender, EventArgs e)//Aplicacion del navegador
        {
            NavegadorVista.Navegador.idApp = "1001";
            navegador1.actual = this;
            navegador1.tabla = dataGridView1;
            TextBox[] Grupotextbox = { txtId,txtnombre, txtapellido, txtusername, txtcontraseña, txtemail, txtestado, TxtPAA, TxtPA };
            TextBox[] Idtextbox = { txtId, txtnombre };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dataGridView1, Grupotextbox, "colchoneria");
        }

        private void CmbPA_SelectedIndexChanged(object sender, EventArgs e)//cambio de valor de combobox a textbox
        {
            TxtPAA.Text = CmbPA.SelectedItem.ToString();
         
        }

        private void TxtPAA_TextChanged(object sender, EventArgs e)//cambio de valor de textbox a combobox
        {
           
        }

        void hashConstraseñas()//hash de contraseñas
        {
            if (txtcontraseña.Text.Length > 0 && TxtPA.Text.Length > 0)
            {
                string hashcontraseña = Seguridad_Controlador.Controlador.SetHash(txtcontraseña.Text);
                string hashpregunta = Seguridad_Controlador.Controlador.SetHash(txtcontraseña.Text);
                txtcontraseña.Text = hashcontraseña;
                TxtPA.Text = hashpregunta;
                
            }
        }

        void configuracionActulizacion()
        {
           CmbPA.SelectedItem = TxtPAA.Text;
           string hashcontraseña = Seguridad_Controlador.Controlador.GetHash(txtcontraseña.Text);
           string hashpregunta = Seguridad_Controlador.Controlador.GetHash(txtcontraseña.Text);
           txtcontraseña.Text = hashcontraseña;
           TxtPA.Text = hashpregunta;
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            if(txtusername.Enabled == true)
            {

                hashConstraseñas();
            }
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtusername.Enabled == false || txtnombre.Enabled == false)
            {
                configuracionActulizacion();
            }
           
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
           
           
        }

       
    }
}
