// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Markets
public class MarketData : UnityHashBase // TypeDefIndex: 11171
{
	// Fields
	[CompilerGenerated]
	private long <Id>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <WorldType>k__BackingField; // 0x28
	[CompilerGenerated]
	private uint <ExhibitDate>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <ExhibitorId>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <ExhibitorName>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <PurchaserId>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <Price>k__BackingField; // 0x44
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x48
	[CompilerGenerated]
	private DateTime <UpdateDate>k__BackingField; // 0x50
	[CompilerGenerated]
	private MarketItemDatav2 <ItemData>k__BackingField; // 0x58

	// Properties
	public long Id { get; set; }
	public byte WorldType { get; set; }
	[CLSCompliant(False)]
	public uint ExhibitDate { get; set; }
	public int ExhibitorId { get; set; }
	public string ExhibitorName { get; set; }
	public int PurchaserId { get; set; }
	public int Price { get; set; }
	public byte State { get; set; }
	public DateTime UpdateDate { get; set; }
	public MarketItemDatav2 ItemData { get; set; }
	public byte ItemType { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35D048C Offset: 0x35CC48C VA: 0x35D048C
	public void .ctor() { }

	// RVA: 0x35D0494 Offset: 0x35CC494 VA: 0x35D0494
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35D049C Offset: 0x35CC49C VA: 0x35D049C
	public long get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35D04A4 Offset: 0x35CC4A4 VA: 0x35D04A4
	protected void set_Id(long value) { }

	[CompilerGenerated]
	// RVA: 0x35D04AC Offset: 0x35CC4AC VA: 0x35D04AC
	public byte get_WorldType() { }

	[CompilerGenerated]
	// RVA: 0x35D04B4 Offset: 0x35CC4B4 VA: 0x35D04B4
	protected void set_WorldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D04BC Offset: 0x35CC4BC VA: 0x35D04BC
	public uint get_ExhibitDate() { }

	[CompilerGenerated]
	// RVA: 0x35D04C4 Offset: 0x35CC4C4 VA: 0x35D04C4
	protected void set_ExhibitDate(uint value) { }

	[CompilerGenerated]
	// RVA: 0x35D04CC Offset: 0x35CC4CC VA: 0x35D04CC
	public int get_ExhibitorId() { }

	[CompilerGenerated]
	// RVA: 0x35D04D4 Offset: 0x35CC4D4 VA: 0x35D04D4
	protected void set_ExhibitorId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D04DC Offset: 0x35CC4DC VA: 0x35D04DC
	public string get_ExhibitorName() { }

	[CompilerGenerated]
	// RVA: 0x35D04E4 Offset: 0x35CC4E4 VA: 0x35D04E4
	protected void set_ExhibitorName(string value) { }

	[CompilerGenerated]
	// RVA: 0x35D04EC Offset: 0x35CC4EC VA: 0x35D04EC
	public int get_PurchaserId() { }

	[CompilerGenerated]
	// RVA: 0x35D04F4 Offset: 0x35CC4F4 VA: 0x35D04F4
	protected void set_PurchaserId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D04FC Offset: 0x35CC4FC VA: 0x35D04FC
	public int get_Price() { }

	[CompilerGenerated]
	// RVA: 0x35D0504 Offset: 0x35CC504 VA: 0x35D0504
	protected void set_Price(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D050C Offset: 0x35CC50C VA: 0x35D050C
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x35D0514 Offset: 0x35CC514 VA: 0x35D0514
	protected void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D051C Offset: 0x35CC51C VA: 0x35D051C
	public DateTime get_UpdateDate() { }

	[CompilerGenerated]
	// RVA: 0x35D0524 Offset: 0x35CC524 VA: 0x35D0524
	protected void set_UpdateDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x35D052C Offset: 0x35CC52C VA: 0x35D052C
	public MarketItemDatav2 get_ItemData() { }

	[CompilerGenerated]
	// RVA: 0x35D0534 Offset: 0x35CC534 VA: 0x35D0534
	protected void set_ItemData(MarketItemDatav2 value) { }

	// RVA: 0x35D053C Offset: 0x35CC53C VA: 0x35D053C
	public byte get_ItemType() { }

	// RVA: 0x35D0558 Offset: 0x35CC558 VA: 0x35D0558 Slot: 3
	public override string ToString() { }

	// RVA: 0x35D0840 Offset: 0x35CC840 VA: 0x35D0840 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35D0848 Offset: 0x35CC848 VA: 0x35D0848 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35D0E1C Offset: 0x35CCE1C VA: 0x35D0E1C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
