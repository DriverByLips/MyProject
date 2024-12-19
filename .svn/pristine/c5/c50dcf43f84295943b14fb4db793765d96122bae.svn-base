using System;
using System.Windows.Forms;

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
            this.Text = "Photo Center System";
            this.Size = new System.Drawing.Size(400, 350);

            CreateAndAddButton("Клиент", OpenClientWindow, new System.Drawing.Point(125, 80));
            CreateAndAddButton("Сотрудник", OpenEmployeeWindow, new System.Drawing.Point(125, 130));
            CreateAndAddButton("Администратор", OpenAdminWindow, new System.Drawing.Point(125, 180));
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
