// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Roguelike
public class RoguelikeResultEvent : EventSubBase // TypeDefIndex: 12809
{
	// Fields
	[CompilerGenerated]
	private bool <IsSuccess>k__BackingField; // 0x20
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x28

	// Properties
	public bool IsSuccess { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365E82C Offset: 0x365A82C VA: 0x365E82C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365E834 Offset: 0x365A834 VA: 0x365E834
	public bool get_IsSuccess() { }

	[CompilerGenerated]
	// RVA: 0x365E83C Offset: 0x365A83C VA: 0x365E83C
	public void set_IsSuccess(bool value) { }

	[CompilerGenerated]
	// RVA: 0x365E848 Offset: 0x365A848 VA: 0x365E848
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x365E850 Offset: 0x365A850 VA: 0x365E850
	public void set_Reward(RewardResponseDatav2 value) { }

	// RVA: 0x365E858 Offset: 0x365A858 VA: 0x365E858 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365E860 Offset: 0x365A860 VA: 0x365E860 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365E868 Offset: 0x365A868 VA: 0x365E868 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x365E93C Offset: 0x365A93C VA: 0x365E93C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
