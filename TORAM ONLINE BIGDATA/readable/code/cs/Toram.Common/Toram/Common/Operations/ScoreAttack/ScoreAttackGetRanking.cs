// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.ScoreAttack
public class ScoreAttackGetRanking : OperationRequestBase // TypeDefIndex: 11731
{
	// Fields
	[CompilerGenerated]
	private byte <Week>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RotationId>k__BackingField; // 0x21
	[CompilerGenerated]
	private byte <BossId>k__BackingField; // 0x22
	[CompilerGenerated]
	private byte <RankingType>k__BackingField; // 0x23

	// Properties
	[PacketParameter(Code = 36)]
	public byte Week { get; set; }
	[PacketParameter(Code = 37)]
	public byte RotationId { get; set; }
	[PacketParameter(Code = 38)]
	public byte BossId { get; set; }
	[PacketParameter(Code = 39)]
	public byte RankingType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373DDE4 Offset: 0x3739DE4 VA: 0x373DDE4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x373DDEC Offset: 0x3739DEC VA: 0x373DDEC
	public byte get_Week() { }

	[CompilerGenerated]
	// RVA: 0x373DDF4 Offset: 0x3739DF4 VA: 0x373DDF4
	public void set_Week(byte value) { }

	[CompilerGenerated]
	// RVA: 0x373DDFC Offset: 0x3739DFC VA: 0x373DDFC
	public byte get_RotationId() { }

	[CompilerGenerated]
	// RVA: 0x373DE04 Offset: 0x3739E04 VA: 0x373DE04
	public void set_RotationId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x373DE0C Offset: 0x3739E0C VA: 0x373DE0C
	public byte get_BossId() { }

	[CompilerGenerated]
	// RVA: 0x373DE14 Offset: 0x3739E14 VA: 0x373DE14
	public void set_BossId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x373DE1C Offset: 0x3739E1C VA: 0x373DE1C
	public byte get_RankingType() { }

	[CompilerGenerated]
	// RVA: 0x373DE24 Offset: 0x3739E24 VA: 0x373DE24
	public void set_RankingType(byte value) { }

	// RVA: 0x373DE2C Offset: 0x3739E2C VA: 0x373DE2C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373DE34 Offset: 0x3739E34 VA: 0x373DE34 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373DE3C Offset: 0x3739E3C VA: 0x373DE3C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373DF5C Offset: 0x3739F5C VA: 0x373DF5C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
