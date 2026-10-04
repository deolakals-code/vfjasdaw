// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Markets
public class MarketResultData : UnityHashBase // TypeDefIndex: 11173
{
	// Fields
	private Dictionary<object, object> tables; // 0x20

	// Properties
	public MarketData[] Products { get; }
	public int Gold { get; }
	public ItemDatav2[] ItemList { get; }
	public WarrantyItemDatav2[] WarrantyList { get; }
	public StarGemData[] StarGemList { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35D11B4 Offset: 0x35CD1B4 VA: 0x35D11B4
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x35D11E4 Offset: 0x35CD1E4 VA: 0x35D11E4
	public MarketData[] get_Products() { }

	// RVA: 0x35D1320 Offset: 0x35CD320 VA: 0x35D1320
	public int get_Gold() { }

	// RVA: 0x35D1434 Offset: 0x35CD434 VA: 0x35D1434
	public ItemDatav2[] get_ItemList() { }

	// RVA: 0x35D1580 Offset: 0x35CD580 VA: 0x35D1580
	public WarrantyItemDatav2[] get_WarrantyList() { }

	// RVA: 0x35D16AC Offset: 0x35CD6AC VA: 0x35D16AC
	public StarGemData[] get_StarGemList() { }

	// RVA: 0x35D17D8 Offset: 0x35CD7D8 VA: 0x35D17D8
	public bool IsProducts() { }

	// RVA: 0x35D1868 Offset: 0x35CD868 VA: 0x35D1868
	public bool IsGold() { }

	// RVA: 0x35D18F8 Offset: 0x35CD8F8 VA: 0x35D18F8
	public bool IsItemList() { }

	// RVA: 0x35D1988 Offset: 0x35CD988 VA: 0x35D1988
	public bool IsWarrantyList() { }

	// RVA: 0x35D1A18 Offset: 0x35CDA18 VA: 0x35D1A18
	public bool IsStarGemList() { }

	// RVA: 0x35D1AA8 Offset: 0x35CDAA8 VA: 0x35D1AA8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35D1AB0 Offset: 0x35CDAB0 VA: 0x35D1AB0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35D1AB8 Offset: 0x35CDAB8 VA: 0x35D1AB8 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
