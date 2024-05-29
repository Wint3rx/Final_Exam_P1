using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Final_Exam
{
    public partial class Form1 : Form
    {
        // Cadena de conexión a la base de datos MySQL
        private string connectionString = "Server=localhost;DataBase=cafeteriacrud;Uid=root;Pwd=Franklin23030917@";

        // Constructor del formulario
        public Form1()
        {
            InitializeComponent();
            InicializarComboBox();
        }

        // Método para inicializar el ComboBox con los nombres de las tablas
        private void InicializarComboBox()
        {
            cbTablas.Items.Add("TiposCafe");
            cbTablas.Items.Add("TiposMolienda");
            cbTablas.Items.Add("TiposCoccion");
            cbTablas.Items.Add("Saborizantes");
            cbTablas.Items.Add("Syrups");
            cbTablas.Items.Add("TiposLeche");
            cbTablas.SelectedIndex = 0; // Selecciona la primera tabla por defecto
        }

        // Método genérico para ejecutar consultas de escritura (INSERT, UPDATE, DELETE)
        private void EjecutarConsulta(string query, Dictionary<string, object> parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Agregar parámetros a la consulta
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    conn.Open();
                    try
                    {
                        // Ejecutar la consulta
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Operación realizada exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        // Método genérico para ejecutar consultas de lectura (SELECT)
        private DataTable EjecutarConsultaLectura(string query, Dictionary<string, object>? parameters = null)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Agregar parámetros a la consulta si existen
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Cargar resultados en un DataTable
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        // Método para agregar un registro a la tabla seleccionada
        private void AgregarRegistro(string tabla)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string query = $"INSERT INTO {tabla} (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)";

            var parameters = new Dictionary<string, object>
            {
                { "@Nombre", nombre },
                { "@Descripcion", descripcion }
            };

            EjecutarConsulta(query, parameters);
        }

        // Método para mostrar los registros de la tabla seleccionada en el DataGridView
        private void MostrarRegistros(string tabla)
        {
            string query = $"SELECT * FROM {tabla}";
            DataTable dt = EjecutarConsultaLectura(query);
            dgvRegistros.DataSource = dt;
        }

        // Método para actualizar un registro en la tabla seleccionada
        private void ActualizarRegistro(string tabla, int id)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string query = $"UPDATE {tabla} SET Nombre = @Nombre, Descripcion = @Descripcion WHERE ID = @ID";

            var parameters = new Dictionary<string, object>
            {
                { "@ID", id },
                { "@Nombre", nombre },
                { "@Descripcion", descripcion }
            };

            EjecutarConsulta(query, parameters);
        }

        // Método para eliminar un registro en la tabla seleccionada
        private void EliminarRegistro(string tabla, int id)
        {
            string query = $"DELETE FROM {tabla} WHERE ID = @ID";

            var parameters = new Dictionary<string, object>
            {
                { "@ID", id }
            };

            EjecutarConsulta(query, parameters);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string? tabla = cbTablas.SelectedItem?.ToString(); // Manejo de posibles valores NULL
            if (tabla != null)
            {
                MessageBox.Show("Agregar: " + tabla); // Mensaje de depuración
                AgregarRegistro(tabla);
            }
            else
            {
                MessageBox.Show("Seleccione una tabla válida.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string? tabla = cbTablas.SelectedItem?.ToString(); 
            if (tabla != null)
            {
                MessageBox.Show("Mostrar: " + tabla);
                MostrarRegistros(tabla);
            }
            else
            {
                MessageBox.Show("Seleccione una tabla válida.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                string? tabla = cbTablas.SelectedItem?.ToString(); 
                if (tabla != null)
                {
                    MessageBox.Show("Actualizar: " + tabla); 
                    ActualizarRegistro(tabla, id);
                }
                else
                {
                    MessageBox.Show("Seleccione una tabla válida.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                string? tabla = cbTablas.SelectedItem?.ToString(); 
                if (tabla != null)
                {
                    MessageBox.Show("Eliminar: " + tabla); 
                    EliminarRegistro(tabla, id);
                }
                else
                {
                    MessageBox.Show("Seleccione una tabla válida.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
