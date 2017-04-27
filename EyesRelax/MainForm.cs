/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 16.01.2016
 * Time: 8:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace EyesRelax
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{

		private bool state=false;
		//private bool break_time=false;
		private int secons = 60;
		private int m1;
		private int m2;
		private string s;
		private string m;
		private Back frm = new Back();	
		private string path = "\""+Process.GetCurrentProcess().MainModule.FileName.ToString()+"\" -s";
		private Microsoft.Win32.RegistryKey hkey;
		
		//private bool autorun_state;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			string[] args = Environment.GetCommandLineArgs();
			
			InitializeComponent();
			//notifyIcon1.Visible = false;
			timer1.Interval = 1000;
			timer2.Interval = 1000;
			bInstall.Enabled=false;
			notifyIcon1.Visible= true;
			checkBox1.Checked= autorun_state;
			
			linkLabel1.Links[0].LinkData = linkLabel1.Text.ToString();
			linkLabel2.Links[0].LinkData = linkLabel2.Text.ToString();
			
			//checkBox2.Checked = break_time;
			groupBox3.Enabled = checkBox2.Checked;

            window_expanded = false;

			time(0);
			foreach(string arg in args)
			{
				if(arg.Equals("-s"))
				{
					m1=int.Parse(nW.Value.ToString());
					m2=int.Parse(nA.Value.ToString());
					
					m1-=1;
					m2-=1;
					timer1.Start();
					bInstall.Text="Saklamak";
					state=true;
					groupBox1.Enabled=false;					

					this.Hide();
				}
			}
			

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void NotifyIcon1MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Show();
	
		}

		void Timer1Tick(object sender, EventArgs e)
		{

			//int i=1;
			if(m1<=0&secons<=0)
			{
				timer1.Stop();				
				m2=int.Parse(nA.Value.ToString());
				m2-=1;
				timer2.Start();
				bInstall.Text="Stop";
				state=true;
				label3.ForeColor=Color.Red;
				secons=60;
				//Back frm = new Back();			
				frm.Show();
				
			}else
			{
				if(secons==0)
				{
					secons=59;
					s=":"+secons.ToString();
					m1-=1;
				}else
					secons-=1;
					
				if(secons<10)
					s=":0"+secons.ToString();
				else
					s=":"+secons.ToString();
				
				
				if(m1<10)
					m="0"+m1.ToString();
				else
					m=m1.ToString();
				
				if(m1==0)
					m="00";
				//i+=1;
				label3.Text = m+s;
			}
	
		}
		void NWValueChanged(object sender, EventArgs e)
		{
			if((nW.Value == 0) || (nA.Value == 0))
				bInstall.Enabled=false;
			else
				bInstall.Enabled=true;
		}
		void BInstallClick(object sender, EventArgs e)
		{
			time(1);
			if(!state)
			{
				m1=int.Parse(nW.Value.ToString());
				m2=int.Parse(nA.Value.ToString());
				
				m1-=1;
				m2-=1;
				timer1.Start();
				bInstall.Text="Stop";
				state=true;
				groupBox1.Enabled=false;
				secons=60;
				
			}else{
				timer1.Stop();
				timer2.Stop();
				state=false;
				bInstall.Text="Start";
				groupBox1.Enabled=true;
				secons=60;
			}

			
			//label3.Text = timer1.
		}
		void Timer2Tick(object sender, EventArgs e)
		{
			if(m2<=0&secons<=0)
			{
				timer2.Stop();
				
				m1=int.Parse(nW.Value.ToString());
				m1-=1;
				timer1.Start();
				//bInstall.Text="Start";
				state=true;
				label3.ForeColor=Color.Black;
				secons=60;
				notifyIcon1.Visible=true;
				frm.Hide();
				
			}else
			{
				//ltime1.Text = DateTime.Now.ToString("HH:m tt zz");
				frm.ltime1.Text = DateTime.Now.ToString("HH:mm");
				if(secons==0)
				{
					secons=59;
					s=":"+secons.ToString();
					m2-=1;
				}else
					secons-=1;
					
				if(secons<10)
					s=":0"+secons.ToString();
				else
					s=":"+secons.ToString();
				
				
				if(m2<10)
					m="0"+m2.ToString();
				else
					m=m2.ToString();
				
				if(m2==0)
					m="00";
				//i+=1;
				//label3.Text = m+s;
				frm.lbl_count.Text = m+s;
			}			
	
		}

		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if(state)
			{
				notifyIcon1.Visible= true;
				
				this.Hide();
				e.Cancel= true;
			}

		}
		void MnuShowClick(object sender, EventArgs e)
		{
			this.Show();
		}
		void ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			state=false;
			timer1.Stop();
			timer2.Stop();
			this.Close();
		}
		
		void autorun(bool b)
		{
			Microsoft.Win32.RegistryKey key;
			key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
			//ProcessStartInfo sts = new ProcessStartInfo();
			
			if(b)
			{
				//key.CreateSubKey("EyesRelax");
				key.SetValue("EyesRelax",path);
			}
			else
			{
				key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				key.DeleteValue("EyesRelax");
			}
			
		}
		void CheckBox1CheckStateChanged(object sender, EventArgs e)
		{
			autorun(checkBox1.Checked);
		}
		
		bool autorun_state
		{
		get	
			{		
				Microsoft.Win32.RegistryKey key;
				string val="";
				key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
				val = key.GetValue("EyesRelax",val="").ToString();
				if(!val.Equals(path))
					return false;
				else 
					return true;

		}
		}
		
		void time(int i)
		{
			Microsoft.Win32.RegistryKey hkey;			
			decimal v;
			hkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\EyesRelax");
			
			if(i==0)
			{
				v = decimal.Parse(hkey.GetValue("TimeToWork", v=0).ToString());
				if(v==0)
				{
					hkey.SetValue("TimeToWork","45");
					nW.Value=45;
					MessageBox.Show("Time to work is set 45 now","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}else
					nW.Value=v;
				
				v = decimal.Parse(hkey.GetValue("TimeToRelax", v=0).ToString());
				if(v==0)
				{
					hkey.SetValue("TimeToRelax","5");
					nA.Value=5;
					MessageBox.Show("Time to relax seted to 5 minutes default","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}else
					nA.Value=v;
				
				/*t = hkey.GetValue("BreakStart", v=0).ToString();
                int len = t.Length();
				decimal t1 = decimal.Parse(t.Substring(0,(t.IndexOf(":")-1));
                decimal t1 = decimal.Parse(t.Substring((t.IndexOf(":"),));*/
				if(v==0)
				{
					hkey.SetValue("TimeToRelax","5");
					nA.Value=5;
					MessageBox.Show("Time to relax seted to 5 minutes default","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}else
					nA.Value=v;
			}
			if(i==1)
			{
				hkey.SetValue("TimeToWork",nW.Value.ToString());
				hkey.SetValue("TimeToRelax",nA.Value.ToString());
			}

		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
			

		}
		void Button1Click(object sender, EventArgs e)
		{
			if(window_expanded)
			{
                window_expanded = false;
                this.Width = 285;

			}else
			{
                window_expanded = true;
				this.Width = 515;
			}			
		}
		
		bool window_expanded
		{
			get
			{
                if (this.Width > 285)
                {
                    this.button1.Text = ">";
                    return true;
                }
                else
                {
                    this.button1.Text = "<";
                    return false;
                }
					
			}

            set
            {
                checkBox2.Visible = value;
                groupBox3.Visible = value;

            }
		}
		
		bool break_time
		{

			
			get
			{
				hkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\EyesRelax");
				bool b = bool.Parse(hkey.GetValue("BreakTime").ToString());
				return b;				
			}
			
			set
			{
				hkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\EyesRelax");
				hkey.SetValue("BreakTime",value);
				
			}
		}
		
		void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
			break_time = checkBox2.Checked;
			groupBox3.Enabled = checkBox2.Checked;
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		/*void MainFormLoad(object sender, EventArgs e)
		{
			string arg = e.ToString();
			
			if(arg.Equals("h"))
				MessageBox.Show("-h",arg,MessageBoxButtons.OK,MessageBoxIcon.Information);
		}*/
	}
}
