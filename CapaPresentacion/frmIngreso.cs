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
    public partial class frmIngreso : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public int Idtrabajador;

        private DataTable dtDetalle;

        private decimal totalPagado = 0;

        public static frmIngreso _instancia;

        public static frmIngreso GetInstancia()
        
        {
            if (_instancia == null)
            {
                _instancia = new frmIngreso();
            }
            return _instancia;

        }
        //Creamos un método para enviar los valores recibidos
        //del proveedor
        public void setProveedor(string idproveedor, string nombre)
        {
            this.txtIdproveedor.Text = idproveedor;
            this.txtProveedor.Text = nombre;
        }

        //Creamos un método para enviar los valores recibidos
        //del artículo
        public void setArticulo(string idarticulo, string nombre)
        {
            this.txtIdarticulo.Text = idarticulo;
            this.txtArticulo.Text = nombre;
        }
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmVistaProveedor_Ingreso vista = new frmVistaProveedor_Ingreso();
            vista.ShowDialog();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            frmVistaArticulo_Ingreso vista = new frmVistaArticulo_Ingreso();
            vista.ShowDialog();
        }

        public frmIngreso()
        {
            InitializeComponent();
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

        }

        private void frmIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        frmVistaProveedor_Ingreso vista = new frmVistaProveedor_Ingreso();
        vista.ShowDialog();

        }

        private void btnBuscarArticulo_Click_1(object sender, EventArgs e)
        {
            frmVistaArticulo_Ingreso vista = new frmVistaArticulo_Ingreso();
            vista.ShowDialog();

        }
    }
}
