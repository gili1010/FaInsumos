﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmGestiones : Form
    {
        public FrmGestiones(string rol)
        {
            InitializeComponent();

            // Mostrar el rol en el Label correspondiente en FrmGestiones
            labelRol.Text = "Rol: " + rol; // Ajusta el nombre del Label según corresponda
        }

        private void FrmGestiones_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
