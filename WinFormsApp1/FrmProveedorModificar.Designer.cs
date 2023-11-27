namespace WinFormsFront
{
    partial class FrmModificarProducto
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
            txtContacto = new TextBox();
            txtNuevoCuit = new TextBox();
            btnModificar = new Button();
            txtCuit = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label6 = new Label();
            txtRZ = new TextBox();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(317, 66);
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
            label4.Location = new Point(169, 22);
            label4.Name = "label4";
            label4.Size = new Size(236, 32);
            label4.TabIndex = 18;
            label4.Text = "Modificar Proveedor";
            // 
            // button1
            // 
            button1.Location = new Point(306, 253);
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
            label3.Location = new Point(116, 183);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 16;
            label3.Text = "Contacto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 108);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 15;
            label2.Text = "Cuit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 70);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 14;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(198, 180);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(194, 23);
            txtContacto.TabIndex = 13;
            // 
            // txtNuevoCuit
            // 
            txtNuevoCuit.Location = new Point(198, 108);
            txtNuevoCuit.Name = "txtNuevoCuit";
            txtNuevoCuit.Size = new Size(194, 23);
            txtNuevoCuit.TabIndex = 12;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(212, 253);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(116, 67);
            txtCuit.Name = "txtCuit";
            txtCuit.PlaceholderText = "Ingrese Cuit";
            txtCuit.Size = new Size(195, 23);
            txtCuit.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 222);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 21;
            label5.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(198, 219);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(194, 23);
            txtDireccion.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 147);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 23;
            label6.Text = "Razon Social";
            // 
            // txtRZ
            // 
            txtRZ.Location = new Point(198, 144);
            txtRZ.Name = "txtRZ";
            txtRZ.Size = new Size(194, 23);
            txtRZ.TabIndex = 22;
            // 
            // FrmModificarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 326);
            Controls.Add(label6);
            Controls.Add(txtRZ);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(btnBuscar);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContacto);
            Controls.Add(txtNuevoCuit);
            Controls.Add(btnModificar);
            Controls.Add(txtCuit);
            Name = "FrmModificarProducto";
            Text = "FrmModificarProveedor";
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
        private TextBox txtContacto;
        private TextBox txtNuevoCuit;
        private Button btnModificar;
        private TextBox txtCuit;
        private Label label5;
        private TextBox txtDireccion;
        private Label label6;
        private TextBox txtRZ;
    }
}