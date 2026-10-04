// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Events
public class BCollaborationMatchingStartEvent : EventSubBase // TypeDefIndex: 13074
{
	// Fields
	[CompilerGenerated]
	private int <Time>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public int Time { get; set; }

	// Methods

	// RVA: 0x369D340 Offset: 0x3699340 VA: 0x369D340
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x369D348 Offset: 0x3699348 VA: 0x369D348 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369D350 Offset: 0x3699350 VA: 0x369D350 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x369D358 Offset: 0x3699358 VA: 0x369D358
	public int get_Time() { }

	[CompilerGenerated]
	// RVA: 0x369D360 Offset: 0x3699360 VA: 0x369D360
	public void set_Time(int value) { }

	// RVA: 0x369D368 Offset: 0x3699368 VA: 0x369D368 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x369D488 Offset: 0x3699488 VA: 0x369D488 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
