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
    public partial class frmPresentacion : Form
    {
        //Variable que nos indica si vamos a insertar un nuevo producto
        private bool IsNuevo = false;
        //Variable que nos indica si vamos a modificar un producto
        private bool IsModificar = false;

        //Constructor del formulario
        public frmPresentacion()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el Nombre de la presentacion");

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
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtIdpresentacion.Text = string.Empty;
        }

        //Habilita los controles de los formularios
        private void Habilitar(bool Valor)
        {
            this.txtNombre.ReadOnly = !Valor;
            this.txtDescripcion.ReadOnly = !Valor;
            this.txtIdpresentacion.ReadOnly = !Valor;
        }
        //Habilita los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsModificar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnModificar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }
        private void OcultarColumnas()
        {
            this.datalistado.Columns[0].Visible = false;
            this.datalistado.Columns[1].Visible = false;
        }

        //Método Mostrar()

        private void Mostrar()
        {
            this.datalistado.DataSource = NPresentacion.Mostrar();
            this.OcultarColumnas();
            LblTotal.Text = "Total Registros: " + Convert.ToString(datalistado.Rows.Count);
        }

        //Método BuscarNombre

        private void BuscarNombre()
        {
            this.datalistado.DataSource = NPresentacion.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            LblTotal.Text = "Total Registros: " + Convert.ToString(datalistado.Rows.Count);
        }


        //Método Constructor

        private void frmPresentacion_Load(object sender, EventArgs e)
        {

            //Le decimos al DataGridView que no auto genere las columnas
            //Llenamos el DataGridView con la información
            //de todos nuestras categorías
            this.Mostrar();
            //Deshabilita los controles
            this.Habilitar(false);
            //Establece los botones
            this.Botones();

        }
        //Llamamos al Método Buscar

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsModificar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdpresentacion.Text = string.Empty;
            this.txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {

                //La variable que almacena si se inserto
                //o se modifico la tabla
                string Rpta = "";
                if (this.txtNombre.Text == string.Empty)
                {

                    MensajeError("Falta Ingresar algunos valores serán remarcados");
                    erroricono.SetError(txtNombre, "Ingrese Nombre");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        //Vamos a insertar un producto
                        Rpta = NPresentacion.Insertar(this.txtNombre.Text.Trim().ToUpper(),
                                   this.txtDescripcion.Text.Trim());

                    }
                    else
                    {
                        //Vamos a modificar un producto
                        Rpta = NPresentacion.Editar(Convert.ToInt32(this.txtIdpresentacion.Text),
                                     this.txtNombre.Text.Trim().ToUpper(),
                                     this.txtDescripcion.Text.Trim());
                    }
                    //Si la respuesta fue OK, fue porque se modifico
                    //o inserto el Producto
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
                    this.txtIdpresentacion.Text = "";

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void datalistado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdpresentacion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["idcategoria"].Value);
            this.txtNombre.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["nombre"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["descripcion"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un producto no puede modificar
            if (!this.txtIdpresentacion.Text.Equals(""))
            {
                this.IsModificar = true;
                this.Botones();
            }
            else
            {
                this.MensajeError("Debe de buscar un registro para Modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.IsNuevo = false;
            this.IsModificar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdpresentacion.Text = string.Empty;
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.datalistado.Columns[0].Visible = true;
            }
            else
            {
                this.datalistado.Columns[0].Visible = false;
            }
        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)datalistado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea eliminar los registros?", "Heavy Shop", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in datalistado.Rows)
                    {

                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NPresentacion.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se eliminó de forma correcta el registro");
                            }
                            else
                            {
                                //Mostramos el mensaje de error
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
    }
}

