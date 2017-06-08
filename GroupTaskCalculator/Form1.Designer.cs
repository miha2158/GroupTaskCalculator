using System.Windows.Forms;

namespace GroupTaskCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent()
        {
            this.InitialNS = new System.Windows.Forms.ComboBox();
            this.DestinationNS = new System.Windows.Forms.ComboBox();
            this.InitialNumber = new System.Windows.Forms.TextBox();
            this.DestinationNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DoAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InitialNS
            // 
            this.InitialNS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InitialNS.FormattingEnabled = true;
            this.InitialNS.Location = new System.Drawing.Point(14, 38);
            this.InitialNS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InitialNS.Name = "InitialNS";
            this.InitialNS.Size = new System.Drawing.Size(140, 25);
            this.InitialNS.TabIndex = 0;
            this.InitialNS.SelectedIndexChanged += new System.EventHandler(this.NS_Selected);
            // 
            // DestinationNS
            // 
            this.DestinationNS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestinationNS.FormattingEnabled = true;
            this.DestinationNS.Location = new System.Drawing.Point(14, 116);
            this.DestinationNS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DestinationNS.Name = "DestinationNS";
            this.DestinationNS.Size = new System.Drawing.Size(140, 25);
            this.DestinationNS.TabIndex = 1;
            this.DestinationNS.SelectedIndexChanged += new System.EventHandler(this.NS_Selected);
            // 
            // InitialNumber
            // 
            this.InitialNumber.Location = new System.Drawing.Point(167, 38);
            this.InitialNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InitialNumber.Multiline = true;
            this.InitialNumber.Name = "InitialNumber";
            this.InitialNumber.ReadOnly = true;
            this.InitialNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InitialNumber.Size = new System.Drawing.Size(389, 124);
            this.InitialNumber.TabIndex = 2;
            this.InitialNumber.TextChanged += new System.EventHandler(this.InitialNumber_TextChanged);
            // 
            // DestinationNumber
            // 
            this.DestinationNumber.Location = new System.Drawing.Point(17, 211);
            this.DestinationNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DestinationNumber.Multiline = true;
            this.DestinationNumber.Name = "DestinationNumber";
            this.DestinationNumber.ReadOnly = true;
            this.DestinationNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DestinationNumber.Size = new System.Drawing.Size(539, 127);
            this.DestinationNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Из";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Системы счисления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Систему счисления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "В";
            // 
            // DoAction
            // 
            this.DoAction.Enabled = false;
            this.DoAction.Location = new System.Drawing.Point(17, 166);
            this.DoAction.Name = "DoAction";
            this.DoAction.Size = new System.Drawing.Size(539, 38);
            this.DoAction.TabIndex = 8;
            this.DoAction.Text = "Перевести";
            this.DoAction.UseVisualStyleBackColor = true;
            this.DoAction.Click += new System.EventHandler(this.DoAction_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(568, 351);
            this.Controls.Add(this.DoAction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DestinationNumber);
            this.Controls.Add(this.InitialNumber);
            this.Controls.Add(this.DestinationNS);
            this.Controls.Add(this.InitialNS);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox InitialNS;
        private System.Windows.Forms.ComboBox DestinationNS;
        private System.Windows.Forms.TextBox InitialNumber;
        private System.Windows.Forms.TextBox DestinationNumber;
        private System.Windows.Forms.Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button DoAction;
    }
}

