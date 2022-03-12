using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso2
{
    public partial class Form1 : Form
    {
        List<DatosVehiculos> datosVehiculo = new List<DatosVehiculos>();
        List<Clientes> cliente = new List<Clientes>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cargarDatosVehiculos()
        {
            FileStream stream = new FileStream("DatosVehiculos.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                DatosVehiculos datos = new DatosVehiculos();
                datos.placa = reader.ReadLine();
                datos.marca = reader.ReadLine();
                datos.modelo = Convert.ToInt16(reader.ReadLine());
                datos.color = reader.ReadLine();
                datos.precioPorKm = Convert.ToDecimal(reader.ReadLine());
                datosVehiculo.Add(datos);
            }
            reader.Close();
        }
        private void cargarClientes()
        {
            FileStream stream = new FileStream("Clientes.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Clientes clientes = new Clientes();
                clientes.nit = reader.ReadLine();
                clientes.nombre = reader.ReadLine();
                clientes.direccion = reader.ReadLine();
                cliente.Add(clientes);
            }
            reader.Close();
        }
        private void cargarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = datosVehiculo;
            dataGridView1.Refresh();

            dataGridView2.DataSource = null;
            dataGridView2.Refresh();
            dataGridView2.DataSource = cliente;
            dataGridView2.Refresh();
        }

        private void buttonIngresarVehiculos_Click(object sender, EventArgs e)
        {
            FormVehiculos vehiculos = new FormVehiculos();
            vehiculos.Show();
        }

        private void buttonIngresarAlquiler_Click(object sender, EventArgs e)
        {
            FormAlquiler alquiler = new FormAlquiler();
            alquiler.Show();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            cargarDatosVehiculos();
            cargarClientes();
            cargarGrid();
        }
    }
}
