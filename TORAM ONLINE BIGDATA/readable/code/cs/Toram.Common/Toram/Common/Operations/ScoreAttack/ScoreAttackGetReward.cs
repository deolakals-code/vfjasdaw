// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.ScoreAttack
public class ScoreAttackGetReward : OperationRequestBase // TypeDefIndex: 11730
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

	// RVA: 0x373DA78 Offset: 0x3739A78 VA: 0x373DA78
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x373DA80 Offset: 0x3739A80 VA: 0x373DA80
	public byte get_Week() { }

	[CompilerGenerated]
	// RVA: 0x373DA88 Offset: 0x3739A88 VA: 0x373DA88
	public void set_Week(byte value) { }

	[CompilerGenerated]
	// RVA: 0x373DA90 Offset: 0x3739A90 VA: 0x373DA90
	public byte get_RotationId() { }

	[CompilerGenerated]
	// RVA: 0x373DA98 Offset: 0x3739A98 VA: 0x373DA98
	public void set_RotationId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x373DAA0 Offset: 0x3739AA0 VA: 0x373DAA0
	public byte get_BossId() { }

	[CompilerGenerated]
	// RVA: 0x373DAA8 Offset: 0x3739AA8 VA: 0x373DAA8
	public void set_BossId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x373DAB0 Offset: 0x3739AB0 VA: 0x373DAB0
	public byte get_RankingType() { }

	[CompilerGenerated]
	// RVA: 0x373DAB8 Offset: 0x3739AB8 VA: 0x373DAB8
	public void set_RankingType(byte value) { }

	// RVA: 0x373DAC0 Offset: 0x3739AC0 VA: 0x373DAC0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373DAC8 Offset: 0x3739AC8 VA: 0x373DAC8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373DAD0 Offset: 0x3739AD0 VA: 0x373DAD0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373DBF0 Offset: 0x3739BF0 VA: 0x373DBF0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
