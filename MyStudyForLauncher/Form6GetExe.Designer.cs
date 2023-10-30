namespace MyStudyForLauncher
{
    partial class Form6GetExe
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
            btnGetExe = new Button();
            textBoxInfo = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnGetExe
            // 
            btnGetExe.Location = new Point(9, 9);
            btnGetExe.Margin = new Padding(2, 2, 2, 2);
            btnGetExe.Name = "btnGetExe";
            btnGetExe.Size = new Size(73, 23);
            btnGetExe.TabIndex = 0;
            btnGetExe.Text = "Get exe file";
            btnGetExe.UseVisualStyleBackColor = true;
            btnGetExe.Click += btnGetExe_Click;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(9, 44);
            textBoxInfo.Margin = new Padding(2, 2, 2, 2);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.Size = new Size(1111, 410);
            textBoxInfo.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(87, 9);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 2;
            button1.Text = "RegistryTest";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form6GetExe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 465);
            Controls.Add(button1);
            Controls.Add(textBoxInfo);
            Controls.Add(btnGetExe);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form6GetExe";
            Text = "Form6GetExe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetExe;
        private TextBox textBoxInfo;
        private Button button1;
    }
}