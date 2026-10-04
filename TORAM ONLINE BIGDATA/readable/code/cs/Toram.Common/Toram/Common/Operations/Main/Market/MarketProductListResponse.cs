// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Market
public class MarketProductListResponse : OperationResponseBase // TypeDefIndex: 11920
{
	// Fields
	[CompilerGenerated]
	private byte <MarketType>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ItemType>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <ViewType>k__BackingField; // 0x28
	[CompilerGenerated]
	private MarketStoreData <MarketStore>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 232)]
	public byte MarketType { get; set; }
	[PacketParameter(Code = 245)]
	public byte ItemType { get; set; }
	[PacketParameter(Code = 91)]
	public int ItemId { get; set; }
	[PacketParameter(Code = 82)]
	public byte ViewType { get; set; }
	[PacketParameter(Code = 199, IsOptional = True)]
	public MarketStoreData MarketStore { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3765664 Offset: 0x3761664 VA: 0x3765664
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376566C Offset: 0x376166C VA: 0x376566C
	public byte get_MarketType() { }

	[CompilerGenerated]
	// RVA: 0x3765674 Offset: 0x3761674 VA: 0x3765674
	public void set_MarketType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376567C Offset: 0x376167C VA: 0x376567C
	public byte get_ItemType() { }

	[CompilerGenerated]
	// RVA: 0x3765684 Offset: 0x3761684 VA: 0x3765684
	public void set_ItemType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376568C Offset: 0x376168C VA: 0x376568C
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3765694 Offset: 0x3761694 VA: 0x3765694
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x376569C Offset: 0x376169C VA: 0x376569C
	public byte get_ViewType() { }

	[CompilerGenerated]
	// RVA: 0x37656A4 Offset: 0x37616A4 VA: 0x37656A4
	public void set_ViewType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37656AC Offset: 0x37616AC VA: 0x37656AC
	public MarketStoreData get_MarketStore() { }

	[CompilerGenerated]
	// RVA: 0x37656B4 Offset: 0x37616B4 VA: 0x37656B4
	public void set_MarketStore(MarketStoreData value) { }

	// RVA: 0x37656BC Offset: 0x37616BC VA: 0x37656BC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37657DC Offset: 0x37617DC VA: 0x37657DC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3765858 Offset: 0x3761858 VA: 0x3765858 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3765860 Offset: 0x3761860 VA: 0x3765860 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3765868 Offset: 0x3761868 VA: 0x3765868 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3765A80 Offset: 0x3761A80 VA: 0x3765A80 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
