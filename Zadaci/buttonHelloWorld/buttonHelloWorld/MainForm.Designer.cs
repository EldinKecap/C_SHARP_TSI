/*
 * Created by SharpDevelop.
 * User: Boris
 * Date: 25/06/2022
 * Time: 14:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace buttonHelloWorld
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
			this.ispisButton = new System.Windows.Forms.Button();
			this.ispisTextbox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// ispisButton
			// 
			this.ispisButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ispisButton.Location = new System.Drawing.Point(98, 65);
			this.ispisButton.Name = "ispisButton";
			this.ispisButton.Size = new System.Drawing.Size(75, 33);
			this.ispisButton.TabIndex = 0;
			this.ispisButton.Text = "Button";
			this.ispisButton.UseVisualStyleBackColor = true;
			this.ispisButton.Click += new System.EventHandler(this.ispisiHelloWorld);
			// 
			// ispisTextbox
			// 
			this.ispisTextbox.Location = new System.Drawing.Point(86, 36);
			this.ispisTextbox.Name = "ispisTextbox";
			this.ispisTextbox.Size = new System.Drawing.Size(100, 22);
			this.ispisTextbox.TabIndex = 1;
			this.ispisTextbox.Text = "Hello World";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 119);
			this.Controls.Add(this.ispisTextbox);
			this.Controls.Add(this.ispisButton);
			this.Name = "MainForm";
			this.Text = "buttonHelloWorld";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox ispisTextbox;
		private System.Windows.Forms.Button ispisButton;
	}
}
