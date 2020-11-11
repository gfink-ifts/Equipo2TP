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
    public partial class abm_Destinos : Form
    {
        string cadenaConex = @"data source=.\SQLEXPRESS; initial catalog=Agencia; integrated security=SSPI";
        SqlConnection cn;

        public abm_Destinos()
        {
            InitializeComponent();
        }

        private void abm_Destinos_Load(object sender, EventArgs e)
        {
           cn = new SqlConnection(cadenaConex);
            
            //carga los combobox de paises y ciudades y sin id ambos
            cargarComboPaises();
            cargarComboCiudades();
            lbl_id_pais.Text = "";
            lbl_id_ciudad.Text = "";
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*-----------------------RADIOBUTTONS-------------------------------*/
        private void rbAltaPais_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAltaPais.Checked == true)
            {
                txt_pais.Enabled = true;
                cbo_pais.Enabled = false;
                lbl_id_pais.Text = "";
            }
                
        }

        private void rbModPais_CheckedChanged(object sender, EventArgs e)
        {
            if (rbModPais.Checked == true)
            {
                txt_pais.Enabled = true;
                cbo_pais.Enabled = true;
                lbl_id_pais.Text = cbo_pais.SelectedValue.ToString();
            }
                
        }

        private void rbBajaPais_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBajaPais.Checked == true)
            {
                txt_pais.Enabled = false;
                cbo_pais.Enabled = true;
                lbl_id_pais.Text = cbo_pais.SelectedValue.ToString();
            }
                
        }

        private void rbAltaCiudad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAltaCiudad.Checked == true)
            {
                txt_ciudad.Enabled = true;
                cbo_ciudad.Enabled = false;
                lbl_id_ciudad.Text = "";
            }
                
        }

        private void rbModCiudad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbModCiudad.Checked == true)
            {
                txt_ciudad.Enabled = true;
                cbo_ciudad.Enabled = true;
                lbl_id_ciudad.Text = cbo_ciudad.SelectedValue.ToString();
            }
                
        }

        private void rbBajaCiudad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBajaCiudad.Checked == true)
            {
                txt_ciudad.Enabled = false;
                cbo_ciudad.Enabled = true;
                lbl_id_ciudad.Text = cbo_ciudad.SelectedValue.ToString();
            }
                
        }


        /**--------------------------COMBOBOXES-----------------------------------*/

        private void cbo_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_id_pais.Text = cbo_pais.SelectedValue.ToString();               
        }

        private void cbo_ciudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_id_ciudad.Text = cbo_ciudad.SelectedValue.ToString();
        }

        /*---------------------------BOTONES CONFIRMACION-----------------------------*/
        private void btn_confirmarPais_Click(object sender, EventArgs e)
        {
            if (rbAltaPais.Checked == true)
            {
                if (txt_pais.Text == "")
                    MessageBox.Show("Debe ingresar el Pais");
                else
                {
                    generarAlta("Paises", "pais", txt_pais.Text);
                    //limpia formularios
                    txt_pais.Text = "";
                    lbl_id_pais.Text = "";
                }
                
            }
            if(rbModPais.Checked == true)
                generarMod("Paises", "pais", txt_pais.Text,cbo_pais.Text);
            if (rbBajaPais.Checked == true)
                generarBaja("Paises","pais", cbo_pais.Text);
            
        }

        private void btn_confirmarCiudad_Click(object sender, EventArgs e)
        {
            if (rbAltaCiudad.Checked == true)
            {
                if (txt_ciudad.Text == "")
                    MessageBox.Show("Debe ingresar una ciudad");
                else
                {
                    generarAlta("Ciudades", "ciudad", txt_ciudad.Text);
                    //limpia formularios
                    txt_ciudad.Text = "";
                    lbl_id_ciudad.Text = "";
                }
                
            }
            if (rbModCiudad.Checked == true)
                generarMod("Ciudades", "ciudad", txt_ciudad.Text, cbo_ciudad.Text);
            if (rbBajaCiudad.Checked == true)
                generarBaja("Ciudades", "ciudad", cbo_ciudad.Text);

        }


        //-----------------BOTONES MOSTRAR ---------------------------------//

        private void btn_mostrarPaises_Click(object sender, EventArgs e)
        {
            //carga los paises de la base de datos en el datagrid
            string query = "select pais from Paises";
            cargarDG(query);
        }

        private void btn_mostrarCiudades_Click(object sender, EventArgs e)
        {
            //carga las ciudades de la base de datos en el datagrid
            string query = "select ciudad from Ciudades";
            cargarDG(query);
        }

        private void btn_buscarDestino_Click(object sender, EventArgs e)
        {
            string destino = "'%" + txt_buscarDestino.Text + "%'";
            string query1 = "select pais as 'Destino'  from Paises where pais like " + destino;
            string query2 = "select ciudad as 'Destino' from Ciudades  where ciudad like " + destino;
            int i,j;
            SqlDataAdapter da;
            DataTable dt = new DataTable();           

            cn.Open();

            da = new SqlDataAdapter(query1, cn);
            da.Fill(dt);
            //agrego de forma dinamica una vez la columna Tipo de Destino para poner origen de la tabla
            dt.Columns.Add("Tipo de Destino", typeof(String));
            //este ciclo completa la columna creada con el dato paises para la tabla cargada
            for (i=0; i < dt.Rows.Count; i++)
                dt.Rows[i][1] = "paises";

            da = new SqlDataAdapter(query2, cn);
            da.Fill(dt);
            //repito el ciclo para completar campo ciudades en los elementos añadidos
            //el ciclo comineza desde la i anterior
            for (j = i; j < dt.Rows.Count; j++)
                dt.Rows[j][1] = "ciudades";

            dgDestinos.DataSource = dt;
            
            cn.Close();
            
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

            cbo_pais.DataSource = dt;
            cbo_pais.ValueMember = "id_pais";
            cbo_pais.DisplayMember = "pais";
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

            cbo_ciudad.DataSource = dt;
            cbo_ciudad.ValueMember = "id_ciudad";
            cbo_ciudad.DisplayMember = "ciudad";
            cn.Close();
           
        }

        //funcion para realizar la carga de datos en el datagrid
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

        

        //funcion para generar alta de paises o ciudades
        private void generarAlta(string tabla, string campo, string destino)
        {
            //validacion de cuadro de destino
            if (destino == "" && (tabla == "Paises")){
                MessageBox.Show("No ha ingresado el pais");
            }else{
                if (destino == "" && tabla == "Ciudades"){
                    MessageBox.Show("No ha ingresado la Ciudad");
                }else{
                    string query = "insert into " + tabla + "(" + campo + ") values('" + destino + "');";

                    SqlCommand alta = new SqlCommand(query, cn);
                    cn.Open();
                    alta.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Alta de " + campo + " generado correctamente");
                    if (tabla == "Paises")
                        cargarComboPaises();
                    if (tabla == "Ciudades")
                        cargarComboCiudades();
                }
            }
        }

        //funcion para generar modificacion de paises o ciudades
        private void generarMod(string tabla, string campo, string destino, string d)
        {
           
            string query = "update " + tabla + " set " + campo + " = '" + destino + "' where " + campo + "='" + d+"';";

            SqlCommand alta = new SqlCommand(query, cn);
            cn.Open();
            alta.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Modificacion de " + campo + " generado correctamente");
            if (tabla == "Paises")
                cargarComboPaises();
            if (tabla == "Ciudades")
                cargarComboCiudades();
        }

        //funcion para generar modificacion de paises o ciudades
        private void generarBaja(string tabla, string campo, string destino)
        {
            string query = "delete from " + tabla + " where " + campo + "='" + destino + "';";

            SqlCommand alta = new SqlCommand(query, cn);
            cn.Open();
            alta.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Eliminacion de " + campo + " generado correctamente");
            if (tabla == "Paises")
                cargarComboPaises();
            if (tabla == "Ciudades")
                cargarComboCiudades();
        }
      
    }
}
