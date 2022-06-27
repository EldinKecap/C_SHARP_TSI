/*
 * Created by SharpDevelop.
 * User: Boris
 * Date: 27. 6. 2022.
 * Time: 01:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace switchOperator
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
		
		void GetResultButtonClick(object sender, EventArgs e)
		{
			float firstNum = float.Parse(num1TextBox.Text);
			float secondNum = float.Parse(num2TextBox.Text);
			if(operatorTextBox.Text == "+")
				resultTextBox.Text = Convert.ToString(firstNum + secondNum);
			else if (operatorTextBox.Text == "-")
				resultTextBox.Text = Convert.ToString(firstNum - secondNum);
			else if (operatorTextBox.Text == "%")
				resultTextBox.Text = Convert.ToString(firstNum % secondNum);
			else if (operatorTextBox.Text == "/")
				resultTextBox.Text = Convert.ToString(firstNum / secondNum);
			else if (operatorTextBox.Text == "*")
				resultTextBox.Text = Convert.ToString(firstNum * secondNum);
			else 
				resultTextBox.Text = "NaN";
			
			switch(operatorTextBox.Text){
				case "+":
					resultTextBox.Text = Convert.ToString(firstNum + secondNum);
					break;
				case "-":
					resultTextBox.Text = Convert.ToString(firstNum - secondNum);
					break;
				case "%":
					resultTextBox.Text = Convert.ToString(firstNum % secondNum);
					break;
				case "/":
					resultTextBox.Text = Convert.ToString(firstNum / secondNum);
					break;
				case "*":
					resultTextBox.Text = Convert.ToString(firstNum * secondNum);
					break;
				default:
					resultTextBox.Text = Convert.ToString(firstNum + operatorTextBox.Text + secondNum);
					break;
			}
		}
	}
}
