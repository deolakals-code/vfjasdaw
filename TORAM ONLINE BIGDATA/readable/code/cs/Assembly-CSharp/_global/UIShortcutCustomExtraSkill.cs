// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIShortcutCustomExtraSkill : UIShortcutCustomBase // TypeDefIndex: 7525
{
	// Fields
	private PlayerDataManager playerDataManager; // 0x28
	private SkillTextManager skillTextManager; // 0x30
	private Dictionary<int, ItemData> equipSkillList; // 0x38

	// Properties
	public override bool IsTopMenu { get; }

	// Methods

	// RVA: 0x1B83D64 Offset: 0x1B7FD64 VA: 0x1B83D64
	public void .ctor(IUIShortcutCustomManager manager) { }

	// RVA: 0x1B85688 Offset: 0x1B81688 VA: 0x1B85688 Slot: 4
	public override bool get_IsTopMenu() { }

	// RVA: 0x1B85690 Offset: 0x1B81690 VA: 0x1B85690 Slot: 6
	public override void CreateList() { }

	// RVA: 0x1B85714 Offset: 0x1B81714 VA: 0x1B85714
	protected void AddAvatarSkillButton(ItemData equipItem) { }

	// RVA: 0x1B85AAC Offset: 0x1B81AAC VA: 0x1B85AAC Slot: 10
	protected virtual void AddIconButton(string title, int skillId, ItemData equipItem) { }

	// RVA: 0x1B85BA0 Offset: 0x1B81BA0 VA: 0x1B85BA0 Slot: 7
	public override string OnSelect(int id) { }

	// RVA: 0x1B85C4C Offset: 0x1B81C4C VA: 0x1B85C4C Slot: 8
	public override void OnClick(int id) { }

	// RVA: 0x1B85EF0 Offset: 0x1B81EF0 VA: 0x1B85EF0 Slot: 11
	protected virtual string GetPopOkButtonLabel() { }

	// RVA: 0x1B85F44 Offset: 0x1B81F44 VA: 0x1B85F44 Slot: 12
	public virtual void OnPopCallBack(int state, int id) { }
}
