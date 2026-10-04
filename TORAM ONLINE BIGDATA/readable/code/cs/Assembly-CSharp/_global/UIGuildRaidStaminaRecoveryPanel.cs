// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildRaidStaminaRecoveryPanel : MonoBehaviour // TypeDefIndex: 5770
{
	// Fields
	public const string PanelPath = "UI/Guild/GuildRaidStaminaRecoveryPanel";
	[SerializeField]
	private UIImageButton orbItemButton; // 0x20
	[SerializeField]
	private UILabel orbLabel; // 0x28
	[CompilerGenerated]
	private bool <IsPopWindow>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsConnection>k__BackingField; // 0x31
	private bool isUseDirect; // 0x32
	private IUIGuildRaidStaminRecoveryPanelReceiver receiver; // 0x38
	private SystemTextManager textManger; // 0x40

	// Properties
	public bool IsPopWindow { get; set; }
	public bool IsConnection { get; set; }

	// Methods

	// RVA: 0x17E47E8 Offset: 0x17E07E8 VA: 0x17E47E8
	public static UIGuildRaidStaminaRecoveryPanel CreatePanel(GameObject manager, Transform panret) { }

	[CompilerGenerated]
	// RVA: 0x17E49CC Offset: 0x17E09CC VA: 0x17E49CC
	public bool get_IsPopWindow() { }

	[CompilerGenerated]
	// RVA: 0x17E49D4 Offset: 0x17E09D4 VA: 0x17E49D4
	private void set_IsPopWindow(bool value) { }

	[CompilerGenerated]
	// RVA: 0x17E49E0 Offset: 0x17E09E0 VA: 0x17E49E0
	public bool get_IsConnection() { }

	[CompilerGenerated]
	// RVA: 0x17E49E8 Offset: 0x17E09E8 VA: 0x17E49E8
	private void set_IsConnection(bool value) { }

	// RVA: 0x17E49F4 Offset: 0x17E09F4 VA: 0x17E49F4
	private void RecoveryOrbStaminaPopPanel() { }

	// RVA: 0x17E4D4C Offset: 0x17E0D4C VA: 0x17E4D4C
	private void ClosePanel() { }

	// RVA: 0x17E4E80 Offset: 0x17E0E80 VA: 0x17E4E80
	private void RecoveryOrbStamina(int param) { }

	[IteratorStateMachine(typeof(UIGuildRaidStaminaRecoveryPanel.<Connection>d__18))]
	// RVA: 0x17E51EC Offset: 0x17E11EC VA: 0x17E51EC
	private IEnumerator Connection(Func<bool> check, Action callback) { }

	[IteratorStateMachine(typeof(UIGuildRaidStaminaRecoveryPanel.<popUpMessage>d__19))]
	// RVA: 0x17E5128 Offset: 0x17E1128 VA: 0x17E5128
	private IEnumerator popUpMessage(string titleText, string messageText, bool isButton, Action<int> callback) { }

	[IteratorStateMachine(typeof(UIGuildRaidStaminaRecoveryPanel.<popUpOrbRecoveryMessage>d__20))]
	// RVA: 0x17E4CE0 Offset: 0x17E0CE0 VA: 0x17E4CE0
	private IEnumerator popUpOrbRecoveryMessage() { }

	// RVA: 0x17E5300 Offset: 0x17E1300 VA: 0x17E5300
	public void PopWindow() { }

	// RVA: 0x17E530C Offset: 0x17E130C VA: 0x17E530C
	public bool CloseWindow() { }

	// RVA: 0x17E531C Offset: 0x17E131C VA: 0x17E531C
	public void OpenGuildStaminaRecoveryPanel() { }

	// RVA: 0x17E553C Offset: 0x17E153C VA: 0x17E553C
	public void OnClick_RecoveryOrbStamina() { }

	// RVA: 0x17E5564 Offset: 0x17E1564 VA: 0x17E5564
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x17E556C Offset: 0x17E156C VA: 0x17E556C
	private void <RecoveryOrbStamina>b__17_0(int x) { }

	[CompilerGenerated]
	// RVA: 0x17E5570 Offset: 0x17E1570 VA: 0x17E5570
	private void <RecoveryOrbStamina>b__17_2() { }

	[CompilerGenerated]
	// RVA: 0x17E56E8 Offset: 0x17E16E8 VA: 0x17E56E8
	private void <RecoveryOrbStamina>b__17_3(int x) { }
}
