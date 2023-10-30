namespace MyStudyForLauncher
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
            button1 = new Button();
            button2 = new Button();
            btnGetFileIcon = new Button();
            btnKeyId = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(194, 29);
            button1.TabIndex = 0;
            button1.Text = "ToPage2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 47);
            button2.Name = "button2";
            button2.Size = new Size(194, 29);
            button2.TabIndex = 1;
            button2.Text = "FlowLayoutPanel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnGetFileIcon
            // 
            btnGetFileIcon.Location = new Point(12, 82);
            btnGetFileIcon.Name = "btnGetFileIcon";
            btnGetFileIcon.Size = new Size(194, 29);
            btnGetFileIcon.TabIndex = 2;
            btnGetFileIcon.Text = "Get file icon";
            btnGetFileIcon.UseVisualStyleBackColor = true;
            btnGetFileIcon.Click += btnGetFileIcon_Click;
            // 
            // btnKeyId
            // 
            btnKeyId.Location = new Point(12, 117);
            btnKeyId.Name = "btnKeyId";
            btnKeyId.Size = new Size(194, 29);
            btnKeyId.TabIndex = 3;
            btnKeyId.TabStop = false;
            btnKeyId.Text = "Get keyboard id";
            btnKeyId.UseVisualStyleBackColor = true;
            btnKeyId.Click += btnKeyId_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 152);
            button3.Name = "button3";
            button3.Size = new Size(194, 29);
            button3.TabIndex = 4;
            button3.Text = "Get exe file";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 367);
            Controls.Add(button3);
            Controls.Add(btnKeyId);
            Controls.Add(btnGetFileIcon);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnGetFileIcon;
        private Button btnKeyId;
        private Button button3;
    }
}