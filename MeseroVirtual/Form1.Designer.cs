﻿namespace MeseroVirtual
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Desayunos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Almuerzos", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Arroz con pollo");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.LVComidas = new System.Windows.Forms.ListView();
            this.CNombre = new System.Windows.Forms.ColumnHeader();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageRestaurante = new System.Windows.Forms.TabPage();
            this.nombreRestaurante = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.PtureImagenAlimento = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_priceAlimento = new System.Windows.Forms.TextBox();
            this.txt_typeAlimento = new System.Windows.Forms.TextBox();
            this.TBAdmindComidas = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCategoriaEditar = new System.Windows.Forms.Button();
            this.btnCategoriaEliminar = new System.Windows.Forms.Button();
            this.btnCategoriaAgregar = new System.Windows.Forms.Button();
            this.txtCategoriaNombre = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtureImagenAlimento)).BeginInit();
            this.TBAdmindComidas.SuspendLayout();
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
            this.LVComidas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LVComidas.BackgroundImageTiled = true;
            this.LVComidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVComidas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CNombre});
            this.LVComidas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LVComidas.ForeColor = System.Drawing.Color.Black;
            this.LVComidas.GridLines = true;
            listViewGroup1.Header = "Desayunos";
            listViewGroup1.Name = "Desayunos";
            listViewGroup2.Header = "Almuerzos";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "Almuerzos";
            this.LVComidas.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
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
            // 
            // CNombre
            // 
            this.CNombre.Text = "Nombre";
            this.CNombre.Width = 500;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageRestaurante);
            this.tabControl1.Controls.Add(this.TBAdmindComidas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 541);
            this.tabControl1.TabIndex = 2;
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
            this.nombreRestaurante.Location = new System.Drawing.Point(351, 13);
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
            this.groupBox2.Location = new System.Drawing.Point(570, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 161);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnComprar);
            this.groupBox1.Controls.Add(this.PtureImagenAlimento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_priceAlimento);
            this.groupBox1.Controls.Add(this.txt_typeAlimento);
            this.groupBox1.Location = new System.Drawing.Point(565, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 282);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos principales";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprar.Location = new System.Drawing.Point(38, 230);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(122, 34);
            this.btnComprar.TabIndex = 9;
            this.btnComprar.Text = "Agregar Pedido";
            this.btnComprar.UseVisualStyleBackColor = false;
            // 
            // PtureImagenAlimento
            // 
            this.PtureImagenAlimento.BackColor = System.Drawing.Color.LightGray;
            this.PtureImagenAlimento.Location = new System.Drawing.Point(23, 95);
            this.PtureImagenAlimento.Name = "PtureImagenAlimento";
            this.PtureImagenAlimento.Size = new System.Drawing.Size(182, 118);
            this.PtureImagenAlimento.TabIndex = 10;
            this.PtureImagenAlimento.TabStop = false;
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
            // TBAdmindComidas
            // 
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
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(449, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(320, 176);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Configuración Restaurante";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCategoriaEditar);
            this.groupBox4.Controls.Add(this.btnCategoriaEliminar);
            this.groupBox4.Controls.Add(this.btnCategoriaAgregar);
            this.groupBox4.Controls.Add(this.txtCategoriaNombre);
            this.groupBox4.Location = new System.Drawing.Point(8, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 145);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar Categoria";
            // 
            // btnCategoriaEditar
            // 
            this.btnCategoriaEditar.Location = new System.Drawing.Point(6, 109);
            this.btnCategoriaEditar.Name = "btnCategoriaEditar";
            this.btnCategoriaEditar.Size = new System.Drawing.Size(236, 23);
            this.btnCategoriaEditar.TabIndex = 4;
            this.btnCategoriaEditar.Text = "Editar";
            this.btnCategoriaEditar.UseVisualStyleBackColor = true;
            // 
            // btnCategoriaEliminar
            // 
            this.btnCategoriaEliminar.Location = new System.Drawing.Point(6, 80);
            this.btnCategoriaEliminar.Name = "btnCategoriaEliminar";
            this.btnCategoriaEliminar.Size = new System.Drawing.Size(236, 23);
            this.btnCategoriaEliminar.TabIndex = 3;
            this.btnCategoriaEliminar.Text = "Eliminar";
            this.btnCategoriaEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCategoriaAgregar
            // 
            this.btnCategoriaAgregar.Location = new System.Drawing.Point(6, 51);
            this.btnCategoriaAgregar.Name = "btnCategoriaAgregar";
            this.btnCategoriaAgregar.Size = new System.Drawing.Size(236, 23);
            this.btnCategoriaAgregar.TabIndex = 2;
            this.btnCategoriaAgregar.Text = "Agregar";
            this.btnCategoriaAgregar.UseVisualStyleBackColor = true;
            this.btnCategoriaAgregar.Click += new System.EventHandler(this.btnCategoriaAgregar_Click);
            // 
            // txtCategoriaNombre
            // 
            this.txtCategoriaNombre.Location = new System.Drawing.Point(6, 22);
            this.txtCategoriaNombre.Name = "txtCategoriaNombre";
            this.txtCategoriaNombre.PlaceholderText = "Ingrese el nombre de la categoria...";
            this.txtCategoriaNombre.Size = new System.Drawing.Size(236, 23);
            this.txtCategoriaNombre.TabIndex = 1;
            this.txtCategoriaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
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
            this.groupBox3.Text = "Agregar Comida";
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
            this.btnAlimentoEditar.Location = new System.Drawing.Point(260, 103);
            this.btnAlimentoEditar.Name = "btnAlimentoEditar";
            this.btnAlimentoEditar.Size = new System.Drawing.Size(156, 30);
            this.btnAlimentoEditar.TabIndex = 6;
            this.btnAlimentoEditar.Text = "Editar";
            this.btnAlimentoEditar.UseVisualStyleBackColor = true;
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
            this.btnAlimentoEliminar.Location = new System.Drawing.Point(341, 22);
            this.btnAlimentoEliminar.Name = "btnAlimentoEliminar";
            this.btnAlimentoEliminar.Size = new System.Drawing.Size(75, 77);
            this.btnAlimentoEliminar.TabIndex = 5;
            this.btnAlimentoEliminar.Text = "Eliminar";
            this.btnAlimentoEliminar.UseVisualStyleBackColor = true;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMenu_FormClosing);
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabPageRestaurante.ResumeLayout(false);
            this.TabPageRestaurante.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtureImagenAlimento)).EndInit();
            this.TBAdmindComidas.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private PictureBox PtureImagenAlimento;
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
        private TextBox txtCategoriaNombre;
        private GroupBox groupBox5;
        private Button btnCategoriaEditar;
        private Button btnCategoriaEliminar;
        private Button btnCategoriaAgregar;
        private Label nombreRestaurante;
        private Label label2;
    }
}