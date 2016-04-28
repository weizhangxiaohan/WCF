using CarApplication.CarReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CarReference.CarManagementClient client = new CarReference.CarManagementClient();
                LinkedList<Car> cars;
                cars = client.ListCars();

                foreach (var car in cars)
                {
                    listBox1.Items.Add(car.BrandName + " " + car.TypeName);
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CarReference.CarManagementClient client = new CarReference.CarManagementClient();
                Car car = new Car();
                car.BrandName = "BMW";
                car.TypeName = "320d";
                int carID = client.InsertNewCar(car);
            }
            catch (Exception ex)
            {

                textBox1.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                CarReference.CarManagementClient client = new CarReference.CarManagementClient();
                byte[] buff;
                buff = client.GetCarPicture("C67872");

                TypeConverter converter = TypeDescriptor.GetConverter(typeof(Bitmap));

                Bitmap bitmap = (Bitmap)converter.ConvertFrom(buff);

                pictureBox1.Image = bitmap;
            }
            catch (Exception ex)
            {

                textBox1.Text = ex.Message;
            }
        }
    }
}
