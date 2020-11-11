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
    public partial class fpago : Form
    {
        string cadenaConex = @"data source=.\SQLEXPRESS; initial catalog=Agencia; integrated security=SSPI";
        SqlConnection cn;

        public fpago()
        {
            InitializeComponent();
        }

        private void FormasDePago_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
            cargarFP();
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            string query = "select id_formaDePago, formaDePago from FormaDePago";
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            dgFormasDePago.DataSource = dt;

            cn.Close();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (rbAgregar.Checked == true)
            {
                if (txt_formaDePago.Text == "")
                    MessageBox.Show("Debe ingresar un nombre de forma de pago");
                else
                {
                    string query = "insert into FormaDePago(formaDePago) values('" + txt_formaDePago.Text + "');";

                    SqlCommand alta = new SqlCommand(query, cn);
                    cn.Open();
                    alta.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Alta de Forma de pago generada correctamente");
                    cargarFP();
                    btnMostar_Click(null, null);
                }

            }

            if (rbModificar.Checked == true)
            {
                string query = "update FormaDePago set formaDePago = '" + txt_formaDePago.Text + "' where formaDePago = '" + cbo_formaDePago.Text + "';";

                SqlCommand modificar = new SqlCommand(query, cn);
                cn.Open();
                modificar.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Modificacion de Forma de pago generada correctamente");
                cargarFP();
                btnMostar_Click(null, null);
            }

            if (rbEliminar.Checked == true)
            {
                string query = "delete from FormaDePago where formaDePago ='" + cbo_formaDePago.Text + "';";

                SqlCommand baja = new SqlCommand(query, cn);
                cn.Open();
                baja.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Eliminacion de Forma de pago generada correctamente");
                cargarFP();
                btnMostar_Click(null, null);
            }
            
        }

        

        /*-----------------------RADIOBUTTONS-------------------------------*/

        private void rbAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbAgregar.Checked == true)
            {
                cbo_formaDePago.Enabled = false;
                txt_formaDePago.Enabled = true;
                txt_formaDePago.Text = "";
            }
        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbModificar.Checked == true)
            {
                cbo_formaDePago.Enabled = true;
                txt_formaDePago.Enabled = true;
            }
        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEliminar.Checked == true)
            {
                cbo_formaDePago.Enabled = true;
                txt_formaDePago.Enabled = false;
            }
        }

        /*---------------------------------------Metodos---------------------------------------------------------*/

        private void cargarFP()
        {
            string query = "select id_formaDePago, formaDePago from FormaDePago";

            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);

            cbo_formaDePago.DataSource = dt;
            cbo_formaDePago.ValueMember = "id_formaDePago";
            cbo_formaDePago.DisplayMember = "formaDePago";
            cn.Close();

        }
    }
}
