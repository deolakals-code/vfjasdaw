// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.HighRaid
public class GetHighRaidPoint : OperationRequestBase // TypeDefIndex: 11559
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

	// RVA: 0x371A3CC Offset: 0x37163CC VA: 0x371A3CC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371A3D4 Offset: 0x37163D4 VA: 0x371A3D4
	public byte get_HighRaidNo() { }

	[CompilerGenerated]
	// RVA: 0x371A3DC Offset: 0x37163DC VA: 0x371A3DC
	public void set_HighRaidNo(byte value) { }

	// RVA: 0x371A3E4 Offset: 0x37163E4 VA: 0x371A3E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371A3EC Offset: 0x37163EC VA: 0x371A3EC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371A3F4 Offset: 0x37163F4 VA: 0x371A3F4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371A494 Offset: 0x3716494 VA: 0x371A494 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
