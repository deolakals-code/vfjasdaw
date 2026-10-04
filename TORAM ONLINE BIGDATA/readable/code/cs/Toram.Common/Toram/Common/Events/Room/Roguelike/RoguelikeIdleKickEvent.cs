// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Roguelike
public class RoguelikeIdleKickEvent : EventSubBase // TypeDefIndex: 12806
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20

	// Properties
	public int ArchetypeId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365DFD0 Offset: 0x3659FD0 VA: 0x365DFD0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365DFD8 Offset: 0x3659FD8 VA: 0x365DFD8
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x365DFE0 Offset: 0x3659FE0 VA: 0x365DFE0
	public void set_ArchetypeId(int value) { }

	// RVA: 0x365DFE8 Offset: 0x3659FE8 VA: 0x365DFE8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365DFF0 Offset: 0x3659FF0 VA: 0x365DFF0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365DFF8 Offset: 0x3659FF8 VA: 0x365DFF8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x365E098 Offset: 0x365A098 VA: 0x365E098 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
