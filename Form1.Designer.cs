namespace PhotoCenterSystem
{
    partial class MainWindow
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

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnAdmin;
    }
}
