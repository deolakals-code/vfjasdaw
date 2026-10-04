// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room
public class RoomBattleReadyEvent : PacketBase // TypeDefIndex: 12749
{
	// Fields
	[CompilerGenerated]
	private RoomSetting <RoomSetting>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 187, IsOptional = True)]
	public RoomSetting RoomSetting { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36503BC Offset: 0x364C3BC VA: 0x36503BC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36503C4 Offset: 0x364C3C4 VA: 0x36503C4
	public RoomSetting get_RoomSetting() { }

	[CompilerGenerated]
	// RVA: 0x36503CC Offset: 0x364C3CC VA: 0x36503CC
	public void set_RoomSetting(RoomSetting value) { }

	// RVA: 0x36503D4 Offset: 0x364C3D4 VA: 0x36503D4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36504F4 Offset: 0x364C4F4 VA: 0x36504F4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3650570 Offset: 0x364C570 VA: 0x3650570 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3650578 Offset: 0x364C578 VA: 0x3650578 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3650610 Offset: 0x364C610 VA: 0x3650610 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
