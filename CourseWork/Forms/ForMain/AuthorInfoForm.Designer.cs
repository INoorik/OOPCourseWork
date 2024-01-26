namespace CourseWork.Forms.ForMain;

partial class AuthorInfoForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorInfoForm));
        tableLayoutPanel1 = new TableLayoutPanel();
        ButtonExit = new Button();
        label1 = new Label();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(ButtonExit, 0, 1);
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Margin = new Padding(4);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.Size = new Size(464, 282);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // ButtonExit
        // 
        ButtonExit.Anchor = AnchorStyles.None;
        ButtonExit.BackColor = Color.FromArgb(174, 163, 176);
        ButtonExit.FlatStyle = FlatStyle.Flat;
        ButtonExit.Location = new Point(181, 238);
        ButtonExit.Name = "ButtonExit";
        ButtonExit.Size = new Size(102, 30);
        ButtonExit.TabIndex = 1;
        ButtonExit.Text = "Отлично";
        ButtonExit.UseVisualStyleBackColor = false;
        ButtonExit.Click += ButtonExit_Click;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.AutoSize = true;
        label1.Location = new Point(60, 52);
        label1.Name = "label1";
        label1.Size = new Size(343, 120);
        label1.TabIndex = 2;
        label1.Text = "Приложение выполнено в ходе выполнения\r\n            курсовой работы\r\n\r\nТема: \"Касса аэрофлота\"\r\n\r\nВыполнил: Абузяров Айнур, 21ВП2";
        // 
        // AuthorInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(130, 112, 129);
        ClientSize = new Size(464, 282);
        Controls.Add(tableLayoutPanel1);
        Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MaximumSize = new Size(480, 320);
        MinimumSize = new Size(480, 320);
        Name = "AuthorInfoForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Информация об авторе";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Button ButtonExit;
    private Label label1;
}