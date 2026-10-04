// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class WeeklyTrophyCheckRewardResponse : PacketBase // TypeDefIndex: 12094
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

	// RVA: 0x37860A0 Offset: 0x37820A0 VA: 0x37860A0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37860A8 Offset: 0x37820A8 VA: 0x37860A8
	public TrophyData get_TrophyData() { }

	[CompilerGenerated]
	// RVA: 0x37860B0 Offset: 0x37820B0 VA: 0x37860B0
	public void set_TrophyData(TrophyData value) { }

	[CompilerGenerated]
	// RVA: 0x37860B8 Offset: 0x37820B8 VA: 0x37860B8
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x37860C0 Offset: 0x37820C0 VA: 0x37860C0
	public void set_Reward(RewardResponseDatav2 value) { }

	// RVA: 0x37860C8 Offset: 0x37820C8 VA: 0x37860C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37860D0 Offset: 0x37820D0 VA: 0x37860D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3786334 Offset: 0x3782334 VA: 0x3786334 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
