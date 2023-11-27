namespace WinFormsFront
{
    partial class FrmMostrarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarProductos));
            classEntidadesBindingSource = new BindingSource(components);
            txtBuscar = new TextBox();
            button3 = new Button();
            button2 = new Button();
            BtnImprimir = new Button();
            negocioBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)classEntidadesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)negocioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // classEntidadesBindingSource
            // 
            classEntidadesBindingSource.DataSource = typeof(AdminEntidades.ClassEntidades);
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(173, 59);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "   Ingrese Codigo a Buscar";
            txtBuscar.Size = new Size(551, 23);
            txtBuscar.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(45, 87);
            button3.Name = "button3";
            button3.Size = new Size(112, 23);
            button3.TabIndex = 8;
            button3.Text = "Regresar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(45, 58);
            button2.Name = "button2";
            button2.Size = new Size(112, 23);
            button2.TabIndex = 7;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BtnImprimir
            // 
            BtnImprimir.Location = new Point(45, 116);
            BtnImprimir.Name = "BtnImprimir";
            BtnImprimir.Size = new Size(112, 23);
            BtnImprimir.TabIndex = 6;
            BtnImprimir.Text = "Imprimir";
            BtnImprimir.UseVisualStyleBackColor = true;
            BtnImprimir.Click += BtnImprimir_Click;
            // 
            // negocioBindingSource
            // 
            negocioBindingSource.DataSource = typeof(AdminNegocio.Negocio);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(551, 267);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(173, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 273);
            panel1.TabIndex = 11;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += ImprimirProducto;
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
            // FrmMostrarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 450);
            Controls.Add(panel1);
            Controls.Add(txtBuscar);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(BtnImprimir);
            Name = "FrmMostrarProductos";
            Text = "FrmMostrarProductos";
            Load += FrmMostrarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)classEntidadesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)negocioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource classEntidadesBindingSource;
        private TextBox txtBuscar;
        private Button button3;
        private Button button2;
        private Button BtnImprimir;
        private BindingSource negocioBindingSource;
        private DataGridView dataGridView1;
        private Panel panel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}