namespace WinFormsFront
{
    partial class FrmProveedorBuscar
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
            btnCancelar = new Button();
            txtContacto = new TextBox();
            txtRZ = new TextBox();
            txtTraerCuit = new TextBox();
            btnBuscar = new Button();
            txtIngresarCuit = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(426, 89);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtContacto
            // 
            txtContacto.Enabled = false;
            txtContacto.Location = new Point(242, 215);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(259, 23);
            txtContacto.TabIndex = 18;
            // 
            // txtRZ
            // 
            txtRZ.Enabled = false;
            txtRZ.Location = new Point(242, 175);
            txtRZ.Name = "txtRZ";
            txtRZ.Size = new Size(259, 23);
            txtRZ.TabIndex = 17;
            // 
            // txtTraerCuit
            // 
            txtTraerCuit.Enabled = false;
            txtTraerCuit.Location = new Point(242, 140);
            txtTraerCuit.Name = "txtTraerCuit";
            txtTraerCuit.Size = new Size(259, 23);
            txtTraerCuit.TabIndex = 16;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(345, 89);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtIngresarCuit
            // 
            txtIngresarCuit.Location = new Point(156, 89);
            txtIngresarCuit.Name = "txtIngresarCuit";
            txtIngresarCuit.PlaceholderText = "Ingrese Cuit Empresa";
            txtIngresarCuit.Size = new Size(163, 23);
            txtIngresarCuit.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 215);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 13;
            label4.Text = "Contacto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 178);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 12;
            label3.Text = "Razon Social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 143);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 11;
            label2.Text = "Cuit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(204, 35);
            label1.Name = "label1";
            label1.Size = new Size(238, 37);
            label1.TabIndex = 10;
            label1.Text = "Buscar  Proveedor";
            label1.Click += label1_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Enabled = false;
            txtDireccion.Location = new Point(242, 252);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(259, 23);
            txtDireccion.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 252);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 20;
            label5.Text = "Dirección";
            // 
            // FrmProveedorBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 304);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(txtContacto);
            Controls.Add(txtRZ);
            Controls.Add(txtTraerCuit);
            Controls.Add(btnBuscar);
            Controls.Add(txtIngresarCuit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProveedorBuscar";
            Text = "FrmProveedorBuscar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private TextBox txtContacto;
        private TextBox txtRZ;
        private TextBox txtTraerCuit;
        private Button btnBuscar;
        private TextBox txtIngresarCuit;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDireccion;
        private Label label5;
    }
}