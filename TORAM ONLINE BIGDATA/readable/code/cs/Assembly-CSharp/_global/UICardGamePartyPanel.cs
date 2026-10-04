// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGamePartyPanel : UICardGameBasePanel // TypeDefIndex: 5673
{
	// Fields
	private bool ready; // 0x88
	private int memberNum; // 0x8C
	private float settingUpdateTime; // 0x90

	// Properties
	protected virtual bool IsLeader { get; }
	public override bool IsReady { get; }

	// Methods

	// RVA: 0x17C49F0 Offset: 0x17C09F0 VA: 0x17C49F0 Slot: 13
	protected virtual bool get_IsLeader() { }

	// RVA: 0x17C49F8 Offset: 0x17C09F8 VA: 0x17C49F8 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x17C4A00 Offset: 0x17C0A00 VA: 0x17C4A00
	public void .ctor(GameObject panel, GameObject partyPanel, GameObject[] partyMemberObject, UIImageButton startButton, UICardGameSettingElement settingBase, GameObject mainSetting, UILabel[] mainSettingLabels) { }

	// RVA: 0x17C4A04 Offset: 0x17C0A04 VA: 0x17C4A04 Slot: 5
	public override byte Initialize() { }

	// RVA: 0x17C4A9C Offset: 0x17C0A9C VA: 0x17C4A9C Slot: 7
	public override bool Update() { }

	// RVA: 0x17C4EB0 Offset: 0x17C0EB0 VA: 0x17C4EB0 Slot: 8
	public override void BattleReady() { }

	// RVA: 0x17C50B8 Offset: 0x17C10B8 VA: 0x17C50B8 Slot: 9
	public override bool Cancel() { }

	// RVA: 0x17C52B8 Offset: 0x17C12B8 VA: 0x17C52B8 Slot: 10
	public override void SetActive(bool active) { }

	// RVA: 0x17C52D8 Offset: 0x17C12D8 VA: 0x17C52D8 Slot: 11
	protected override UICardGameSettingElement CreateSettingElement(string name, int value, int min, int max, int change, UICardGameSettingElement.SettingUnitType type, bool main) { }

	// RVA: 0x17C53D8 Offset: 0x17C13D8 VA: 0x17C53D8 Slot: 12
	public override void SynchronousGameSetting(CardGameSettingData setting) { }

	// RVA: 0x17C4DE8 Offset: 0x17C0DE8 VA: 0x17C4DE8
	private bool CheckSettingChange() { }
}
