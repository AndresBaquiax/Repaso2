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
    public partial class FormVehiculos : Form
    {
        List<DatosVehiculos> vehiculos = new List<DatosVehiculos>();
        public FormVehiculos()
        {
            InitializeComponent();
        }
        private void buttonGuardarVehiculos_Click_1(object sender, EventArgs e)
        {
            DatosVehiculos vehiculo = new DatosVehiculos();
            vehiculo.placa = textBoxPlaca.Text;
            vehiculo.marca = textBoxMarca.Text;
            vehiculo.modelo = Convert.ToInt16(textBoxModelo.Text);
            vehiculo.color = textBoxColor.Text;
            vehiculo.precioPorKm = Convert.ToDecimal(textBoxPrecioKm.Text);


            int posicion = vehiculos.FindIndex(x => x.placa == vehiculo.placa);
            if(posicion == -1)
            {
                vehiculos.Add(vehiculo);
                GuardarVehiculos();

            }
            else
            {
                MessageBox.Show("Placa Repetida");
            }
            textBoxPlaca.Text = "";
            textBoxMarca.Text = "";
            textBoxModelo.Text = "";
            textBoxColor.Text = "";
            textBoxPrecioKm.Text = "";

            
        }
        private void GuardarVehiculos()
        {
            FileStream stream = new FileStream("DatosVehiculos.txt" , FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var dato in vehiculos)
            {
                writer.WriteLine(dato.placa);
                writer.WriteLine(dato.marca);
                writer.WriteLine(dato.modelo);
                writer.WriteLine(dato.color);
                writer.WriteLine(dato.precioPorKm);
            }
            writer.Close();
        }
    }
}
