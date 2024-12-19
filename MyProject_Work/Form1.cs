using System;
using System.Windows.Forms;

//Добавил комментарии

namespace PhotoCenterSystem
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenClientWindow(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void OpenEmployeeWindow(object sender, EventArgs e)
        {
            EmployeeWindow employeeWindow = new EmployeeWindow();
            employeeWindow.Show();
        }

        private void OpenAdminWindow(object sender, EventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
        }

        private void InitializeComponent()
        {
            this.Text = "Photo Center System";
            this.Size = new System.Drawing.Size(400, 350);

            Button btnClient = new Button();
            btnClient.Text = "Клиент";
            btnClient.Click += OpenClientWindow;
            btnClient.Size = new System.Drawing.Size(150, 40);
            btnClient.Location = new System.Drawing.Point(125, 80);

            Button btnEmployee = new Button();
            btnEmployee.Text = "Сотрудник";
            btnEmployee.Click += OpenEmployeeWindow;
            btnEmployee.Size = new System.Drawing.Size(150, 40);
            btnEmployee.Location = new System.Drawing.Point(125, 130);

            Button btnAdmin = new Button();
            btnAdmin.Text = "Администратор";
            btnAdmin.Click += OpenAdminWindow;
            btnAdmin.Size = new System.Drawing.Size(150, 40);
            btnAdmin.Location = new System.Drawing.Point(125, 180);

            // Добавление кнопок в форму
            this.Controls.Add(btnClient);
            this.Controls.Add(btnEmployee);
            this.Controls.Add(btnAdmin);
        }
    }
}
