using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupTaskCalculator
{
    public partial class Form1 : Form
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
            /*string temp = InitialNumber.Text;

            InitialNumber.Text = temp
                .Replace("- ", "-")
                .Replace("--", "-")
                .Replace(",-", ",")
                .Replace(",,", ",")
                .Replace("-,", "-");*/
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
            return char.IsControl(c) || new[] { '-', ',', ' ' }.Contains(c);
        }

        private void InitialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (InitialNS.SelectedItem)
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
                    else
                        if (new[] { '8', '9' }.Contains(e.KeyChar))
                            e.Handled = true;
                }
                break;

                case 9:
                {
                    if (!(char.IsDigit(e.KeyChar) || IsControl(e.KeyChar)))
                        e.Handled = true;
                    else
                        if (e.KeyChar == '9')
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
                    if (!(char.IsDigit(e.KeyChar) || IsControl(e.KeyChar) || new[] { 'a','b','c','d','e','f' }.Contains(e.KeyChar.ToString().ToLower()[0])))
                        e.Handled = true;
                }
                break;
            }
        }

        private void InitialNS_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitialNumber.ReadOnly = false;
        }

        private void DoAction_Click(object sender, EventArgs e)
        {

        }

        private void DestinationNS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InitialNS.SelectedIndex != -1)
                DoAction.Enabled = true;
        }
    }
}
