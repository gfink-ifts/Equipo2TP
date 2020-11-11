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
    public partial class Reportes : Form
    {
        string cadenaConex = @"data source=.\SQLEXPRESS; initial catalog=Agencia; integrated security=SSPI";
        SqlConnection cn;

        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            cargarDG(null);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            cargarDG(txt_dni.Text);
        }

        //funcion para cargar DG
        private void cargarDG(string dni)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "select v.id_venta, v.fechaDeVenta, c.dni, c.apellido, c.nombre, v.id_paquete, pa.pais, ci.ciudad, f.formaDePago "
                         + "from Ventas as v, Clientes as c, Paquetes as p, Paises as pa, Ciudades as ci, FormaDePago as f "
                         + "where v.id_cliente = c.id_cliente and v.id_paquete = p.id_paquete and pa.id_pais = p.id_pais "
                         + "and ci.id_ciudad = p.id_ciudad and f.id_formaDePago = v.id_formaDePago";


            if (dni == null)
                query += " ;";
            else
                query += " and c.dni = " + txt_dni.Text + "; ";

            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            dgReportes.DataSource = dt;

            cn.Close();
        }

        
    }
}
