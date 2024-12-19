using System;
using System.Windows.Forms;

namespace PhotoCenterSystem
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void GenerateReport(object sender, EventArgs e)
        {
            MessageBox.Show("Отчёт сгенерирован.");
        }

        private void AddUser(object sender, EventArgs e)
        {
            MessageBox.Show("Пользователь добавлен.");
        }

        private void InitializeComponent()
        {
            this.Text = "Администратор";
            this.Size = new System.Drawing.Size(600, 400);

            TabControl tabControl = new TabControl
            {
                Dock = DockStyle.Fill
            };

            tabControl.TabPages.Add(CreateUserManagementTab());
            tabControl.TabPages.Add(CreateReportTab());

            // Добавление TabControl в форму
            this.Controls.Add(tabControl);
        }

        private TabPage CreateUserManagementTab()
        {
            TabPage tabPage = new TabPage("Пользователи");

            ListView listView = CreateListView(new[] { "Имя", "Роль", "Последний вход" }, new[] { 200, 150, 150 });
            listView.Dock = DockStyle.Fill;
            tabPage.Controls.Add(listView);

            Button btnAddUser = CreateButton("Добавить пользователя", AddUser, DockStyle.Bottom);
            tabPage.Controls.Add(btnAddUser);

            return tabPage;
        }

        private TabPage CreateReportTab()
        {
            TabPage tabPage = new TabPage("Отчёты");

            ComboBox comboBox = new ComboBox
            {
                Dock = DockStyle.Top
            };
            comboBox.Items.AddRange(new[] { "Финансовый", "Заказы" });
            tabPage.Controls.Add(comboBox);

            Button btnGenerateReport = CreateButton("Сгенерировать отчёт", GenerateReport, DockStyle.Bottom);
            tabPage.Controls.Add(btnGenerateReport);

            return tabPage;
        }

        private ListView CreateListView(string[] columnNames, int[] columnWidths)
        {
            ListView listView = new ListView();

            for (int i = 0; i < columnNames.Length; i++)
            {
                listView.Columns.Add(columnNames[i], columnWidths[i]);
            }

            return listView;
        }

        private Button CreateButton(string text, EventHandler clickHandler, DockStyle dockStyle)
        {
            Button button = new Button
            {
                Text = text,
                Dock = dockStyle
            };

            if (clickHandler != null)
            {
                button.Click += clickHandler;
            }

            return button;
        }
    }
}
