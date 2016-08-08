using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmVistaCategoria_Articulo : Form
    {
        public frmVistaCategoria_Articulo()
        {
            InitializeComponent();
        }

        private void frmVistaCategoria_Articulo_Load(object sender, EventArgs e)
        {
            this.Mostrar();

        }
        private void OcultarColumnas()
        {
            this.datalistado.Columns[0].Visible = false;
            this.datalistado.Columns[1].Visible = false;
        }
        private void Mostrar()
        {
            this.datalistado.DataSource = NCategoria.Mostrar();
            this.OcultarColumnas();
            LblTotal.Text = "Total Registros: " + Convert.ToString(datalistado.Rows.Count);
        }

        private void BuscarNombre()
        {
            this.datalistado.DataSource = NCategoria.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            LblTotal.Text = "Total Registros: " + Convert.ToString(datalistado.Rows.Count);
        }

   

        private void datalistado_DoubleClick_1(object sender, EventArgs e)
        {
            frmArticulo form = frmArticulo.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.datalistado.CurrentRow.Cells["idcategoria"].Value);
            par2 = Convert.ToString(this.datalistado.CurrentRow.Cells["nombre"].Value);
            form.setCategoria(par1, par2);
            this.Hide();

        }

    }
}
