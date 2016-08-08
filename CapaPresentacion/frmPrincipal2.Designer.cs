namespace CapaPresentacion
{
    partial class frmPrincipal2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal2));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorFEchasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TsCompras = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.TsIngresos = new System.Windows.Forms.ToolStripButton();
            this.TSAlmacen = new System.Windows.Forms.ToolStripButton();
            this.TsAdministrar = new System.Windows.Forms.ToolStripButton();
            this.TsReportes = new System.Windows.Forms.ToolStripButton();
            this.TsAyuda = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip.Font = new System.Drawing.Font("Chiller", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSistema,
            this.MnuAlmacen,
            this.MnuCompras,
            this.MnuVentas,
            this.MnuMantenimiento,
            this.MnuConsultas,
            this.MnuHerramientas,
            this.MnuAyuda});
            this.menuStrip.Location = new System.Drawing.Point(0, 324);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1157, 46);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MnuSistema
            // 
            this.MnuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.MnuSistema.Image = global::CapaPresentacion.Properties.Resources.Skull_bw;
            this.MnuSistema.Name = "MnuSistema";
            this.MnuSistema.Size = new System.Drawing.Size(151, 42);
            this.MnuSistema.Text = "HeavyShop";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources._1470288768_log_out;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(139, 42);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // MnuAlmacen
            // 
            this.MnuAlmacen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.presentacionesToolStripMenuItem});
            this.MnuAlmacen.Image = global::CapaPresentacion.Properties.Resources._1470175606_warehouse;
            this.MnuAlmacen.Name = "MnuAlmacen";
            this.MnuAlmacen.Size = new System.Drawing.Size(131, 42);
            this.MnuAlmacen.Text = "Almacen";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources._1470288841_Cart_2;
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(246, 42);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click_1);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources._1470174578_category;
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(246, 42);
            this.categoriasToolStripMenuItem.Text = "Categorías";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click_1);
            // 
            // presentacionesToolStripMenuItem
            // 
            this.presentacionesToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources._1470174921_show_property;
            this.presentacionesToolStripMenuItem.Name = "presentacionesToolStripMenuItem";
            this.presentacionesToolStripMenuItem.Size = new System.Drawing.Size(246, 42);
            this.presentacionesToolStripMenuItem.Text = "Presentaciones";
            this.presentacionesToolStripMenuItem.Click += new System.EventHandler(this.presentacionesToolStripMenuItem_Click);
            // 
            // MnuCompras
            // 
            this.MnuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.proveedorToolStripMenuItem});
            this.MnuCompras.Image = global::CapaPresentacion.Properties.Resources._1470175699_aiga_cashier;
            this.MnuCompras.Name = "MnuCompras";
            this.MnuCompras.Size = new System.Drawing.Size(132, 42);
            this.MnuCompras.Text = "Compras";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources._1470288996_enter;
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(193, 42);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources._1470289080_Account_and_Control;
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(193, 42);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click_1);
            // 
            // MnuVentas
            // 
            this.MnuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem1,
            this.clientesToolStripMenuItem});
            this.MnuVentas.Image = global::CapaPresentacion.Properties.Resources._1470175771_ChirstmaxShop_cash;
            this.MnuVentas.Name = "MnuVentas";
            this.MnuVentas.Size = new System.Drawing.Size(113, 42);
            this.MnuVentas.Text = "Ventas";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Image = global::CapaPresentacion.Properties.Resources._1469939105_finance_21;
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(181, 42);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            this.ventasToolStripMenuItem1.Click += new System.EventHandler(this.ventasToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources._1470175061_5332___MySpace;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(181, 42);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // MnuMantenimiento
            // 
            this.MnuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabajadoresToolStripMenuItem});
            this.MnuMantenimiento.Image = global::CapaPresentacion.Properties.Resources._1470173996_pen7;
            this.MnuMantenimiento.Name = "MnuMantenimiento";
            this.MnuMantenimiento.Size = new System.Drawing.Size(163, 42);
            this.MnuMantenimiento.Text = "Administrar";
            // 
            // trabajadoresToolStripMenuItem
            // 
            this.trabajadoresToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources._1470174011_news2;
            this.trabajadoresToolStripMenuItem.Name = "trabajadoresToolStripMenuItem";
            this.trabajadoresToolStripMenuItem.Size = new System.Drawing.Size(224, 42);
            this.trabajadoresToolStripMenuItem.Text = "Trabajadores";
            this.trabajadoresToolStripMenuItem.Click += new System.EventHandler(this.trabajadoresToolStripMenuItem_Click_1);
            // 
            // MnuConsultas
            // 
            this.MnuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorFEchasToolStripMenuItem,
            this.comprasPorFechasToolStripMenuItem,
            this.stockArticulosToolStripMenuItem});
            this.MnuConsultas.Name = "MnuConsultas";
            this.MnuConsultas.Size = new System.Drawing.Size(130, 42);
            this.MnuConsultas.Text = "Consultas";
            // 
            // ventasPorFEchasToolStripMenuItem
            // 
            this.ventasPorFEchasToolStripMenuItem.Name = "ventasPorFEchasToolStripMenuItem";
            this.ventasPorFEchasToolStripMenuItem.Size = new System.Drawing.Size(303, 42);
            this.ventasPorFEchasToolStripMenuItem.Text = "Ventas Por Fechas";
            // 
            // comprasPorFechasToolStripMenuItem
            // 
            this.comprasPorFechasToolStripMenuItem.Name = "comprasPorFechasToolStripMenuItem";
            this.comprasPorFechasToolStripMenuItem.Size = new System.Drawing.Size(303, 42);
            this.comprasPorFechasToolStripMenuItem.Text = "Compras Por Fechas";
            // 
            // stockArticulosToolStripMenuItem
            // 
            this.stockArticulosToolStripMenuItem.Name = "stockArticulosToolStripMenuItem";
            this.stockArticulosToolStripMenuItem.Size = new System.Drawing.Size(303, 42);
            this.stockArticulosToolStripMenuItem.Text = "Stock Articulos";
            // 
            // MnuHerramientas
            // 
            this.MnuHerramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.MnuHerramientas.Name = "MnuHerramientas";
            this.MnuHerramientas.Size = new System.Drawing.Size(161, 42);
            this.MnuHerramientas.Text = "&Herramientas";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupBDToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(125, 42);
            this.optionsToolStripMenuItem.Text = "&BD";
            // 
            // backupBDToolStripMenuItem
            // 
            this.backupBDToolStripMenuItem.Name = "backupBDToolStripMenuItem";
            this.backupBDToolStripMenuItem.Size = new System.Drawing.Size(199, 42);
            this.backupBDToolStripMenuItem.Text = "BackupBD";
            // 
            // MnuAyuda
            // 
            this.MnuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.MnuAyuda.Name = "MnuAyuda";
            this.MnuAyuda.Size = new System.Drawing.Size(94, 42);
            this.MnuAyuda.Text = "&Ayuda";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources._1469969800_search;
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(226, 42);
            this.indexToolStripMenuItem.Text = "&Índice";
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.indexToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(223, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources._1470287718_info;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(226, 42);
            this.aboutToolStripMenuItem.Text = "&Acerca de...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1157, 39);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(1079, 34);
            this.toolStripStatusLabel.Text = "                                      .:                                         " +
    "       heavyshop                                             :.";
            this.toolStripStatusLabel.ToolTipText = "Punto de Venta Heavy Shop";
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsCompras,
            this.toolStripButton2,
            this.TsIngresos,
            this.TSAlmacen,
            this.TsAdministrar,
            this.TsReportes,
            this.TsAyuda});
            this.toolStrip.Location = new System.Drawing.Point(0, 39);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1157, 25);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "ToolStrip";
            // 
            // TsCompras
            // 
            this.TsCompras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsCompras.Image = global::CapaPresentacion.Properties.Resources._1470135355_buy;
            this.TsCompras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsCompras.Name = "TsCompras";
            this.TsCompras.Size = new System.Drawing.Size(23, 22);
            this.TsCompras.Text = "Comprar";
            this.TsCompras.Click += new System.EventHandler(this.TsCompra_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::CapaPresentacion.Properties.Resources._1469939105_finance_21;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Vender";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // TsIngresos
            // 
            this.TsIngresos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsIngresos.Image = global::CapaPresentacion.Properties.Resources._1470175699_aiga_cashier1;
            this.TsIngresos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsIngresos.Name = "TsIngresos";
            this.TsIngresos.Size = new System.Drawing.Size(23, 22);
            this.TsIngresos.Text = "Ingresos";
            this.TsIngresos.Click += new System.EventHandler(this.TsIngresos_Click);
            // 
            // TSAlmacen
            // 
            this.TSAlmacen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSAlmacen.Image = global::CapaPresentacion.Properties.Resources._1470175606_warehouse1;
            this.TSAlmacen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSAlmacen.Name = "TSAlmacen";
            this.TSAlmacen.Size = new System.Drawing.Size(23, 22);
            this.TSAlmacen.Text = "Almacen";
            // 
            // TsAdministrar
            // 
            this.TsAdministrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsAdministrar.Image = global::CapaPresentacion.Properties.Resources._1470173996_pen71;
            this.TsAdministrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsAdministrar.Name = "TsAdministrar";
            this.TsAdministrar.Size = new System.Drawing.Size(23, 22);
            this.TsAdministrar.Text = "Administrar";
            this.TsAdministrar.Click += new System.EventHandler(this.TsVentas_Click);
            // 
            // TsReportes
            // 
            this.TsReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsReportes.Image = global::CapaPresentacion.Properties.Resources._1470174018_notebook;
            this.TsReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsReportes.Name = "TsReportes";
            this.TsReportes.Size = new System.Drawing.Size(23, 22);
            this.TsReportes.Text = "Consultas";
            // 
            // TsAyuda
            // 
            this.TsAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsAyuda.Image = global::CapaPresentacion.Properties.Resources._1470287551_help;
            this.TsAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsAyuda.Name = "TsAyuda";
            this.TsAyuda.Size = new System.Drawing.Size(23, 22);
            this.TsAyuda.Text = "Ayuda";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmPrincipal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.heavyshop2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 370);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal2";
            this.Text = ".:+Heavy Shop+:.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal2_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuSistema;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuAlmacen;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuCompras;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuVentas;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem trabajadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuConsultas;
        private System.Windows.Forms.ToolStripMenuItem ventasPorFEchasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuHerramientas;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton TsCompras;
        private System.Windows.Forms.ToolStripButton TsAdministrar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton TsIngresos;
        private System.Windows.Forms.ToolStripButton TSAlmacen;
        private System.Windows.Forms.ToolStripButton TsReportes;
        private System.Windows.Forms.ToolStripButton TsAyuda;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}