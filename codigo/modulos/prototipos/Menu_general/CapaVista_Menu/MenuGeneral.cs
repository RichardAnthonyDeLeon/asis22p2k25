using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista_Seguridad;

namespace CapaVista_Menu
{
    public partial class MenuGeneral : Form
    {

        public MenuGeneral()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesión?", "Mensaje",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();//Cierra el formulario
        }

        private void consultaBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaRisko/AyudaConsultaP2.chm", "Consulta.html");
        }

        private void reporteAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Reporte frm = new Reporte();
            frm.Show();

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
