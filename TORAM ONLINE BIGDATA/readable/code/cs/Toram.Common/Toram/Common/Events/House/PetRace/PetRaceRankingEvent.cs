// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.PetRace
public class PetRaceRankingEvent : EventSubBase // TypeDefIndex: 12827
{
	// Fields
	public Dictionary<int, int> GoalRanking; // 0x20
	public Dictionary<int, byte> NextCheckPoints; // 0x28
	[CompilerGenerated]
	private PetRaceRankingInfo[] <RankingInfo>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public PetRaceRankingInfo[] RankingInfo { get; set; }

	// Methods

	// RVA: 0x3661954 Offset: 0x365D954 VA: 0x3661954
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x366195C Offset: 0x365D95C VA: 0x366195C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3661964 Offset: 0x365D964 VA: 0x3661964 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x366196C Offset: 0x365D96C VA: 0x366196C
	public PetRaceRankingInfo[] get_RankingInfo() { }

	[CompilerGenerated]
	// RVA: 0x3661974 Offset: 0x365D974 VA: 0x3661974
	public void set_RankingInfo(PetRaceRankingInfo[] value) { }

	// RVA: 0x366197C Offset: 0x365D97C VA: 0x366197C
	public Dictionary<byte, int> GetRanking() { }

	// RVA: 0x3662AA4 Offset: 0x365EAA4 VA: 0x3662AA4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3662E78 Offset: 0x365EE78 VA: 0x3662E78 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
