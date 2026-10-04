// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room
public class RoomSecondPartyLeaveEvent : EventSubBase // TypeDefIndex: 12744
{
	// Fields
	[CompilerGenerated]
	private int <TeamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private RaidRoomSetting <Setting>k__BackingField; // 0x28
	[CompilerGenerated]
	private int[] <NpcIds>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public int TeamId { get; set; }
	public RaidRoomSetting Setting { get; set; }
	public int[] NpcIds { get; set; }

	// Methods

	// RVA: 0x364F104 Offset: 0x364B104 VA: 0x364F104
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x364F10C Offset: 0x364B10C VA: 0x364F10C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364F114 Offset: 0x364B114 VA: 0x364F114 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x364F11C Offset: 0x364B11C VA: 0x364F11C
	public int get_TeamId() { }

	[CompilerGenerated]
	// RVA: 0x364F124 Offset: 0x364B124 VA: 0x364F124
	public void set_TeamId(int value) { }

	[CompilerGenerated]
	// RVA: 0x364F12C Offset: 0x364B12C VA: 0x364F12C
	public RaidRoomSetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x364F134 Offset: 0x364B134 VA: 0x364F134
	public void set_Setting(RaidRoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x364F13C Offset: 0x364B13C VA: 0x364F13C
	public int[] get_NpcIds() { }

	[CompilerGenerated]
	// RVA: 0x364F144 Offset: 0x364B144 VA: 0x364F144
	public void set_NpcIds(int[] value) { }

	// RVA: 0x364F14C Offset: 0x364B14C VA: 0x364F14C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364F3BC Offset: 0x364B3BC VA: 0x364F3BC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
