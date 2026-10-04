// Assembly: AppsFlyer.dll
// Namespace: AppsFlyerSDK
public class AppsFlyerRequestEventArgs : EventArgs // TypeDefIndex: 17289
{
	// Fields
	[CompilerGenerated]
	private readonly int <statusCode>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <errorDescription>k__BackingField; // 0x18

	// Properties
	public int statusCode { get; }
	public string errorDescription { get; }

	// Methods

	// RVA: 0x16F51E8 Offset: 0x16F11E8 VA: 0x16F51E8
	public void .ctor(int code, string description) { }

	[CompilerGenerated]
	// RVA: 0x16FA3B0 Offset: 0x16F63B0 VA: 0x16FA3B0
	public int get_statusCode() { }

	[CompilerGenerated]
	// RVA: 0x16FA3B8 Offset: 0x16F63B8 VA: 0x16FA3B8
	public string get_errorDescription() { }
}
