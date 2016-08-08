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
    public partial class frmArticulo : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;

        private static frmArticulo _instancia;

        //Creamos una instancia para poder utilizar los
        //Objetos del formulario
        public static frmArticulo GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new frmArticulo();
            }
            return _instancia;
        }
        //Creamos un método para enviar los valores recibidos
        //a la caja de texto txtIdcategoria
        public void setCategoria(string idcategoria, string nombre)
        {
            this.txtIdcategoria.Text = idcategoria;
            this.txtCategoria.Text = nombre;
        }

        public frmArticulo()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el Nombre del Artículo");
            this.ttMensaje.SetToolTip(this.txtDescripcion, "Ingrese la descripción del Artículo");
            this.ttMensaje.SetToolTip(this.pxImagen, "Seleccione la imagen del artículo");
            this.txtIdcategoria.Visible = false;
            this.txtCategoria.ReadOnly = true;
            this.LlenarComboPresentacion();
        }


        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Heavy Shop", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Heavy Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtIdarticulo.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
            this.txtCategoria.Text = string.Empty;
            this.txtIdcategoria.Text = string.Empty;

            this.pxImagen.Image = global::CapaPresentacion.Properties.Resources.file2;


        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtCodigo.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.btnBuscarCategoria.Enabled = valor;
            this.cbIdpresentacion.Enabled = valor;
            this.txtIdarticulo.ReadOnly = !valor;
            this.btnCargar.Enabled = valor;
            this.btnLimpiar.Enabled = valor;
        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
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

        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.datalistado.Columns[0].Visible = false;
            this.datalistado.Columns[1].Visible = false;
            this.datalistado.Columns[6].Visible = false;
            this.datalistado.Columns[8].Visible = false;
        }

        //Método Mostrar
        private void Mostrar()
        {
            this.datalistado.DataSource = NArticulo.Mostrar();
            this.OcultarColumnas();
            LblTotal.Text = "Total de Registros: " + Convert.ToString(datalistado.Rows.Count);
        }

        //Método BuscarNombre
        private void BuscarNombre()
        {
            this.datalistado.DataSource = NArticulo.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            LblTotal.Text = "Total de Registros: " + Convert.ToString(datalistado.Rows.Count);

        }

        private void LlenarComboPresentacion()
        {
            cbIdpresentacion.DataSource = NPresentacion.Mostrar();
            cbIdpresentacion.ValueMember = "idpresentacion";
            cbIdpresentacion.DisplayMember = "nombre";
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog


            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pxImagen.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxImagen.Image = global::CapaPresentacion.Properties.Resources.file2;
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            
            //Le decimos al DataGridView que no auto genere las columnas
            //this.datalistado.AutoGenerateColumns = false;
            //Llenamos el DataGridView con la información
            //de todos nuestros Artículos
            this.Mostrar();
            //Deshabilita los controles
            this.Habilitar(false);
            //Establece los botones
            this.Botones();
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            frmVistaCategoria_Articulo vista = new frmVistaCategoria_Articulo();
            vista.ShowDialog();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtCodigo.Focus();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty || this.txtCodigo.Text == string.Empty || txtIdcategoria.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese un Valor");
                    errorIcono.SetError(txtCodigo, "Ingrese un Valor");
                    errorIcono.SetError(txtIdcategoria, "Ingrese un Valor");
                }
                else
                {
                    // Stream usado como buffer
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    // Se guarda la imagen en el buffer
                    pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imagen = ms.GetBuffer();


                    if (this.IsNuevo)
                    {

                        rpta = NArticulo.Insertar(this.txtCodigo.Text, this.txtNombre.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim(), imagen, Convert.ToInt32(txtIdcategoria.Text)
                            , Convert.ToInt32(cbIdpresentacion.SelectedValue));



                    }
                    else
                    {
                        rpta = NArticulo.Editar(Convert.ToInt32(this.txtIdarticulo.Text), this.txtCodigo.Text, this.txtNombre.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim(), imagen, Convert.ToInt32(txtIdcategoria.Text)
                            , Convert.ToInt32(cbIdpresentacion.SelectedValue));
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
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

        private void datalistado_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.txtIdarticulo.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["idarticulo"].Value);
            this.txtCodigo.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["codigo"].Value);
            this.txtNombre.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["nombre"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["descripcion"].Value);
            //Mostramos la Imagen
            // El campo imagen primero se almacena en un buffer
            byte[] imagenBuffer = (byte[])this.datalistado.CurrentRow.Cells["imagen"].Value;
            // Se crea un MemoryStream a partir de ese buffer
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
            // Se utiliza el MemoryStream para extraer la imagen
            this.pxImagen.Image = Image.FromStream(ms);
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;

            this.txtIdcategoria.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["idcategoria"].Value);
            this.txtCategoria.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Categoria"].Value);
            this.cbIdpresentacion.SelectedValue = Convert.ToString(this.datalistado.CurrentRow.Cells["idpresentacion"].Value);
            //this.cbIdpresentacion.DisplayMember = Convert.ToString(this.dataListado.CurrentRow.Cells["Presentacion"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (!this.txtIdarticulo.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void chkEliminar_CheckedChanged_1(object sender, EventArgs e)
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

        private void btnEliminar_Click_1(object sender, EventArgs e)
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
                            Rpta = NArticulo.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Eliminó Correctamente el registro");
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

        //private void datalistado_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void datalistado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void datalistado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}