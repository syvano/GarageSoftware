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

            car.Registration = RegistrationTxtBox.Text.ToUpper();
            car.Make = MakeTxtBox.Text.ToUpper();
            car.Model = ModelTxtBox.Text.ToUpper();
            car.Front_Brake_Remaining = (int)FrontBrakeNum.Value;
            car.Rear_Brake_Remaining = (int)RearBrakeNum.Value;
            car.Anti_Freeze_Strength = (int)AntiFreezeStengthNum.Value;
            car.Odometer = (int)OdometerNum.Value;

            CarsDataAccess db = new CarsDataAccess();
            db.AddCar(car);

            ClearAllFields();

        }

        private void ClearAllFields()
        {
            RegistrationTxtBox.Text = default;
            MakeTxtBox.Text = default;
            ModelTxtBox.Text = default;
            FrontBrakeNum.Value = default;
            RearBrakeNum.Value = default;
            AntiFreezeStengthNum.Value = default;
            OdometerNum.Value = default;
        }
    }

}
