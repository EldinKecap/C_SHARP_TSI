/*
 * Created by SharpDevelop.
 * User: Boris
 * Date: 25/06/2022
 * Time: 13:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace helloWorld
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
			
			string messageHelloWorld = "Hello World";
			
			ispisTextBox.Text = messageHelloWorld;
			
			string newMessage;
			newMessage = "Zdravo Svijete";
			
			ispisTextBox.Text = newMessage;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
