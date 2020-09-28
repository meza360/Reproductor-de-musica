namespace Reproductor_de_musica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.lista = new System.Windows.Forms.ListBox();
            this.agregar_archivos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // reproductor
            // 
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(0, -1);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(364, 162);
            this.reproductor.TabIndex = 0;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(0, 210);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(364, 147);
            this.lista.TabIndex = 1;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // agregar_archivos
            // 
            this.agregar_archivos.Location = new System.Drawing.Point(0, 167);
            this.agregar_archivos.Name = "agregar_archivos";
            this.agregar_archivos.Size = new System.Drawing.Size(83, 37);
            this.agregar_archivos.TabIndex = 2;
            this.agregar_archivos.Text = "Agregar Canciones";
            this.agregar_archivos.UseVisualStyleBackColor = true;
            this.agregar_archivos.Click += new System.EventHandler(this.agregar_archivos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 354);
            this.Controls.Add(this.agregar_archivos);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.reproductor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button agregar_archivos;
    }
}

