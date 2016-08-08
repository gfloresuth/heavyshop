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
    public partial class frmProveedor : Form
    {
        //Variable que nos indica si vamos a insertar un nuevo producto
        private bool IsNuevo = false;
        //Variable que nos indica si vamos a modificar un producto
        private bool IsModificar = false;

        //Constructor del formulario
        public frmProveedor()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtRazon_Social, "Ingrese la Razón social del Proveedor");
            this.ttMensaje.SetToolTip(this.txtNum_Documento, "Ingrese el Documento del Proveedor");
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la Dirección del Proveedor");

        }

        //Para mostrar mensaje de confirmación
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Heavy Shop", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Para mostrar mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Heavy Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpia los controles del formulario
        private void Limpiar()
        {
            this.txtIdproveedor.Text = string.Empty;
            this.txtRazon_Social.Text = string.Empty;
            this.txtNum_Documento.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtUrl.Text = string.Empty;
        }
        //Habilita los controles de los formularios
        private void Habilitar(bool Valor)
        {
            this.txtIdproveedor.ReadOnly = !Valor;
            this.txtRazon_Social.ReadOnly = !Valor;
            this.cbSector_Comercial.Enabled = Valor;
            this.txtDireccion.ReadOnly = !Valor;
            this.cbTipo_Documento.Enabled = Valor;
            this.txtNum_Documento.Enabled = Valor;
            this.txtDireccion.ReadOnly = !Valor;
            this.txtTelefono.ReadOnly = !Valor;
            this.txtEmail.ReadOnly = !Valor;
            this.txtUrl.ReadOnly = !Valor;
        }
        //Habilita los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsModificar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }
        private void Mostrar()
        {
            this.dataListado.DataSource = NProveedor.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarRazon_Social()
        {
            this.dataListado.DataSource = NProveedor.BuscarRazon_Social(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void BuscarNum_Documento()
        {
            this.dataListado.DataSource = NProveedor.BuscarNum_Documento(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {

            //Le decimos al DataGridView que no auto genere las columnas
            //this.datalistado.AutoGenerateColumns = false;
            //Llenamos el DataGridView con la informacion
            //de todos nuestros Proveedores
            this.Mostrar();
            //Deshabilita los controles
            this.Habilitar(false);
            //Establece los botones
            this.Botones();

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Razon Social"))
            {
                this.BuscarRazon_Social();
            }
            else if (cbBuscar.Text.Equals("Documento"))
            {
                this.BuscarNum_Documento();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NProveedor.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se Eliminó Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }

                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsModificar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtRazon_Social.Focus();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {

                //La variable que almacena si se inserto 
                //o se modifico la tabla
                string Rpta = "";
                if (this.txtRazon_Social.Text == string.Empty || this.txtNum_Documento.Text == string.Empty || txtDireccion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtRazon_Social, "Ingrese un Valor");
                    errorIcono.SetError(txtNum_Documento, "Ingrese un Valor");
                    errorIcono.SetError(txtDireccion, "Ingrese un Valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        //Vamos a insertar un Proveedor
                        Rpta = NProveedor.Insertar(this.txtRazon_Social.Text.Trim().ToUpper(),
                        cbSector_Comercial.Text, cbTipo_Documento.Text,
                        txtNum_Documento.Text, txtDireccion.Text,
                        txtTelefono.Text, txtEmail.Text, txtUrl.Text);

                    }
                    else
                    {
                        //Vamos a modificar un Proveedor
                        Rpta = NProveedor.Editar(Convert.ToInt32(this.txtIdproveedor.Text),
                            this.txtRazon_Social.Text.Trim().ToUpper(),
                        cbSector_Comercial.Text, cbTipo_Documento.Text,
                        txtNum_Documento.Text, txtDireccion.Text,
                        txtTelefono.Text, txtEmail.Text, txtUrl.Text);
                    }
                    //Si la respuesta fue OK, fue porque se modifico 
                    //o inserto el Proveedor
                    //de forma correcta
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOK("Se insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOK("Se actualizó de forma correcta el registro");
                        }

                    }
                    else
                    {
                        //Mostramos el mensaje de error
                        this.MensajeError(Rpta);
                    }
                    this.IsNuevo = false;
                    this.IsModificar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.txtIdproveedor.Text = "";

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            //Si no ha seleccionado un Proveedor no puede modificar
            if (!this.txtIdproveedor.Text.Equals(""))
            {
                this.IsModificar = true;
                this.Botones();
            }
            else
            {
                this.MensajeError("Debe de buscar un registro para Modificar");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsModificar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdproveedor.Text = string.Empty;
        }

        private void dataListado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }


        private void chkEliminar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }


        private void dataListado_DoubleClick_1(object sender, EventArgs e)
        {
            this.txtIdproveedor.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idproveedor"].Value);
            this.txtRazon_Social.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["razon_social"].Value);
            this.cbSector_Comercial.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sector_comercial"].Value);
            this.cbTipo_Documento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_documento"].Value);
            this.txtNum_Documento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["num_documento"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);
            this.txtUrl.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["url"].Value);
            this.tabControl1.SelectedIndex = 1;
        }
    }
}
