// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Treasure
public class TreasureKeyInfoResponse : OperationResponseBase // TypeDefIndex: 11392
{
	// Fields
	[CompilerGenerated]
	private int <KeyNum>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <LapseSecond>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 253)]
	public int KeyNum { get; set; }
	[PacketParameter(Code = 172)]
	public int LapseSecond { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36FFEFC Offset: 0x36FBEFC VA: 0x36FFEFC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36FFF04 Offset: 0x36FBF04 VA: 0x36FFF04
	public int get_KeyNum() { }

	[CompilerGenerated]
	// RVA: 0x36FFF0C Offset: 0x36FBF0C VA: 0x36FFF0C
	public void set_KeyNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x36FFF14 Offset: 0x36FBF14 VA: 0x36FFF14
	public int get_LapseSecond() { }

	[CompilerGenerated]
	// RVA: 0x36FFF1C Offset: 0x36FBF1C VA: 0x36FFF1C
	public void set_LapseSecond(int value) { }

	// RVA: 0x36FFF24 Offset: 0x36FBF24 VA: 0x36FFF24 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FFF2C Offset: 0x36FBF2C VA: 0x36FFF2C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36FFF34 Offset: 0x36FBF34 VA: 0x36FFF34 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37000A0 Offset: 0x36FC0A0 VA: 0x37000A0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
