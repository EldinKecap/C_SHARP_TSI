/*
 * Created by SharpDevelop.
 * User: Boris
 * Date: 25/06/2022
 * Time: 13:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace helloWorld
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
			this.ispisTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// ispisTextBox
			// 
			this.ispisTextBox.Location = new System.Drawing.Point(90, 72);
			this.ispisTextBox.Name = "ispisTextBox";
			this.ispisTextBox.ReadOnly = true;
			this.ispisTextBox.Size = new System.Drawing.Size(100, 22);
			this.ispisTextBox.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 152);
			this.Controls.Add(this.ispisTextBox);
			this.Name = "MainForm";
			this.Text = "helloWorld";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox ispisTextBox;
	}
}
