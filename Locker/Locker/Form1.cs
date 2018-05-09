using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locker
{
    public partial class Form1 : Form
    {
        private String[] unlockCodes = {"TigerOPS", "Bravo", "Ghemri" };

        public Form1()
        {
            InitializeComponent();
        }

        private void unlockApp()
        {
            foreach(String unlockCode in unlockCodes)
            {
                if (unlockBox.Text == unlockCode)
                {
                    statusLabel.Text = "Unlocked!";
                    unlockBox.Enabled = false;
                    unlockButton.Enabled = false;
                    return;
                }
            }
            MessageBox.Show("The unlock code is not valid.", "Invalid Code");
        }

        private void unlockButton_Click(object sender, EventArgs e)
        {
            unlockApp();
        }
    }
}
