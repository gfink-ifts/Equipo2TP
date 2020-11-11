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
    public partial class txt_precio : Form
    {
        string micadenaConex = @"data source= .\SQLEXPRESS; initial catalog=Agencia; integrated security=SSPI";
        SqlConnection cn;

        public txt_precio()
        {
            InitializeComponent();
        }

        private void Paquetes_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(micadenaConex);
            btn_agregar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_ver.Enabled = false;
            btn_eliminarpaq.Enabled = false;


            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false;
                }
            }
        }


        private void Paquetes_EnabledChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btn_BscPais_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(cbo_id.Text);
            string query2 = "select pa.id_paquete, p.pais, c.ciudad, pa.diasEstadia, pa.fechaDeInicio, pa.fechaDeFin, pa.detalles, pa.cantidad, pa.personas, pa.precio from paises as p, Paquetes as pa, ciudades as c where p.id_pais = pa.id_pais and pa. id_ciudad = c.id_ciudad and pa.id_paquete = @id";
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();
            da = new SqlDataAdapter(query2, cn);
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            da.Fill(dt);
            cn.Close();

            dataGridView1.DataSource = dt;
            if (dt.Rows.Count == 0)
                MessageBox.Show("¡No hay paquetes para la búsqueda!");
            else
            {
                lbl_pais.Text = Convert.ToString(dt.Rows[0][1]);
                lbl_ciudad.Text = Convert.ToString(dt.Rows[0][2]);
                lbl_estadia.Text = Convert.ToString(dt.Rows[0][3]);
                lbl_fein.Text = Convert.ToString(dt.Rows[0][4]);
                lbl_fefin.Text = Convert.ToString(dt.Rows[0][5]);
                lbl_det.Text = Convert.ToString(dt.Rows[0][6]);
                lbl_cant.Text = Convert.ToString(dt.Rows[0][7]);
                lbl_pers.Text = Convert.ToString(dt.Rows[0][8]);
                lbl_precio.Text = Convert.ToString(dt.Rows[0][9]);
                //agrega elementos de los labels cargados a los txt para modificar si corresponde
                if(rb_modificar.Checked == true)
                {
                    txt_id_pais.Text = lbl_pais.Text;
                    txt_id_ciudad.Text = lbl_ciudad.Text;
                    txt_diasestadia.Text = lbl_estadia.Text;
                    txt_fechainicio.Text = "";
                    txt_fechafin.Text = "";
                    txt_detalles.Text = lbl_det.Text;
                    txt_cantidad.Text = lbl_cant.Text;
                    txt_personas.Text = lbl_pers.Text;
                    txtPrecio.Text = lbl_precio.Text;
                    MessageBox.Show("Completar fecha de inicio y fin en formato YYYY-MM-DD");
                }

            }
        }

        private void btn_BscCiudad_Click(object sender, EventArgs e)
        {
            {
                string ciudad = txt_BscCiudad.Text;
                string pais = txt_BscPais.Text;
                string query = "select pa.id_paquete, p.pais, c.ciudad, pa.diasEstadia, pa.fechaDeInicio, pa.fechaDeFin, pa.detalles, pa.cantidad from paises as p, Paquetes as pa, ciudades as c where p.id_pais = pa.id_pais and pa. id_ciudad = c.id_ciudad and c.ciudad like @ciudad and p. pais like @pais";

                SqlDataAdapter da;
                DataTable dt = new DataTable();

                cn.Open();
                da = new SqlDataAdapter(query, cn);
                da.SelectCommand.Parameters.AddWithValue("@ciudad", "%" + ciudad + "%");
                da.SelectCommand.Parameters.AddWithValue("@pais", "%" + pais + "%");
                da.Fill(dt);
                cn.Close();
                dataGridView1.DataSource = dt;
            }
        }

        //alta de paquete
        private void button1_Click(object sender, EventArgs e)
        {
            string id_pais = buscarIdPais(txt_id_pais.Text);
            string id_ciudad = buscarIdCiudad(txt_id_ciudad.Text);
            string diasEstadia = txt_diasestadia.Text;
            string fechaDeInicio = txt_fechainicio.Text;
            string fechaDeFin = txt_fechafin.Text;
            string detalles = txt_detalles.Text;
            string cantidad = txt_cantidad.Text;
            string personas = txt_personas.Text;
            string precio = txtPrecio.Text;
            string cmd = "insert into Paquetes (id_pais, id_ciudad, diasEstadia, fechaDeInicio, fechaDeFin, detalles, cantidad, personas, precio) values (@id_pais, @id_ciudad, @diasEstadia, @fechaDeInicio, @fechaDeFin, @detalles, @cantidad, @personas, @precio)";
            SqlCommand comando = new SqlCommand(cmd, cn);
            comando.Parameters.AddWithValue("@id_pais", id_pais);
            comando.Parameters.AddWithValue("@id_ciudad", id_ciudad);
            comando.Parameters.AddWithValue("@diasEstadia", diasEstadia);
            comando.Parameters.AddWithValue("@fechaDeInicio", fechaDeInicio);
            comando.Parameters.AddWithValue("@fechaDeFin", fechaDeFin);
            comando.Parameters.AddWithValue("@detalles", detalles);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@personas", personas);
            comando.Parameters.AddWithValue("@precio", precio);
            cn.Open();
            comando.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("La carga se realizó con éxito");

            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rb_agregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_agregar.Checked)
            {
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Enabled = true;
                        btn_agregar.Enabled = true;

                    }
                }

            }
            else
            {
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Enabled = false;
                        btn_agregar.Enabled = false;

                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rb_modificar_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_modificar.Checked)
            {
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Enabled = true;
                        btn_modificar.Enabled = true;
                        cbo_ciudades.Enabled = true;
                        cbo_paises.Enabled = true;
                        btn_BscCiudad.Enabled = false;
                        btn_ver.Enabled = true;
                    }
                }
            }

            else
            {
                foreach (Control c in groupBox1.Controls)
                {
                    if (c
                        is TextBox)
                    {
                        c.Enabled = false;
                        btn_modificar.Enabled = false;
                        cbo_ciudades.Enabled = false;
                        cbo_paises.Enabled = false;
                        btn_BscCiudad.Enabled = true;
                        btn_ver.Enabled = true;
                    }
                }

            }

            string query = "select pa.id_paquete, p.pais, c.ciudad, pa.diasEstadia, pa.fechaDeInicio, pa.fechaDeFin, pa.detalles, pa.cantidad, pa.personas, pa.precio from paises as p, Paquetes as pa, ciudades as c where p.id_pais = pa.id_pais and pa. id_ciudad = c.id_ciudad;";

            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();

            da = new SqlDataAdapter(query, cn);
            //da.SelectCommand.Parameters.AddWithValue("@ciudad", "%" + ciudad + "%");
            //da.SelectCommand.Parameters.AddWithValue("@pais", "%" + pais + "%");

            da.Fill(dt);
            cn.Close();

            dataGridView1.DataSource = dt;
            cbo_paises.DataSource = dt;
            cbo_paises.DisplayMember = "pais";
            //cbo_paises.ValueMember = "id_paquete";

            cbo_ciudades.DataSource = dt;
            cbo_ciudades.DisplayMember = "ciudad";
            //cbo_ciudades.ValueMember = "id_paquete";

            cbo_id.DataSource = dt;
            cbo_id.DisplayMember = "id_paquete";



        }

        private void txt_fechainicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpiarFormulario()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

            }
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (txt_id_pais.Text == "" || txt_id_pais.Text == "" || txt_diasestadia.Text == "" || txt_fechainicio.Text == "" || txt_fechafin.Text == "" || txt_detalles.Text == "" || txt_cantidad.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
            }
            else
            {
                int id = Convert.ToInt16(cbo_id.Text);
                string id_pais = buscarIdPais(txt_id_pais.Text);
                string id_ciudad = buscarIdCiudad(txt_id_ciudad.Text);
                string diasEstadia = txt_diasestadia.Text;
                string fechaDeInicio = txt_fechainicio.Text;
                string fechaDeFin = txt_fechafin.Text;
                string detalles = txt_detalles.Text;
                string cantidad = txt_cantidad.Text;
                string personas = txt_personas.Text;
                string precio = txtPrecio.Text;
                string query3 = "update Paquetes set id_pais = @id_pais, id_ciudad = @id_ciudad, diasEstadia = @diasEstadia, fechaDeInicio = @fechaDeInicio, fechaDeFin = @fechaDeFin, Detalles = @detalles, cantidad = @cantidad, personas = @personas, precio = @precio where id_paquete = @id";
                SqlCommand comando = new SqlCommand(query3, cn);
                comando.Parameters.AddWithValue("@id_pais", id_pais);
                comando.Parameters.AddWithValue("@id_ciudad", id_ciudad);
                comando.Parameters.AddWithValue("@diasEstadia", diasEstadia);
                comando.Parameters.AddWithValue("@fechaDeInicio", fechaDeInicio);
                comando.Parameters.AddWithValue("@fechaDeFin", fechaDeFin);
                comando.Parameters.AddWithValue("@detalles", detalles);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@personas", personas);
                comando.Parameters.AddWithValue("@precio", precio);
                cn.Open();
                comando.ExecuteNonQuery();
                cn.Close();
            }
            limpiarFormulario();
        }

        private void rb_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_eliminar.Checked)
            {
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Enabled = false;
                        btn_modificar.Enabled = false;
                        cbo_ciudades.Enabled = false;
                        cbo_paises.Enabled = false;
                        cbo_id.Enabled = true;
                        btn_BscCiudad.Enabled = true;
                        btn_ver.Enabled = true;
                        btn_eliminarpaq.Enabled = true;
                    }

                }
            }
            string query4 = "select pa.id_paquete, p.pais, c.ciudad, pa.diasEstadia, pa.fechaDeInicio, pa.fechaDeFin, pa.detalles, pa.cantidad from paises as p, Paquetes as pa, ciudades as c where p.id_pais = pa.id_pais and pa. id_ciudad = c.id_ciudad";
            SqlDataAdapter da;
            DataTable dt = new DataTable();


            cn.Open();

            da = new SqlDataAdapter(query4, cn);
            da.Fill(dt);
            cn.Close();
            cbo_id.DataSource = dt;
            cbo_id.DisplayMember = "id_paquete";
            cbo_id.ValueMember = "id_paquete";

        }

        private void btn_eliminarpaq_Click(object sender, EventArgs e)

        {
            int idciu = Convert.ToInt16(cbo_id.SelectedValue);
            string queryelimin = "delete Paquetes where id_paquete = @id";
            SqlCommand comando = new SqlCommand(queryelimin, cn);
            comando.Parameters.AddWithValue("@id", idciu);
            cn.Open();
            comando.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Ud. acaba de eliminar el registro");

        }


        private void rb_agregar_CheckedChanged_1(object sender, EventArgs e)
        {
            btn_agregar.Enabled = true;
            btn_modificar.Enabled = false;
            btn_eliminarpaq.Enabled = false;
            btn_ver.Enabled = false;
            cbo_id.Enabled = false;
        }

        private void rb_modificar_CheckedChanged_1(object sender, EventArgs e)
        {
            btn_agregar.Enabled = false;
            btn_modificar.Enabled = true;
            btn_eliminarpaq.Enabled = false;
            btn_ver.Enabled = true;
            cbo_id.Enabled = true;
        }

        private void rb_eliminar_CheckedChanged_1(object sender, EventArgs e)
        {
            btn_agregar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_eliminarpaq.Enabled = true;
            btn_ver.Enabled = true;
            cbo_id.Enabled = true;
        }

        private string buscarIdPais(string pais)
        {
            string id;
            string query = "select id_pais from paises where pais = '" + pais + "'";
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            cn.Close();
            id = Convert.ToString(dt.Rows[0][0]);
            return id;
        }
        private string buscarIdCiudad(string ciudad)
        {
            string id;
            string query = "select id_ciudad from ciudades where ciudad = '" + ciudad + "'";
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            cn.Close();
            id = Convert.ToString(dt.Rows[0][0]);
            return id;
        }
    }
}
