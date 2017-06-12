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
using System.IO;

namespace GroupTaskCalculator
{
    public partial class Form1: Form
    {
        private static object[] PossibleNS0 = { 2, 3, 8, 9, 10, 16 };
        private static object[] PossibleNS1 = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public Form1()
        {
            InitializeComponent();
            initialNS.Items.AddRange(PossibleNS0);
            destinationNS.Items.AddRange(PossibleNS0);
            initialNumber.KeyPress += InitialNumber_KeyPress;
        }
        private static readonly string log = "programme.log.txt";
        private readonly string logpath = Path.GetFullPath(log);
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var fs = new FileStream(log, FileMode.OpenOrCreate))
            {
                fs.Position = fs.Length;
                using (var w = new StreamWriter(fs, Encoding.Unicode))
                {
                    w.WriteLine("\n");
                    w.WriteLine("\n");
                    w.WriteLine("Open time: {0}", DateTime.Now);
                }
            }
        }

        private void InitialNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                InitialNumber_KeyPress(sender, (KeyPressEventArgs)e);
            }
            catch (Exception)
            {
            }
        }
        private static char[] cChars = new[] { '-', ',', ' ', '.' };
        private static string Nums = "0123456789abcdef";
        bool IsValid(char c, int NS)
        {
            char cc = c.ToString().ToLower()[0];
            return (Nums.IndexOf(cc) != -1 && Nums.IndexOf(cc) < NS) || char.IsControl(cc) || cChars.Contains(cc);
        }
        private void InitialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (initialNS.SelectedItem == null)
                return;

            if (!IsValid(e.KeyChar, (int)initialNS.SelectedItem))
                e.Handled = true;


            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                e.Handled = true;
                DoAction_Click(sender, e);
            }
        }

        private void NS_Selected(object sender, EventArgs e)
        {
            if (initialNS.SelectedIndex != -1 && destinationNS.SelectedIndex != -1)
            {
                swapNS.Enabled = true;
                doAction.Enabled = true;
                initialNumber.ReadOnly = false;
            }
        }
        private void DoAction_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream(log, FileMode.OpenOrCreate))
            {
                fs.Position = fs.Length;
                using (var w = new StreamWriter(fs, Encoding.Unicode))
                {
                    w.WriteLine("\n");
                    w.WriteLine(DateTime.UtcNow.TimeOfDay);
                    w.WriteLine("Input Number: {0}", initialNumber.Text);
                    w.WriteLine("Input Number System: {0}", initialNS.SelectedItem);
                    w.WriteLine("Destination Number System: {0}", destinationNS.SelectedItem);
                    try
                    {
                        var p = new Calc((int)initialNS.SelectedItem, (int)destinationNS.SelectedItem,
                            initialNumber.Text);

                        destinationNumber.Text = p.Convert();
                        w.WriteLine("Result: {0}", destinationNumber.Text);
                    }
                    catch (Exception ex)
                    {
                        w.WriteLine(ex.Message);
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void swapNS_Click(object sender, EventArgs e)
        {
            var s = initialNumber.Text;
            initialNumber.Text = destinationNumber.Text;
            destinationNumber.Text = s;

            var i1 = destinationNS.SelectedIndex;
            var i2 = initialNS.SelectedIndex;
            destinationNS.SelectedIndex = i2;
            initialNS.SelectedIndex = i1;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream(log, FileMode.Create))
            {
            }
        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc = new Process();
            proc.StartInfo = new ProcessStartInfo(logpath);
            proc.Start();
            Close();
            Dispose();
        }

        private void ChangeItems(object[] items)
        {
            initialNS.Items.Clear();
            initialNS.Items.AddRange(items);
            destinationNS.Items.Clear();
            destinationNS.Items.AddRange(items);
        }
        private void superModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeItems(PossibleNS1);
            superModeToolStripMenuItem.CheckState = CheckState.Checked;
            regularModeToolStripMenuItem.CheckState = CheckState.Unchecked;
        }
        private void regularModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeItems(PossibleNS1);
            regularModeToolStripMenuItem.CheckState = CheckState.Checked;
            superModeToolStripMenuItem.CheckState = CheckState.Unchecked;
        }
    }
}