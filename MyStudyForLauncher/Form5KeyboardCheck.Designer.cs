namespace MyStudyForLauncher
{
    partial class Form5KeyboardCheck
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
            label_keyDownValue = new Label();
            label2 = new Label();
            label_keyUpValue = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 15);
            label1.TabIndex = 0;
            label1.Text = "The keyboard you keyDown is:";
            // 
            // label_keyDownValue
            // 
            label_keyDownValue.AutoSize = true;
            label_keyDownValue.Location = new Point(284, 33);
            label_keyDownValue.Margin = new Padding(2, 0, 2, 0);
            label_keyDownValue.Name = "label_keyDownValue";
            label_keyDownValue.Size = new Size(0, 15);
            label_keyDownValue.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 66);
            label2.Name = "label2";
            label2.Size = new Size(162, 15);
            label2.TabIndex = 2;
            label2.Text = "The keyboard you keyUp is:";
            // 
            // label_keyUpValue
            // 
            label_keyUpValue.AutoSize = true;
            label_keyUpValue.Location = new Point(284, 66);
            label_keyUpValue.Name = "label_keyUpValue";
            label_keyUpValue.Size = new Size(0, 15);
            label_keyUpValue.TabIndex = 3;
            // 
            // Form5KeyboardCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 355);
            Controls.Add(label_keyUpValue);
            Controls.Add(label2);
            Controls.Add(label_keyDownValue);
            Controls.Add(label1);
            KeyPreview = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form5KeyboardCheck";
            Text = "Form5KeyboardCheck";
            FormClosing += Form5KeyboardCheck_FormClosing;
            Load += Form5KeyboardCheck_Load;
            KeyDown += Form5KeyboardCheck_KeyDown;
            KeyUp += Form5KeyboardCheck_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_keyDownValue;
        private Label label2;
        private Label label_keyUpValue;
    }
}