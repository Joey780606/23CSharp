﻿namespace MyStudyForLauncher
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 301);
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
    }
}