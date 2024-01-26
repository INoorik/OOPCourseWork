﻿namespace CourseWork.Forms.ForTransports
{
    partial class UpdatePlaneForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TableLayoutPanelDriverParametersValue = new TableLayoutPanel();
            NumericUpDownMileage = new NumericUpDown();
            TextBoxModel = new TextBox();
            NumericUpDownCapacity = new NumericUpDown();
            ComboBoxDriver = new ComboBox();
            DriverBindingSource = new BindingSource(components);
            DateTimePickerMaintenanceDate = new DateTimePicker();
            tableLayoutPanel2 = new TableLayoutPanel();
            NumericUpDownLicensePlateNumber = new NumericUpDown();
            ComboBoxFirstLetter = new ComboBox();
            ComboBoxSecondLetter = new ComboBox();
            ComboBoxThirdLetter = new ComboBox();
            ComboBoxRoute = new ComboBox();
            RouteBindingSource = new BindingSource(components);
            LabelModel = new Label();
            LabelLicensePlate = new Label();
            LabelCapacity = new Label();
            LabelDrivingExperience = new Label();
            LabelRoute = new Label();
            LabelDriver = new Label();
            LabelMileage = new Label();
            TableLayoutPanelDriverParameters = new TableLayoutPanel();
            GroupBoxParameters = new GroupBox();
            TableLayoutPanelMain = new TableLayoutPanel();
            GroupBoxParametersValues = new GroupBox();
            TableLayoutPanelDriverInfo = new TableLayoutPanel();
            GroupBoxActions = new GroupBox();
            TableLayoutPanelActions = new TableLayoutPanel();
            ButtonExit = new Button();
            ButtonUpdate = new Button();
            TableLayoutPanelDriverParametersValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownMileage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DriverBindingSource).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownLicensePlateNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RouteBindingSource).BeginInit();
            TableLayoutPanelDriverParameters.SuspendLayout();
            GroupBoxParameters.SuspendLayout();
            TableLayoutPanelMain.SuspendLayout();
            GroupBoxParametersValues.SuspendLayout();
            TableLayoutPanelDriverInfo.SuspendLayout();
            GroupBoxActions.SuspendLayout();
            TableLayoutPanelActions.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanelDriverParametersValue
            // 
            TableLayoutPanelDriverParametersValue.ColumnCount = 1;
            TableLayoutPanelDriverParametersValue.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelDriverParametersValue.Controls.Add(NumericUpDownMileage, 0, 4);
            TableLayoutPanelDriverParametersValue.Controls.Add(TextBoxModel, 0, 0);
            TableLayoutPanelDriverParametersValue.Controls.Add(NumericUpDownCapacity, 0, 2);
            TableLayoutPanelDriverParametersValue.Controls.Add(ComboBoxDriver, 0, 5);
            TableLayoutPanelDriverParametersValue.Controls.Add(DateTimePickerMaintenanceDate, 0, 3);
            TableLayoutPanelDriverParametersValue.Controls.Add(tableLayoutPanel2, 0, 1);
            TableLayoutPanelDriverParametersValue.Controls.Add(ComboBoxRoute, 0, 6);
            TableLayoutPanelDriverParametersValue.Dock = DockStyle.Fill;
            TableLayoutPanelDriverParametersValue.Location = new Point(2, 16);
            TableLayoutPanelDriverParametersValue.Margin = new Padding(2);
            TableLayoutPanelDriverParametersValue.Name = "TableLayoutPanelDriverParametersValue";
            TableLayoutPanelDriverParametersValue.RowCount = 7;
            TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            TableLayoutPanelDriverParametersValue.Size = new Size(382, 451);
            TableLayoutPanelDriverParametersValue.TabIndex = 0;
            // 
            // NumericUpDownMileage
            // 
            NumericUpDownMileage.Anchor = AnchorStyles.None;
            NumericUpDownMileage.BackColor = Color.FromArgb(198, 210, 237);
            NumericUpDownMileage.DecimalPlaces = 1;
            NumericUpDownMileage.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NumericUpDownMileage.Location = new Point(41, 277);
            NumericUpDownMileage.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NumericUpDownMileage.Name = "NumericUpDownMileage";
            NumericUpDownMileage.Size = new Size(300, 21);
            NumericUpDownMileage.TabIndex = 0;
            NumericUpDownMileage.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxModel
            // 
            TextBoxModel.Anchor = AnchorStyles.None;
            TextBoxModel.AutoCompleteCustomSource.AddRange(new string[] { "Acura", "Alfa Romeo", "Aston Martin", "Audi", "Bentley", "BMW", "Bugatti", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Citroen", "Dodge", "Ferrari", "Fiat", "Ford", "Genesis", "GMC", "Honda", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Lincoln", "Lotus", "Maserati", "Mazda", "McLaren", "Mercedes-Benz", "Mini", "Mitsubishi", "Nissan", "Pagani", "Peugeot", "Porsche", "Ram", "Renault", "Rolls-Royce", "Subaru", "Tesla", "Toyota", "Volkswagen", "Volvo", "W Motors", "Zenvo", "Zotye" });
            TextBoxModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TextBoxModel.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TextBoxModel.BackColor = Color.FromArgb(198, 210, 237);
            TextBoxModel.Location = new Point(41, 21);
            TextBoxModel.Margin = new Padding(2);
            TextBoxModel.Name = "TextBoxModel";
            TextBoxModel.Size = new Size(300, 21);
            TextBoxModel.TabIndex = 0;
            // 
            // NumericUpDownCapacity
            // 
            NumericUpDownCapacity.Anchor = AnchorStyles.None;
            NumericUpDownCapacity.BackColor = Color.FromArgb(198, 210, 237);
            NumericUpDownCapacity.Location = new Point(41, 149);
            NumericUpDownCapacity.Margin = new Padding(2);
            NumericUpDownCapacity.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            NumericUpDownCapacity.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDownCapacity.Name = "NumericUpDownCapacity";
            NumericUpDownCapacity.Size = new Size(300, 21);
            NumericUpDownCapacity.TabIndex = 5;
            NumericUpDownCapacity.TextAlign = HorizontalAlignment.Center;
            NumericUpDownCapacity.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // ComboBoxDriver
            // 
            ComboBoxDriver.Anchor = AnchorStyles.None;
            ComboBoxDriver.BackColor = Color.FromArgb(198, 210, 237);
            ComboBoxDriver.DataSource = DriverBindingSource;
            ComboBoxDriver.DisplayMember = "LastName";
            ComboBoxDriver.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxDriver.FormattingEnabled = true;
            ComboBoxDriver.Location = new Point(41, 340);
            ComboBoxDriver.Margin = new Padding(2);
            ComboBoxDriver.Name = "ComboBoxDriver";
            ComboBoxDriver.Size = new Size(300, 23);
            ComboBoxDriver.TabIndex = 7;
            // 
            // DriverBindingSource
            // 
            DriverBindingSource.DataSource = typeof(Entities.Pilot);
            // 
            // DateTimePickerMaintenanceDate
            // 
            DateTimePickerMaintenanceDate.Anchor = AnchorStyles.None;
            DateTimePickerMaintenanceDate.Location = new Point(41, 213);
            DateTimePickerMaintenanceDate.Name = "DateTimePickerMaintenanceDate";
            DateTimePickerMaintenanceDate.Size = new Size(300, 21);
            DateTimePickerMaintenanceDate.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(NumericUpDownLicensePlateNumber, 1, 0);
            tableLayoutPanel2.Controls.Add(ComboBoxFirstLetter, 0, 0);
            tableLayoutPanel2.Controls.Add(ComboBoxSecondLetter, 2, 0);
            tableLayoutPanel2.Controls.Add(ComboBoxThirdLetter, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 67);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(376, 58);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // NumericUpDownLicensePlateNumber
            // 
            NumericUpDownLicensePlateNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NumericUpDownLicensePlateNumber.BackColor = Color.FromArgb(198, 210, 237);
            NumericUpDownLicensePlateNumber.Location = new Point(97, 18);
            NumericUpDownLicensePlateNumber.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            NumericUpDownLicensePlateNumber.Name = "NumericUpDownLicensePlateNumber";
            NumericUpDownLicensePlateNumber.Size = new Size(88, 21);
            NumericUpDownLicensePlateNumber.TabIndex = 0;
            NumericUpDownLicensePlateNumber.TextAlign = HorizontalAlignment.Center;
            NumericUpDownLicensePlateNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ComboBoxFirstLetter
            // 
            ComboBoxFirstLetter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxFirstLetter.BackColor = Color.FromArgb(198, 210, 237);
            ComboBoxFirstLetter.FormattingEnabled = true;
            ComboBoxFirstLetter.Items.AddRange(new object[] { "А", "В", "Е", "К", "М", "Н", "О", "Р", "С", "Т", "У", "Х" });
            ComboBoxFirstLetter.Location = new Point(3, 17);
            ComboBoxFirstLetter.Name = "ComboBoxFirstLetter";
            ComboBoxFirstLetter.Size = new Size(88, 23);
            ComboBoxFirstLetter.TabIndex = 1;
            // 
            // ComboBoxSecondLetter
            // 
            ComboBoxSecondLetter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxSecondLetter.BackColor = Color.FromArgb(198, 210, 237);
            ComboBoxSecondLetter.FormattingEnabled = true;
            ComboBoxSecondLetter.Items.AddRange(new object[] { "А", "В", "Е", "К", "М", "Н", "О", "Р", "С", "Т", "У", "Х" });
            ComboBoxSecondLetter.Location = new Point(191, 17);
            ComboBoxSecondLetter.Name = "ComboBoxSecondLetter";
            ComboBoxSecondLetter.Size = new Size(88, 23);
            ComboBoxSecondLetter.TabIndex = 2;
            // 
            // ComboBoxThirdLetter
            // 
            ComboBoxThirdLetter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxThirdLetter.BackColor = Color.FromArgb(198, 210, 237);
            ComboBoxThirdLetter.FormattingEnabled = true;
            ComboBoxThirdLetter.Items.AddRange(new object[] { "А", "В", "Е", "К", "М", "Н", "О", "Р", "С", "Т", "У", "Х" });
            ComboBoxThirdLetter.Location = new Point(285, 17);
            ComboBoxThirdLetter.Name = "ComboBoxThirdLetter";
            ComboBoxThirdLetter.Size = new Size(88, 23);
            ComboBoxThirdLetter.TabIndex = 3;
            // 
            // ComboBoxRoute
            // 
            ComboBoxRoute.Anchor = AnchorStyles.None;
            ComboBoxRoute.BackColor = Color.FromArgb(198, 210, 237);
            ComboBoxRoute.DataSource = RouteBindingSource;
            ComboBoxRoute.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxRoute.FormattingEnabled = true;
            ComboBoxRoute.Location = new Point(41, 406);
            ComboBoxRoute.Name = "ComboBoxRoute";
            ComboBoxRoute.Size = new Size(300, 23);
            ComboBoxRoute.TabIndex = 12;
            // 
            // RouteBindingSource
            // 
            RouteBindingSource.DataSource = typeof(Entities.Flight);
            // 
            // LabelModel
            // 
            LabelModel.Anchor = AnchorStyles.None;
            LabelModel.AutoSize = true;
            LabelModel.Location = new Point(164, 24);
            LabelModel.Margin = new Padding(2, 0, 2, 0);
            LabelModel.Name = "LabelModel";
            LabelModel.Size = new Size(53, 15);
            LabelModel.TabIndex = 0;
            LabelModel.Text = "Модель";
            // 
            // LabelLicensePlate
            // 
            LabelLicensePlate.Anchor = AnchorStyles.None;
            LabelLicensePlate.AutoSize = true;
            LabelLicensePlate.Location = new Point(143, 88);
            LabelLicensePlate.Margin = new Padding(2, 0, 2, 0);
            LabelLicensePlate.Name = "LabelLicensePlate";
            LabelLicensePlate.Size = new Size(96, 15);
            LabelLicensePlate.TabIndex = 1;
            LabelLicensePlate.Text = "Номерной знак";
            // 
            // LabelCapacity
            // 
            LabelCapacity.Anchor = AnchorStyles.None;
            LabelCapacity.AutoSize = true;
            LabelCapacity.Location = new Point(147, 152);
            LabelCapacity.Margin = new Padding(2, 0, 2, 0);
            LabelCapacity.Name = "LabelCapacity";
            LabelCapacity.Size = new Size(87, 15);
            LabelCapacity.TabIndex = 2;
            LabelCapacity.Text = "Вместимость";
            // 
            // LabelDrivingExperience
            // 
            LabelDrivingExperience.Anchor = AnchorStyles.None;
            LabelDrivingExperience.AutoSize = true;
            LabelDrivingExperience.Location = new Point(84, 216);
            LabelDrivingExperience.Margin = new Padding(2, 0, 2, 0);
            LabelDrivingExperience.Name = "LabelDrivingExperience";
            LabelDrivingExperience.Size = new Size(214, 15);
            LabelDrivingExperience.TabIndex = 3;
            LabelDrivingExperience.Text = "Последняя дата тех. обслуживания";
            // 
            // LabelRoute
            // 
            LabelRoute.Anchor = AnchorStyles.None;
            LabelRoute.AutoSize = true;
            LabelRoute.Location = new Point(173, 410);
            LabelRoute.Margin = new Padding(2, 0, 2, 0);
            LabelRoute.Name = "LabelRoute";
            LabelRoute.Size = new Size(35, 15);
            LabelRoute.TabIndex = 5;
            LabelRoute.Text = "Рейс";
            // 
            // LabelDriver
            // 
            LabelDriver.Anchor = AnchorStyles.None;
            LabelDriver.AutoSize = true;
            LabelDriver.Location = new Point(169, 344);
            LabelDriver.Margin = new Padding(2, 0, 2, 0);
            LabelDriver.Name = "LabelDriver";
            LabelDriver.Size = new Size(44, 15);
            LabelDriver.TabIndex = 4;
            LabelDriver.Text = "Пилот";
            // 
            // LabelMileage
            // 
            LabelMileage.Anchor = AnchorStyles.None;
            LabelMileage.AutoSize = true;
            LabelMileage.Location = new Point(166, 280);
            LabelMileage.Name = "LabelMileage";
            LabelMileage.Size = new Size(49, 15);
            LabelMileage.TabIndex = 6;
            LabelMileage.Text = "Пробег";
            // 
            // TableLayoutPanelDriverParameters
            // 
            TableLayoutPanelDriverParameters.ColumnCount = 1;
            TableLayoutPanelDriverParameters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelDriverParameters.Controls.Add(LabelModel, 0, 0);
            TableLayoutPanelDriverParameters.Controls.Add(LabelLicensePlate, 0, 1);
            TableLayoutPanelDriverParameters.Controls.Add(LabelCapacity, 0, 2);
            TableLayoutPanelDriverParameters.Controls.Add(LabelDrivingExperience, 0, 3);
            TableLayoutPanelDriverParameters.Controls.Add(LabelRoute, 0, 6);
            TableLayoutPanelDriverParameters.Controls.Add(LabelDriver, 0, 5);
            TableLayoutPanelDriverParameters.Controls.Add(LabelMileage, 0, 4);
            TableLayoutPanelDriverParameters.Dock = DockStyle.Fill;
            TableLayoutPanelDriverParameters.Location = new Point(2, 16);
            TableLayoutPanelDriverParameters.Margin = new Padding(2);
            TableLayoutPanelDriverParameters.Name = "TableLayoutPanelDriverParameters";
            TableLayoutPanelDriverParameters.RowCount = 7;
            TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            TableLayoutPanelDriverParameters.Size = new Size(382, 451);
            TableLayoutPanelDriverParameters.TabIndex = 0;
            // 
            // GroupBoxParameters
            // 
            GroupBoxParameters.Controls.Add(TableLayoutPanelDriverParameters);
            GroupBoxParameters.Dock = DockStyle.Fill;
            GroupBoxParameters.Location = new Point(2, 2);
            GroupBoxParameters.Margin = new Padding(2);
            GroupBoxParameters.Name = "GroupBoxParameters";
            GroupBoxParameters.Padding = new Padding(2);
            GroupBoxParameters.Size = new Size(386, 469);
            GroupBoxParameters.TabIndex = 0;
            GroupBoxParameters.TabStop = false;
            GroupBoxParameters.Text = "Параметры";
            // 
            // TableLayoutPanelMain
            // 
            TableLayoutPanelMain.ColumnCount = 2;
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanelMain.Controls.Add(GroupBoxParameters, 0, 0);
            TableLayoutPanelMain.Controls.Add(GroupBoxParametersValues, 1, 0);
            TableLayoutPanelMain.Dock = DockStyle.Fill;
            TableLayoutPanelMain.Location = new Point(2, 2);
            TableLayoutPanelMain.Margin = new Padding(2);
            TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            TableLayoutPanelMain.RowCount = 1;
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableLayoutPanelMain.Size = new Size(780, 473);
            TableLayoutPanelMain.TabIndex = 1;
            // 
            // GroupBoxParametersValues
            // 
            GroupBoxParametersValues.Controls.Add(TableLayoutPanelDriverParametersValue);
            GroupBoxParametersValues.Dock = DockStyle.Fill;
            GroupBoxParametersValues.Location = new Point(392, 2);
            GroupBoxParametersValues.Margin = new Padding(2);
            GroupBoxParametersValues.Name = "GroupBoxParametersValues";
            GroupBoxParametersValues.Padding = new Padding(2);
            GroupBoxParametersValues.Size = new Size(386, 469);
            GroupBoxParametersValues.TabIndex = 1;
            GroupBoxParametersValues.TabStop = false;
            GroupBoxParametersValues.Text = "Значения";
            // 
            // TableLayoutPanelDriverInfo
            // 
            TableLayoutPanelDriverInfo.ColumnCount = 1;
            TableLayoutPanelDriverInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanelDriverInfo.Controls.Add(TableLayoutPanelMain, 0, 0);
            TableLayoutPanelDriverInfo.Controls.Add(GroupBoxActions, 0, 1);
            TableLayoutPanelDriverInfo.Dock = DockStyle.Fill;
            TableLayoutPanelDriverInfo.Location = new Point(0, 0);
            TableLayoutPanelDriverInfo.Margin = new Padding(2);
            TableLayoutPanelDriverInfo.Name = "TableLayoutPanelDriverInfo";
            TableLayoutPanelDriverInfo.RowCount = 2;
            TableLayoutPanelDriverInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanelDriverInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            TableLayoutPanelDriverInfo.Size = new Size(784, 565);
            TableLayoutPanelDriverInfo.TabIndex = 4;
            // 
            // GroupBoxActions
            // 
            GroupBoxActions.Controls.Add(TableLayoutPanelActions);
            GroupBoxActions.Dock = DockStyle.Fill;
            GroupBoxActions.Location = new Point(2, 479);
            GroupBoxActions.Margin = new Padding(2);
            GroupBoxActions.Name = "GroupBoxActions";
            GroupBoxActions.Padding = new Padding(2);
            GroupBoxActions.Size = new Size(780, 84);
            GroupBoxActions.TabIndex = 2;
            GroupBoxActions.TabStop = false;
            GroupBoxActions.Text = "Действия";
            // 
            // TableLayoutPanelActions
            // 
            TableLayoutPanelActions.ColumnCount = 4;
            TableLayoutPanelActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutPanelActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutPanelActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutPanelActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutPanelActions.Controls.Add(ButtonExit, 3, 0);
            TableLayoutPanelActions.Controls.Add(ButtonUpdate, 0, 0);
            TableLayoutPanelActions.Dock = DockStyle.Fill;
            TableLayoutPanelActions.Location = new Point(2, 16);
            TableLayoutPanelActions.Margin = new Padding(2);
            TableLayoutPanelActions.Name = "TableLayoutPanelActions";
            TableLayoutPanelActions.RowCount = 1;
            TableLayoutPanelActions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelActions.Size = new Size(776, 66);
            TableLayoutPanelActions.TabIndex = 0;
            // 
            // ButtonExit
            // 
            ButtonExit.Anchor = AnchorStyles.None;
            ButtonExit.BackColor = Color.FromArgb(174, 163, 176);
            ButtonExit.FlatStyle = FlatStyle.Flat;
            ButtonExit.Location = new Point(614, 20);
            ButtonExit.Margin = new Padding(2);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(130, 25);
            ButtonExit.TabIndex = 0;
            ButtonExit.Text = "Отмена";
            ButtonExit.UseVisualStyleBackColor = false;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Anchor = AnchorStyles.None;
            ButtonUpdate.BackColor = Color.FromArgb(174, 163, 176);
            ButtonUpdate.FlatStyle = FlatStyle.Flat;
            ButtonUpdate.Location = new Point(32, 20);
            ButtonUpdate.Margin = new Padding(2);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(130, 25);
            ButtonUpdate.TabIndex = 1;
            ButtonUpdate.Text = "Изменить";
            ButtonUpdate.UseVisualStyleBackColor = false;
            ButtonUpdate.Click += ButtonUpdate_Click;
            // 
            // UpdatePlaneForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(130, 112, 129);
            ClientSize = new Size(784, 565);
            Controls.Add(TableLayoutPanelDriverInfo);
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(800, 600);
            Name = "UpdatePlaneForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменить параметры самолета";
            TableLayoutPanelDriverParametersValue.ResumeLayout(false);
            TableLayoutPanelDriverParametersValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownMileage).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)DriverBindingSource).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NumericUpDownLicensePlateNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)RouteBindingSource).EndInit();
            TableLayoutPanelDriverParameters.ResumeLayout(false);
            TableLayoutPanelDriverParameters.PerformLayout();
            GroupBoxParameters.ResumeLayout(false);
            TableLayoutPanelMain.ResumeLayout(false);
            GroupBoxParametersValues.ResumeLayout(false);
            TableLayoutPanelDriverInfo.ResumeLayout(false);
            GroupBoxActions.ResumeLayout(false);
            TableLayoutPanelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanelDriverParametersValue;
        private NumericUpDown NumericUpDownMileage;
        private TextBox TextBoxModel;
        private NumericUpDown NumericUpDownCapacity;
        private ComboBox ComboBoxDriver;
        private BindingSource DriverBindingSource;
        private DateTimePicker DateTimePickerMaintenanceDate;
        private TableLayoutPanel tableLayoutPanel2;
        private NumericUpDown NumericUpDownLicensePlateNumber;
        private ComboBox ComboBoxFirstLetter;
        private ComboBox ComboBoxSecondLetter;
        private ComboBox ComboBoxThirdLetter;
        private ComboBox ComboBoxRoute;
        private BindingSource RouteBindingSource;
        private Label LabelModel;
        private Label LabelLicensePlate;
        private Label LabelCapacity;
        private Label LabelDrivingExperience;
        private Label LabelRoute;
        private Label LabelDriver;
        private Label LabelMileage;
        private TableLayoutPanel TableLayoutPanelDriverParameters;
        private GroupBox GroupBoxParameters;
        private TableLayoutPanel TableLayoutPanelMain;
        private GroupBox GroupBoxParametersValues;
        private TableLayoutPanel TableLayoutPanelDriverInfo;
        private GroupBox GroupBoxActions;
        private TableLayoutPanel TableLayoutPanelActions;
        private Button ButtonExit;
        private Button ButtonUpdate;
    }
}