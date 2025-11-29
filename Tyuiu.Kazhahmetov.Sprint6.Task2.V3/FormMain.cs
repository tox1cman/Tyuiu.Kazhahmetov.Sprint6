using Tyuiu.Kazhahmetov.Sprint6.Task2.V3.Lib;
namespace Tyuiu.Kazhahmetov.Sprint6.Task2.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void textBoxTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEnd_Click(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int end = Convert.ToInt32(textBoxEnd.Text);

                int len = ds.GetMassFunction(start, end).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, end);

                this.dataGridViewRes.Rows.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewRes.Rows.Add(Convert.ToString(start), Convert.ToString(valueArray[i]));
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПИНб-25-1 Кажахметов Амир Ерболович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void buttonResult_MouseMove(object sender, EventArgs e)
        {
            buttonResult.BackColor = Color.Red;
        }


        private void buttonResult_MouseLeave(object sender, EventArgs e)
        {
            buttonResult.BackColor = Color.Green;
        }

        private void buttonResult_MouseClick(object sender, MouseEventArgs e)
        {
            buttonResult.BackColor = Color.YellowGreen;
        }

        private void buttonResult_MouseEnter(object sender, EventArgs e)
        {
            buttonResult.BackColor = Color.Red;
        }
    }
}
