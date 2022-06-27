/*
 * Created by SharpDevelop.
 * User: Boris
 * Date: 27. 6. 2022.
 * Time: 00:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace imePrezimeTextBoxes
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
			
			string imeString = "Boris";
			imeTextBox.Text = imeString;
			
			string prezimeString = "Divkovic";
			prezimeTextBox.Text = prezimeString;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
