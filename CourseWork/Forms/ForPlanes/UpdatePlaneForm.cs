using CourseWork.Entities;
using CourseWork.Services;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Forms.ForTransports;

public partial class UpdatePlaneForm : Form
{
    private readonly Plane _transport = new();

    public UpdatePlaneForm() => InitializeComponent();

    public UpdatePlaneForm(Plane transport) : this() => _transport = transport;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        MainForm.airportContext.Pilots.Load();
        DriverBindingSource.DataSource = MainForm.airportContext.Pilots.Local.ToBindingList();

        MainForm.airportContext.Flights.Load();
        RouteBindingSource.DataSource = MainForm.airportContext.Flights.Local.ToBindingList();

        TextBoxModel.Text = _transport.Model;
        ComboBoxFirstLetter.SelectedText = _transport.LicensePlate[0].ToString();
        NumericUpDownLicensePlateNumber.Value = int.Parse(_transport.LicensePlate.Substring(1, 3));
        ComboBoxSecondLetter.SelectedText = _transport.LicensePlate[4].ToString();
        ComboBoxThirdLetter.SelectedText = _transport.LicensePlate[5].ToString();
        NumericUpDownCapacity.Value = _transport.Capacity;
        DateTimePickerMaintenanceDate.Value = _transport.LastMaintenanceDate;
        NumericUpDownMileage.Value = int.Parse(_transport.FlightTime.ToString());
        ComboBoxDriver.SelectedItem = _transport.Pilot;
        ComboBoxRoute.SelectedItem = _transport.Pilot;
    }

    private async void ButtonUpdate_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _transport.Model = TextBoxModel.Text;
        _transport.LicensePlate = $"{ComboBoxFirstLetter.Text}{NumericUpDownLicensePlateNumber.Value:000}{ComboBoxSecondLetter.Text}{ComboBoxThirdLetter.Text}";
        _transport.Capacity = (int)NumericUpDownCapacity.Value;
        _transport.LastMaintenanceDate = DateTimePickerMaintenanceDate.Value;
        _transport.FlightTime = (double)NumericUpDownMileage.Value;
        _transport.Pilot = ComboBoxDriver.SelectedItem as Pilot;
        _transport.Pilot = ComboBoxRoute.SelectedItem as Pilot;

        PlaneService transportService = new(MainForm.airportContext);
        try
        {
            await transportService.UpdatePlaneAsync(_transport);

            MessageBox.Show("Самолет успешно изменен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось изменить самолет: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool ValidateInput() => !string.IsNullOrWhiteSpace(TextBoxModel.Text);

    private void ButtonExit_Click(object sender, EventArgs e) => Close();
}
