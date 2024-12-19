using System;
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
            // Здесь можно добавить логику проверки введённых данных и их сохранения
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Регистрация успешна!");

                // Закрываем окно регистрации
                this.Close();

                // Открываем окно клиента
                ClientWindow clientForm = new ClientWindow();
                clientForm.Show();
            }
            else
            {
                MessageBox.Show("Заполните все поля.");
            }
        }
    }
}
