// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BanManager // TypeDefIndex: 1377
{
	// Fields
	public static readonly int QuitBanLevel; // 0x0
	public static readonly int PartyBanLevel; // 0x4
	[CompilerGenerated]
	private bool <IsBan>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <BanLevel>k__BackingField; // 0x14
	[CompilerGenerated]
	private bool <IsItemBan>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsWideChatBan>k__BackingField; // 0x19
	[CompilerGenerated]
	private bool <IsPrivateMainte>k__BackingField; // 0x1A
	private SystemTextManager systemTextManager; // 0x20

	// Properties
	public bool IsBan { get; set; }
	public int BanLevel { get; set; }
	public bool IsItemBan { get; set; }
	public bool IsWideChatBan { get; set; }
	public bool IsPrivateMainte { get; set; }
	public bool IsSomeBan { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1FE16D4 Offset: 0x1FDD6D4 VA: 0x1FE16D4
	public bool get_IsBan() { }

	[CompilerGenerated]
	// RVA: 0x1FE16DC Offset: 0x1FDD6DC VA: 0x1FE16DC
	private void set_IsBan(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1FE16E8 Offset: 0x1FDD6E8 VA: 0x1FE16E8
	public int get_BanLevel() { }

	[CompilerGenerated]
	// RVA: 0x1FE16F0 Offset: 0x1FDD6F0 VA: 0x1FE16F0
	private void set_BanLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FE16F8 Offset: 0x1FDD6F8 VA: 0x1FE16F8
	public bool get_IsItemBan() { }

	[CompilerGenerated]
	// RVA: 0x1FE1700 Offset: 0x1FDD700 VA: 0x1FE1700
	private void set_IsItemBan(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1FE170C Offset: 0x1FDD70C VA: 0x1FE170C
	public bool get_IsWideChatBan() { }

	[CompilerGenerated]
	// RVA: 0x1FE1714 Offset: 0x1FDD714 VA: 0x1FE1714
	private void set_IsWideChatBan(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1FE1720 Offset: 0x1FDD720 VA: 0x1FE1720
	public bool get_IsPrivateMainte() { }

	[CompilerGenerated]
	// RVA: 0x1FE1728 Offset: 0x1FDD728 VA: 0x1FE1728
	private void set_IsPrivateMainte(bool value) { }

	// RVA: 0x1FE1734 Offset: 0x1FDD734 VA: 0x1FE1734
	public bool get_IsSomeBan() { }

	// RVA: 0x1FE175C Offset: 0x1FDD75C VA: 0x1FE175C
	public void InitializeBanSetting(OffenderData[] offenderList) { }

	// RVA: 0x1FE17C8 Offset: 0x1FDD7C8 VA: 0x1FE17C8
	public void UpdateBanSetting(OffenderData offender) { }

	[IteratorStateMachine(typeof(BanManager.<ShowPrisonBanMessage>d__27))]
	// RVA: 0x1FE1AE0 Offset: 0x1FDDAE0 VA: 0x1FE1AE0
	private IEnumerator ShowPrisonBanMessage(int level, int id, bool sendOperation) { }

	[IteratorStateMachine(typeof(BanManager.<ShowPrivateMaintenanceMessage>d__28))]
	// RVA: 0x1FE1B78 Offset: 0x1FDDB78 VA: 0x1FE1B78
	private IEnumerator ShowPrivateMaintenanceMessage(OffenderData offender) { }

	[IteratorStateMachine(typeof(BanManager.<ShowFunctionLimitMessage>d__29))]
	// RVA: 0x1FE1C50 Offset: 0x1FDDC50 VA: 0x1FE1C50
	public IEnumerator ShowFunctionLimitMessage() { }

	// RVA: 0x1FE1CE4 Offset: 0x1FDDCE4 VA: 0x1FE1CE4
	public void .ctor() { }

	// RVA: 0x1FE1CEC Offset: 0x1FDDCEC VA: 0x1FE1CEC
	private static void .cctor() { }
}
