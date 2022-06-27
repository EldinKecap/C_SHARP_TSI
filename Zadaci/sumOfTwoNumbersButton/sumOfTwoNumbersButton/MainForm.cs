/*
 * Created by SharpDevelop.
 * User: Boris
 * Date: 27. 6. 2022.
 * Time: 00:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sumOfTwoNumbersButton
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
		
		void IspisiSumuButtonClick(object sender, EventArgs e)
		{
			int number1 = int.Parse(firstNumTextBox.Text);
			int number2 = int.Parse(secondNumTextBox.Text);
			
			string res = Convert.ToString(number1+number2);
			resultTextBox.Text = res;
		}
	}
}
