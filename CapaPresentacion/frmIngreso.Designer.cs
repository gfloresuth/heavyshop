namespace CapaPresentacion
{
    partial class frmIngreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngreso));
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIdarticulo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdproveedor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotal_Pagado = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataListadoDetalle = new System.Windows.Forms.DataGridView();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtFecha_Vencimiento = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecio_Venta = new System.Windows.Forms.TextBox();
            this.dtFecha_Produccion = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.texCorrelativo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipo_Comprobante = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtIdingreso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblTotal = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingresos Almacen";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // txtIdarticulo
            // 
            this.txtIdarticulo.Location = new System.Drawing.Point(26, 109);
            this.txtIdarticulo.Name = "txtIdarticulo";
            this.txtIdarticulo.Size = new System.Drawing.Size(81, 29);
            this.txtIdarticulo.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.txtIdproveedor);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtProveedor);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblTotal_Pagado);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.dataListadoDetalle);
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtIgv);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.texCorrelativo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbTipo_Comprobante);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Controls.Add(this.txtIdarticulo);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.txtIdingreso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos Almacen";
            // 
            // txtIdproveedor
            // 
            this.txtIdproveedor.Location = new System.Drawing.Point(282, 29);
            this.txtIdproveedor.Name = "txtIdproveedor";
            this.txtIdproveedor.Size = new System.Drawing.Size(81, 29);
            this.txtIdproveedor.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(361, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 22);
            this.label15.TabIndex = 41;
            this.label15.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(464, 29);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(147, 29);
            this.txtProveedor.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(620, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 26);
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotal_Pagado
            // 
            this.lblTotal_Pagado.AutoSize = true;
            this.lblTotal_Pagado.Location = new System.Drawing.Point(147, 381);
            this.lblTotal_Pagado.Name = "lblTotal_Pagado";
            this.lblTotal_Pagado.Size = new System.Drawing.Size(30, 22);
            this.lblTotal_Pagado.TabIndex = 40;
            this.lblTotal_Pagado.Text = "0.0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 381);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 22);
            this.label16.TabIndex = 39;
            this.label16.Text = "Total Pagado $: ";
            // 
            // dataListadoDetalle
            // 
            this.dataListadoDetalle.AllowUserToAddRows = false;
            this.dataListadoDetalle.AllowUserToDeleteRows = false;
            this.dataListadoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoDetalle.Location = new System.Drawing.Point(26, 292);
            this.dataListadoDetalle.Name = "dataListadoDetalle";
            this.dataListadoDetalle.Size = new System.Drawing.Size(811, 66);
            this.dataListadoDetalle.TabIndex = 32;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackgroundImage = global::CapaPresentacion.Properties.Resources._1470148065_No;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.Location = new System.Drawing.Point(852, 208);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(45, 36);
            this.btnQuitar.TabIndex = 31;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources._1470148044_Ok;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(852, 154);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(45, 37);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dtFecha_Vencimiento);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtPrecio_Venta);
            this.groupBox2.Controls.Add(this.dtFecha_Produccion);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPrecioCompra);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtStock);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtArticulo);
            this.groupBox2.Controls.Add(this.btnBuscarArticulo);
            this.groupBox2.Location = new System.Drawing.Point(20, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 100);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(567, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 22);
            this.label14.TabIndex = 37;
            this.label14.Text = "Fecha Vencimiento: ";
            // 
            // dtFecha_Vencimiento
            // 
            this.dtFecha_Vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha_Vencimiento.Location = new System.Drawing.Point(711, 61);
            this.dtFecha_Vencimiento.Name = "dtFecha_Vencimiento";
            this.dtFecha_Vencimiento.Size = new System.Drawing.Size(100, 29);
            this.dtFecha_Vencimiento.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(567, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 22);
            this.label13.TabIndex = 31;
            this.label13.Text = "Fecha Producción: ";
            // 
            // txtPrecio_Venta
            // 
            this.txtPrecio_Venta.Location = new System.Drawing.Point(440, 61);
            this.txtPrecio_Venta.Name = "txtPrecio_Venta";
            this.txtPrecio_Venta.Size = new System.Drawing.Size(109, 29);
            this.txtPrecio_Venta.TabIndex = 35;
            // 
            // dtFecha_Produccion
            // 
            this.dtFecha_Produccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha_Produccion.Location = new System.Drawing.Point(712, 18);
            this.dtFecha_Produccion.Name = "dtFecha_Produccion";
            this.dtFecha_Produccion.Size = new System.Drawing.Size(100, 29);
            this.dtFecha_Produccion.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 22);
            this.label12.TabIndex = 34;
            this.label12.Text = "Precio de Venta:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(440, 18);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(109, 29);
            this.txtPrecioCompra.TabIndex = 33;
            this.txtPrecioCompra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Precio de Compra:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(108, 68);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(147, 29);
            this.txtStock.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Artículo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Stock Inicial: ";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(108, 18);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(147, 29);
            this.txtArticulo.TabIndex = 16;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarArticulo.BackgroundImage")));
            this.btnBuscarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(262, 19);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(33, 26);
            this.btnBuscarArticulo.TabIndex = 18;
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click_1);
            // 
            // txtIgv
            // 
            this.txtIgv.Location = new System.Drawing.Point(575, 67);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.Size = new System.Drawing.Size(109, 29);
            this.txtIgv.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(526, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 22);
            this.label11.TabIndex = 27;
            this.label11.Text = "IVA: ";
            // 
            // texCorrelativo
            // 
            this.texCorrelativo.Location = new System.Drawing.Point(411, 67);
            this.texCorrelativo.Name = "texCorrelativo";
            this.texCorrelativo.Size = new System.Drawing.Size(109, 29);
            this.texCorrelativo.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Numero: ";
            // 
            // cbTipo_Comprobante
            // 
            this.cbTipo_Comprobante.FormattingEnabled = true;
            this.cbTipo_Comprobante.Items.AddRange(new object[] {
            "TICKET",
            "BOLETA",
            "FACTURA",
            "GUIA REMISION"});
            this.cbTipo_Comprobante.Location = new System.Drawing.Point(128, 66);
            this.cbTipo_Comprobante.Name = "cbTipo_Comprobante";
            this.cbTipo_Comprobante.Size = new System.Drawing.Size(121, 30);
            this.cbTipo_Comprobante.TabIndex = 24;
            this.cbTipo_Comprobante.TabStop = false;
            this.cbTipo_Comprobante.Text = "TICKET";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(654, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Fecha: ";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(718, 25);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(100, 29);
            this.dtFecha.TabIndex = 22;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::CapaPresentacion.Properties.Resources._1470173931_close;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(838, 381);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(59, 47);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::CapaPresentacion.Properties.Resources._1470173937_edit;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(718, 381);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(64, 47);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::CapaPresentacion.Properties.Resources._1470173947_save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(590, 381);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(63, 47);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::CapaPresentacion.Properties.Resources._1470173939_new;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.Location = new System.Drawing.Point(464, 381);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(61, 47);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(329, 66);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(76, 29);
            this.txtSerie.TabIndex = 4;
            // 
            // txtIdingreso
            // 
            this.txtIdingreso.Location = new System.Drawing.Point(109, 22);
            this.txtIdingreso.Name = "txtIdingreso";
            this.txtIdingreso.Size = new System.Drawing.Size(147, 29);
            this.txtIdingreso.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Comprobante:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(916, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administrar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(19, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 472);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dtFecha2);
            this.tabPage1.Controls.Add(this.dtFecha1);
            this.tabPage1.Controls.Add(this.datalistado);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.chkEliminar);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(916, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "Fecha Final";
            // 
            // dtFecha2
            // 
            this.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha2.Location = new System.Drawing.Point(118, 81);
            this.dtFecha2.Name = "dtFecha2";
            this.dtFecha2.Size = new System.Drawing.Size(105, 29);
            this.dtFecha2.TabIndex = 9;
            // 
            // dtFecha1
            // 
            this.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha1.Location = new System.Drawing.Point(118, 34);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(105, 29);
            this.dtFecha1.TabIndex = 8;
            // 
            // datalistado
            // 
            this.datalistado.AllowUserToAddRows = false;
            this.datalistado.AllowUserToDeleteRows = false;
            this.datalistado.AllowUserToOrderColumns = true;
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datalistado.Location = new System.Drawing.Point(7, 168);
            this.datalistado.MultiSelect = false;
            this.datalistado.Name = "datalistado";
            this.datalistado.ReadOnly = true;
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(903, 272);
            this.datalistado.TabIndex = 7;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(536, 118);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(0, 22);
            this.LblTotal.TabIndex = 6;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(7, 136);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(76, 26);
            this.chkEliminar.TabIndex = 5;
            this.chkEliminar.Text = "Anular";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources._1470173993_print2;
            this.btnImprimir.Location = new System.Drawing.Point(769, 11);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(141, 129);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources._1470027355_editor_trash_delete_recycle_bin_glyph;
            this.btnEliminar.Location = new System.Drawing.Point(540, 7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 131);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Anular";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::CapaPresentacion.Properties.Resources._1469969800_search;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(306, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 129);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Inicio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CapaPresentacion.Properties.Resources.heavyshop2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(824, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 54);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(955, 516);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIngreso";
            this.Text = ".:INGRESOS ALMACEN:.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIngreso_FormClosing);
            this.Load += new System.EventHandler(this.frmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtFecha2;
        private System.Windows.Forms.DateTimePicker dtFecha1;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox texCorrelativo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipo_Comprobante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.TextBox txtIdarticulo;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtIdingreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecio_Venta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtFecha_Vencimiento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtFecha_Produccion;
        private System.Windows.Forms.Label lblTotal_Pagado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataListadoDetalle;
        private System.Windows.Forms.TextBox txtIdproveedor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}