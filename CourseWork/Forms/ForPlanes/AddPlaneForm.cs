using CourseWork.Entities;
using CourseWork.Helpers;
using CourseWork.Services;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Forms.ForTransports;

public partial class AddPlaneForm : Form
{
    public AddPlaneForm() => InitializeComponent();

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        MainForm.airportContext.Pilots.Load();
        DriverBindingSource.DataSource = MainForm.airportContext.Pilots.Local.ToBindingList();

        MainForm.airportContext.Pilots.Load();
        RouteBindingSource.DataSource = MainForm.airportContext.Flights.Local.ToBindingList();

        ComboBoxDriver.DisplayMember = "FirstName";

        ComboBoxFirstLetter.SelectedIndex = 0;
        ComboBoxSecondLetter.SelectedIndex = 0;
        ComboBoxThirdLetter.SelectedIndex = 0;
    }

    private async void ButtonAdd_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        PlaneService transportService = new(MainForm.airportContext);

        try
        {
            var driver = ComboBoxDriver.SelectedItem as Pilot;
            var route = ComboBoxRoute.SelectedItem as Flight;

            var transport = new Plane
            {
                Model = TextBoxModel.Text,
                LicensePlate = $"{ComboBoxFirstLetter.Text}{NumericUpDownLicensePlateNumber.Value:000}{ComboBoxSecondLetter.Text}{ComboBoxThirdLetter.Text}",
                Capacity = (int)NumericUpDownCapacity.Value,
                LastMaintenanceDate = DateTimePickerMaintenanceDate.Value,
                FlightTime = (double)NumericUpDownMileage.Value,
                Pilot = driver,
                Flight = route
            };

            await transportService.AddPlaneAsync(transport);

            MessageBox.Show("Самолет успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось добавить самолет: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool ValidateInput() => !string.IsNullOrWhiteSpace(TextBoxModel.Text);

    private void ButtonGenerate_Click(object sender, EventArgs e)
    {
        var transportParameters = PlaneGenerator.Generate();

        TextBoxModel.Text = transportParameters.Item1;
        ComboBoxFirstLetter.SelectedItem = transportParameters.Item2[0];
        NumericUpDownLicensePlateNumber.Value = int.Parse(transportParameters.Item2[1]);
        ComboBoxSecondLetter.SelectedItem = transportParameters.Item2[2];
        ComboBoxThirdLetter.SelectedItem = transportParameters.Item2[3];
        NumericUpDownCapacity.Value = transportParameters.Item3;
        DateTimePickerMaintenanceDate.Value = transportParameters.Item4;
        NumericUpDownMileage.Value = transportParameters.Item5;
    }

    
    private void ButtonClear_Click(object sender, EventArgs e)
    {
        TextBoxModel.Clear();
        ComboBoxFirstLetter.ResetText();
        NumericUpDownLicensePlateNumber.Value = NumericUpDownLicensePlateNumber.Minimum;
        ComboBoxSecondLetter.ResetText();
        ComboBoxThirdLetter.ResetText();
        NumericUpDownCapacity.Value = NumericUpDownCapacity.Minimum;
        DateTimePickerMaintenanceDate.ResetText();
        NumericUpDownMileage.Value = NumericUpDownMileage.Minimum;
        ComboBoxDriver.ResetText();
        ComboBoxRoute.ResetText();
    }

    
    private void ButtonExit_Click(object sender, EventArgs e) => Close();

    private void TextBoxModel_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TextBoxModel.Text))
            ErrorProvider.SetError(TextBoxModel, "Некорректная модель самолета");
    }
}
