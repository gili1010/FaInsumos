namespace WinFormsFront
{
    partial class FrmModificarProd
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
            txtCodigo = new TextBox();
            btnModificar = new Button();
            txtNuevaDescr = new TextBox();
            txtNuevoStock = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(144, 65);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(113, 23);
            txtCodigo.TabIndex = 0;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(168, 188);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtNuevaDescr
            // 
            txtNuevaDescr.Location = new Point(144, 104);
            txtNuevaDescr.Name = "txtNuevaDescr";
            txtNuevaDescr.Size = new Size(194, 23);
            txtNuevaDescr.TabIndex = 2;
            txtNuevaDescr.TextChanged += txtNuevaDescr_TextChanged;
            // 
            // txtNuevoStock
            // 
            txtNuevoStock.Location = new Point(144, 143);
            txtNuevoStock.Name = "txtNuevoStock";
            txtNuevoStock.Size = new Size(194, 23);
            txtNuevoStock.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 65);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 4;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 104);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 146);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Stock";
            // 
            // button1
            // 
            button1.Location = new Point(263, 188);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(129, 18);
            label4.Name = "label4";
            label4.Size = new Size(223, 32);
            label4.TabIndex = 8;
            label4.Text = "Modificar Producto";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(263, 65);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmModificarProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(488, 312);
            Controls.Add(btnBuscar);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNuevoStock);
            Controls.Add(txtNuevaDescr);
            Controls.Add(btnModificar);
            Controls.Add(txtCodigo);
            Name = "FrmModificarProd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmModificarProd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Button btnModificar;
        private TextBox txtNuevaDescr;
        private TextBox txtNuevoStock;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Button btnBuscar;
    }
}