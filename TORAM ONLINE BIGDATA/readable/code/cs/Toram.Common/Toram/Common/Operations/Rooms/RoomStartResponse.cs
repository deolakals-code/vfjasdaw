// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomStartResponse : OperationResponseBase // TypeDefIndex: 11740
{
	// Fields
	[CompilerGenerated]
	private bool <IsMatching>k__BackingField; // 0x20
	[CompilerGenerated]
	private RaidRoomSetting <Setting>k__BackingField; // 0x28
	[CompilerGenerated]
	private int[] <NpcIds>k__BackingField; // 0x30
	[CompilerGenerated]
	private RoomSetting <RoomSetting>k__BackingField; // 0x38

	// Properties
	public bool IsMatching { get; set; }
	public RaidRoomSetting Setting { get; set; }
	public int[] NpcIds { get; set; }
	public RoomSetting RoomSetting { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373F604 Offset: 0x373B604 VA: 0x373F604
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373F60C Offset: 0x373B60C VA: 0x373F60C
	public bool get_IsMatching() { }

	[CompilerGenerated]
	// RVA: 0x373F614 Offset: 0x373B614 VA: 0x373F614
	public void set_IsMatching(bool value) { }

	[CompilerGenerated]
	// RVA: 0x373F620 Offset: 0x373B620 VA: 0x373F620
	public RaidRoomSetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x373F628 Offset: 0x373B628 VA: 0x373F628
	public void set_Setting(RaidRoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x373F630 Offset: 0x373B630 VA: 0x373F630
	public int[] get_NpcIds() { }

	[CompilerGenerated]
	// RVA: 0x373F638 Offset: 0x373B638 VA: 0x373F638
	public void set_NpcIds(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x373F640 Offset: 0x373B640 VA: 0x373F640
	public RoomSetting get_RoomSetting() { }

	[CompilerGenerated]
	// RVA: 0x373F648 Offset: 0x373B648 VA: 0x373F648
	public void set_RoomSetting(RoomSetting value) { }

	// RVA: 0x373F650 Offset: 0x373B650 VA: 0x373F650 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373F658 Offset: 0x373B658 VA: 0x373F658 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373F660 Offset: 0x373B660 VA: 0x373F660 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x373F990 Offset: 0x373B990 VA: 0x373F990 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
