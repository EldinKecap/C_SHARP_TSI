/*
 * Created by SharpDevelop.
 * User: Boris
 * Date: 27. 6. 2022.
 * Time: 00:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace imePrezimeTextBoxes
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
			this.imeTextBox = new System.Windows.Forms.TextBox();
			this.prezimeTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// imeTextBox
			// 
			this.imeTextBox.Location = new System.Drawing.Point(41, 45);
			this.imeTextBox.Name = "imeTextBox";
			this.imeTextBox.Size = new System.Drawing.Size(100, 20);
			this.imeTextBox.TabIndex = 0;
			// 
			// prezimeTextBox
			// 
			this.prezimeTextBox.Location = new System.Drawing.Point(147, 45);
			this.prezimeTextBox.Name = "prezimeTextBox";
			this.prezimeTextBox.Size = new System.Drawing.Size(100, 20);
			this.prezimeTextBox.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 105);
			this.Controls.Add(this.prezimeTextBox);
			this.Controls.Add(this.imeTextBox);
			this.Name = "MainForm";
			this.Text = "imePrezimeTextBoxes";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox prezimeTextBox;
		private System.Windows.Forms.TextBox imeTextBox;
	}
}
