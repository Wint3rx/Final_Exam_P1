Proyecto Final para examen Programacion I
Hola, soy Franklin Lopez (Winter) para servirles, en este caso les presento mi proyecto de examen final que es una base
de datos sobre una cafeteria, donde la principal idea es tener un listado exacto de las cosas que tenemos y las que no,
para asi llevar un orden correcto de todas estas cosas, ademas, se estara usando para poder agregar datos extra si en 
caso se llega a necesitar, por otro lado, tenemos que esta base de datos utiliza un sistema CRUD (Create, Read, Update &
Delete) por lo que sera aun mas intuitivo para su uso diario y mas eficiente dentro del mismo.

Aplicamos un sistema de formulario con algunos datos, botones, cajas de texto, visualizadores de datos y otros apartados 
para poder hacer funcional el mismo. Utilizamos un sistema intuitivo, basico y facil de comprender para que no sea 
dificil su uso, ademas, que cualquier persona podria usarlo de la mejor manera con un poco de explicacion acerca del 
tema y su funcionamiento.

Ahora les dejo aca una pequenia explicacion acerca del codigo usado tanto para la base de datos en MySQL como en Visual 
Studio 2022.


Inicialmente creamos una base de datos con las siguientes tablas:

CREATE TABLE TiposCafe (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion TEXT
);

CREATE TABLE TiposMolienda (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion TEXT
);

CREATE TABLE TiposCoccion (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion TEXT
);

CREATE TABLE Saborizantes (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion TEXT
);

CREATE TABLE Syrups (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion TEXT
);

CREATE TABLE TiposLeche (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion TEXT
);

Tras hacer esto comenzamos a trabajar los datos que iban a estar dentro de la misma como lo son estos:

INSERT INTO TiposCafe (Nombre, Descripcion) VALUES
('Arabica', 'Café de sabor suave y aromático.'),
('Robusta', 'Café de sabor fuerte y amargo.'),
('Liberica', 'Café con notas florales y frutales.');

INSERT INTO TiposMolienda (Nombre, Descripcion) VALUES
('Fina', 'Molienda adecuada para espresso.'),
('Media', 'Molienda adecuada para cafetera de goteo.'),
('Gruesa', 'Molienda adecuada para prensa francesa.');

INSERT INTO TiposCoccion (Nombre, Descripcion) VALUES
('Espresso', 'Café preparado a alta presión en una máquina de espresso.'),
('Filtrado', 'Café preparado mediante filtración por gravedad.'),
('Prensa francesa', 'Café preparado mediante infusión en una prensa francesa.');

INSERT INTO Saborizantes (Nombre, Descripcion) VALUES
('Canela', 'Saborizante con un toque de especias y dulzura.'),
('Vainilla', 'Saborizante con un sabor suave y dulce.'),
('Cacao', 'Saborizante con un sabor a chocolate.');

INSERT INTO Syrups (Nombre, Descripcion) VALUES
('Vainilla', 'Jarabe con sabor a vainilla.'),
('Caramelo', 'Jarabe con sabor a caramelo.'),
('Avellana', 'Jarabe con sabor a avellana.');

INSERT INTO TiposLeche (Nombre, Descripcion) VALUES
('Entera', 'Leche con alto contenido de grasa.'),
('Descremada', 'Leche con bajo contenido de grasa.'),
('Almendra', 'Leche de origen vegetal hecha de almendras.');

Con estos datos ingresados ya podemos usar las tablas y saber de que es cada una, se hizo pequenia porque se penso para 
una empresa pequenia desde un inicio.


Luego de eso ya podemos entrar a Visual Studio 2022 creando un formulario para poder comenzar con nuestro codigo y 
nuestra interfaz completa para su uso.

Tras crear el formulario usamos estas herramientas para poder darle uso.

        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtID;
        private DataGridView dgvRegistros;
        private ComboBox cbTablas;
        private Button btnAgregar;
        private Button btnMostrar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;

Ahora que ya tenemos esto podemos iniciar nuestro codigo en el apartado Form1.cs

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

Con esta parte lo que hacemos es inicializar el constructor del formulario y ademas hacemos uso del combobox para 
agregar el nombre a las tablas.


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

En este punto estamos haciendo uso de un metodo para ejecutar las consultas de ecrtiura y como agregar los parametros 
para las consultas.


        // Método para ejecutar consultas de lectura (SELECT)
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

Aqui lo que hacemos es exactamente lo mismo que en anterior pero unicamente con el apartado de lectura.


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

En esta parte estamos haciendo dos cosas, la primera es un metodo para mostrar los registros de la tabla que se 
selecciono. Luego en la segunda parte es un metodo para actualizar un registro de la tabla seleccionada.


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

Ahora tenemos el ultimo metodo que es unicamente para eliminar los datos o registros en la tabla que se selecciono.


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


Ya para terminar tenemos los botones, los cuales cada uno tiene su debida funcion dentro del uso del CRUD, ademas de 
eso, cada boton tiene avisos para poder asegurarnos que la accion que estamos por hacer sea la correcta y estemos 
seguros de lo que estamos haciendo.
