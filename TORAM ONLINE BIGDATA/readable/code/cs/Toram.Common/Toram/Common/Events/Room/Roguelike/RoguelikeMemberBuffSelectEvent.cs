// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Roguelike
public class RoguelikeMemberBuffSelectEvent : EventSubBase // TypeDefIndex: 12808
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private Tuple<short, short>[] <SelectedBuffs>k__BackingField; // 0x28

	// Properties
	public int ArchetypeId { get; set; }
	public Tuple<short, short>[] SelectedBuffs { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365E1B8 Offset: 0x365A1B8 VA: 0x365E1B8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365E1C0 Offset: 0x365A1C0 VA: 0x365E1C0
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x365E1C8 Offset: 0x365A1C8 VA: 0x365E1C8
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x365E1D0 Offset: 0x365A1D0 VA: 0x365E1D0
	public Tuple<short, short>[] get_SelectedBuffs() { }

	[CompilerGenerated]
	// RVA: 0x365E1D8 Offset: 0x365A1D8 VA: 0x365E1D8
	public void set_SelectedBuffs(Tuple<short, short>[] value) { }

	// RVA: 0x365E1E0 Offset: 0x365A1E0 VA: 0x365E1E0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365E1E8 Offset: 0x365A1E8 VA: 0x365E1E8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365E1F0 Offset: 0x365A1F0 VA: 0x365E1F0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x365E42C Offset: 0x365A42C VA: 0x365E42C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
