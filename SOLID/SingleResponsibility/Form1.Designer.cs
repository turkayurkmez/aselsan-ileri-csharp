namespace SingleResponsibility
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
            buttonCreate = new Button();
            textBoxProductName = new TextBox();
            textBoxPrice = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(132, 208);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(94, 29);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Ekle";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(101, 130);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(125, 27);
            textBoxProductName.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(101, 163);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(125, 27);
            textBoxPrice.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(212, 295);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 348);
            Controls.Add(button1);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxProductName);
            Controls.Add(buttonCreate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreate;
        private TextBox textBoxProductName;
        private TextBox textBoxPrice;
        private Button button1;
    }
}
