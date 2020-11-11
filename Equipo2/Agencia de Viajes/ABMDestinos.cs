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
    public partial class ABMDestinos : Form
    {
        string cadenaConex = @"data source=nOTEBOOK\SQLEXPRESS; initial catalog=Agencia; integrated security=SSPI";
        SqlConnection cn;

        public ABMDestinos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ABMDestinos_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);

            cargarComboPaises();
            cargarComboCiudades();

            //al ingresar al modulo de destinos configura los combobox para agregar nuevos destinos
            cbo_abmPais.SelectedIndex = 0;
            cbo_abmCiudad.SelectedIndex = 0;
            cbo_idPais.Enabled = false;
            cbo_idCiudad.Enabled = false;
        }

        private void cbo_abmPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //opciones que se habilitan/eshabilitan segun si es alta-baja-mod
            if (cbo_abmPais.SelectedIndex == 0)
            {
                //opciones de agregar pais
                cbo_idPais.Enabled = false;                
                btn_agregarPais.Enabled = true;
                btn_modificarPais.Enabled = false;
                btn_eliminarPais.Enabled = false;
                txt_pais.Enabled = true;
            }
            if (cbo_abmPais.SelectedIndex == 1)
            {
                //opciones de modificar pais
                cbo_idPais.Enabled = true;
                btn_agregarPais.Enabled = false;
                btn_modificarPais.Enabled = true;
                btn_eliminarPais.Enabled = false;
                txt_pais.Enabled = true;
            }
            if (cbo_abmPais.SelectedIndex == 2)
            {
                //opciones de eliminar pais
                cbo_idPais.Enabled = true;                
                btn_agregarPais.Enabled = false;
                btn_modificarPais.Enabled = false;
                btn_eliminarPais.Enabled = true;
                txt_pais.Enabled = false;
            }
        }

        private void cbo_abmCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //opciones que se habilitan/eshabilitan segun si es alta-baja-mod
            if (cbo_abmCiudad.SelectedIndex == 0)
            {
                //opciones de agregar ciudad
                cbo_idCiudad.Enabled = false;
                btn_agregarCiudad.Enabled = true;
                btn_modificarCiudad.Enabled = false;
                btn_eliminarCiudad.Enabled = false;
                txt_ciudad.Enabled = true;
            }
            if (cbo_abmCiudad.SelectedIndex == 1)
            {
                //opciones de modificar ciudad
                cbo_idCiudad.Enabled = true;
                btn_agregarCiudad.Enabled = false;
                btn_modificarCiudad.Enabled = true;
                btn_eliminarCiudad.Enabled = false;
                txt_ciudad.Enabled = true;
            }
            if (cbo_abmCiudad.SelectedIndex == 2)
            {
                //opciones de eliminar pais
                cbo_idCiudad.Enabled = true;
                btn_agregarCiudad.Enabled = false;
                btn_modificarCiudad.Enabled = false;
                btn_eliminarCiudad.Enabled = true;
                txt_ciudad.Enabled = false;
            }
        }


        //-----------------BOTONES MOSTRAR ---------------------------------//
        

        private void btn_mostrarPaises_Click(object sender, EventArgs e)
        {
            //carga los paises de la base de datos en el datagrid
            string query = "select id_pais, pais from Paises";
            cargarDG(query);
        }

        private void btn_mostrarCiudades_Click(object sender, EventArgs e)
        {
            //carga las ciudades de la base de datos en el datagrid
            string query = "select id_ciudad, ciudad from Ciudades";
            cargarDG(query);
        }

        private void btn_buscarDestino_Click(object sender, EventArgs e)
        {
                      
            string destino = "'%"+txt_buscarDestino.Text+"%'";
            string query = "select id_pais as 'ID PAIS/CIUDAD', pais as 'PAIS/CIUDAD' from Paises where pais like " + destino
                         + " union select id_ciudad, ciudad from Ciudades  where ciudad like "+ destino;
            cargarDG(query);
        }

        //---------------BOTONES ALTA-BAJA-MODIFICACION DE PAIS---------------------------------//

        private void btn_agregarPais_Click(object sender, EventArgs e)
        {
            
            string pais = txt_pais.Text;
            string query = "insert into Paises (pais) values (@p)";

            SqlCommand altapais = new SqlCommand(query, cn);
            altapais.Parameters.AddWithValue("@p", pais);

            cn.Open();
            altapais.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Pais Agregado Correctamente");
            cargarComboPaises();
        }
        

        private void btn_modificarPais_Click(object sender, EventArgs e)
        {
            string pais = txt_pais.Text;
            string id_pais = cbo_idPais.Text;
            string query = "update Paises set pais = @p where id_pais = @i";

            SqlCommand modpais = new SqlCommand(query, cn);
            modpais.Parameters.AddWithValue("@p", pais);
            modpais.Parameters.AddWithValue("@i", id_pais);

            cn.Open();
            modpais.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Pais Modificado Correctamente");
            
        }

        private void btn_eliminarPais_Click(object sender, EventArgs e)
        {
            string id_pais = cbo_idPais.Text;
            string query = "delete from Paises where id_pais = @idpais";

            SqlCommand bajapais = new SqlCommand(query, cn);
            bajapais.Parameters.AddWithValue("@idpais", id_pais);

            cn.Open();
            bajapais.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Pais Eliminado Correctamente");
            cargarComboPaises();
        }



        //---------------BOTONES ALTA-BAJA-MODIFICACION DE CIUDAD---------------------------------//

        

        private void btn_agregarCiudad_Click_1(object sender, EventArgs e)
        {
            string ciudad = txt_ciudad.Text;
            string query = "insert into Ciudades (ciudad) values (@c)";

            SqlCommand altaciudad = new SqlCommand(query, cn);
            altaciudad.Parameters.AddWithValue("@c", ciudad);

            cn.Open();
            altaciudad.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Ciudad Agregada Correctamente");
            cargarComboCiudades();
        }

        private void btn_modificarCiudad_Click(object sender, EventArgs e)
        {
            string ciudad = txt_ciudad.Text;
            string id_ciudad = cbo_idCiudad.Text;
            string query = "update Ciudades set ciudad = @c where id_ciudad = @i";

            SqlCommand modciudad = new SqlCommand(query, cn);
            modciudad.Parameters.AddWithValue("@c", ciudad);
            modciudad.Parameters.AddWithValue("@i", id_ciudad);

            cn.Open();
            modciudad.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Ciudad Modificada Correctamente");
        }

        private void btn_eliminarCiudad_Click(object sender, EventArgs e)
        {
            string id_ciudad = cbo_idCiudad.Text;
            string query = "delete from Ciudades where id_ciudad = @idciudad";


            SqlCommand bajaciudad = new SqlCommand(query, cn);
            bajaciudad.Parameters.AddWithValue("@idciudad", id_ciudad);

            cn.Open();
            bajaciudad.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Ciudad Eliminada Correctamente");
            cargarComboCiudades();
        }

        ///----------------------------------------funciones ----------------------------------------/////

        ///funcion para cargar los paises en el combobox
        ///se usan al iniciar el form, al agregar y eliminar un pais (actualiza)

        private void cargarComboPaises()
        {
            string query = "select id_pais, pais from Paises";
            
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);

            cbo_idPais.DataSource = dt;
            cbo_idPais.ValueMember = "id_pais";
            cbo_idPais.DisplayMember = "id_pais";
            cn.Close();
        }

        ///funcion para cargar las ciudades en el combobox
        ///se usan al iniciar el form, al agregar y eliminar una ciudad (actualiza)

        private void cargarComboCiudades()
        {
            string query = "select id_ciudad, ciudad from Ciudades";

            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);

            cbo_idCiudad.DataSource = dt;
            cbo_idCiudad.ValueMember = "id_ciudad";
            cbo_idCiudad.DisplayMember = "id_ciudad";
            cn.Close();
        }



        //metodo para realizar la carga de datos en el datagrid
        private void cargarDG(string query)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            dgDestinos.DataSource = dt;

            cn.Close();
        }

        
    }
}
