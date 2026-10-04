// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal class IdentityManager : IIdentityManager // TypeDefIndex: 17453
{
	// Fields
	private readonly IPlayerId m_PlayerId; // 0x10
	private readonly IExternalUserId m_ExternalIdProvider; // 0x18
	private readonly IPersistence m_Persistence; // 0x20
	private bool m_Initialized; // 0x28
	[CompilerGenerated]
	private string <UserId>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <InstallId>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <ExternalId>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <IsNewPlayer>k__BackingField; // 0x48
	[CompilerGenerated]
	private Action OnPlayerChanged; // 0x50

	// Properties
	public string UserId { get; set; }
	public string InstallId { get; set; }
	public string PlayerId { get; }
	public string ExternalId { get; set; }
	public bool IsNewPlayer { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37A34F4 Offset: 0x379F4F4 VA: 0x37A34F4 Slot: 4
	public string get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x37A34FC Offset: 0x379F4FC VA: 0x37A34FC
	private void set_UserId(string value) { }

	[CompilerGenerated]
	// RVA: 0x37A3504 Offset: 0x379F504 VA: 0x37A3504 Slot: 5
	public string get_InstallId() { }

	[CompilerGenerated]
	// RVA: 0x37A350C Offset: 0x379F50C VA: 0x37A350C
	private void set_InstallId(string value) { }

	// RVA: 0x37A3514 Offset: 0x379F514 VA: 0x37A3514 Slot: 6
	public string get_PlayerId() { }

	[CompilerGenerated]
	// RVA: 0x37A35C0 Offset: 0x379F5C0 VA: 0x37A35C0 Slot: 10
	public string get_ExternalId() { }

	[CompilerGenerated]
	// RVA: 0x37A35C8 Offset: 0x379F5C8 VA: 0x37A35C8
	private void set_ExternalId(string value) { }

	[CompilerGenerated]
	// RVA: 0x37A35D0 Offset: 0x379F5D0 VA: 0x37A35D0 Slot: 7
	public bool get_IsNewPlayer() { }

	[CompilerGenerated]
	// RVA: 0x37A35D8 Offset: 0x379F5D8 VA: 0x37A35D8
	private void set_IsNewPlayer(bool value) { }

	[CompilerGenerated]
	// RVA: 0x37A35E4 Offset: 0x379F5E4 VA: 0x37A35E4 Slot: 8
	public void add_OnPlayerChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x37A3680 Offset: 0x379F680 VA: 0x37A3680 Slot: 9
	public void remove_OnPlayerChanged(Action value) { }

	// RVA: 0x379C1F0 Offset: 0x37981F0 VA: 0x379C1F0
	public void .ctor(IInstallationId installId, IPlayerId playerId, IExternalUserId externalId, IPersistence persistence) { }

	// RVA: 0x37A371C Offset: 0x379F71C VA: 0x37A371C
	private void ExternalUserIdChanged(string newName) { }
}
