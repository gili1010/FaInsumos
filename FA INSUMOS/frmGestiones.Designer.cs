namespace FA_INSUMOS
{
    partial class frmGestiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestiones));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialVentasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarArticuoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(974, 475);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(536, 46);
            this.label6.TabIndex = 10;
            this.label6.Text = "GESTIONES - FA INSUMOS";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.proveedoreToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nToolStripMenuItem,
            this.guardarVentaToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.historialVentasToolStripMenuItem,
            this.buscarVentaToolStripMenuItem,
            this.eliminarVentaToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nToolStripMenuItem.Text = "Registrar Venta";
            this.nToolStripMenuItem.Click += new System.EventHandler(this.nToolStripMenuItem_Click);
            // 
            // guardarVentaToolStripMenuItem
            // 
            this.guardarVentaToolStripMenuItem.Name = "guardarVentaToolStripMenuItem";
            this.guardarVentaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.guardarVentaToolStripMenuItem.Text = "Guardar Venta";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // historialVentasToolStripMenuItem
            // 
            this.historialVentasToolStripMenuItem.Name = "historialVentasToolStripMenuItem";
            this.historialVentasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.historialVentasToolStripMenuItem.Text = "Historial Ventas";
            // 
            // buscarVentaToolStripMenuItem
            // 
            this.buscarVentaToolStripMenuItem.Name = "buscarVentaToolStripMenuItem";
            this.buscarVentaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.buscarVentaToolStripMenuItem.Text = "Buscar Venta";
            // 
            // eliminarVentaToolStripMenuItem
            // 
            this.eliminarVentaToolStripMenuItem.Name = "eliminarVentaToolStripMenuItem";
            this.eliminarVentaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eliminarVentaToolStripMenuItem.Text = "Eliminar Venta";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCompraToolStripMenuItem,
            this.guardarCompraToolStripMenuItem,
            this.imprimirToolStripMenuItem1,
            this.historialVentasToolStripMenuItem1,
            this.buscarCompraToolStripMenuItem,
            this.eliminarCompraToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // nuevaCompraToolStripMenuItem
            // 
            this.nuevaCompraToolStripMenuItem.Name = "nuevaCompraToolStripMenuItem";
            this.nuevaCompraToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nuevaCompraToolStripMenuItem.Text = "Registrar Compra";
            this.nuevaCompraToolStripMenuItem.Click += new System.EventHandler(this.nuevaCompraToolStripMenuItem_Click);
            // 
            // guardarCompraToolStripMenuItem
            // 
            this.guardarCompraToolStripMenuItem.Name = "guardarCompraToolStripMenuItem";
            this.guardarCompraToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.guardarCompraToolStripMenuItem.Text = "Guardar Compra";
            this.guardarCompraToolStripMenuItem.Click += new System.EventHandler(this.guardarCompraToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem1
            // 
            this.imprimirToolStripMenuItem1.Name = "imprimirToolStripMenuItem1";
            this.imprimirToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.imprimirToolStripMenuItem1.Text = "Imprimir";
            // 
            // historialVentasToolStripMenuItem1
            // 
            this.historialVentasToolStripMenuItem1.Name = "historialVentasToolStripMenuItem1";
            this.historialVentasToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.historialVentasToolStripMenuItem1.Text = "Historial Compras";
            this.historialVentasToolStripMenuItem1.Click += new System.EventHandler(this.historialVentasToolStripMenuItem1_Click);
            // 
            // buscarCompraToolStripMenuItem
            // 
            this.buscarCompraToolStripMenuItem.Name = "buscarCompraToolStripMenuItem";
            this.buscarCompraToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.buscarCompraToolStripMenuItem.Text = "Buscar Compra";
            // 
            // eliminarCompraToolStripMenuItem
            // 
            this.eliminarCompraToolStripMenuItem.Name = "eliminarCompraToolStripMenuItem";
            this.eliminarCompraToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eliminarCompraToolStripMenuItem.Text = "Eliminar Compra";
            // 
            // proveedoreToolStripMenuItem
            // 
            this.proveedoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProveedorToolStripMenuItem,
            this.guardarProveedorToolStripMenuItem,
            this.imprimirToolStripMenuItem2,
            this.buscarProveedorToolStripMenuItem,
            this.consultarDatosToolStripMenuItem});
            this.proveedoreToolStripMenuItem.Name = "proveedoreToolStripMenuItem";
            this.proveedoreToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.proveedoreToolStripMenuItem.Text = "Proveedores";
            // 
            // nuevoProveedorToolStripMenuItem
            // 
            this.nuevoProveedorToolStripMenuItem.Name = "nuevoProveedorToolStripMenuItem";
            this.nuevoProveedorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nuevoProveedorToolStripMenuItem.Text = "Registrar Proveedor";
            // 
            // guardarProveedorToolStripMenuItem
            // 
            this.guardarProveedorToolStripMenuItem.Name = "guardarProveedorToolStripMenuItem";
            this.guardarProveedorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.guardarProveedorToolStripMenuItem.Text = "Guardar Proveedor";
            this.guardarProveedorToolStripMenuItem.Click += new System.EventHandler(this.guardarProveedorToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem2
            // 
            this.imprimirToolStripMenuItem2.Name = "imprimirToolStripMenuItem2";
            this.imprimirToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.imprimirToolStripMenuItem2.Text = "Imprimir ";
            // 
            // buscarProveedorToolStripMenuItem
            // 
            this.buscarProveedorToolStripMenuItem.Name = "buscarProveedorToolStripMenuItem";
            this.buscarProveedorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.buscarProveedorToolStripMenuItem.Text = "Buscar Proveedor";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.guardarClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem,
            this.consultarDatosToolStripMenuItem1});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArticuloToolStripMenuItem,
            this.consultarArticuoToolStripMenuItem,
            this.eliminarArticuloToolStripMenuItem,
            this.listarProductosToolStripMenuItem,
            this.modificarArticuloToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // consultarDatosToolStripMenuItem
            // 
            this.consultarDatosToolStripMenuItem.Name = "consultarDatosToolStripMenuItem";
            this.consultarDatosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.consultarDatosToolStripMenuItem.Text = "Consultar Datos";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.registrarClienteToolStripMenuItem.Text = "Registrar Cliente";
            // 
            // guardarClienteToolStripMenuItem
            // 
            this.guardarClienteToolStripMenuItem.Name = "guardarClienteToolStripMenuItem";
            this.guardarClienteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.guardarClienteToolStripMenuItem.Text = "Guardar Cliente";
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            // 
            // consultarDatosToolStripMenuItem1
            // 
            this.consultarDatosToolStripMenuItem1.Name = "consultarDatosToolStripMenuItem1";
            this.consultarDatosToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.consultarDatosToolStripMenuItem1.Text = "Consultar Datos";
            // 
            // listarProductosToolStripMenuItem
            // 
            this.listarProductosToolStripMenuItem.Name = "listarProductosToolStripMenuItem";
            this.listarProductosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listarProductosToolStripMenuItem.Text = "Listar Articulos";
            // 
            // consultarArticuoToolStripMenuItem
            // 
            this.consultarArticuoToolStripMenuItem.Name = "consultarArticuoToolStripMenuItem";
            this.consultarArticuoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.consultarArticuoToolStripMenuItem.Text = "Consultar Articulo";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            this.agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            this.agregarArticuloToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarArticuloToolStripMenuItem.Text = "Agregar Articulo";
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            this.eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            this.eliminarArticuloToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eliminarArticuloToolStripMenuItem.Text = "Eliminar Articulo";
            // 
            // modificarArticuloToolStripMenuItem
            // 
            this.modificarArticuloToolStripMenuItem.Name = "modificarArticuloToolStripMenuItem";
            this.modificarArticuloToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modificarArticuloToolStripMenuItem.Text = "Modificar Articulo";
            this.modificarArticuloToolStripMenuItem.Click += new System.EventHandler(this.modificarArticuloToolStripMenuItem_Click);
            // 
            // frmGestiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 617);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGestiones";
            this.Text = "GESTIONES - FA INSUMOS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historialVentasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem buscarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarArticuoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArticuloToolStripMenuItem;
    }
}