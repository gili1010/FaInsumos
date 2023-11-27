namespace WinFormsApp1
{
    partial class FrmGestiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestiones));
            pictureBox1 = new PictureBox();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            nuevaVentaToolStripMenuItem = new ToolStripMenuItem();
            ventaPendienteToolStripMenuItem = new ToolStripMenuItem();
            guardarVentaToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            historialVentasToolStripMenuItem = new ToolStripMenuItem();
            devolucionesToolStripMenuItem = new ToolStripMenuItem();
            buscarVentaToolStripMenuItem = new ToolStripMenuItem();
            eliminarVentaToolStripMenuItem = new ToolStripMenuItem();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            buscarProveedorToolStripMenuItem = new ToolStripMenuItem();
            agregarProveedorToolStripMenuItem = new ToolStripMenuItem();
            modificarProveedorToolStripMenuItem = new ToolStripMenuItem();
            eliminarProveedorToolStripMenuItem = new ToolStripMenuItem();
            mostrarProveedoresToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            buscarProductoToolStripMenuItem = new ToolStripMenuItem();
            agregarProductoToolStripMenuItem = new ToolStripMenuItem();
            modificarProductoToolStripMenuItem = new ToolStripMenuItem();
            eliminarProductoToolStripMenuItem = new ToolStripMenuItem();
            mostrarProductosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            labelRol = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(482, 322);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaVentaToolStripMenuItem, ventaPendienteToolStripMenuItem, guardarVentaToolStripMenuItem, imprimirToolStripMenuItem, historialVentasToolStripMenuItem, devolucionesToolStripMenuItem, buscarVentaToolStripMenuItem, eliminarVentaToolStripMenuItem });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(53, 20);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            nuevaVentaToolStripMenuItem.Size = new Size(180, 22);
            nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            nuevaVentaToolStripMenuItem.Click += nuevaVentaToolStripMenuItem_Click;
            // 
            // ventaPendienteToolStripMenuItem
            // 
            ventaPendienteToolStripMenuItem.Name = "ventaPendienteToolStripMenuItem";
            ventaPendienteToolStripMenuItem.Size = new Size(180, 22);
            ventaPendienteToolStripMenuItem.Text = "Venta Pendiente";
            // 
            // guardarVentaToolStripMenuItem
            // 
            guardarVentaToolStripMenuItem.Name = "guardarVentaToolStripMenuItem";
            guardarVentaToolStripMenuItem.Size = new Size(180, 22);
            guardarVentaToolStripMenuItem.Text = "Guardar Venta";
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(180, 22);
            imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // historialVentasToolStripMenuItem
            // 
            historialVentasToolStripMenuItem.Name = "historialVentasToolStripMenuItem";
            historialVentasToolStripMenuItem.Size = new Size(180, 22);
            historialVentasToolStripMenuItem.Text = "Historial Ventas";
            historialVentasToolStripMenuItem.Click += historialVentasToolStripMenuItem_Click;
            // 
            // devolucionesToolStripMenuItem
            // 
            devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            devolucionesToolStripMenuItem.Size = new Size(180, 22);
            devolucionesToolStripMenuItem.Text = "Devoluciones";
            // 
            // buscarVentaToolStripMenuItem
            // 
            buscarVentaToolStripMenuItem.Name = "buscarVentaToolStripMenuItem";
            buscarVentaToolStripMenuItem.Size = new Size(180, 22);
            buscarVentaToolStripMenuItem.Text = "Buscar Venta";
            // 
            // eliminarVentaToolStripMenuItem
            // 
            eliminarVentaToolStripMenuItem.Name = "eliminarVentaToolStripMenuItem";
            eliminarVentaToolStripMenuItem.Size = new Size(180, 22);
            eliminarVentaToolStripMenuItem.Text = "Eliminar Venta";
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventaToolStripMenuItem });
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(67, 20);
            comprasToolStripMenuItem.Text = "Compras";
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(103, 22);
            ventaToolStripMenuItem.Text = "Venta";
            ventaToolStripMenuItem.Click += ventaToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarProveedorToolStripMenuItem, agregarProveedorToolStripMenuItem, modificarProveedorToolStripMenuItem, eliminarProveedorToolStripMenuItem, mostrarProveedoresToolStripMenuItem });
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(84, 20);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // buscarProveedorToolStripMenuItem
            // 
            buscarProveedorToolStripMenuItem.Name = "buscarProveedorToolStripMenuItem";
            buscarProveedorToolStripMenuItem.Size = new Size(183, 22);
            buscarProveedorToolStripMenuItem.Text = "Buscar Proveedor";
            buscarProveedorToolStripMenuItem.Click += buscarProveedorToolStripMenuItem_Click;
            // 
            // agregarProveedorToolStripMenuItem
            // 
            agregarProveedorToolStripMenuItem.Name = "agregarProveedorToolStripMenuItem";
            agregarProveedorToolStripMenuItem.Size = new Size(183, 22);
            agregarProveedorToolStripMenuItem.Text = "Agregar Proveedor";
            agregarProveedorToolStripMenuItem.Click += agregarProveedorToolStripMenuItem_Click;
            // 
            // modificarProveedorToolStripMenuItem
            // 
            modificarProveedorToolStripMenuItem.Name = "modificarProveedorToolStripMenuItem";
            modificarProveedorToolStripMenuItem.Size = new Size(183, 22);
            modificarProveedorToolStripMenuItem.Text = "Modificar Proveedor";
            modificarProveedorToolStripMenuItem.Click += modificarProveedorToolStripMenuItem_Click;
            // 
            // eliminarProveedorToolStripMenuItem
            // 
            eliminarProveedorToolStripMenuItem.Name = "eliminarProveedorToolStripMenuItem";
            eliminarProveedorToolStripMenuItem.Size = new Size(183, 22);
            eliminarProveedorToolStripMenuItem.Text = "Eliminar Proveedor";
            eliminarProveedorToolStripMenuItem.Click += eliminarProveedorToolStripMenuItem_Click_1;
            // 
            // mostrarProveedoresToolStripMenuItem
            // 
            mostrarProveedoresToolStripMenuItem.Name = "mostrarProveedoresToolStripMenuItem";
            mostrarProveedoresToolStripMenuItem.Size = new Size(183, 22);
            mostrarProveedoresToolStripMenuItem.Text = "Mostrar Proveedores";
            mostrarProveedoresToolStripMenuItem.Click += mostrarProveedoresToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarProductoToolStripMenuItem, agregarProductoToolStripMenuItem, modificarProductoToolStripMenuItem, eliminarProductoToolStripMenuItem, mostrarProductosToolStripMenuItem });
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(73, 20);
            stockToolStripMenuItem.Text = "Productos";
            // 
            // buscarProductoToolStripMenuItem
            // 
            buscarProductoToolStripMenuItem.Name = "buscarProductoToolStripMenuItem";
            buscarProductoToolStripMenuItem.Size = new Size(177, 22);
            buscarProductoToolStripMenuItem.Text = "Buscar Producto";
            buscarProductoToolStripMenuItem.Click += buscarProductoToolStripMenuItem_Click;
            // 
            // agregarProductoToolStripMenuItem
            // 
            agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            agregarProductoToolStripMenuItem.Size = new Size(177, 22);
            agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            agregarProductoToolStripMenuItem.Click += agregarProductoToolStripMenuItem_Click;
            // 
            // modificarProductoToolStripMenuItem
            // 
            modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            modificarProductoToolStripMenuItem.Size = new Size(177, 22);
            modificarProductoToolStripMenuItem.Text = "Modificar Producto";
            modificarProductoToolStripMenuItem.Click += modificarProductoToolStripMenuItem_Click;
            // 
            // eliminarProductoToolStripMenuItem
            // 
            eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            eliminarProductoToolStripMenuItem.Size = new Size(177, 22);
            eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            eliminarProductoToolStripMenuItem.Click += eliminarProductoToolStripMenuItem_Click;
            // 
            // mostrarProductosToolStripMenuItem
            // 
            mostrarProductosToolStripMenuItem.Name = "mostrarProductosToolStripMenuItem";
            mostrarProductosToolStripMenuItem.Size = new Size(177, 22);
            mostrarProductosToolStripMenuItem.Text = "Mostrar Productos";
            mostrarProductosToolStripMenuItem.Click += mostrarProductosToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ventasToolStripMenuItem, comprasToolStripMenuItem, proveedoresToolStripMenuItem, clientesToolStripMenuItem, stockToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Location = new Point(296, 33);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(0, 15);
            labelRol.TabIndex = 2;
            // 
            // FrmGestiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRol);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmGestiones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestiones - FA INSUMOS";
            Load += FrmGestiones_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private ToolStripMenuItem ventaPendienteToolStripMenuItem;
        private ToolStripMenuItem guardarVentaToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem historialVentasToolStripMenuItem;
        private ToolStripMenuItem devolucionesToolStripMenuItem;
        private ToolStripMenuItem buscarVentaToolStripMenuItem;
        private ToolStripMenuItem eliminarVentaToolStripMenuItem;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Label labelRol;
        private ToolStripMenuItem buscarProductoToolStripMenuItem;
        private ToolStripMenuItem agregarProductoToolStripMenuItem;
        private ToolStripMenuItem modificarProductoToolStripMenuItem;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private ToolStripMenuItem buscarProveedorToolStripMenuItem;
        private ToolStripMenuItem agregarProveedorToolStripMenuItem;
        private ToolStripMenuItem modificarProveedorToolStripMenuItem;
        private ToolStripMenuItem eliminarProveedorToolStripMenuItem;
        private ToolStripMenuItem mostrarProveedoresToolStripMenuItem;
        private ToolStripMenuItem mostrarProductosToolStripMenuItem;
        private ToolStripMenuItem ventaToolStripMenuItem;
    }
}