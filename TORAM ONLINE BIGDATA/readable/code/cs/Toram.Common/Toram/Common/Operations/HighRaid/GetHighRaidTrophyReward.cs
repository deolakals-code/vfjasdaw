// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.HighRaid
public class GetHighRaidTrophyReward : OperationRequestBase // TypeDefIndex: 11561
{
	// Fields
	[CompilerGenerated]
	private byte <HighRaidNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <TrophyId>k__BackingField; // 0x21

	// Properties
	[PacketParameter(Code = 210)]
	public byte HighRaidNo { get; set; }
	[PacketParameter(Code = 200)]
	public byte TrophyId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371A8D4 Offset: 0x37168D4 VA: 0x371A8D4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371A8DC Offset: 0x37168DC VA: 0x371A8DC
	public byte get_HighRaidNo() { }

	[CompilerGenerated]
	// RVA: 0x371A8E4 Offset: 0x37168E4 VA: 0x371A8E4
	public void set_HighRaidNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371A8EC Offset: 0x37168EC VA: 0x371A8EC
	public byte get_TrophyId() { }

	[CompilerGenerated]
	// RVA: 0x371A8F4 Offset: 0x37168F4 VA: 0x371A8F4
	public void set_TrophyId(byte value) { }

	// RVA: 0x371A8FC Offset: 0x37168FC VA: 0x371A8FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371A904 Offset: 0x3716904 VA: 0x371A904 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371A90C Offset: 0x371690C VA: 0x371A90C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371A9D4 Offset: 0x37169D4 VA: 0x371A9D4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
