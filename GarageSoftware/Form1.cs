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
            MessageBox.Show($@"
                                Successfully added
                                Registration - {RegistrationTxtBox.Text}
                                Make - {MakeTxtBox.Text}
                                Model - {ModelTxtBox.Text}
                                Tyre Pressures are - {NsfTyrePressure.Text}  {OsfTyrePressure.Text}
                                                            - {NsrTyrePressure.Text}  {OsrTyrePressure.Text}");
        }
    }
}
