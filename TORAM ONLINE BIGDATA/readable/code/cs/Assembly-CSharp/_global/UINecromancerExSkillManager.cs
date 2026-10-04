// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINecromancerExSkillManager : UIFamiliarSelectManager // TypeDefIndex: 6758
{
	// Fields
	[SerializeField]
	private UISprite pointIcon; // 0x1D0
	[SerializeField]
	private UIScrollWindow selectScrollWindow; // 0x1D8
	[SerializeField]
	private UINecromancerExSkillElement element; // 0x1E0
	[SerializeField]
	private GameObject switchButton; // 0x1E8
	[SerializeField]
	private UISprite switchButtonIcon; // 0x1F0
	[SerializeField]
	private UILabel switchButtonLabel; // 0x1F8
	private ExSkillSummonDemonic prevExSkillData; // 0x200
	private ExSkillSummonDemonic nowExSkillData; // 0x208
	private int maxPoint; // 0x210
	private List<UISprite> pointIconList; // 0x218
	private List<UINecromancerExSkillElement> elementList; // 0x220
	private UINecromancerExSkillManager.SummonDemonicData summonDemonicData; // 0x228
	private const int UnlockOrbNum = 10;

	// Methods

	[IteratorStateMachine(typeof(UINecromancerExSkillManager.<Start>d__17))]
	// RVA: 0x19EADC0 Offset: 0x19E6DC0 VA: 0x19EADC0 Slot: 8
	protected override IEnumerator Start() { }

	// RVA: 0x19EAE54 Offset: 0x19E6E54 VA: 0x19EAE54
	public void OnSwitch() { }

	// RVA: 0x19EAE70 Offset: 0x19E6E70 VA: 0x19EAE70
	private void Initialize() { }

	// RVA: 0x19EB8E0 Offset: 0x19E78E0 VA: 0x19EB8E0 Slot: 13
	protected override void ChangePanelState(UIFamiliarSelectManager.PanelState panelState) { }

	// RVA: 0x19EB6E0 Offset: 0x19E76E0 VA: 0x19EB6E0
	private void UpdatePoint() { }

	// RVA: 0x19EBB24 Offset: 0x19E7B24 VA: 0x19EBB24
	private void SetConfig(int ability, bool flag) { }

	[IteratorStateMachine(typeof(UINecromancerExSkillManager.<SendUpdateExSkill>d__23))]
	// RVA: 0x19EBB50 Offset: 0x19E7B50 VA: 0x19EBB50
	private IEnumerator SendUpdateExSkill() { }

	// RVA: 0x19EBBE4 Offset: 0x19E7BE4 VA: 0x19EBBE4
	private void GetData() { }

	// RVA: 0x19EBCB8 Offset: 0x19E7CB8 VA: 0x19EBCB8
	private void ChangeData(byte selectNo, int color, int flag) { }

	// RVA: 0x19EBDB8 Offset: 0x19E7DB8 VA: 0x19EBDB8
	private void UnlockData(byte unlockNo, int useOrb, int orbNum) { }

	// RVA: 0x19EBEB8 Offset: 0x19E7EB8 VA: 0x19EBEB8 Slot: 9
	protected override void UpdateServantModel(int bitId, GameObject model) { }

	// RVA: 0x19EC078 Offset: 0x19E8078 VA: 0x19EC078 Slot: 12
	protected override void ChangeFamiliaData(byte id, byte[] colorIds, int flag) { }

	// RVA: 0x19EC1F4 Offset: 0x19E81F4 VA: 0x19EC1F4 Slot: 17
	protected override void PopUpBuyPanel() { }

	// RVA: 0x19EC264 Offset: 0x19E8264 VA: 0x19EC264 Slot: 18
	protected override int GetServivePrice() { }

	// RVA: 0x19EC26C Offset: 0x19E826C VA: 0x19EC26C Slot: 19
	public override void OnClickBuyOrb() { }

	// RVA: 0x19EC528 Offset: 0x19E8528 VA: 0x19EC528 Slot: 20
	protected override void PopUpColorPanel() { }

	// RVA: 0x19EC868 Offset: 0x19E8868 VA: 0x19EC868 Slot: 10
	protected override void UpdateServantModelColor(byte r, byte g, byte b) { }

	// RVA: 0x19ECD38 Offset: 0x19E8D38 VA: 0x19ECD38 Slot: 11
	public override void OnClickEnter() { }

	[IteratorStateMachine(typeof(UINecromancerExSkillManager.<CloseSaveData>d__35))]
	// RVA: 0x19ED178 Offset: 0x19E9178 VA: 0x19ED178 Slot: 14
	protected override IEnumerator CloseSaveData(UIActiveState nextActiveState) { }

	// RVA: 0x19ED21C Offset: 0x19E921C VA: 0x19ED21C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x19ED340 Offset: 0x19E9340 VA: 0x19ED340 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19ED3D8 Offset: 0x19E93D8 VA: 0x19ED3D8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19ED4EC Offset: 0x19E94EC VA: 0x19ED4EC
	private bool <Initialize>b__19_0(int addPoint) { }

	[CompilerGenerated]
	// RVA: 0x19ED52C Offset: 0x19E952C VA: 0x19ED52C
	private void <ChangeFamiliaData>b__28_1() { }

	[CompilerGenerated]
	// RVA: 0x19ED738 Offset: 0x19E9738 VA: 0x19ED738
	private void <ChangeFamiliaData>b__28_2() { }

	[CompilerGenerated]
	// RVA: 0x19ED740 Offset: 0x19E9740 VA: 0x19ED740
	private void <OnClickBuyOrb>b__31_1() { }

	[CompilerGenerated]
	// RVA: 0x19ED9CC Offset: 0x19E99CC VA: 0x19ED9CC
	private void <OnClickBuyOrb>b__31_3() { }

	[CompilerGenerated]
	// RVA: 0x19EDB6C Offset: 0x19E9B6C VA: 0x19EDB6C
	private void <OnClickBuyOrb>b__31_2() { }
}
