using CourseWork.Entities;
using CourseWork.Helpers;
using CourseWork.Services;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Forms.ForRoutes;

public partial class AddFlightForm : Form
{
    public AddFlightForm() => InitializeComponent();

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        MainForm.airportContext.Planes.Load();
        TransportBindingSource.DataSource = MainForm.airportContext.Planes.Local.ToBindingList();
    }

    private async void ButtonAdd_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        FlightService routeService = new(MainForm.airportContext);

        try
        {
            var route = new Flight
            {
                Name = TextBoxName.Text,
                Distance = (int)NumericUpDownDistance.Value,
                StartLocation = TextBoxStartLocation.Text,
                EndLocation = TextBoxEndLocation.Text,
                StartTime = DateTimePickerStartTime.Value,
                EndTime = DateTimePickerEndTime.Value,
                Planes = ListBoxPlanes.SelectedItems.Cast<Plane>().ToList(),
                Pilots = ListBoxPlanes.SelectedItems.Cast<Plane>().Select(t => t.Pilot).Where(d => d != null).ToList(),
            };

            await routeService.AddFlightAsync(route);

            MessageBox.Show("Рейс успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось добавить рейс: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool ValidateInput() => !string.IsNullOrWhiteSpace(TextBoxName.Text)
                                    && !string.IsNullOrWhiteSpace(TextBoxStartLocation.Text)
                                    && !string.IsNullOrWhiteSpace(TextBoxEndLocation.Text);

    private void ButtonGenerate_Click(object sender, EventArgs e)
    {
        var routeParameters = FlightGenerator.Generate();

        TextBoxName.Text = routeParameters.Item1;
        TextBoxStartLocation.Text = routeParameters.Item2;
        TextBoxEndLocation.Text = routeParameters.Item3;
        NumericUpDownDistance.Value = (decimal)routeParameters.Item4;
    }

    private void ButtonClear_Click(object sender, EventArgs e)
    {
        TextBoxName.Clear();
        NumericUpDownDistance.Value = NumericUpDownDistance.Minimum;
        TextBoxStartLocation.Clear();
        TextBoxEndLocation.Clear();
        DateTimePickerStartTime.ResetText();
        DateTimePickerEndTime.ResetText();
        ListBoxPlanes.ClearSelected();
    }

    private void ButtonExit_Click(object sender, EventArgs e) => Close();

    private void TextBoxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TextBoxName.Text))
            ErrorProvider.SetError(TextBoxName, "Некорректное название рейса");
    }

    private void TextBoxStartLocation_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TextBoxStartLocation.Text))
            ErrorProvider.SetError(TextBoxStartLocation, "Некорректное место вылета");
    }

    private void TextBoxEndLocation_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TextBoxEndLocation.Text))
            ErrorProvider.SetError(TextBoxEndLocation, "Некорректное место прибытия");
    }
}
