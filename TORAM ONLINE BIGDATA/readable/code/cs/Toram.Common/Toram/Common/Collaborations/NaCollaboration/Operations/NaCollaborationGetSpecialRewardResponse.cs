// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NaCollaboration.Operations
public class NaCollaborationGetSpecialRewardResponse : OperationResponseBase // TypeDefIndex: 13087
{
	// Fields
	[CompilerGenerated]
	private RewardResponseDatav2 <RewardData>k__BackingField; // 0x20

	// Properties
	public RewardResponseDatav2 RewardData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36A086C Offset: 0x369C86C VA: 0x36A086C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36A0874 Offset: 0x369C874 VA: 0x36A0874
	public RewardResponseDatav2 get_RewardData() { }

	[CompilerGenerated]
	// RVA: 0x36A087C Offset: 0x369C87C VA: 0x36A087C
	public void set_RewardData(RewardResponseDatav2 value) { }

	// RVA: 0x36A0884 Offset: 0x369C884 VA: 0x36A0884 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36A088C Offset: 0x369C88C VA: 0x36A088C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36A0894 Offset: 0x369C894 VA: 0x36A0894 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36A0A30 Offset: 0x369CA30 VA: 0x36A0A30 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
