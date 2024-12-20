﻿using System;
using System.Windows.Forms;

namespace PhotoCenterSystem
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        // Обработчик для кнопки "Зарегистрироваться"
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (AreFieldsValid(username, password))
            {
                RegisterUser(username, password);
            }
            else
            {
                ShowErrorMessage("Заполните все поля.");
            }
        }

        // Проверка на заполненность полей
        private bool AreFieldsValid(string username, string password)
        {
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
        }

        // Логика регистрации пользователя
        private void RegisterUser(string username, string password)
        {
            // Можно добавить логику сохранения пользователя в базу данных или другой источник
            ShowMessage("Регистрация успешна!");

            CloseRegistrationForm();
            OpenClientWindow();
        }

        // Закрытие окна регистрации
        private void CloseRegistrationForm()
        {
            this.Close();
        }

        // Открытие окна клиента
        private void OpenClientWindow()
        {
            ClientWindow clientForm = new ClientWindow();
            clientForm.Show();
        }

        // Метод для отображения сообщений об ошибке
        private void ShowErrorMessage(string message)
        {
            ShowMessage(message);
        }

        // Универсальный метод для отображения сообщений
        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
