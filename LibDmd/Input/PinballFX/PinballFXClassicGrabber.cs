namespace LibDmd.Input.PinballFX
{
	public class PinballFXClassicGrabber : PinballFXGrabber
	{
		public override string Name { get; } = "Pinball FX Classic";

		protected override string GetProcessName()
		{
			return "Pinball FX Classic";
		}
	}
}
