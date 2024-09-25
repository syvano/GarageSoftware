using DomainModel.Models;
using DataAccessLayer;

namespace GarageSoftware
{
    public partial class GarageForm : Form
    {
        public GarageForm()
        {
            InitializeComponent();
        }

        private void AddVehicleBtn_Click(object sender, EventArgs e)
        {

            Car car = new Car();

            car.Registration = RegistrationTxtBox.Text;
            car.Make = MakeTxtBox.Text;
            car.Model = ModelTxtBox.Text;
            car.Front_Brake_Remaining = 90;
            car.Rear_Brake_Remaining = 90;
            car.Anti_Freeze_Strength = -25;

            CarsDataAccess carsDataAccess = new CarsDataAccess();
            carsDataAccess.AddCar(car);

        }
    }

}
