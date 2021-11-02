
namespace WindowsEF_Linq
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
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.btnTraerPorCategoria = new System.Windows.Forms.Button();
            this.btnTraerPorNombreProducto = new System.Windows.Forms.Button();
            this.btnTraerPorId = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.btnTraerProductoCategoria = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Location = new System.Drawing.Point(12, 12);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(224, 28);
            this.btnTraerTodos.TabIndex = 0;
            this.btnTraerTodos.Text = "Traer todos los productos";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // btnTraerPorCategoria
            // 
            this.btnTraerPorCategoria.Location = new System.Drawing.Point(242, 12);
            this.btnTraerPorCategoria.Name = "btnTraerPorCategoria";
            this.btnTraerPorCategoria.Size = new System.Drawing.Size(224, 28);
            this.btnTraerPorCategoria.TabIndex = 1;
            this.btnTraerPorCategoria.Text = "Traer todos los productos por categoria";
            this.btnTraerPorCategoria.UseVisualStyleBackColor = true;
            this.btnTraerPorCategoria.Click += new System.EventHandler(this.btnTraerPorCategoria_Click);
            // 
            // btnTraerPorNombreProducto
            // 
            this.btnTraerPorNombreProducto.Location = new System.Drawing.Point(12, 46);
            this.btnTraerPorNombreProducto.Name = "btnTraerPorNombreProducto";
            this.btnTraerPorNombreProducto.Size = new System.Drawing.Size(224, 28);
            this.btnTraerPorNombreProducto.TabIndex = 2;
            this.btnTraerPorNombreProducto.Text = "Traer por Nombre de producto";
            this.btnTraerPorNombreProducto.UseVisualStyleBackColor = true;
            this.btnTraerPorNombreProducto.Click += new System.EventHandler(this.btnTraerPorNombreProducto_Click);
            // 
            // btnTraerPorId
            // 
            this.btnTraerPorId.Location = new System.Drawing.Point(242, 46);
            this.btnTraerPorId.Name = "btnTraerPorId";
            this.btnTraerPorId.Size = new System.Drawing.Size(224, 28);
            this.btnTraerPorId.TabIndex = 3;
            this.btnTraerPorId.Text = "Traer por ID";
            this.btnTraerPorId.UseVisualStyleBackColor = true;
            this.btnTraerPorId.Click += new System.EventHandler(this.btnTraerPorId_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridProductos.Location = new System.Drawing.Point(0, 80);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(1008, 370);
            this.gridProductos.TabIndex = 4;
            // 
            // btnTraerProductoCategoria
            // 
            this.btnTraerProductoCategoria.Location = new System.Drawing.Point(472, 12);
            this.btnTraerProductoCategoria.Name = "btnTraerProductoCategoria";
            this.btnTraerProductoCategoria.Size = new System.Drawing.Size(224, 28);
            this.btnTraerProductoCategoria.TabIndex = 5;
            this.btnTraerProductoCategoria.Text = "Traer Producto Categoria";
            this.btnTraerProductoCategoria.UseVisualStyleBackColor = true;
            this.btnTraerProductoCategoria.Click += new System.EventHandler(this.btnTraerProductoCategoria_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Traer Producto Categoria";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTraerProductoCategoria);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnTraerPorId);
            this.Controls.Add(this.btnTraerPorNombreProducto);
            this.Controls.Add(this.btnTraerPorCategoria);
            this.Controls.Add(this.btnTraerTodos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.Button btnTraerPorCategoria;
        private System.Windows.Forms.Button btnTraerPorNombreProducto;
        private System.Windows.Forms.Button btnTraerPorId;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Button btnTraerProductoCategoria;
        private System.Windows.Forms.Button button1;
    }
}

