/*
 * Created by SharpDevelop.
 * User: Boris
 * Date: 27. 6. 2022.
 * Time: 00:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace imePrezimeButtonTextBox
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
			this.ispisImePrezimeButton = new System.Windows.Forms.Button();
			this.imePrezimeTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// ispisImePrezimeButton
			// 
			this.ispisImePrezimeButton.Location = new System.Drawing.Point(89, 50);
			this.ispisImePrezimeButton.Name = "ispisImePrezimeButton";
			this.ispisImePrezimeButton.Size = new System.Drawing.Size(100, 39);
			this.ispisImePrezimeButton.TabIndex = 0;
			this.ispisImePrezimeButton.Text = "Ispisi ime i prezime";
			this.ispisImePrezimeButton.UseVisualStyleBackColor = true;
			this.ispisImePrezimeButton.Click += new System.EventHandler(this.IspisImePrezimeButtonClick);
			// 
			// imePrezimeTextBox
			// 
			this.imePrezimeTextBox.Location = new System.Drawing.Point(89, 24);
			this.imePrezimeTextBox.Name = "imePrezimeTextBox";
			this.imePrezimeTextBox.Size = new System.Drawing.Size(100, 20);
			this.imePrezimeTextBox.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 113);
			this.Controls.Add(this.imePrezimeTextBox);
			this.Controls.Add(this.ispisImePrezimeButton);
			this.Name = "MainForm";
			this.Text = "imePrezimeButtonTextBox";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox imePrezimeTextBox;
		private System.Windows.Forms.Button ispisImePrezimeButton;
	}
}
