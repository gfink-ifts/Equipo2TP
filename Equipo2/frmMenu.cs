using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_Viajes
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        
        private void btn_destinos_Click(object sender, EventArgs e)
        {
            abm_Destinos abmd = new abm_Destinos();
            abmd.Show();
        }

        private void btn_tipoDeCambio_Click(object sender, EventArgs e)
        {
            tipoCambio tp = new tipoCambio();
            tp.Show();
        }

        private void btn_formasDePago_Click(object sender, EventArgs e)
        {
            fpago fp = new fpago();
            fp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ventas v = new Ventas();
            v.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.Show();
        }

        private void Paquetes_Click(object sender, EventArgs e)
        {
            txt_precio p = new txt_precio();
            p.Show();
        }
    }
}
