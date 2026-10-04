// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Ranking.Defence
public class DefenceScoreRanking : OperationRequestBase // TypeDefIndex: 11454
{
	// Fields
	[CompilerGenerated]
	private byte <RankType>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 244)]
	public override byte SubCode { get; }
	public override byte Code { get; }
	[UnityHash(Code = 245, IsOptional = True)]
	public byte RankType { get; set; }

	// Methods

	// RVA: 0x370CC8C Offset: 0x3708C8C VA: 0x370CC8C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x370CC94 Offset: 0x3708C94 VA: 0x370CC94 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x370CC9C Offset: 0x3708C9C VA: 0x370CC9C
	public void set_RankType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x370CCA4 Offset: 0x3708CA4 VA: 0x370CCA4
	public byte get_RankType() { }

	// RVA: 0x370CCAC Offset: 0x3708CAC VA: 0x370CCAC
	public void .ctor() { }

	// RVA: 0x370CCB4 Offset: 0x3708CB4 VA: 0x370CCB4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x370CD54 Offset: 0x3708D54 VA: 0x370CD54 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
