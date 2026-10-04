// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPointShopExchangePointButton : UIPointShopButtonBase // TypeDefIndex: 6163
{
	// Fields
	[SerializeField]
	private UILabel exchangeItemNumLabel; // 0x90
	[SerializeField]
	private GameObject completeIconObj; // 0x98
	[SerializeField]
	private GameObject soldOutLabelObj; // 0xA0
	private int limit; // 0xA8

	// Methods

	// RVA: 0x18AAB88 Offset: 0x18A6B88 VA: 0x18AAB88 Slot: 4
	protected override void ResultButton() { }

	// RVA: 0x18AAE3C Offset: 0x18A6E3C VA: 0x18AAE3C Slot: 5
	protected override void PointErrButton() { }

	// RVA: 0x18AAE58 Offset: 0x18A6E58 VA: 0x18AAE58 Slot: 6
	protected override void LimitButton() { }

	// RVA: 0x18AAE74 Offset: 0x18A6E74 VA: 0x18AAE74 Slot: 7
	protected override void UnknownButton() { }

	// RVA: 0x18AABA4 Offset: 0x18A6BA4 VA: 0x18AABA4
	private void setTradeItemNum(bool isEnabled) { }

	// RVA: 0x18AAE90 Offset: 0x18A6E90 VA: 0x18AAE90 Slot: 8
	public override void OnButtonClick() { }

	// RVA: 0x18ABA14 Offset: 0x18A7A14 VA: 0x18ABA14
	public void .ctor() { }
}
