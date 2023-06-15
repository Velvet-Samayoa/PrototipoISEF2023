
namespace Vista_Seguridad
{
    partial class Modulos
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
            this.txtact = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdModulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.Dgv_modulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_modulos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtact
            // 
            this.txtact.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtact.Location = new System.Drawing.Point(197, 321);
            this.txtact.Name = "txtact";
            this.txtact.Size = new System.Drawing.Size(244, 25);
            this.txtact.TabIndex = 2;
            this.txtact.Tag = "estado_modulo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(197, 280);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(244, 25);
            this.txtDescripcion.TabIndex = 28;
            this.txtDescripcion.Tag = "descripcion_modulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label5.Location = new System.Drawing.Point(52, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripcion";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtNombre.Location = new System.Drawing.Point(197, 236);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 25);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Tag = "nombre_modulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label3.Location = new System.Drawing.Point(52, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Modulo";
            
            // 
            // txtIdModulo
            // 
            this.txtIdModulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtIdModulo.Location = new System.Drawing.Point(197, 199);
            this.txtIdModulo.Name = "txtIdModulo";
            this.txtIdModulo.Size = new System.Drawing.Size(244, 25);
            this.txtIdModulo.TabIndex = 1;
            this.txtIdModulo.Tag = "pk_id_modulos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label2.Location = new System.Drawing.Point(52, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Modulo";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(33, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 29;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // Dgv_modulos
            // 
            this.Dgv_modulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_modulos.Location = new System.Drawing.Point(12, 372);
            this.Dgv_modulos.Name = "Dgv_modulos";
            this.Dgv_modulos.Size = new System.Drawing.Size(718, 240);
            this.Dgv_modulos.TabIndex = 30;
            this.Dgv_modulos.Tag = "tbl_modulos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label1.Location = new System.Drawing.Point(52, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Activo";
            // 
            // Modulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(745, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtact);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.Dgv_modulos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdModulo);
            this.Name = "Modulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulos";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_modulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdModulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtact;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.DataGridView Dgv_modulos;
        private System.Windows.Forms.Label label1;
    }
}