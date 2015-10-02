namespace WindowsFormsApplication1
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
            this.lblMisDocumentos = new System.Windows.Forms.Label();
            this.cbDirectorios = new System.Windows.Forms.ComboBox();
            this.lblDirectorios2 = new System.Windows.Forms.Label();
            this.cbDirectorios2 = new System.Windows.Forms.ComboBox();
            this.lblAcceso = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnFormAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMisDocumentos
            // 
            this.lblMisDocumentos.AutoSize = true;
            this.lblMisDocumentos.Location = new System.Drawing.Point(13, 13);
            this.lblMisDocumentos.Name = "lblMisDocumentos";
            this.lblMisDocumentos.Size = new System.Drawing.Size(86, 13);
            this.lblMisDocumentos.TabIndex = 0;
            this.lblMisDocumentos.Text = "Mis Documentos";
            // 
            // cbDirectorios
            // 
            this.cbDirectorios.FormattingEnabled = true;
            this.cbDirectorios.Location = new System.Drawing.Point(13, 30);
            this.cbDirectorios.Name = "cbDirectorios";
            this.cbDirectorios.Size = new System.Drawing.Size(121, 21);
            this.cbDirectorios.TabIndex = 1;
            this.cbDirectorios.SelectedIndexChanged += new System.EventHandler(this.cbDirectorios_SelectedIndexChanged);
            // 
            // lblDirectorios2
            // 
            this.lblDirectorios2.AutoSize = true;
            this.lblDirectorios2.Location = new System.Drawing.Point(152, 13);
            this.lblDirectorios2.Name = "lblDirectorios2";
            this.lblDirectorios2.Size = new System.Drawing.Size(120, 13);
            this.lblDirectorios2.TabIndex = 2;
            this.lblDirectorios2.Text = "Contenido de la carpeta";
            // 
            // cbDirectorios2
            // 
            this.cbDirectorios2.FormattingEnabled = true;
            this.cbDirectorios2.Location = new System.Drawing.Point(155, 29);
            this.cbDirectorios2.Name = "cbDirectorios2";
            this.cbDirectorios2.Size = new System.Drawing.Size(121, 21);
            this.cbDirectorios2.TabIndex = 3;
            this.cbDirectorios2.SelectedIndexChanged += new System.EventHandler(this.cbDirectorios2_SelectedIndexChanged);
            // 
            // lblAcceso
            // 
            this.lblAcceso.AutoSize = true;
            this.lblAcceso.Location = new System.Drawing.Point(13, 54);
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(103, 13);
            this.lblAcceso.TabIndex = 4;
            this.lblAcceso.Text = "El últmo acceso fue:";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(301, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(13, 122);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEditor.Size = new System.Drawing.Size(363, 167);
            this.txtEditor.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(301, 70);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtInsertar
            // 
            this.txtInsertar.Location = new System.Drawing.Point(13, 295);
            this.txtInsertar.Multiline = true;
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInsertar.Size = new System.Drawing.Size(363, 28);
            this.txtInsertar.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(301, 329);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(13, 329);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoEllipsis = true;
            this.lblPath.Location = new System.Drawing.Point(16, 67);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(279, 50);
            this.lblPath.TabIndex = 11;
            // 
            // btnFormAbrir
            // 
            this.btnFormAbrir.Location = new System.Drawing.Point(301, 41);
            this.btnFormAbrir.Name = "btnFormAbrir";
            this.btnFormAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnFormAbrir.TabIndex = 12;
            this.btnFormAbrir.Text = "Abrir Form";
            this.btnFormAbrir.UseVisualStyleBackColor = true;
            this.btnFormAbrir.Click += new System.EventHandler(this.btnFormAbrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 364);
            this.Controls.Add(this.btnFormAbrir);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lblAcceso);
            this.Controls.Add(this.cbDirectorios2);
            this.Controls.Add(this.lblDirectorios2);
            this.Controls.Add(this.cbDirectorios);
            this.Controls.Add(this.lblMisDocumentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMisDocumentos;
        private System.Windows.Forms.ComboBox cbDirectorios;
        private System.Windows.Forms.Label lblDirectorios2;
        private System.Windows.Forms.ComboBox cbDirectorios2;
        private System.Windows.Forms.Label lblAcceso;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnFormAbrir;
    }
}

