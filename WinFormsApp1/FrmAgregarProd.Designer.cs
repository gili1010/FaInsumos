namespace WinFormsFront
{
    partial class FrmAgregarProd
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
            txtCodigo = new TextBox();
            txtDesc = new TextBox();
            txtStock = new TextBox();
            btnAgregar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(144, 20);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 0;
            label1.Text = "Agregar Producto";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(161, 70);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(221, 23);
            txtCodigo.TabIndex = 1;
            txtCodigo.TextChanged += textBox1_TextChanged;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(161, 113);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(221, 23);
            txtDesc.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(162, 154);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(220, 23);
            txtStock.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(161, 217);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 73);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 121);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 6;
            label3.Text = "Descrpción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 162);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Stock";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(242, 217);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAgregarProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(464, 350);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(txtStock);
            Controls.Add(txtDesc);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Cursor = Cursors.IBeam;
            ForeColor = SystemColors.ControlText;
            Name = "FrmAgregarProd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAgregarProd";
            Load += FrmAgregarProd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private TextBox txtDesc;
        private TextBox txtStock;
        private Button btnAgregar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCancelar;
    }
}