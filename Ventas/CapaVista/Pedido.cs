using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CapaVista
{
    public partial class Pedido : Form
    {
        CapaModelo_Ventas.Cpconexion conexion = new CapaModelo_Ventas.Cpconexion();
        public Pedido()
        {
            InitializeComponent();
        }

        private void txt_total_detalle_TextChanged(object sender, EventArgs e)
        {

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
                    MessageBox.Show("Dato modificado");
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
                    MessageBox.Show("Dato eliminado");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla ");
                }
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
                    MessageBox.Show("Dato insertado");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }

        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> valoresPorTagTabla = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> valoresPorTagColumnas = new Dictionary<string, List<string>>();

            TextBox[] arreglo = { txt_id, txt_almacen, txt_fecha, txt_clientes, txt_id_detalle, txt_id_pedido_detalle, txt_prodcuto, txt_cantidad, txt_Precio, txt_total, txt_estado};

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && textBox.Tag != null)
                {
                    string[] datosTextBox = textBox.Tag.ToString().Split(',');
                    string tabla = datosTextBox[0];
                    string columna = datosTextBox[1];
                    string condicion = datosTextBox.Length == 3 ? datosTextBox[2] : "";
                    string valor = textBox.Text;
                    if (!valoresPorTagTabla.ContainsKey(tabla))
                    {
                        valoresPorTagTabla[tabla] = new List<string>();
                        valoresPorTagColumnas[tabla] = new List<string>();
                    }
                    valoresPorTagTabla[tabla].Add(columna);
                    valoresPorTagColumnas[tabla].Add("\'" + valor + "\'");
                }
            }
            Guardar(valoresPorTagTabla, valoresPorTagColumnas);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> valoresPorTagTabla = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> valoresPorTagColumnas = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> valoresPorTagCondicion = new Dictionary<string, List<string>>();

            TextBox id_detalle = new TextBox();
            id_detalle.Text = txt_id.Text;
            id_detalle.Tag = "tbl_detalle_pedido,Pk_detalle_pedido,primary";

            TextBox[] arreglo = { txt_id, txt_almacen, txt_fecha, txt_clientes, txt_id_detalle, txt_id_pedido_detalle, txt_prodcuto, txt_cantidad, txt_Precio, txt_total, txt_estado };


            foreach (TextBox textBox in arreglo)
            {
                string[] datosTextBox = textBox.Tag.ToString().Split(',');
                string tabla = datosTextBox[0];
                string columna = datosTextBox[1];
                string valor = textBox.Text;
                if (!valoresPorTagTabla.ContainsKey(tabla))
                {
                    valoresPorTagTabla[tabla] = new List<string>();
                    valoresPorTagColumnas[tabla] = new List<string>();
                    valoresPorTagCondicion[tabla] = new List<string>();
                }
                valoresPorTagTabla[tabla].Add(columna);
                valoresPorTagColumnas[tabla].Add("\'" + valor + "\'");
                if (textBox.Tag.ToString().Contains("primary"))
                {
                    valoresPorTagCondicion[tabla].Add(columna);
                }

            }
            Actualizar(valoresPorTagTabla, valoresPorTagColumnas, valoresPorTagCondicion);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> valoresPorTagTabla = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> valoresPorTagColumnas = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> valoresPorTagCondicion = new Dictionary<string, List<string>>();


            TextBox id_detalle = new TextBox();
            id_detalle.Text = txt_id.Text;
            id_detalle.Tag = "tbl_detalle_pedido,Pk_detalle_pedido,primary";

            TextBox[] arreglo = { txt_id, txt_almacen, txt_fecha, txt_clientes, txt_id_detalle, txt_id_pedido_detalle, txt_prodcuto, txt_cantidad, txt_Precio, txt_total, txt_estado };

            foreach (TextBox textBox in arreglo)
            {
                string[] datosTextBox = textBox.Tag.ToString().Split(',');
                string tabla = datosTextBox[0];
                string columna = datosTextBox[1];
                string valor = textBox.Text;
                if (!valoresPorTagTabla.ContainsKey(tabla))
                {
                    valoresPorTagTabla[tabla] = new List<string>();
                    valoresPorTagColumnas[tabla] = new List<string>();
                    valoresPorTagCondicion[tabla] = new List<string>();
                }
                valoresPorTagTabla[tabla].Add(columna);
                valoresPorTagColumnas[tabla].Add("\'" + valor + "\'");
                if (textBox.Tag.ToString().Contains("primary"))
                {
                    valoresPorTagCondicion[tabla].Add(columna);
                }
            }
            Eliminar(valoresPorTagTabla, valoresPorTagColumnas, valoresPorTagCondicion);
        }
    }
}
