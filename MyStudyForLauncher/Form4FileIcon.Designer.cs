namespace MyStudyForLauncher
{
    partial class Form4FileIcon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbFileName = new TextBox();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 0;
            label1.Text = "File name:";
            // 
            // tbFileName
            // 
            tbFileName.Location = new Point(123, 28);
            tbFileName.Name = "tbFileName";
            tbFileName.Size = new Size(319, 27);
            tbFileName.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(38, 74);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "找icon檔";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 122);
            label2.Name = "label2";
            label2.Size = new Size(123, 19);
            label2.TabIndex = 3;
            label2.Text = "icon檔會存在C槽";
            // 
            // Form4FileIcon
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(tbFileName);
            Controls.Add(label1);
            Name = "Form4FileIcon";
            Text = "Form4FileIcon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbFileName;
        private Button button1;
        private Label label2;
    }
}