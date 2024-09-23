using DomainModel.Models;

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

            Vehicle myCar = new Vehicle();

            myCar.Registration = RegistrationTxtBox.Text;
            myCar.Make = MakeTxtBox.Text;
            myCar.Model = ModelTxtBox.Text;

            MessageBox.Show($@"
                                Successfully added
                                Registration - {myCar.Registration}
                                Make - {myCar.Make}
                                Model - {myCar.Model}
                                Tyre Pressures are - {NsfTyrePressure.Text}  {OsfTyrePressure.Text}
                                                            - {NsrTyrePressure.Text}  {OsrTyrePressure.Text}");
        }
    }

}
