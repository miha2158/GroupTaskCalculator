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
            this.initialNS = new System.Windows.Forms.ComboBox();
            this.destinationNS = new System.Windows.Forms.ComboBox();
            this.initialNumber = new System.Windows.Forms.TextBox();
            this.destinationNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doAction = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.regularModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swapNS = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // initialNS
            // 
            this.initialNS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.initialNS.FormattingEnabled = true;
            this.initialNS.Location = new System.Drawing.Point(12, 45);
            this.initialNS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.initialNS.Name = "initialNS";
            this.initialNS.Size = new System.Drawing.Size(140, 25);
            this.initialNS.TabIndex = 0;
            this.initialNS.SelectedIndexChanged += new System.EventHandler(this.NS_Selected);
            // 
            // destinationNS
            // 
            this.destinationNS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationNS.FormattingEnabled = true;
            this.destinationNS.Location = new System.Drawing.Point(15, 168);
            this.destinationNS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.destinationNS.Name = "destinationNS";
            this.destinationNS.Size = new System.Drawing.Size(140, 25);
            this.destinationNS.TabIndex = 2;
            this.destinationNS.SelectedIndexChanged += new System.EventHandler(this.NS_Selected);
            // 
            // initialNumber
            // 
            this.initialNumber.Location = new System.Drawing.Point(167, 45);
            this.initialNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.initialNumber.Multiline = true;
            this.initialNumber.Name = "initialNumber";
            this.initialNumber.ReadOnly = true;
            this.initialNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.initialNumber.Size = new System.Drawing.Size(389, 124);
            this.initialNumber.TabIndex = 3;
            this.initialNumber.TextChanged += new System.EventHandler(this.InitialNumber_TextChanged);
            // 
            // destinationNumber
            // 
            this.destinationNumber.Location = new System.Drawing.Point(12, 218);
            this.destinationNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.destinationNumber.Multiline = true;
            this.destinationNumber.Name = "destinationNumber";
            this.destinationNumber.ReadOnly = true;
            this.destinationNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.destinationNumber.Size = new System.Drawing.Size(544, 127);
            this.destinationNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Из";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Системы счисления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Систему счисления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "В";
            // 
            // doAction
            // 
            this.doAction.Enabled = false;
            this.doAction.Location = new System.Drawing.Point(167, 176);
            this.doAction.Name = "doAction";
            this.doAction.Size = new System.Drawing.Size(389, 38);
            this.doAction.TabIndex = 4;
            this.doAction.Text = "Перевести";
            this.doAction.UseVisualStyleBackColor = true;
            this.doAction.Click += new System.EventHandler(this.DoAction_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Точность ~ 10 знаков после запятой";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Лог";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.clearToolStripMenuItem.Text = "Очистить";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.viewToolStripMenuItem.Text = "Открыть";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularModeToolStripMenuItem,
            this.superModeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1.Text = "Режимы";
            // 
            // regularModeToolStripMenuItem
            // 
            this.regularModeToolStripMenuItem.Name = "regularModeToolStripMenuItem";
            this.regularModeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.regularModeToolStripMenuItem.Text = "Обычный режим";
            this.regularModeToolStripMenuItem.Click += new System.EventHandler(this.regularModeToolStripMenuItem_Click);
            // 
            // superModeToolStripMenuItem
            // 
            this.superModeToolStripMenuItem.Name = "superModeToolStripMenuItem";
            this.superModeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.superModeToolStripMenuItem.Text = "Супер режим";
            this.superModeToolStripMenuItem.Click += new System.EventHandler(this.superModeToolStripMenuItem_Click);
            // 
            // swapNS
            // 
            this.swapNS.Enabled = false;
            this.swapNS.Location = new System.Drawing.Point(12, 107);
            this.swapNS.Name = "swapNS";
            this.swapNS.Size = new System.Drawing.Size(140, 27);
            this.swapNS.TabIndex = 1;
            this.swapNS.Text = "Поменять↕";
            this.swapNS.UseVisualStyleBackColor = true;
            this.swapNS.Click += new System.EventHandler(this.swapNS_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(568, 357);
            this.Controls.Add(this.swapNS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.doAction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationNumber);
            this.Controls.Add(this.initialNumber);
            this.Controls.Add(this.destinationNS);
            this.Controls.Add(this.initialNS);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox initialNS;
        private System.Windows.Forms.ComboBox destinationNS;
        private System.Windows.Forms.TextBox initialNumber;
        private System.Windows.Forms.TextBox destinationNumber;
        private System.Windows.Forms.Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button doAction;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem superModeToolStripMenuItem;
        private ToolStripMenuItem regularModeToolStripMenuItem;
        private Button swapNS;
    }
}

