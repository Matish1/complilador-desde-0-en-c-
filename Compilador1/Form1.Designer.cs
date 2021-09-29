namespace Compilador1
{
    partial class frmEditor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.etArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.opNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.opAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.opGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.opGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.opSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.eteditar = new System.Windows.Forms.ToolStripMenuItem();
            this.etConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.etAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.rteditor = new System.Windows.Forms.RichTextBox();
            this.etCompilar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etArchivo,
            this.eteditar,
            this.etConfiguracion,
            this.etCompilar,
            this.etAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1336, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // etArchivo
            // 
            this.etArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opNuevo,
            this.opAbrir,
            this.opGuardar,
            this.opGuardarComo,
            this.opSalir});
            this.etArchivo.Name = "etArchivo";
            this.etArchivo.Size = new System.Drawing.Size(60, 20);
            this.etArchivo.Text = "Archivo";
            // 
            // opNuevo
            // 
            this.opNuevo.Name = "opNuevo";
            this.opNuevo.Size = new System.Drawing.Size(150, 22);
            this.opNuevo.Text = "Nuevo";
            this.opNuevo.Click += new System.EventHandler(this.OpNuevo_Click);
            // 
            // opAbrir
            // 
            this.opAbrir.Name = "opAbrir";
            this.opAbrir.Size = new System.Drawing.Size(150, 22);
            this.opAbrir.Text = "Abrir";
            this.opAbrir.Click += new System.EventHandler(this.OpAbrir_Click);
            // 
            // opGuardar
            // 
            this.opGuardar.Name = "opGuardar";
            this.opGuardar.Size = new System.Drawing.Size(150, 22);
            this.opGuardar.Text = "Guardar";
            this.opGuardar.Click += new System.EventHandler(this.OpGuardar_Click);
            // 
            // opGuardarComo
            // 
            this.opGuardarComo.Name = "opGuardarComo";
            this.opGuardarComo.Size = new System.Drawing.Size(150, 22);
            this.opGuardarComo.Text = "Guardar como";
            this.opGuardarComo.Click += new System.EventHandler(this.OpGuardarComo_Click);
            // 
            // opSalir
            // 
            this.opSalir.Name = "opSalir";
            this.opSalir.Size = new System.Drawing.Size(150, 22);
            this.opSalir.Text = "Salir";
            this.opSalir.Click += new System.EventHandler(this.OpSalir_Click);
            // 
            // eteditar
            // 
            this.eteditar.Name = "eteditar";
            this.eteditar.Size = new System.Drawing.Size(49, 20);
            this.eteditar.Text = "Editar";
            // 
            // etConfiguracion
            // 
            this.etConfiguracion.Name = "etConfiguracion";
            this.etConfiguracion.Size = new System.Drawing.Size(95, 20);
            this.etConfiguracion.Text = "Configuracion";
            // 
            // etAyuda
            // 
            this.etAyuda.Name = "etAyuda";
            this.etAyuda.Size = new System.Drawing.Size(53, 20);
            this.etAyuda.Text = "Ayuda";
            // 
            // rteditor
            // 
            this.rteditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rteditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rteditor.Location = new System.Drawing.Point(0, 24);
            this.rteditor.Name = "rteditor";
            this.rteditor.Size = new System.Drawing.Size(1336, 738);
            this.rteditor.TabIndex = 1;
            this.rteditor.Text = "";
            // 
            // etCompilar
            // 
            this.etCompilar.Name = "etCompilar";
            this.etCompilar.Size = new System.Drawing.Size(68, 20);
            this.etCompilar.Text = "Compilar";
            this.etCompilar.Click += new System.EventHandler(this.etCompilar_Click);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 762);
            this.Controls.Add(this.rteditor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEditor";
            this.Text = "MingC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem etArchivo;
        private System.Windows.Forms.ToolStripMenuItem opNuevo;
        private System.Windows.Forms.ToolStripMenuItem opAbrir;
        private System.Windows.Forms.ToolStripMenuItem opSalir;
        private System.Windows.Forms.ToolStripMenuItem eteditar;
        private System.Windows.Forms.ToolStripMenuItem etConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem opGuardar;
        private System.Windows.Forms.ToolStripMenuItem opGuardarComo;
        private System.Windows.Forms.ToolStripMenuItem etAyuda;
        private System.Windows.Forms.RichTextBox rteditor;
        private System.Windows.Forms.ToolStripMenuItem etCompilar;
    }
}

