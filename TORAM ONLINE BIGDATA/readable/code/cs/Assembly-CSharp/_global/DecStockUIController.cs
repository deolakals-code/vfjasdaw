// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DecStockUIController // TypeDefIndex: 6281
{
	// Fields
	private int fixedValue; // 0x10
	private int nowValue; // 0x14
	private int baseValue; // 0x18
	private int haveMoney; // 0x1C
	private int cost; // 0x20
	private StockUIControllerLabel uiControll; // 0x28
	private ShoppingPanel.ShoppingPanelState state; // 0x30

	// Properties
	public int BuyCount { get; }
	public int SendBuyCount { get; }
	public int Cost { get; }

	// Methods

	// RVA: 0x18DABE4 Offset: 0x18D6BE4 VA: 0x18DABE4
	public int get_BuyCount() { }

	// RVA: 0x18DABEC Offset: 0x18D6BEC VA: 0x18DABEC
	public int get_SendBuyCount() { }

	// RVA: 0x18DAC18 Offset: 0x18D6C18 VA: 0x18DAC18
	public int get_Cost() { }

	// RVA: 0x18DAC28 Offset: 0x18D6C28 VA: 0x18DAC28
	public void .ctor() { }

	// RVA: 0x18DAC30 Offset: 0x18D6C30 VA: 0x18DAC30
	public void SetItemType(ShoppingPanel.ShoppingPanelState _state) { }

	// RVA: 0x18DAC38 Offset: 0x18D6C38 VA: 0x18DAC38
	public void SetValues(int _baseValue, int _haveMoney, int _oneCost) { }

	// RVA: 0x18DAC48 Offset: 0x18D6C48 VA: 0x18DAC48
	public void SetStockUI(StockUIControllerLabel _stock_ui_label) { }

	// RVA: 0x18DAC50 Offset: 0x18D6C50 VA: 0x18DAC50
	public void AddFixedValue() { }

	// RVA: 0x18DAE08 Offset: 0x18D6E08 VA: 0x18DAE08
	public void DecreaseFixedValue() { }

	// RVA: 0x18DAE88 Offset: 0x18D6E88 VA: 0x18DAE88
	public void AddMax() { }
}
