using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsPubs.Data;

namespace WindowsPubs
{
    
    
    
    public partial class Form1 : Form
    {
        PubsContext context = new PubsContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerTodosAutores_Click(object sender, EventArgs e)
        {
            var autores = (from a in context.authors select a).ToList();

            gridAutores.DataSource = autores;
        }

        private void btnTraerPublicadores_Click(object sender, EventArgs e)
        {
            var publicadores = (from p in context.publishers select p).ToList();
            gridAutores.DataSource = publicadores;
        }

        private void btnAutorPorCiudad_Click(object sender, EventArgs e)
        {
            string ciudad = "Oakland";
            var autores = (from a in context.authors where a.city == ciudad select a).ToList();
            gridAutores.DataSource = autores;
        }

        private void btnAutorPorId_Click(object sender, EventArgs e)
        {
            string Id = "722-51-5454";
            var autor = (from a in context.authors where a.au_id == Id select a).SingleOrDefault();

            MessageBox.Show(autor.au_lname);
        }

        private void btnPublicadorPorNombre_Click(object sender, EventArgs e)
        {
            string nombre = "Five Lakes Publishing";
            var publicador = (from p in context.publishers where p.pub_name == nombre select p).SingleOrDefault();
            MessageBox.Show(publicador.pub_name + " " + publicador.state);
        }

        private void btnListaSalesStores_Click(object sender, EventArgs e)
        {
            //6-Mostrar una lista(Id, NombreTienda, Ciudad, NroOrden, fecha, Cantidad y IdTitulo) Usar las entidades: sales y stores

            var lista = (from s in context.sales
                         join
                         store in context.stores
                         on s.stor_id equals store.stor_id
                         select new
                         {
                             s.stor_id, store.stor_name,
                             store.city, s.ord_num, s.ord_date,
                             s.title_id
                         }).ToList();
            gridAutores.DataSource = lista;
        }

        private void btnPublicadorEspecial_Click(object sender, EventArgs e)
        {
            //7-Mostrar una lista(Nombre, apellido, nombre del publicador)
            //. Usar las tablas: employee y publishers

            var lista = (from employee in context.employees
                         join
                         publisher in context.publishers
                         on employee.pub_id equals publisher.pub_id
                         select new
                         {
                             Name=employee.fname,
                             LastName=employee.lname,
                             PublisherName=publisher.pub_name
                         }).ToList();
            gridAutores.DataSource = lista;
        }

        private void btnPunto8_Click(object sender, EventArgs e)
        {
            //8-Mostrar una lista(Nombre, apellido, nombre del publicador)
            //. Usar las tablas: employee y publishers.Agregar un filtro deben traer los empleados que viven en el mismo pais.
            string pais = "Germany";
            var lista = (from employee in context.employees
                         join
                         publisher in context.publishers
                         on employee.pub_id equals publisher.pub_id
                         where publisher.country == pais
                         select new
                         {
                             Name = employee.fname,
                             LastName = employee.lname,
                             PublisherName = publisher.pub_name
                         }).ToList();
            gridAutores.DataSource = lista;
        }
    }
}
