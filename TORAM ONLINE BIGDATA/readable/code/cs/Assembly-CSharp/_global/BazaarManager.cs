// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BazaarManager // TypeDefIndex: 1726
{
	// Fields
	private BazaarData bazaarData; // 0x10
	[CompilerGenerated]
	private bool <IsEnabled>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsAleadyNotifiedEnable>k__BackingField; // 0x19
	[CompilerGenerated]
	private bool <IsConnect>k__BackingField; // 0x1A
	private const string KEY_ENABLED = "BAZAAR";

	// Properties
	public BazaarData BazaarData { get; set; }
	public bool IsEnabled { get; set; }
	public bool IsAleadyNotifiedEnable { get; set; }
	public bool IsConnect { get; set; }

	// Methods

	// RVA: 0x20AF4F4 Offset: 0x20AB4F4 VA: 0x20AF4F4
	public BazaarData get_BazaarData() { }

	// RVA: 0x20AF4FC Offset: 0x20AB4FC VA: 0x20AF4FC
	private void set_BazaarData(BazaarData value) { }

	[CompilerGenerated]
	// RVA: 0x20AF5DC Offset: 0x20AB5DC VA: 0x20AF5DC
	public bool get_IsEnabled() { }

	[CompilerGenerated]
	// RVA: 0x20AF5E4 Offset: 0x20AB5E4 VA: 0x20AF5E4
	private void set_IsEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x20AF5F0 Offset: 0x20AB5F0 VA: 0x20AF5F0
	public bool get_IsAleadyNotifiedEnable() { }

	[CompilerGenerated]
	// RVA: 0x20AF5F8 Offset: 0x20AB5F8 VA: 0x20AF5F8
	private void set_IsAleadyNotifiedEnable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x20AF604 Offset: 0x20AB604 VA: 0x20AF604
	public bool get_IsConnect() { }

	[CompilerGenerated]
	// RVA: 0x20AF60C Offset: 0x20AB60C VA: 0x20AF60C
	private void set_IsConnect(bool value) { }

	// RVA: 0x20AF618 Offset: 0x20AB618 VA: 0x20AF618
	public void .ctor() { }

	// RVA: 0x20AF648 Offset: 0x20AB648 VA: 0x20AF648
	private string GetEnabledSaveKey() { }

	// RVA: 0x20AF6B4 Offset: 0x20AB6B4 VA: 0x20AF6B4
	public void OnEnter() { }

	// RVA: 0x20AF744 Offset: 0x20AB744 VA: 0x20AF744
	public void ConnectGetBazaarData() { }

	// RVA: 0x20AF824 Offset: 0x20AB824 VA: 0x20AF824
	public void ConnectUpdateCheckOpenBazaarDialog() { }

	// RVA: 0x20AF8F8 Offset: 0x20AB8F8 VA: 0x20AF8F8
	public bool CheckNotification() { }

	// RVA: 0x20AF578 Offset: 0x20AB578 VA: 0x20AF578
	private void SaveAlreadyNotified() { }

	// RVA: 0x20AF970 Offset: 0x20AB970 VA: 0x20AF970
	public void ClearAlreadyNotified() { }

	[IteratorStateMachine(typeof(BazaarManager.<PopSoldOutDialog>d__27))]
	// RVA: 0x20AF9A8 Offset: 0x20AB9A8 VA: 0x20AF9A8
	public IEnumerator PopSoldOutDialog(SystemTextManager systemTextManager, GameObject gameObject) { }
}
