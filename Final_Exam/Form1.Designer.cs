namespace Final_Exam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtID = new TextBox();
            dgvRegistros = new DataGridView();
            cbTablas = new ComboBox();
            btnAgregar = new Button();
            btnMostrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(134, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(131, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(134, 66);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(131, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(134, 7);
            txtID.Name = "txtID";
            txtID.Size = new Size(131, 23);
            txtID.TabIndex = 2;
            // 
            // dgvRegistros
            // 
            dgvRegistros.BackgroundColor = Color.PaleTurquoise;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Location = new Point(12, 141);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.Size = new Size(664, 281);
            dgvRegistros.TabIndex = 3;
            // 
            // cbTablas
            // 
            cbTablas.FormattingEnabled = true;
            cbTablas.Location = new Point(134, 94);
            cbTablas.Name = "cbTablas";
            cbTablas.Size = new Size(131, 23);
            cbTablas.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(682, 141);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 30);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Create";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(682, 177);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(91, 30);
            btnMostrar.TabIndex = 6;
            btnMostrar.Text = "Read";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(682, 213);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(91, 30);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Update";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(682, 249);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 30);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Delete";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(40, 37);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 9;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 10;
            label2.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(86, 7);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 11;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(60, 94);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 12;
            label4.Text = "Tabla:";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.R__1_;
            pictureBox1.Image = Properties.Resources.R__1_;
            pictureBox1.Location = new Point(630, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 425);
            label5.Name = "label5";
            label5.Size = new Size(276, 21);
            label5.TabIndex = 14;
            label5.Text = "Made by: Franklin (Winter) Lopez";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(793, 456);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnMostrar);
            Controls.Add(btnAgregar);
            Controls.Add(cbTablas);
            Controls.Add(dgvRegistros);
            Controls.Add(txtID);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
    }
}
