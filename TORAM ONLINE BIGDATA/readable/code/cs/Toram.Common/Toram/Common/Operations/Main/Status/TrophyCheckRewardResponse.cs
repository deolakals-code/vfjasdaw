// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class TrophyCheckRewardResponse : PacketBase // TypeDefIndex: 12092
{
	// Fields
	[CompilerGenerated]
	private int <TrophyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public int TrophyId { get; set; }
	public RewardResponseDatav2 Reward { get; set; }

	// Methods

	// RVA: 0x3785B6C Offset: 0x3781B6C VA: 0x3785B6C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3785B74 Offset: 0x3781B74 VA: 0x3785B74 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3785B7C Offset: 0x3781B7C VA: 0x3785B7C
	public int get_TrophyId() { }

	[CompilerGenerated]
	// RVA: 0x3785B84 Offset: 0x3781B84 VA: 0x3785B84
	public void set_TrophyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3785B8C Offset: 0x3781B8C VA: 0x3785B8C
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x3785B94 Offset: 0x3781B94 VA: 0x3785B94
	public void set_Reward(RewardResponseDatav2 value) { }

	// RVA: 0x3785B9C Offset: 0x3781B9C VA: 0x3785B9C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3785D90 Offset: 0x3781D90 VA: 0x3785D90 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
