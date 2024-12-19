namespace PhotoCenterSystem
{
    partial class AdminWindow
    {
        /// <summary>
        /// Необходимая переменная для поддержки конструктора компонента.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очищает все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">Если значение true, уничтожаются все управляемые ресурсы.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором Windows Form Designer

        /// <summary>
        /// Требуется для поддержки конструктора формы.
        /// </summary>
        

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}
