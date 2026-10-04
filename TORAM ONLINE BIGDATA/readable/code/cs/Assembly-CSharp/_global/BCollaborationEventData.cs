// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BCollaborationEventData : GameEventDataBase // TypeDefIndex: 1831
{
	// Fields
	[TupleElementNames(new[] { "Value", "AddPoint", "MaxCount" })]
	public static Dictionary<byte, ValueTuple<short, int, int>> WeeklyRewardInfo; // 0x0
	[CompilerGenerated]
	private List<BCRankingData> <RankingDataList>k__BackingField; // 0x18
	private BCollaborationEventData eventData; // 0x20

	// Properties
	public override byte GameEventType { get; }
	public BCollaborationEventData EventData { get; }
	public List<BCRankingData> RankingDataList { get; set; }
	public static int GetMyTargetDamage { get; }

	// Methods

	// RVA: 0x20EB400 Offset: 0x20E7400 VA: 0x20EB400 Slot: 4
	public override byte get_GameEventType() { }

	// RVA: 0x20EB408 Offset: 0x20E7408 VA: 0x20EB408
	public BCollaborationEventData get_EventData() { }

	[CompilerGenerated]
	// RVA: 0x20EB410 Offset: 0x20E7410 VA: 0x20EB410
	public List<BCRankingData> get_RankingDataList() { }

	[CompilerGenerated]
	// RVA: 0x20EB418 Offset: 0x20E7418 VA: 0x20EB418
	private void set_RankingDataList(List<BCRankingData> value) { }

	// RVA: 0x20EB420 Offset: 0x20E7420 VA: 0x20EB420 Slot: 7
	public override void Clear() { }

	// RVA: 0x20EB424 Offset: 0x20E7424 VA: 0x20EB424 Slot: 5
	public override void Initialize(byte[] binary) { }

	// RVA: 0x20EB4A8 Offset: 0x20E74A8 VA: 0x20EB4A8 Slot: 8
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x20EB4AC Offset: 0x20E74AC VA: 0x20EB4AC
	public static int get_GetMyTargetDamage() { }

	// RVA: 0x20EB56C Offset: 0x20E756C VA: 0x20EB56C
	public void SetRankingData(BCollaborationGetRankingResponse responseData) { }

	// RVA: 0x20EB68C Offset: 0x20E768C VA: 0x20EB68C
	public BCRankingData GetRankingData(BCRankingItemType mainWeapon, BCRankingItemType subWeapon) { }

	// RVA: 0x20EB848 Offset: 0x20E7848 VA: 0x20EB848
	public void .ctor() { }

	// RVA: 0x20EB8D8 Offset: 0x20E78D8 VA: 0x20EB8D8
	private static void .cctor() { }
}
