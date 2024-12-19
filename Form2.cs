﻿using System;
using System.Windows.Forms;

namespace PhotoCenterSystem
{
    public partial class ClientWindow : Form
    {
        public ClientWindow()
        {
            InitializeComponent();
        }

        private void SubmitOrder(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ оформлен.");
        }

        private void InitializeComponent1()
        {
            this.Text = "Клиент";
            this.Size = new System.Drawing.Size(600, 400);

            TabControl tabControl = new TabControl
            {
                Dock = DockStyle.Fill
            };

            tabControl.TabPages.Add(CreatePersonalCabinetTab());
            tabControl.TabPages.Add(CreateOrderPlacementTab());

            // Добавление TabControl в форму
            this.Controls.Add(tabControl);
        }

        private TabPage CreatePersonalCabinetTab()
        {
            TabPage tabPage = new TabPage("Личный кабинет");

            ListView listView = CreateListView(new[] { "Дата", "Статус", "Сумма" }, new[] { 100, 200, 100 });
            listView.Dock = DockStyle.Fill;
            tabPage.Controls.Add(listView);

            Button btnSubmitOrder = CreateButton("Оформить новый заказ", SubmitOrder, DockStyle.Bottom);
            tabPage.Controls.Add(btnSubmitOrder);

            return tabPage;
        }

        private TabPage CreateOrderPlacementTab()
        {
            TabPage tabPage = new TabPage("Оформление заказа");

            Button btnUpload = CreateButton("Загрузить", null, DockStyle.Top);
            tabPage.Controls.Add(btnUpload);

            ComboBox comboBox = new ComboBox
            {
                Dock = DockStyle.Top
            };
            comboBox.Items.AddRange(new[] { "Глянцевая бумага", "Матовая бумага" });
            tabPage.Controls.Add(comboBox);

            Button btnConfirmOrder = CreateButton("Подтвердить заказ", SubmitOrder, DockStyle.Bottom);
            tabPage.Controls.Add(btnConfirmOrder);

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
