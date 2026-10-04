// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class ProcessFishingFish : OperationRequestBase // TypeDefIndex: 11661
{
	// Fields
	[CompilerGenerated]
	private short[] <IndexList>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 15)]
	public short[] IndexList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372D050 Offset: 0x3729050 VA: 0x372D050
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372D058 Offset: 0x3729058 VA: 0x372D058
	public short[] get_IndexList() { }

	[CompilerGenerated]
	// RVA: 0x372D060 Offset: 0x3729060 VA: 0x372D060
	public void set_IndexList(short[] value) { }

	// RVA: 0x372D068 Offset: 0x3729068 VA: 0x372D068 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372D070 Offset: 0x3729070 VA: 0x372D070 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372D078 Offset: 0x3729078 VA: 0x372D078 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372D0E4 Offset: 0x37290E4 VA: 0x372D0E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
