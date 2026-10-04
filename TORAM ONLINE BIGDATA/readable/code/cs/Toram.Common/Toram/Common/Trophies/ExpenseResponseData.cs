// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Trophies
public class ExpenseResponseData : UnityHashBase // TypeDefIndex: 11067
{
	// Fields
	public Dictionary<object, object> expenseTable; // 0x20

	// Properties
	public int Gold { get; }
	public ItemDatav2[] ItemList { get; }
	public OrbItemData[] OrbItem { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35B1EC8 Offset: 0x35ADEC8 VA: 0x35B1EC8
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x35B1EF8 Offset: 0x35ADEF8 VA: 0x35B1EF8
	public int get_Gold() { }

	// RVA: 0x35B200C Offset: 0x35AE00C VA: 0x35B200C
	public ItemDatav2[] get_ItemList() { }

	// RVA: 0x35B2158 Offset: 0x35AE158 VA: 0x35B2158
	public OrbItemData[] get_OrbItem() { }

	// RVA: 0x35B2284 Offset: 0x35AE284 VA: 0x35B2284
	public bool IsGold() { }

	// RVA: 0x35B2314 Offset: 0x35AE314 VA: 0x35B2314
	public bool IsItemList() { }

	// RVA: 0x35B23A4 Offset: 0x35AE3A4 VA: 0x35B23A4
	public bool IsOrbItem() { }

	// RVA: 0x35B2434 Offset: 0x35AE434 VA: 0x35B2434 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35B243C Offset: 0x35AE43C VA: 0x35B243C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35B2444 Offset: 0x35AE444 VA: 0x35B2444 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
