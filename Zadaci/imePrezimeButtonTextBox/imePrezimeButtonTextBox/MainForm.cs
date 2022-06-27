/*
 * Created by SharpDevelop.
 * User: Boris
 * Date: 27. 6. 2022.
 * Time: 00:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace imePrezimeButtonTextBox
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
			imePrezimeTextBox.Text = "Ime i prezime";
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void IspisImePrezimeButtonClick(object sender, EventArgs e)
		{
			imePrezimeTextBox.Text = "Boris Divkovic";
		}
	}
}
