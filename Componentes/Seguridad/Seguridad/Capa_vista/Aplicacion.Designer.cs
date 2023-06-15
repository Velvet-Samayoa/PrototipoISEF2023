
namespace Vista_Seguridad
{
    partial class Aplicacion
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
            this.idapp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtact = new System.Windows.Forms.TextBox();
            this.Dgv_modulos = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_modulos)).BeginInit();
            this.SuspendLayout();
            // 
            // idapp
            // 
            this.idapp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.idapp.Location = new System.Drawing.Point(274, 182);
            this.idapp.Name = "idapp";
            this.idapp.Size = new System.Drawing.Size(244, 25);
            this.idapp.TabIndex = 9;
            this.idapp.Tag = "pk_id_aplicacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label2.Location = new System.Drawing.Point(121, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID Aplicacion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(275, 250);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(244, 25);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Tag = "descripcion_aplicacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label5.Location = new System.Drawing.Point(121, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripcion";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtNombre.Location = new System.Drawing.Point(275, 214);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 25);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Tag = "nombre_aplicacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label4.Location = new System.Drawing.Point(121, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre Aplicacion";
            // 
            // txtact
            // 
            this.txtact.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtact.Location = new System.Drawing.Point(275, 284);
            this.txtact.Name = "txtact";
            this.txtact.Size = new System.Drawing.Size(227, 25);
            this.txtact.TabIndex = 2;
            this.txtact.Tag = "estado_aplicacion";
            // 
            // Dgv_modulos
            // 
            this.Dgv_modulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_modulos.Location = new System.Drawing.Point(12, 329);
            this.Dgv_modulos.Name = "Dgv_modulos";
            this.Dgv_modulos.Size = new System.Drawing.Size(675, 240);
            this.Dgv_modulos.TabIndex = 32;
            this.Dgv_modulos.Tag = "tbl_aplicaciones";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(52, 16);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(592, 159);
            this.navegador1.TabIndex = 31;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label1.Location = new System.Drawing.Point(121, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Activo";
            // 
            // Aplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(717, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_modulos);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtact);
            this.Controls.Add(this.idapp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Name = "Aplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion";
           
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_modulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtact;
        private System.Windows.Forms.TextBox idapp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_modulos;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Label label1;
    }
}