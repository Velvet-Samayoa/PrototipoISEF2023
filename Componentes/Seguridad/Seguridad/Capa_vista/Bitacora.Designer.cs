
namespace Vista_Seguridad
{
    partial class Bitacora
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
            this.datag = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.Dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datag)).BeginInit();
            this.SuspendLayout();
            // 
            // datag
            // 
            this.datag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datag.Location = new System.Drawing.Point(11, 129);
            this.datag.Margin = new System.Windows.Forms.Padding(2);
            this.datag.Name = "datag";
            this.datag.RowHeadersWidth = 51;
            this.datag.RowTemplate.Height = 24;
            this.datag.Size = new System.Drawing.Size(879, 445);
            this.datag.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.button1.Location = new System.Drawing.Point(535, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dtp_inicio
            // 
            this.Dtp_inicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.Dtp_inicio.Location = new System.Drawing.Point(168, 31);
            this.Dtp_inicio.Name = "Dtp_inicio";
            this.Dtp_inicio.Size = new System.Drawing.Size(333, 25);
            this.Dtp_inicio.TabIndex = 2;
            // 
            // Dtp_fin
            // 
            this.Dtp_fin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.Dtp_fin.Location = new System.Drawing.Point(168, 72);
            this.Dtp_fin.Name = "Dtp_fin";
            this.Dtp_fin.Size = new System.Drawing.Size(333, 25);
            this.Dtp_fin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label2.Location = new System.Drawing.Point(61, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Final";
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(898, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtp_fin);
            this.Controls.Add(this.Dtp_inicio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datag);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacora";
            ((System.ComponentModel.ISupportInitialize)(this.datag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Dtp_inicio;
        private System.Windows.Forms.DateTimePicker Dtp_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}