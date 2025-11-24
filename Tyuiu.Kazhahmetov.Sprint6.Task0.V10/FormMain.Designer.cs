namespace Tyuiu.Kazhahmetov.Sprint6.Task0.V10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxX = new TextBox();
            buttonCalc = new Button();
            TextBoxResult = new TextBox();
            Info = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(59, 303);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(360, 23);
            textBoxX.TabIndex = 0;
            textBoxX.TextChanged += textBoxX_TextChanged;
            textBoxX.KeyPress += try_KeyPress;
            // 
            // buttonCalc
            // 
            buttonCalc.FlatStyle = FlatStyle.Flat;
            buttonCalc.Location = new Point(613, 393);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(160, 41);
            buttonCalc.TabIndex = 1;
            buttonCalc.Text = "Вычислить";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += getResult_Click;
            // 
            // TextBoxResult
            // 
            TextBoxResult.Location = new Point(632, 348);
            TextBoxResult.Name = "TextBoxResult";
            TextBoxResult.ReadOnly = true;
            TextBoxResult.Size = new Size(100, 23);
            TextBoxResult.TabIndex = 2;
            // 
            // Info
            // 
            Info.Location = new Point(549, 393);
            Info.Name = "Info";
            Info.Size = new Size(47, 41);
            Info.TabIndex = 3;
            Info.Text = "?";
            Info.UseVisualStyleBackColor = true;
            Info.Click += buttonInfo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 285);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 4;
            label1.Text = "Введите значение X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(662, 330);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Ответ:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(275, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(513, 135);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Info);
            Controls.Add(TextBoxResult);
            Controls.Add(buttonCalc);
            Controls.Add(textBoxX);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxX;
        private Button buttonCalc;
        private TextBox TextBoxResult;
        private Button Info;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
