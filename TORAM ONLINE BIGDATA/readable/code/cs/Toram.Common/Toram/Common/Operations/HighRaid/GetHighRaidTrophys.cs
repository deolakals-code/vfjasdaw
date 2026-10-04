// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.HighRaid
public class GetHighRaidTrophys : OperationRequestBase // TypeDefIndex: 11562
{
	// Fields
	[CompilerGenerated]
	private byte <HighRaidNo>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 210)]
	public byte HighRaidNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371AB40 Offset: 0x3716B40 VA: 0x371AB40
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371AB48 Offset: 0x3716B48 VA: 0x371AB48
	public byte get_HighRaidNo() { }

	[CompilerGenerated]
	// RVA: 0x371AB50 Offset: 0x3716B50 VA: 0x371AB50
	public void set_HighRaidNo(byte value) { }

	// RVA: 0x371AB58 Offset: 0x3716B58 VA: 0x371AB58 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371AB60 Offset: 0x3716B60 VA: 0x371AB60 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371AB68 Offset: 0x3716B68 VA: 0x371AB68 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371AC08 Offset: 0x3716C08 VA: 0x371AC08 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
