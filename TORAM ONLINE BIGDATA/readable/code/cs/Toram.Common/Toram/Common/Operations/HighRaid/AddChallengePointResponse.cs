// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.HighRaid
public class AddChallengePointResponse : OperationResponseBase // TypeDefIndex: 11554
{
	// Fields
	[CompilerGenerated]
	private byte <Point>k__BackingField; // 0x20
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x28

	// Properties
	public byte Point { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3719870 Offset: 0x3715870 VA: 0x3719870
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3719878 Offset: 0x3715878 VA: 0x3719878
	public byte get_Point() { }

	[CompilerGenerated]
	// RVA: 0x3719880 Offset: 0x3715880 VA: 0x3719880
	public void set_Point(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3719888 Offset: 0x3715888 VA: 0x3719888
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x3719890 Offset: 0x3715890 VA: 0x3719890
	public void set_Reward(RewardResponseDatav2 value) { }

	// RVA: 0x3719898 Offset: 0x3715898 VA: 0x3719898 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37198A0 Offset: 0x37158A0 VA: 0x37198A0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37198A8 Offset: 0x37158A8 VA: 0x37198A8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3719970 Offset: 0x3715970 VA: 0x3719970 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
