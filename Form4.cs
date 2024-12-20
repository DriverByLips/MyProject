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

            // Используем вспомогательный метод для создания TabControl и TabPages
            TabControl tabControl = CreateTabControl();
            this.Controls.Add(tabControl);
        }

        // Метод для создания TabControl с добавленными TabPages
        private TabControl CreateTabControl()
        {
            TabControl tabControl = new TabControl
            {
                Dock = DockStyle.Fill
            };

            tabControl.TabPages.Add(CreateTabPage("Пользователи", CreateUserManagementTab()));
            tabControl.TabPages.Add(CreateTabPage("Отчёты", CreateReportTab()));

            return tabControl;
        }

        // Метод для создания TabPage с контентом
        private TabPage CreateTabPage(string tabName, Control tabContent)
        {
            return new TabPage(tabName)
            {
                Controls = { tabContent }
            };
        }

        // Метод для создания панели с элементами управления для управления пользователями
        private Control CreateUserManagementTab()
        {
            Panel panel = new Panel { Dock = DockStyle.Fill };

            // Используем вспомогательные методы для создания элементов управления
            ListView listView = CreateListView(new[] { "Имя", "Роль", "Последний вход" }, new[] { 200, 150, 150 });
            panel.Controls.Add(listView);

            Button btnAddUser = CreateButton("Добавить пользователя", AddUser, DockStyle.Bottom);
            panel.Controls.Add(btnAddUser);

            return panel;
        }

        // Метод для создания панели с элементами управления для создания отчётов
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

        // Метод для создания ListView с переданными параметрами
        private ListView CreateListView(string[] columnNames, int[] columnWidths)
        {
            ListView listView = new ListView { Dock = DockStyle.Fill };

            for (int i = 0; i < columnNames.Length; i++)
            {
                listView.Columns.Add(columnNames[i], columnWidths[i]);
            }

            return listView;
        }

        // Метод для создания кнопки с переданным текстом и обработчиком события
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
