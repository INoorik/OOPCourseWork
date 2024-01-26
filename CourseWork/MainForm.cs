using CourseWork.Contexts;
using CourseWork.Entities;
using CourseWork.Forms.ForDrivers;
using CourseWork.Forms.ForMain;
using CourseWork.Forms.ForRoutes;
using CourseWork.Forms.ForTransports;
using CourseWork.Services;
using Microsoft.EntityFrameworkCore;

namespace CourseWork;

public partial class MainForm : Form
{
    /// <summary>
    /// Контекст базы данных аэропорта
    /// </summary>
    public static readonly AirportContext airportContext = new();

    /// <summary>
    /// Конструктор класса MainForm
    /// </summary>
    public MainForm() => InitializeComponent();

    /// <summary>
    /// Метод OnLoad
    /// </summary>
    /// <param name="e">Аргументы события</param>
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        airportContext.Database.EnsureDeleted();
        airportContext.Database.EnsureCreated();

        airportContext.Pilots.Load();
        DriverBindingSource.DataSource = airportContext.Pilots.Local.ToBindingList();
        UpdatePilotSearchTypes();

        airportContext.Planes.Load();
        TransportBindingSource.DataSource = airportContext.Planes.Local.ToBindingList();
        UpdatePlaneSearchTypes();

        airportContext.Flights.Load();
        RouteBindingSource.DataSource = airportContext.Flights.Local.ToBindingList();
        UpdateFlightSearchTypes();

