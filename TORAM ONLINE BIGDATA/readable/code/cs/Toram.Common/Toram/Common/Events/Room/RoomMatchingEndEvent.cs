// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room
public class RoomMatchingEndEvent : EventSubBase // TypeDefIndex: 12742
{
	// Fields
	[CompilerGenerated]
	private RaidRoomSetting <Setting>k__BackingField; // 0x20
	[CompilerGenerated]
	private int[] <NpcIds>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public RaidRoomSetting Setting { get; set; }
	public int[] NpcIds { get; set; }

	// Methods

	// RVA: 0x364E770 Offset: 0x364A770 VA: 0x364E770
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x364E778 Offset: 0x364A778 VA: 0x364E778 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364E780 Offset: 0x364A780 VA: 0x364E780 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x364E788 Offset: 0x364A788 VA: 0x364E788
	public RaidRoomSetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x364E790 Offset: 0x364A790 VA: 0x364E790
	public void set_Setting(RaidRoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x364E798 Offset: 0x364A798 VA: 0x364E798
	public int[] get_NpcIds() { }

	[CompilerGenerated]
	// RVA: 0x364E7A0 Offset: 0x364A7A0 VA: 0x364E7A0
	public void set_NpcIds(int[] value) { }

	// RVA: 0x364E7A8 Offset: 0x364A7A8 VA: 0x364E7A8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364E9C8 Offset: 0x364A9C8 VA: 0x364E9C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
