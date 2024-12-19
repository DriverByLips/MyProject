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

            listView.Columns.Add("Номер", 100);
            listView.Columns.Add("Клиент", 200);
            listView.Columns.Add("Статус", 100);

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
