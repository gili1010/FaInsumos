namespace WinFormsFront
{
    partial class FrmEliminarProveedor
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
            txtRZ = new TextBox();
            btnEliminar = new Button();
            txtCuit = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(331, 92);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(197, 45);
            label4.Name = "label4";
            label4.Size = new Size(220, 32);
            label4.TabIndex = 28;
            label4.Text = "Eliminar Proveedor";
            // 
            // button1
            // 
            button1.Location = new Point(331, 254);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 173);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 26;
            label3.Text = "Contacto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 131);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 25;
            label2.Text = "Razon Social";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 92);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 24;
            label1.Text = "Cuit";
            // 
            // txtContacto
            // 
            txtContacto.Enabled = false;
            txtContacto.Location = new Point(212, 170);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(194, 23);
            txtContacto.TabIndex = 23;
            // 
            // txtRZ
            // 
            txtRZ.Enabled = false;
            txtRZ.Location = new Point(212, 131);
            txtRZ.Name = "txtRZ";
            txtRZ.Size = new Size(194, 23);
            txtRZ.TabIndex = 22;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(227, 254);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(212, 92);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(113, 23);
            txtCuit.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 214);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 31;
            label5.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Enabled = false;
            txtDireccion.Location = new Point(212, 214);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(194, 23);
            txtDireccion.TabIndex = 30;
            // 
            // FrmEliminarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 342);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(btnBuscar);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContacto);
            Controls.Add(txtRZ);
            Controls.Add(btnEliminar);
            Controls.Add(txtCuit);
            Name = "FrmEliminarProveedor";
            Text = "FrmEliminarProveedor";
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
        private TextBox txtRZ;
        private Button btnEliminar;
        private TextBox txtCuit;
        private Label label5;
        private TextBox txtDireccion;
    }
}