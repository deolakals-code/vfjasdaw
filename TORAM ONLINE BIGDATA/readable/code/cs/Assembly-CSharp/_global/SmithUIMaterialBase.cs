// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithUIMaterialBase : MonoBehaviour // TypeDefIndex: 8473
{
	// Fields
	public bool IsPlayer; // 0x20
	public int ShopId; // 0x24
	[CompilerGenerated]
	private UIBasePanelControl <topButtonControl>k__BackingField; // 0x28
	protected SystemTextManager systemTextManager; // 0x30
	protected ItemTextManager itemTextManager; // 0x38
	protected PlayerDataManager playerDataManager; // 0x40
	protected readonly float takeWait; // 0x48
	[CompilerGenerated]
	private bool <IsWaitingChat>k__BackingField; // 0x4C
	[CompilerGenerated]
	private HistoryLog <HistoryLog>k__BackingField; // 0x50
	[CompilerGenerated]
	private UnityAction <ShortcutListBackAction>k__BackingField; // 0x58
	[CompilerGenerated]
	private UnityAction <HistoryBackAction>k__BackingField; // 0x60

	// Properties
	public UIBasePanelControl topButtonControl { get; set; }
	public bool IsWaitingChat { get; set; }
	public HistoryLog HistoryLog { get; set; }
	public UnityAction ShortcutListBackAction { get; set; }
	public UnityAction HistoryBackAction { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D761DC Offset: 0x1D721DC VA: 0x1D761DC
	public UIBasePanelControl get_topButtonControl() { }

	[CompilerGenerated]
	// RVA: 0x1D761E4 Offset: 0x1D721E4 VA: 0x1D761E4
	public void set_topButtonControl(UIBasePanelControl value) { }

	[CompilerGenerated]
	// RVA: 0x1D761EC Offset: 0x1D721EC VA: 0x1D761EC
	public bool get_IsWaitingChat() { }

	[CompilerGenerated]
	// RVA: 0x1D761F4 Offset: 0x1D721F4 VA: 0x1D761F4
	public void set_IsWaitingChat(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1D76200 Offset: 0x1D72200 VA: 0x1D76200
	public HistoryLog get_HistoryLog() { }

	[CompilerGenerated]
	// RVA: 0x1D76208 Offset: 0x1D72208 VA: 0x1D76208
	private void set_HistoryLog(HistoryLog value) { }

	[CompilerGenerated]
	// RVA: 0x1D76210 Offset: 0x1D72210 VA: 0x1D76210
	public UnityAction get_ShortcutListBackAction() { }

	[CompilerGenerated]
	// RVA: 0x1D76218 Offset: 0x1D72218 VA: 0x1D76218
	public void set_ShortcutListBackAction(UnityAction value) { }

	[CompilerGenerated]
	// RVA: 0x1D76220 Offset: 0x1D72220 VA: 0x1D76220
	public UnityAction get_HistoryBackAction() { }

	[CompilerGenerated]
	// RVA: 0x1D76228 Offset: 0x1D72228 VA: 0x1D76228
	public void set_HistoryBackAction(UnityAction value) { }

	// RVA: 0x1D76230 Offset: 0x1D72230 VA: 0x1D76230
	private void Start() { }

	// RVA: 0x1D76234 Offset: 0x1D72234 VA: 0x1D76234 Slot: 4
	public virtual void Close() { }

	// RVA: 0x1D762A0 Offset: 0x1D722A0 VA: 0x1D762A0
	public void SetTitle() { }

	// RVA: 0x1D76388 Offset: 0x1D72388 VA: 0x1D76388
	public void SetTitle(string titleArg) { }

	// RVA: 0x1D7648C Offset: 0x1D7248C VA: 0x1D7648C
	public void SetTitleText(string text) { }

	// RVA: 0x1D7651C Offset: 0x1D7251C VA: 0x1D7651C
	public void SetShopId(int smithId) { }

	// RVA: 0x1D76524 Offset: 0x1D72524 VA: 0x1D76524 Slot: 5
	protected virtual void OnDestroy() { }

	// RVA: 0x1D76584 Offset: 0x1D72584 VA: 0x1D76584
	public void OpenHistoryLog() { }

	// RVA: 0x1D7684C Offset: 0x1D7284C VA: 0x1D7684C
	protected void EndWaitingChat() { }

	// RVA: 0x1D769C4 Offset: 0x1D729C4 VA: 0x1D769C4
	protected void SetRightTopChatButtonAction() { }

	// RVA: 0x1D76A58 Offset: 0x1D72A58 VA: 0x1D76A58
	protected void PCCustomRightTopButtonAction() { }

	// RVA: 0x1D76A5C Offset: 0x1D72A5C VA: 0x1D76A5C
	public void SetRightTopChatButton() { }

	// RVA: 0x1D76B68 Offset: 0x1D72B68 VA: 0x1D76B68
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D76B80 Offset: 0x1D72B80 VA: 0x1D76B80
	private void <OpenHistoryLog>b__33_0() { }

	[CompilerGenerated]
	// RVA: 0x1D76C3C Offset: 0x1D72C3C VA: 0x1D76C3C
	private void <SetRightTopChatButtonAction>b__35_0() { }
}
