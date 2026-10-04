// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIShortcutCustomSkill : UIShortcutCustomBase // TypeDefIndex: 7541
{
	// Fields
	private SkillTextManager skillTextManager; // 0x28
	private PlayerDataManager playerDataManager; // 0x30
	private List<SkillData> skillDataList; // 0x38
	private UIShortcutCustomSkill.PageState pageState; // 0x40
	private int selectTreeType; // 0x44

	// Properties
	public override bool IsFullWindow { get; }
	public override bool IsTopMenu { get; }

	// Methods

	// RVA: 0x1BA18AC Offset: 0x1B9D8AC VA: 0x1BA18AC
	public void .ctor(IUIShortcutCustomManager manager) { }

	// RVA: 0x1BA2364 Offset: 0x1B9E364 VA: 0x1BA2364 Slot: 5
	public override bool get_IsFullWindow() { }

	// RVA: 0x1BA236C Offset: 0x1B9E36C VA: 0x1BA236C Slot: 4
	public override bool get_IsTopMenu() { }

	// RVA: 0x1BA2374 Offset: 0x1B9E374 VA: 0x1BA2374 Slot: 6
	public override void CreateList() { }

	// RVA: 0x1BA307C Offset: 0x1B9F07C VA: 0x1BA307C Slot: 7
	public override string OnSelect(int id) { }

	// RVA: 0x1BA3194 Offset: 0x1B9F194 VA: 0x1BA3194 Slot: 8
	public override void OnClick(int id) { }

	// RVA: 0x1BA3348 Offset: 0x1B9F348 VA: 0x1BA3348 Slot: 9
	public override void OnSwitchButton() { }

	// RVA: 0x1BA1A94 Offset: 0x1B9DA94 VA: 0x1BA1A94
	private void SetSkillDataList() { }

	// RVA: 0x1BA254C Offset: 0x1B9E54C VA: 0x1BA254C
	private void CreateSkillList() { }

	// RVA: 0x1BA27D4 Offset: 0x1B9E7D4 VA: 0x1BA27D4
	private void CreateSkillTreeList() { }

	// RVA: 0x1BA2B6C Offset: 0x1B9EB6C VA: 0x1BA2B6C
	private void CreateInSkillTreeList(int id) { }
}
