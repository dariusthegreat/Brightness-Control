namespace BrightnessControl
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			trackBar1 = new TrackBar();
			timer1 = new System.Windows.Forms.Timer(components);
			((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
			SuspendLayout();
			// 
			// trackBar1
			// 
			trackBar1.Location = new Point(12, 12);
			trackBar1.Maximum = 100;
			trackBar1.Name = "trackBar1";
			trackBar1.Size = new Size(783, 45);
			trackBar1.TabIndex = 0;
			trackBar1.TickStyle = TickStyle.Both;
			trackBar1.ValueChanged += OnTrackBar1ValueChanged;
			trackBar1.KeyDown += OnTrackBar1KeyDown;
			// 
			// timer1
			// 
			timer1.Interval = 200;
			timer1.Tick += OnTimer1Tick;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 73);
			Controls.Add(trackBar1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "Form1";
			Text = "Monitor Brightness Control";
			Load += Form1_Load;
			KeyDown += OnForm1KeyDown;
			((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TrackBar trackBar1;
		private System.Windows.Forms.Timer timer1;
	}
}
