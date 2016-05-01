using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalInterface;
using System.ServiceModel;

namespace RantalApplication
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
                RentalProxy rentalProxy = new RentalProxy();
                RentalRegistration rentalRegistration = new RentalRegistration();
                rentalRegistration.CustomerID = 1;
                rentalRegistration.CarID = "123767";

                rentalRegistration.DropOffLocation = 1327;
                rentalRegistration.DropOffDateTime = DateTime.Now;

                rentalRegistration.PickUpLocation = 7633;
                rentalRegistration.PickUpDateTime = DateTime.Now;

                rentalProxy.RegisterCarRental(rentalRegistration);
            }
            catch (FaultException<RentalRegisterFault> rentalRegisterFault)
            {

                MessageBox.Show("rentalRegisterFault " + rentalRegisterFault.Message);
            }
            catch (FaultException faultException)
            {

                MessageBox.Show("faultException " + faultException.Message);
            }
            catch (EndpointNotFoundException endpointNotFoundException)
            {

                MessageBox.Show("endpointNotFoundException " + endpointNotFoundException.Message);
            }
            catch (CommunicationException communicationException)
            {

                MessageBox.Show("communicationException " + communicationException.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RentalProxy rentalProxy = new RentalProxy();
                rentalProxy.RegisterCarRentalAsPayed("1876893");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
