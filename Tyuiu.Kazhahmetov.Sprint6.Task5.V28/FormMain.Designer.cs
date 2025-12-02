namespace Tyuiu.Kazhahmetov.Sprint6.Task5.V28
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonInfo = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            panel1 = new Panel();
            groupBoxTask = new GroupBox();
            textBox2 = new TextBox();
            textBoxRes = new TextBox();
            groupBoxRes = new GroupBox();
            dataGridView1 = new DataGridView();
            Index = new DataGridViewTextBoxColumn();
            Res = new DataGridViewTextBoxColumn();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            groupBoxTask.SuspendLayout();
            groupBoxRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(788, 13);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(78, 50);
            buttonInfo.TabIndex = 4;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Cyan;
            buttonSave.Location = new Point(696, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(78, 50);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Открыть файл";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Lime;
            buttonDone.Location = new Point(601, 13);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(78, 50);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonInfo);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(groupBoxTask);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 75);
            panel1.TabIndex = 1;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBox2);
            groupBoxTask.Dock = DockStyle.Left;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(571, 75);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            groupBoxTask.Enter += groupBoxTask_Enter;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 19);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(565, 53);
            textBox2.TabIndex = 0;
            textBox2.Text = "Прочитать данные из файла InPutFileTask5V28.txt. Вывести в dataGridView. Вывести все числа, меньше 10. Построить диаграмму по этим значениям. \r\n";
            // 
            // textBoxRes
            // 
            textBoxRes.Dock = DockStyle.Fill;
            textBoxRes.Location = new Point(0, 0);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.ScrollBars = ScrollBars.Vertical;
            textBoxRes.Size = new Size(984, 411);
            textBoxRes.TabIndex = 2;
            // 
            // groupBoxRes
            // 
            groupBoxRes.BackColor = Color.White;
            groupBoxRes.Controls.Add(dataGridView1);
            groupBoxRes.Dock = DockStyle.Left;
            groupBoxRes.Location = new Point(0, 75);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(200, 336);
            groupBoxRes.TabIndex = 3;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Вывод";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Index, Res });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(194, 314);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Index
            // 
            Index.HeaderText = "";
            Index.Name = "Index";
            Index.Width = 50;
            // 
            // Res
            // 
            Res.HeaderText = "";
            Res.Name = "Res";
            Res.Width = 50;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(200, 75);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(784, 336);
            chart1.TabIndex = 4;
            chart1.Text = "chart1";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 336);
            panel2.TabIndex = 5;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(200, 75);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 336);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 411);
            Controls.Add(splitter1);
            Controls.Add(chart1);
            Controls.Add(panel2);
            Controls.Add(groupBoxRes);
            Controls.Add(panel1);
            Controls.Add(textBoxRes);
            MinimizeBox = false;
            MinimumSize = new Size(1000, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInfo;
        private Button buttonSave;
        private Button buttonDone;
        private Panel panel1;
        private GroupBox groupBoxTask;
        private TextBox textBox2;
        private TextBox textBoxRes;
        private GroupBox groupBoxRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel2;
        private Splitter splitter1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn Res;
    }
}
