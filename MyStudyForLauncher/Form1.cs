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
    }
}