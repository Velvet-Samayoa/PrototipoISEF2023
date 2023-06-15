using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Comentado por Luis Torres 26/02/2023
namespace Modelo_Seguridad
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        //Metodo para obtener datos de la tabla usuario
        public string[] queryLogin(string user)
        {
            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string datos = "pk_id_usuario, username_usuario, password_usuario";
            string sql = "SELECT " + datos + " FROM tbl_usuarios where username_usuario='" + user + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString();
                    Campos[(i + 1)] = reader.GetValue(1).ToString();
                    Campos[(i + 2)] = reader.GetValue(2).ToString();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en query hacia la tabla de usuarios"); }
            return Campos;
        }

        //Metodo para recuperacion de respuesta en la tabla usuario
        public string[] queryRecuperacion(string user)
        {
            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string datos = "pk_id_usuario, username_usuario, respuesta";
            string sql = "SELECT " + datos + " FROM tbl_usuarios where username_usuario='" + user + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString();
                    Campos[(i + 1)] = reader.GetValue(1).ToString();
                    Campos[(i + 2)] = reader.GetValue(2).ToString();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en query hacia la tabla de usuarios"); }
            return Campos;
        }


        //Metodo para insercion de datos en bitacora
        public void insertBitacora(string values)
        {
            string campos = "fk_id_usuario, fk_id_aplicacion, fecha_bitacora, hora_bitacora, host_bitacora, ip_bitacora, accion_bitacora";
            string sql = "INSERT INTO tbl_bitacoraDeEventos (" + campos + ") values (" + values + ");";;
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en bitacora"); }
        }

        //Metodo para seleccion de nombre de la apliacion segun su codigo de la tabla aplicaciones
        public string queryNombreApp(string app)
        {
            string nombreApp = "";
            string sql = "SELECT nombre_aplicacion FROM tbl_aplicaciones where pk_id_aplicacion='" + app + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    nombreApp = reader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el nombre de la aplicación");
            }
            return nombreApp;
        }

        //Metodo para selecion de perfiles de usuario 
        public int[] getPerfilesUsuario(string user)
        {
            int[] perfiles = new int[100];
            int i = 0;
            string sql = "SELECT fk_id_perfil FROM tbl_asignacionesPerfilsUsuario WHERE fk_id_usuario='" + user + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    perfiles[i] = int.Parse(reader.GetValue(0).ToString());
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el nombre de la aplicación");
            }

            return perfiles;
        }

        //Metodo para seleccion de perfiles de aplicacion
        public int[] getPerfilAplicacion(int perfil)
        {
            int[] modulos = new int[300];
            int i = 0;
            string sql = "SELECT fk_id_aplicacion FROM tbl_permisosAplicacionPerfil WHERE fk_id_perfil='" + perfil + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    modulos[i] = int.Parse(reader.GetValue(0).ToString());
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
            return modulos;
        }
        //Metodo para seleccion de id apliacion segun perfil y id aplicacion
        public Boolean getAuthPerfilAplicacion(int perfil, int idApp)
        {
            Boolean result = false;
            string sql = "SELECT fk_id_aplicacion FROM tbl_permisosAplicacionPerfil WHERE fk_id_perfil='" + perfil + "' AND fk_id_aplicacion='" + idApp + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (int.Parse(reader.GetValue(0).ToString()) == idApp)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
            return result;
        }

        //Metodo para la seleccion del id del modulo segun el id de aplicacion
        public int getModuloAplicacion(int aplicacion)
        {
            int idModulo = 0;
           // int i = 0;
            string sql = "SELECT fk_id_modulos FROM tbl_AsignacionModuloAplicacion where fk_id_aplicacion='" + aplicacion + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    idModulo = int.Parse(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el modulo de la aplicacion #" + aplicacion);
            }

            return idModulo;
        }

        //Metodo para seleccion de permisos para los botones segun el perfil y aplicacion
        public int[] getPermisos(int perfil, int aplicacion)
        {
            int[] permisos = new int[5];
            int i = 0;
            string campos = "guardar_permiso, modificar_permiso, eliminar_permiso, buscar_permiso, imprimir_permiso";
            string sql = "SELECT " + campos + " FROM tbl_permisosAplicacionPerfil WHERE fk_id_perfil='" + perfil + "' AND fk_id_aplicacion='" + aplicacion + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    permisos[i] = int.Parse(reader.GetValue(0).ToString());
                    permisos[i + 1] = int.Parse(reader.GetValue(1).ToString());
                    permisos[i + 2] = int.Parse(reader.GetValue(2).ToString());
                    permisos[i + 3] = int.Parse(reader.GetValue(3).ToString());
                    permisos[i + 4] = int.Parse(reader.GetValue(4).ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
            return permisos;
        }


        //Metodo para insertar en cualquier tabla
        public void insertar(string dato, string tipo, string tabla)
        {
            string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
            try
            {
            
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener");
            }


            
        }

        //Metodo para seleccionar el campo pregunta en la tabla usuarios
        public string getPregunta(string username)
        {
            string pregunta = "";
            string sql = "SELECT pregunta FROM tbl_usuarios WHERE username_usuario='" + username + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pregunta = reader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener");
            }
            return pregunta;
        }
   

        //Metodo para eliminar cualquier dato de una tabla con doble condicion
        public void eliminarAsiganaciones(string tabla, string condicion1, int campo1, string condicion2, int campo2)
        {
            try
            {

                string sql = "DELETE FROM " + tabla + " where (" + condicion1 + " = " + campo1 + ") and ("+ condicion2 + " =" + campo2 + ");";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }


        }


        //Metodo para actulizar cualquier tabla
        public void actualizarcontra(string dato, string condicion, string tabla, string usu)
        {
            try
            {
                string sql = "Update " + tabla + " " + dato + " where " + condicion + " " + "'" + usu + "'" + "; ";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo actualizar con");
            }


        }

        //Metodo para seleccionar todas las apliaciones
        public OdbcDataAdapter llenarListaAplicaciones(string tabla)
        {
            string sql = "Select pk_id_aplicacion as ID, nombre_aplicacion as Nombre, descripcion_aplicacion as Descripcion from  " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        //Metodo para seleccionar todos los modulos
        public OdbcDataAdapter llenarListaModulos(string tabla)
        {
            string sql = "select pk_id_modulos as Modulo, nombre_modulo as Nombre, descripcion_modulo as Descripcion from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        //Metodo para seleccionar todos los usuarios
        public OdbcDataAdapter llenarListaUsuarios(string tabla)
        {
            string sql = "Select pk_id_usuario as ID, nombre_usuario as nombre, username_usuario as Usuario from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        //Metodo para seleccionar todos los usuarios dependiendo del id
        public OdbcDataAdapter llenarListaApliUsuario(string tabla,string id)
        {
            string sql = "Select *from "+ tabla + " where ID = "+ id + " ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        //Metodo para seleccionar todos los perfiles
        public OdbcDataAdapter llenarListaPerfiles(string tabla)
        {
            string sql = "Select pk_id_perfil as ID, nombre_perfil as Nombre, descripcion_perfil as Descripcion from  " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }


        public OdbcDataAdapter llenarbitacora(string[] fechas) //llenar bitacora
        {
            string sql = "Select pk_id_bitacora as ID, fk_id_usuario as Usuario, fk_id_aplicacion as Aplicacion, fecha_bitacora as Fecha, hora_bitacora as Hora, ip_bitacora as IP, accion_bitacora as Accion from  tbl_bitacoradeeventos where fecha_bitacora >= "+ fechas[0] + " and fecha_bitacora <= " + fechas[1] + " ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
    }
}
