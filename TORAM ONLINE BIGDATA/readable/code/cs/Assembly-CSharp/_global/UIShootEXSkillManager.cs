// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIShootEXSkillManager : UIFamiliarSelectManager // TypeDefIndex: 6824
{
	// Fields
	private UIShootEXSkillManager.HuntingOneData huntingOneData; // 0x1D0

	// Methods

	[IteratorStateMachine(typeof(UIShootEXSkillManager.<Start>d__5))]
	// RVA: 0x1A0BC8C Offset: 0x1A07C8C VA: 0x1A0BC8C Slot: 8
	protected override IEnumerator Start() { }

	// RVA: 0x1A0BD20 Offset: 0x1A07D20 VA: 0x1A0BD20 Slot: 15
	public override void UpdateRushSwitchButton(int flag) { }

	// RVA: 0x1A0BE2C Offset: 0x1A07E2C VA: 0x1A0BE2C Slot: 9
	protected override void UpdateServantModel(int bitId, GameObject model) { }

	// RVA: 0x1A0BF2C Offset: 0x1A07F2C VA: 0x1A0BF2C Slot: 12
	protected override void ChangeFamiliaData(byte id, byte[] colorIds, int flag) { }

	// RVA: 0x1A0C198 Offset: 0x1A08198 VA: 0x1A0C198 Slot: 13
	protected override void ChangePanelState(UIFamiliarSelectManager.PanelState panelState) { }

	// RVA: 0x1A0C370 Offset: 0x1A08370 VA: 0x1A0C370 Slot: 17
	protected override void PopUpBuyPanel() { }

	// RVA: 0x1A0C3E4 Offset: 0x1A083E4 VA: 0x1A0C3E4 Slot: 19
	public override void OnClickBuyOrb() { }

	// RVA: 0x1A0C764 Offset: 0x1A08764 VA: 0x1A0C764 Slot: 20
	protected override void PopUpColorPanel() { }

	[IteratorStateMachine(typeof(UIShootEXSkillManager.<CloseSaveData>d__13))]
	// RVA: 0x1A0C7D8 Offset: 0x1A087D8 VA: 0x1A0C7D8 Slot: 14
	protected override IEnumerator CloseSaveData(UIActiveState nextActiveState) { }

	// RVA: 0x1A0C87C Offset: 0x1A0887C VA: 0x1A0C87C
	private void GetData() { }

	// RVA: 0x1A0C0D4 Offset: 0x1A080D4 VA: 0x1A0C0D4
	private void ChangeData(byte selectNo, int color, int flag) { }

	// RVA: 0x1A0C6A0 Offset: 0x1A086A0 VA: 0x1A0C6A0
	private void UnlockData(byte unlockNo, int useOrb, int orbNum) { }

	// RVA: 0x1A0C9C8 Offset: 0x1A089C8 VA: 0x1A0C9C8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A0C9CC Offset: 0x1A089CC VA: 0x1A0C9CC
	private void <ChangeFamiliaData>b__8_1() { }

	[CompilerGenerated]
	// RVA: 0x1A0CBA4 Offset: 0x1A08BA4 VA: 0x1A0CBA4
	private void <ChangeFamiliaData>b__8_2() { }

	[CompilerGenerated]
	// RVA: 0x1A0CBA8 Offset: 0x1A08BA8 VA: 0x1A0CBA8
	private void <OnClickBuyOrb>b__11_1() { }

	[CompilerGenerated]
	// RVA: 0x1A0CE24 Offset: 0x1A08E24 VA: 0x1A0CE24
	private void <OnClickBuyOrb>b__11_2() { }
}
