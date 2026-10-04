// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildQuestBoradPopDiscardPanel : MonoBehaviour // TypeDefIndex: 6665
{
	// Fields
	[SerializeField]
	private UILabel selectedLabel; // 0x20
	[SerializeField]
	private UIGuildQuestBoardManager manager; // 0x28
	[SerializeField]
	private GameObject fadePanel; // 0x30
	[CompilerGenerated]
	private bool <IsPopWindow>k__BackingField; // 0x38
	private int SelectedNum; // 0x3C
	private SystemTextManager systemTextManager; // 0x40
	private int selectedType; // 0x48

	// Properties
	public bool IsPopWindow { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19AE8D4 Offset: 0x19AA8D4 VA: 0x19AE8D4
	public bool get_IsPopWindow() { }

	[CompilerGenerated]
	// RVA: 0x19AE8DC Offset: 0x19AA8DC VA: 0x19AE8DC
	private void set_IsPopWindow(bool value) { }

	// RVA: 0x19AE8E8 Offset: 0x19AA8E8 VA: 0x19AE8E8
	private void Awake() { }

	// RVA: 0x19A9F20 Offset: 0x19A5F20 VA: 0x19A9F20
	public void PopQuestWindow(UIGuildQuestBoardManager.GuildQuestDataBase quest, int selectedType) { }

	// RVA: 0x19AA0AC Offset: 0x19A60AC VA: 0x19AA0AC
	public void ClosedWindow() { }

	// RVA: 0x19AE9D0 Offset: 0x19AA9D0 VA: 0x19AE9D0
	private void UpdateSelectedLabel() { }

	// RVA: 0x19AEA68 Offset: 0x19AAA68 VA: 0x19AEA68
	public void OnClick_ChangeQuestType(int add) { }

	// RVA: 0x19AEAF4 Offset: 0x19AAAF4 VA: 0x19AEAF4
	public void OnClick_EnterButton() { }

	// RVA: 0x19AEB50 Offset: 0x19AAB50 VA: 0x19AEB50
	public void .ctor() { }
}
