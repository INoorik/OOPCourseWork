using CourseWork.Entities;
using CourseWork.Helpers;
using CourseWork.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace CourseWork;

public partial class AddPIlotForm : Form
{
    public AddPIlotForm() => InitializeComponent();

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        MainForm.airportContext.Planes.Load();
        TransportBindingSource.DataSource = MainForm.airportContext.Planes.Local.ToBindingList();

        MainForm.airportContext.Flights.Load();
        RouteBindingSource.DataSource = MainForm.airportContext.Flights.Local.ToBindingList();
    }

    private async void ButtonAdd_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        PilotService driverService = new(MainForm.airportContext);

        try
        {
            Plane? transport = ComboBoxTransport.SelectedItem as Plane;

            var driver = new Pilot
            {
                FirstName = TextBoxFirstName.Text,
                LastName = TextBoxLastName.Text,
                Age = (int)NumericUpDownAge.Value,
                FlyingExperience = (int)NumericUpDownDrivingExperience.Value,
                Plane = transport,
                Flight = transport?.Flight,
            };

            await driverService.AddPilotAsync(driver);

            MessageBox.Show("Пилот успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось добавить пилота: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    [GeneratedRegex("^[А-ЯЁ][а-яё]*(-[А-ЯЁ][а-яё]*)?$")]
    private static partial Regex RegexRussianName();

    [GeneratedRegex("^[А-ЯЁ][а-яё]*(-[А-ЯЁ][а-яё]*)?$")]
    private static partial Regex RegexRussianSurname();

    private bool ValidateInput() => RegexRussianName().IsMatch(TextBoxFirstName.Text)
                                    && RegexRussianSurname().IsMatch(TextBoxLastName.Text);

    private void ButtonGenerate_Click(object sender, EventArgs e)
    {
        var driverParameters = PilotGenerator.Generate();

        TextBoxFirstName.Text = driverParameters.Item1;
        TextBoxLastName.Text = driverParameters.Item2;
        NumericUpDownAge.Value = driverParameters.Item3;
        NumericUpDownDrivingExperience.Value = driverParameters.Item4;
    }

    /// <summary>
    /// Обработчик нажатия на кнопку очистки полей формы
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonClear_Click(object sender, EventArgs e)
    {
        TextBoxFirstName.Clear();
        TextBoxLastName.Clear();
        NumericUpDownAge.Value = NumericUpDownAge.Minimum;
        NumericUpDownDrivingExperience.Value = NumericUpDownDrivingExperience.Minimum;
        ComboBoxTransport.ResetText();
    }

    /// <summary>
    /// Обработчик нажатия на кнопку выхода из приложения
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonExit_Click(object sender, EventArgs e) => Close();

    private void TextBoxFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (!RegexRussianName().IsMatch(TextBoxFirstName.Text))
            ErrorProvider.SetError(TextBoxFirstName, "Некорректное имя пилота");
    }

    private void TextBoxLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (!RegexRussianName().IsMatch(TextBoxLastName.Text))
            ErrorProvider.SetError(TextBoxLastName, "Некорректная фамилия пилота");
    }
}
