﻿using System;
using System.Windows.Forms;

namespace PhotoCenterSystem
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            CreateAndAddButton("Открыть клиентский интерфейс", OpenClientWindow, new System.Drawing.Point(50, 50));
            CreateAndAddButton("Открыть интерфейс сотрудника", OpenEmployeeWindow, new System.Drawing.Point(50, 100));
            CreateAndAddButton("Открыть административный интерфейс", OpenAdminWindow, new System.Drawing.Point(50, 150));
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

        private void CreateAndAddButton(string text, EventHandler clickHandler, System.Drawing.Point location)
        {
            Button button = new Button
            {
                Text = text,
                Size = new System.Drawing.Size(150, 40),
                Location = location
            };
            button.Click += clickHandler;
            this.Controls.Add(button);
        }
    }
}
