
namespace WindowsPubs
{
    partial class Form1
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
            this.btnTraerTodosAutores = new System.Windows.Forms.Button();
            this.gridAutores = new System.Windows.Forms.DataGridView();
            this.btnTraerPublicadores = new System.Windows.Forms.Button();
            this.btnAutorPorCiudad = new System.Windows.Forms.Button();
            this.btnAutorPorId = new System.Windows.Forms.Button();
            this.btnPublicadorPorNombre = new System.Windows.Forms.Button();
            this.btnListaSalesStores = new System.Windows.Forms.Button();
            this.btnPublicadorEspecial = new System.Windows.Forms.Button();
            this.btnPunto8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodosAutores
            // 
            this.btnTraerTodosAutores.Location = new System.Drawing.Point(12, 12);
            this.btnTraerTodosAutores.Name = "btnTraerTodosAutores";
            this.btnTraerTodosAutores.Size = new System.Drawing.Size(176, 30);
            this.btnTraerTodosAutores.TabIndex = 0;
            this.btnTraerTodosAutores.Text = "Traer todos los Autores";
            this.btnTraerTodosAutores.UseVisualStyleBackColor = true;
            this.btnTraerTodosAutores.Click += new System.EventHandler(this.btnTraerTodosAutores_Click);
            // 
            // gridAutores
            // 
            this.gridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridAutores.Location = new System.Drawing.Point(0, 82);
            this.gridAutores.Name = "gridAutores";
            this.gridAutores.Size = new System.Drawing.Size(800, 368);
            this.gridAutores.TabIndex = 1;
            // 
            // btnTraerPublicadores
            // 
            this.btnTraerPublicadores.Location = new System.Drawing.Point(12, 46);
            this.btnTraerPublicadores.Name = "btnTraerPublicadores";
            this.btnTraerPublicadores.Size = new System.Drawing.Size(176, 30);
            this.btnTraerPublicadores.TabIndex = 2;
            this.btnTraerPublicadores.Text = "Traer todos los Publicadores";
            this.btnTraerPublicadores.UseVisualStyleBackColor = true;
            this.btnTraerPublicadores.Click += new System.EventHandler(this.btnTraerPublicadores_Click);
            // 
            // btnAutorPorCiudad
            // 
            this.btnAutorPorCiudad.Location = new System.Drawing.Point(194, 12);
            this.btnAutorPorCiudad.Name = "btnAutorPorCiudad";
            this.btnAutorPorCiudad.Size = new System.Drawing.Size(176, 30);
            this.btnAutorPorCiudad.TabIndex = 3;
            this.btnAutorPorCiudad.Text = "Traer Autores por Ciudad";
            this.btnAutorPorCiudad.UseVisualStyleBackColor = true;
            this.btnAutorPorCiudad.Click += new System.EventHandler(this.btnAutorPorCiudad_Click);
            // 
            // btnAutorPorId
            // 
            this.btnAutorPorId.Location = new System.Drawing.Point(376, 12);
            this.btnAutorPorId.Name = "btnAutorPorId";
            this.btnAutorPorId.Size = new System.Drawing.Size(176, 30);
            this.btnAutorPorId.TabIndex = 4;
            this.btnAutorPorId.Text = "Traer Autores por ID";
            this.btnAutorPorId.UseVisualStyleBackColor = true;
            this.btnAutorPorId.Click += new System.EventHandler(this.btnAutorPorId_Click);
            // 
            // btnPublicadorPorNombre
            // 
            this.btnPublicadorPorNombre.Location = new System.Drawing.Point(194, 48);
            this.btnPublicadorPorNombre.Name = "btnPublicadorPorNombre";
            this.btnPublicadorPorNombre.Size = new System.Drawing.Size(176, 30);
            this.btnPublicadorPorNombre.TabIndex = 5;
            this.btnPublicadorPorNombre.Text = "Traer Publicador por Nombre";
            this.btnPublicadorPorNombre.UseVisualStyleBackColor = true;
            this.btnPublicadorPorNombre.Click += new System.EventHandler(this.btnPublicadorPorNombre_Click);
            // 
            // btnListaSalesStores
            // 
            this.btnListaSalesStores.Location = new System.Drawing.Point(376, 48);
            this.btnListaSalesStores.Name = "btnListaSalesStores";
            this.btnListaSalesStores.Size = new System.Drawing.Size(176, 30);
            this.btnListaSalesStores.TabIndex = 6;
            this.btnListaSalesStores.Text = "Lista Sales y Stores";
            this.btnListaSalesStores.UseVisualStyleBackColor = true;
            this.btnListaSalesStores.Click += new System.EventHandler(this.btnListaSalesStores_Click);
            // 
            // btnPublicadorEspecial
            // 
            this.btnPublicadorEspecial.Location = new System.Drawing.Point(558, 12);
            this.btnPublicadorEspecial.Name = "btnPublicadorEspecial";
            this.btnPublicadorEspecial.Size = new System.Drawing.Size(176, 30);
            this.btnPublicadorEspecial.TabIndex = 7;
            this.btnPublicadorEspecial.Text = "Lista Publicador Especial";
            this.btnPublicadorEspecial.UseVisualStyleBackColor = true;
            this.btnPublicadorEspecial.Click += new System.EventHandler(this.btnPublicadorEspecial_Click);
            // 
            // btnPunto8
            // 
            this.btnPunto8.Location = new System.Drawing.Point(558, 48);
            this.btnPunto8.Name = "btnPunto8";
            this.btnPunto8.Size = new System.Drawing.Size(176, 30);
            this.btnPunto8.TabIndex = 8;
            this.btnPunto8.Text = "Punto 8";
            this.btnPunto8.UseVisualStyleBackColor = true;
            this.btnPunto8.Click += new System.EventHandler(this.btnPunto8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPunto8);
            this.Controls.Add(this.btnPublicadorEspecial);
            this.Controls.Add(this.btnListaSalesStores);
            this.Controls.Add(this.btnPublicadorPorNombre);
            this.Controls.Add(this.btnAutorPorId);
            this.Controls.Add(this.btnAutorPorCiudad);
            this.Controls.Add(this.btnTraerPublicadores);
            this.Controls.Add(this.gridAutores);
            this.Controls.Add(this.btnTraerTodosAutores);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodosAutores;
        private System.Windows.Forms.DataGridView gridAutores;
        private System.Windows.Forms.Button btnTraerPublicadores;
        private System.Windows.Forms.Button btnAutorPorCiudad;
        private System.Windows.Forms.Button btnAutorPorId;
        private System.Windows.Forms.Button btnPublicadorPorNombre;
        private System.Windows.Forms.Button btnListaSalesStores;
        private System.Windows.Forms.Button btnPublicadorEspecial;
        private System.Windows.Forms.Button btnPunto8;
    }
}

