using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 1. Author: Joey yang
 * 2. Reference document: 
 *   a. https://stackoverflow.com/questions/51380900/keyup-event-not-working-winform
 *   b. InitializeComponent();
 */
namespace MyStudyForLauncher
{
    public partial class Form5KeyboardCheck : Form
    {
        public Form5KeyboardCheck()
        {
            InitializeComponent();  //在 Form5KeyboardCheck.Designer.cs 裡,很重要 

        }

        private void Form5KeyboardCheck_Load(object sender, EventArgs e)
        {

        }

        private void Form5KeyboardCheck_KeyDown(object sender, KeyEventArgs e)
        {
            label_keyDownValue.Text = e.KeyCode.ToString() + " === " + e.Modifiers.ToString() + " === " + e.KeyValue;
        }

        private void Form5KeyboardCheck_KeyUp(object sender, KeyEventArgs e)
        {
            label_keyUpValue.Text = e.KeyCode.ToString() + " === " + e.Modifiers.ToString() + " === " + e.KeyValue;
        }

        private void Form5KeyboardCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //this.WindowState = FormWindowState.Minimized;
            //this.Close();
            Program.form1.Show();
        }
    }
}
