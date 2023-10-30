using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyStudyForLauncher
{
    public partial class Form6GetExe : Form
    {
        public Form6GetExe()
        {
            InitializeComponent();
        }

        private void btnGetExe_Click(object sender, EventArgs e)
        {
            string sourceDirectory = @"c:\";

            var findFiles = Directory.EnumerateFiles(sourceDirectory,
                "*.txt", SearchOption.AllDirectories);

            foreach (string currentFile in findFiles)
            {
                textBoxInfo.Text += currentFile + "\r\n";
            }

        }

        private void processValueNames(RegistryKey Key)
        { //function to process the valueNames for a given key
            string[] valuenames = Key.GetValueNames();
            if (valuenames == null || valuenames.Length <= 0) //has no values
                return;
            foreach (string valuename in valuenames)
            {
                object obj = Key.GetValue(valuename);
                // if (obj != null && valuename=="Path")
                if (obj != null && valuename == "")
                    textBoxInfo.Text += (Key.Name + " !" + valuename + "@ " + obj.ToString() + "\r\n"); //assuming the output to be in comboBox1 in string type
            }
            textBoxInfo.Text += "======\r\n";
        }

        public void OutputRegKey(RegistryKey Key)
        {
            try
            {
                string[] subkeynames = Key.GetSubKeyNames(); //means deeper folder
                if (subkeynames == null || subkeynames.Length <= 0)
                { //has no more subkey, process
                    processValueNames(Key);
                    return;
                }
                foreach (string keyname in subkeynames)
                { //has subkeys, go deeper
                    using (RegistryKey key2 = Key.OpenSubKey(keyname))
                        OutputRegKey(key2);
                }
                processValueNames(Key);
            }
            catch (Exception e)
            {
                //error, do something
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey registry = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths");
            if (registry == null)
                textBoxInfo.Text = "no data\r\n";
            else
                textBoxInfo.Text = "get data\r\n";
            OutputRegKey(registry);
        }
    }
}
