// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildQuestBoradPopQuestPanel : MonoBehaviour // TypeDefIndex: 6666
{
	// Fields
	[SerializeField]
	private GameObject popQuestScaleWindow; // 0x20
	[SerializeField]
	private UILabel popQuestTitleLabel; // 0x28
	[SerializeField]
	private UISprite popQuestTitleIcon; // 0x30
	[SerializeField]
	private UILabel popQuestTargetLabel; // 0x38
	[SerializeField]
	private UILabel popQuestCountLabel; // 0x40
	[SerializeField]
	private UILabel[] popQuestRewardLabel; // 0x48
	[SerializeField]
	private UIIconBase[] popQuestRewardIcon; // 0x50
	[SerializeField]
	private UIImageButton popQuestRewardReportButton; // 0x58
	[SerializeField]
	private GameObject popQuestRewardReportIcon; // 0x60
	[SerializeField]
	private GameObject discardQuestButton; // 0x68
	[SerializeField]
	private UIIruna2Anchor reorderQuestButton; // 0x70
	[SerializeField]
	private GameObject itemSearchButton; // 0x78
	[CompilerGenerated]
	private bool <IsPopWindow>k__BackingField; // 0x80

	// Properties
	public bool IsPopWindow { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19AEB60 Offset: 0x19AAB60 VA: 0x19AEB60
	public bool get_IsPopWindow() { }

	[CompilerGenerated]
	// RVA: 0x19AEB68 Offset: 0x19AAB68 VA: 0x19AEB68
	private void set_IsPopWindow(bool value) { }

	// RVA: 0x19A9634 Offset: 0x19A5634 VA: 0x19A9634
	public void PopQuestWindow(UIGuildQuestBoardManager.GuildQuestDataBase quest, SystemTextManager systemTextManager, ItemManager itemManager, bool isReorder) { }

	// RVA: 0x19AD380 Offset: 0x19A9380 VA: 0x19AD380
	public void SetActive(bool flag) { }

	// RVA: 0x19A9C5C Offset: 0x19A5C5C VA: 0x19A9C5C
	public void ClosedWindow() { }

	// RVA: 0x19AEB74 Offset: 0x19AAB74 VA: 0x19AEB74
	public void .ctor() { }
}
