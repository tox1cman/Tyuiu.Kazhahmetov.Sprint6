using Tyuiu.Kazhahmetov.Sprint6.Task4.V15.Lib;
namespace Tyuiu.Kazhahmetov.Sprint6.Task4.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int end = Convert.ToInt32(textBoxEnd.Text);
                double[] values = ds.GetMassFunction(start, end);
                this.chart1.Titles.Add("График функции sin(x)");
                this.chart1.ChartAreas[0].AxisX.Title = "X";
                this.chart1.ChartAreas[0].AxisY.Title = "Y";
                textBoxRes.Text = "";
                chart1.Series[0].Points.Clear();
                for (int i = 0; i < values.Length; i++)
                {
                    this.chart1.Series[0].Points.AddXY(start, values[i]);
                    textBoxRes.AppendText(values[i] + Environment.NewLine);
                    start++;
                }
            }
            catch { MessageBox.Show("Wrong Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxRes.Text);
                DialogResult dia = MessageBox.Show("Файл" + path + "сохранен успешно! \n Открыть его?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dia == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch { MessageBox.Show("Wrong Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПИНб-25-1 Кажахметов Амир Ерболович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
