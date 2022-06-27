/*
 * Created by SharpDevelop.
 * User: Boris
 * Date: 27. 6. 2022.
 * Time: 00:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sumOfTwoNumbersButton
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
			this.ispisiSumuButton = new System.Windows.Forms.Button();
			this.firstNumTextBox = new System.Windows.Forms.TextBox();
			this.secondNumTextBox = new System.Windows.Forms.TextBox();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ispisiSumuButton
			// 
			this.ispisiSumuButton.Location = new System.Drawing.Point(184, 45);
			this.ispisiSumuButton.Name = "ispisiSumuButton";
			this.ispisiSumuButton.Size = new System.Drawing.Size(27, 22);
			this.ispisiSumuButton.TabIndex = 0;
			this.ispisiSumuButton.Text = "=";
			this.ispisiSumuButton.UseVisualStyleBackColor = true;
			this.ispisiSumuButton.Click += new System.EventHandler(this.IspisiSumuButtonClick);
			// 
			// firstNumTextBox
			// 
			this.firstNumTextBox.Location = new System.Drawing.Point(51, 46);
			this.firstNumTextBox.Name = "firstNumTextBox";
			this.firstNumTextBox.Size = new System.Drawing.Size(46, 20);
			this.firstNumTextBox.TabIndex = 1;
			// 
			// secondNumTextBox
			// 
			this.secondNumTextBox.Location = new System.Drawing.Point(119, 47);
			this.secondNumTextBox.Name = "secondNumTextBox";
			this.secondNumTextBox.Size = new System.Drawing.Size(46, 20);
			this.secondNumTextBox.TabIndex = 2;
			// 
			// resultTextBox
			// 
			this.resultTextBox.Location = new System.Drawing.Point(230, 46);
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.ReadOnly = true;
			this.resultTextBox.Size = new System.Drawing.Size(46, 20);
			this.resultTextBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(103, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(10, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "+";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(338, 113);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.secondNumTextBox);
			this.Controls.Add(this.firstNumTextBox);
			this.Controls.Add(this.ispisiSumuButton);
			this.Name = "MainForm";
			this.Text = "sumOfTwoNumbersButton";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox resultTextBox;
		private System.Windows.Forms.TextBox secondNumTextBox;
		private System.Windows.Forms.TextBox firstNumTextBox;
		private System.Windows.Forms.Button ispisiSumuButton;
	}
}
