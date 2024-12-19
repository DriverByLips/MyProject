﻿using System;
using System.Windows.Forms;

namespace PhotoCenterSystem
{
    public partial class EmployeeWindow : Form
    {
        public EmployeeWindow()
        {
            InitializeComponent();
        }

        private void UpdateOrderStatus(object sender, EventArgs e)
        {
            MessageBox.Show("Статус заказа обновлён.");
        }

        private void InitializeComponent()
        {
            this.Text = "Сотрудник";
            this.Size = new System.Drawing.Size(600, 400);

            ListView listView = CreateOrderListView();
            Button btnUpdateStatus = CreateButton("Обновить статус", UpdateOrderStatus, DockStyle.Bottom);

            // Добавление элементов на форму
            this.Controls.Add(listView);
            this.Controls.Add(btnUpdateStatus);
        }

        private ListView CreateOrderListView()
        {
            ListView listView = new ListView
            {
                Dock = DockStyle.Top
            };

            // Универсальный метод добавления столбцов
            AddColumnsToListView(listView, new[] { "Номер", "Клиент", "Статус" }, new[] { 100, 200, 100 });

            return listView;
        }

        private void AddColumnsToListView(ListView listView, string[] columnNames, int[] columnWidths)
        {
            for (int i = 0; i < columnNames.Length; i++)
            {
                listView.Columns.Add(columnNames[i], columnWidths[i]);
            }
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
