using CourseWork.Entities;
using CourseWork.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace CourseWork.Forms.ForTransports;

public partial class UpdatePilotForm : Form
{
    private readonly Pilot _driver = new();

    public UpdatePilotForm() => InitializeComponent();

    public UpdatePilotForm(Pilot driver) : this() => _driver = driver;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        MainForm.airportContext.Pilots.Load();
        TransportBindingSource.DataSource = MainForm.airportContext.Planes.Local.ToBindingList();

        TextBoxFirstName.Text = _driver.FirstName;
        TextBoxLastName.Text = _driver.LastName;
        NumericUpDownAge.Value = _driver.Age;
        NumericUpDownDrivingExperience.Value = _driver.FlyingExperience;
        ComboBoxTransport.SelectedItem = _driver.Plane;
    }

    private async void ButtonUpdate_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _driver.FirstName = TextBoxFirstName.Text;
        _driver.LastName = TextBoxLastName.Text;
        _driver.Age = (int)NumericUpDownAge.Value;
        _driver.FlyingExperience = (int)NumericUpDownDrivingExperience.Value;
        _driver.Plane = ComboBoxTransport.SelectedItem as Plane;

        PilotService driverService = new(MainForm.airportContext);
        try
        {
            await driverService.UpdatePilotAsync(_driver);

            MessageBox.Show("Пилот успешно изменен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось изменить пилота: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    [GeneratedRegex("^[А-ЯЁ][а-яё]*(-[А-ЯЁ][а-яё]*)?$")]
    private static partial Regex RegexRussianName();

    [GeneratedRegex("^[А-ЯЁ][а-яё]*(-[А-ЯЁ][а-яё]*)?$")]
    private static partial Regex RegexRussianSurname();

    private bool ValidateInput() => RegexRussianName().IsMatch(TextBoxFirstName.Text)
                                    && RegexRussianSurname().IsMatch(TextBoxLastName.Text);

    private void ButtonExit_Click(object sender, EventArgs e) => Close();
}
