namespace WinFormsFront
{
    partial class FrmMostrarProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarProveedores));
            dataGridView1 = new DataGridView();
            cuitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            RZ = new DataGridViewTextBoxColumn();
            nombrecontactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            classEntidadesBindingSource = new BindingSource(components);
            BtnImprimir = new Button();
            button2 = new Button();
            button3 = new Button();
            txtBuscar = new TextBox();
            bindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            classEntidadesBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)classEntidadesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)classEntidadesBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cuitDataGridViewTextBoxColumn, RZ, nombrecontactoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = classEntidadesBindingSource;
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(572, 300);
            dataGridView1.TabIndex = 0;
            // 
            // cuitDataGridViewTextBoxColumn
            // 
            cuitDataGridViewTextBoxColumn.DataPropertyName = "cuit";
            cuitDataGridViewTextBoxColumn.HeaderText = "cuit";
            cuitDataGridViewTextBoxColumn.Name = "cuitDataGridViewTextBoxColumn";
            cuitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RZ
            // 
            RZ.DataPropertyName = "RZ";
            RZ.HeaderText = "RZ";
            RZ.Name = "RZ";
            RZ.ReadOnly = true;
            RZ.Width = 150;
            // 
            // nombrecontactoDataGridViewTextBoxColumn
            // 
            nombrecontactoDataGridViewTextBoxColumn.DataPropertyName = "nombre_contacto";
            nombrecontactoDataGridViewTextBoxColumn.FillWeight = 200F;
            nombrecontactoDataGridViewTextBoxColumn.HeaderText = "contacto";
            nombrecontactoDataGridViewTextBoxColumn.Name = "nombrecontactoDataGridViewTextBoxColumn";
            nombrecontactoDataGridViewTextBoxColumn.ReadOnly = true;
            nombrecontactoDataGridViewTextBoxColumn.Width = 150;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.ReadOnly = true;
            direccionDataGridViewTextBoxColumn.Width = 250;
            // 
            // classEntidadesBindingSource
            // 
            classEntidadesBindingSource.DataSource = typeof(AdminEntidades.ClassEntidades);
            // 
            // BtnImprimir
            // 
            BtnImprimir.Location = new Point(26, 70);
            BtnImprimir.Name = "BtnImprimir";
            BtnImprimir.Size = new Size(112, 23);
            BtnImprimir.TabIndex = 1;
            BtnImprimir.Text = "Imprimir";
            BtnImprimir.UseVisualStyleBackColor = true;
            BtnImprimir.Click += BtnImprimir_Click;
            // 
            // button2
            // 
            button2.Location = new Point(26, 12);
            button2.Name = "button2";
            button2.Size = new Size(112, 23);
            button2.TabIndex = 2;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(26, 41);
            button3.Name = "button3";
            button3.Size = new Size(112, 23);
            button3.TabIndex = 3;
            button3.Text = "Regresar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(154, 13);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "   Ingrese Cuit a Buscar";
            txtBuscar.Size = new Size(582, 23);
            txtBuscar.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(154, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 292);
            panel1.TabIndex = 5;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += ImprimirProveedor;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // classEntidadesBindingSource1
            // 
            classEntidadesBindingSource1.DataSource = typeof(AdminEntidades.ClassEntidades);
            // 
            // FrmMostrarProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 358);
            Controls.Add(panel1);
            Controls.Add(txtBuscar);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(BtnImprimir);
            Name = "FrmMostrarProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMostrarProveedores";
            Load += FrmMostrarProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)classEntidadesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)classEntidadesBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn rZDataGridViewTextBoxColumn;
        private BindingSource classEntidadesBindingSource;
        private Button BtnImprimir;
        private Button button2;
        private Button button3;
        private TextBox txtBuscar;
        private BindingSource bindingSource1;
        private Panel panel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn RZ;
        private DataGridViewTextBoxColumn nombrecontactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private BindingSource classEntidadesBindingSource1;
    }
}