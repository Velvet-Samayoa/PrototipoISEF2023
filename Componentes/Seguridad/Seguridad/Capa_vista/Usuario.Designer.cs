
namespace Vista_Seguridad
{
    partial class Usuario
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
            this.check = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.CmbPA = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPA = new System.Windows.Forms.TextBox();
            this.TxtPAA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            this.label9 = new System.Windows.Forms.Label();
            this.btnverificar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(309, 251);
            this.check.Margin = new System.Windows.Forms.Padding(2);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(42, 17);
            this.check.TabIndex = 9;
            this.check.Text = "Ver";
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label6.Location = new System.Drawing.Point(18, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Username";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(117, 215);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(220, 20);
            this.txtusername.TabIndex = 7;
            this.txtusername.Tag = "username_usuario";

            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(117, 246);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(177, 20);
            this.txtcontraseña.TabIndex = 5;
            this.txtcontraseña.Tag = "password_usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label3.Location = new System.Drawing.Point(8, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(470, 286);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(215, 20);
            this.txtemail.TabIndex = 7;
            this.txtemail.Tag = "email_usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label7.Location = new System.Drawing.Point(399, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "email";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(470, 252);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(215, 20);
            this.txtapellido.TabIndex = 5;
            this.txtapellido.Tag = "apellido_usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label4.Location = new System.Drawing.Point(386, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(470, 218);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(215, 20);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.Tag = "nombre_usuario";

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label5.Location = new System.Drawing.Point(386, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(117, 283);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(177, 20);
            this.txtestado.TabIndex = 8;
            this.txtestado.Tag = "estado_usuario";
            // 
            // CmbPA
            // 
            this.CmbPA.FormattingEnabled = true;
            this.CmbPA.Items.AddRange(new object[] {
            "PRIMER MASCOTA",
            "COLOR FAVORITO",
            "CIUDAD NACIMIENTO",
            "SEGUNDO APELLIDO DEL PADRE",
            "PRIMER CENTRO DE ESTUDIO"});
            this.CmbPA.Location = new System.Drawing.Point(117, 324);
            this.CmbPA.Name = "CmbPA";
            this.CmbPA.Size = new System.Drawing.Size(121, 21);
            this.CmbPA.TabIndex = 11;
            this.CmbPA.SelectedIndexChanged += new System.EventHandler(this.CmbPA_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label8.Location = new System.Drawing.Point(386, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Respuesta";
            // 
            // TxtPA
            // 
            this.TxtPA.Location = new System.Drawing.Point(470, 321);
            this.TxtPA.Name = "TxtPA";
            this.TxtPA.Size = new System.Drawing.Size(114, 20);
            this.TxtPA.TabIndex = 9;
            this.TxtPA.Tag = "respuesta";
            // 
            // TxtPAA
            // 
            this.TxtPAA.Location = new System.Drawing.Point(244, 325);
            this.TxtPAA.Name = "TxtPAA";
            this.TxtPAA.Size = new System.Drawing.Size(93, 20);
            this.TxtPAA.TabIndex = 12;
            this.TxtPAA.Tag = "pregunta";
            this.TxtPAA.Visible = false;
            this.TxtPAA.TextChanged += new System.EventHandler(this.TxtPAA_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label2.Location = new System.Drawing.Point(18, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pregunta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label1.Location = new System.Drawing.Point(72, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(117, 183);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(220, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Tag = "pk_id_usuario";

            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 223);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.Tag = "tbl_usuarios";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(111, 3);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 83;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label9.Location = new System.Drawing.Point(43, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 84;
            this.label9.Text = "Estado";
            // 
            // btnverificar
            // 
            this.btnverificar.Location = new System.Drawing.Point(704, 218);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(75, 36);
            this.btnverificar.TabIndex = 85;
            this.btnverificar.Text = "Insertar";
            this.btnverificar.UseVisualStyleBackColor = true;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(704, 269);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 37);
            this.btnactualizar.TabIndex = 86;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(804, 599);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.CmbPA);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtPA);
            this.Controls.Add(this.TxtPAA);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.check);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label3);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbPA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPA;
        private System.Windows.Forms.TextBox TxtPAA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Button btnactualizar;
    }
}