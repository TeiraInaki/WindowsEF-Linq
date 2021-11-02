using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsEF_Linq.Data;

namespace WindowsEF_Linq
{
    public partial class Form1 : Form
    {
        //Crear una instancia del DbContext
        NorthwindContext context = new NorthwindContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            var productos = (from p in context.Products select p).ToList();

            gridProductos.DataSource = productos;
        }

        private void btnTraerPorCategoria_Click(object sender, EventArgs e)
        {
            int categoryId = 2;
            var productos = (from p in context.Products where p.CategoryID == categoryId select p).ToList();

            gridProductos.DataSource = productos;
        }

        private void btnTraerPorNombreProducto_Click(object sender, EventArgs e)
        {
            string nombre = "Konbu";
            var producto = (from p in context.Products where p.ProductName == nombre select p).SingleOrDefault();

            MessageBox.Show(producto.ProductName + "\nPrecio:  " + producto.UnitPrice);
        }

        private void btnTraerPorId_Click(object sender, EventArgs e)
        {
            int Id = 6;
            var producto = (from p in context.Products where p.ProductID == Id select p).SingleOrDefault();

            MessageBox.Show(producto.ProductName + "\nPrecio:  " + producto.UnitPrice);
        }

        private void btnTraerProductoCategoria_Click(object sender, EventArgs e)
        {
            //Me permite unir en una misma tabla varias tablas, ademas de mostrar de esas tablas unidas las columnas que yo quiera
            var lista = (
                from c in context.Categories
                join 
                p in context.Products
                on c.CategoryID equals p.CategoryID
                select new
                {
                    //p.CategoryID,
                    p.ProductID,
                    Category=c.CategoryName,
                    Product=p.ProductName, p.UnitPrice
                }).ToList();

            gridProductos.DataSource = lista;
        }
    }
}
