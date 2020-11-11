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
    public partial class Clientes : Form
    {
        string cadenaConex = @"data source=.\SQLEXPRESS; initial catalog=Agencia; integrated security=SSPI";
        SqlConnection cn;
        public Clientes()
        {
            InitializeComponent();
        }
        /*-------------------Boton confirmar--------------------------
         * insert de clientes-------------------------------*/
        private void btn_confirmarCliente_Click(object sender, EventArgs e)
        {
            if (txt_Sexo.Enabled == true && rb_alta.Checked == true)
            {
                string nombre, apellido, domicilio, email, sexo;
                int edad, dni, telefono;

                DateTime fecha = DateTime.Now;
                String fechaHoy = fecha.ToString("yyyy-MM-dd");
                nombre = txt_nombre.Text;
                apellido = txt_apellido.Text;
                domicilio = txt_direccion.Text;
                email = txt_email.Text;
                edad = Convert.ToInt32(txt_edad.Text);
                dni = Convert.ToInt32(txt_dni_alta.Text);
                telefono = Convert.ToInt32(txt_telefono.Text);
                sexo = txt_Sexo.Text;
                string query = "insert into Clientes (nombre,apellido,sexo,edad,dni,domicilio,telefono,email,fecha_de_alta) values (@nombre,@apellido,@sexo,@edad,@dni,@domicilio,@telefono,@email,@fecha)";


                SqlCommand nuevocliente = new SqlCommand(query, cn);
                nuevocliente.Parameters.AddWithValue("@nombre", nombre);
                nuevocliente.Parameters.AddWithValue("@apellido", apellido);
                nuevocliente.Parameters.AddWithValue("@sexo", sexo);
                nuevocliente.Parameters.AddWithValue("@edad", edad);
                nuevocliente.Parameters.AddWithValue("@dni", dni);
                nuevocliente.Parameters.AddWithValue("@domicilio", domicilio);
                nuevocliente.Parameters.AddWithValue("@telefono", telefono);
                nuevocliente.Parameters.AddWithValue("@email", email);
                nuevocliente.Parameters.AddWithValue("@fecha", fechaHoy);

                cn.Open();
                nuevocliente.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Alta Generada Exitosamente");

                txt_Sexo.Enabled = false;
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
            }
            if (txt_Sexo.Enabled == true && rb_modificar.Checked == true)
            {
                string nombre, apellido, domicilio, email, sexo;
                int edad, dni, telefono;

                DateTime fecha = DateTime.Now;
                String fechaHoy = fecha.ToString("yyyy-MM-dd");
                nombre = txt_nombre.Text;
                apellido = txt_apellido.Text;
                domicilio = txt_direccion.Text;
                email = txt_email.Text;
                edad = Convert.ToInt32(txt_edad.Text);
                telefono = Convert.ToInt32(txt_telefono.Text);
                dni = Convert.ToInt32(txt_dni_busqueda.Text);
                sexo = txt_Sexo.Text;
                string query = "update Clientes set nombre=@nombre,apellido=@apellido,sexo=@sexo,edad=@edad,domicilio=@domicilio,telefono=@telefono,email=@email,fecha_de_alta=@fecha where dni=@dni";


                SqlCommand modificarcliente = new SqlCommand(query, cn);
                modificarcliente.Parameters.AddWithValue("@nombre", nombre);
                modificarcliente.Parameters.AddWithValue("@apellido", apellido);
                modificarcliente.Parameters.AddWithValue("@sexo", sexo);
                modificarcliente.Parameters.AddWithValue("@edad", edad);
                modificarcliente.Parameters.AddWithValue("@dni", dni);
                modificarcliente.Parameters.AddWithValue("@domicilio", domicilio);
                modificarcliente.Parameters.AddWithValue("@telefono", telefono);
                modificarcliente.Parameters.AddWithValue("@email", email);
                modificarcliente.Parameters.AddWithValue("@fecha", fechaHoy);

                cn.Open();
                modificarcliente.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Modificacion Generada Exitosamente");

                txt_Sexo.Enabled = false;
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
            }
            if (txt_Sexo.Enabled == true && rb_baja.Checked == true)
            {
                int dni = Convert.ToInt32(txt_dni_busqueda.Text);
                string query = "delete Clientes where dni= @dni";


                SqlCommand nuevocliente = new SqlCommand(query, cn);
                nuevocliente.Parameters.AddWithValue("@dni", dni);


                cn.Open();
                nuevocliente.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Baja Generada Exitosamente");

                txt_Sexo.Enabled = false;
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
            }


        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);

        }
        /*-----------------------RADIOBUTTONS-------------------------------*/
        private void rb_alta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cliente.Checked == true)
            {
                txt_dni_busqueda.Enabled = true;
                rb_Ord_fecha.Enabled = false;
                rb_Ord_Apellido.Enabled = false;
            }
        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_todos.Checked == true)
            {
                txt_dni_busqueda.Enabled = false;
                rb_Ord_fecha.Enabled = true;
                rb_Ord_Apellido.Enabled = true;
                rb_alta.Checked = true;
                rb_modificar.Checked = false;
                rb_baja.Checked = false;
                rb_alta.Enabled = true;
                rb_modificar.Enabled = false;
                rb_baja.Enabled = false;
            }
        }
        /*-------------------Boton Buscar--------------------------*/

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (rb_todos.Checked == true && rb_Ord_fecha.Checked == true)
            {
                string query = "select fecha_de_alta,nombre,apellido,edad,sexo,dni,domicilio,telefono,email from Clientes order by fecha_de_alta";
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                cn.Open();

                da = new SqlDataAdapter(query, cn);
                da.Fill(dt);

                cn.Close();

                dg_Clientes.DataSource = dt;
            }
            if (rb_todos.Checked == true && rb_Ord_Apellido.Checked == true)
            {

                string query = "select fecha_de_alta,nombre,apellido,edad,sexo,dni,domicilio,telefono,email from Clientes order by apellido";
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                cn.Open();

                da = new SqlDataAdapter(query, cn);
                da.Fill(dt);

                cn.Close();

                dg_Clientes.DataSource = dt;
            }
            if (rb_cliente.Checked == true && txt_dni_busqueda.Text != "")
            {
                rb_alta.Checked = false;
                rb_modificar.Checked = true;
                rb_baja.Checked = false;
                rb_alta.Enabled = false;
                rb_modificar.Enabled = true;
                rb_baja.Enabled = true;
                int dni = Convert.ToInt32(txt_dni_busqueda.Text);
                string query = "select fecha_de_alta,nombre,apellido,edad,sexo,dni,domicilio,telefono,email from Clientes where dni =" + dni;
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                cn.Open();

                da = new SqlDataAdapter(query, cn);
                da.Fill(dt);

                cn.Close();

                if (dt.Rows.Count > 0)
                {
                    txt_dni_alta.Text = txt_dni_busqueda.Text;
                    txt_nombre.Text = Convert.ToString(dt.Rows[0][1]);
                    txt_apellido.Text = Convert.ToString(dt.Rows[0][2]);
                    txt_edad.Text = Convert.ToString(dt.Rows[0][3]);
                    txt_Sexo.Text = Convert.ToString(dt.Rows[0][4]);
                    txt_direccion.Text = Convert.ToString(dt.Rows[0][6]);
                    txt_telefono.Text = Convert.ToString(dt.Rows[0][7]);
                    txt_email.Text = Convert.ToString(dt.Rows[0][8]);

                }
                dg_Clientes.DataSource = dt;
            }


        }

        private void cmb_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Sexo.Text = cmb_sexo.Text;
            txt_Sexo.Enabled = true;

        }


        ///----------------------------------------funciones ----------------------------------------/////


        ///--------Funcion para llenar los texbox-----------------------------------------------------/////
        private void llenarDatos()
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            if (rb_cliente.Checked == true)
            {
                if (txt_dni_busqueda.Text == "")
                    MessageBox.Show("Debe ingresar un DNI");
                else
                {
                    string query = "select v.id_venta, v.fechaDeVenta, c.dni, c.apellido, c.nombre, v.id_paquete, pa.pais, ci.ciudad, f.formaDePago "
                         + "from Ventas as v, Clientes as c, Paquetes as p, Paises as pa, Ciudades as ci, FormaDePago as f "
                         + "where v.id_cliente = c.id_cliente and v.id_paquete = p.id_paquete and pa.id_pais = p.id_pais "
                         + "and ci.id_ciudad = p.id_ciudad and f.id_formaDePago = v.id_formaDePago "
                         + "and c.dni = " + txt_dni_busqueda.Text + ";";
                    SqlDataAdapter da;
                    DataTable dt = new DataTable();

                    cn.Open();
                    da = new SqlDataAdapter(query, cn);
                    da.Fill(dt);
                    dg_historial.DataSource = dt;

                    cn.Close();
                }                
            }
            else
            {
                 string query = "select v.id_venta, v.fechaDeVenta, c.dni, c.apellido, c.nombre, v.id_paquete, pa.pais, ci.ciudad, f.formaDePago "
                         + "from Ventas as v, Clientes as c, Paquetes as p, Paises as pa, Ciudades as ci, FormaDePago as f "
                         + "where v.id_cliente = c.id_cliente and v.id_paquete = p.id_paquete and pa.id_pais = p.id_pais "
                         + "and ci.id_ciudad = p.id_ciudad and f.id_formaDePago = v.id_formaDePago ";
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                cn.Open();
                da = new SqlDataAdapter(query, cn);
                da.Fill(dt);
                dg_historial.DataSource = dt;

                cn.Close();
            }        
        }

        private void rb_cliente_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void rb_todos_CheckedChanged_1(object sender, EventArgs e)
        {
 
        }

        private void cmb_sexo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txt_Sexo.Text = cmb_sexo.Text;
        }
    }
}
