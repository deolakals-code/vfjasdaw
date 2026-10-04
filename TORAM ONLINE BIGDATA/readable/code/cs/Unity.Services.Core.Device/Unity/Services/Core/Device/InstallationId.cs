// Assembly: Unity.Services.Core.Device.dll
// Namespace: Unity.Services.Core.Device
internal class InstallationId : IInstallationId, IServiceComponent // TypeDefIndex: 17911
{
	// Fields
	internal string Identifier; // 0x10
	internal IUserIdentifierProvider UnityAdsIdentifierProvider; // 0x18
	internal IUserIdentifierProvider UnityAnalyticsIdentifierProvider; // 0x20

	// Methods

	// RVA: 0x37A99E0 Offset: 0x37A59E0 VA: 0x37A99E0
	public void .ctor() { }

	// RVA: 0x37A9A9C Offset: 0x37A5A9C VA: 0x37A9A9C Slot: 4
	public string GetOrCreateIdentifier() { }

	// RVA: 0x37A9AC8 Offset: 0x37A5AC8 VA: 0x37A9AC8
	public void CreateIdentifier() { }

	// RVA: 0x37A9D74 Offset: 0x37A5D74 VA: 0x37A9D74
	private static string ReadIdentifierFromFile() { }

	// RVA: 0x37A9DE4 Offset: 0x37A5DE4 VA: 0x37A9DE4
	private static void WriteIdentifierToFile(string identifier) { }

	// RVA: 0x37A9DB8 Offset: 0x37A5DB8 VA: 0x37A9DB8
	private static string GenerateGuid() { }
}
