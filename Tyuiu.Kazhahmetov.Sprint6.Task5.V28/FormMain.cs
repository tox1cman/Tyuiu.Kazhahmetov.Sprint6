using System.Xml.Linq;
using Tyuiu.Kazhahmetov.Sprint6.Task5.V28.Lib;
namespace Tyuiu.Kazhahmetov.Sprint6.Task5.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\\DataSprint6\InPutDataFileTask5V28.txt";


        private void groupBoxTask_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.chart1.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";

            chart1.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chart1.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПИНб-25-1 Кажахметов Амир Ерболович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
