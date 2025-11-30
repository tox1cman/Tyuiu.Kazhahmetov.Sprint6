using Tyuiu.Kazhahmetov.Sprint6.Task3.V23.Lib;
namespace Tyuiu.Kazhahmetov.Sprint6.Task3.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] {
                                {0, -19, 25, 34,  0 },
                                {-19, -16, 1, -5, 32},
                                {1, 13, -5, -17,  -5},
                                {3, -9, -15, -1,   0},
                                {1, 20, 15, -5,   31} };



        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            dataGridViewTask.ColumnCount = cols;
            dataGridViewTask.RowCount = rows;


            for (int i = 0; i < cols; i++)
            {
                dataGridViewTask.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewTask.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }

            }
            dataGridViewTask.ReadOnly = true;
            dataGridViewTask.AllowUserToOrderColumns = false;
            dataGridViewTask.AllowUserToResizeColumns = false;
            dataGridViewTask.AllowUserToResizeRows = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПИНб-25-1 Кажахметов Амир Ерболович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewTask.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewTask.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }

            }
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            int[,] res_matrix = ds.Calculate(matrix);

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            dataGridViewRes.ColumnCount = cols;
            dataGridViewRes.RowCount = rows;


            for (int i = 0; i < cols; i++)
            {
                dataGridViewRes.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewRes.Rows[i].Cells[j].Value = Convert.ToString(res_matrix[i, j]);
                }

            }
            dataGridViewRes.ReadOnly = true;
            dataGridViewRes.AllowUserToOrderColumns = false;
            dataGridViewRes.AllowUserToResizeColumns = false;
            dataGridViewRes.AllowUserToResizeRows = false;
        }

        private void buttonRes_MouseEnter(object sender, EventArgs e)
        {
            buttonRes.BackColor = Color.Red;
        }

        private void buttonRes_MouseLeave(object sender, EventArgs e)
        {
            buttonRes.BackColor = Color.Lime;
        }

        private void buttonRes_MouseClick(object sender, MouseEventArgs e)
        {
            buttonRes.BackColor = Color.Yellow;
        }
    }
}
