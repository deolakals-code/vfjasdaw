// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Market
public class MarketSetupResponse : OperationResponseBase // TypeDefIndex: 11926
{
	// Fields
	[CompilerGenerated]
	private byte <MarketType>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <MarketId>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <SalesMax>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x34
	[CompilerGenerated]
	private byte <MarketServiceType>k__BackingField; // 0x36

	// Properties
	[PacketParameter(Code = 245)]
	public byte MarketType { get; set; }
	[PacketParameter(Code = 200)]
	public long MarketId { get; set; }
	[PacketParameter(Code = 195)]
	public int SalesMax { get; set; }
	[PacketParameter(Code = 81)]
	public short ReturnCode { get; set; }
	[PacketParameter(Code = 232)]
	public byte MarketServiceType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3767154 Offset: 0x3763154 VA: 0x3767154
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376715C Offset: 0x376315C VA: 0x376715C
	public byte get_MarketType() { }

	[CompilerGenerated]
	// RVA: 0x3767164 Offset: 0x3763164 VA: 0x3767164
	public void set_MarketType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376716C Offset: 0x376316C VA: 0x376716C
	public long get_MarketId() { }

	[CompilerGenerated]
	// RVA: 0x3767174 Offset: 0x3763174 VA: 0x3767174
	public void set_MarketId(long value) { }

	[CompilerGenerated]
	// RVA: 0x376717C Offset: 0x376317C VA: 0x376717C
	public int get_SalesMax() { }

	[CompilerGenerated]
	// RVA: 0x3767184 Offset: 0x3763184 VA: 0x3767184
	public void set_SalesMax(int value) { }

	[CompilerGenerated]
	// RVA: 0x376718C Offset: 0x376318C VA: 0x376718C
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3767194 Offset: 0x3763194 VA: 0x3767194
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x376719C Offset: 0x376319C VA: 0x376719C
	public byte get_MarketServiceType() { }

	[CompilerGenerated]
	// RVA: 0x37671A4 Offset: 0x37631A4 VA: 0x37671A4
	public void set_MarketServiceType(byte value) { }

	// RVA: 0x37671AC Offset: 0x37631AC VA: 0x37671AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37671B4 Offset: 0x37631B4 VA: 0x37671B4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37671BC Offset: 0x37631BC VA: 0x37671BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3767430 Offset: 0x3763430 VA: 0x3767430 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
