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
    public partial class Ventas : Form
    {
        string cadenaConex = @"data source=.\SQLEXPRESS; initial catalog=Agencia; integrated security=SSPI";
        SqlConnection cn;
        Boolean cargo = false; //uso la variable para evitar ejecutar cargarCiudades antes de que cargue el menu (no se porque lo ejecuta x3 (?))

        public Ventas()
        {
            InitializeComponent();
        }


        private void Ventas_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
            cargarTipoDeCambio();
            cargarFormasDePago();
            limpiarFormulario();
            cargarPaises();
            cargarCiudades();
            cargo = true;
        }

        private void cbo_paises_SelectedIndexChanged(object sender, EventArgs e)
        {
            //carga el combobox de ciudades con las que corresponden al pais elegido
            //ejecuta el metodo cargarCiudades luego de que carga el form
            if (cargo == true)
                cargarCiudades();            
        }

        /*-------------------------BOTONES---------------------------------------*/

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cargarDG(Convert.ToInt32(cbo_paises.SelectedValue), Convert.ToInt32(cbo_ciudades.SelectedValue));
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txt_dniCliente.Text == "")
                MessageBox.Show("Debe Ingresar un nro de DNI");
            else
            {
                string query = "select nombre, apellido, domicilio, telefono, email, id_cliente from Clientes where dni = " + txt_dniCliente.Text + ";";

                SqlDataAdapter da;
                DataTable dt = new DataTable();

                cn.Open();
                da = new SqlDataAdapter(query, cn);
                da.Fill(dt);
                cn.Close();

                if (dt.Rows.Count == 0)
                    MessageBox.Show("¡No existe Registro!");
                else
                {
                    lbl_nombreyapellido.Text = Convert.ToString(dt.Rows[0][0]) + " " + Convert.ToString(dt.Rows[0][1]);
                    lbl_domicilio.Text = Convert.ToString(dt.Rows[0][2]);
                    lbl_telefono.Text = Convert.ToString(dt.Rows[0][3]);
                    lbl_email.Text = Convert.ToString(dt.Rows[0][4]);
                    lbl_idcliente.Text = Convert.ToString(dt.Rows[0][5]);
                }
                
            }
            
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "select paq.id_paquete, p.pais, c.ciudad, paq.diasEstadia, paq.fechaDeInicio, "
                         + "paq.fechaDeFin, paq.detalles, paq.personas, paq.precio, paq.cantidad "
                         + "from Paquetes as paq, Paises as p, Ciudades as c "
                         + "where paq.id_pais = p.id_pais and paq.id_ciudad = c.id_ciudad "
                         + "and paq.id_paquete = @idpaq ;";

            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.SelectCommand.Parameters.AddWithValue("@idpaq", cbo_ids.SelectedValue);
            da.Fill(dt);
            //cargo los labels con los elementos del dt
            lbl_infoPais.Text = Convert.ToString(dt.Rows[0][1]);
            lbl_infoCiudad.Text = Convert.ToString(dt.Rows[0][2]);
            lbl_infoDiasEstadia.Text = Convert.ToString(dt.Rows[0][3]);
            lbl_infoFechaInicio.Text = Convert.ToString(dt.Rows[0][4]);
            lbl_infoFechaFin.Text = Convert.ToString(dt.Rows[0][5]);
            lbl_infoDetalles.Text = Convert.ToString(dt.Rows[0][6]);
            lbl_infoPersonas.Text = Convert.ToString(dt.Rows[0][7]);
            lbl_infoPrecioDolares.Text = Convert.ToString(dt.Rows[0][8]);
            lbl_infoPrecioPesos.Text = Convert.ToString(Convert.ToDouble(dt.Rows[0][8]) * Convert.ToDouble(lbl_tipoDeCambio.Text));
            lbl_infoCantidad.Text = Convert.ToString(dt.Rows[0][9]);
            cn.Close();
        }

        private void btn_cargarPaquete_Click(object sender, EventArgs e)
        {
            if (lbl_infoPrecioPesos.Text == "-")
                MessageBox.Show("¡Debe seleccionar un paquete!");
            else
            {
                if (lbl_infoCantidad.Text == "0")
                    MessageBox.Show("¡No hay paquetes disponibles para este destino!");
                else
                {
                    SqlDataAdapter da;
                    DataTable dt = new DataTable();
                    string query = "select paq.id_paquete, p.pais, c.ciudad, paq.diasEstadia, paq.fechaDeInicio, "
                                 + "paq.fechaDeFin, paq.detalles, paq.personas, paq.precio "
                                 + "from Paquetes as paq, Paises as p, Ciudades as c "
                                 + "where paq.id_pais = p.id_pais and paq.id_ciudad = c.id_ciudad "
                                 + "and paq.id_paquete = @idpaq ;";

                    cn.Open();
                    da = new SqlDataAdapter(query, cn);
                    da.SelectCommand.Parameters.AddWithValue("@idpaq", cbo_ids.SelectedValue);
                    da.Fill(dt);
                    //cargo los labels para confirmar la venta
                    lbl_idPaquete.Text = cbo_ids.Text;
                    lbl_pais.Text = Convert.ToString(dt.Rows[0][1]);
                    lbl_ciudad.Text = Convert.ToString(dt.Rows[0][2]);
                    lbl_diasEstadia.Text = Convert.ToString(dt.Rows[0][3]);
                    lbl_fechaInicio.Text = Convert.ToString(dt.Rows[0][4]);
                    lbl_fechaFin.Text = Convert.ToString(dt.Rows[0][5]);
                    lbl_infoPersonas.Text = Convert.ToString(dt.Rows[0][7]);
                    lbl_precioDolares.Text = Convert.ToString(dt.Rows[0][8]);
                    lbl_precioPesos.Text = Convert.ToString(Convert.ToDouble(dt.Rows[0][8]) * Convert.ToDouble(lbl_tipoDeCambio.Text));
                    cn.Close();
                }     
            }
        }

        //genera la venta con los datos cargados. primero realiza validacion
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txt_dniCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar DNI");
            }
            else
            {
                if(lbl_idPaquete.Text == "-")
                {
                    MessageBox.Show("Debe ingresar Paquete");
                }
                else
                {
                    if (cbo_formaDePago.Text == "")
                        MessageBox.Show("Debe ingresar una forma de pago");
                    else
                    {
                        //se genera la venta
                        DateTime fecha = DateTime.Now;

                        string query = "insert into Ventas(fechaDeVenta, id_cliente, id_paquete, precio, id_formaDePago)"
                                     + "values(@fecha, @idcliente, @idpaquete, @precio, @idfpago);";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.Parameters.AddWithValue("@idcliente",lbl_idcliente.Text);
                        cmd.Parameters.AddWithValue("@idpaquete", lbl_idPaquete.Text);
                        cmd.Parameters.AddWithValue("@precio", lbl_precioDolares.Text);
                        cmd.Parameters.AddWithValue("@idfpago", cbo_formaDePago.SelectedValue);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Venta realizada Exitosamente!");

                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes();
            r.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------------funciones------------------------------------//

        //funcion para cargar formas de pago en combobox
        private void cargarFormasDePago()
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

        //funcion carga tipo de cambio
        private void cargarTipoDeCambio()
        {
            string query = "select id_tipoCambio, valor from TipoCambio "
                         + "order by id_tipoCambio DESC";
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            cn.Close();

            lbl_tipoDeCambio.Text = Convert.ToString(dt.Rows[0][1]);
        }

        //funcion para limpiar formulario de venta
        private void limpiarFormulario()
        {
            txt_dniCliente.Text = "";
            lbl_idcliente.Text = "-";
            lbl_nombreyapellido.Text = "-";
            lbl_domicilio.Text = "-";
            lbl_telefono.Text = "-";
            lbl_email.Text = "-";
            lbl_idPaquete.Text = "-";
            lbl_pais.Text = "-";
            lbl_ciudad.Text = "-";
            lbl_fechaInicio.Text = "-";
            lbl_fechaFin.Text = "-";
            lbl_diasEstadia.Text = "-";
            lbl_precioDolares.Text = "-";
            lbl_precioPesos.Text = "-";
            cbo_formaDePago.Text = "";
        }

        //funcion para cargar comboboxes de paises
        private void cargarPaises()
        {
            //PROCESO: toma la tabla de paquetes, busca los id de paises y los carga en el
            //combobox con los nombres tomados de Paises (DISTINCT ELIMINA DUPLICADOS)
            string query = "select DISTINCT paq.id_pais, p.pais from Paquetes as paq, Paises as p where paq.id_pais = p.id_pais;";

            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);

            cbo_paises.DataSource = dt;
            cbo_paises.ValueMember = "id_pais";
            cbo_paises.DisplayMember = "pais";
            cn.Close();
        }
        //funcion para cargar combobox de ciudades
        private void cargarCiudades()
        {
            //PROCESO: toma la tabla de paquetes, busca los id de ciudades y los carga en el
            //combobox con los nombres tomados de Ciudades (DISTINCT ELIMINA DUPLICADOS)
            string query = "select DISTINCT paq.id_ciudad, c.ciudad from Paquetes as paq, Ciudades as c where paq.id_ciudad = c.id_ciudad and paq.id_pais = '" + cbo_paises.SelectedValue + "';";

            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);

            cbo_ciudades.DataSource = dt;
            cbo_ciudades.ValueMember = "id_ciudad";
            cbo_ciudades.DisplayMember = "ciudad";
            cn.Close();
        }
        //funcion para realizar la carga de datos en el datagrid
        private void cargarDG(int id_pais, int id_ciudad)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "select DISTINCT paq.id_paquete, p.pais, c.ciudad from Paquetes as paq, Paises as p, Ciudades as c "
                         + "where paq.id_pais = p.id_pais and paq.id_ciudad = c.id_ciudad "
                         + "and p.id_pais = @idp and c.id_ciudad = @idc";

            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.SelectCommand.Parameters.AddWithValue("@idp", id_pais);
            da.SelectCommand.Parameters.AddWithValue("@idc", id_ciudad);
            da.Fill(dt);
            dgPaquetes.DataSource = dt;
            cn.Close();

            cbo_ids.DataSource = dt;
            cbo_ids.ValueMember = "id_paquete";
            cbo_ids.DisplayMember = "id_paquete";
            cbo_ids.Text = "";
            cn.Close();
        }

        


    }
}
