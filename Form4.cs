﻿using System;
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

            tabControl.TabPages.Add(CreateTabPage("Пользователи", CreateUserManagementTab()));
            tabControl.TabPages.Add(CreateTabPage("Отчёты", CreateReportTab()));

            // Добавление TabControl в форму
            this.Controls.Add(tabControl);
        }

        private TabPage CreateTabPage(string tabName, Control tabContent)
        {
            TabPage tabPage = new TabPage(tabName)
            {
                Controls = { tabContent }
            };
            return tabPage;
        }

        private Control CreateUserManagementTab()
        {
            Panel panel = new Panel { Dock = DockStyle.Fill };

            ListView listView = CreateListView(new[] { "Имя", "Роль", "Последний вход" }, new[] { 200, 150, 150 });
            panel.Controls.Add(listView);

            Button btnAddUser = CreateButton("Добавить пользователя", AddUser, DockStyle.Bottom);
            panel.Controls.Add(btnAddUser);

            return panel;
        }

        private Control CreateReportTab()
        {
            Panel panel = new Panel { Dock = DockStyle.Fill };

            ComboBox comboBox = new ComboBox
            {
                Dock = DockStyle.Top,
                Items = { "Финансовый", "Заказы" }
            };
            panel.Controls.Add(comboBox);

            Button btnGenerateReport = CreateButton("Сгенерировать отчёт", GenerateReport, DockStyle.Bottom);
            panel.Controls.Add(btnGenerateReport);

            return panel;
        }

        private ListView CreateListView(string[] columnNames, int[] columnWidths)
        {
            ListView listView = new ListView();
            for (int i = 0; i < columnNames.Length; i++)
            {
                listView.Columns.Add(columnNames[i], columnWidths[i]);
            }
            listView.Dock = DockStyle.Fill;
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
