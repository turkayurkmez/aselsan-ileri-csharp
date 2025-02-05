namespace SimpleThreads
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            labelSyncCounter = new Label();
            buttonSenkronStart = new Button();
            groupBox2 = new GroupBox();
            labelAsyncCounter = new Label();
            buttonAsyncStart = new Button();
            groupBox3 = new GroupBox();
            progressBar1 = new ProgressBar();
            labelTask = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelSyncCounter);
            groupBox1.Controls.Add(buttonSenkronStart);
            groupBox1.Location = new Point(46, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 243);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senkron";
            // 
            // labelSyncCounter
            // 
            labelSyncCounter.AutoSize = true;
            labelSyncCounter.Location = new Point(94, 129);
            labelSyncCounter.Name = "labelSyncCounter";
            labelSyncCounter.Size = new Size(50, 20);
            labelSyncCounter.TabIndex = 1;
            labelSyncCounter.Text = "label1";
            // 
            // buttonSenkronStart
            // 
            buttonSenkronStart.Location = new Point(41, 81);
            buttonSenkronStart.Name = "buttonSenkronStart";
            buttonSenkronStart.Size = new Size(158, 29);
            buttonSenkronStart.TabIndex = 0;
            buttonSenkronStart.Text = "Senkron Start";
            buttonSenkronStart.UseVisualStyleBackColor = true;
            buttonSenkronStart.Click += buttonSenkronStart_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelAsyncCounter);
            groupBox2.Controls.Add(buttonAsyncStart);
            groupBox2.Location = new Point(352, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 243);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Asenkron";
            // 
            // labelAsyncCounter
            // 
            labelAsyncCounter.AutoSize = true;
            labelAsyncCounter.Location = new Point(94, 129);
            labelAsyncCounter.Name = "labelAsyncCounter";
            labelAsyncCounter.Size = new Size(50, 20);
            labelAsyncCounter.TabIndex = 1;
            labelAsyncCounter.Text = "label1";
            // 
            // buttonAsyncStart
            // 
            buttonAsyncStart.Location = new Point(41, 81);
            buttonAsyncStart.Name = "buttonAsyncStart";
            buttonAsyncStart.Size = new Size(158, 29);
            buttonAsyncStart.TabIndex = 0;
            buttonAsyncStart.Text = "Asenkron Start";
            buttonAsyncStart.UseVisualStyleBackColor = true;
            buttonAsyncStart.Click += buttonAsyncStart_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(progressBar1);
            groupBox3.Controls.Add(labelTask);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(663, 57);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(276, 243);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Task";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(60, 168);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(125, 29);
            progressBar1.TabIndex = 2;
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(94, 129);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(50, 20);
            labelTask.TabIndex = 1;
            labelTask.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(41, 81);
            button1.Name = "button1";
            button1.Size = new Size(158, 29);
            button1.TabIndex = 0;
            button1.Text = "Task Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(1084, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(220, 264);
            listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 450);
            Controls.Add(listBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelSyncCounter;
        private Button buttonSenkronStart;
        private GroupBox groupBox2;
        private Label labelAsyncCounter;
        private Button buttonAsyncStart;
        private GroupBox groupBox3;
        private Label labelTask;
        private Button button1;
        private ProgressBar progressBar1;
        private ListBox listBox1;
    }
}
