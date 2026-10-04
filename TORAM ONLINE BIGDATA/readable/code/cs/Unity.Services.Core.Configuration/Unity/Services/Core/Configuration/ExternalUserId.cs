// Assembly: Unity.Services.Core.Configuration.dll
// Namespace: Unity.Services.Core.Configuration
internal class ExternalUserId : IExternalUserId, IServiceComponent // TypeDefIndex: 17891
{
	// Properties
	public string UserId { get; }

	// Methods

	// RVA: 0x37A87B4 Offset: 0x37A47B4 VA: 0x37A87B4 Slot: 4
	public string get_UserId() { }

	// RVA: 0x37A8818 Offset: 0x37A4818 VA: 0x37A8818 Slot: 5
	public void add_UserIdChanged(Action<string> value) { }

	// RVA: 0x37A8884 Offset: 0x37A4884 VA: 0x37A8884 Slot: 6
	public void remove_UserIdChanged(Action<string> value) { }

	// RVA: 0x37A88F0 Offset: 0x37A48F0 VA: 0x37A88F0
	public void .ctor() { }
}
