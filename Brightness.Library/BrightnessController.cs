namespace Brightness.Library;

public class  BrightnessController : IBrightnessController
{
	private readonly Lazy<PhysicalMonitorBrightnessController> _lazyLoaderdController;

    public BrightnessController() => _lazyLoaderdController = new(() => new PhysicalMonitorBrightnessController());

	private PhysicalMonitorBrightnessController Controller => _lazyLoaderdController.Value;

    public uint Brightness 
	{
		get => Controller.Get();
		set => Controller.Set(value);
	}
}
