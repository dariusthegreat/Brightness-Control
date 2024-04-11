using Brightness.Library;

namespace BrightnessControl
{
	public partial class Form1 : Form
	{
		private readonly IBrightnessController _brightnessController = new BrightnessController();

		public Form1() => InitializeComponent();

		private uint SelectedValue
		{
			get => InvokeRequired ? Invoke(new Func<uint>(() => SelectedValue)) : (uint)trackBar1.Value;
			set
			{
				if (InvokeRequired)
				{
					Invoke(new Action(() => SelectedValue = value));
					return;
				}

				trackBar1.Value = (int)value;
			}
		}

		private void Form1_Load(object sender, EventArgs e) => SelectedValue = _brightnessController.Brightness;

		private void OnTimer1Tick(object sender, EventArgs e)
		{
			_brightnessController.Brightness = SelectedValue;
			timer1.Stop();
		}

		private async void OnTrackBar1ValueChanged(object sender, EventArgs e)
		{
			timer1.Stop();
			await Task.Delay(TimeSpan.FromMilliseconds(timer1.Interval));
			timer1.Start();
		}

		private void OnForm1KeyDown(object sender, KeyEventArgs e) => OnKeyDownEvent(e);

		private void OnTrackBar1KeyDown(object sender, KeyEventArgs e) => OnKeyDownEvent(e);

		private void OnKeyDownEvent(KeyEventArgs eventArgs)
		{
			if (eventArgs.KeyCode is Keys.Escape or Keys.Enter)
				Close();
		}
	}
}
