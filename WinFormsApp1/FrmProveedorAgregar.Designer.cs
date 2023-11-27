namespace WinFormsFront
{
    partial class FrmProveedorAgregar
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            txtContacto = new TextBox();
            txtRZ = new TextBox();
            txtCuit = new TextBox();
            label1 = new Label();
            label5 = new Label();
            txtDireccion = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(362, 292);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 198);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 16;
            label4.Text = "Contacto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 156);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 15;
            label3.Text = "Razon Social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 120);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 14;
            label2.Text = "Cuit";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(271, 292);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(239, 198);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(220, 23);
            txtContacto.TabIndex = 12;
            // 
            // txtRZ
            // 
            txtRZ.Location = new Point(238, 156);
            txtRZ.Name = "txtRZ";
            txtRZ.Size = new Size(221, 23);
            txtRZ.TabIndex = 11;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(238, 117);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(221, 23);
            txtCuit.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(193, 57);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 9;
            label1.Text = "Agregar Producto";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 241);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 19;
            label5.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(239, 241);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(220, 23);
            txtDireccion.TabIndex = 18;
            // 
            // FrmProveedorAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(txtContacto);
            Controls.Add(txtRZ);
            Controls.Add(txtCuit);
            Controls.Add(label1);
            Name = "FrmProveedorAgregar";
            Text = "FrmProveedorAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAgregar;
        private TextBox txtContacto;
        private TextBox txtRZ;
        private TextBox txtCuit;
        private Label label1;
        private Label label5;
        private TextBox txtDireccion;
    }
}