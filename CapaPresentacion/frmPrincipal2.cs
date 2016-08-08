using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal2 : Form
    {
        public string Idtrabajador = "";
        public string Apellidos = "";
        public string Nombre = "";
        public string Acceso = "";


        public frmPrincipal2()
        {
            InitializeComponent();
        }

        private void frmPrincipal2_Load(object sender, EventArgs e)
        {

            System.Windows.Forms.ContextMenu contextMenu1;
            contextMenu1 = new System.Windows.Forms.ContextMenu();
            System.Windows.Forms.MenuItem menuItem1;
            menuItem1 = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem menuItem2;
            menuItem2 = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem menuItem3;
            menuItem3 = new System.Windows.Forms.MenuItem();

            contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] { menuItem1, menuItem2, menuItem3 });
            menuItem1.Index = 0;
            menuItem1.Text = "MenuItem1";
            menuItem2.Index = 1;
            menuItem2.Text = "MenuItem2";
            menuItem3.Index = 2;
            menuItem3.Text = "MenuItem3";

            //textBox1.ContextMenu = contextMenu1;

            GestionUsuarios();
        }

        private void GestionUsuarios()
        {
            //Controlamos los accesos Administrador, Vendedor, ProveedorAlmacen
            if (Acceso == "Administrador")
            {
                this.MnuAlmacen.Enabled = true;
                this.MnuCompras.Enabled = true;
                this.MnuVentas.Enabled = true;
                this.MnuMantenimiento.Enabled = true;
                this.MnuConsultas.Enabled = true;
                this.MnuHerramientas.Enabled = true;
                this.TsCompras.Enabled = true;
                this.TsAdministrar.Enabled = true;

            }
            else if (Acceso == "Vendedor")
            {
                this.MnuAlmacen.Enabled = false;
                this.MnuCompras.Enabled = false;
                this.MnuVentas.Enabled = true;
                this.MnuMantenimiento.Enabled = false;
                this.MnuConsultas.Enabled = true;
                this.MnuHerramientas.Enabled = true;
                this.TsCompras.Enabled = false;
                this.TsAdministrar.Enabled = true;
            }
            else if (Acceso == "Almacenero")
            {
                this.MnuAlmacen.Enabled = true;
                this.MnuCompras.Enabled = true;
                this.MnuVentas.Enabled = false;
                this.MnuMantenimiento.Enabled = false;
                this.MnuConsultas.Enabled = true;
                this.MnuHerramientas.Enabled = true;
                this.TsCompras.Enabled = true;
                this.TsAdministrar.Enabled = true;
            }
            else
            {
                this.MnuAlmacen.Enabled = false;
                this.MnuCompras.Enabled = false;
                this.MnuVentas.Enabled = false;
                this.MnuMantenimiento.Enabled = false;
                this.MnuConsultas.Enabled = false;
                this.MnuHerramientas.Enabled = false;
                this.TsCompras.Enabled = false;
                this.TsAdministrar.Enabled = false;
            }
        }
        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void categoriasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria();
            frm.ShowDialog();
        }

        private void presentacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPresentacion frm = new frmPresentacion();
            frm.ShowDialog();
        }

        private void articulosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmArticulo frm = frmArticulo.GetInstancia();
            frm.ShowDialog();
            
        }

        private void proveedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProveedor frm = new frmProveedor();
            frm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.ShowDialog();
        }

        private void trabajadoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmTrabajador frm = new frmTrabajador();
            frm.ShowDialog();
        }

        private void TsVentas_Click(object sender, EventArgs e)
        {

        }

        private void TsCompra_Click(object sender, EventArgs e)
        {
            
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngreso frm = frmIngreso.GetInstancia();
            frm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcerca frm = new frmAcerca();
            frm.ShowDialog();

        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVenta frm = new frmVenta();
            frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmVenta frm = new frmVenta();
            frm.ShowDialog();
        }

        private void TsIngresos_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda frm = new frmAyuda();
            frm.ShowDialog();        }
    }
}
