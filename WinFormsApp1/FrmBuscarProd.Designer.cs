namespace WinFormsFront
{
    partial class FrmBuscarProd
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIngresarCod = new TextBox();
            btnBuscar = new Button();
            txtTraerCod = new TextBox();
            txtTraerDesc = new TextBox();
            txtTraerStock = new TextBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(213, 22);
            label1.Name = "label1";
            label1.Size = new Size(225, 37);
            label1.TabIndex = 0;
            label1.Text = "Buscar  Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 119);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 154);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 191);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Stock";
            // 
            // txtIngresarCod
            // 
            txtIngresarCod.Location = new Point(153, 78);
            txtIngresarCod.Name = "txtIngresarCod";
            txtIngresarCod.PlaceholderText = "Ingrese Cod Producto";
            txtIngresarCod.Size = new Size(163, 23);
            txtIngresarCod.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(322, 78);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtTraerCod
            // 
            txtTraerCod.Enabled = false;
            txtTraerCod.Location = new Point(255, 120);
            txtTraerCod.Name = "txtTraerCod";
            txtTraerCod.Size = new Size(231, 23);
            txtTraerCod.TabIndex = 6;
            // 
            // txtTraerDesc
            // 
            txtTraerDesc.Enabled = false;
            txtTraerDesc.Location = new Point(255, 154);
            txtTraerDesc.Name = "txtTraerDesc";
            txtTraerDesc.Size = new Size(231, 23);
            txtTraerDesc.TabIndex = 7;
            // 
            // txtTraerStock
            // 
            txtTraerStock.Enabled = false;
            txtTraerStock.Location = new Point(255, 191);
            txtTraerStock.Name = "txtTraerStock";
            txtTraerStock.Size = new Size(231, 23);
            txtTraerStock.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(411, 78);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmBuscarProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(640, 303);
            Controls.Add(btnCancelar);
            Controls.Add(txtTraerStock);
            Controls.Add(txtTraerDesc);
            Controls.Add(txtTraerCod);
            Controls.Add(btnBuscar);
            Controls.Add(txtIngresarCod);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmBuscarProd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBuscarProd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIngresarCod;
        private Button btnBuscar;
        private TextBox txtTraerCod;
        private TextBox txtTraerDesc;
        private TextBox txtTraerStock;
        private Button btnCancelar;
    }
}