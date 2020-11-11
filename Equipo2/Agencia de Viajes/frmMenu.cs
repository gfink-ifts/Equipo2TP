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
            ABMDestinos abmd = new ABMDestinos();
            abmd.Show();
        }

        private void btn_tipoDeCambio_Click(object sender, EventArgs e)
        {
            tipoCambio tp = new tipoCambio();
            tp.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
