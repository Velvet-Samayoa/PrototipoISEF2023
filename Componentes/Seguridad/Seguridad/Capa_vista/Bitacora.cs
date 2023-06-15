using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;
//Comentado por George Mayén 25/02/2023
namespace Vista_Seguridad
{
    public partial class Bitacora : Form
    {
        string emp = "tbl_bitacoradeeventos";
        Controlador cn = new Controlador();

        public Bitacora()
        {
            InitializeComponent();
        }

        //Método que llama al método de actualizardatagriew
        private void button1_Click(object sender, EventArgs e)
        {
            DateTimePicker[] dateTimePickers = { Dtp_inicio, Dtp_fin };
            cn.filtroBitacora(dateTimePickers, datag);
        }
    }
}
