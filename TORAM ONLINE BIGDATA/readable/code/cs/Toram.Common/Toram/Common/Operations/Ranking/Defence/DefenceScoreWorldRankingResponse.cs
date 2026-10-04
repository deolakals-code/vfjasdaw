// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Ranking.Defence
public class DefenceScoreWorldRankingResponse : OperationResponseBase // TypeDefIndex: 11449
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

	// RVA: 0x370C560 Offset: 0x3708560 VA: 0x370C560 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370C568 Offset: 0x3708568 VA: 0x370C568 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x370C570 Offset: 0x3708570 VA: 0x370C570
	public DefenceRankingData[] get_RankingData() { }

	[CompilerGenerated]
	// RVA: 0x370C578 Offset: 0x3708578 VA: 0x370C578
	public void set_RankingData(DefenceRankingData[] value) { }

	// RVA: 0x370C580 Offset: 0x3708580 VA: 0x370C580
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x370C588 Offset: 0x3708588 VA: 0x370C588 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370C700 Offset: 0x3708700 VA: 0x370C700 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
