/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 18.01.2016
 * Time: 10:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EyesRelax
{
	/// <summary>
	/// Description of Back.
	/// </summary>
	public partial class Back : Form
	{
		public Back()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.Bounds = Screen.PrimaryScreen.Bounds;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
