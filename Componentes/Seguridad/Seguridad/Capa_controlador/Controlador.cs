using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Modelo_Seguridad;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;


namespace Seguridad_Controlador
{   //comentado por Jason Ortega 0901-19-22658 25/02/23
    public class Controlador
    {
        Sentencias sn = new Sentencias();  //se hace la conexion con la clase sentencia

        public static string Username;

        public static string idUser;

        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public static string SetHash(string inputString) //recibe una cadena de entrada inputString
        {
            string hash = "x2";
            byte[] bytes = UTF8Encoding.UTF8.GetBytes(inputString);
            MD5 mD5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();
            tripleDES.Key = mD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash)); //Se crea objeto TripleDES y se establece su clave utilizando el valor hash
            tripleDES.Mode = CipherMode.ECB; //se establece el modo de cifrado como ECB
            ICryptoTransform transform = tripleDES.CreateEncryptor();
            byte[] output = transform.TransformFinalBlock(bytes, 0, bytes.Length); // se cifra la matriz de byte de la cadena de entrada
            return Convert.ToBase64String(output); //se convierte la matriz de bytes cifrada a una cadena Base64 y se devuelve como salida de la funcion
        }

        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public static string GetHash(string inputString)
        {
            string hash = "x2";
            byte[] bytes = Convert.FromBase64String(inputString); // se convierte la cadena de entrada en una matriz de bytes utilizando el metodo FromBase64String
            MD5 mD5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create(); 
            tripleDES.Key = mD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Se crea un objeto TripleDES y se establece su clave utilizando el valor hash 
            tripleDES.Mode = CipherMode.ECB; //Se establece el modo de cifrado como ECB para el objeto TripleDES
            ICryptoTransform transform = tripleDES.CreateDecryptor(); //se crea un objeto ICryptoTransform utilizando 
            byte[] output = transform.TransformFinalBlock(bytes, 0, bytes.Length);
            return UTF8Encoding.UTF8.GetString(output);
        }

        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public void setBtitacora(string aplicacion, string accion) //se crea un registro de bitacora con la informacion sobre las acciones realizadas por un usuario
        {
            string fechaActual = DateTime.Now.ToString("yyyy/MM/dd");
            string horaActual = DateTime.Now.ToString("HH:mm:ss");
            string nombreHost = System.Net.Dns.GetHostName().ToUpper();
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;
            string direccionIP = addr[1].ToString();
            string datos = "" + GetHash(idUser) + "," + aplicacion + ",'" + fechaActual + "','" + horaActual + "','" + nombreHost + "','" + direccionIP + "','" + accion + "'";
            sn.insertBitacora(datos);
        }

        public string getNombreAplicacion(string codigoApp) //obtiene el nombre de la aplicacion correspondiente a un codigo de aplicacion dado.
        {
            return sn.queryNombreApp(codigoApp);
        }
        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public Boolean getAccesoModulos(int moduloSolicitado)  //acceso a los modulo en funcion de los perfiles.
        {
            string idUsuario = GetHash(idUser);
            Boolean respuestAcceso= false;
            int[] perfiles = sn.getPerfilesUsuario(idUsuario);
            for (int i = 0; i < perfiles.Length; i++)
            {
                if (perfiles[i] != 0 && perfiles[i] != null)
                {
                    int[] aplicaciones = sn.getPerfilAplicacion(perfiles[i]);
                    for (int j = 0; j < aplicaciones.Length; j++)
                    {
                        if (aplicaciones[j] != 0 && aplicaciones != null)
                        {
                            int idModulo = sn.getModuloAplicacion(aplicaciones[j]);
                            if (idModulo == 1000 && moduloSolicitado == 1000)
                            {
                                respuestAcceso = true;
                            }
                            if (idModulo == 2000 && moduloSolicitado == 2000)
                            {
                                respuestAcceso = true;
                            }
                            if (idModulo == 3000 && moduloSolicitado == 3000)
                            {
                                respuestAcceso = true;
                            }
                            if (idModulo == 4000 && moduloSolicitado == 4000)
                            {
                                respuestAcceso = true;
                            }
                            if (idModulo == 5000 && moduloSolicitado == 5000)
                            {
                                respuestAcceso = true;
                            }
                            if (idModulo == 6000 && moduloSolicitado == 6000)
                            {
                                respuestAcceso = true;
                            }
                            if (idModulo == 7000 && moduloSolicitado == 7000)
                            {
                                respuestAcceso = true;
                            }
                            if (idModulo == 8000 && moduloSolicitado == 8000)
                            {
                                respuestAcceso = true;
                            }
                        }
                    }
                }
            }


            return respuestAcceso;
        }
        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public void deshabilitarApps(Button[] paneles) //deshabilita los paneles 
        {
            for (int i = 0; i < paneles.Length; i++)
            {
                paneles[i].Enabled = false;
            }
        }
        public void getAccesoApp(int idApp, Button boton) //Verifica si el usuario ingresado tiene acceso
        {
            string idUsuario = GetHash(idUser);
            int[] perfiles = sn.getPerfilesUsuario(idUsuario);
            for (int i = 0; i < perfiles.Length; i++)
            {
                if (perfiles[i] != 0 && perfiles[i] != null)
                {
                    Boolean aplicaciones = sn.getAuthPerfilAplicacion(perfiles[i], idApp);
                    Console.WriteLine(aplicaciones);
                    if (aplicaciones)
                    {
                        boton.Enabled = true;
                    }
                    else
                    {
                        boton.Enabled = false;
                    }
                }
            }
        }
        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public int[] getPermisosAplicaion(string App) //da los permisos a una aplicacion 
        {
            int[] result = new int[5];
            int[] permisos = new int[5];
            string idUsuario = GetHash(idUser);
            int[] perfiles = sn.getPerfilesUsuario(idUsuario);
            for (int i = 0; i < perfiles.Length; i++)
            {
                if (perfiles[i] != 0 && perfiles[i] != null)
                {
                    result = sn.getPermisos(perfiles[i], int.Parse(App));
                    if (result[0] == 1)
                    {
                        permisos[0] = result[0];
                        Console.WriteLine("Guardar");
                    }
                    if (result[1] == 1)
                    {
                        permisos[1] = result[1];
                        Console.WriteLine("Modificar");
                    }
                    if (result[2] == 1)
                    {
                        permisos[2] = result[2];
                        Console.WriteLine("Eliminar");
                    }
                    if (result[3] == 1)
                    {
                        permisos[3] = result[3];
                        Console.WriteLine("Buscar");
                    }
                    if (result[4] == 1)
                    {
                        permisos[4] = result[4];
                        Console.WriteLine("Imprimir");
                    }
                }
            }
            return permisos;
        }
        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public Boolean validarLogin(string username, string password) //Valida en inicio de sesion del usuario
        {
            string[] datos = sn.queryLogin(username);
            for (int i = 0; i < datos.Length; i = i + 3)
            {
                if (datos[i + 1] == username)
                {
                    if (datos[i + 2] == password)
                    {
                        idUser = SetHash(datos[i]);
                        return true;
                    }
                }
            }
            return false;
        }
        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public Boolean validarRecuperacion(string username, string respuesta) //valida la respuesta del usuario a una pregunta de seguridad
        {
            string[] datos = sn.queryRecuperacion(username);
            for (int i = 0; i < datos.Length; i = i + 3)
            {
                if (datos[i + 1] == username)
                {
                    if (datos[i + 2] == respuesta)
                    {
                        idUser = SetHash(datos[i]);
                        return true;
                    }
                }
            }
            return false;
        }

        //comentado por Jason Ortega 0901-19-22658 25/02/23

        public void ingresar(TextBox[] textbox, string tabla/*, string app*/)//Crea cadenas de datos para la insercion
        {
            string dato = " ";
            string tipo = " ";

            for (int x = 0; x < textbox.Length; x++)
            {

                if (x == textbox.Length - 1)
                {
                    dato += "'" + textbox[x].Text + "'";
                    tipo += textbox[x].Tag.ToString();
                }
                else
                {
                    dato += "'" + textbox[x].Text + "',";
                    tipo += textbox[x].Tag.ToString() + ",";
                }

            }
            sn.insertar(dato, tipo, tabla);
          //  setBtitacora(app, "Insertar");
        }
        
        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public void actualizarcontra(TextBox[] textbox, string tabla, string campo, string usu) //actualiza contraseña de usuario
        {
            string dato = " ";

            string condicion = campo;


            dato += "set  " + textbox[0].Tag.ToString() + " = '" + textbox[0].Text + "' ";



            sn.actualizarcontra(dato, condicion, tabla, usu);
            MessageBox.Show("Dato actualizado");
        }
        //comentado por Jason Ortega 0901-19-22658 25/02/23
        
        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public void eliminarAsiganaciones(string tabla, string condicion1, int campo1, string condicion2, int campo2) //elimina asignaciones
        {
            try
            {
                sn.eliminarAsiganaciones(tabla, condicion1, campo1, condicion2, campo2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar por permisos asignados");
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }
        }
        //comentado por Jason Ortega 0901-19-22658 25/02/23
       
        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public void llenarListAplicaciones(string ntabla, DataGridView tabla) //Llena la lista de aplicaciones
        {
            OdbcDataAdapter dt = sn.llenarListaAplicaciones(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }
        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public void llenarListModulo(string ntabla, DataGridView tabla) //Llena la lista de modulos 
        {
            OdbcDataAdapter dt = sn.llenarListaModulos(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }
        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public void llenarListUsuarios(string ntabla, DataGridView tabla) //Llena la lista de usuarios
        {
            OdbcDataAdapter dt = sn.llenarListaUsuarios(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }
        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public void llenarListApliUsuariosstring(string ntabla, DataGridView tabla,string id) //Llena la lista de aplicacion de usuario
        {
            OdbcDataAdapter dt = sn.llenarListaApliUsuario(ntabla, id);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }
        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public void llenarListPerfiles(string ntabla, DataGridView tabla) //Llena la lista de perfiles
        {
            OdbcDataAdapter dt = sn.llenarListaPerfiles(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }


        //comentado por Jason Ortega 0901-19-22658 25/02/23
        public string llenarPregunta(string username) //devuelve la pregunta de seguridad asociada con el usuario.
        {
            return sn.getPregunta(username);
        }
        //comentado por Jason Ortega 0901-19-22658 25/02/23
        
        public void limpiarTextbox(TextBox[] textBoxes)//Metodo para limpiar textbox
        {
            for(int x = 0; x < textBoxes.Length; x++)
            {
                textBoxes[x].Clear();
            }
        }

        public void limpiarCheckbox(CheckBox[] checkBoxes)//Metodo para desmarcar checkbox
        {
            for (int x = 0; x < checkBoxes.Length; x++)
            {
                checkBoxes[x].Checked = false;
            }
        }

        public void marcarCheckbox(CheckBox[] checkBoxes)//Metodo para marcar checkbox
        {
            for (int x = 0; x < checkBoxes.Length; x++)
            {
                checkBoxes[x].Checked = true;
            }
        }

        public void desabilitarTextbox(TextBox[] textBoxes)//Metodo para desabilitar textbox
        {
            for(int x= 0; x < textBoxes.Length; x++)
            {
                textBoxes[x].Visible = false;
            }
        }

        public void filtroBitacora(DateTimePicker[] dateTimePickers, DataGridView tabla)
        {
            string[] fechas = { dateTimePickers[0].Value.ToString("yyyyMMdd"), dateTimePickers[1].Value.ToString("yyyyMMdd") };
            OdbcDataAdapter dt = sn.llenarbitacora(fechas);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }
    }
}
