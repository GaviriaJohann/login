using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using datosPersonales.Clases;
using Npgsql;


// Johann Mauricio Gaviria Rodriguez
// 27 - Feb - 2024
// este programa permite al usuario ingresar información en un formulario y proporciona
// validación en tiempo real para garantizar que los datos ingresados sean válidos antes
// de enviar el formulario. Los errores se muestran al usuario para corregirlos antes de
// enviar los datos.


namespace datosPersonales
{
    public partial class frmFormulario : Form
    {
        string generoSeleccionado;

        public frmFormulario()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (rdoMasculino.Checked)
            {
                generoSeleccionado = "Masculino";
            }
            else
            {
                generoSeleccionado = "Femenino";
            }

            Connextion conexion = new Connextion();
            NpgsqlConnection conn = conexion.connection();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                //int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string email = txtEmail.Text;
                string contraseña = txtContraseña.Text;
                string genero = generoSeleccionado;
                string eps = txtEps.Text;

                try
                {
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO usuarios (nombre, apellido, email, password, genero, eps) VALUES (@nombre, @apellido, @email, @password, @genero, @eps)";
                        //cmd.Parameters.AddWithValue("id", id);
                        cmd.Parameters.AddWithValue("nombre", nombre);
                        cmd.Parameters.AddWithValue("apellido", apellido);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("password", contraseña);
                        cmd.Parameters.AddWithValue("genero", genero);
                        cmd.Parameters.AddWithValue("eps", eps);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registro exitoso!");

                        frmLogin login = new frmLogin();

                        login.Show();

                        this.Hide();
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al registrar: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();

            login.Show();

            this.Hide();
        }
    }
}
