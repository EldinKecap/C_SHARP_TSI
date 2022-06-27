/*
 * Created by SharpDevelop.
 * User: Boris
 * Date: 27. 6. 2022.
 * Time: 01:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ifElseOperators
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.num1TextBox = new System.Windows.Forms.TextBox();
			this.operatorTextBox = new System.Windows.Forms.TextBox();
			this.num2TextBox = new System.Windows.Forms.TextBox();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.getResultButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// num1TextBox
			// 
			this.num1TextBox.Location = new System.Drawing.Point(13, 51);
			this.num1TextBox.Name = "num1TextBox";
			this.num1TextBox.Size = new System.Drawing.Size(46, 20);
			this.num1TextBox.TabIndex = 0;
			// 
			// operatorTextBox
			// 
			this.operatorTextBox.Location = new System.Drawing.Point(74, 51);
			this.operatorTextBox.Name = "operatorTextBox";
			this.operatorTextBox.Size = new System.Drawing.Size(46, 20);
			this.operatorTextBox.TabIndex = 1;
			// 
			// num2TextBox
			// 
			this.num2TextBox.Location = new System.Drawing.Point(136, 51);
			this.num2TextBox.Name = "num2TextBox";
			this.num2TextBox.Size = new System.Drawing.Size(46, 20);
			this.num2TextBox.TabIndex = 2;
			// 
			// resultTextBox
			// 
			this.resultTextBox.Location = new System.Drawing.Point(235, 51);
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.ReadOnly = true;
			this.resultTextBox.Size = new System.Drawing.Size(51, 20);
			this.resultTextBox.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Num 1:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(136, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Num 2:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(74, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Operator";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(235, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "Rezultat";
			// 
			// getResultButton
			// 
			this.getResultButton.Location = new System.Drawing.Point(198, 51);
			this.getResultButton.Name = "getResultButton";
			this.getResultButton.Size = new System.Drawing.Size(21, 20);
			this.getResultButton.TabIndex = 9;
			this.getResultButton.Text = "=";
			this.getResultButton.UseVisualStyleBackColor = true;
			this.getResultButton.Click += new System.EventHandler(this.GetResultButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 102);
			this.Controls.Add(this.getResultButton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.num2TextBox);
			this.Controls.Add(this.operatorTextBox);
			this.Controls.Add(this.num1TextBox);
			this.Name = "MainForm";
			this.Text = "ifElseOperators";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button getResultButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox resultTextBox;
		private System.Windows.Forms.TextBox num2TextBox;
		private System.Windows.Forms.TextBox operatorTextBox;
		private System.Windows.Forms.TextBox num1TextBox;
	}
}
