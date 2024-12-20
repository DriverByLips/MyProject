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

            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            TabPage tabPage1 = new TabPage("Пользователи");
            ListView listView = new ListView();
            listView.Columns.Add("Имя", 200);
            listView.Columns.Add("Роль", 150);
            listView.Columns.Add("Последний вход", 150);
            listView.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(listView);

            Button btnAddUser = new Button();
            btnAddUser.Text = "Добавить пользователя";
            btnAddUser.Click += AddUser;
            btnAddUser.Dock = DockStyle.Bottom;
            tabPage1.Controls.Add(btnAddUser);

            TabPage tabPage2 = new TabPage("Отчёты");
            ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("Финансовый");
            comboBox.Items.Add("Заказы");
            comboBox.Dock = DockStyle.Top;

            Button btnGenerateReport = new Button();
            btnGenerateReport.Text = "Сгенерировать отчёт";
            btnGenerateReport.Click += GenerateReport;
            btnGenerateReport.Dock = DockStyle.Bottom;

            tabPage2.Controls.Add(comboBox);
            tabPage2.Controls.Add(btnGenerateReport);

            tabControl.TabPages.Add(tabPage1);
            tabControl.TabPages.Add(tabPage2);

            // Добавление TabControl в форму
            this.Controls.Add(tabControl);
        }
    }
}
