// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Ranking.Defence
public class DefenceCurrentScoreResponse : OperationResponseBase // TypeDefIndex: 11451
{
	// Fields
	[CompilerGenerated]
	private byte <RankType>k__BackingField; // 0x20
	[CompilerGenerated]
	private DefenceRankingData[] <ScoreData>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketParameter(Code = 245)]
	public byte RankType { get; set; }
	[PacketParameter(Code = 199)]
	public DefenceRankingData[] ScoreData { get; set; }

	// Methods

	// RVA: 0x370C7C0 Offset: 0x37087C0 VA: 0x370C7C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370C7C8 Offset: 0x37087C8 VA: 0x370C7C8 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x370C7D0 Offset: 0x37087D0 VA: 0x370C7D0
	public byte get_RankType() { }

	[CompilerGenerated]
	// RVA: 0x370C7D8 Offset: 0x37087D8 VA: 0x370C7D8
	public void set_RankType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x370C7E0 Offset: 0x37087E0 VA: 0x370C7E0
	public DefenceRankingData[] get_ScoreData() { }

	[CompilerGenerated]
	// RVA: 0x370C7E8 Offset: 0x37087E8 VA: 0x370C7E8
	public void set_ScoreData(DefenceRankingData[] value) { }

	// RVA: 0x370C7F0 Offset: 0x37087F0 VA: 0x370C7F0
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x370C7F8 Offset: 0x37087F8 VA: 0x370C7F8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370C9C8 Offset: 0x37089C8 VA: 0x370C9C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
