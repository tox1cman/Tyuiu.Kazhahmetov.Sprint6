using Tyuiu.Kazhahmetov.Sprint6.Task1.V18.Lib;
namespace Tyuiu.Kazhahmetov.Sprint6.Task1.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int end = Convert.ToInt32(textBoxEnd.Text);

                string strLine;

                int len = ds.GetMassFunction(start, end).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, end);
                textBoxResult.Text = "";
                textBoxResult.Text = ("+----------+----------+" + Environment.NewLine);
                textBoxResult.Text = ("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult.Text = ("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len - 1; i++)
                {
                    strLine = String.Format("| {0,5:d}    |  {1, 5:f2}   | ", start, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    start++;
                }

                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);



            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПИНб-25-1 Кажахметов Амир Ерболович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
