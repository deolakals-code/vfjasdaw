// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.HighRaid
public class GetChallengePointResponse : OperationResponseBase // TypeDefIndex: 11556
{
	// Fields
	[CompilerGenerated]
	private byte <Point>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Count>k__BackingField; // 0x21
	[CompilerGenerated]
	private byte <MaterialIndex>k__BackingField; // 0x22

	// Properties
	[PacketParameter(Code = 205)]
	public byte Point { get; set; }
	[PacketParameter(Code = 21)]
	public byte Count { get; set; }
	[PacketParameter(Code = 146)]
	public byte MaterialIndex { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3719B94 Offset: 0x3715B94 VA: 0x3719B94
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3719B9C Offset: 0x3715B9C VA: 0x3719B9C
	public byte get_Point() { }

	[CompilerGenerated]
	// RVA: 0x3719BA4 Offset: 0x3715BA4 VA: 0x3719BA4
	public void set_Point(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3719BAC Offset: 0x3715BAC VA: 0x3719BAC
	public byte get_Count() { }

	[CompilerGenerated]
	// RVA: 0x3719BB4 Offset: 0x3715BB4 VA: 0x3719BB4
	public void set_Count(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3719BBC Offset: 0x3715BBC VA: 0x3719BBC
	public byte get_MaterialIndex() { }

	[CompilerGenerated]
	// RVA: 0x3719BC4 Offset: 0x3715BC4 VA: 0x3719BC4
	public void set_MaterialIndex(byte value) { }

	// RVA: 0x3719BCC Offset: 0x3715BCC VA: 0x3719BCC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3719BD4 Offset: 0x3715BD4 VA: 0x3719BD4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3719BDC Offset: 0x3715BDC VA: 0x3719BDC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3719CD4 Offset: 0x3715CD4 VA: 0x3719CD4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
