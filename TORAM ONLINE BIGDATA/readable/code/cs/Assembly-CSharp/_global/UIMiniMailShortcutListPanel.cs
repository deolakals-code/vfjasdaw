// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMiniMailShortcutListPanel : UIBasePanel // TypeDefIndex: 7475
{
	// Fields
	[SerializeField]
	private UILabel[] buttonLabels; // 0x30
	[SerializeField]
	private UISprite warnIcon; // 0x38
	private int avatarUuid; // 0x40
	private string avatarName; // 0x48
	private UIIruna2Anchor anchor; // 0x50
	private PlayerDataManager playerDataManager; // 0x58

	// Methods

	// RVA: 0x1B65304 Offset: 0x1B61304 VA: 0x1B65304
	public void Initialize(int uuid, string name) { }

	// RVA: 0x1B655A0 Offset: 0x1B615A0 VA: 0x1B655A0
	private void Start() { }

	// RVA: 0x1B654C8 Offset: 0x1B614C8 VA: 0x1B654C8
	private Color GetTextColor(UIMiniMailShortcutListPanel.ShortcutType type) { }

	// RVA: 0x1B656E0 Offset: 0x1B616E0 VA: 0x1B656E0
	private void ShortcutClick(int param) { }

	// RVA: 0x1B659B4 Offset: 0x1B619B4 VA: 0x1B659B4
	private void CloseShortCut() { }

	// RVA: 0x1B65A10 Offset: 0x1B61A10 VA: 0x1B65A10 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1B65A6C Offset: 0x1B61A6C VA: 0x1B65A6C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1B65AC8 Offset: 0x1B61AC8 VA: 0x1B65AC8
	public void .ctor() { }
}
