using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo_Ventas
{
    public class Sentencias
    {
        Cpconexion con = new Cpconexion();

        public OdbcDataAdapter DisplayAlumnos()
        {
            string sql = "SELECT * FROM tbl_vendedores ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sql, con.Conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla Alumnos");
            }
            return dataTable;
        }

        public OdbcDataReader getNombre(string id_cliente)
        {
            string sql = "select Nombres_clientes from tbl_clientes where Pk_idClientes = '" + id_cliente + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.Conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener el nombre de la tabla tbl_clientes");
                return null;
            }
        }



        public void ejecutarSentecias(string sql)
        {
            Console.WriteLine(sql);
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.Conexion());
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("error con la setencias" + sql + "\n" + e);
            }
        }

        public OdbcDataAdapter llenartabla3(string idFactura, string almacen)
        {
            string sql = "select pk_id_cuentaporpagar,pk_id_almacen,pk_id_proveedor,pk_id_factura,DATE_FORMAT(fecha_emision_cuentaporpagar, '%Y-%m-%d'),saldo_pago_cuentaporpagar,monto_pago_cuentaporpagar from tbl_cuentaporpagar where pk_id_factura = " + idFactura + " and pk_id_almacen= " + almacen  + " ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.Conexion());
            return datatable;
        }


        public OdbcDataAdapter llenartabla(string tabla)
        {
            string sql = "select * from vista_IdVentas;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.Conexion());
            return datatable;

        }


        public int estadotabla(string tabla)
        {
            int dato = 0;
            string sql = "select count(*) as total from " + tabla;
            OdbcCommand cmd = new OdbcCommand(sql, con.Conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                dato = lr.GetInt32(0);


            }
            return dato;
        }

        public string buscarid(string tabla, string tipo)
        {
            string dato = " ";
            try
            {

                string sql = "select " + tipo + " from " + tabla + " Order by " + tipo + " Desc Limit 1";
                OdbcCommand cmd = new OdbcCommand(sql, con.Conexion());
                OdbcDataReader lr = cmd.ExecuteReader();
                while (lr.Read())
                {
                    dato = lr.GetString(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


            return dato;
        }




    }
}

