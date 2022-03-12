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
    public partial class FormAlquiler : Form
    {
        List<Alquiler> alquileres = new List<Alquiler>();
        List<DatosVehiculos> datosVehiculo = new List<DatosVehiculos>();
        List<Clientes> clientes = new List<Clientes>();
        List<Mostrar> mostrar = new List<Mostrar>();
        public FormAlquiler()
        {
            InitializeComponent();
        }

        private void buttonGuardarAlquiler_Click(object sender, EventArgs e)
        {
            Alquiler alquiler = new Alquiler();
            alquiler.nit = textBoxNit.Text;
            alquiler.placa = textBoxPlaca.Text;
            alquiler.fechaAlquiler = dateTimePickerFechaAlquiler.Value;
            alquiler.fechaDevolucion = dateTimePickerFechaDevolucion.Value;
            alquiler.kmRecorridos = Convert.ToInt16(textBoxKmRecorridos.Text); 
            alquileres.Add(alquiler);
            GuardarAlquileres();

            textBoxNit.Text = "";
            textBoxPlaca.Text = "";
            textBoxKmRecorridos.Text = "";

        }
        private void GuardarAlquileres()
        {
            FileStream stream = new FileStream("Alquileres.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var dato in alquileres)
            {
                writer.WriteLine(dato.nit);
                writer.WriteLine(dato.placa);
                writer.WriteLine(dato.fechaAlquiler);
                writer.WriteLine(dato.fechaDevolucion);
                writer.WriteLine(dato.kmRecorridos);
            }
            writer.Close();
        }

        private void FormAlquiler_Load(object sender, EventArgs e)
        {

        }
        private void cargarMostrar()
        {
            FileStream stream = new FileStream("Mostrar.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Mostrar mostrarT = new Mostrar();
                mostrarT.nombre = reader.ReadLine();
                mostrarT.placa = reader.ReadLine();
                mostrarT.color = reader.ReadLine();
                mostrarT.fechaDevolucion = Convert.ToDateTime(reader.ReadLine());
                mostrarT.totalPagar = Convert.ToDecimal(reader.ReadLine());
                mostrar.Add(mostrarT);
            }
            reader.Close();
        }
        private void cargarAlquiler()
        {
            FileStream stream = new FileStream("Alquileres.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Alquiler alquileresT = new Alquiler();
                alquileresT.nit = reader.ReadLine();
                alquileresT.placa = reader.ReadLine();
                alquileresT.fechaAlquiler = Convert.ToDateTime(reader.ReadLine());
                alquileresT.fechaDevolucion = Convert.ToDateTime(reader.ReadLine());
                alquileresT.kmRecorridos = Convert.ToDecimal(reader.ReadLine());
                alquileres.Add(alquileresT);
            }
            reader.Close();
        }
        private void GuardarMostrar()
        {
            FileStream stream = new FileStream("Mostrar.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var dato in mostrar)
            {
                writer.WriteLine(dato.nombre);
                writer.WriteLine(dato.placa);
                writer.WriteLine(dato.color);
                writer.WriteLine(dato.fechaDevolucion);
                writer.WriteLine(dato.totalPagar);
            }
            writer.Close();
        }
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alquileres.Count; i++)
            {
                Mostrar mostrarT = new Mostrar();
                for (int j = 0; j < clientes.Count; j++)
                {
                    if (alquileres[i].nit == clientes[j].nit)
                    {
                        mostrarT.nombre = clientes[j].nombre;
                    }
                }
                for (int k = 0; k < datosVehiculo.Count; k++)
                {
                    if (alquileres[i].placa == datosVehiculo[k].placa)
                    {
                        mostrarT.placa = datosVehiculo[k].placa;
                        mostrarT.color = datosVehiculo[k].color;
                        mostrarT.totalPagar = datosVehiculo[k].precioPorKm * alquileres[i].kmRecorridos;
                    }
                }
                mostrar.Add(mostrarT);
                GuardarMostrar();
                cargarMostrar();
                dataGridViewMostrar.DataSource = null;
                dataGridViewMostrar.Refresh();
                dataGridViewMostrar.DataSource = mostrar;
                dataGridViewMostrar.Refresh();
            }
        }
    }
}
