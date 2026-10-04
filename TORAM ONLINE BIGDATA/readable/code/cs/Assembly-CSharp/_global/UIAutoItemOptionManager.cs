// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIAutoItemOptionManager : UIOptionBaseManager // TypeDefIndex: 7496
{
	// Fields
	protected OptionsSystem optionsSystem; // 0x90
	protected List<int> autoItemIdList; // 0x98
	[SerializeField]
	protected UILabel autoItemText; // 0xA0
	private List<PopUpSelectWindow_AutoItem.SelectData> selectListEx; // 0xA8

	// Methods

	// RVA: 0x1B743E4 Offset: 0x1B703E4 VA: 0x1B743E4 Slot: 7
	protected override void Initialize() { }

	// RVA: 0x1B74488 Offset: 0x1B70488 VA: 0x1B74488 Slot: 26
	protected virtual bool AutoItemList(int itemId) { }

	// RVA: 0x1B6A0CC Offset: 0x1B660CC VA: 0x1B6A0CC Slot: 27
	protected virtual void OnDestroy() { }

	// RVA: 0x1B74D64 Offset: 0x1B70D64 VA: 0x1B74D64 Slot: 21
	protected override bool SetFlag(bool setFlag) { }

	// RVA: 0x1B74D94 Offset: 0x1B70D94 VA: 0x1B74D94 Slot: 23
	protected override bool SetParam(int setParam) { }

	// RVA: 0x1B74E88 Offset: 0x1B70E88 VA: 0x1B74E88 Slot: 24
	protected override string GetEnumType(int enumType) { }

	// RVA: 0x1B74EEC Offset: 0x1B70EEC VA: 0x1B74EEC
	public void ShowAutoPotionSetting() { }

	// RVA: 0x1B74F68 Offset: 0x1B70F68 VA: 0x1B74F68 Slot: 28
	protected virtual void AddItemForSelectButton(int id, ItemTextManagerData itemTextManagerData) { }

	// RVA: 0x1B750C8 Offset: 0x1B710C8 VA: 0x1B750C8 Slot: 12
	public override void OnClickPercentButton(int id, int param, int startParam, float powerParam) { }

	// RVA: 0x1B75390 Offset: 0x1B71390 VA: 0x1B75390 Slot: 13
	public override void OnClickSelectButton(int id, int addParam, int param, string[] textList) { }

	// RVA: 0x1B6CC1C Offset: 0x1B68C1C VA: 0x1B6CC1C
	public void .ctor() { }
}
