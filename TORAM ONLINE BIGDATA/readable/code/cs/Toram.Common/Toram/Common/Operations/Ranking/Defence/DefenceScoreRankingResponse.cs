// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Ranking.Defence
public class DefenceScoreRankingResponse : OperationResponseBase // TypeDefIndex: 11455
{
	// Fields
	[CompilerGenerated]
	private DefenceRankingData[] <RankingData>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketParameter(Code = 199)]
	public DefenceRankingData[] RankingData { get; set; }

	// Methods

	// RVA: 0x370CEA0 Offset: 0x3708EA0 VA: 0x370CEA0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370CEA8 Offset: 0x3708EA8 VA: 0x370CEA8 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x370CEB0 Offset: 0x3708EB0 VA: 0x370CEB0
	public DefenceRankingData[] get_RankingData() { }

	[CompilerGenerated]
	// RVA: 0x370CEB8 Offset: 0x3708EB8 VA: 0x370CEB8
	public void set_RankingData(DefenceRankingData[] value) { }

	// RVA: 0x370CEC0 Offset: 0x3708EC0 VA: 0x370CEC0
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x370CEC8 Offset: 0x3708EC8 VA: 0x370CEC8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370D040 Offset: 0x3709040 VA: 0x370D040 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
