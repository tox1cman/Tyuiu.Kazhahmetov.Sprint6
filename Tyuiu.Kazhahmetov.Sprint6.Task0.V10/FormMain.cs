using System.Security.AccessControl;
using Tyuiu.Kazhahmetov.Sprint6.Task0.V10.Lib;
namespace Tyuiu.Kazhahmetov.Sprint6.Task0.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Text = "ТАСК 0 | ВАРИАНТ 10 | Кажахметов.А.Е | ПИНб-25-1 |";
        }
        private void getResult_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                TextBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxX.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void try_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПИНб-25-1 Кажахметов Амир Ерболович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
