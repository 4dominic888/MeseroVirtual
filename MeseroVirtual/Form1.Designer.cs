namespace MeseroVirtual
{
    partial class FMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Desayunos", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Arroz con pollo");
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Almuerzos", System.Windows.Forms.HorizontalAlignment.Center);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.LVComidas = new System.Windows.Forms.ListView();
            this.CNombre = new System.Windows.Forms.ColumnHeader();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageRestaurante = new System.Windows.Forms.TabPage();
            this.nombreRestaurante = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.PictureImagenAlimento = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_priceAlimento = new System.Windows.Forms.TextBox();
            this.txt_typeAlimento = new System.Windows.Forms.TextBox();
            this.TBColaPedidos = new System.Windows.Forms.TabPage();
            this.listaPedidos = new System.Windows.Forms.ListView();
            this.columnNombre = new System.Windows.Forms.ColumnHeader();
            this.columnCantidad = new System.Windows.Forms.ColumnHeader();
            this.columnPrecio = new System.Windows.Forms.ColumnHeader();
            this.menuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmRetirarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMandarPedido = new System.Windows.Forms.Button();
            this.TBAdmindComidas = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnEstablecerNombreRestaurante = new System.Windows.Forms.Button();
            this.txtNombreRestaurante = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAdministrarCategorias = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAlimentoBuscar = new System.Windows.Forms.Button();
            this.txtAlimentoImagenPath = new System.Windows.Forms.TextBox();
            this.btnAlimentoEditar = new System.Windows.Forms.Button();
            this.txtAlimentoBuscarNombre = new System.Windows.Forms.TextBox();
            this.btnAlimentoEliminar = new System.Windows.Forms.Button();
            this.btnAlimentoAgregar = new System.Windows.Forms.Button();
            this.txtAlimentoPrecio = new System.Windows.Forms.TextBox();
            this.cbAlimentoCategoria = new System.Windows.Forms.ComboBox();
            this.btnAlimentoImagen = new System.Windows.Forms.Button();
            this.txtAlimentoNombre = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TabPageRestaurante.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureImagenAlimento)).BeginInit();
            this.TBColaPedidos.SuspendLayout();
            this.menuContextual.SuspendLayout();
            this.TBAdmindComidas.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal";
            // 
            // LVComidas
            // 
            this.LVComidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LVComidas.BackgroundImageTiled = true;
            this.LVComidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVComidas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CNombre});
            this.LVComidas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LVComidas.ForeColor = System.Drawing.Color.Black;
            this.LVComidas.GridLines = true;
            listViewGroup1.Header = "Desayunos";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "Desayunos";
            this.LVComidas.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            listViewGroup2.Header = "Almuerzos";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "Almuerzos";
            listViewItem1.Group = listViewGroup2;
            this.LVComidas.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.LVComidas.Location = new System.Drawing.Point(17, 46);
            this.LVComidas.MultiSelect = false;
            this.LVComidas.Name = "LVComidas";
            this.LVComidas.ShowItemToolTips = true;
            this.LVComidas.Size = new System.Drawing.Size(540, 459);
            this.LVComidas.TabIndex = 1;
            this.LVComidas.UseCompatibleStateImageBehavior = false;
            this.LVComidas.View = System.Windows.Forms.View.Tile;
            this.LVComidas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VerInformacion);
            // 
            // CNombre
            // 
            this.CNombre.Text = "Nombre";
            this.CNombre.Width = 500;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageRestaurante);
            this.tabControl1.Controls.Add(this.TBColaPedidos);
            this.tabControl1.Controls.Add(this.TBAdmindComidas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 541);
            this.tabControl1.TabIndex = 1;
            // 
            // TabPageRestaurante
            // 
            this.TabPageRestaurante.Controls.Add(this.nombreRestaurante);
            this.TabPageRestaurante.Controls.Add(this.label2);
            this.TabPageRestaurante.Controls.Add(this.groupBox2);
            this.TabPageRestaurante.Controls.Add(this.groupBox1);
            this.TabPageRestaurante.Controls.Add(this.label1);
            this.TabPageRestaurante.Controls.Add(this.LVComidas);
            this.TabPageRestaurante.Location = new System.Drawing.Point(4, 24);
            this.TabPageRestaurante.Name = "TabPageRestaurante";
            this.TabPageRestaurante.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageRestaurante.Size = new System.Drawing.Size(792, 513);
            this.TabPageRestaurante.TabIndex = 0;
            this.TabPageRestaurante.Text = "Menu";
            this.TabPageRestaurante.UseVisualStyleBackColor = true;
            // 
            // nombreRestaurante
            // 
            this.nombreRestaurante.AutoSize = true;
            this.nombreRestaurante.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreRestaurante.Location = new System.Drawing.Point(394, 13);
            this.nombreRestaurante.Name = "nombreRestaurante";
            this.nombreRestaurante.Size = new System.Drawing.Size(78, 20);
            this.nombreRestaurante.TabIndex = 0;
            this.nombreRestaurante.Text = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(225, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Restaurante";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFiltro);
            this.groupBox2.Controls.Add(this.txtFiltro);
            this.groupBox2.Location = new System.Drawing.Point(570, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 97);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(9, 51);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(180, 23);
            this.cbFiltro.TabIndex = 1;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltroCambia);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(9, 22);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PlaceholderText = "Buscar...";
            this.txtFiltro.Size = new System.Drawing.Size(180, 23);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnComprar);
            this.groupBox1.Controls.Add(this.PictureImagenAlimento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_priceAlimento);
            this.groupBox1.Controls.Add(this.txt_typeAlimento);
            this.groupBox1.Location = new System.Drawing.Point(565, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 344);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos principales";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprar.Location = new System.Drawing.Point(44, 293);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(122, 34);
            this.btnComprar.TabIndex = 9;
            this.btnComprar.Text = "Agregar Pedido";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // PictureImagenAlimento
            // 
            this.PictureImagenAlimento.BackColor = System.Drawing.Color.LightGray;
            this.PictureImagenAlimento.Location = new System.Drawing.Point(14, 106);
            this.PictureImagenAlimento.Name = "PictureImagenAlimento";
            this.PictureImagenAlimento.Size = new System.Drawing.Size(191, 181);
            this.PictureImagenAlimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureImagenAlimento.TabIndex = 10;
            this.PictureImagenAlimento.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio: S/. ";
            // 
            // txt_priceAlimento
            // 
            this.txt_priceAlimento.Location = new System.Drawing.Point(73, 66);
            this.txt_priceAlimento.Name = "txt_priceAlimento";
            this.txt_priceAlimento.ReadOnly = true;
            this.txt_priceAlimento.Size = new System.Drawing.Size(121, 23);
            this.txt_priceAlimento.TabIndex = 8;
            // 
            // txt_typeAlimento
            // 
            this.txt_typeAlimento.Location = new System.Drawing.Point(56, 29);
            this.txt_typeAlimento.Name = "txt_typeAlimento";
            this.txt_typeAlimento.ReadOnly = true;
            this.txt_typeAlimento.Size = new System.Drawing.Size(138, 23);
            this.txt_typeAlimento.TabIndex = 7;
            // 
            // TBColaPedidos
            // 
            this.TBColaPedidos.Controls.Add(this.listaPedidos);
            this.TBColaPedidos.Controls.Add(this.btnMandarPedido);
            this.TBColaPedidos.Location = new System.Drawing.Point(4, 24);
            this.TBColaPedidos.Name = "TBColaPedidos";
            this.TBColaPedidos.Size = new System.Drawing.Size(792, 513);
            this.TBColaPedidos.TabIndex = 2;
            this.TBColaPedidos.Text = "Cola de pedidos";
            this.TBColaPedidos.UseVisualStyleBackColor = true;
            // 
            // listaPedidos
            // 
            this.listaPedidos.BackColor = System.Drawing.Color.MistyRose;
            this.listaPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNombre,
            this.columnCantidad,
            this.columnPrecio});
            this.listaPedidos.ContextMenuStrip = this.menuContextual;
            this.listaPedidos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaPedidos.Location = new System.Drawing.Point(0, 0);
            this.listaPedidos.MultiSelect = false;
            this.listaPedidos.Name = "listaPedidos";
            this.listaPedidos.ShowGroups = false;
            this.listaPedidos.Size = new System.Drawing.Size(792, 481);
            this.listaPedidos.TabIndex = 2;
            this.listaPedidos.UseCompatibleStateImageBehavior = false;
            this.listaPedidos.View = System.Windows.Forms.View.Details;
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 622;
            // 
            // columnCantidad
            // 
            this.columnCantidad.Text = "Cantidad";
            this.columnCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCantidad.Width = 70;
            // 
            // columnPrecio
            // 
            this.columnPrecio.Text = "Precio Total";
            this.columnPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPrecio.Width = 100;
            // 
            // menuContextual
            // 
            this.menuContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRetirarPedido});
            this.menuContextual.Name = "menuContextual";
            this.menuContextual.ShowImageMargin = false;
            this.menuContextual.Size = new System.Drawing.Size(124, 26);
            this.menuContextual.Opening += new System.ComponentModel.CancelEventHandler(this.menuContextual_Opening);
            // 
            // tsmRetirarPedido
            // 
            this.tsmRetirarPedido.Name = "tsmRetirarPedido";
            this.tsmRetirarPedido.Size = new System.Drawing.Size(123, 22);
            this.tsmRetirarPedido.Text = "Retirar pedido";
            this.tsmRetirarPedido.Click += new System.EventHandler(this.tsmRetirarPedido_Click);
            // 
            // btnMandarPedido
            // 
            this.btnMandarPedido.Location = new System.Drawing.Point(3, 487);
            this.btnMandarPedido.Name = "btnMandarPedido";
            this.btnMandarPedido.Size = new System.Drawing.Size(781, 23);
            this.btnMandarPedido.TabIndex = 1;
            this.btnMandarPedido.Text = "Mandar pedido";
            this.btnMandarPedido.UseVisualStyleBackColor = true;
            this.btnMandarPedido.Click += new System.EventHandler(this.btnMandarPedido_Click);
            // 
            // TBAdmindComidas
            // 
            this.TBAdmindComidas.Controls.Add(this.groupBox6);
            this.TBAdmindComidas.Controls.Add(this.groupBox5);
            this.TBAdmindComidas.Controls.Add(this.groupBox4);
            this.TBAdmindComidas.Controls.Add(this.groupBox3);
            this.TBAdmindComidas.Location = new System.Drawing.Point(4, 24);
            this.TBAdmindComidas.Name = "TBAdmindComidas";
            this.TBAdmindComidas.Padding = new System.Windows.Forms.Padding(3);
            this.TBAdmindComidas.Size = new System.Drawing.Size(792, 513);
            this.TBAdmindComidas.TabIndex = 1;
            this.TBAdmindComidas.Text = "Administrador de comidas";
            this.TBAdmindComidas.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnGuardar);
            this.groupBox6.Location = new System.Drawing.Point(272, 206);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 142);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Configuración general";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(13, 22);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 49);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnEstablecerNombreRestaurante);
            this.groupBox5.Controls.Add(this.txtNombreRestaurante);
            this.groupBox5.Location = new System.Drawing.Point(449, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(335, 74);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Configuración Restaurante";
            // 
            // btnEstablecerNombreRestaurante
            // 
            this.btnEstablecerNombreRestaurante.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstablecerNombreRestaurante.Location = new System.Drawing.Point(207, 25);
            this.btnEstablecerNombreRestaurante.Name = "btnEstablecerNombreRestaurante";
            this.btnEstablecerNombreRestaurante.Size = new System.Drawing.Size(122, 24);
            this.btnEstablecerNombreRestaurante.TabIndex = 1;
            this.btnEstablecerNombreRestaurante.Text = "Establecer nombre";
            this.btnEstablecerNombreRestaurante.UseVisualStyleBackColor = true;
            this.btnEstablecerNombreRestaurante.Click += new System.EventHandler(this.btnEstablecerNombreRestaurante_Click);
            // 
            // txtNombreRestaurante
            // 
            this.txtNombreRestaurante.Location = new System.Drawing.Point(16, 26);
            this.txtNombreRestaurante.Name = "txtNombreRestaurante";
            this.txtNombreRestaurante.Size = new System.Drawing.Size(184, 23);
            this.txtNombreRestaurante.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAdministrarCategorias);
            this.groupBox4.Location = new System.Drawing.Point(8, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 60);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Categorias";
            // 
            // btnAdministrarCategorias
            // 
            this.btnAdministrarCategorias.Location = new System.Drawing.Point(6, 22);
            this.btnAdministrarCategorias.Name = "btnAdministrarCategorias";
            this.btnAdministrarCategorias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdministrarCategorias.Size = new System.Drawing.Size(236, 23);
            this.btnAdministrarCategorias.TabIndex = 5;
            this.btnAdministrarCategorias.Text = "Administrar Categorias";
            this.btnAdministrarCategorias.UseVisualStyleBackColor = true;
            this.btnAdministrarCategorias.Click += new System.EventHandler(this.btnAdministrarCategorias_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAlimentoBuscar);
            this.groupBox3.Controls.Add(this.txtAlimentoImagenPath);
            this.groupBox3.Controls.Add(this.btnAlimentoEditar);
            this.groupBox3.Controls.Add(this.txtAlimentoBuscarNombre);
            this.groupBox3.Controls.Add(this.btnAlimentoEliminar);
            this.groupBox3.Controls.Add(this.btnAlimentoAgregar);
            this.groupBox3.Controls.Add(this.txtAlimentoPrecio);
            this.groupBox3.Controls.Add(this.cbAlimentoCategoria);
            this.groupBox3.Controls.Add(this.btnAlimentoImagen);
            this.groupBox3.Controls.Add(this.txtAlimentoNombre);
            this.groupBox3.Location = new System.Drawing.Point(8, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 176);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comida";
            // 
            // btnAlimentoBuscar
            // 
            this.btnAlimentoBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlimentoBuscar.BackgroundImage")));
            this.btnAlimentoBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlimentoBuscar.Location = new System.Drawing.Point(391, 141);
            this.btnAlimentoBuscar.Name = "btnAlimentoBuscar";
            this.btnAlimentoBuscar.Size = new System.Drawing.Size(25, 23);
            this.btnAlimentoBuscar.TabIndex = 7;
            this.btnAlimentoBuscar.UseVisualStyleBackColor = true;
            this.btnAlimentoBuscar.Click += new System.EventHandler(this.btnAlimentoBuscar_Click);
            // 
            // txtAlimentoImagenPath
            // 
            this.txtAlimentoImagenPath.BackColor = System.Drawing.Color.White;
            this.txtAlimentoImagenPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlimentoImagenPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlimentoImagenPath.Location = new System.Drawing.Point(6, 79);
            this.txtAlimentoImagenPath.Name = "txtAlimentoImagenPath";
            this.txtAlimentoImagenPath.ReadOnly = true;
            this.txtAlimentoImagenPath.Size = new System.Drawing.Size(236, 15);
            this.txtAlimentoImagenPath.TabIndex = 7;
            this.txtAlimentoImagenPath.Text = "imagen path";
            // 
            // btnAlimentoEditar
            // 
            this.btnAlimentoEditar.Enabled = false;
            this.btnAlimentoEditar.Location = new System.Drawing.Point(260, 103);
            this.btnAlimentoEditar.Name = "btnAlimentoEditar";
            this.btnAlimentoEditar.Size = new System.Drawing.Size(156, 30);
            this.btnAlimentoEditar.TabIndex = 6;
            this.btnAlimentoEditar.Text = "Editar";
            this.btnAlimentoEditar.UseVisualStyleBackColor = true;
            this.btnAlimentoEditar.Click += new System.EventHandler(this.btnAlimentoEditar_Click);
            // 
            // txtAlimentoBuscarNombre
            // 
            this.txtAlimentoBuscarNombre.Location = new System.Drawing.Point(260, 141);
            this.txtAlimentoBuscarNombre.Name = "txtAlimentoBuscarNombre";
            this.txtAlimentoBuscarNombre.PlaceholderText = "Buscar por nombre...";
            this.txtAlimentoBuscarNombre.Size = new System.Drawing.Size(125, 23);
            this.txtAlimentoBuscarNombre.TabIndex = 2;
            // 
            // btnAlimentoEliminar
            // 
            this.btnAlimentoEliminar.Enabled = false;
            this.btnAlimentoEliminar.Location = new System.Drawing.Point(341, 22);
            this.btnAlimentoEliminar.Name = "btnAlimentoEliminar";
            this.btnAlimentoEliminar.Size = new System.Drawing.Size(75, 77);
            this.btnAlimentoEliminar.TabIndex = 5;
            this.btnAlimentoEliminar.Text = "Eliminar";
            this.btnAlimentoEliminar.UseVisualStyleBackColor = true;
            this.btnAlimentoEliminar.Click += new System.EventHandler(this.btnAlimentoEliminar_Click);
            // 
            // btnAlimentoAgregar
            // 
            this.btnAlimentoAgregar.Location = new System.Drawing.Point(260, 22);
            this.btnAlimentoAgregar.Name = "btnAlimentoAgregar";
            this.btnAlimentoAgregar.Size = new System.Drawing.Size(75, 77);
            this.btnAlimentoAgregar.TabIndex = 4;
            this.btnAlimentoAgregar.Text = "Agregar";
            this.btnAlimentoAgregar.UseVisualStyleBackColor = true;
            this.btnAlimentoAgregar.Click += new System.EventHandler(this.btnAlimentoAgregar_Click);
            // 
            // txtAlimentoPrecio
            // 
            this.txtAlimentoPrecio.Location = new System.Drawing.Point(6, 131);
            this.txtAlimentoPrecio.Name = "txtAlimentoPrecio";
            this.txtAlimentoPrecio.PlaceholderText = "Inserte el precio en Soles S/.";
            this.txtAlimentoPrecio.Size = new System.Drawing.Size(236, 23);
            this.txtAlimentoPrecio.TabIndex = 3;
            this.txtAlimentoPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // cbAlimentoCategoria
            // 
            this.cbAlimentoCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlimentoCategoria.FormattingEnabled = true;
            this.cbAlimentoCategoria.Location = new System.Drawing.Point(6, 100);
            this.cbAlimentoCategoria.MaxDropDownItems = 90;
            this.cbAlimentoCategoria.Name = "cbAlimentoCategoria";
            this.cbAlimentoCategoria.Size = new System.Drawing.Size(236, 23);
            this.cbAlimentoCategoria.TabIndex = 2;
            // 
            // btnAlimentoImagen
            // 
            this.btnAlimentoImagen.Location = new System.Drawing.Point(6, 51);
            this.btnAlimentoImagen.Name = "btnAlimentoImagen";
            this.btnAlimentoImagen.Size = new System.Drawing.Size(236, 23);
            this.btnAlimentoImagen.TabIndex = 1;
            this.btnAlimentoImagen.Text = "Inserte una imagen";
            this.btnAlimentoImagen.UseVisualStyleBackColor = true;
            this.btnAlimentoImagen.Click += new System.EventHandler(this.btnAlimentoImagen_Click);
            // 
            // txtAlimentoNombre
            // 
            this.txtAlimentoNombre.Location = new System.Drawing.Point(6, 22);
            this.txtAlimentoNombre.Name = "txtAlimentoNombre";
            this.txtAlimentoNombre.PlaceholderText = "Ingrese el nombre de la comida...";
            this.txtAlimentoNombre.Size = new System.Drawing.Size(236, 23);
            this.txtAlimentoNombre.TabIndex = 0;
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMenu_FormClosing);
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabPageRestaurante.ResumeLayout(false);
            this.TabPageRestaurante.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureImagenAlimento)).EndInit();
            this.TBColaPedidos.ResumeLayout(false);
            this.menuContextual.ResumeLayout(false);
            this.TBAdmindComidas.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private ListView LVComidas;
        private TabControl tabControl1;
        private TabPage TabPageRestaurante;
        private ColumnHeader CNombre;
        private PictureBox PictureImagenAlimento;
        private Button btnComprar;
        private TextBox txt_priceAlimento;
        private TextBox txt_typeAlimento;
        private Label label5;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TabPage TBAdmindComidas;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private TextBox txtAlimentoNombre;
        private ComboBox cbAlimentoCategoria;
        private Button btnAlimentoImagen;
        private TextBox txtAlimentoPrecio;
        private Button btnAlimentoBuscar;
        private Button btnAlimentoEditar;
        private TextBox txtAlimentoBuscarNombre;
        private Button btnAlimentoEliminar;
        private Button btnAlimentoAgregar;
        private TextBox txtAlimentoImagenPath;
        private GroupBox groupBox5;
        private Label nombreRestaurante;
        private Label label2;
        private Button btnGuardar;
        private GroupBox groupBox6;
        private Button btnAdministrarCategorias;
        private TextBox txtNombreRestaurante;
        private Button btnEstablecerNombreRestaurante;
        private TabPage TBColaPedidos;
        private Button btnMandarPedido;
        private ContextMenuStrip menuContextual;
        private ToolStripMenuItem tsmRetirarPedido;
        private ListView listaPedidos;
        private ColumnHeader columnNombre;
        private ColumnHeader columnCantidad;
        private ColumnHeader columnPrecio;
        private TextBox txtFiltro;
        private ComboBox cbFiltro;
    }
}