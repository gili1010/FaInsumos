namespace WinFormsFront
{
    partial class FrmEliminarProducto
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
            btnBuscar = new Button();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNuevoStock = new TextBox();
            txtNuevaDescr = new TextBox();
            btnEliminar = new Button();
            txtCodigo = new TextBox();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(302, 88);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(168, 41);
            label4.Name = "label4";
            label4.Size = new Size(207, 32);
            label4.TabIndex = 18;
            label4.Text = "Eliminar Producto";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(302, 211);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 169);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 16;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 127);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 15;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 88);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 14;
            label1.Text = "Codigo";
            // 
            // txtNuevoStock
            // 
            txtNuevoStock.Enabled = false;
            txtNuevoStock.Location = new Point(183, 166);
            txtNuevoStock.Name = "txtNuevoStock";
            txtNuevoStock.Size = new Size(194, 23);
            txtNuevoStock.TabIndex = 13;
            // 
            // txtNuevaDescr
            // 
            txtNuevaDescr.Enabled = false;
            txtNuevaDescr.Location = new Point(183, 127);
            txtNuevaDescr.Name = "txtNuevaDescr";
            txtNuevaDescr.Size = new Size(194, 23);
            txtNuevaDescr.TabIndex = 12;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(207, 211);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(183, 88);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(113, 23);
            txtCodigo.TabIndex = 10;
            // 
            // FrmEliminarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 450);
            Controls.Add(btnBuscar);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNuevoStock);
            Controls.Add(txtNuevaDescr);
            Controls.Add(btnEliminar);
            Controls.Add(txtCodigo);
            Name = "FrmEliminarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEliminarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Label label4;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNuevoStock;
        private TextBox txtNuevaDescr;
        private Button btnEliminar;
        private TextBox txtCodigo;
    }
}