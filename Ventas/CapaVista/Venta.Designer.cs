
namespace CapaVista
{
    partial class Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.txt_uuid = new System.Windows.Forms.TextBox();
            this.txt_cambio = new System.Windows.Forms.TextBox();
            this.txt_clientes = new System.Windows.Forms.TextBox();
            this.txt_moneda = new System.Windows.Forms.TextBox();
            this.txt_fecha_vencimiento = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_fechaventa = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txt_almacen_encabezado = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txt_total_detalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_almacen_detalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_id_detalleventa = new System.Windows.Forms.TextBox();
            this.txt_estado_detalle = new System.Windows.Forms.TextBox();
            this.txt_id_venta_detalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(394, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Venta";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(159, 58);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(576, 154);
            this.navegador1.TabIndex = 7;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(514, 435);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(126, 16);
            this.label25.TabIndex = 79;
            this.label25.Text = "Factura electronica";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(547, 530);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(134, 20);
            this.txt_numero.TabIndex = 78;
            this.txt_numero.Tag = "tbl_venta,NumeroFel_venta";
            // 
            // txt_serie
            // 
            this.txt_serie.Location = new System.Drawing.Point(547, 499);
            this.txt_serie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(134, 20);
            this.txt_serie.TabIndex = 77;
            this.txt_serie.Tag = "tbl_venta,serieFel_venta";
            // 
            // txt_uuid
            // 
            this.txt_uuid.Location = new System.Drawing.Point(547, 465);
            this.txt_uuid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_uuid.Name = "txt_uuid";
            this.txt_uuid.Size = new System.Drawing.Size(134, 20);
            this.txt_uuid.TabIndex = 76;
            this.txt_uuid.Tag = "tbl_venta,UUidFel_venta";
            // 
            // txt_cambio
            // 
            this.txt_cambio.Location = new System.Drawing.Point(547, 397);
            this.txt_cambio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cambio.Name = "txt_cambio";
            this.txt_cambio.Size = new System.Drawing.Size(134, 20);
            this.txt_cambio.TabIndex = 75;
            this.txt_cambio.Tag = "tbl_venta,tipodecambio_venta";
            // 
            // txt_clientes
            // 
            this.txt_clientes.Location = new System.Drawing.Point(197, 449);
            this.txt_clientes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_clientes.Name = "txt_clientes";
            this.txt_clientes.Size = new System.Drawing.Size(108, 20);
            this.txt_clientes.TabIndex = 74;
            this.txt_clientes.Tag = "tbl_venta,Pk_idClientes";
            // 
            // txt_moneda
            // 
            this.txt_moneda.Location = new System.Drawing.Point(193, 487);
            this.txt_moneda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_moneda.Name = "txt_moneda";
            this.txt_moneda.Size = new System.Drawing.Size(112, 20);
            this.txt_moneda.TabIndex = 73;
            this.txt_moneda.Tag = "tbl_venta,moneda_venta";
            // 
            // txt_fecha_vencimiento
            // 
            this.txt_fecha_vencimiento.Location = new System.Drawing.Point(547, 364);
            this.txt_fecha_vencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha_vencimiento.Name = "txt_fecha_vencimiento";
            this.txt_fecha_vencimiento.Size = new System.Drawing.Size(134, 20);
            this.txt_fecha_vencimiento.TabIndex = 72;
            this.txt_fecha_vencimiento.Tag = "tbl_venta,fecha_venci_venta";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(193, 528);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(112, 20);
            this.txt_estado.TabIndex = 71;
            this.txt_estado.Tag = "tbl_venta,Estado_fac_venta";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(197, 412);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(108, 20);
            this.txt_total.TabIndex = 70;
            this.txt_total.Tag = "tbl_venta,Total_venta";
            // 
            // txt_iva
            // 
            this.txt_iva.Location = new System.Drawing.Point(197, 372);
            this.txt_iva.Margin = new System.Windows.Forms.Padding(4);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(108, 20);
            this.txt_iva.TabIndex = 69;
            this.txt_iva.Tag = "tbl_venta,IVA_venta";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(398, 528);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 16);
            this.label26.TabIndex = 68;
            this.label26.Text = "Número";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(418, 499);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 16);
            this.label27.TabIndex = 67;
            this.label27.Text = "Serie";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(418, 469);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 16);
            this.label28.TabIndex = 66;
            this.label28.Text = "UUid";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(56, 449);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 16);
            this.label29.TabIndex = 65;
            this.label29.Text = "Id Clientes";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(340, 397);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(106, 16);
            this.label30.TabIndex = 64;
            this.label30.Text = "Tipo de cambio";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(58, 487);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(59, 16);
            this.label31.TabIndex = 63;
            this.label31.Text = "Moneda";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(317, 365);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(126, 16);
            this.label32.TabIndex = 62;
            this.label32.Text = "Fecha vencimiento";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(58, 530);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(50, 16);
            this.label33.TabIndex = 60;
            this.label33.Text = "Estado";
            // 
            // txt_fechaventa
            // 
            this.txt_fechaventa.Location = new System.Drawing.Point(547, 328);
            this.txt_fechaventa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fechaventa.Name = "txt_fechaventa";
            this.txt_fechaventa.Size = new System.Drawing.Size(134, 20);
            this.txt_fechaventa.TabIndex = 57;
            this.txt_fechaventa.Tag = "tbl_venta,fecha_venta";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(56, 414);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(40, 16);
            this.label34.TabIndex = 61;
            this.label34.Text = "Total";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(56, 374);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(35, 16);
            this.label35.TabIndex = 59;
            this.label35.Text = "IVA";
            // 
            // txt_almacen_encabezado
            // 
            this.txt_almacen_encabezado.Location = new System.Drawing.Point(547, 290);
            this.txt_almacen_encabezado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_almacen_encabezado.Name = "txt_almacen_encabezado";
            this.txt_almacen_encabezado.Size = new System.Drawing.Size(134, 20);
            this.txt_almacen_encabezado.TabIndex = 58;
            this.txt_almacen_encabezado.Tag = "tbl_venta,codigo_almacen";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(56, 290);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(21, 16);
            this.label36.TabIndex = 52;
            this.label36.Text = "Id";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(347, 327);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(102, 16);
            this.label37.TabIndex = 56;
            this.label37.Text = "Fecha de venta";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(393, 290);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(64, 16);
            this.label38.TabIndex = 55;
            this.label38.Text = "Almacen";
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(193, 330);
            this.txt_descuento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(112, 20);
            this.txt_descuento.TabIndex = 54;
            this.txt_descuento.Tag = "tbl_venta,Descuento_venta";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(193, 290);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(112, 20);
            this.txt_id.TabIndex = 53;
            this.txt_id.Tag = "tbl_venta,Pk_idVenta,primary";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(56, 329);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(74, 16);
            this.label39.TabIndex = 51;
            this.label39.Text = "Descuento";
            // 
            // txt_total_detalle
            // 
            this.txt_total_detalle.Location = new System.Drawing.Point(1003, 496);
            this.txt_total_detalle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_total_detalle.Name = "txt_total_detalle";
            this.txt_total_detalle.Size = new System.Drawing.Size(129, 20);
            this.txt_total_detalle.TabIndex = 98;
            this.txt_total_detalle.Tag = "tbl_detalle_venta,Total_detalleventa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(719, 530);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 97;
            this.label2.Text = "Estado";
            // 
            // txt_almacen_detalle
            // 
            this.txt_almacen_detalle.Location = new System.Drawing.Point(1003, 290);
            this.txt_almacen_detalle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_almacen_detalle.Name = "txt_almacen_detalle";
            this.txt_almacen_detalle.Size = new System.Drawing.Size(129, 20);
            this.txt_almacen_detalle.TabIndex = 96;
            this.txt_almacen_detalle.Tag = "tbl_detalle_venta,codigo_almacen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(711, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 95;
            this.label3.Tag = "Pk_idVendedores";
            this.label3.Text = "Almacen";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(868, 568);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 26);
            this.button1.TabIndex = 87;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1003, 568);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 26);
            this.button2.TabIndex = 89;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(1003, 395);
            this.txt_producto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(129, 20);
            this.txt_producto.TabIndex = 94;
            this.txt_producto.Tag = "tbl_detalle_venta,codigo_producto";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(1003, 433);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(129, 20);
            this.txt_cantidad.TabIndex = 93;
            this.txt_cantidad.Tag = "tbl_detalle_venta,Cantidad_detalleventa";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(733, 568);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 26);
            this.button3.TabIndex = 86;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(711, 396);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 92;
            this.label4.Text = "Codigo producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(711, 435);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 91;
            this.label5.Tag = "Pk_idVendedores";
            this.label5.Text = "Cantidad";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(1003, 467);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(129, 20);
            this.txt_precio.TabIndex = 90;
            this.txt_precio.Tag = "tbl_detalle_venta,Precio_uni_detalleventa";
            // 
            // txt_id_detalleventa
            // 
            this.txt_id_detalleventa.Location = new System.Drawing.Point(1003, 327);
            this.txt_id_detalleventa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_detalleventa.Name = "txt_id_detalleventa";
            this.txt_id_detalleventa.Size = new System.Drawing.Size(129, 20);
            this.txt_id_detalleventa.TabIndex = 88;
            this.txt_id_detalleventa.Tag = "tbl_detalle_venta,PK_orden_detalleventa,primary";
            // 
            // txt_estado_detalle
            // 
            this.txt_estado_detalle.Location = new System.Drawing.Point(1003, 526);
            this.txt_estado_detalle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado_detalle.Name = "txt_estado_detalle";
            this.txt_estado_detalle.Size = new System.Drawing.Size(129, 20);
            this.txt_estado_detalle.TabIndex = 85;
            this.txt_estado_detalle.Tag = "tbl_detalle_venta,Estado_detalleventa";
            // 
            // txt_id_venta_detalle
            // 
            this.txt_id_venta_detalle.Location = new System.Drawing.Point(1003, 363);
            this.txt_id_venta_detalle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_venta_detalle.Name = "txt_id_venta_detalle";
            this.txt_id_venta_detalle.Size = new System.Drawing.Size(129, 20);
            this.txt_id_venta_detalle.TabIndex = 84;
            this.txt_id_venta_detalle.Tag = "tbl_detalle_venta,Pk_idVenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(719, 467);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 83;
            this.label6.Text = "Precio unitario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(711, 328);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 82;
            this.label7.Text = "Id detalle venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(719, 499);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 81;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(711, 364);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 80;
            this.label9.Text = "Id Venta";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1212, 642);
            this.Controls.Add(this.txt_total_detalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_almacen_detalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_id_detalleventa);
            this.Controls.Add(this.txt_estado_detalle);
            this.Controls.Add(this.txt_id_venta_detalle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_serie);
            this.Controls.Add(this.txt_uuid);
            this.Controls.Add(this.txt_cambio);
            this.Controls.Add(this.txt_clientes);
            this.Controls.Add(this.txt_moneda);
            this.Controls.Add(this.txt_fecha_vencimiento);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_iva);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txt_fechaventa);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.txt_almacen_encabezado);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Venta";
            this.Text = "z";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_serie;
        private System.Windows.Forms.TextBox txt_uuid;
        private System.Windows.Forms.TextBox txt_cambio;
        private System.Windows.Forms.TextBox txt_clientes;
        private System.Windows.Forms.TextBox txt_moneda;
        private System.Windows.Forms.TextBox txt_fecha_vencimiento;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txt_fechaventa;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txt_almacen_encabezado;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txt_total_detalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_almacen_detalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_id_detalleventa;
        private System.Windows.Forms.TextBox txt_estado_detalle;
        private System.Windows.Forms.TextBox txt_id_venta_detalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}