using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
            InitialNS.Items.AddRange(PossibleNS);
            DestinationNS.Items.AddRange(PossibleNS);
            InitialNumber.KeyPress += InitialNumber_KeyPress;
        }

        private static readonly object[] PossibleNS = { 2, 3, 8, 9, 10, 16 };

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

        bool IsControl(char c)
        {
            return char.IsControl(c) || new[] { '-', ',', ' ', '.' }.Contains(c);
        }

        private void InitialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (InitialNS.SelectedItem == null)
                return;

            switch ((int)InitialNS.SelectedItem)
            {
                case 2:
                {
                    if (!(new[] { '0', '1' }.Contains(e.KeyChar) || IsControl(e.KeyChar)))
                        e.Handled = true;
                }
                    break;

                case 3:
                {
                    if (!(new[] { '0', '1', '2' }.Contains(e.KeyChar) || IsControl(e.KeyChar)))
                        e.Handled = true;
                }
                    break;

                case 8:
                {
                    if (!(char.IsDigit(e.KeyChar) || IsControl(e.KeyChar)))
                        e.Handled = true;
                    else if (new[] { '8', '9' }.Contains(e.KeyChar))
                        e.Handled = true;
                }
                    break;

                case 9:
                {
                    if (!(char.IsDigit(e.KeyChar) || IsControl(e.KeyChar)))
                        e.Handled = true;
                    else if (e.KeyChar == '9')
                        e.Handled = true;
                }
                    break;

                case 10:
                {
                    if (!(char.IsDigit(e.KeyChar) || IsControl(e.KeyChar)))
                        e.Handled = true;
                }
                    break;

                case 16:
                {
                    if (!(char.IsDigit(e.KeyChar)
                          || IsControl(e.KeyChar)
                          || new[] { 'a', 'b', 'c', 'd', 'e', 'f' }.Contains(e.KeyChar.ToString().ToLower()[0])))
                        e.Handled = true;
                }
                    break;
            }

            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                e.Handled = true;
                DoAction_Click(sender, e);
            }
        }

        private void DoAction_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream("programme.log.txt", FileMode.OpenOrCreate))
            {
                fs.Position = fs.Length;
                using (var w = new StreamWriter(fs, Encoding.Unicode))
                {
                    w.WriteLine("\n");
                    w.WriteLine("Input Number: {0}", InitialNumber.Text);
                    w.WriteLine("Input Number System: {0}", InitialNS.SelectedItem);
                    w.WriteLine("Destination Number System: {0}", DestinationNS.SelectedItem);
                    try
                    {
                        var p = new Calc((int)InitialNS.SelectedItem, (int)DestinationNS.SelectedItem,
                            InitialNumber.Text);

                        DestinationNumber.Text = p.Convert();
                        w.WriteLine("Result: {0}", DestinationNumber.Text);
                    }
                    catch (Exception ex)
                    {
                        w.WriteLine(ex.Message);
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void NS_Selected(object sender, EventArgs e)
        {
            if (InitialNS.SelectedIndex != -1 && DestinationNS.SelectedIndex != -1)
            {
                DoAction.Enabled = true;
                InitialNumber.ReadOnly = false;
            }
        }
    }
}