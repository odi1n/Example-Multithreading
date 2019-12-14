/*
 * Created by SharpDevelop.
 * User: David
 * Date: 01.03.2018
 * Time: 10:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TestThread
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox TBLog;
		private System.Windows.Forms.NumericUpDown NumericThreadCount;
		private System.Windows.Forms.Label label1;
		
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
			this.btnStart = new System.Windows.Forms.Button();
			this.TBLog = new System.Windows.Forms.TextBox();
			this.NumericThreadCount = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.NumericThreadCount)).BeginInit();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(12, 342);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(273, 41);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
			// 
			// TBLog
			// 
			this.TBLog.Location = new System.Drawing.Point(12, 12);
			this.TBLog.Multiline = true;
			this.TBLog.Name = "TBLog";
			this.TBLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TBLog.Size = new System.Drawing.Size(662, 324);
			this.TBLog.TabIndex = 1;
			// 
			// NumericThreadCount
			// 
			this.NumericThreadCount.Location = new System.Drawing.Point(440, 354);
			this.NumericThreadCount.Minimum = new decimal(new int[] {
			5,
			0,
			0,
			0});
			this.NumericThreadCount.Name = "NumericThreadCount";
			this.NumericThreadCount.Size = new System.Drawing.Size(54, 20);
			this.NumericThreadCount.TabIndex = 2;
			this.NumericThreadCount.Value = new decimal(new int[] {
			5,
			0,
			0,
			0});
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(334, 356);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Кол-во потоков";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 395);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NumericThreadCount);
			this.Controls.Add(this.TBLog);
			this.Controls.Add(this.btnStart);
			this.Name = "MainForm";
			this.Text = "TestThread";
			((System.ComponentModel.ISupportInitialize)(this.NumericThreadCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
