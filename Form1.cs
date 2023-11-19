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

namespace MethodCollection
{
    public partial class Form1 : Form
    {
        ArrayFormCars carsarr = new ArrayFormCars();

        string filename = "CarItem.txt";

        public Form1()
        {
            InitializeComponent();
        }
        public void show(DataGridView dg)
        {
            dg.Rows.Clear();
            foreach (CarCharakter c in carsarr.Cars)            
                dg.Rows.Add(c.Brand, c.Name, c.Year, c.Run);
            
        }
        private void Add_new_data_button_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new CarCharakter(textBox1.Text,textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
                carsarr.AddCar(car);
                var lastCar = carsarr.Cars[carsarr.Cars.Count - 1];
                dataGridView2.Rows.Add(
                    lastCar.Brand,
                    lastCar.Name,
                    lastCar.Year,
                    lastCar.Run);
            }
            catch
            {
                MessageBox.Show("Invalid data");
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            carsarr.WriteFile(filename);
            MessageBox.Show("Data successfully recorded");
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            carsarr.Cars.Sort();
            dataGridView1.Rows.Clear();
            foreach (CarCharakter car in carsarr.Cars)            
                if (car.Year > Convert.ToInt32(Sortik.Text))
                    dataGridView1.Rows.Add(car.Brand, car.Name, car.Year, car.Run);
            
        }

        private void Delate_button_Click(object sender, EventArgs e)
        {
            var car = dataGridView2.CurrentRow.Index;
            carsarr.Remove(car);
            show(dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carsarr.ReadFile(filename);
            show(dataGridView2);
            MessageBox.Show("Data successfully recorded");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carsarr.Sortt();
            show(dataGridView3);
        }
    }
}
