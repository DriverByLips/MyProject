using System;
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

            ListView listView = new ListView();
            listView.Columns.Add("Номер", 100);
            listView.Columns.Add("Клиент", 200);
            listView.Columns.Add("Статус", 100);
            listView.Dock = DockStyle.Top;

            Button btnUpdateStatus = new Button();
            btnUpdateStatus.Text = "Обновить статус";
            btnUpdateStatus.Click += UpdateOrderStatus;
            btnUpdateStatus.Dock = DockStyle.Bottom;

            // Добавление элементов на форму
            this.Controls.Add(listView);
            this.Controls.Add(btnUpdateStatus);
        }
    }
}
