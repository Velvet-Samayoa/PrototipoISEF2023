using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CapaControlador_Alumnos
{
    public class CpControlador
    {
        CapaModelo_Ventas.Sentencias sn = new CapaModelo_Ventas.Sentencias();
        CapaModelo_Ventas.Cpconexion conexion = new CapaModelo_Ventas.Cpconexion();

        public DataTable MostrarReportes()
        {
            OdbcDataAdapter data = sn.DisplayAlumnos();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

        public void ast(TextBox[] textBoxs, string fun)
        {
            string sql = string.Empty;
            string colTemp = "";
            string valTemp = "";
            foreach (TextBox textBox in textBoxs)
            {
                string columna = textBox.Tag.ToString();
                string valor = textBox.Text;
                switch (fun)
                {
                    case "insert":
                        colTemp = colTemp + columna + ",";
                        valTemp = valTemp + "'" + valor + "',";
                        break;

                    case "delete":
                        break;

                    case "update":
                        sql += columna + " = '" + valor + "', ";
                        break;
                }
            }
            if (!string.IsNullOrEmpty(sql))
            {
                sql = sql.Substring(0, sql.Length - 2);
            }

            if (!string.IsNullOrEmpty(colTemp))
            {
                colTemp = colTemp.Substring(0, colTemp.Length - 1);
                valTemp = valTemp.Substring(0, valTemp.Length - 1);
            }
            switch (fun)
            {
                case "insert":
                    sql = "insert into tbl_vendedores (" + colTemp + ") values(" + valTemp + ");";
                    sn.ejecutarSentecias(sql);
                    break;

                case "delete":
                    sql = "DELETE FROM tbl_vendedores WHERE id = '" + textBoxs[0].Text + "';";
                    sn.ejecutarSentecias(sql);
                    break;

                case "update":
                    sql = "UPDATE INTO tbl_vendedores SET " + sql + " WHERE id='" + textBoxs[0].Text + "';";
                    sn.ejecutarSentecias(sql);
                    break;
            }
        }

        public void Guardar(Dictionary<string, List<string>> valoresPorTagTabla, Dictionary<string, List<string>> valoresPorTagColumnas)
        {
            HashSet<string> tables = new HashSet<string>(valoresPorTagTabla.Keys.Union(valoresPorTagColumnas.Keys));

            foreach (string tabla in tables)
            {
                List<string> columnas = valoresPorTagTabla[tabla];
                List<string> valores = valoresPorTagColumnas[tabla];

                // Generate INSERT statement
                string insert = $"INSERT INTO {tabla} ({string.Join(",", columnas)}) VALUES ({string.Join(",", valores)});";

                try
                {
                    OdbcCommand cmd = new OdbcCommand(insert, conexion.Conexion());
                    Console.WriteLine(insert);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }

        }
        public void Actualizar(Dictionary<string, List<string>> valoresPorTagTabla, Dictionary<string, List<string>> valoresPorTagColumnas, Dictionary<string, List<string>> condiciones)
        {
            HashSet<string> tables = new HashSet<string>(valoresPorTagTabla.Keys.Union(valoresPorTagColumnas.Keys));
            foreach (string tabla in tables)
            {
                List<string> columnas = valoresPorTagTabla[tabla];
                List<string> valores = valoresPorTagColumnas[tabla];
                string condicion = string.Join(" AND ", condiciones[tabla].Select((v, i) => $"{v}={valoresPorTagColumnas[tabla][i]}"));

                List<string> updateValues = columnas.Zip(valores, (col, val) => $"{col}={val}").ToList();
                string update = $"UPDATE {tabla} SET {string.Join(",", updateValues)} WHERE {condicion};";
                try
                {
                    OdbcCommand consulta = new OdbcCommand(update, conexion.Conexion());
                    Console.WriteLine(update);
                    consulta.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error en CapaModeloReporteria --> Sentencias" + e);
                }
            }

        }
        public void Eliminar(Dictionary<string, List<string>> valoresPorTagTabla, Dictionary<string, List<string>> valoresPorTagColumnas, Dictionary<string, List<string>> condiciones)
        {
            HashSet<string> tables = new HashSet<string>(valoresPorTagTabla.Keys.Union(valoresPorTagColumnas.Keys));
            foreach (string tabla in tables)
            {
                List<string> columnas = valoresPorTagTabla[tabla];
                List<string> valores = valoresPorTagColumnas[tabla];
                string condicion = string.Join(" AND ", condiciones[tabla].Select((v, i) => $"{v}={valoresPorTagColumnas[tabla][i]}"));
                string delete = $"DELETE FROM {tabla} WHERE {condicion};";
                try
                {
                    OdbcCommand cmd = new OdbcCommand(delete, conexion.Conexion());
                    Console.WriteLine(delete);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla ");
                }
            }
        }
    }
}
