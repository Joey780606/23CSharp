namespace MyStudyForLauncher
{
    /*******************
     * Author: Joey yang
     * Initial date: 2023/08/17
     * 
     * Reference website:
     * 1. https://www.youtube.com/watch?v=MnTS7R3wkYg
     * 
     * 
     ******************/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3FlowLayoutPanel form3 = new Form3FlowLayoutPanel();
            form3.Show();

            this.Hide();
        }

        private void btnGetFileIcon_Click(object sender, EventArgs e)
        {
            Form4FileIcon form4 = new Form4FileIcon();
            form4.Show();

            this.Hide();
        }
    }
}