namespace MeseroVirtual
{
    partial class vCRUD
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
            this.cMOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.LB_Categorias = new System.Windows.Forms.ListBox();
            this.cMOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMOpciones
            // 
            this.cMOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.cMOpciones.Name = "cMOpciones";
            this.cMOpciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cMOpciones.ShowImageMargin = false;
            this.cMOpciones.Size = new System.Drawing.Size(101, 70);
            this.cMOpciones.Opening += new System.ComponentModel.CancelEventHandler(this.cMOpciones_Opening);
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(0, 370);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(418, 27);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Realizar Cambios";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // LB_Categorias
            // 
            this.LB_Categorias.ContextMenuStrip = this.cMOpciones;
            this.LB_Categorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_Categorias.FormattingEnabled = true;
            this.LB_Categorias.ItemHeight = 15;
            this.LB_Categorias.Location = new System.Drawing.Point(0, 0);
            this.LB_Categorias.Name = "LB_Categorias";
            this.LB_Categorias.Size = new System.Drawing.Size(423, 364);
            this.LB_Categorias.TabIndex = 9;
            this.LB_Categorias.DoubleClick += new System.EventHandler(this.LB_Categorias_DoubleClick);
            // 
            // vCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 402);
            this.Controls.Add(this.LB_Categorias);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "vCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vCRUD";
            this.Load += new System.EventHandler(this.vCRUD_Load);
            this.cMOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAceptar;
        private ToolStripMenuItem modificarToolStripMenuItem;
        internal ListBox LB_Categorias;
        private ToolStripMenuItem agregarToolStripMenuItem1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        internal ContextMenuStrip cMOpciones;
    }
}