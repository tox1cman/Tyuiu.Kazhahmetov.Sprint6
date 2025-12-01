namespace Tyuiu.Kazhahmetov.Sprint6.Task4.V15
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
            panel1 = new Panel();
            buttonInfo = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            groupBoxData = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            groupBoxTask = new GroupBox();
            textBox2 = new TextBox();
            panel2 = new Panel();
            groupBoxRes = new GroupBox();
            textBoxRes = new TextBox();
            panel3 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            groupBoxData.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxRes.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonInfo);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(groupBoxData);
            panel1.Controls.Add(groupBoxTask);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 75);
            panel1.TabIndex = 0;
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
            buttonSave.Text = "Сохранить";
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
            // groupBoxData
            // 
            groupBoxData.Controls.Add(label2);
            groupBoxData.Controls.Add(label1);
            groupBoxData.Controls.Add(textBoxEnd);
            groupBoxData.Controls.Add(textBoxStart);
            groupBoxData.Dock = DockStyle.Left;
            groupBoxData.Location = new Point(344, 0);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(241, 75);
            groupBoxData.TabIndex = 1;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Ввод Данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 21);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Конец";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Старт";
            label1.Click += label1_Click;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(129, 39);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(100, 23);
            textBoxEnd.TabIndex = 1;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(15, 39);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBox2);
            groupBoxTask.Dock = DockStyle.Left;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(344, 75);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 19);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(338, 53);
            textBox2.TabIndex = 0;
            textBox2.Text = "Протабулировать функицю sin(x) на диапазоне от -5 до 5.\r\nРезультат вывести в TextBox, построить график и сохранить файл.";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(groupBoxRes);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 336);
            panel2.TabIndex = 0;
            // 
            // groupBoxRes
            // 
            groupBoxRes.BackColor = Color.White;
            groupBoxRes.Controls.Add(textBoxRes);
            groupBoxRes.Dock = DockStyle.Fill;
            groupBoxRes.Location = new Point(0, 0);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(200, 336);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Вывод";
            // 
            // textBoxRes
            // 
            textBoxRes.Dock = DockStyle.Fill;
            textBoxRes.Location = new Point(3, 19);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.ScrollBars = ScrollBars.Vertical;
            textBoxRes.Size = new Size(194, 314);
            textBoxRes.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(chart1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(784, 336);
            panel3.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(784, 336);
            chart1.TabIndex = 0;
            chart1.Text = "График Функции";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(200, 75);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 336);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 411);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            groupBoxData.ResumeLayout(false);
            groupBoxData.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private GroupBox groupBoxRes;
        private GroupBox groupBoxTask;
        private TextBox textBox2;
        private TextBox textBoxRes;
        private GroupBox groupBoxData;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private Label label1;
        private Label label2;
        private Button buttonDone;
        private Button buttonInfo;
        private Button buttonSave;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
