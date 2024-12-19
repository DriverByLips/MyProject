using System;
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

            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            TabPage tabPage1 = new TabPage("Личный кабинет");
            ListView listView = new ListView();
            listView.Columns.Add("Дата", 100);
            listView.Columns.Add("Статус", 200);
            listView.Columns.Add("Сумма", 100);
            listView.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(listView);

            Button btnSubmitOrder = new Button();
            btnSubmitOrder.Text = "Оформить новый заказ";
            btnSubmitOrder.Click += SubmitOrder;
            btnSubmitOrder.Dock = DockStyle.Bottom;
            tabPage1.Controls.Add(btnSubmitOrder);

            TabPage tabPage2 = new TabPage("Оформление заказа");
            Button btnUpload = new Button();
            btnUpload.Text = "Загрузить";
            btnUpload.Dock = DockStyle.Top;

            ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("Глянцевая бумага");
            comboBox.Items.Add("Матовая бумага");
            comboBox.Dock = DockStyle.Top;

            Button btnConfirmOrder = new Button();
            btnConfirmOrder.Text = "Подтвердить заказ";
            btnConfirmOrder.Click += SubmitOrder;
            btnConfirmOrder.Dock = DockStyle.Bottom;

            tabPage2.Controls.Add(btnUpload);
            tabPage2.Controls.Add(comboBox);
            tabPage2.Controls.Add(btnConfirmOrder);

            tabControl.TabPages.Add(tabPage1);
            tabControl.TabPages.Add(tabPage2);

            // Добавление TabControl в форму
            this.Controls.Add(tabControl);
        }
    }
}
