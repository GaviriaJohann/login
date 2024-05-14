using datosPersonales.Clases;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datosPersonales
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public class DatosPersonales
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string contraseña = txtContraseña.Text;

            Connextion conexion = new Connextion();
            NpgsqlConnection conn = conexion.connection();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = "SELECT nombre, apellido FROM usuarios WHERE email = @email AND password = @contraseña";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("contraseña", contraseña);

                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            DatosPersonales datosUsuario = new DatosPersonales
                            {
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString()
                            };

                            MessageBox.Show("Inicio de sesión exitoso!");

                            frmAdmin admin = new frmAdmin(datosUsuario);
                            
                            admin.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al iniciar sesión: " + ex.Message);
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            frmFormulario frmFormulario = new frmFormulario();
            frmFormulario.Show();
            this.Hide();

        }
    }
}
