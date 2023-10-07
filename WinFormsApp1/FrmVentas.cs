using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFront
{
    public partial class FrmVentas : Form
    {
        public FrmVentas(string rol)
        {
            InitializeComponent();

            // Mostrar el rol en el Label correspondiente en FrmGestiones
            labelRol.Text = "Rol: " + rol; // Ajusta el nombre del Label según corresponda

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
