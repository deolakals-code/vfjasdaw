// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINewAutoItemOptionManager : UIAutoItemOptionManager // TypeDefIndex: 7490
{
	// Fields
	private List<string> text; // 0xB0
	private List<string> textEx; // 0xB8
	private List<NewOptionElementSwitch_AutoItem.SelectData> selectListEx; // 0xC0
	private int selectedItemParam; // 0xC8
	private UIOptionButton autoItemButton; // 0xD0
	private UIToggle autoDeleteEquipItemCheckBox; // 0xD8
	private UISelectButton[] autoDeleteSelectButtons; // 0xE0
	private UIToggle autoDeleteEquipItemBossCheckBox; // 0xE8
	private UIToggle autoDeleteEquipItemEventCheckBox; // 0xF0

	// Methods

	// RVA: 0x1B69CF8 Offset: 0x1B65CF8 VA: 0x1B69CF8
	private void Update() { }

	// RVA: 0x1B6A090 Offset: 0x1B66090 VA: 0x1B6A090 Slot: 27
	protected override void OnDestroy() { }

	// RVA: 0x1B6A0E4 Offset: 0x1B660E4 VA: 0x1B6A0E4 Slot: 7
	protected override void Initialize() { }

	// RVA: 0x1B6A448 Offset: 0x1B66448 VA: 0x1B6A448 Slot: 26
	protected override bool AutoItemList(int itemId) { }

	// RVA: 0x1B6AB7C Offset: 0x1B66B7C VA: 0x1B6AB7C Slot: 28
	protected override void AddItemForSelectButton(int id, ItemTextManagerData itemTextManagerData) { }

	// RVA: 0x1B6ACD8 Offset: 0x1B66CD8 VA: 0x1B6ACD8 Slot: 18
	public override void OnNewClickSwitchButton(int id, int defaultParam, int addParam, int param, string[] textList) { }

	// RVA: 0x1B6AFDC Offset: 0x1B66FDC VA: 0x1B6AFDC Slot: 19
	public override void OnNewClickPercentButton(int id, int defaultParam, int start, float power) { }

	// RVA: 0x1B6B2EC Offset: 0x1B672EC VA: 0x1B6B2EC
	private void PopUpAutoItemOption() { }

	// RVA: 0x1B6B374 Offset: 0x1B67374 VA: 0x1B6B374
	private void CreateAutoItemPanel(Transform parent) { }

	// RVA: 0x1B6A364 Offset: 0x1B66364 VA: 0x1B6A364
	private void UpdateHpText() { }

	// RVA: 0x1B6B8B8 Offset: 0x1B678B8 VA: 0x1B6B8B8
	protected void AutoDeleteEquipItemPopUp() { }

	// RVA: 0x1B6B940 Offset: 0x1B67940 VA: 0x1B6B940
	private void CreateAutoDeleteEquipItemPanel(Transform parent) { }

	// RVA: 0x1B6C518 Offset: 0x1B68518 VA: 0x1B6C518
	private UILabel CreateLabel(Transform parent, float posX, float posY, float scale, string textKey, UIWidget.Pivot pivot) { }

	// RVA: 0x1B6C274 Offset: 0x1B68274 VA: 0x1B6C274
	private void CreateLabelWithSizeControl(Transform parent, float posX, float posY, string textKey) { }

	// RVA: 0x1B6C378 Offset: 0x1B68378 VA: 0x1B6C378
	private UIToggle CreateCheckBox(Transform parent, float posX, float posY, bool initialValue, string textKey) { }

	// RVA: 0x1B6C694 Offset: 0x1B68694 VA: 0x1B6C694
	private void CreateConditionRow(Transform parent, float posX, ref float posY, UINewAutoItemOptionManager.AutoDeleteSelectType type, string labelKey, int initialValue, string[] selectList) { }

	// RVA: 0x1B6C8B8 Offset: 0x1B688B8 VA: 0x1B6C8B8
	private void CreateConditionRow(Transform parent, float posX, ref float posY, UINewAutoItemOptionManager.AutoDeleteSelectType type, string labelKey, int initialValue, int[] sortList, Dictionary<int, string> textList) { }

	// RVA: 0x1B69D08 Offset: 0x1B65D08 VA: 0x1B69D08
	private void UpdateAutoDeleteEquipItemSetting() { }

	// RVA: 0x1B6CAE8 Offset: 0x1B68AE8 VA: 0x1B6CAE8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1B6CCF8 Offset: 0x1B68CF8 VA: 0x1B6CCF8
	private void <CreateAutoItemPanel>b__18_0(int x) { }

	[CompilerGenerated]
	// RVA: 0x1B6CD08 Offset: 0x1B68D08 VA: 0x1B6CD08
	private void <CreateAutoItemPanel>b__18_1(int x) { }
}
