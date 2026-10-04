// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class LoginStampRewardResponse : PacketBase // TypeDefIndex: 12081
{
	// Fields
	[CompilerGenerated]
	private StampCardData <RewardCard>k__BackingField; // 0x20
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x28

	// Properties
	public StampCardData RewardCard { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3783578 Offset: 0x377F578 VA: 0x3783578
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3783580 Offset: 0x377F580 VA: 0x3783580
	public StampCardData get_RewardCard() { }

	[CompilerGenerated]
	// RVA: 0x3783588 Offset: 0x377F588 VA: 0x3783588
	public void set_RewardCard(StampCardData value) { }

	[CompilerGenerated]
	// RVA: 0x3783590 Offset: 0x377F590 VA: 0x3783590
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x3783598 Offset: 0x377F598 VA: 0x3783598
	public void set_Reward(RewardResponseDatav2 value) { }

	// RVA: 0x37835A0 Offset: 0x377F5A0 VA: 0x37835A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37835A8 Offset: 0x377F5A8 VA: 0x37835A8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x378380C Offset: 0x377F80C VA: 0x378380C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
