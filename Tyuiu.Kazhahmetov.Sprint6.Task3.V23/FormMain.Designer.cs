namespace Tyuiu.Kazhahmetov.Sprint6.Task3.V23
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
            groupBoxTask = new GroupBox();
            dataGridViewTask = new DataGridView();
            textBox1 = new TextBox();
            buttonRes = new Button();
            buttonInfo = new Button();
            groupBoxRes = new GroupBox();
            dataGridViewRes = new DataGridView();
            textBoxRes = new TextBox();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).BeginInit();
            groupBoxRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(dataGridViewTask);
            groupBoxTask.Controls.Add(textBox1);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(382, 294);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            groupBoxTask.Enter += groupBox1_Enter;
            // 
            // dataGridViewTask
            // 
            dataGridViewTask.AllowUserToAddRows = false;
            dataGridViewTask.AllowUserToDeleteRows = false;
            dataGridViewTask.AllowUserToResizeColumns = false;
            dataGridViewTask.AllowUserToResizeRows = false;
            dataGridViewTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask.ColumnHeadersVisible = false;
            dataGridViewTask.Location = new Point(18, 60);
            dataGridViewTask.Name = "dataGridViewTask";
            dataGridViewTask.ReadOnly = true;
            dataGridViewTask.RowHeadersVisible = false;
            dataGridViewTask.Size = new Size(345, 213);
            dataGridViewTask.TabIndex = 1;
            dataGridViewTask.CellContentClick += dataGridViewTask_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(370, 268);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию во втором столбце.";
            // 
            // buttonRes
            // 
            buttonRes.BackColor = Color.Lime;
            buttonRes.Location = new Point(287, 319);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(224, 56);
            buttonRes.TabIndex = 1;
            buttonRes.Text = "Выполнить";
            buttonRes.UseVisualStyleBackColor = false;
            buttonRes.Click += buttonRes_Click;
            buttonRes.MouseClick += buttonRes_MouseClick;
            buttonRes.MouseEnter += buttonRes_MouseEnter;
            buttonRes.MouseLeave += buttonRes_MouseLeave;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.Aqua;
            buttonInfo.Location = new Point(362, 385);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(77, 56);
            buttonInfo.TabIndex = 2;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(dataGridViewRes);
            groupBoxRes.Controls.Add(textBoxRes);
            groupBoxRes.Location = new Point(415, 12);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(362, 294);
            groupBoxRes.TabIndex = 3;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат";
            groupBoxRes.Enter += groupBox1_Enter_1;
            // 
            // dataGridViewRes
            // 
            dataGridViewRes.AllowUserToAddRows = false;
            dataGridViewRes.AllowUserToDeleteRows = false;
            dataGridViewRes.AllowUserToResizeColumns = false;
            dataGridViewRes.AllowUserToResizeRows = false;
            dataGridViewRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes.ColumnHeadersVisible = false;
            dataGridViewRes.Location = new Point(16, 60);
            dataGridViewRes.MultiSelect = false;
            dataGridViewRes.Name = "dataGridViewRes";
            dataGridViewRes.RowHeadersVisible = false;
            dataGridViewRes.Size = new Size(331, 213);
            dataGridViewRes.TabIndex = 0;
            dataGridViewRes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(6, 22);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.Size = new Size(350, 265);
            textBoxRes.TabIndex = 1;
            textBoxRes.Text = "Готовая матрица:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxRes);
            Controls.Add(buttonInfo);
            Controls.Add(buttonRes);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).EndInit();
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBox1;
        private DataGridView dataGridViewTask;
        private Button buttonRes;
        private Button buttonInfo;
        private GroupBox groupBoxRes;
        private TextBox textBoxRes;
        private DataGridView dataGridViewRes;
    }
}