        AuthorInfoForm authorInfoForm = new();
        authorInfoForm.ShowDialog();
    }

    private void UpdatePilotSearchTypes()
    {
        ComboBoxDriversSearchTypes.Items.Clear();
        foreach (DataGridViewColumn column in DataGridViewDrivers.Columns)
            if (column.Visible)
                ComboBoxDriversSearchTypes.Items.Add(column.HeaderText);
        ComboBoxDriversSearchTypes.SelectedIndex = 0;
    }

    private void UpdatePlaneSearchTypes()
    {
        ComboBoxTransportSearchTypes.Items.Clear();
        foreach (DataGridViewColumn column in DataGridViewTransportes.Columns)
            if (column.Visible)
                ComboBoxTransportSearchTypes.Items.Add(column.HeaderText);
        ComboBoxTransportSearchTypes.SelectedIndex = 0;
    }

    private void UpdateFlightSearchTypes()
    {
        ComboBoxRoutesSearchTypes.Items.Clear();
        foreach (DataGridViewColumn column in DataGridViewRoutes.Columns)
            if (column.Visible)
                ComboBoxRoutesSearchTypes.Items.Add(column.HeaderText);
        ComboBoxRoutesSearchTypes.SelectedIndex = 0;
    }

    /// <summary>
    /// Обработчик нажатия на кнопку добавления пилота
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonAddDriver_Click(object sender, EventArgs e)
    {
        AddPIlotForm addDriverForm = new();
        addDriverForm.ShowDialog();
    }

    /// <summary>
    /// Обработчик нажатия на кнопку изменения информации о пилоте
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonUpdateDriver_Click(object sender, EventArgs e)
    {
        if (DriverBindingSource.Current != null)
        {
            Pilot currentDriver = DriverBindingSource.Current as Pilot;

            UpdatePilotForm updateDriverForm = new(currentDriver);
            updateDriverForm.ShowDialog();

            DataGridViewDrivers.Refresh();
        }
        else
        {
            MessageBox.Show("Выберите пилота для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Обработчик нажатия на кнопку удаления выбранных пилотов
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private async void ButtonDeleteSelectedDrivers_Click(object sender, EventArgs e)
    {
        if (DataGridViewDrivers.SelectedRows.Count == 0)
        {
            MessageBox.Show("Выберите пилотов для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Создаем сервис для удаления пилотов
        PilotService driverService = new(airportContext);

        string deletedDriversIds = "";

        // Проходимся по каждой выбранной строке и удаляем соответствующего пилота
        foreach (DataGridViewRow selectedRow in DataGridViewDrivers.SelectedRows)
        {
            int driverId = (int)selectedRow.Cells[0].Value;

            try
            {
                await driverService.DeletePilotAsync(driverId);

                // Если удаление прошло успешно, добавляем ID удаленного пилота в строку deletedDriversIds
                if (deletedDriversIds == "")
                    deletedDriversIds = driverId.ToString();
                else
                    deletedDriversIds += ", " + driverId.ToString();
            }
            catch (Exception ex)
            {
                // Если произошла ошибка при удалении пилота, выводимсообщение с ошибкой
                string errorMessage = $"Не удалось удалить пилота с ID {driverId}: {ex.Message}";
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Создаем сообщение об успешном выполнении операции и показываем его, используя список удаленных ID пилотов
        string successMessage = $"Удалены пилоты с ID: {deletedDriversIds}";
        MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Обработчик нажатия на кнопку настройки фильтрации пилотов
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonFilterDrivers_Click(object sender, EventArgs e)
    {
        FilterPilotForm filterDriverForm = new(DataGridViewDrivers);
        filterDriverForm.ShowDialog();

        /*UpdateDriverSearchTypes();*/
    }

    /// <summary>
    /// Обработчик нажатия на кнопку добавления самолета
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonAddTransport_Click(object sender, EventArgs e)
    {
        AddPlaneForm addTransportForm = new();
        addTransportForm.ShowDialog();
    }

    /// <summary>
    /// Обработчик нажатия на кнопку обновления информации о самолете
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonUpdateTransport_Click(object sender, EventArgs e)
    {
        if (TransportBindingSource.Current != null)
        {
            Plane currentTransport = TransportBindingSource.Current as Plane;

            UpdatePlaneForm updateTransportForm = new(currentTransport);
            updateTransportForm.ShowDialog();

            DataGridViewTransportes.Refresh();
        }
        else
        {
            MessageBox.Show("Выберите самолет для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Обработчик нажатия на кнопку удаления выбранных самолетов
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private async void ButtonDeleteSelectedTransportes_Click(object sender, EventArgs e)
    {
        if (DataGridViewTransportes.SelectedRows.Count == 0)
        {
            MessageBox.Show("Выберите самолет для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Создаем сервис для удаления самолета
        PlaneService transportService = new(airportContext);

        string deletedTransportsIds = "";

        // Проходимся по каждой выбранной строке и удаляем соответствующий самолет
        foreach (DataGridViewRow selectedRow in DataGridViewTransportes.SelectedRows)
        {
            int transportId = (int)selectedRow.Cells[0].Value;

            try
            {
                await transportService.DeletePlaneAsync(transportId);

                // Если удаление прошло успешно, добавляем ID удаленного самолета в строку deletedDriversIds
                if (deletedTransportsIds == "")
                    deletedTransportsIds = transportId.ToString();
                else
                    deletedTransportsIds += ", " + transportId.ToString();
            }
            catch (Exception ex)
            {
                // Если произошла ошибка при удалении самолета, выводим сообщение с ошибкой
                string errorMessage = $"Не удалось удалить самолет с ID {transportId}: {ex.Message}";
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Создаем сообщение об успешном выполнении операции и показываем его, используя список удаленных ID самолетов
        string successMessage = $"Удалены саомлеты с ID: {deletedTransportsIds}";
        MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Обработчик нажатия на кнопку фильтрации самолетов
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonFilterTransportes_Click(object sender, EventArgs e)
    {
        FilterPlaneForm filterTransportForm = new(DataGridViewTransportes);
        filterTransportForm.ShowDialog();

        /*UpdateTransportSearchTypes();*/
    }

    /// <summary>
    /// Обработчик нажатия на кнопку добавления рейса
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonAddRoute_Click(object sender, EventArgs e)
    {
        AddFlightForm addRouteForm = new();
        addRouteForm.ShowDialog();
    }

    /// <summary>
    /// Обработчик нажатия на кнопку обновления информации о рейсе
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonUpdateRoute_Click(object sender, EventArgs e)
    {
        if (RouteBindingSource.Current != null)
        {
            Flight currentRoute = RouteBindingSource.Current as Flight;

            UpdateFlightForm updateRouteForm = new(currentRoute);
            updateRouteForm.ShowDialog();

            DataGridViewRoutes.Refresh();
        }
        else
        {
            MessageBox.Show("Выберите рейс для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Обработчик нажатия на кнопку удаления выбранных рейсов
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private async void ButtonDeleteRoutes_Click(object sender, EventArgs e)
    {
        if (DataGridViewRoutes.SelectedRows.Count == 0)
        {
            MessageBox.Show("Выберите рейсы для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Создаем сервис для удаления рейса
        FlightService routeService = new(airportContext);

        string deletedRotuesIds = "";

        // Проходимся по каждой выбранной строке и удаляем соответствующий рейс
        foreach (DataGridViewRow selectedRow in DataGridViewRoutes.SelectedRows)
        {
            int routeId = (int)selectedRow.Cells[0].Value;

            try
            {
                await routeService.DeleteFlightAsync(routeId);

                // Если удаление прошло успешно, добавляем ID удаленного рейса в строку deletedDriversIds
                if (deletedRotuesIds == "")
                    deletedRotuesIds = routeId.ToString();
                else
                    deletedRotuesIds += ", " + routeId.ToString();
            }
            catch (Exception ex)
            {
                // Если произошла ошибка при удалении рейса, выводим сообщение с ошибкой
                string errorMessage = $"Не удалось удалить рейс с ID {routeId}: {ex.Message}";
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Создаем сообщение об успешном выполнении операции и показываем его, используя список удаленных ID рейсов
        string successMessage = $"Удалены рейсы с ID: {deletedRotuesIds}";
        MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Обработчик нажатия на кнопку фильтрации рейсов
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonFilterRoutes_Click(object sender, EventArgs e)
    {
        FilterFlightForm filterRouteForm = new(DataGridViewRoutes);
        filterRouteForm.ShowDialog();

        /*UpdateRouteSearchTypes();*/
    }

    /// <summary>
    /// Обработчик нажатия на кнопку выхода из приложения
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonExit_Click(object sender, EventArgs e) => Application.Exit();

    private void TextBoxDriversSearchValue_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar != (char)Keys.Enter)
            return;

        string searchText = TextBoxDriversSearchValue.Text.ToLower();
        CurrencyManager currencyManager = (CurrencyManager)BindingContext[DataGridViewDrivers.DataSource];
        currencyManager.SuspendBinding();

        foreach (DataGridViewRow row in DataGridViewDrivers.Rows)
        {
            row.Visible = false;

            DataGridViewCell searchCell = row.Cells[ComboBoxDriversSearchTypes.SelectedIndex];
            if (searchCell != null && searchCell.Value.ToString().ToLower().Contains(searchText))
                row.Visible = true;
        }

        currencyManager.ResumeBinding();
        e.Handled = true;
    }

    private void TextBoxTransportsSearchValues_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar != (char)Keys.Enter)
            return;

        string searchText = TextBoxTransportsSearchValues.Text.ToLower();
        CurrencyManager currencyManager = (CurrencyManager)BindingContext[DataGridViewTransportes.DataSource];
        currencyManager.SuspendBinding();

        foreach (DataGridViewRow row in DataGridViewTransportes.Rows)
        {
            row.Visible = false;

            DataGridViewCell searchCell = row.Cells[ComboBoxTransportSearchTypes.SelectedIndex];
            if (searchCell != null && searchCell.Value.ToString().ToLower().Contains(searchText))
                row.Visible = true;
        }

        currencyManager.ResumeBinding();
        e.Handled = true;
    }

    private void TextBoxRoutesSearchValue_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar != (char)Keys.Enter)
            return;

        string searchText = TextBoxRoutesSearchValue.Text.ToLower();
        CurrencyManager currencyManager = (CurrencyManager)BindingContext[DataGridViewRoutes.DataSource];
        currencyManager.SuspendBinding();

        foreach (DataGridViewRow row in DataGridViewRoutes.Rows)
        {
            row.Visible = false;

            DataGridViewCell searchCell = row.Cells[ComboBoxRoutesSearchTypes.SelectedIndex];
            if (searchCell != null && searchCell.Value.ToString().ToLower().Contains(searchText))
                row.Visible = true;
        }

        currencyManager.ResumeBinding();
        e.Handled = true;
    }
}
