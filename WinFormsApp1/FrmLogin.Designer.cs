namespace WinFormsApp1
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(txtUsuario);
            panel1.Location = new Point(495, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 318);
            panel1.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(56, 82);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(189, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(56, 126);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(189, 23);
            txtContraseña.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(109, 190);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnIngresar;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
    }
}