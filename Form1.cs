﻿using System;
using System.Windows.Forms;

namespace PhotoCenterSystem
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            ButtonInitializer.InitializeButtons(this, OpenClientWindow, OpenEmployeeWindow, OpenAdminWindow);  // Передаем обработчики
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(378, 294);
            this.Name = "MainWindow";
            this.Text = "Photo Center System";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // В дальнейшем можно добавить загрузку данных или другие действия
        }

        private void OpenClientWindow(object sender, EventArgs e)
        {
            OpenWindow(new RegistrationForm());
        }

        private void OpenEmployeeWindow(object sender, EventArgs e)
        {
            OpenWindow(new EmployeeWindow());
        }

        private void OpenAdminWindow(object sender, EventArgs e)
        {
            OpenWindow(new AdminWindow());
        }

        private void OpenWindow(Form form)
        {
            form.Show();
        }
    }

    // Новый вспомогательный класс для инициализации кнопок
    public static class ButtonInitializer
    {
        public static void InitializeButtons(Form form, EventHandler clientHandler, EventHandler employeeHandler, EventHandler adminHandler)
        {
            CreateAndAddButton(form, "Открыть клиентский интерфейс", clientHandler, new System.Drawing.Point(50, 50));
            CreateAndAddButton(form, "Открыть интерфейс сотрудника", employeeHandler, new System.Drawing.Point(50, 100));
            CreateAndAddButton(form, "Открыть административный интерфейс", adminHandler, new System.Drawing.Point(50, 150));
        }

        private static void CreateAndAddButton(Form form, string text, EventHandler clickHandler, System.Drawing.Point location)
        {
            Button button = new Button
            {
                Text = text,
                Size = new System.Drawing.Size(150, 40),
                Location = location
            };
            button.Click += clickHandler;
            form.Controls.Add(button);
        }
    }
}
