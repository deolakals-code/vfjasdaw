// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.MiniGame
public class DailyDartsGameRewardItemResponse : OperationRequestBase // TypeDefIndex: 12002
{
	// Fields
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x20

	// Properties
	public RewardResponseDatav2 Reward { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3774B30 Offset: 0x3770B30 VA: 0x3774B30
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3774B38 Offset: 0x3770B38 VA: 0x3774B38
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x3774B40 Offset: 0x3770B40 VA: 0x3774B40
	public void set_Reward(RewardResponseDatav2 value) { }

	// RVA: 0x3774B48 Offset: 0x3770B48 VA: 0x3774B48 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3774B50 Offset: 0x3770B50 VA: 0x3774B50 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3774B58 Offset: 0x3770B58 VA: 0x3774B58 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3774C74 Offset: 0x3770C74 VA: 0x3774C74 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
