/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 18.01.2016
 * Time: 10:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EyesRelax
{
	partial class Back
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.Label ltime1;
		public System.Windows.Forms.Label lbl_count;
		
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
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.ltime1 = new System.Windows.Forms.Label();
			this.lbl_count = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ltime1
			// 
			this.ltime1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.ltime1.AutoEllipsis = true;
			this.ltime1.BackColor = System.Drawing.Color.Transparent;
			this.ltime1.Dock = System.Windows.Forms.DockStyle.Right;
			this.ltime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ltime1.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.ltime1.ImageKey = "(none)";
			this.ltime1.Location = new System.Drawing.Point(-298, 0);
			this.ltime1.Name = "ltime1";
			this.ltime1.Size = new System.Drawing.Size(348, 50);
			this.ltime1.TabIndex = 0;
			this.ltime1.Text = "11";
			// 
			// lbl_count
			// 
			this.lbl_count.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.lbl_count.AutoEllipsis = true;
			this.lbl_count.BackColor = System.Drawing.Color.Transparent;
			this.lbl_count.Dock = System.Windows.Forms.DockStyle.Right;
			this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_count.ForeColor = System.Drawing.Color.Cyan;
			this.lbl_count.ImageKey = "(none)";
			this.lbl_count.Location = new System.Drawing.Point(-418, 0);
			this.lbl_count.Name = "lbl_count";
			this.lbl_count.Size = new System.Drawing.Size(120, 50);
			this.lbl_count.TabIndex = 1;
			this.lbl_count.Text = "10";
			// 
			// Back
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(50, 50);
			this.ControlBox = false;
			this.Controls.Add(this.lbl_count);
			this.Controls.Add(this.ltime1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Back";
			this.Opacity = 0.8D;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Back";
			this.TopMost = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);

		}
	}
}
