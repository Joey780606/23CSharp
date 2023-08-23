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
 * 
 */
namespace MyStudyForLauncher
{
    public partial class Form4FileIcon : Form
    {
        public Form4FileIcon()
        {
            InitializeComponent();
        }

        public static Icon IconFromFilePath(string filePath)
        {
            var result = (Icon?)null;

            try
            {
                result = Icon.ExtractAssociatedIcon(filePath);
            }
            catch (System.Exception)
            {
                // swallow and return nothing. You could supply a default Icon here as well
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filePath = tbFileName.Text;
            var theIcon = IconFromFilePath(filePath);

            if (theIcon != null)
            {
                // Save it to disk, or do whatever you want with it.
                using (var stream = new System.IO.FileStream(@"c:\myfile.ico", System.IO.FileMode.CreateNew))
                {
                    theIcon.Save(stream);
                }
            }
        }
    }
}
