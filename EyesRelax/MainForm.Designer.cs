/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 16.01.2016
 * Time: 8:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EyesRelax
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button bInstall;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.NumericUpDown nW;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nA;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnuShow;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.NumericUpDown time4;
		private System.Windows.Forms.NumericUpDown ntime3;
		private System.Windows.Forms.NumericUpDown time2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown ntime1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bInstall = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nW = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nA = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.time4 = new System.Windows.Forms.NumericUpDown();
            this.ntime3 = new System.Windows.Forms.NumericUpDown();
            this.time2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ntime1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntime3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntime1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "EyesRelax";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShow,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 76);
            // 
            // mnuShow
            // 
            this.mnuShow.Name = "mnuShow";
            this.mnuShow.Size = new System.Drawing.Size(145, 22);
            this.mnuShow.Text = "Settings";
            this.mnuShow.Click += new System.EventHandler(this.MnuShowClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem1.Text = "Skip this time";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2Click);
            // 
            // bInstall
            // 
            this.bInstall.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bInstall.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bInstall.FlatAppearance.BorderSize = 0;
            this.bInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInstall.Location = new System.Drawing.Point(153, 122);
            this.bInstall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bInstall.Name = "bInstall";
            this.bInstall.Size = new System.Drawing.Size(71, 33);
            this.bInstall.TabIndex = 0;
            this.bInstall.Text = "Start";
            this.bInstall.UseVisualStyleBackColor = false;
            this.bInstall.Click += new System.EventHandler(this.BInstallClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // nW
            // 
            this.nW.Location = new System.Drawing.Point(142, 31);
            this.nW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nW.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nW.Name = "nW";
            this.nW.Size = new System.Drawing.Size(58, 23);
            this.nW.TabIndex = 1;
            this.nW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nW.ValueChanged += new System.EventHandler(this.NWValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time to relax:";
            // 
            // nA
            // 
            this.nA.Location = new System.Drawing.Point(142, 63);
            this.nA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nA.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nA.Name = "nA";
            this.nA.Size = new System.Drawing.Size(58, 23);
            this.nA.TabIndex = 3;
            this.nA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nA.ValueChanged += new System.EventHandler(this.NWValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pause every:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nW);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(208, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time settings";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 34);
            this.label3.TabIndex = 1;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(16, 165);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 31);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Start with windows";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.CheckBox1CheckStateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(13, 205);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(241, 141);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About";
            // 
            // linkLabel2
            // 
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.Location = new System.Drawing.Point(9, 109);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(227, 22);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://github.com/myrat/eyesrelax";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Source code:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Version: v1.0.1\r\nIdea taken from:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(9, 61);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(219, 27);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.eyesrelax.narod.ru/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(232, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 81);
            this.button1.TabIndex = 4;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.time4);
            this.groupBox3.Controls.Add(this.ntime3);
            this.groupBox3.Controls.Add(this.time2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ntime1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(275, 47);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(214, 88);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // time4
            // 
            this.time4.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.time4.Location = new System.Drawing.Point(152, 54);
            this.time4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.time4.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.time4.Name = "time4";
            this.time4.Size = new System.Drawing.Size(47, 23);
            this.time4.TabIndex = 2;
            this.time4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ntime3
            // 
            this.ntime3.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ntime3.Location = new System.Drawing.Point(98, 54);
            this.ntime3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ntime3.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.ntime3.Name = "ntime3";
            this.ntime3.Size = new System.Drawing.Size(46, 23);
            this.ntime3.TabIndex = 1;
            this.ntime3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // time2
            // 
            this.time2.Location = new System.Drawing.Point(152, 22);
            this.time2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.time2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(47, 23);
            this.time2.TabIndex = 2;
            this.time2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "End time:";
            // 
            // ntime1
            // 
            this.ntime1.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ntime1.Location = new System.Drawing.Point(98, 22);
            this.ntime1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ntime1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.ntime1.Name = "ntime1";
            this.ntime1.Size = new System.Drawing.Size(46, 23);
            this.ntime1.TabIndex = 1;
            this.ntime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Start time:";
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(275, 15);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(199, 31);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Break time(ToDo)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 356);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bInstall);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.time4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntime3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntime1)).EndInit();
            this.ResumeLayout(false);

		}
	}
}