// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISystemOptionManager : UIOptionBaseManager // TypeDefIndex: 7543
{
	// Fields
	protected OptionsSystem optionsSystem; // 0x90
	private List<int> autoItemIdList; // 0x98
	[SerializeField]
	private UILabel autoItemText; // 0xA0
	[SerializeField]
	private GameObject guardAvoidPanel; // 0xA8
	[SerializeField]
	private UISprite[] guardButton; // 0xB0
	[SerializeField]
	private UISprite[] avoidButton; // 0xB8
	protected UIOptionButton guardAvoidButton; // 0xC0

	// Methods

	// RVA: 0x1BA3970 Offset: 0x1B9F970 VA: 0x1BA3970 Slot: 7
	protected override void Initialize() { }

	// RVA: 0x1BA411C Offset: 0x1BA011C VA: 0x1BA411C
	protected bool AutoItemList(int itemId) { }

	// RVA: 0x1BA4988 Offset: 0x1BA0988 VA: 0x1BA4988 Slot: 26
	protected virtual void OnDestroy() { }

	// RVA: 0x1BA49A0 Offset: 0x1BA09A0 VA: 0x1BA49A0 Slot: 21
	protected override bool SetFlag(bool setFlag) { }

	// RVA: 0x1BA49D0 Offset: 0x1BA09D0 VA: 0x1BA49D0 Slot: 23
	protected override bool SetParam(int setParam) { }

	// RVA: 0x1BA4AC4 Offset: 0x1BA0AC4 VA: 0x1BA4AC4 Slot: 24
	protected override string GetEnumType(int enumType) { }

	// RVA: 0x1BA4B28 Offset: 0x1BA0B28 VA: 0x1BA4B28
	public void ShowAutoPotionSetting() { }

	// RVA: 0x1BA4BA4 Offset: 0x1BA0BA4 VA: 0x1BA4BA4 Slot: 13
	public override void OnClickSelectButton(int id, int addParam, int param, string[] textList) { }

	// RVA: 0x1BA4E80 Offset: 0x1BA0E80 VA: 0x1BA4E80 Slot: 11
	public override void OnBitCheckBoxButton(int id, int bitParam, string[] textList, Vector2[] position) { }

	// RVA: 0x1BA5084 Offset: 0x1BA1084 VA: 0x1BA5084 Slot: 15
	public override void OnClickSwitchButton(int type, int bitParam, string[] textList, string[] textExList, int paramNum) { }

	// RVA: 0x1BA523C Offset: 0x1BA123C VA: 0x1BA523C
	private string GetGuardAndAvoidText() { }

	// RVA: 0x1BA5284 Offset: 0x1BA1284 VA: 0x1BA5284 Slot: 27
	protected virtual void GuardAvoidSettingPopUp() { }

	// RVA: 0x1BA55AC Offset: 0x1BA15AC VA: 0x1BA55AC Slot: 28
	protected virtual void GuardAvoidSettingCallBack(int state) { }

	// RVA: 0x1BA5908 Offset: 0x1BA1908 VA: 0x1BA5908
	protected void CheckGuardAvoidUpdate(GuardType oldGuardType, AvoidType oldAvoidType) { }

	// RVA: 0x1BA5AB0 Offset: 0x1BA1AB0 VA: 0x1BA5AB0
	private void OnGuardSetting(int param) { }

	// RVA: 0x1BA5B68 Offset: 0x1BA1B68 VA: 0x1BA5B68
	private void OnAvoidSetting(int param) { }

	// RVA: 0x1BA5C20 Offset: 0x1BA1C20 VA: 0x1BA5C20
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1BA5CF4 Offset: 0x1BA1CF4 VA: 0x1BA5CF4
	private void <OnClickSwitchButton>b__16_0(int param, int num) { }
}
