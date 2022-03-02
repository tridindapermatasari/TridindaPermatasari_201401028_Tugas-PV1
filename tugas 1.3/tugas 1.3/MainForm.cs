using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugas_1._
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void InsertbarangClick(object sender, EventArgs e)
		{
			listbarang.Items.Add(teksbarang.Text);
			teksbarang.Clear();
			teksbarang.Focus();
			
		}
	}
}
