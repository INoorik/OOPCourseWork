using CourseWork.Contexts;

namespace CourseWork;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        labelDbPath = new Label();
        RouteBindingSource = new BindingSource(components);
        ButtonExit = new Button();
        tableLayoutPanelMain = new TableLayoutPanel();
        TabControl = new TabControl();
        TabPageDrivers = new TabPage();
        TableLayoutPanelDrivers = new TableLayoutPanel();
        DataGridViewDrivers = new DataGridView();
        idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        flyingExperienceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        planeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        planeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        flightIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        flightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        DriverBindingSource = new BindingSource(components);
        TableLayoutPanelDriversActions = new TableLayoutPanel();
        ButtonAddDriver = new Button();
        ButtonFilterDrivers = new Button();
        ButtonDeleteSelectedDrivers = new Button();
        ButtonUpdateDriver = new Button();
        GroupBoxDriverSearchParameters = new GroupBox();
        TableLayoutPanelDriversSearch = new TableLayoutPanel();
        TextBoxDriversSearchValue = new TextBox();
        ComboBoxDriversSearchTypes = new ComboBox();
        TabPageTransports = new TabPage();
        TableLayoutPanelTransportes = new TableLayoutPanel();
        DataGridViewTransportes = new DataGridView();
        idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        Model = new DataGridViewTextBoxColumn();
        Capacity = new DataGridViewTextBoxColumn();
        LastMaintenanceDate = new DataGridViewTextBoxColumn();
        FlightTime = new DataGridViewTextBoxColumn();
        FlightId = new DataGridViewTextBoxColumn();
        PilotId = new DataGridViewTextBoxColumn();
        LicensePlate = new DataGridViewTextBoxColumn();
        TransportBindingSource = new BindingSource(components);
        TableLayoutPanelTransportsActions = new TableLayoutPanel();
        ButtonAddTransport = new Button();
        ButtonFilterTransportes = new Button();
        ButtonUpdateTransport = new Button();
        ButtonDeleteSelectedTransportes = new Button();
        GroupBoxTransportSearchParameters = new GroupBox();
        TableLayoutPanelTransportsSearch = new TableLayoutPanel();
        TextBoxTransportsSearchValues = new TextBox();
        ComboBoxTransportSearchTypes = new ComboBox();
        TabPageRoutes = new TabPage();
        TableLayoutPanelRoutes = new TableLayoutPanel();
        DataGridViewRoutes = new DataGridView();
        idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        startLocationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        endLocationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        distanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        startTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        endTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        TableLayoutPanelRoutesActions = new TableLayoutPanel();
        ButtonAddRoute = new Button();
        ButtonFilterRoutes = new Button();
        ButtonUpdateRoute = new Button();
        ButtonDeleteRoutes = new Button();
        GroupBoxRouteSearchParameter = new GroupBox();
        TableLayoutPanelRoutesSearch = new TableLayoutPanel();
        TextBoxRoutesSearchValue = new TextBox();
        ComboBoxRoutesSearchTypes = new ComboBox();
        ((System.ComponentModel.ISupportInitialize)RouteBindingSource).BeginInit();
        tableLayoutPanelMain.SuspendLayout();
        TabControl.SuspendLayout();
        TabPageDrivers.SuspendLayout();
        TableLayoutPanelDrivers.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DataGridViewDrivers).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DriverBindingSource).BeginInit();
        TableLayoutPanelDriversActions.SuspendLayout();
        GroupBoxDriverSearchParameters.SuspendLayout();
        TableLayoutPanelDriversSearch.SuspendLayout();
        TabPageTransports.SuspendLayout();
        TableLayoutPanelTransportes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DataGridViewTransportes).BeginInit();
        ((System.ComponentModel.ISupportInitialize)TransportBindingSource).BeginInit();
        TableLayoutPanelTransportsActions.SuspendLayout();
        GroupBoxTransportSearchParameters.SuspendLayout();
        TableLayoutPanelTransportsSearch.SuspendLayout();
        TabPageRoutes.SuspendLayout();
        TableLayoutPanelRoutes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DataGridViewRoutes).BeginInit();
        TableLayoutPanelRoutesActions.SuspendLayout();
        GroupBoxRouteSearchParameter.SuspendLayout();
        TableLayoutPanelRoutesSearch.SuspendLayout();
        SuspendLayout();
        // 
        // labelDbPath
        // 
        labelDbPath.AutoSize = true;
        labelDbPath.Location = new Point(436, 290);
        labelDbPath.Name = "labelDbPath";
        labelDbPath.Size = new Size(0, 15);
        labelDbPath.TabIndex = 0;
        // 
        // RouteBindingSource
        // 
        RouteBindingSource.DataSource = typeof(Entities.Flight);
        // 
        // ButtonExit
        // 
        ButtonExit.Anchor = AnchorStyles.None;
        ButtonExit.BackColor = Color.FromArgb(174, 163, 176);
        ButtonExit.FlatStyle = FlatStyle.Flat;
        ButtonExit.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonExit.Location = new Point(419, 726);
        ButtonExit.Name = "ButtonExit";
        ButtonExit.Size = new Size(170, 25);
        ButtonExit.TabIndex = 5;
        ButtonExit.Text = "Выход";
        ButtonExit.UseVisualStyleBackColor = false;
        ButtonExit.Click += ButtonExit_Click;
        // 
        // tableLayoutPanelMain
        // 
        tableLayoutPanelMain.BackColor = Color.FromArgb(130, 112, 129);
        tableLayoutPanelMain.ColumnCount = 1;
        tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanelMain.Controls.Add(ButtonExit, 0, 1);
        tableLayoutPanelMain.Controls.Add(TabControl, 0, 0);
        tableLayoutPanelMain.Dock = DockStyle.Fill;
        tableLayoutPanelMain.Location = new Point(0, 0);
        tableLayoutPanelMain.Name = "tableLayoutPanelMain";
        tableLayoutPanelMain.RowCount = 2;
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanelMain.Size = new Size(1008, 778);
        tableLayoutPanelMain.TabIndex = 6;
        // 
        // TabControl
        // 
        TabControl.Controls.Add(TabPageDrivers);
        TabControl.Controls.Add(TabPageTransports);
        TabControl.Controls.Add(TabPageRoutes);
        TabControl.Dock = DockStyle.Fill;
        TabControl.Location = new Point(3, 3);
        TabControl.Name = "TabControl";
        TabControl.SelectedIndex = 0;
        TabControl.Size = new Size(1002, 694);
        TabControl.TabIndex = 5;
        // 
        // TabPageDrivers
        // 
        TabPageDrivers.BackColor = Color.FromArgb(231, 230, 247);
        TabPageDrivers.Controls.Add(TableLayoutPanelDrivers);
        TabPageDrivers.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        TabPageDrivers.Location = new Point(4, 24);
        TabPageDrivers.Name = "TabPageDrivers";
        TabPageDrivers.Padding = new Padding(3);
        TabPageDrivers.Size = new Size(994, 666);
        TabPageDrivers.TabIndex = 0;
        TabPageDrivers.Text = "Пилоты";
        // 
        // TableLayoutPanelDrivers
        // 
        TableLayoutPanelDrivers.ColumnCount = 1;
        TableLayoutPanelDrivers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TableLayoutPanelDrivers.Controls.Add(DataGridViewDrivers, 0, 0);
        TableLayoutPanelDrivers.Controls.Add(TableLayoutPanelDriversActions, 0, 1);
        TableLayoutPanelDrivers.Dock = DockStyle.Fill;
        TableLayoutPanelDrivers.Location = new Point(3, 3);
        TableLayoutPanelDrivers.Name = "TableLayoutPanelDrivers";
        TableLayoutPanelDrivers.RowCount = 2;
        TableLayoutPanelDrivers.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
        TableLayoutPanelDrivers.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        TableLayoutPanelDrivers.Size = new Size(988, 660);
        TableLayoutPanelDrivers.TabIndex = 3;
        // 
        // DataGridViewDrivers
        // 
        DataGridViewDrivers.AllowUserToAddRows = false;
        DataGridViewDrivers.AllowUserToDeleteRows = false;
        DataGridViewDrivers.AutoGenerateColumns = false;
        DataGridViewDrivers.BackgroundColor = Color.FromArgb(198, 210, 237);
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
        DataGridViewDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        DataGridViewDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewDrivers.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, flyingExperienceDataGridViewTextBoxColumn, planeIdDataGridViewTextBoxColumn, planeDataGridViewTextBoxColumn, flightIDDataGridViewTextBoxColumn, flightDataGridViewTextBoxColumn });
        DataGridViewDrivers.DataSource = DriverBindingSource;
        DataGridViewDrivers.Dock = DockStyle.Fill;
        DataGridViewDrivers.Location = new Point(3, 3);
        DataGridViewDrivers.Name = "DataGridViewDrivers";
        DataGridViewDrivers.ReadOnly = true;
        DataGridViewDrivers.RowHeadersVisible = false;
        DataGridViewDrivers.RowTemplate.Height = 25;
        DataGridViewDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DataGridViewDrivers.Size = new Size(982, 555);
        DataGridViewDrivers.TabIndex = 1;
        // 
        // idDataGridViewTextBoxColumn1
        // 
        idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
        idDataGridViewTextBoxColumn1.HeaderText = "ID";
        idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
        idDataGridViewTextBoxColumn1.ReadOnly = true;
        // 
        // firstNameDataGridViewTextBoxColumn
        // 
        firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
        firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
        firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
        firstNameDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // lastNameDataGridViewTextBoxColumn
        // 
        lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
        lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
        lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
        lastNameDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // ageDataGridViewTextBoxColumn
        // 
        ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
        ageDataGridViewTextBoxColumn.HeaderText = "Возраст";
        ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
        ageDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // flyingExperienceDataGridViewTextBoxColumn
        // 
        flyingExperienceDataGridViewTextBoxColumn.DataPropertyName = "FlyingExperience";
        flyingExperienceDataGridViewTextBoxColumn.HeaderText = "Стаж";
        flyingExperienceDataGridViewTextBoxColumn.Name = "flyingExperienceDataGridViewTextBoxColumn";
        flyingExperienceDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // planeIdDataGridViewTextBoxColumn
        // 
        planeIdDataGridViewTextBoxColumn.DataPropertyName = "PlaneId";
        planeIdDataGridViewTextBoxColumn.HeaderText = "ID самолета";
        planeIdDataGridViewTextBoxColumn.Name = "planeIdDataGridViewTextBoxColumn";
        planeIdDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // planeDataGridViewTextBoxColumn
        // 
        planeDataGridViewTextBoxColumn.DataPropertyName = "Plane";
        planeDataGridViewTextBoxColumn.HeaderText = "Самолет";
        planeDataGridViewTextBoxColumn.Name = "planeDataGridViewTextBoxColumn";
        planeDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // flightIDDataGridViewTextBoxColumn
        // 
        flightIDDataGridViewTextBoxColumn.DataPropertyName = "FlightID";
        flightIDDataGridViewTextBoxColumn.HeaderText = "ID Рейса";
        flightIDDataGridViewTextBoxColumn.Name = "flightIDDataGridViewTextBoxColumn";
        flightIDDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // flightDataGridViewTextBoxColumn
        // 
        flightDataGridViewTextBoxColumn.DataPropertyName = "Flight";
        flightDataGridViewTextBoxColumn.HeaderText = "Рейс";
        flightDataGridViewTextBoxColumn.Name = "flightDataGridViewTextBoxColumn";
        flightDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // DriverBindingSource
        // 
        DriverBindingSource.DataSource = typeof(Entities.Pilot);
        // 
        // TableLayoutPanelDriversActions
        // 
        TableLayoutPanelDriversActions.ColumnCount = 5;
        TableLayoutPanelDriversActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelDriversActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelDriversActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelDriversActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelDriversActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelDriversActions.Controls.Add(ButtonAddDriver, 0, 0);
        TableLayoutPanelDriversActions.Controls.Add(ButtonFilterDrivers, 3, 0);
        TableLayoutPanelDriversActions.Controls.Add(ButtonDeleteSelectedDrivers, 2, 0);
        TableLayoutPanelDriversActions.Controls.Add(ButtonUpdateDriver, 1, 0);
        TableLayoutPanelDriversActions.Controls.Add(GroupBoxDriverSearchParameters, 4, 0);
        TableLayoutPanelDriversActions.Dock = DockStyle.Fill;
        TableLayoutPanelDriversActions.Location = new Point(3, 564);
        TableLayoutPanelDriversActions.Name = "TableLayoutPanelDriversActions";
        TableLayoutPanelDriversActions.RowCount = 1;
        TableLayoutPanelDriversActions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        TableLayoutPanelDriversActions.Size = new Size(982, 93);
        TableLayoutPanelDriversActions.TabIndex = 2;
        // 
        // ButtonAddDriver
        // 
        ButtonAddDriver.Anchor = AnchorStyles.None;
        ButtonAddDriver.BackColor = Color.FromArgb(174, 163, 176);
        ButtonAddDriver.FlatStyle = FlatStyle.Flat;
        ButtonAddDriver.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonAddDriver.Location = new Point(13, 34);
        ButtonAddDriver.Name = "ButtonAddDriver";
        ButtonAddDriver.Size = new Size(170, 25);
        ButtonAddDriver.TabIndex = 2;
        ButtonAddDriver.Text = "Добавить пилота";
        ButtonAddDriver.UseVisualStyleBackColor = false;
        ButtonAddDriver.Click += ButtonAddDriver_Click;
        // 
        // ButtonFilterDrivers
        // 
        ButtonFilterDrivers.Anchor = AnchorStyles.None;
        ButtonFilterDrivers.BackColor = Color.FromArgb(174, 163, 176);
        ButtonFilterDrivers.FlatStyle = FlatStyle.Flat;
        ButtonFilterDrivers.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonFilterDrivers.Location = new Point(601, 34);
        ButtonFilterDrivers.Name = "ButtonFilterDrivers";
        ButtonFilterDrivers.Size = new Size(170, 25);
        ButtonFilterDrivers.TabIndex = 4;
        ButtonFilterDrivers.Text = "Настроить фильтр";
        ButtonFilterDrivers.UseVisualStyleBackColor = false;
        ButtonFilterDrivers.Click += ButtonFilterDrivers_Click;
        // 
        // ButtonDeleteSelectedDrivers
        // 
        ButtonDeleteSelectedDrivers.Anchor = AnchorStyles.None;
        ButtonDeleteSelectedDrivers.BackColor = Color.FromArgb(174, 163, 176);
        ButtonDeleteSelectedDrivers.FlatStyle = FlatStyle.Flat;
        ButtonDeleteSelectedDrivers.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonDeleteSelectedDrivers.Location = new Point(405, 34);
        ButtonDeleteSelectedDrivers.Name = "ButtonDeleteSelectedDrivers";
        ButtonDeleteSelectedDrivers.Size = new Size(170, 25);
        ButtonDeleteSelectedDrivers.TabIndex = 3;
        ButtonDeleteSelectedDrivers.Text = "Удалить пилотов";
        ButtonDeleteSelectedDrivers.UseVisualStyleBackColor = false;
        ButtonDeleteSelectedDrivers.Click += ButtonDeleteSelectedDrivers_Click;
        // 
        // ButtonUpdateDriver
        // 
        ButtonUpdateDriver.Anchor = AnchorStyles.None;
        ButtonUpdateDriver.BackColor = Color.FromArgb(174, 163, 176);
        ButtonUpdateDriver.FlatStyle = FlatStyle.Flat;
        ButtonUpdateDriver.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonUpdateDriver.Location = new Point(209, 34);
        ButtonUpdateDriver.Name = "ButtonUpdateDriver";
        ButtonUpdateDriver.Size = new Size(170, 25);
        ButtonUpdateDriver.TabIndex = 5;
        ButtonUpdateDriver.Text = "Изменить пилота";
        ButtonUpdateDriver.UseVisualStyleBackColor = false;
        ButtonUpdateDriver.Click += ButtonUpdateDriver_Click;
        // 
        // GroupBoxDriverSearchParameters
        // 
        GroupBoxDriverSearchParameters.Controls.Add(TableLayoutPanelDriversSearch);
        GroupBoxDriverSearchParameters.Location = new Point(787, 3);
        GroupBoxDriverSearchParameters.Name = "GroupBoxDriverSearchParameters";
        GroupBoxDriverSearchParameters.Size = new Size(192, 87);
        GroupBoxDriverSearchParameters.TabIndex = 7;
        GroupBoxDriverSearchParameters.TabStop = false;
        GroupBoxDriverSearchParameters.Text = "Поиск";
        // 
        // TableLayoutPanelDriversSearch
        // 
        TableLayoutPanelDriversSearch.ColumnCount = 1;
        TableLayoutPanelDriversSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TableLayoutPanelDriversSearch.Controls.Add(TextBoxDriversSearchValue, 0, 1);
        TableLayoutPanelDriversSearch.Controls.Add(ComboBoxDriversSearchTypes, 0, 0);
        TableLayoutPanelDriversSearch.Dock = DockStyle.Fill;
        TableLayoutPanelDriversSearch.Location = new Point(3, 18);
        TableLayoutPanelDriversSearch.Name = "TableLayoutPanelDriversSearch";
        TableLayoutPanelDriversSearch.RowCount = 2;
        TableLayoutPanelDriversSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TableLayoutPanelDriversSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TableLayoutPanelDriversSearch.Size = new Size(186, 66);
        TableLayoutPanelDriversSearch.TabIndex = 6;
        // 
        // TextBoxDriversSearchValue
        // 
        TextBoxDriversSearchValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        TextBoxDriversSearchValue.BackColor = Color.FromArgb(198, 210, 237);
        TextBoxDriversSearchValue.ForeColor = SystemColors.WindowText;
        TextBoxDriversSearchValue.Location = new Point(3, 38);
        TextBoxDriversSearchValue.Name = "TextBoxDriversSearchValue";
        TextBoxDriversSearchValue.PlaceholderText = "Значение поиска";
        TextBoxDriversSearchValue.Size = new Size(180, 22);
        TextBoxDriversSearchValue.TabIndex = 1;
        TextBoxDriversSearchValue.KeyPress += TextBoxDriversSearchValue_KeyPress;
        // 
        // ComboBoxDriversSearchTypes
        // 
        ComboBoxDriversSearchTypes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        ComboBoxDriversSearchTypes.BackColor = Color.FromArgb(198, 210, 237);
        ComboBoxDriversSearchTypes.FormattingEnabled = true;
        ComboBoxDriversSearchTypes.Location = new Point(3, 5);
        ComboBoxDriversSearchTypes.Name = "ComboBoxDriversSearchTypes";
        ComboBoxDriversSearchTypes.Size = new Size(180, 24);
        ComboBoxDriversSearchTypes.TabIndex = 0;
        // 
        // TabPageTransports
        // 
        TabPageTransports.BackColor = Color.FromArgb(231, 230, 247);
        TabPageTransports.Controls.Add(TableLayoutPanelTransportes);
        TabPageTransports.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        TabPageTransports.Location = new Point(4, 24);
        TabPageTransports.Name = "TabPageTransports";
        TabPageTransports.Padding = new Padding(3);
        TabPageTransports.Size = new Size(994, 666);
        TabPageTransports.TabIndex = 1;
        TabPageTransports.Text = "Самолет";
        // 
        // TableLayoutPanelTransportes
        // 
        TableLayoutPanelTransportes.ColumnCount = 1;
        TableLayoutPanelTransportes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TableLayoutPanelTransportes.Controls.Add(DataGridViewTransportes, 0, 0);
        TableLayoutPanelTransportes.Controls.Add(TableLayoutPanelTransportsActions, 0, 1);
        TableLayoutPanelTransportes.Dock = DockStyle.Fill;
        TableLayoutPanelTransportes.Location = new Point(3, 3);
        TableLayoutPanelTransportes.Name = "TableLayoutPanelTransportes";
        TableLayoutPanelTransportes.RowCount = 2;
        TableLayoutPanelTransportes.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
        TableLayoutPanelTransportes.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        TableLayoutPanelTransportes.Size = new Size(988, 660);
        TableLayoutPanelTransportes.TabIndex = 5;
        // 
        // DataGridViewTransportes
        // 
        DataGridViewTransportes.AllowUserToAddRows = false;
        DataGridViewTransportes.AllowUserToDeleteRows = false;
        DataGridViewTransportes.AutoGenerateColumns = false;
        DataGridViewTransportes.BackgroundColor = Color.FromArgb(198, 210, 237);
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = SystemColors.Control;
        dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        DataGridViewTransportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        DataGridViewTransportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewTransportes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, Model, Capacity, LastMaintenanceDate, FlightTime, FlightId, PilotId, LicensePlate });
        DataGridViewTransportes.DataSource = TransportBindingSource;
        DataGridViewTransportes.Dock = DockStyle.Fill;
        DataGridViewTransportes.Location = new Point(3, 3);
        DataGridViewTransportes.Name = "DataGridViewTransportes";
        DataGridViewTransportes.ReadOnly = true;
        DataGridViewTransportes.RowHeadersVisible = false;
        DataGridViewTransportes.RowTemplate.Height = 25;
        DataGridViewTransportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DataGridViewTransportes.Size = new Size(982, 555);
        DataGridViewTransportes.TabIndex = 3;
        // 
        // idDataGridViewTextBoxColumn2
        // 
        idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
        idDataGridViewTextBoxColumn2.HeaderText = "ID";
        idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
        idDataGridViewTextBoxColumn2.ReadOnly = true;
        // 
        // Model
        // 
        Model.DataPropertyName = "Model";
        Model.HeaderText = "Модель";
        Model.Name = "Model";
        Model.ReadOnly = true;
        // 
        // Capacity
        // 
        Capacity.DataPropertyName = "Capacity";
        Capacity.HeaderText = "Вместимость";
        Capacity.Name = "Capacity";
        Capacity.ReadOnly = true;
        // 
        // LastMaintenanceDate
        // 
        LastMaintenanceDate.DataPropertyName = "LastMaintenanceDate";
        LastMaintenanceDate.HeaderText = "Дата последнего тех. обслуживания";
        LastMaintenanceDate.Name = "LastMaintenanceDate";
        LastMaintenanceDate.ReadOnly = true;
        // 
        // FlightTime
        // 
        FlightTime.DataPropertyName = "FlightTime";
        FlightTime.HeaderText = "Летное время";
        FlightTime.Name = "FlightTime";
        FlightTime.ReadOnly = true;
        // 
        // FlightId
        // 
        FlightId.DataPropertyName = "FlightId";
        FlightId.HeaderText = "Id полета";
        FlightId.Name = "FlightId";
        FlightId.ReadOnly = true;
        // 
        // PilotId
        // 
        PilotId.DataPropertyName = "PilotId";
        PilotId.HeaderText = "Id пилота";
        PilotId.Name = "PilotId";
        PilotId.ReadOnly = true;
        // 
        // LicensePlate
        // 
        LicensePlate.DataPropertyName = "LicensePlate";
        LicensePlate.HeaderText = "Номер";
        LicensePlate.Name = "LicensePlate";
        LicensePlate.ReadOnly = true;
        // 
        // TransportBindingSource
        // 
        TransportBindingSource.DataSource = typeof(Entities.Plane);
        // 
        // TableLayoutPanelTransportsActions
        // 
        TableLayoutPanelTransportsActions.ColumnCount = 5;
        TableLayoutPanelTransportsActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelTransportsActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelTransportsActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelTransportsActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelTransportsActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelTransportsActions.Controls.Add(ButtonAddTransport, 0, 0);
        TableLayoutPanelTransportsActions.Controls.Add(ButtonFilterTransportes, 3, 0);
        TableLayoutPanelTransportsActions.Controls.Add(ButtonUpdateTransport, 1, 0);
        TableLayoutPanelTransportsActions.Controls.Add(ButtonDeleteSelectedTransportes, 2, 0);
        TableLayoutPanelTransportsActions.Controls.Add(GroupBoxTransportSearchParameters, 4, 0);
        TableLayoutPanelTransportsActions.Dock = DockStyle.Fill;
        TableLayoutPanelTransportsActions.Location = new Point(3, 564);
        TableLayoutPanelTransportsActions.Name = "TableLayoutPanelTransportsActions";
        TableLayoutPanelTransportsActions.RowCount = 1;
        TableLayoutPanelTransportsActions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        TableLayoutPanelTransportsActions.Size = new Size(982, 93);
        TableLayoutPanelTransportsActions.TabIndex = 4;
        // 
        // ButtonAddTransport
        // 
        ButtonAddTransport.Anchor = AnchorStyles.None;
        ButtonAddTransport.BackColor = Color.FromArgb(174, 163, 176);
        ButtonAddTransport.FlatStyle = FlatStyle.Flat;
        ButtonAddTransport.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonAddTransport.Location = new Point(13, 34);
        ButtonAddTransport.Name = "ButtonAddTransport";
        ButtonAddTransport.Size = new Size(170, 25);
        ButtonAddTransport.TabIndex = 4;
        ButtonAddTransport.Text = "Добавить Самолет";
        ButtonAddTransport.UseVisualStyleBackColor = false;
        ButtonAddTransport.Click += ButtonAddTransport_Click;
        // 
        // ButtonFilterTransportes
        // 
        ButtonFilterTransportes.Anchor = AnchorStyles.None;
        ButtonFilterTransportes.BackColor = Color.FromArgb(174, 163, 176);
        ButtonFilterTransportes.FlatStyle = FlatStyle.Flat;
        ButtonFilterTransportes.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonFilterTransportes.Location = new Point(601, 34);
        ButtonFilterTransportes.Name = "ButtonFilterTransportes";
        ButtonFilterTransportes.Size = new Size(170, 25);
        ButtonFilterTransportes.TabIndex = 7;
        ButtonFilterTransportes.Text = "Настроить фильтр";
        ButtonFilterTransportes.UseVisualStyleBackColor = false;
        ButtonFilterTransportes.Click += ButtonFilterTransportes_Click;
        // 
        // ButtonUpdateTransport
        // 
        ButtonUpdateTransport.Anchor = AnchorStyles.None;
        ButtonUpdateTransport.BackColor = Color.FromArgb(174, 163, 176);
        ButtonUpdateTransport.FlatStyle = FlatStyle.Flat;
        ButtonUpdateTransport.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonUpdateTransport.Location = new Point(209, 34);
        ButtonUpdateTransport.Name = "ButtonUpdateTransport";
        ButtonUpdateTransport.Size = new Size(170, 25);
        ButtonUpdateTransport.TabIndex = 5;
        ButtonUpdateTransport.Text = "Изменить самолет";
        ButtonUpdateTransport.UseVisualStyleBackColor = false;
        ButtonUpdateTransport.Click += ButtonUpdateTransport_Click;
        // 
        // ButtonDeleteSelectedTransportes
        // 
        ButtonDeleteSelectedTransportes.Anchor = AnchorStyles.None;
        ButtonDeleteSelectedTransportes.BackColor = Color.FromArgb(174, 163, 176);
        ButtonDeleteSelectedTransportes.FlatStyle = FlatStyle.Flat;
        ButtonDeleteSelectedTransportes.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonDeleteSelectedTransportes.Location = new Point(405, 34);
        ButtonDeleteSelectedTransportes.Name = "ButtonDeleteSelectedTransportes";
        ButtonDeleteSelectedTransportes.Size = new Size(170, 25);
        ButtonDeleteSelectedTransportes.TabIndex = 6;
        ButtonDeleteSelectedTransportes.Text = "Удалить самолет/ы";
        ButtonDeleteSelectedTransportes.UseVisualStyleBackColor = false;
        ButtonDeleteSelectedTransportes.Click += ButtonDeleteSelectedTransportes_Click;
        // 
        // GroupBoxTransportSearchParameters
        // 
        GroupBoxTransportSearchParameters.Controls.Add(TableLayoutPanelTransportsSearch);
        GroupBoxTransportSearchParameters.Location = new Point(787, 3);
        GroupBoxTransportSearchParameters.Name = "GroupBoxTransportSearchParameters";
        GroupBoxTransportSearchParameters.Size = new Size(192, 87);
        GroupBoxTransportSearchParameters.TabIndex = 9;
        GroupBoxTransportSearchParameters.TabStop = false;
        GroupBoxTransportSearchParameters.Text = "Поиск";
        // 
        // TableLayoutPanelTransportsSearch
        // 
        TableLayoutPanelTransportsSearch.ColumnCount = 1;
        TableLayoutPanelTransportsSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TableLayoutPanelTransportsSearch.Controls.Add(TextBoxTransportsSearchValues, 0, 1);
        TableLayoutPanelTransportsSearch.Controls.Add(ComboBoxTransportSearchTypes, 0, 0);
        TableLayoutPanelTransportsSearch.Dock = DockStyle.Fill;
        TableLayoutPanelTransportsSearch.Location = new Point(3, 18);
        TableLayoutPanelTransportsSearch.Name = "TableLayoutPanelTransportsSearch";
        TableLayoutPanelTransportsSearch.RowCount = 2;
        TableLayoutPanelTransportsSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TableLayoutPanelTransportsSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TableLayoutPanelTransportsSearch.Size = new Size(186, 66);
        TableLayoutPanelTransportsSearch.TabIndex = 8;
        // 
        // TextBoxTransportsSearchValues
        // 
        TextBoxTransportsSearchValues.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        TextBoxTransportsSearchValues.BackColor = Color.FromArgb(198, 210, 237);
        TextBoxTransportsSearchValues.Location = new Point(3, 38);
        TextBoxTransportsSearchValues.Name = "TextBoxTransportsSearchValues";
        TextBoxTransportsSearchValues.PlaceholderText = "Значение поиска";
        TextBoxTransportsSearchValues.Size = new Size(180, 22);
        TextBoxTransportsSearchValues.TabIndex = 1;
        TextBoxTransportsSearchValues.KeyPress += TextBoxTransportsSearchValues_KeyPress;
        // 
        // ComboBoxTransportSearchTypes
        // 
        ComboBoxTransportSearchTypes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        ComboBoxTransportSearchTypes.BackColor = Color.FromArgb(198, 210, 237);
        ComboBoxTransportSearchTypes.FormattingEnabled = true;
        ComboBoxTransportSearchTypes.Location = new Point(3, 5);
        ComboBoxTransportSearchTypes.Name = "ComboBoxTransportSearchTypes";
        ComboBoxTransportSearchTypes.Size = new Size(180, 24);
        ComboBoxTransportSearchTypes.TabIndex = 0;
        // 
        // TabPageRoutes
        // 
        TabPageRoutes.BackColor = Color.FromArgb(231, 230, 247);
        TabPageRoutes.Controls.Add(TableLayoutPanelRoutes);
        TabPageRoutes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        TabPageRoutes.Location = new Point(4, 24);
        TabPageRoutes.Name = "TabPageRoutes";
        TabPageRoutes.Padding = new Padding(3);
        TabPageRoutes.Size = new Size(994, 666);
        TabPageRoutes.TabIndex = 2;
        TabPageRoutes.Text = "Рейсы";
        // 
        // TableLayoutPanelRoutes
        // 
        TableLayoutPanelRoutes.ColumnCount = 1;
        TableLayoutPanelRoutes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TableLayoutPanelRoutes.Controls.Add(DataGridViewRoutes, 0, 0);
        TableLayoutPanelRoutes.Controls.Add(TableLayoutPanelRoutesActions, 0, 1);
        TableLayoutPanelRoutes.Dock = DockStyle.Fill;
        TableLayoutPanelRoutes.Location = new Point(3, 3);
        TableLayoutPanelRoutes.Name = "TableLayoutPanelRoutes";
        TableLayoutPanelRoutes.RowCount = 2;
        TableLayoutPanelRoutes.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
        TableLayoutPanelRoutes.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        TableLayoutPanelRoutes.Size = new Size(988, 660);
        TableLayoutPanelRoutes.TabIndex = 7;
        // 
        // DataGridViewRoutes
        // 
        DataGridViewRoutes.AllowUserToAddRows = false;
        DataGridViewRoutes.AllowUserToDeleteRows = false;
        DataGridViewRoutes.AllowUserToOrderColumns = true;
        DataGridViewRoutes.AutoGenerateColumns = false;
        DataGridViewRoutes.BackgroundColor = Color.FromArgb(198, 210, 237);
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle3.BackColor = SystemColors.Control;
        dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        DataGridViewRoutes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
        DataGridViewRoutes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewRoutes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, startLocationDataGridViewTextBoxColumn, endLocationDataGridViewTextBoxColumn, distanceDataGridViewTextBoxColumn, startTimeDataGridViewTextBoxColumn, endTimeDataGridViewTextBoxColumn });
        DataGridViewRoutes.DataSource = RouteBindingSource;
        DataGridViewRoutes.Dock = DockStyle.Fill;
        DataGridViewRoutes.Location = new Point(3, 3);
        DataGridViewRoutes.Name = "DataGridViewRoutes";
        DataGridViewRoutes.ReadOnly = true;
        DataGridViewRoutes.RowHeadersVisible = false;
        DataGridViewRoutes.RowTemplate.Height = 25;
        DataGridViewRoutes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DataGridViewRoutes.Size = new Size(982, 555);
        DataGridViewRoutes.TabIndex = 4;
        // 
        // idDataGridViewTextBoxColumn
        // 
        idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        idDataGridViewTextBoxColumn.DataPropertyName = "Id";
        idDataGridViewTextBoxColumn.HeaderText = "ID";
        idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
        idDataGridViewTextBoxColumn.ReadOnly = true;
        idDataGridViewTextBoxColumn.Width = 45;
        // 
        // nameDataGridViewTextBoxColumn
        // 
        nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
        nameDataGridViewTextBoxColumn.HeaderText = "Название";
        nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
        nameDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // startLocationDataGridViewTextBoxColumn
        // 
        startLocationDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        startLocationDataGridViewTextBoxColumn.DataPropertyName = "StartLocation";
        startLocationDataGridViewTextBoxColumn.HeaderText = "Стартовая точка";
        startLocationDataGridViewTextBoxColumn.Name = "startLocationDataGridViewTextBoxColumn";
        startLocationDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // endLocationDataGridViewTextBoxColumn
        // 
        endLocationDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        endLocationDataGridViewTextBoxColumn.DataPropertyName = "EndLocation";
        endLocationDataGridViewTextBoxColumn.HeaderText = "Конечная точка";
        endLocationDataGridViewTextBoxColumn.Name = "endLocationDataGridViewTextBoxColumn";
        endLocationDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // distanceDataGridViewTextBoxColumn
        // 
        distanceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
        distanceDataGridViewTextBoxColumn.HeaderText = "Расстояние";
        distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
        distanceDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // startTimeDataGridViewTextBoxColumn
        // 
        startTimeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
        startTimeDataGridViewTextBoxColumn.HeaderText = "Начало движения";
        startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
        startTimeDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // endTimeDataGridViewTextBoxColumn
        // 
        endTimeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
        endTimeDataGridViewTextBoxColumn.HeaderText = "Конец движения";
        endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
        endTimeDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // TableLayoutPanelRoutesActions
        // 
        TableLayoutPanelRoutesActions.ColumnCount = 5;
        TableLayoutPanelRoutesActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelRoutesActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelRoutesActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelRoutesActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelRoutesActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        TableLayoutPanelRoutesActions.Controls.Add(ButtonAddRoute, 0, 0);
        TableLayoutPanelRoutesActions.Controls.Add(ButtonFilterRoutes, 3, 0);
        TableLayoutPanelRoutesActions.Controls.Add(ButtonUpdateRoute, 1, 0);
        TableLayoutPanelRoutesActions.Controls.Add(ButtonDeleteRoutes, 2, 0);
        TableLayoutPanelRoutesActions.Controls.Add(GroupBoxRouteSearchParameter, 4, 0);
        TableLayoutPanelRoutesActions.Dock = DockStyle.Fill;
        TableLayoutPanelRoutesActions.Location = new Point(3, 564);
        TableLayoutPanelRoutesActions.Name = "TableLayoutPanelRoutesActions";
        TableLayoutPanelRoutesActions.RowCount = 1;
        TableLayoutPanelRoutesActions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        TableLayoutPanelRoutesActions.Size = new Size(982, 93);
        TableLayoutPanelRoutesActions.TabIndex = 5;
        // 
        // ButtonAddRoute
        // 
        ButtonAddRoute.Anchor = AnchorStyles.None;
        ButtonAddRoute.BackColor = Color.FromArgb(174, 163, 176);
        ButtonAddRoute.FlatStyle = FlatStyle.Flat;
        ButtonAddRoute.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonAddRoute.Location = new Point(13, 34);
        ButtonAddRoute.Name = "ButtonAddRoute";
        ButtonAddRoute.Size = new Size(170, 25);
        ButtonAddRoute.TabIndex = 6;
        ButtonAddRoute.Text = "Добавить рейс";
        ButtonAddRoute.UseVisualStyleBackColor = false;
        ButtonAddRoute.Click += ButtonAddRoute_Click;
        // 
        // ButtonFilterRoutes
        // 
        ButtonFilterRoutes.Anchor = AnchorStyles.None;
        ButtonFilterRoutes.BackColor = Color.FromArgb(174, 163, 176);
        ButtonFilterRoutes.FlatStyle = FlatStyle.Flat;
        ButtonFilterRoutes.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonFilterRoutes.Location = new Point(601, 34);
        ButtonFilterRoutes.Name = "ButtonFilterRoutes";
        ButtonFilterRoutes.Size = new Size(170, 25);
        ButtonFilterRoutes.TabIndex = 9;
        ButtonFilterRoutes.Text = "Настроить фильтр";
        ButtonFilterRoutes.UseVisualStyleBackColor = false;
        ButtonFilterRoutes.Click += ButtonFilterRoutes_Click;
        // 
        // ButtonUpdateRoute
        // 
        ButtonUpdateRoute.Anchor = AnchorStyles.None;
        ButtonUpdateRoute.BackColor = Color.FromArgb(174, 163, 176);
        ButtonUpdateRoute.FlatStyle = FlatStyle.Flat;
        ButtonUpdateRoute.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonUpdateRoute.Location = new Point(209, 34);
        ButtonUpdateRoute.Name = "ButtonUpdateRoute";
        ButtonUpdateRoute.Size = new Size(170, 25);
        ButtonUpdateRoute.TabIndex = 7;
        ButtonUpdateRoute.Text = "Изменить рейс";
        ButtonUpdateRoute.UseVisualStyleBackColor = false;
        ButtonUpdateRoute.Click += ButtonUpdateRoute_Click;
        // 
        // ButtonDeleteRoutes
        // 
        ButtonDeleteRoutes.Anchor = AnchorStyles.None;
        ButtonDeleteRoutes.BackColor = Color.FromArgb(174, 163, 176);
        ButtonDeleteRoutes.FlatStyle = FlatStyle.Flat;
        ButtonDeleteRoutes.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonDeleteRoutes.Location = new Point(405, 34);
        ButtonDeleteRoutes.Name = "ButtonDeleteRoutes";
        ButtonDeleteRoutes.Size = new Size(170, 25);
        ButtonDeleteRoutes.TabIndex = 8;
        ButtonDeleteRoutes.Text = "Удалить рейс";
        ButtonDeleteRoutes.UseVisualStyleBackColor = false;
        ButtonDeleteRoutes.Click += ButtonDeleteRoutes_Click;
        // 
        // GroupBoxRouteSearchParameter
        // 
        GroupBoxRouteSearchParameter.Controls.Add(TableLayoutPanelRoutesSearch);
        GroupBoxRouteSearchParameter.Location = new Point(787, 3);
        GroupBoxRouteSearchParameter.Name = "GroupBoxRouteSearchParameter";
        GroupBoxRouteSearchParameter.Size = new Size(192, 87);
        GroupBoxRouteSearchParameter.TabIndex = 11;
        GroupBoxRouteSearchParameter.TabStop = false;
        GroupBoxRouteSearchParameter.Text = "Поиск";
        // 
        // TableLayoutPanelRoutesSearch
        // 
        TableLayoutPanelRoutesSearch.ColumnCount = 1;
        TableLayoutPanelRoutesSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TableLayoutPanelRoutesSearch.Controls.Add(TextBoxRoutesSearchValue, 0, 1);
        TableLayoutPanelRoutesSearch.Controls.Add(ComboBoxRoutesSearchTypes, 0, 0);
        TableLayoutPanelRoutesSearch.Dock = DockStyle.Fill;
        TableLayoutPanelRoutesSearch.Location = new Point(3, 18);
        TableLayoutPanelRoutesSearch.Name = "TableLayoutPanelRoutesSearch";
        TableLayoutPanelRoutesSearch.RowCount = 2;
        TableLayoutPanelRoutesSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TableLayoutPanelRoutesSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TableLayoutPanelRoutesSearch.Size = new Size(186, 66);
        TableLayoutPanelRoutesSearch.TabIndex = 10;
        // 
        // TextBoxRoutesSearchValue
        // 
        TextBoxRoutesSearchValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        TextBoxRoutesSearchValue.BackColor = Color.FromArgb(198, 210, 237);
        TextBoxRoutesSearchValue.Location = new Point(3, 38);
        TextBoxRoutesSearchValue.Name = "TextBoxRoutesSearchValue";
        TextBoxRoutesSearchValue.PlaceholderText = "Значение поиска";
        TextBoxRoutesSearchValue.Size = new Size(180, 22);
        TextBoxRoutesSearchValue.TabIndex = 0;
        TextBoxRoutesSearchValue.KeyPress += TextBoxRoutesSearchValue_KeyPress;
        // 
        // ComboBoxRoutesSearchTypes
        // 
        ComboBoxRoutesSearchTypes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        ComboBoxRoutesSearchTypes.BackColor = Color.FromArgb(198, 210, 237);
        ComboBoxRoutesSearchTypes.FormattingEnabled = true;
        ComboBoxRoutesSearchTypes.Location = new Point(3, 5);
        ComboBoxRoutesSearchTypes.Name = "ComboBoxRoutesSearchTypes";
        ComboBoxRoutesSearchTypes.Size = new Size(180, 24);
        ComboBoxRoutesSearchTypes.TabIndex = 1;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1008, 778);
        Controls.Add(tableLayoutPanelMain);
        Controls.Add(labelDbPath);
        Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(640, 510);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Главный экран";
        ((System.ComponentModel.ISupportInitialize)RouteBindingSource).EndInit();
        tableLayoutPanelMain.ResumeLayout(false);
        TabControl.ResumeLayout(false);
        TabPageDrivers.ResumeLayout(false);
        TableLayoutPanelDrivers.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)DataGridViewDrivers).EndInit();
        ((System.ComponentModel.ISupportInitialize)DriverBindingSource).EndInit();
        TableLayoutPanelDriversActions.ResumeLayout(false);
        GroupBoxDriverSearchParameters.ResumeLayout(false);
        TableLayoutPanelDriversSearch.ResumeLayout(false);
        TableLayoutPanelDriversSearch.PerformLayout();
        TabPageTransports.ResumeLayout(false);
        TableLayoutPanelTransportes.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)DataGridViewTransportes).EndInit();
        ((System.ComponentModel.ISupportInitialize)TransportBindingSource).EndInit();
        TableLayoutPanelTransportsActions.ResumeLayout(false);
        GroupBoxTransportSearchParameters.ResumeLayout(false);
        TableLayoutPanelTransportsSearch.ResumeLayout(false);
        TableLayoutPanelTransportsSearch.PerformLayout();
        TabPageRoutes.ResumeLayout(false);
        TableLayoutPanelRoutes.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)DataGridViewRoutes).EndInit();
        TableLayoutPanelRoutesActions.ResumeLayout(false);
        GroupBoxRouteSearchParameter.ResumeLayout(false);
        TableLayoutPanelRoutesSearch.ResumeLayout(false);
        TableLayoutPanelRoutesSearch.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelDbPath;
    private Button ButtonExit;
    private TableLayoutPanel tableLayoutPanelMain;
    private DataGridViewTextBoxColumn routesDataGridViewTextBoxColumn;
    private BindingSource RouteBindingSource;
    private TabControl TabControl;
    private TabPage TabPageDrivers;
    private TableLayoutPanel TableLayoutPanelDrivers;
    private DataGridView DataGridViewDrivers;
    private TableLayoutPanel TableLayoutPanelDriversActions;
    private Button ButtonAddDriver;
    private Button ButtonFilterDrivers;
    private Button ButtonDeleteSelectedDrivers;
    private Button ButtonUpdateDriver;
    private GroupBox GroupBoxDriverSearchParameters;
    private TableLayoutPanel TableLayoutPanelDriversSearch;
    private TextBox TextBoxDriversSearchValue;
    private ComboBox ComboBoxDriversSearchTypes;
    private TabPage TabPageTransports;
    private TableLayoutPanel TableLayoutPanelTransportes;
    private DataGridView DataGridViewTransportes;
    private TableLayoutPanel TableLayoutPanelTransportsActions;
    private Button ButtonAddTransport;
    private Button ButtonFilterTransportes;
    private Button ButtonUpdateTransport;
    private Button ButtonDeleteSelectedTransportes;
    private GroupBox GroupBoxTransportSearchParameters;
    private TableLayoutPanel TableLayoutPanelTransportsSearch;
    private TextBox TextBoxTransportsSearchValues;
    private ComboBox ComboBoxTransportSearchTypes;
    private TabPage TabPageRoutes;
    private TableLayoutPanel TableLayoutPanelRoutes;
    private DataGridView DataGridViewRoutes;
    private TableLayoutPanel TableLayoutPanelRoutesActions;
    private Button ButtonAddRoute;
    private Button ButtonFilterRoutes;
    private Button ButtonUpdateRoute;
    private Button ButtonDeleteRoutes;
    private GroupBox GroupBoxRouteSearchParameter;
    private TableLayoutPanel TableLayoutPanelRoutesSearch;
    private TextBox TextBoxRoutesSearchValue;
    private ComboBox ComboBoxRoutesSearchTypes;
    private BindingSource DriverBindingSource;
    private DataGridViewTextBoxColumn drivingExperienceDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn transportIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn transportDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn routeIdDataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn1;
    private BindingSource TransportBindingSource;
    private DataGridViewTextBoxColumn transportsDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn driversDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn startLocationDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn endLocationDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn mileageDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn routeIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn driverIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn driverDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn flyingExperienceDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn planeIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn planeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn flightIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn flightDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn Model;
    private DataGridViewTextBoxColumn Capacity;
    private DataGridViewTextBoxColumn LastMaintenanceDate;
    private DataGridViewTextBoxColumn FlightTime;
    private DataGridViewTextBoxColumn FlightId;
    private DataGridViewTextBoxColumn PilotId;
    private DataGridViewTextBoxColumn LicensePlate;
}