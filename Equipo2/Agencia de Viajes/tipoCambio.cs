using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Agencia_de_Viajes
{
    public partial class tipoCambio : Form
    {
        string cadenaConex = @"data source=nOTEBOOK\SQLEXPRESS; initial catalog=Agencia; integrated security=SSPI";
        SqlConnection cn;

        public tipoCambio()
        {
            InitializeComponent();
        }

        private void tipoCambio_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string query = "select id_tipoCambio, fecha, valor from TipoCambio" +
                "           order by id_tipoCambio DESC";
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            dgTipoCambio.DataSource = dt;

            cn.Close();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            //toma la fecha de hoy y le da formato para guardar en base de datos
            DateTime fecha = DateTime.Now;
            String fechaHoy = fecha.ToString("yyyy-MM-dd");
            string cotizacion = txt_cotizacion.Text;
            string query = "insert into TipoCambio(fecha, valor) values(@fec, @cot);";

            SqlCommand nuevacoti = new SqlCommand(query, cn);
            nuevacoti.Parameters.AddWithValue("@fec", fechaHoy);
            nuevacoti.Parameters.AddWithValue("@cot", cotizacion);

            cn.Open();
            nuevacoti.ExecuteNonQuery();
            cn.Close();
            btnConsultar_Click(null,null);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        
    }
}
