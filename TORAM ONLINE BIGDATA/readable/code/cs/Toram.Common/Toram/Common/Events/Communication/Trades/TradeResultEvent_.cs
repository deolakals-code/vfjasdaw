// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Trades
public class TradeResultEvent_ : EventSubBase // TypeDefIndex: 12896
{
	// Fields
	[CompilerGenerated]
	private int <MemberId>k__BackingField; // 0x20
	[CompilerGenerated]
	private TradeData_ <PassTradeData>k__BackingField; // 0x28
	[CompilerGenerated]
	private TradeData_ <GetTradeData>k__BackingField; // 0x30
	[CompilerGenerated]
	private ItemDatav2[] <Items>k__BackingField; // 0x38
	[CompilerGenerated]
	private WarrantyItemDatav2[] <Warranties>k__BackingField; // 0x40
	[CompilerGenerated]
	private StarGemData[] <StarGems>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x50

	// Properties
	public int MemberId { get; set; }
	public TradeData_ PassTradeData { get; set; }
	public TradeData_ GetTradeData { get; set; }
	public ItemDatav2[] Items { get; set; }
	public WarrantyItemDatav2[] Warranties { get; set; }
	public StarGemData[] StarGems { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3671830 Offset: 0x366D830 VA: 0x3671830
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3671838 Offset: 0x366D838 VA: 0x3671838
	public int get_MemberId() { }

	[CompilerGenerated]
	// RVA: 0x3671840 Offset: 0x366D840 VA: 0x3671840
	public void set_MemberId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3671848 Offset: 0x366D848 VA: 0x3671848
	public TradeData_ get_PassTradeData() { }

	[CompilerGenerated]
	// RVA: 0x3671850 Offset: 0x366D850 VA: 0x3671850
	public void set_PassTradeData(TradeData_ value) { }

	[CompilerGenerated]
	// RVA: 0x3671858 Offset: 0x366D858 VA: 0x3671858
	public TradeData_ get_GetTradeData() { }

	[CompilerGenerated]
	// RVA: 0x3671860 Offset: 0x366D860 VA: 0x3671860
	public void set_GetTradeData(TradeData_ value) { }

	[CompilerGenerated]
	// RVA: 0x3671868 Offset: 0x366D868 VA: 0x3671868
	public ItemDatav2[] get_Items() { }

	[CompilerGenerated]
	// RVA: 0x3671870 Offset: 0x366D870 VA: 0x3671870
	public void set_Items(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3671878 Offset: 0x366D878 VA: 0x3671878
	public WarrantyItemDatav2[] get_Warranties() { }

	[CompilerGenerated]
	// RVA: 0x3671880 Offset: 0x366D880 VA: 0x3671880
	public void set_Warranties(WarrantyItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3671888 Offset: 0x366D888 VA: 0x3671888
	public StarGemData[] get_StarGems() { }

	[CompilerGenerated]
	// RVA: 0x3671890 Offset: 0x366D890 VA: 0x3671890
	public void set_StarGems(StarGemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3671898 Offset: 0x366D898 VA: 0x3671898
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x36718A0 Offset: 0x366D8A0 VA: 0x36718A0
	public void set_Gold(int value) { }

	// RVA: 0x36718A8 Offset: 0x366D8A8 VA: 0x36718A8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36718B0 Offset: 0x366D8B0 VA: 0x36718B0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36718B8 Offset: 0x366D8B8 VA: 0x36718B8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3671A94 Offset: 0x366DA94 VA: 0x3671A94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
