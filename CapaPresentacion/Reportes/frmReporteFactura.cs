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
    public partial class frmReporteFactura : Form
    {
        private int _Idventa;

        public int Idventa
        {
            get { return _Idventa; }
            set { _Idventa = value; }
        }
        public frmReporteFactura()
        {
            InitializeComponent();
        }

        private void frmReporteFactura_Load(object sender, EventArgs e)
        {
            try
             { 
            // TODO: This line of code loads data into the 'dsPrincipal.spreporte_factura' table. You can move, or remove it, as needed.
            this.spreporte_facturaTableAdapter.Fill(this.dsPrincipal.spreporte_factura,Idventa);

            this.reportViewer1.RefreshReport();
             }
            catch (Exception Ex)
            {
                this.reportViewer1.RefreshReport();
            }
            }
    }
}
