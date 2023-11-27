namespace WinFormsFront
{
    partial class FrmNuevaVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnRegresar = new Button();
            dataGridView1 = new DataGridView();
            btnCofirmar = new Button();
            txtIdUsuario = new TextBox();
            txtIdProducto = new TextBox();
            txtCantidad = new TextBox();
            txtPrecioUnitario = new TextBox();
            btnAceptar = new Button();
            classEntidadesBindingSource = new BindingSource(components);
            btnBuscar = new Button();
            txtDescripcion = new TextBox();
            stock = new TextBox();
            label1 = new Label();
            Id = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)classEntidadesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(245, 279);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Producto, Cantidad, Descripcion, Precio, Total });
            dataGridView1.Location = new Point(310, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(420, 222);
            dataGridView1.TabIndex = 3;
            // 
            // btnCofirmar
            // 
            btnCofirmar.Location = new Point(61, 279);
            btnCofirmar.Name = "btnCofirmar";
            btnCofirmar.Size = new Size(75, 23);
            btnCofirmar.TabIndex = 6;
            btnCofirmar.Text = "Agregar";
            btnCofirmar.UseVisualStyleBackColor = true;
            btnCofirmar.Click += btnCofirmar_Click;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(61, 74);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.PlaceholderText = "Id usuario";
            txtIdUsuario.Size = new Size(193, 23);
            txtIdUsuario.TabIndex = 7;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(61, 30);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.PlaceholderText = "Id Producto";
            txtIdProducto.Size = new Size(95, 23);
            txtIdProducto.TabIndex = 9;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(61, 156);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "Cantidad";
            txtCantidad.Size = new Size(193, 23);
            txtCantidad.TabIndex = 10;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(61, 200);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.PlaceholderText = "Precio Unitario";
            txtPrecioUnitario.Size = new Size(193, 23);
            txtPrecioUnitario.TabIndex = 11;
            txtPrecioUnitario.TextChanged += txtPrecioUnitario_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(153, 279);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // classEntidadesBindingSource
            // 
            classEntidadesBindingSource.DataSource = typeof(AdminEntidades.ClassEntidades);
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(179, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.AutoCompleteSource = AutoCompleteSource.FileSystem;
            txtDescripcion.Location = new Point(62, 116);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripcion";
            txtDescripcion.Size = new Size(192, 23);
            txtDescripcion.TabIndex = 14;
            // 
            // stock
            // 
            stock.Location = new Point(154, 240);
            stock.Name = "stock";
            stock.PlaceholderText = "Stock";
            stock.Size = new Size(100, 23);
            stock.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 245);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 16;
            label1.Text = "Stock Actual";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.HeaderText = "Total";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Producto";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Cantidad";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Precio";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // FrmNuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(stock);
            Controls.Add(txtDescripcion);
            Controls.Add(btnBuscar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtCantidad);
            Controls.Add(txtIdProducto);
            Controls.Add(txtIdUsuario);
            Controls.Add(btnCofirmar);
            Controls.Add(btnRegresar);
            Controls.Add(dataGridView1);
            Name = "FrmNuevaVenta";
            Text = "FrmNuevaVenta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)classEntidadesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegresar;
        private DataGridView dataGridView1;
        private Button btnCofirmar;
        private TextBox txtIdUsuario;
        private TextBox txtIdProducto;
        private TextBox txtCantidad;
        private TextBox txtPrecioUnitario;
        private Button btnAceptar;
        private BindingSource classEntidadesBindingSource;
        private Button btnBuscar;
        private TextBox txtDescripcion;
        private TextBox stock;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
    }
}