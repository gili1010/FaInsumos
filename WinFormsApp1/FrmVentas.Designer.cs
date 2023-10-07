namespace WinFormsFront
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            nuevaVentaToolStripMenuItem = new ToolStripMenuItem();
            ventaPendienteToolStripMenuItem = new ToolStripMenuItem();
            guardarVentaToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            historialDeVentasToolStripMenuItem = new ToolStripMenuItem();
            devolucionesToolStripMenuItem = new ToolStripMenuItem();
            buscarVentaToolStripMenuItem = new ToolStripMenuItem();
            eliminarVentaToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            buscarClientesToolStripMenuItem = new ToolStripMenuItem();
            agregarClienteToolStripMenuItem = new ToolStripMenuItem();
            modificarClienteToolStripMenuItem = new ToolStripMenuItem();
            labelRol = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(259, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 171);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ventasToolStripMenuItem, clientesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaVentaToolStripMenuItem, ventaPendienteToolStripMenuItem, guardarVentaToolStripMenuItem, imprimirToolStripMenuItem, historialDeVentasToolStripMenuItem, devolucionesToolStripMenuItem, buscarVentaToolStripMenuItem, eliminarVentaToolStripMenuItem });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(53, 20);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            nuevaVentaToolStripMenuItem.Size = new Size(171, 22);
            nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            // 
            // ventaPendienteToolStripMenuItem
            // 
            ventaPendienteToolStripMenuItem.Name = "ventaPendienteToolStripMenuItem";
            ventaPendienteToolStripMenuItem.Size = new Size(171, 22);
            ventaPendienteToolStripMenuItem.Text = "Venta Pendiente";
            // 
            // guardarVentaToolStripMenuItem
            // 
            guardarVentaToolStripMenuItem.Name = "guardarVentaToolStripMenuItem";
            guardarVentaToolStripMenuItem.Size = new Size(171, 22);
            guardarVentaToolStripMenuItem.Text = "Guardar Venta";
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(171, 22);
            imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // historialDeVentasToolStripMenuItem
            // 
            historialDeVentasToolStripMenuItem.Name = "historialDeVentasToolStripMenuItem";
            historialDeVentasToolStripMenuItem.Size = new Size(171, 22);
            historialDeVentasToolStripMenuItem.Text = "Historial de ventas";
            // 
            // devolucionesToolStripMenuItem
            // 
            devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            devolucionesToolStripMenuItem.Size = new Size(171, 22);
            devolucionesToolStripMenuItem.Text = "Devoluciones";
            // 
            // buscarVentaToolStripMenuItem
            // 
            buscarVentaToolStripMenuItem.Name = "buscarVentaToolStripMenuItem";
            buscarVentaToolStripMenuItem.Size = new Size(171, 22);
            buscarVentaToolStripMenuItem.Text = "Buscar Venta";
            // 
            // eliminarVentaToolStripMenuItem
            // 
            eliminarVentaToolStripMenuItem.Name = "eliminarVentaToolStripMenuItem";
            eliminarVentaToolStripMenuItem.Size = new Size(171, 22);
            eliminarVentaToolStripMenuItem.Text = "Eliminar Venta";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarClientesToolStripMenuItem, agregarClienteToolStripMenuItem, modificarClienteToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // buscarClientesToolStripMenuItem
            // 
            buscarClientesToolStripMenuItem.Name = "buscarClientesToolStripMenuItem";
            buscarClientesToolStripMenuItem.Size = new Size(165, 22);
            buscarClientesToolStripMenuItem.Text = "Buscar Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            agregarClienteToolStripMenuItem.Size = new Size(165, 22);
            agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            // 
            // modificarClienteToolStripMenuItem
            // 
            modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            modificarClienteToolStripMenuItem.Size = new Size(165, 22);
            modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Location = new Point(266, 51);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(0, 15);
            labelRol.TabIndex = 2;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRol);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmVentas";
            Text = "FrmVentas";
            Load += FrmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private ToolStripMenuItem ventaPendienteToolStripMenuItem;
        private ToolStripMenuItem guardarVentaToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem historialDeVentasToolStripMenuItem;
        private ToolStripMenuItem devolucionesToolStripMenuItem;
        private ToolStripMenuItem buscarVentaToolStripMenuItem;
        private ToolStripMenuItem eliminarVentaToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem buscarClientesToolStripMenuItem;
        private ToolStripMenuItem agregarClienteToolStripMenuItem;
        private ToolStripMenuItem modificarClienteToolStripMenuItem;
        private Label labelRol;
    }
}