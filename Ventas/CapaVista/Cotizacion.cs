using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas_CapaControlador;
using System.Data.Odbc;

namespace CapaVista
{
    public partial class Cotizacion : Form
    {
        Controlador controlador = new Controlador();
        CapaModelo_Ventas.Cpconexion conexion = new CapaModelo_Ventas.Cpconexion();

        public Cotizacion()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 4; // Establece el número de columnas

            dataGridView1.Columns[0].Name = "Producto"; // Nombre de la primera columna
            dataGridView1.Columns[1].Name = "Cantidad"; // Nombre de la segunda columna
            dataGridView1.Columns[2].Name = "Precio Unitario"; // Nombre de la tercera columna
            dataGridView1.Columns[3].Name = "Subtotal"; // Nombre de la cuarta columna
            
            try
            {

                txt_id.Text = controlador.llenarTextBoxID();
                txt_id_detalle_cotizacion.Text = controlador.llenarTextBoxIdDetalle();
                comboBoxProducto.Items.Add(controlador.llenarComboProductos());
                comboBoxAlmacen.Items.Add(controlador.llenarComboAlmacen());
                comboBoxCliente.Items.Add(controlador.llenarComboCliente());
                comboBox4.Items.Add(controlador.llenarComboEstado());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

            }
        }
        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void Actualizar(Dictionary<string, List<string>> valoresPorTagTabla, Dictionary<string, List<string>> valoresPorTagColumnas, Dictionary<string, List<string>> condiciones)
        {
           

        }
        public void Eliminar(Dictionary<string, List<string>> valoresPorTagTabla, Dictionary<string, List<string>> valoresPorTagColumnas, Dictionary<string, List<string>> condiciones)
        {
            

        }
        public void Guardar(Dictionary<string, List<string>> valoresPorTagTabla, Dictionary<string, List<string>> valoresPorTagColumnas)
        {
          

        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {

            

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string productos = comboBoxProducto.SelectedItem.ToString();
            txt_producto.Text = productos;
            string dato1 = txt_producto.Text;
            string dato2 = txt_cantidad.Text;
            txt_precio.Text = controlador.obtenerPrecioUnitario(productos);
            string dato3 = txt_precio.Text;
            float numPrecio = float.Parse(dato3);
            float numCantidad = float.Parse(dato2);
            float subTotal = numPrecio * numCantidad;
            string dato4 = subTotal.ToString("F2"); //F2 indica que se deben mostrar dos decimales
            string[] row1 = { dato1, dato2, dato3, dato4 }; // Valores de la primera fila
            dataGridView1.Rows.Add(row1); // Agrega la primera fila
            string dato5 = txt_total.Text;
            float total = float.Parse(dato5);
            total = total + subTotal;
            txt_total.Text = total.ToString("F2");
            txt_cantidad_producto.Text = txt_cantidad.Text;
            txt_cantidad.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indice = dataGridView1.SelectedRows[0].Index;
                DataGridViewCell celdaSeleccionada = dataGridView1.SelectedCells[3];
                object valorCelda = celdaSeleccionada.Value;
                string dato4 = valorCelda.ToString();
                string dato5 = txt_total.Text;
                float total = float.Parse(dato5);
                float precioRestado = float.Parse(dato4);
                total = total - precioRestado;
                txt_total.Text = total.ToString();
                dataGridView1.Rows.RemoveAt(indice);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idCotizacion = txt_id.Text;
            DateTime fecha = dateTimePicker1.Value;
            txt_fecha.Text = fecha.ToString("yyyy/MM/dd"); // Formato de fecha deseado
            string nombreAlmacen = comboBoxAlmacen.SelectedItem.ToString();
            string idAlmacen = "SELECT codigo_almacen FROM `ModuloVentas`.`tbl_almacen` WHERE nombre_almacen = '" + nombreAlmacen + "';";
            OdbcCommand cmdAlmacen = new OdbcCommand(idAlmacen, conexion.Conexion());
            OdbcDataReader readerAlmacen = cmdAlmacen.ExecuteReader();

            while (readerAlmacen.Read())
            {
                string almacen = readerAlmacen.GetString(0);
                textBox1.Text = almacen;
            }
            string dpiCliente = comboBoxCliente.SelectedItem.ToString();
            string idCliente = "SELECT Pk_idClientes FROM `ModuloVentas`.`tbl_clientes` WHERE Dpi_clientes = '" + dpiCliente + "';";
            OdbcCommand cmdCliente = new OdbcCommand(idCliente, conexion.Conexion());
            OdbcDataReader readerCliente = cmdCliente.ExecuteReader();

            while (readerCliente.Read())
            {
                string cliente = readerCliente.GetString(0);
                textBox2.Text = cliente;
            }
            string cotizacion = "insert into `ModuloVentas`.`tbl_cotizacion` values (" + idCotizacion + "," + textBox1.Text + "," + textBox2.Text + ", '" + txt_fecha.Text + "');";
            OdbcCommand cmdInsertar = new OdbcCommand(cotizacion, conexion.Conexion());
            cmdInsertar.ExecuteNonQuery();


            string nombreEstado = comboBox4.SelectedItem.ToString();
            string idEstado = "SELECT Pk_estado_cotizacion FROM `ModuloVentas`.`tbl_estado_cotizacion` WHERE descripcion_estado_cotizacion = '" + nombreEstado + "';";
            OdbcCommand cmdEstado = new OdbcCommand(idEstado, conexion.Conexion());
            OdbcDataReader readerEstado = cmdEstado.ExecuteReader();

            while (readerEstado.Read())
            {
                string estado = readerEstado.GetString(0);
                txt_estado.Text = estado;
            }

            string[] nombreProducto, cantidad, precio, subTotal;
            int numeroFilas = dataGridView1.Rows.Count;
            nombreProducto = new string[numeroFilas];
            cantidad = new string[numeroFilas];
            precio = new string[numeroFilas];
            subTotal = new string[numeroFilas];

            for (int i = 0; i < numeroFilas; i++)
            {
                DataGridViewRow fila = dataGridView1.Rows[i];
                cantidad[i] = fila.Cells[1].Value.ToString();
                precio[i] = fila.Cells[2].Value.ToString();
                subTotal[i] = fila.Cells[3].Value.ToString();
                txt_cantidad_detalle.Text = cantidad[i];
                txt_total_detalle.Text = subTotal[i];
                txt_precio_detalle.Text = precio[i];
                // Obtener el valor de la celda deseada, por ejemplo, la primera celda de cada fila
                nombreProducto[i] = fila.Cells[0].Value.ToString();
                string idProducto = "SELECT codigo_producto FROM `ModuloVentas`.`tbl_producto` WHERE nombre_producto = '" + nombreProducto[i] + "';";
                OdbcCommand cmdIdProducto = new OdbcCommand(idProducto, conexion.Conexion());
                OdbcDataReader readerIdProducto = cmdIdProducto.ExecuteReader();
                while (readerIdProducto.Read())
                {
                    string idProductoDetalle = readerIdProducto.GetString(0);
                    txt_id_producto.Text = idProductoDetalle;
                }

                string detalleCotizacion = "insert into `ModuloVentas`.`tbl_detalle_cotizacion` values (" + txt_id_detalle_cotizacion.Text + "," + txt_id.Text + "," + txt_id_producto.Text + "," + txt_precio_detalle.Text + ", " + txt_cantidad_detalle.Text + "," + txt_total_detalle.Text + "," + txt_estado.Text + ");";
                OdbcCommand cmdInsertarDetalle = new OdbcCommand(detalleCotizacion, conexion.Conexion());
                cmdInsertarDetalle.ExecuteNonQuery();

                int idActualDetalle = int.Parse(txt_id_detalle_cotizacion.Text);
                idActualDetalle = idActualDetalle + 1;
                txt_id_detalle_cotizacion.Text = idActualDetalle.ToString();
            }

            MessageBox.Show("Dato Insertado");
            dataGridView1.Rows.Clear();
            int idActual = int.Parse(txt_id.Text);
            idActual = idActual + 1;
            txt_id.Text = idActual.ToString();
        }
    }
}
