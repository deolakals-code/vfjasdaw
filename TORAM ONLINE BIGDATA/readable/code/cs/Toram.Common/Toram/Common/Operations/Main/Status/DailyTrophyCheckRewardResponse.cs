// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class DailyTrophyCheckRewardResponse : PacketBase // TypeDefIndex: 12076
{
	// Fields
	[CompilerGenerated]
	private TrophyData <TrophyData>k__BackingField; // 0x20
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x28

	// Properties
	public TrophyData TrophyData { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3782794 Offset: 0x377E794 VA: 0x3782794
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378279C Offset: 0x377E79C VA: 0x378279C
	public TrophyData get_TrophyData() { }

	[CompilerGenerated]
	// RVA: 0x37827A4 Offset: 0x377E7A4 VA: 0x37827A4
	public void set_TrophyData(TrophyData value) { }

	[CompilerGenerated]
	// RVA: 0x37827AC Offset: 0x377E7AC VA: 0x37827AC
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x37827B4 Offset: 0x377E7B4 VA: 0x37827B4
	public void set_Reward(RewardResponseDatav2 value) { }

	// RVA: 0x37827BC Offset: 0x377E7BC VA: 0x37827BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37827C4 Offset: 0x377E7C4 VA: 0x37827C4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3782A28 Offset: 0x377EA28 VA: 0x3782A28 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
