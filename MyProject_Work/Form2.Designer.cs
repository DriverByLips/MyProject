namespace PhotoCenterSystem
{
    partial class ClientWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView = new System.Windows.Forms.ListView();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUpload = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(578, 344);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView);
            this.tabPage1.Controls.Add(this.btnSubmitOrder);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(570, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Личный кабинет";
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(570, 288);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmitOrder.Location = new System.Drawing.Point(0, 288);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(570, 23);
            this.btnSubmitOrder.TabIndex = 1;
            this.btnSubmitOrder.Text = "Оформить новый заказ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpload);
            this.tabPage2.Controls.Add(this.comboBox);
            this.tabPage2.Controls.Add(this.btnConfirmOrder);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(570, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оформление заказа";
            // 
            // btnUpload
            // 
            this.btnUpload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpload.Location = new System.Drawing.Point(0, 28);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(570, 34);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Загрузить";
            // 
            // comboBox
            // 
            this.comboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox.Items.AddRange(new object[] {
            "Глянцевая бумага",
            "Матовая бумага"});
            this.comboBox.Location = new System.Drawing.Point(0, 0);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(570, 28);
            this.comboBox.TabIndex = 1;
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfirmOrder.Location = new System.Drawing.Point(0, 288);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(570, 23);
            this.btnConfirmOrder.TabIndex = 2;
            this.btnConfirmOrder.Text = "Подтвердить заказ";
            // 
            // ClientWindow
            // 
            this.ClientSize = new System.Drawing.Size(578, 344);
            this.Controls.Add(this.tabControl);
            this.Name = "ClientWindow";
            this.Text = "Клиент";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnConfirmOrder;
    }
}